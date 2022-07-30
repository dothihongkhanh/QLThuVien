Imports System.Data.SqlClient
Public Class TimKiem_PhieuMuon_Khanh_23_nhom5
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Private Sub TimKiem_PhieuMuon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String
        constring = "Data Source=DESKTOP-J8SR7CQ\SQLEXPRESS;Initial Catalog=QLTHUVIEN_HongKhanh;User Id=sa;Password=123456"
        con = New SqlConnection(constring)
    End Sub

    Private Sub txtTKThang_TextChanged(sender As Object, e As EventArgs) Handles txtTKThang.TextChanged
        lenh = "select * from PhieuMuon where month(ngayMuon) = '" & txtTKThang.Text & "'"
        Dim cmd As New SqlCommand(lenh, con)
        con.Open()
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("Sach")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        danh_sach = Me.BindingContext(dttable)
        DataGridView_TKPM.DataSource = dttable
    End Sub
End Class