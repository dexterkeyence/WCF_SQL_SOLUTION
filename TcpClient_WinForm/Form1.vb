﻿
Imports System.ComponentModel
Imports System.Net.Sockets
Imports System.Text
Public Class Form1
    'Public clientSocket As New System.Net.Sockets.TcpClient
    Public serverStream As NetworkStream





    Sub msg(ByVal mesg As String)
        'TextBox1.Text = TextBox1.Text + Environment.NewLine + " >>" + mesg
        TextBox1.Text = TextBox1.Text + Environment.NewLine + "" + mesg
    End Sub

    Private Sub BtnRead_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRead.Click
        Dim serverStream As NetworkStream = clientSocket.GetStream()
        Dim inStream(500024) As Byte
        Dim returndata As String = ""

        clientSocket.ReceiveTimeout = 1000 ' 10 SECONDS

        clientSocket.ReceiveBufferSize() = 5000000

        Do

            Try

                serverStream.Read(inStream, 0, 100000)

                returndata = returndata + System.Text.Encoding.ASCII.GetString(inStream)
                'msg("Data from Server : " + returndata)


            Catch ex As Exception
                MsgBox("No DATA")
                msg(ex.ToString)
            Finally

            End Try

        Loop Until clientSocket.Available = 0

        msg("" + returndata)






    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        Dim clientSocket As New System.Net.Sockets.TcpClient
        Try
            clientSocket.Connect(TextBox2.Text, TextBox3.Text)
            msg("Client Started")
            Label3.Text = "Server Connected ..."
        Catch ex As Exception
            'MsgBox(ex.ToString)
            If clientSocket.Connected = False Then
                MsgBox("Cannot Connect, Please check that IP Address and Port Number is correct!!")
            Else

                MsgBox("The connection is already Established!! ")
            End If
        End Try


    End Sub


    Private Sub BtnSend_Click_1(ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles BtnSend.Click

        Dim serverStream As NetworkStream = clientSocket.GetStream()
        Dim outStream As Byte() =
        System.Text.Encoding.ASCII.GetBytes(TextBox4.Text & vbCrLf)
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clientSocket As New System.Net.Sockets.TcpClient
        clientSocket.Close()
        msg("Client Disconnected")
        Label3.Text = "Server Dis-Connected ..."

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim clientSocket As New System.Net.Sockets.TcpClient

        Try
            clientSocket.Connect(TextBox2.Text, TextBox3.Text)
            'msg("Client Started")
            Label3.Text = "Server Connected ..."
        Catch ex As Exception
            MsgBox(ex.ToString)
            If clientSocket.Connected = False Then
                MsgBox("Cannot Connect, Please check that IP Address and Port Number is correct!!")
            Else

                MsgBox("The connection is already Established!! ")
            End If
        End Try


        Dim serverStream As NetworkStream = clientSocket.GetStream()
        Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(TextBox4.Text & vbCrLf)
        Dim inStream(500024) As Byte
        Dim returndata As String = ""
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()
        clientSocket.ReceiveTimeout = 1000 ' 10 SECONDS

        clientSocket.ReceiveBufferSize() = 5000000

        Do

            Try

                serverStream.Read(inStream, 0, 100000)

                returndata = returndata + System.Text.Encoding.ASCII.GetString(inStream)
                'msg("Data from Server : " + returndata)


            Catch ex As Exception
                MsgBox("No DATA")
                msg(ex.ToString)
            Finally

            End Try

        Loop Until clientSocket.Available = 0

        msg("" + returndata)


        clientSocket.Close()
        'msg("Client Disconnected")
        Label3.Text = "Server Dis-Connected ..."


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class

