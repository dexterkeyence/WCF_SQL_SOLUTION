Imports System.Net.Sockets
' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
Public Class Service1
    Implements IKVHOSTService1

    Public Sub New()
    End Sub





    <WebInvoke(Method:="POST", RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)>
    Public Function GetData(ByVal IP As String, ByVal Port As String, ByVal Command As String) As String Implements IKVHOSTService1.GetData
        Dim clientSocket As New System.Net.Sockets.TcpClient
        Dim returndata As String = ""
        '-----CONNECT TO PLC-----------

        Try
            clientSocket.Connect(IP, Port)

        Catch ex As Exception

            If clientSocket.Connected = False Then
                returndata = returndata + "Cannot Connect, IP Address or Port Number Error!" + vbCrLf
            Else

                returndata = returndata + ""
            End If
        End Try

        If clientSocket.Connected = True Then
            '-----SEND TO PLC-----------
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(Command & vbCrLf)
            Dim inStream(100000) As Byte

            Try
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()
            Catch ex As Exception

                returndata = returndata + "Send Command Error" + vbCrLf

            End Try


            '-----READ FROM PLC-----------
            clientSocket.ReceiveTimeout = 10000 ' 10 SECONDS
            clientSocket.ReceiveBufferSize() = 100000

            Do

                Try
                    serverStream.Read(inStream, 0, 100000)

                    returndata = returndata + System.Text.Encoding.ASCII.GetString(inStream)

                Catch ex As Exception
                    returndata = returndata + "No Data" & vbCrLf

                Finally

                End Try

            Loop Until clientSocket.Available = 0
        End If


        clientSocket.Close()


        Return returndata.TrimEnd(Chr(10), Chr(13), Chr(0))
    End Function


    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IKVHOSTService1.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function

End Class
