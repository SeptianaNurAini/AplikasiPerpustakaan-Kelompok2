<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterBuku
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
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Label5 = New Label()
        Label6 = New Label()
        TextBox4 = New TextBox()
        TextBox6 = New TextBox()
        ComboBox1 = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(588, 232)
        Button4.Name = "Button4"
        Button4.Size = New Size(109, 38)
        Button4.TabIndex = 22
        Button4.Text = "TUTUP"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(454, 232)
        Button3.Name = "Button3"
        Button3.Size = New Size(115, 38)
        Button3.TabIndex = 21
        Button3.Text = "HAPUS"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(325, 232)
        Button2.Name = "Button2"
        Button2.Size = New Size(111, 38)
        Button2.TabIndex = 20
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(194, 232)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 38)
        Button1.TabIndex = 19
        Button1.Text = "INPUT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(181, 86)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(516, 22)
        TextBox3.TabIndex = 17
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(181, 54)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(516, 22)
        TextBox2.TabIndex = 16
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(181, 23)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(255, 22)
        TextBox1.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(25, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 32)
        Label4.TabIndex = 11
        Label4.Text = "Penerbit"' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(25, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 32)
        Label3.TabIndex = 12
        Label3.Text = "Pengarang"' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(25, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 32)
        Label2.TabIndex = 13
        Label2.Text = "Judul"' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(25, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 32)
        Label1.TabIndex = 14
        Label1.Text = "Kode Buku"' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(25, 285)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(749, 193)
        DataGridView1.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(25, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(155, 32)
        Label5.TabIndex = 23
        Label5.Text = "Tahun"' 
        ' Label6
        ' 
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(25, 182)
        Label6.Name = "Label6"
        Label6.Size = New Size(155, 32)
        Label6.TabIndex = 24
        Label6.Text = "Jumlah"' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(181, 118)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(516, 22)
        TextBox4.TabIndex = 25
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox6.Location = New Point(181, 182)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(137, 22)
        TextBox6.TabIndex = 27
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(181, 149)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(137, 23)
        ComboBox1.TabIndex = 28
        ' 
        ' FormMasterBuku
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(800, 549)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        ForeColor = SystemColors.ControlText
        Name = "FormMasterBuku"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormMasterBuku"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
