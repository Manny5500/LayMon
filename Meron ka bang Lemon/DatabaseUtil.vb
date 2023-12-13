Imports System.Data.SQLite
Public Class DatabaseUtil
    Dim connectionString As String = "Data Source=mydatabase.db;Version=3;"
    Dim conn As SQLiteConnection
    Dim SQL As String
    Dim myCommand As New SQLiteCommand
    Dim myAdapter As New SQLiteDataAdapter
    Dim myData As New DataTable
    Dim tableStyle As New UIStyle()


    Sub Data_Load(ByVal data As String, ByVal table As DataGridView)
        conn = New SQLiteConnection()
        conn.ConnectionString = "Data Source=mydatabase.db;Version=3;"
        Try
            myData.Clear()
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = data
            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)

            With table
                .DataSource = myData
            End With
            conn.Close()
        Catch myerror As Exception
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
        tableStyle.TableStyle(table)
    End Sub
    Sub Query(ByVal data As String, ByVal selectAll As String, ByVal table As DataGridView, ByVal type As String)
        conn = New SQLiteConnection()
        conn.ConnectionString = "Data Source=mydatabase.db;Version=3;"
        Try
            conn.Open()
            SQL = data
            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()
            Data_Load(selectAll, table)
            MessageBox.Show("" & type & " Successfully")
        Catch myerror As Exception
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Public Sub CreateDatabaseAndTable()
        ' Create a new SQLite database file
        SQLiteConnection.CreateFile("mydatabase.db")
        ' Open a connection to the database
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            ' Create a table
            Using command As New SQLiteCommand(connection)
                command.CommandText = "CREATE TABLE IF NOT EXISTS MyTable (ID INTEGER PRIMARY KEY AUTOINCREMENT, 
                Name TEXT, Desc TEXT, Price INTEGER);"
                command.ExecuteNonQuery()
                command.CommandText = "INSERT INTO MyTable (Name, Desc, Price) VALUES('chakie', 'Chakay Kikay', 2500);"
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub FetchData()
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Using command As New SQLiteCommand("SELECT * FROM MyTable;", connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Retrieve data from columns
                        Dim id As Integer = reader.GetInt32(0)
                        Dim name As String = reader.GetString(1)
                    End While
                End Using
            End Using
            connection.Close()
        End Using
    End Sub
End Class
