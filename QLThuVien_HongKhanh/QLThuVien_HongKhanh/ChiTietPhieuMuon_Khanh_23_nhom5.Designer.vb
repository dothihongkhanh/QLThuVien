<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChiTietPhieuMuon_Khanh_23_nhom5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChiTietPhieuMuon_Khanh_23_nhom5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbbMaSach = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerNgayTra = New System.Windows.Forms.DateTimePicker()
        Me.btnThemCTPM = New System.Windows.Forms.Button()
        Me.btnSuaCTPM = New System.Windows.Forms.Button()
        Me.btnXoaCTPM = New System.Windows.Forms.Button()
        Me.btnLuuCTPM = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnQLTC = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.DataGridView_CTPM = New System.Windows.Forms.DataGridView()
        Me.cbbMaPM = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView_CTPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã phiếu mượn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã sách"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ngày trả"
        '
        'cbbMaSach
        '
        Me.cbbMaSach.FormattingEnabled = True
        Me.cbbMaSach.Location = New System.Drawing.Point(151, 139)
        Me.cbbMaSach.Name = "cbbMaSach"
        Me.cbbMaSach.Size = New System.Drawing.Size(200, 26)
        Me.cbbMaSach.TabIndex = 3
        '
        'DateTimePickerNgayTra
        '
        Me.DateTimePickerNgayTra.Location = New System.Drawing.Point(151, 187)
        Me.DateTimePickerNgayTra.Name = "DateTimePickerNgayTra"
        Me.DateTimePickerNgayTra.Size = New System.Drawing.Size(200, 24)
        Me.DateTimePickerNgayTra.TabIndex = 5
        '
        'btnThemCTPM
        '
        Me.btnThemCTPM.BackColor = System.Drawing.Color.PeachPuff
        Me.btnThemCTPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemCTPM.Location = New System.Drawing.Point(105, 242)
        Me.btnThemCTPM.Name = "btnThemCTPM"
        Me.btnThemCTPM.Size = New System.Drawing.Size(80, 40)
        Me.btnThemCTPM.TabIndex = 6
        Me.btnThemCTPM.Text = "Thêm"
        Me.btnThemCTPM.UseVisualStyleBackColor = False
        '
        'btnSuaCTPM
        '
        Me.btnSuaCTPM.BackColor = System.Drawing.Color.PeachPuff
        Me.btnSuaCTPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaCTPM.Location = New System.Drawing.Point(105, 293)
        Me.btnSuaCTPM.Name = "btnSuaCTPM"
        Me.btnSuaCTPM.Size = New System.Drawing.Size(80, 40)
        Me.btnSuaCTPM.TabIndex = 7
        Me.btnSuaCTPM.Text = "Sửa"
        Me.btnSuaCTPM.UseVisualStyleBackColor = False
        '
        'btnXoaCTPM
        '
        Me.btnXoaCTPM.BackColor = System.Drawing.Color.PeachPuff
        Me.btnXoaCTPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaCTPM.Location = New System.Drawing.Point(227, 293)
        Me.btnXoaCTPM.Name = "btnXoaCTPM"
        Me.btnXoaCTPM.Size = New System.Drawing.Size(80, 40)
        Me.btnXoaCTPM.TabIndex = 8
        Me.btnXoaCTPM.Text = "Xóa"
        Me.btnXoaCTPM.UseVisualStyleBackColor = False
        '
        'btnLuuCTPM
        '
        Me.btnLuuCTPM.BackColor = System.Drawing.Color.PeachPuff
        Me.btnLuuCTPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuuCTPM.Location = New System.Drawing.Point(227, 242)
        Me.btnLuuCTPM.Name = "btnLuuCTPM"
        Me.btnLuuCTPM.Size = New System.Drawing.Size(80, 40)
        Me.btnLuuCTPM.TabIndex = 9
        Me.btnLuuCTPM.Text = "Lưu"
        Me.btnLuuCTPM.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(257, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(290, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CHI TIẾT PHIẾU MƯỢN"
        '
        'btnQLTC
        '
        Me.btnQLTC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnQLTC.Location = New System.Drawing.Point(32, 20)
        Me.btnQLTC.Name = "btnQLTC"
        Me.btnQLTC.Size = New System.Drawing.Size(162, 35)
        Me.btnQLTC.TabIndex = 11
        Me.btnQLTC.Text = "Quay lại trang chủ"
        Me.btnQLTC.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.White
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(625, 20)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(67, 35)
        Me.btnThoat.TabIndex = 12
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'DataGridView_CTPM
        '
        Me.DataGridView_CTPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_CTPM.Location = New System.Drawing.Point(382, 97)
        Me.DataGridView_CTPM.Name = "DataGridView_CTPM"
        Me.DataGridView_CTPM.RowHeadersWidth = 51
        Me.DataGridView_CTPM.Size = New System.Drawing.Size(347, 236)
        Me.DataGridView_CTPM.TabIndex = 13
        '
        'cbbMaPM
        '
        Me.cbbMaPM.FormattingEnabled = True
        Me.cbbMaPM.Location = New System.Drawing.Point(151, 89)
        Me.cbbMaPM.Name = "cbbMaPM"
        Me.cbbMaPM.Size = New System.Drawing.Size(200, 26)
        Me.cbbMaPM.TabIndex = 4
        '
        'ChiTietPhieuMuon_Khanh_23_nhom5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(772, 367)
        Me.Controls.Add(Me.DataGridView_CTPM)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnQLTC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnLuuCTPM)
        Me.Controls.Add(Me.btnXoaCTPM)
        Me.Controls.Add(Me.btnSuaCTPM)
        Me.Controls.Add(Me.btnThemCTPM)
        Me.Controls.Add(Me.DateTimePickerNgayTra)
        Me.Controls.Add(Me.cbbMaPM)
        Me.Controls.Add(Me.cbbMaSach)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ChiTietPhieuMuon_Khanh_23_nhom5"
        Me.Text = "ChiTietPhieuMuon_Khanh_23_nhom5"
        CType(Me.DataGridView_CTPM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbbMaSach As ComboBox
    Friend WithEvents DateTimePickerNgayTra As DateTimePicker
    Friend WithEvents btnThemCTPM As Button
    Friend WithEvents btnSuaCTPM As Button
    Friend WithEvents btnXoaCTPM As Button
    Friend WithEvents btnLuuCTPM As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnQLTC As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents DataGridView_CTPM As DataGridView
    Friend WithEvents cbbMaPM As ComboBox
End Class
