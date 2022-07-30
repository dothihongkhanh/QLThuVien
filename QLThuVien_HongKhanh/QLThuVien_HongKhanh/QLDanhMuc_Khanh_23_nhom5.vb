Imports System.Data.SqlClient
Public Class QLDanhMuc_Khanh_23_Nhom5
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Private Sub QLDanhMuc_Khanh_23_Nhom5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String
        constring = "Data Source=DESKTOP-J8SR7CQ\SQLEXPRESS;Initial Catalog=QLTHUVIEN_HongKhanh;User Id=sa;Password=123456"
        con = New SqlConnection(constring)
        Xuat_dm()
        danh_sach_moi(sender, e)
    End Sub
    Private Sub Xuat_dm()
        Dim lenh As String
        lenh = "select * from DanhMuc"
        Dim cmd As New SqlCommand(lenh, con)
        con.Open()
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("DanhMuc")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGridView_DM.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)
    End Sub
    Private Sub xuat()
        txtMaDM.Text = danh_sach.Current("maDanhMuc")
        txtTenDM.Text = danh_sach.Current("tenDanhMuc")
        btnLuuDM.Enabled = False
        txtMaDM.Enabled = False
    End Sub
    Private Sub danh_sach_moi(sender As Object, e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat()
    End Sub

    Private Sub btnLuuDM_Click(sender As Object, e As EventArgs) Handles btnLuuDM.Click
        If MsgBox("Bạn có muốn thêm không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thêm") = MsgBoxResult.Yes Then
            If txtMaDM.Text = "" Or txtTenDM.Text = "" Then
                MsgBox("Vui lòng điền dâyd đủ thông tin !!!")
            Else lenh = "insert into DanhMuc(maDanhMuc, tenDanhMuc) values(
                   '" & txtMaDM.Text & "',
                   N'" & txtTenDM.Text & "')"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_dm()
                MsgBox("Thêm thành công!")
            End If
        End If
        btnThemDM.Enabled = True
        btnLuuDM.Enabled = False
        btnSuaDM.Enabled = True
        btnXoaDM.Enabled = True
    End Sub

    Private Sub btnSuaDM_Click(sender As Object, e As EventArgs) Handles btnSuaDM.Click
        If MsgBox("Bạn có muốn sửa không ? ", MsgBoxStyle.Question +
                    MsgBoxStyle.YesNo, "Sửa ") = MsgBoxResult.Yes Then
            lenh = "Update DanhMuc 
               set maDanhMuc= '" & txtMaDM.Text & "',
               tenDanhMuc= N'" & txtTenDM.Text & "'
               where maDanhMuc =  '" & Trim(txtMaDM.Text) & "'"
            Dim cmd As New SqlCommand(lenh, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Xuat_dm()
            MsgBox("Sửa thành công")
        End If
    End Sub

    Private Sub btnXoaDM_Click(sender As Object, e As EventArgs) Handles btnXoaDM.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                              "Xóa") = MsgBoxResult.Yes Then

            If txtMaDM.Text = "" Then
                MsgBox("Chọn giá trị cần xóa !!!")
            Else
                lenh = "delete from DanhMuc where maDanhMuc = '" & txtMaDM.Text & "' "

                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_dm()
                MsgBox("Xóa thành công!")
                txtMaDM.Text = ""
                txtTenDM.Text = ""
            End If
        End If
    End Sub

    Private Sub btnThemDM_Click(sender As Object, e As EventArgs) Handles btnThemDM.Click
        txtMaDM.Text = ""
        txtTenDM.Text = ""
        btnThemDM.Enabled = False
        btnLuuDM.Enabled = True
        btnSuaDM.Enabled = False
        btnXoaDM.Enabled = False
        txtMaDM.Enabled = True
    End Sub

    Private Sub btnQLTC_Click(sender As Object, e As EventArgs) Handles btnQLTC.Click
        Me.Hide()
        TrangChu_Khanh_23_nhom5.Show()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class
