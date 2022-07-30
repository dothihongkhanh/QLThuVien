Imports System.Data.SqlClient
Public Class QLPhieuMuon_Khanh_23_nhom5
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Private Sub QLPhieuMuon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String
        constring = "Data Source=DESKTOP-J8SR7CQ\SQLEXPRESS;Initial Catalog=QLTHUVIEN_HongKhanh;User Id=sa;Password=123456"
        con = New SqlConnection(constring)
        Xuat_pm()
        danh_sach_moi(sender, e)

        cbbMaDG.Text = danh_sach.Current("maDocGia")
        'Lấy dữ liệu từ bảng đưa vào Combobox
        For I = 0 To danh_sach.Count - 1
            danh_sach.Position = I
            cbbMaDG.Items.Add(danh_sach.Current("maDocGia"))
        Next
    End Sub
    Private Sub Xuat_pm()
        Dim lenh As String
        lenh = "select * from PhieuMuon"
        Dim cmd As New SqlCommand(lenh, con)
        con.Open()
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("PhieuMuon")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGridView_PM.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)
    End Sub
    Private Sub xuat()
        txtMaPM.Text = danh_sach.Current("maPM")
        cbbMaDG.Text = danh_sach.Current("maDocGia")
        txtTenNV.Text = danh_sach.Current("tenNhanVien")
        DateTimePickerNgayMuon.Value = danh_sach.Current("ngayMuon")
        txtSoNgayMuon.Text = danh_sach.Current("soNgayMuon")
        btnLuuPM.Enabled = False
        txtMaPM.Enabled = False
    End Sub
    Private Sub danh_sach_moi(sender As Object, e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        TrangChu_Khanh_23_nhom5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub btnThemPM_Click(sender As Object, e As EventArgs) Handles btnThemPM.Click
        txtMaPM.Text = ""
        cbbMaDG.Text = ""
        txtTenNV.Text = ""
        DateTimePickerNgayMuon.Value = DateTime.Now.AddDays(0)
        txtSoNgayMuon.Text = ""
        btnThemPM.Enabled = False
        btnLuuPM.Enabled = True
        btnSuaPM.Enabled = False
        btnXoaPM.Enabled = False
        txtMaPM.Enabled = True
    End Sub

    Private Sub btnSuaPM_Click(sender As Object, e As EventArgs) Handles btnSuaPM.Click
        If MsgBox("Bạn có muốn sửa không ? ", MsgBoxStyle.Question +
                    MsgBoxStyle.YesNo, "Sửa ") = MsgBoxResult.Yes Then
            lenh = "Update PhieuMuon 
               set maPM= '" & txtMaPM.Text & "',
               maDocGia= '" & cbbMaDG.Text & "', 
               tenNhanVien= N'" & txtTenNV.Text & "',
               ngayMuon= '" & DateTimePickerNgayMuon.Value.Date.ToString("yyyyMMdd") & "', 
               soNgayMuon= '" & txtSoNgayMuon.Text & "'
               where maPM = '" & Trim(txtMaPM.Text) & "'"
            Dim cmd As New SqlCommand(lenh, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Xuat_pm()
            MsgBox("Sửa thành công")
        End If
    End Sub

    Private Sub btnXoaPM_Click(sender As Object, e As EventArgs) Handles btnXoaPM.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                              "Xóa") = MsgBoxResult.Yes Then

            If txtMaPM.Text = "" Then
                MsgBox("Chọn giá trị cần xóa !!!")
            Else
                lenh = "delete from PhieuMuon where maPM = '" & txtMaPM.Text & "' "

                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_pm()

                txtMaPM.Text = ""
                cbbMaDG.Text = ""
                txtTenNV.Text = ""
                DateTimePickerNgayMuon.Value = DateTime.Now.AddDays(0)
                txtSoNgayMuon.Text = ""
                MsgBox("Xóa thành công!")
            End If
        End If
    End Sub

    Private Sub btnLuuPM_Click(sender As Object, e As EventArgs) Handles btnLuuPM.Click
        If MsgBox("Bạn có muốn thêm không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thêm") = MsgBoxResult.Yes Then
            If txtMaPM.Text = "" Or txtTenNV.Text = "" Or txtSoNgayMuon.Text = "" Then
                MsgBox("Vui lòng điền dâyd đủ thông tin !!!")
            Else lenh = "insert into PhieuMuon(maPM, maDocGia, tenNhanVien, ngayMuon, soNgayMuon) values(
                   '" & txtMaPM.Text & "',
                   '" & cbbMaDG.Text & "',
                   N'" & txtTenNV.Text & "',
                   '" & DateTimePickerNgayMuon.Value.Date.ToString("yyyyMMdd") & "',
                   '" & txtSoNgayMuon.Text & "')"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_pm()
                MsgBox("Thêm thành công!")
            End If
        End If
        btnThemPM.Enabled = True
        btnLuuPM.Enabled = False
        btnSuaPM.Enabled = True
        btnXoaPM.Enabled = True
    End Sub

    Private Sub btnXemCTPhieuMuon_Click(sender As Object, e As EventArgs) Handles btnXemCTPhieuMuon.Click
        ChiTietPhieuMuon_Khanh_23_nhom5.Show()
    End Sub
End Class