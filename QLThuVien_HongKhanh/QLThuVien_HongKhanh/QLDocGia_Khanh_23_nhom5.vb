Imports System.Data.SqlClient
Public Class QLDocGia_Khanh_23_nhom5
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Private Sub QLDocGia_Khanh_23_nhom5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String
        constring = "Data Source=DESKTOP-J8SR7CQ\SQLEXPRESS;Initial Catalog=QLTHUVIEN_HongKhanh;User Id=sa;Password=123456"
        con = New SqlConnection(constring)
        Xuat_dg()
        danh_sach_moi(sender, e)
    End Sub
    Private Sub Xuat_dg()
        Dim lenh As String
        lenh = "select * from DocGia"
        Dim cmd As New SqlCommand(lenh, con)
        con.Open()
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("NhanVien")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGridView_DG.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)
    End Sub
    Private Sub xuat()
        txtMaDG.Text = danh_sach.Current("maDocGia")
        txtTenDG.Text = danh_sach.Current("tenDocGia")
        DateTimePickerNgaySinh.Value = danh_sach.Current("ngaySinh")
        If danh_sach.Current("gioiTinh") = "Nam" Then
            rbNam.Checked = True
        Else
            rbNu.Checked = True
        End If
        txtSDT.Text = danh_sach.Current("SDT")
        btnLuuDG.Enabled = False
        txtMaDG.Enabled = False
    End Sub
    Private Sub danh_sach_moi(sender As Object, e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat()
    End Sub
    Private Sub btnQLTC_Click(sender As Object, e As EventArgs) Handles btnQLTC.Click
        Me.Hide()
        TrangChu_Khanh_23_nhom5.Show()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Sub btnThemDG_Click(sender As Object, e As EventArgs) Handles btnThemDG.Click
        txtMaDG.Text = ""
        txtTenDG.Text = ""
        DateTimePickerNgaySinh.Value = DateTime.Now.AddDays(0)
        rbNam.Checked = False And rbNu.Checked = False
        txtSDT.Text = ""
        btnThemDG.Enabled = False
        btnLuuDG.Enabled = True
        btnSuaDG.Enabled = False
        btnXoaDG.Enabled = False
        txtMaDG.Enabled = True
    End Sub

    Private Sub btnSuaDG_Click(sender As Object, e As EventArgs) Handles btnSuaDG.Click
        Dim gioitinh$
        If rbNam.Checked = True Then
            gioitinh = "Nam"
        Else
            gioitinh = "Nữ"
        End If
        If MsgBox("Bạn có muốn sửa không ? ", MsgBoxStyle.Question +
                    MsgBoxStyle.YesNo, "Sửa ") = MsgBoxResult.Yes Then
            lenh = "Update DocGia 
               set maDocGia= '" & txtMaDG.Text & "',
               tenDocGia= N'" & txtTenDG.Text & "',  
               ngaySinh='" & DateTimePickerNgaySinh.Value.Date.ToString("yyyyMMdd") & "', 
               gioiTinh= N'" & gioitinh & "',
               sdt='" & txtSDT.Text & "'
               where maDocGia =  '" & Trim(txtMaDG.Text) & "'"
            Dim cmd As New SqlCommand(lenh, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Xuat_dg()
            MsgBox("Sửa thành công")
        End If
    End Sub

    Private Sub btnXoaDG_Click(sender As Object, e As EventArgs) Handles btnXoaDG.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                              "Xóa") = MsgBoxResult.Yes Then

            If txtMaDG.Text = "" Then
                MsgBox("Chọn giá trị cần xóa !!!")
            Else
                lenh = "delete from DocGia where maDocGia = '" & txtMaDG.Text & "' "

                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_dg()
                MsgBox("Xóa thành công!")
                txtMaDG.Text = ""
                txtTenDG.Text = ""
                DateTimePickerNgaySinh.Value = DateTime.Now.AddDays(0)
                rbNam.Checked = False And rbNu.Checked = False
                txtSDT.Text = ""
            End If
        End If
    End Sub

    Private Sub btnLuuDG_Click(sender As Object, e As EventArgs) Handles btnLuuDG.Click
        Dim gioitinh$
        If rbNam.Checked = True Then
            gioitinh = "Nam"
        Else
            gioitinh = "Nữ"
        End If
        If MsgBox("Bạn có muốn thêm không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thêm") = MsgBoxResult.Yes Then
            If txtMaDG.Text = "" Or txtTenDG.Text = "" Or txtSDT.Text = "" Or rbNam.Checked = False And rbNu.Checked = False Then
                MsgBox("Vui lòng điền dâyd đủ thông tin !!!")
            Else lenh = "insert into DocGia(maDocGia, tenDocGia, ngaySinh, gioiTinh, sdt) values(
                   '" & txtMaDG.Text & "',
                   N'" & txtTenDG.Text & "',
                   '" & DateTimePickerNgaySinh.Value.Date.ToString("yyyyMMdd") & "',
                   N'" & gioitinh & "', 
                   N'" & txtSDT.Text & "')"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_dg()
                MsgBox("Thêm thành công!")
            End If
        End If
        btnThemDG.Enabled = True
        btnLuuDG.Enabled = False
        btnSuaDG.Enabled = True
        btnXoaDG.Enabled = True
    End Sub

End Class