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
        Me.ToolusageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StampDeptDataSet = New KV_COM_LB.StampDeptDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ToolusageTableAdapter = New KV_COM_LB.StampDeptDataSetTableAdapters.ToolusageTableAdapter()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        CType(Me.ToolusageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StampDeptDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolusageBindingSource
        '
        Me.ToolusageBindingSource.DataMember = "Toolusage"
        Me.ToolusageBindingSource.DataSource = Me.StampDeptDataSet
        '
        'StampDeptDataSet
        '
        Me.StampDeptDataSet.DataSetName = "StampDeptDataSet"
        Me.StampDeptDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ToolusageTableAdapter
        '
        Me.ToolusageTableAdapter.ClearBeforeFill = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 406)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip2.TabIndex = 2
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ViewReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ViewReport"
        Me.Text = "ViewReport"
        CType(Me.ToolusageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StampDeptDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ToolusageBindingSource As BindingSource
    Friend WithEvents StampDeptDataSet As StampDeptDataSet
    Friend WithEvents ToolusageTableAdapter As StampDeptDataSetTableAdapters.ToolusageTableAdapter
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusStrip2 As StatusStrip
End Class
