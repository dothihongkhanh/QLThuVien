Imports System.Data.SqlClient
Public Class TimKiem_Sach_Khanh_23_nhom5
    Private con As SqlConnection
    Private WithEvents danh_sach As BindingManagerBase
    Public lenh As String
    Private Sub TimKiem_Sach_Khanh_23_nhom5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String
        constring = "Data Source=DESKTOP-J8SR7CQ\SQLEXPRESS;Initial Catalog=QLTHUVIEN_HongKhanh;User Id=sa;Password=123456"
        con = New SqlConnection(constring)
        Xuat_hang()
        cbbDK1.Text = danh_sach.Current("maSach") & " | " & danh_sach.Current("tenSach")
        'Lấy dữ liệu từ bảng đưa vào Combobox
        For I = 0 To danh_sach.Count - 1
            danh_sach.Position = I
            cbbDK1.Items.Add(danh_sach.Current("maSach") & " | " & danh_sach.Current("tenSach"))
        Next
    End Sub
    Private Sub Xuat_hang()
        lenh = "select * from Sach order by maSach"
        Dim cmd As New SqlCommand(lenh, con)
        con.Open()
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("Sach")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        danh_sach = Me.BindingContext(dttable)
        DataGridView_TKS.DataSource = dttable
    End Sub

    Private Sub cbbDK1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbDK1.SelectedIndexChanged
        Dim tach As String
        tach = cbbDK1.Text.Substring(0, InStr(cbbDK1.Text, " |")).Trim
        lenh = "select * from Sach where maSach = '" & tach & "'"
        Dim cmd As New SqlCommand(lenh, con)
        con.Open()
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("Sach")
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        con.Close()
        danh_sach = Me.BindingContext(dttable)
        DataGridView_TKS.DataSource = dttable
    End Sub

    Private Sub btnTKS_Click(sender As Object, e As EventArgs) Handles btnTKS.Click
        Xuat_hang()
    End Sub
End Class