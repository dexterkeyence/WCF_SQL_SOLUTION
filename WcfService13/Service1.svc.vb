' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.



Imports System.Data.SqlClient

Public Class Service1
    Implements IService1

    Public Sub New()
    End Sub




    Public Function GetData(ByVal value As Integer) As String Implements IService1.GetData
        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand
        Dim myReader As SqlDataReader
        Dim results As String = ""


        Try
            'Create a Connection object.
            myConn = New SqlConnection("Server=KEY-NB-42\SQLEXPRESS2;Initial Catalog=TestDB;Integrated Security=True")
            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT Serial, ModelName FROM TestDB.dbo.TestTable"


            'Open the connection.
            myConn.Open()

            myReader = myCmd.ExecuteReader()
            'Concatenate the query result into a string.
            Do While myReader.Read()
                results = results & myReader.GetString(0) & vbTab & myReader.GetString(1) & vbLf
            Loop
            'Display results.

            results = "30"

            myReader.Close()
            myConn.Close()

        Catch ex As Exception
            results = ex.Message
        End Try




        Return String.Format("You entered: {0}", results)
    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IService1.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function

End Class
