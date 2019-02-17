Imports WebApp_WcfKVHost_SQL.StampDeptDataSetTableAdapters

Public Class About
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim ta = New ToolusageTableAdapter
        Label2.Text = ta.GetToolUsageCount(TextBox1.Text)
    End Sub
End Class