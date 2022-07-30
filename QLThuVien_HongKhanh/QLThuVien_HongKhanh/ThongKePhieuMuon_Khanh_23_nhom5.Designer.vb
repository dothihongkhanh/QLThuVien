<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ThongKePhieuMuon_Khanh_23_nhom5
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
        Me.PhieuMuonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLTHUVIEN_HongKhanhDataSet = New QLThuVien_HongKhanh.QLTHUVIEN_HongKhanhDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PhieuMuonTableAdapter = New QLThuVien_HongKhanh.QLTHUVIEN_HongKhanhDataSetTableAdapters.PhieuMuonTableAdapter()
        CType(Me.PhieuMuonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLTHUVIEN_HongKhanhDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PhieuMuonBindingSource
        '
        Me.PhieuMuonBindingSource.DataMember = "PhieuMuon"
        Me.PhieuMuonBindingSource.DataSource = Me.QLTHUVIEN_HongKhanhDataSet
        '
        'QLTHUVIEN_HongKhanhDataSet
        '
        Me.QLTHUVIEN_HongKhanhDataSet.DataSetName = "QLTHUVIEN_HongKhanhDataSet"
        Me.QLTHUVIEN_HongKhanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PhieuMuonBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "QLThuVien_HongKhanh.Report_PhieuMuon_Khanh_23_nhom5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(6, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(957, 445)
        Me.ReportViewer1.TabIndex = 0
        '
        'PhieuMuonTableAdapter
        '
        Me.PhieuMuonTableAdapter.ClearBeforeFill = True
        '
        'ThongKePhieuMuon_Khanh_23_nhom5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ThongKePhieuMuon_Khanh_23_nhom5"
        Me.Text = "ThongKePhieuMuon_Khanh_23_nhom5"
        CType(Me.PhieuMuonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLTHUVIEN_HongKhanhDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PhieuMuonBindingSource As BindingSource
    Friend WithEvents QLTHUVIEN_HongKhanhDataSet As QLTHUVIEN_HongKhanhDataSet
    Friend WithEvents PhieuMuonTableAdapter As QLTHUVIEN_HongKhanhDataSetTableAdapters.PhieuMuonTableAdapter
End Class
