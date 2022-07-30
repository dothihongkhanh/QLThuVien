Imports System.Data.SqlClient
Public Class ChiTietPhieuMuon_Khanh_23_nhom5
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Private Sub ChiTietPhieuMuon_Khanh_23_nhom5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String
        constring = "Data Source=DESKTOP-J8SR7CQ\SQLEXPRESS;Initial Catalog=QLTHUVIEN_HongKhanh;User Id=sa;Password=123456"
        con = New SqlConnection(constring)
        Xuat_ctpm()
        danh_sach_moi(sender, e)

        Dim dt1 As New DataTable
        Dim sqlquery1 As String
        sqlquery1 = "select * from PhieuMuon"
        Dim SQL1 As New SqlDataAdapter(sqlquery1, con)
        SQL1.Fill(dt1)
        Dim cmd1 As New SqlCommand(sqlquery1, con)
        cbbMaPM.DataSource = dt1
        cbbMaPM.DisplayMember = "maPM"

        Dim dt2 As New DataTable
        Dim sqlquery2 As String
        sqlquery2 = "select * from Sach"
        Dim SQL2 As New SqlDataAdapter(sqlquery2, con)
        SQL2.Fill(dt2)
        Dim cmd2 As New SqlCommand(sqlquery2, con)
        cbbMaSach.DataSource = dt2
        cbbMaSach.DisplayMember = "maSach"
    End Sub
    Private Sub Xuat_ctpm()
        Dim lenh As String
        lenh = "select * from ChiTietPhieuMuon"
        Dim cmd As New SqlCommand(lenh, con)
        con.Open()
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("ChiTietPhieuMuon")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        DataGridView_CTPM.DataSource = dttable
        danh_sach = Me.BindingContext(dttable)
    End Sub
    Private Sub xuat()
        cbbMaPM.Text = danh_sach.Current("maPM")
        cbbMaSach.Text = danh_sach.Current("maSach")
        DateTimePickerNgayTra.Value = danh_sach.Current("ngayTra")
        btnLuuCTPM.Enabled = False
    End Sub
    Private Sub danh_sach_moi(sender As Object, e As System.EventArgs) Handles danh_sach.PositionChanged
        xuat()
    End Sub
    Private Sub btnQLTC_Click(sender As Object, e As EventArgs) Handles btnQLTC.Click
        Me.Hide()
        QLPhieuMuon_Khanh_23_nhom5.Show()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnThemCTPM_Click(sender As Object, e As EventArgs) Handles btnThemCTPM.Click
        cbbMaPM.Text = ""
        cbbMaSach.Text = ""
        DateTimePickerNgayTra.Value = DateTime.Now.AddDays(0)
        btnThemCTPM.Enabled = False
        btnLuuCTPM.Enabled = True
        btnSuaCTPM.Enabled = False
        btnXoaCTPM.Enabled = False
    End Sub

    Private Sub btnLuuCTPM_Click(sender As Object, e As EventArgs) Handles btnLuuCTPM.Click
        If MsgBox("Bạn có muốn thêm không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thêm") = MsgBoxResult.Yes Then
            If cbbMaPM.Text = "" Or cbbMaSach.Text = "" Then
                MsgBox("Vui lòng điền dâyd đủ thông tin !!!")
            Else lenh = "insert into ChiTietPhieuMuon(maPM, maSach, ngayTra) values(
                   '" & cbbMaPM.Text & "',
                   '" & cbbMaSach.Text & "',
                   '" & DateTimePickerNgayTra.Value.Date.ToString("yyyyMMdd") & "')"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_ctpm()
                MsgBox("Thêm thành công!")
            End If
        End If
        btnThemCTPM.Enabled = True
        btnLuuCTPM.Enabled = False
        btnSuaCTPM.Enabled = True
        btnXoaCTPM.Enabled = True
    End Sub

    Private Sub btnSuaCTPM_Click(sender As Object, e As EventArgs) Handles btnSuaCTPM.Click
        If MsgBox("Bạn có muốn sửa không ? ", MsgBoxStyle.Question +
                    MsgBoxStyle.YesNo, "Sửa ") = MsgBoxResult.Yes Then
            lenh = "Update ChiTietPhieuMuon 
               set maPM= '" & cbbMaPM.Text & "',
               maSach= '" & cbbMaSach.Text & "', 
               ngayTra= '" & DateTimePickerNgayTra.Value.Date.ToString("yyyyMMdd") & "'
               where maPM = '" & Trim(cbbMaPM.Text) & "' and maSach = '" & Trim(cbbMaSach.Text) & "' "
            Dim cmd As New SqlCommand(lenh, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Xuat_ctpm()
            MsgBox("Sửa thành công")
        End If
    End Sub

    Private Sub btnXoaCTPM_Click(sender As Object, e As EventArgs) Handles btnXoaCTPM.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                              "Xóa") = MsgBoxResult.Yes Then

            If cbbMaPM.Text = "" Then
                MsgBox("Chọn giá trị cần xóa !!!")
            Else
                lenh = "delete from ChiTietPhieuMuon where maPM = '" & cbbMaPM.Text & "' and maSach = '" & cbbMaSach.Text & "'"

                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_ctpm()
                cbbMaPM.Text = ""
                cbbMaSach.Text = ""
                MsgBox("Xóa thành công!")
            End If
        End If
    End Sub


End Class