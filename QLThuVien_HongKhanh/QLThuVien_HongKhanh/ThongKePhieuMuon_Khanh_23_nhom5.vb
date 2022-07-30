Public Class ThongKePhieuMuon_Khanh_23_nhom5
    Private Sub ThongKePhieuMuon_Khanh_23_nhom5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QLTHUVIEN_HongKhanhDataSet.PhieuMuon' table. You can move, or remove it, as needed.
        Me.PhieuMuonTableAdapter.Fill(Me.QLTHUVIEN_HongKhanhDataSet.PhieuMuon)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class