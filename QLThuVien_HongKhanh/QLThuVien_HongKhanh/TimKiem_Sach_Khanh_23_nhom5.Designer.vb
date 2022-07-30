<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimKiem_Sach_Khanh_23_nhom5
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
        Me.cbbDK1 = New System.Windows.Forms.ComboBox()
        Me.btnTKS = New System.Windows.Forms.Button()
        Me.DataGridView_TKS = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView_TKS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TÌM KIẾM SÁCH"
        '
        'cbbDK1
        '
        Me.cbbDK1.FormattingEnabled = True
        Me.cbbDK1.Items.AddRange(New Object() {""})
        Me.cbbDK1.Location = New System.Drawing.Point(193, 90)
        Me.cbbDK1.Name = "cbbDK1"
        Me.cbbDK1.Size = New System.Drawing.Size(263, 26)
        Me.cbbDK1.TabIndex = 1
        '
        'btnTKS
        '
        Me.btnTKS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTKS.Location = New System.Drawing.Point(515, 81)
        Me.btnTKS.Name = "btnTKS"
        Me.btnTKS.Size = New System.Drawing.Size(84, 43)
        Me.btnTKS.TabIndex = 6
        Me.btnTKS.Text = "Tải lại"
        Me.btnTKS.UseVisualStyleBackColor = False
        '
        'DataGridView_TKS
        '
        Me.DataGridView_TKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_TKS.Location = New System.Drawing.Point(23, 145)
        Me.DataGridView_TKS.Name = "DataGridView_TKS"
        Me.DataGridView_TKS.RowHeadersWidth = 51
        Me.DataGridView_TKS.RowTemplate.Height = 24
        Me.DataGridView_TKS.Size = New System.Drawing.Size(839, 207)
        Me.DataGridView_TKS.TabIndex = 7
        '
        'TimKiem_Sach_Khanh_23_nhom5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(877, 402)
        Me.Controls.Add(Me.DataGridView_TKS)
        Me.Controls.Add(Me.btnTKS)
        Me.Controls.Add(Me.cbbDK1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "TimKiem_Sach_Khanh_23_nhom5"
        Me.Text = "TimKiem_Sach_Khanh_23_nhom5"
        CType(Me.DataGridView_TKS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbbDK1 As ComboBox
    Friend WithEvents btnTKS As Button
    Friend WithEvents DataGridView_TKS As DataGridView
End Class
