<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ThongKeSach_Khanh_23_nhom5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SachBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLTHUVIEN_HongKhanhDataSet = New QLThuVien_HongKhanh.QLTHUVIEN_HongKhanhDataSet()
        Me.ReportViewer_TKS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SachTableAdapter = New QLThuVien_HongKhanh.QLTHUVIEN_HongKhanhDataSetTableAdapters.SachTableAdapter()
        CType(Me.SachBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLTHUVIEN_HongKhanhDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SachBindingSource
        '
        Me.SachBindingSource.DataMember = "Sach"
        Me.SachBindingSource.DataSource = Me.QLTHUVIEN_HongKhanhDataSet
        '
        'QLTHUVIEN_HongKhanhDataSet
        '
        Me.QLTHUVIEN_HongKhanhDataSet.DataSetName = "QLTHUVIEN_HongKhanhDataSet"
        Me.QLTHUVIEN_HongKhanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer_TKS
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SachBindingSource
        Me.ReportViewer_TKS.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer_TKS.LocalReport.ReportEmbeddedResource = "QLThuVien_HongKhanh.Report_Sach_Khanh_23_Nhom5.rdlc"
        Me.ReportViewer_TKS.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer_TKS.Name = "ReportViewer_TKS"
        Me.ReportViewer_TKS.ServerReport.BearerToken = Nothing
        Me.ReportViewer_TKS.Size = New System.Drawing.Size(1199, 626)
        Me.ReportViewer_TKS.TabIndex = 0
        '
        'SachTableAdapter
        '
        Me.SachTableAdapter.ClearBeforeFill = True
        '
        'ThongKeSach_Khanh_23_nhom5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 637)
        Me.Controls.Add(Me.ReportViewer_TKS)
        Me.Name = "ThongKeSach_Khanh_23_nhom5"
        Me.Text = "ThongKeDocGia_Khanh_23_nhom5"
        CType(Me.SachBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLTHUVIEN_HongKhanhDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer_TKS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SachBindingSource As BindingSource
    Friend WithEvents QLTHUVIEN_HongKhanhDataSet As QLTHUVIEN_HongKhanhDataSet
    Friend WithEvents SachTableAdapter As QLTHUVIEN_HongKhanhDataSetTableAdapters.SachTableAdapter
End Class
