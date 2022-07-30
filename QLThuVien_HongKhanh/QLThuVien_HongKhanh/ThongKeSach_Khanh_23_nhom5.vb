Imports System.Data.SqlClient
Public Class ThongKeSach_Khanh_23_nhom5
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Private Sub ThongKeDocGia_Khanh_23_nhom5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QLTHUVIEN_HongKhanhDataSet.Sach' table. You can move, or remove it, as needed.
        Me.SachTableAdapter.Fill(Me.QLTHUVIEN_HongKhanhDataSet.Sach)

        Me.ReportViewer_TKS.RefreshReport()

    End Sub

End Class