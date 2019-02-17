Imports WebApp_WcfKVHost_SQL.StampDeptDataSetTableAdapters

Public Class About
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        UpdateCount()
    End Sub

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateCount()
    End Sub

    Private Sub UpdateCount()
        Dim ta = New ToolusageTableAdapter
        Try
            Label2.Text = ta.GetToolUsageCount(TextBox1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim client = New DataTestService.Service1Client
        Dim result = client.GetData("1")
        Label3.Text = result
    End Sub
End Class