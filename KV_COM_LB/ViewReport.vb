Public Class ViewReport
    Private Sub ViewReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StampDeptDataSet.Toolusage' table. You can move, or remove it, as needed.
        Me.ToolusageTableAdapter.Fill(Me.StampDeptDataSet.Toolusage)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class