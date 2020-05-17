Imports WebApp_WcfKVHost_SQL.StampDeptDataSetTableAdapters

Public Class About
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub


    'Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '   
    'End Sub

    Private Sub SQLUpdateCount()
        Dim ta = New ToolusageTableAdapter
        Dim PLC As New KVHost.KVHOSTService1Client

        Try
            Label2.Text = ta.GetToolUsageCount(TextBox1.Text)
            Label1.Text = TextBox1.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PLCUpdateCount()

        Dim PLC As New KVHost.KVHOSTService1Client


        Try
            Label3.Text = PLC.GetData(IP:="192.168.0.5", Port:="8501", Command:="RD DM1000")
            RadioButton1.Checked = PLC.GetData(IP:="192.168.0.5", Port:="8501", Command:="RD MR3000")
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SQLUpdateCount()
        PLCUpdateCount()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SQLUpdateCount()
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim PLC As New KVHost.KVHOSTService1Client

        PLC.GetData(IP:="192.168.0.5", Port:="8501", Command:="WR DM1000 " & TextBox2.Text)
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim PLC As New KVHost.KVHOSTService1Client

        Try
            PLC.GetData(IP:="192.168.0.5", Port:="8501", Command:="WR MR3000 1")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim PLC As New KVHost.KVHOSTService1Client
        PLC.GetData(IP:="192.168.0.5", Port:="8501", Command:="WR MR3000 0")
    End Sub

    Protected Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub


End Class