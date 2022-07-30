Public Class ThongKeDocGia_Khanh_23_nhom5
    Private Sub ThongKeDocGia_Khanh_23_nhom5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QLTHUVIEN_HongKhanhDataSet.DocGia' table. You can move, or remove it, as needed.
        Me.DocGiaTableAdapter.Fill(Me.QLTHUVIEN_HongKhanhDataSet.DocGia)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class