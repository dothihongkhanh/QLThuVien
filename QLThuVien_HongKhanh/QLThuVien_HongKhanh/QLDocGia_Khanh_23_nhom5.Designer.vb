<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QLDocGia_Khanh_23_nhom5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QLDocGia_Khanh_23_nhom5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaDG = New System.Windows.Forms.TextBox()
        Me.txtTenDG = New System.Windows.Forms.TextBox()
        Me.DateTimePickerNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.rbNam = New System.Windows.Forms.RadioButton()
        Me.rbNu = New System.Windows.Forms.RadioButton()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.btnThemDG = New System.Windows.Forms.Button()
        Me.btnSuaDG = New System.Windows.Forms.Button()
        Me.btnXoaDG = New System.Windows.Forms.Button()
        Me.btnLuuDG = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView_DG = New System.Windows.Forms.DataGridView()
        Me.btnQLTC = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        CType(Me.DataGridView_DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã độc giả"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên độc giả"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ngày sinh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(367, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Giới tính"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(367, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Số điện thoại"
        '
        'txtMaDG
        '
        Me.txtMaDG.Location = New System.Drawing.Point(153, 93)
        Me.txtMaDG.Name = "txtMaDG"
        Me.txtMaDG.Size = New System.Drawing.Size(170, 24)
        Me.txtMaDG.TabIndex = 5
        '
        'txtTenDG
        '
        Me.txtTenDG.Location = New System.Drawing.Point(153, 132)
        Me.txtTenDG.Name = "txtTenDG"
        Me.txtTenDG.Size = New System.Drawing.Size(170, 24)
        Me.txtTenDG.TabIndex = 6
        '
        'DateTimePickerNgaySinh
        '
        Me.DateTimePickerNgaySinh.Location = New System.Drawing.Point(153, 179)
        Me.DateTimePickerNgaySinh.Name = "DateTimePickerNgaySinh"
        Me.DateTimePickerNgaySinh.Size = New System.Drawing.Size(170, 24)
        Me.DateTimePickerNgaySinh.TabIndex = 7
        '
        'rbNam
        '
        Me.rbNam.AutoSize = True
        Me.rbNam.Location = New System.Drawing.Point(497, 85)
        Me.rbNam.Name = "rbNam"
        Me.rbNam.Size = New System.Drawing.Size(61, 22)
        Me.rbNam.TabIndex = 8
        Me.rbNam.TabStop = True
        Me.rbNam.Text = "Nam"
        Me.rbNam.UseVisualStyleBackColor = True
        '
        'rbNu
        '
        Me.rbNu.AutoSize = True
        Me.rbNu.Location = New System.Drawing.Point(594, 85)
        Me.rbNu.Name = "rbNu"
        Me.rbNu.Size = New System.Drawing.Size(48, 22)
        Me.rbNu.TabIndex = 9
        Me.rbNu.TabStop = True
        Me.rbNu.Text = "Nữ"
        Me.rbNu.UseVisualStyleBackColor = True
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(497, 129)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(170, 24)
        Me.txtSDT.TabIndex = 10
        '
        'btnThemDG
        '
        Me.btnThemDG.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnThemDG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemDG.Location = New System.Drawing.Point(119, 228)
        Me.btnThemDG.Name = "btnThemDG"
        Me.btnThemDG.Size = New System.Drawing.Size(80, 40)
        Me.btnThemDG.TabIndex = 11
        Me.btnThemDG.Text = "Thêm"
        Me.btnThemDG.UseVisualStyleBackColor = False
        '
        'btnSuaDG
        '
        Me.btnSuaDG.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSuaDG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaDG.Location = New System.Drawing.Point(370, 228)
        Me.btnSuaDG.Name = "btnSuaDG"
        Me.btnSuaDG.Size = New System.Drawing.Size(80, 40)
        Me.btnSuaDG.TabIndex = 12
        Me.btnSuaDG.Text = "Sửa"
        Me.btnSuaDG.UseVisualStyleBackColor = False
        '
        'btnXoaDG
        '
        Me.btnXoaDG.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnXoaDG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaDG.Location = New System.Drawing.Point(497, 228)
        Me.btnXoaDG.Name = "btnXoaDG"
        Me.btnXoaDG.Size = New System.Drawing.Size(80, 40)
        Me.btnXoaDG.TabIndex = 13
        Me.btnXoaDG.Text = "Xóa"
        Me.btnXoaDG.UseVisualStyleBackColor = False
        '
        'btnLuuDG
        '
        Me.btnLuuDG.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLuuDG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuuDG.Location = New System.Drawing.Point(234, 228)
        Me.btnLuuDG.Name = "btnLuuDG"
        Me.btnLuuDG.Size = New System.Drawing.Size(80, 40)
        Me.btnLuuDG.TabIndex = 14
        Me.btnLuuDG.Text = "Lưu"
        Me.btnLuuDG.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Magenta
        Me.Label6.Location = New System.Drawing.Point(253, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(277, 32)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "QUẢN LÝ ĐỘC GIẢ"
        '
        'DataGridView_DG
        '
        Me.DataGridView_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_DG.Location = New System.Drawing.Point(66, 297)
        Me.DataGridView_DG.Name = "DataGridView_DG"
        Me.DataGridView_DG.RowHeadersWidth = 51
        Me.DataGridView_DG.Size = New System.Drawing.Size(577, 185)
        Me.DataGridView_DG.TabIndex = 16
        '
        'btnQLTC
        '
        Me.btnQLTC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnQLTC.Location = New System.Drawing.Point(24, 14)
        Me.btnQLTC.Name = "btnQLTC"
        Me.btnQLTC.Size = New System.Drawing.Size(191, 33)
        Me.btnQLTC.TabIndex = 17
        Me.btnQLTC.Text = "Quay lại trang chủ"
        Me.btnQLTC.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(635, 13)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(69, 34)
        Me.btnThoat.TabIndex = 18
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'QLDocGia_Khanh_23_nhom5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(725, 506)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnQLTC)
        Me.Controls.Add(Me.DataGridView_DG)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnLuuDG)
        Me.Controls.Add(Me.btnXoaDG)
        Me.Controls.Add(Me.btnSuaDG)
        Me.Controls.Add(Me.btnThemDG)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.rbNu)
        Me.Controls.Add(Me.rbNam)
        Me.Controls.Add(Me.DateTimePickerNgaySinh)
        Me.Controls.Add(Me.txtTenDG)
        Me.Controls.Add(Me.txtMaDG)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "QLDocGia_Khanh_23_nhom5"
        Me.Text = "QLDocGia_Khanh_23_nhom5"
        CType(Me.DataGridView_DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMaDG As TextBox
    Friend WithEvents txtTenDG As TextBox
    Friend WithEvents DateTimePickerNgaySinh As DateTimePicker
    Friend WithEvents rbNam As RadioButton
    Friend WithEvents rbNu As RadioButton
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents btnThemDG As Button
    Friend WithEvents btnSuaDG As Button
    Friend WithEvents btnXoaDG As Button
    Friend WithEvents btnLuuDG As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView_DG As DataGridView
    Friend WithEvents btnQLTC As Button
    Friend WithEvents btnThoat As Button
End Class
