<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimKiem_PhieuMuon_Khanh_23_nhom5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTKThang = New System.Windows.Forms.TextBox()
        Me.DataGridView_TKPM = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView_TKPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TÌM KIẾM PHIẾU MƯỢN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tìm theo tháng mượn"
        '
        'txtTKThang
        '
        Me.txtTKThang.Location = New System.Drawing.Point(324, 80)
        Me.txtTKThang.Name = "txtTKThang"
        Me.txtTKThang.Size = New System.Drawing.Size(111, 24)
        Me.txtTKThang.TabIndex = 2
        '
        'DataGridView_TKPM
        '
        Me.DataGridView_TKPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_TKPM.Location = New System.Drawing.Point(12, 122)
        Me.DataGridView_TKPM.Name = "DataGridView_TKPM"
        Me.DataGridView_TKPM.RowHeadersWidth = 51
        Me.DataGridView_TKPM.RowTemplate.Height = 24
        Me.DataGridView_TKPM.Size = New System.Drawing.Size(578, 145)
        Me.DataGridView_TKPM.TabIndex = 4
        '
        'TimKiem_PhieuMuon_Khanh_23_nhom5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 337)
        Me.Controls.Add(Me.DataGridView_TKPM)
        Me.Controls.Add(Me.txtTKThang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "TimKiem_PhieuMuon_Khanh_23_nhom5"
        Me.Text = "TimKiem_PhieuMuon"
        CType(Me.DataGridView_TKPM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTKThang As TextBox
    Friend WithEvents DataGridView_TKPM As DataGridView
End Class
