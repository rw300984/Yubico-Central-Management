Imports System.Data.SQLite
Module db
    Public Function ExecuteNonQuery(ByVal database As String, ByVal statement As String) As Boolean
        Try
            Dim result As Boolean = False
            Dim SQLitecon As New SQLiteConnection("Data Source=database\data.db")
            Dim SQLitecmd As New SQLiteCommand(statement, SQLitecon)
            SQLitecon.Open()
            If SQLitecon.State = ConnectionState.Open Then
                Dim rows As Integer = SQLitecmd.ExecuteNonQuery
                If rows > 0 Then
                    result = True
                Else
                    result = False
                End If
            Else
                result = False
            End If
            SQLitecon.Close()
            SQLitecon.Dispose()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function ExecuteScalar(ByVal database As String, ByVal statement As String) As Boolean
        Try
            Dim result As Boolean = False
            Dim SQLitecon As New SQLiteConnection("Data Source=database\data.db")
            Dim SQLitecmd As New SQLiteCommand(statement, SQLitecon)
            SQLitecon.Open()
            If SQLitecon.State = ConnectionState.Open Then
                Dim rows As Integer = SQLitecmd.ExecuteScalar
                '  MessageBox.Show(rows)
                If rows > 0 Then
                    result = True
                Else
                    result = False
                End If
            Else
                result = False
            End If
            SQLitecon.Close()
            SQLitecon.Dispose()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function ExecuteReaderSingleRow(ByVal database As String, ByVal statement As String, ByVal columns As Integer) As Object()
        Dim result(columns) As Object
        Try
            Dim SQLitecon As New SQLiteConnection("Data Source=database\data.db")
            Dim SQLitecmd As New SQLiteCommand(statement, SQLitecon)
            Dim SQLiteReader As SQLiteDataReader = Nothing
            SQLitecon.Open()
            If SQLitecon.State = ConnectionState.Open Then
                SQLiteReader = SQLitecmd.ExecuteReader

                Do While SQLiteReader.Read()
                    Dim count As Integer = 0
                    Do While count <= SQLiteReader.FieldCount - 1
                        result(count) = SQLiteReader(count)
                        count = count + 1
                    Loop
                Loop
            End If
            SQLitecon.Close()
            SQLitecon.Dispose()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return result
        End Try
    End Function

    Public Function ChangeData(ByVal database As String, ByVal statement As String)

    End Function
    Public Function DeleteData(ByVal database As String, ByVal statement As String)

    End Function
    Public Function GetData(ByVal database As String, ByVal statement As String)

    End Function
    Public Function GetDataAffected(ByVal database As String, ByVal statement As String)

    End Function
End Module
