Imports System.Data.SqlClient
Public Class TimKiem_DocGia_Khanh_23_nhom5
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Private Sub btnTK_Click(sender As Object, e As EventArgs) Handles btnTK.Click
        lenh = "select * from DocGia "
        If cbbDK.Text = "AND" Then
            If cbbDK1.Text = "Tên độc giả" And cbbDK2.Text = "Giới tính" Then
                lenh = lenh + " where tenDocGia = N'" & txtDK1.Text & "' and gioiTinh = N'" & txtDK2.Text & "'"
            ElseIf cbbDK1.Text = "Tên độc giả" And cbbDK2.Text = "Năm sinh" Then
                lenh = lenh + " where tenDocGia = N'" & txtDK1.Text & "' and year(ngaySinh) = '" & txtDK2.Text & "'"
            ElseIf cbbDK1.Text = "Giới tính" And cbbDK2.Text = "Năm sinh" Then
                lenh = lenh + " where gioiTinh = N'" & txtDK1.Text & "' and year(ngaySinh) = '" & txtDK2.Text & "'"
            End If
        End If
        If cbbDK.Text = "OR" Then
            If cbbDK1.Text = "Tên độc giả" And cbbDK2.Text = "Giới tính" Then
                lenh = lenh + " where tenDocGia = N'" & txtDK1.Text & "' or gioiTinh = N'" & txtDK2.Text & "'"
            ElseIf cbbDK1.Text = "Tên độc giả" And cbbDK2.Text = "Năm sinh" Then
                lenh = lenh + " where tenDocGia = N'" & txtDK1.Text & "' or year(ngaySinh) = '" & txtDK2.Text & "'"
            ElseIf cbbDK1.Text = "Giới tính" And cbbDK2.Text = "Năm sinh" Then
                lenh = lenh + " where gioiTinh = N'" & txtDK1.Text & "' or year(ngaySinh) = '" & txtDK2.Text & "'"
            End If
        End If
        If cbbDK.Text = "" Then
            If cbbDK1.Text = "Tên độc giả" Then
                lenh = lenh + " where tenDocGia = N'" & txtDK1.Text & "'"
            ElseIf cbbDK1.Text = "Năm sinh" Then
                lenh = lenh + " where  year(ngaySinh) = '" & txtDK1.Text & "'"
            ElseIf cbbDK1.Text = "Giới tính" Then
                lenh = lenh + " where gioiTinh = N'" & txtDK1.Text & "'"
            End If
        End If
        Dim cmd As New SqlCommand(lenh, con)
        con.Open()
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("DocGia")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        danh_sach = Me.BindingContext(dttable)
        DataGridView_TKDG.DataSource = dttable
    End Sub

    Private Sub TimKiem_DocGia_Khanh_23_nhom5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String
        constring = "Data Source=DESKTOP-J8SR7CQ\SQLEXPRESS;Initial Catalog=QLTHUVIEN_HongKhanh;User Id=sa;Password=123456"
        con = New SqlConnection(constring)
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnQLTC_Click(sender As Object, e As EventArgs) Handles btnQLTC.Click
        Me.Hide()
        TrangChu_Khanh_23_nhom5.Show()
    End Sub

    Private Sub btnTaiLai_Click(sender As Object, e As EventArgs) Handles btnTaiLai.Click
        lenh = "select * from DocGia order by maDocGia"
        Dim cmd As New SqlCommand(lenh, con)
        con.Open()
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("DocGia")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        danh_sach = Me.BindingContext(dttable)
        DataGridView_TKDG.DataSource = dttable
    End Sub
End Class