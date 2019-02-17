<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.StampDeptDataSet = New KV_COM_LB.StampDeptDataSet()
        Me.ToolusageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolusageTableAdapter = New KV_COM_LB.StampDeptDataSetTableAdapters.ToolusageTableAdapter()
        CType(Me.StampDeptDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolusageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ToolusageBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "KV_COM_LB.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'StampDeptDataSet
        '
        Me.StampDeptDataSet.DataSetName = "StampDeptDataSet"
        Me.StampDeptDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolusageBindingSource
        '
        Me.ToolusageBindingSource.DataMember = "Toolusage"
        Me.ToolusageBindingSource.DataSource = Me.StampDeptDataSet
        '
        'ToolusageTableAdapter
        '
        Me.ToolusageTableAdapter.ClearBeforeFill = True
        '
        'ViewReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ViewReport"
        Me.Text = "ViewReport"
        CType(Me.StampDeptDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolusageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ToolusageBindingSource As BindingSource
    Friend WithEvents StampDeptDataSet As StampDeptDataSet
    Friend WithEvents ToolusageTableAdapter As StampDeptDataSetTableAdapters.ToolusageTableAdapter
End Class
