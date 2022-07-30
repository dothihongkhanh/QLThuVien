<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLDanhMuc_Khanh_23_Nhom5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QLDanhMuc_Khanh_23_Nhom5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaDM = New System.Windows.Forms.TextBox()
        Me.txtTenDM = New System.Windows.Forms.TextBox()
        Me.btnThemDM = New System.Windows.Forms.Button()
        Me.btnLuuDM = New System.Windows.Forms.Button()
        Me.btnSuaDM = New System.Windows.Forms.Button()
        Me.btnXoaDM = New System.Windows.Forms.Button()
        Me.DataGridView_DM = New System.Windows.Forms.DataGridView()
        Me.btnQLTC = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        CType(Me.DataGridView_DM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(315, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ DANH MỤC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã danh mục"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên danh mục"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtMaDM
        '
        Me.txtMaDM.Location = New System.Drawing.Point(135, 99)
        Me.txtMaDM.Name = "txtMaDM"
        Me.txtMaDM.Size = New System.Drawing.Size(198, 24)
        Me.txtMaDM.TabIndex = 3
        '
        'txtTenDM
        '
        Me.txtTenDM.Location = New System.Drawing.Point(135, 153)
        Me.txtTenDM.Name = "txtTenDM"
        Me.txtTenDM.Size = New System.Drawing.Size(198, 24)
        Me.txtTenDM.TabIndex = 4
        '
        'btnThemDM
        '
        Me.btnThemDM.BackColor = System.Drawing.Color.Lime
        Me.btnThemDM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemDM.Location = New System.Drawing.Point(45, 207)
        Me.btnThemDM.Name = "btnThemDM"
        Me.btnThemDM.Size = New System.Drawing.Size(90, 45)
        Me.btnThemDM.TabIndex = 5
        Me.btnThemDM.Text = "Thêm"
        Me.btnThemDM.UseVisualStyleBackColor = False
        '
        'btnLuuDM
        '
        Me.btnLuuDM.BackColor = System.Drawing.Color.Lime
        Me.btnLuuDM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuuDM.Location = New System.Drawing.Point(216, 208)
        Me.btnLuuDM.Name = "btnLuuDM"
        Me.btnLuuDM.Size = New System.Drawing.Size(90, 45)
        Me.btnLuuDM.TabIndex = 6
        Me.btnLuuDM.Text = "Lưu"
        Me.btnLuuDM.UseVisualStyleBackColor = False
        '
        'btnSuaDM
        '
        Me.btnSuaDM.BackColor = System.Drawing.Color.Lime
        Me.btnSuaDM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaDM.Location = New System.Drawing.Point(39, 280)
        Me.btnSuaDM.Name = "btnSuaDM"
        Me.btnSuaDM.Size = New System.Drawing.Size(90, 45)
        Me.btnSuaDM.TabIndex = 7
        Me.btnSuaDM.Text = "Sửa"
        Me.btnSuaDM.UseVisualStyleBackColor = False
        '
        'btnXoaDM
        '
        Me.btnXoaDM.BackColor = System.Drawing.Color.Lime
        Me.btnXoaDM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaDM.Location = New System.Drawing.Point(216, 280)
        Me.btnXoaDM.Name = "btnXoaDM"
        Me.btnXoaDM.Size = New System.Drawing.Size(90, 45)
        Me.btnXoaDM.TabIndex = 8
        Me.btnXoaDM.Text = "Xóa"
        Me.btnXoaDM.UseVisualStyleBackColor = False
        '
        'DataGridView_DM
        '
        Me.DataGridView_DM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_DM.Location = New System.Drawing.Point(382, 99)
        Me.DataGridView_DM.Name = "DataGridView_DM"
        Me.DataGridView_DM.RowHeadersWidth = 51
        Me.DataGridView_DM.RowTemplate.Height = 24
        Me.DataGridView_DM.Size = New System.Drawing.Size(402, 249)
        Me.DataGridView_DM.TabIndex = 9
        '
        'btnQLTC
        '
        Me.btnQLTC.BackColor = System.Drawing.Color.Salmon
        Me.btnQLTC.Location = New System.Drawing.Point(61, 36)
        Me.btnQLTC.Name = "btnQLTC"
        Me.btnQLTC.Size = New System.Drawing.Size(158, 32)
        Me.btnQLTC.TabIndex = 10
        Me.btnQLTC.Text = "Quay lại trang chủ"
        Me.btnQLTC.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.White
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(696, 34)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(77, 34)
        Me.btnThoat.TabIndex = 11
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'QLDanhMuc_Khanh_23_Nhom5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(815, 377)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnQLTC)
        Me.Controls.Add(Me.DataGridView_DM)
        Me.Controls.Add(Me.btnXoaDM)
        Me.Controls.Add(Me.btnSuaDM)
        Me.Controls.Add(Me.btnLuuDM)
        Me.Controls.Add(Me.btnThemDM)
        Me.Controls.Add(Me.txtTenDM)
        Me.Controls.Add(Me.txtMaDM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "QLDanhMuc_Khanh_23_Nhom5"
        Me.Text = "QLDanhMuc_Khanh_23_Nhom5"
        CType(Me.DataGridView_DM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaDM As TextBox
    Friend WithEvents txtTenDM As TextBox
    Friend WithEvents btnThemDM As Button
    Friend WithEvents btnLuuDM As Button
    Friend WithEvents btnSuaDM As Button
    Friend WithEvents btnXoaDM As Button
    Friend WithEvents DataGridView_DM As DataGridView
    Friend WithEvents btnQLTC As Button
    Friend WithEvents btnThoat As Button
End Class
