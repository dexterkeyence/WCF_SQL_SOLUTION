' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.



Imports System.Data.SqlClient

Public Class Service1
    Implements ISQLService

    Public Sub New()
    End Sub




    Public Function GetData(ByVal value As String) As String Implements ISQLService.GetData
        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand
        Dim myReader As SqlDataReader
        Dim results As String = ""

        Try
            '------------Create a Connection object
            myConn = New SqlConnection("Server=KEY-NB-42\SQLEXPRESS2;Initial Catalog=TestDB;Integrated Security=True")
            '------------Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = value
            '------------Open the connection.
            myConn.Open()
            '------------Call the Reading Procedure
            myReader = myCmd.ExecuteReader()
            'Concatenate the query result into a string.
            Dim Value1 As Int64

            Value1 = myReader.FieldCount

            If Value1 > 0 Then
                Do While myReader.Read()

                    For i As Integer = 0 To Value1 - 1
                        If i = 0 Then

                            Select Case myReader.GetFieldType(i).ToString

                                Case "System.String"
                                    results = results & myReader.GetString(i)
                                Case "System.Int32"
                                    results = results & myReader.GetInt32(i).ToString
                            End Select

                        Else

                            Select Case myReader.GetFieldType(i).ToString

                                Case "System.String"
                                    results = results & vbTab & myReader.GetString(i)
                                Case "System.Int32"
                                    results = results & vbTab & myReader.GetString(i)
                            End Select
                        End If
                    Next

                    results = results & vbLf

                Loop

            Else
                results = "Records Affected :" + myReader.RecordsAffected().ToString
            End If



            myReader.Close()
            myConn.Close()

        Catch ex As Exception
            results = ex.Message
        End Try


        Return results
    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements ISQLService.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function

End Class
