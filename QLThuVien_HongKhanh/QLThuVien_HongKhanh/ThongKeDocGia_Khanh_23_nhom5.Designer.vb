<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThongKeDocGia_Khanh_23_nhom5
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
        Me.QLTHUVIEN_HongKhanhDataSet = New QLThuVien_HongKhanh.QLTHUVIEN_HongKhanhDataSet()
        Me.DocGiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocGiaTableAdapter = New QLThuVien_HongKhanh.QLTHUVIEN_HongKhanhDataSetTableAdapters.DocGiaTableAdapter()
        CType(Me.QLTHUVIEN_HongKhanhDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocGiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DocGiaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "QLThuVien_HongKhanh.Report_DocGia_Khanh_23_nhom5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(7, 8)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(896, 732)
        Me.ReportViewer1.TabIndex = 0
        '
        'QLTHUVIEN_HongKhanhDataSet
        '
        Me.QLTHUVIEN_HongKhanhDataSet.DataSetName = "QLTHUVIEN_HongKhanhDataSet"
        Me.QLTHUVIEN_HongKhanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DocGiaBindingSource
        '
        Me.DocGiaBindingSource.DataMember = "DocGia"
        Me.DocGiaBindingSource.DataSource = Me.QLTHUVIEN_HongKhanhDataSet
        '
        'DocGiaTableAdapter
        '
        Me.DocGiaTableAdapter.ClearBeforeFill = True
        '
        'ThongKeDocGia_Khanh_23_nhom5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 745)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ThongKeDocGia_Khanh_23_nhom5"
        Me.Text = "ThongKeDocGia_Khanh_23_nhom5"
        CType(Me.QLTHUVIEN_HongKhanhDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocGiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DocGiaBindingSource As BindingSource
    Friend WithEvents QLTHUVIEN_HongKhanhDataSet As QLTHUVIEN_HongKhanhDataSet
    Friend WithEvents DocGiaTableAdapter As QLTHUVIEN_HongKhanhDataSetTableAdapters.DocGiaTableAdapter
End Class
