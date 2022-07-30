Imports System.Data.SqlClient
Public Class QLSach_Khanh_23_nhom5
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Private Sub QLSach_Khanh_23_nhom5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String
        constring = "Data Source=DESKTOP-J8SR7CQ\SQLEXPRESS;Initial Catalog=QLTHUVIEN_HongKhanh;User Id=sa;Password=123456"
        con = New SqlConnection(constring)
        Xuat_s()
        danh_sach_moi(sender, e)

        Dim dt1 As New DataTable
        Dim sqlquery1 As String
        sqlquery1 = "select * from DanhMuc"
        Dim SQL1 As New SqlDataAdapter(sqlquery1, con)
        SQL1.Fill(dt1)
        Dim cmd1 As New SqlCommand(sqlquery1, con)
        cbbMaDM.DataSource = dt1
        cbbMaDM.DisplayMember = "tenDanhMuc"
    End Sub
    Private Sub Xuat_s()
        Dim lenh As String
        lenh = "select maSach, tenSach, tenDanhMuc, theLoai, tacGia, nhaXuatBan, namXuatBan, soLuongCon
                from DanhMuc as dm, Sach as s
                where dm.maDanhMuc = s.maDanhMuc"
        Dim cmd As New SqlCommand(lenh, con)
        con.Open()
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("Sach")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGridView_S.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)
    End Sub
    Private Sub xuat()
        txtMaSach.Text = danh_sach.Current("maSach")
        cbbMaDM.Text = danh_sach.Current("tenDanhMuc")
        txtTenSach.Text = danh_sach.Current("tenSach")
        txtTheLoai.Text = danh_sach.Current("theLoai")
        txtTacGia.Text = danh_sach.Current("tacGia")
        txtNhaXB.Text = danh_sach.Current("nhaXuatBan")
        txtNamXB.Text = danh_sach.Current("namXuatBan")
        txtSLCon.Text = danh_sach.Current("soLuongCon")
        btnLuuS.Enabled = False
        txtMaSach.Enabled = False
    End Sub
    Private Sub danh_sach_moi(sender As Object, e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat()
    End Sub
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnQLTC_Click(sender As Object, e As EventArgs) Handles btnQLTC.Click
        Me.Hide()
        TrangChu_Khanh_23_nhom5.Show()
    End Sub

    Private Sub btnThemS_Click(sender As Object, e As EventArgs) Handles btnThemS.Click
        txtMaSach.Text = ""
        cbbMaDM.Text = ""
        txtTenSach.Text = ""
        txtTheLoai.Text = ""
        txtTacGia.Text = ""
        txtNhaXB.Text = ""
        txtNamXB.Text = ""
        txtSLCon.Text = ""
        btnThemS.Enabled = False
        btnLuuS.Enabled = True
        btnSuaS.Enabled = False
        btnXoaS.Enabled = False
        txtMaSach.Enabled = True
    End Sub

    Private Sub btnSuaS_Click(sender As Object, e As EventArgs) Handles btnSuaS.Click
        If MsgBox("Bạn có muốn sửa không ? ", MsgBoxStyle.Question +
                    MsgBoxStyle.YesNo, "Sửa ") = MsgBoxResult.Yes Then
            lenh = "Update Sach 
               set maSach= '" & txtMaSach.Text & "',
               maDanhMuc= N'" & cbbMaDM.Text & "',
               tenSach= N'" & txtTenSach.Text & "',
               theLoai= N'" & txtTheLoai.Text & "',
               tacGia= N'" & txtTacGia.Text & "',
               nhaXuatBan= N'" & txtNhaXB.Text & "',
               namXuatBan= N'" & txtNamXB.Text & "',
               soLuongCon= N'" & txtSLCon.Text & "'
               where maSach =  '" & Trim(txtMaSach.Text) & "'"
            Dim cmd As New SqlCommand(lenh, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Xuat_s()
            MsgBox("Sửa thành công")
        End If
    End Sub

    Private Sub btnXoaS_Click(sender As Object, e As EventArgs) Handles btnXoaS.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                             "Xóa") = MsgBoxResult.Yes Then

            If txtMaSach.Text = "" Then
                MsgBox("Chọn giá trị cần xóa !!!")
            Else
                lenh = "delete from Sach where maSach = '" & txtMaSach.Text & "' "

                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_s()
                txtMaSach.Text = ""
                cbbMaDM.Text = ""
                txtTenSach.Text = ""
                txtTheLoai.Text = ""
                txtTacGia.Text = ""
                txtNhaXB.Text = ""
                txtNamXB.Text = ""
                txtSLCon.Text = ""
                MsgBox("Xóa thành công!")
            End If
        End If
    End Sub

    Private Sub btnLuuS_Click(sender As Object, e As EventArgs) Handles btnLuuS.Click
        If MsgBox("Bạn có muốn thêm không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thêm") = MsgBoxResult.Yes Then
            If txtMaSach.Text = "" Or txtTenSach.Text = "" Or txtTheLoai.Text = "" Or txtTacGia.Text = "" Or txtNhaXB.Text = "" Or txtNamXB.Text = "" Or txtSLCon.Text = "" Then
                MsgBox("Vui lòng điền dâyd đủ thông tin !!!")
            Else lenh = "insert into Sach(maSach, maDanhMuc, tenSach, theLoai, tacGia, nhaXuatBan, namXuatBan, soLuongCon) values(
                   '" & txtMaSach.Text & "',
                   '" & cbbMaDM.Text & "',
                   N'" & txtTenSach.Text & "',
                   N'" & txtTheLoai.Text & "',
                   N'" & txtTacGia.Text & "',
                   N'" & txtNhaXB.Text & "',
                   '" & txtNamXB.Text & "',
                   '" & txtSLCon.Text & "')"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_s()
                MsgBox("Thêm thành công!")
            End If
        End If
        btnThemS.Enabled = True
        btnLuuS.Enabled = False
        btnSuaS.Enabled = True
        btnXoaS.Enabled = True
    End Sub
End Class