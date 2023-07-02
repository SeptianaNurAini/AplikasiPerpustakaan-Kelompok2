<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanPeminjaman
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
        GroupBox1 = New GroupBox()
        rbblnthn = New RadioButton()
        rbsemua = New RadioButton()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        DataGridView1 = New DataGridView()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbblnthn)
        GroupBox1.Controls.Add(rbsemua)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Location = New Point(211, 22)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(324, 122)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Laporan Bulanan"' 
        ' rbblnthn
        ' 
        rbblnthn.AutoSize = True
        rbblnthn.Location = New Point(6, 47)
        rbblnthn.Name = "rbblnthn"
        rbblnthn.Size = New Size(92, 19)
        rbblnthn.TabIndex = 81
        rbblnthn.TabStop = True
        rbblnthn.Text = "Bulan/Tahun"
        rbblnthn.UseVisualStyleBackColor = True
        ' 
        ' rbsemua
        ' 
        rbsemua.AutoSize = True
        rbsemua.Location = New Point(6, 22)
        rbsemua.Name = "rbsemua"
        rbsemua.Size = New Size(61, 19)
        rbsemua.TabIndex = 80
        rbsemua.TabStop = True
        rbsemua.Text = "Semua"
        rbsemua.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"2023", "2024", "2025", "2026", "2027"})
        ComboBox2.Location = New Point(231, 47)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(65, 23)
        ComboBox2.TabIndex = 79
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        ComboBox1.Location = New Point(104, 47)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(110, 23)
        ComboBox1.TabIndex = 78
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(21, 162)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(708, 270)
        DataGridView1.TabIndex = 1
        ' 
        ' FormLaporanPeminjaman
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(746, 451)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Name = "FormLaporanPeminjaman"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Laporan Peminjaman"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents rbblnthn As RadioButton
    Friend WithEvents rbsemua As RadioButton
End Class
