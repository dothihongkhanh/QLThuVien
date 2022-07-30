<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimKiem_DocGia_Khanh_23_nhom5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TimKiem_DocGia_Khanh_23_nhom5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbbDK = New System.Windows.Forms.ComboBox()
        Me.cbbDK1 = New System.Windows.Forms.ComboBox()
        Me.cbbDK2 = New System.Windows.Forms.ComboBox()
        Me.txtDK1 = New System.Windows.Forms.TextBox()
        Me.txtDK2 = New System.Windows.Forms.TextBox()
        Me.btnTK = New System.Windows.Forms.Button()
        Me.DataGridView_TKDG = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnQLTC = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnTaiLai = New System.Windows.Forms.Button()
        CType(Me.DataGridView_TKDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(236, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TÌM KIẾM ĐỘC GIẢ"
        '
        'cbbDK
        '
        Me.cbbDK.FormattingEnabled = True
        Me.cbbDK.Items.AddRange(New Object() {"AND", "OR"})
        Me.cbbDK.Location = New System.Drawing.Point(50, 102)
        Me.cbbDK.Name = "cbbDK"
        Me.cbbDK.Size = New System.Drawing.Size(80, 26)
        Me.cbbDK.TabIndex = 1
        '
        'cbbDK1
        '
        Me.cbbDK1.FormattingEnabled = True
        Me.cbbDK1.Items.AddRange(New Object() {"Tên độc giả", "Giới tính", "Năm sinh"})
        Me.cbbDK1.Location = New System.Drawing.Point(176, 102)
        Me.cbbDK1.Name = "cbbDK1"
        Me.cbbDK1.Size = New System.Drawing.Size(105, 26)
        Me.cbbDK1.TabIndex = 2
        '
        'cbbDK2
        '
        Me.cbbDK2.FormattingEnabled = True
        Me.cbbDK2.Items.AddRange(New Object() {"Tên độc giả", "Giới tính", "Năm sinh"})
        Me.cbbDK2.Location = New System.Drawing.Point(176, 150)
        Me.cbbDK2.Name = "cbbDK2"
        Me.cbbDK2.Size = New System.Drawing.Size(105, 26)
        Me.cbbDK2.TabIndex = 3
        '
        'txtDK1
        '
        Me.txtDK1.Location = New System.Drawing.Point(331, 102)
        Me.txtDK1.Name = "txtDK1"
        Me.txtDK1.Size = New System.Drawing.Size(166, 24)
        Me.txtDK1.TabIndex = 4
        '
        'txtDK2
        '
        Me.txtDK2.Location = New System.Drawing.Point(331, 150)
        Me.txtDK2.Name = "txtDK2"
        Me.txtDK2.Size = New System.Drawing.Size(166, 24)
        Me.txtDK2.TabIndex = 5
        '
        'btnTK
        '
        Me.btnTK.BackColor = System.Drawing.Color.Lime
        Me.btnTK.Location = New System.Drawing.Point(533, 116)
        Me.btnTK.Name = "btnTK"
        Me.btnTK.Size = New System.Drawing.Size(90, 41)
        Me.btnTK.TabIndex = 6
        Me.btnTK.Text = "Tìm kiếm"
        Me.btnTK.UseVisualStyleBackColor = False
        '
        'DataGridView_TKDG
        '
        Me.DataGridView_TKDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_TKDG.Location = New System.Drawing.Point(21, 200)
        Me.DataGridView_TKDG.Name = "DataGridView_TKDG"
        Me.DataGridView_TKDG.RowHeadersWidth = 51
        Me.DataGridView_TKDG.RowTemplate.Height = 24
        Me.DataGridView_TKDG.Size = New System.Drawing.Size(519, 170)
        Me.DataGridView_TKDG.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Từ nối"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(190, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Thuộc tính"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(386, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Từ khóa"
        '
        'btnQLTC
        '
        Me.btnQLTC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnQLTC.Location = New System.Drawing.Point(41, 26)
        Me.btnQLTC.Name = "btnQLTC"
        Me.btnQLTC.Size = New System.Drawing.Size(146, 33)
        Me.btnQLTC.TabIndex = 11
        Me.btnQLTC.Text = "Quay lại trang chủ"
        Me.btnQLTC.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.White
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(557, 27)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 31)
        Me.btnThoat.TabIndex = 12
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'btnTaiLai
        '
        Me.btnTaiLai.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTaiLai.Location = New System.Drawing.Point(557, 272)
        Me.btnTaiLai.Name = "btnTaiLai"
        Me.btnTaiLai.Size = New System.Drawing.Size(75, 33)
        Me.btnTaiLai.TabIndex = 13
        Me.btnTaiLai.Text = "Tải lại"
        Me.btnTaiLai.UseVisualStyleBackColor = False
        '
        'TimKiem_DocGia_Khanh_23_nhom5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(657, 397)
        Me.Controls.Add(Me.btnTaiLai)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnQLTC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView_TKDG)
        Me.Controls.Add(Me.btnTK)
        Me.Controls.Add(Me.txtDK2)
        Me.Controls.Add(Me.txtDK1)
        Me.Controls.Add(Me.cbbDK2)
        Me.Controls.Add(Me.cbbDK1)
        Me.Controls.Add(Me.cbbDK)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "TimKiem_DocGia_Khanh_23_nhom5"
        Me.Text = "TimKiem_DocGia_Khanh_23_nhom5"
        CType(Me.DataGridView_TKDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbbDK As ComboBox
    Friend WithEvents cbbDK1 As ComboBox
    Friend WithEvents cbbDK2 As ComboBox
    Friend WithEvents txtDK1 As TextBox
    Friend WithEvents txtDK2 As TextBox
    Friend WithEvents btnTK As Button
    Friend WithEvents DataGridView_TKDG As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnQLTC As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnTaiLai As Button
End Class
