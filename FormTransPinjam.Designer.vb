<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransPinjam
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        LBLNoPinjam = New Label()
        ComboBox1 = New ComboBox()
        LBLNama = New Label()
        LBLAlamat = New Label()
        LBLTelepon = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        LBLTanggal = New Label()
        LBLJam = New Label()
        LBLNamaPetugas = New Label()
        Label9 = New Label()
        TextBox1 = New TextBox()
        Label10 = New Label()
        LBLJudul = New Label()
        Label11 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Timer1 = New Timer(components)
        Label12 = New Label()
        LBLPengarang = New Label()
        Label13 = New Label()
        LBLTahun = New Label()
        Label14 = New Label()
        LBLTotalBuku = New Label()
        DataGridView2 = New DataGridView()
        Label15 = New Label()
        LBLTelahPinjam = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Location = New Point(41, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 0
        Label1.Text = "No Pinjam"' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Location = New Point(41, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 1
        Label2.Text = "Kode Anggota"' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Location = New Point(41, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 2
        Label3.Text = "Nama"' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Location = New Point(41, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 3
        Label4.Text = "Alamat"' 
        ' Label5
        ' 
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Location = New Point(41, 169)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 4
        Label5.Text = "Telepon"' 
        ' LBLNoPinjam
        ' 
        LBLNoPinjam.BorderStyle = BorderStyle.Fixed3D
        LBLNoPinjam.Location = New Point(147, 16)
        LBLNoPinjam.Name = "LBLNoPinjam"
        LBLNoPinjam.Size = New Size(121, 23)
        LBLNoPinjam.TabIndex = 5
        LBLNoPinjam.Text = "LBLNoPinjam"' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(147, 55)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 6
        ' 
        ' LBLNama
        ' 
        LBLNama.BorderStyle = BorderStyle.Fixed3D
        LBLNama.Location = New Point(147, 95)
        LBLNama.Name = "LBLNama"
        LBLNama.Size = New Size(339, 23)
        LBLNama.TabIndex = 7
        LBLNama.Text = "LBLNama"' 
        ' LBLAlamat
        ' 
        LBLAlamat.BorderStyle = BorderStyle.Fixed3D
        LBLAlamat.Location = New Point(147, 134)
        LBLAlamat.Name = "LBLAlamat"
        LBLAlamat.Size = New Size(339, 23)
        LBLAlamat.TabIndex = 8
        LBLAlamat.Text = "LBLAlamat"' 
        ' LBLTelepon
        ' 
        LBLTelepon.BorderStyle = BorderStyle.Fixed3D
        LBLTelepon.Location = New Point(147, 169)
        LBLTelepon.Name = "LBLTelepon"
        LBLTelepon.Size = New Size(339, 23)
        LBLTelepon.TabIndex = 9
        LBLTelepon.Text = "LBLTelepon"' 
        ' Label6
        ' 
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.Location = New Point(501, 16)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 23)
        Label6.TabIndex = 10
        Label6.Text = "Tanggal"' 
        ' Label7
        ' 
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Location = New Point(501, 55)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 23)
        Label7.TabIndex = 11
        Label7.Text = "Jam"' 
        ' Label8
        ' 
        Label8.BorderStyle = BorderStyle.Fixed3D
        Label8.Location = New Point(501, 95)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 23)
        Label8.TabIndex = 12
        Label8.Text = "Petugas"' 
        ' LBLTanggal
        ' 
        LBLTanggal.BorderStyle = BorderStyle.Fixed3D
        LBLTanggal.Location = New Point(571, 16)
        LBLTanggal.Name = "LBLTanggal"
        LBLTanggal.Size = New Size(163, 23)
        LBLTanggal.TabIndex = 13
        LBLTanggal.Text = "LBLTanggal"' 
        ' LBLJam
        ' 
        LBLJam.BorderStyle = BorderStyle.Fixed3D
        LBLJam.Location = New Point(571, 55)
        LBLJam.Name = "LBLJam"
        LBLJam.Size = New Size(163, 23)
        LBLJam.TabIndex = 14
        LBLJam.Text = "LBLJam"' 
        ' LBLNamaPetugas
        ' 
        LBLNamaPetugas.BorderStyle = BorderStyle.Fixed3D
        LBLNamaPetugas.Location = New Point(571, 95)
        LBLNamaPetugas.Name = "LBLNamaPetugas"
        LBLNamaPetugas.Size = New Size(163, 23)
        LBLNamaPetugas.TabIndex = 15
        LBLNamaPetugas.Text = "LBLNamaPetugas"' 
        ' Label9
        ' 
        Label9.BorderStyle = BorderStyle.Fixed3D
        Label9.Location = New Point(41, 204)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 23)
        Label9.TabIndex = 16
        Label9.Text = "Kode Buku"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(147, 204)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.BorderStyle = BorderStyle.Fixed3D
        Label10.Location = New Point(253, 206)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 23)
        Label10.TabIndex = 18
        Label10.Text = "Judul"' 
        ' LBLJudul
        ' 
        LBLJudul.BorderStyle = BorderStyle.Fixed3D
        LBLJudul.Location = New Point(307, 206)
        LBLJudul.Name = "LBLJudul"
        LBLJudul.Size = New Size(258, 23)
        LBLJudul.TabIndex = 19
        LBLJudul.Text = "LBLJudul"' 
        ' Label11
        ' 
        Label11.BorderStyle = BorderStyle.Fixed3D
        Label11.Location = New Point(571, 206)
        Label11.Name = "Label11"
        Label11.Size = New Size(32, 23)
        Label11.TabIndex = 20
        Label11.Text = "Jml"' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(609, 206)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(47, 23)
        TextBox2.TabIndex = 21
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(663, 203)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 30)
        Button1.TabIndex = 22
        Button1.Text = "Input"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(41, 278)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(709, 151)
        DataGridView1.TabIndex = 23
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(474, 465)
        Button2.Name = "Button2"
        Button2.Size = New Size(83, 30)
        Button2.TabIndex = 24
        Button2.Text = "SIMPAN"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(568, 465)
        Button3.Name = "Button3"
        Button3.Size = New Size(84, 30)
        Button3.TabIndex = 25
        Button3.Text = "BATAL"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(663, 465)
        Button4.Name = "Button4"
        Button4.Size = New Size(87, 30)
        Button4.TabIndex = 26
        Button4.Text = "TUTUP"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Label12
        ' 
        Label12.BorderStyle = BorderStyle.Fixed3D
        Label12.Location = New Point(41, 243)
        Label12.Name = "Label12"
        Label12.Size = New Size(124, 26)
        Label12.TabIndex = 27
        Label12.Text = "Pengarang"' 
        ' LBLPengarang
        ' 
        LBLPengarang.BorderStyle = BorderStyle.Fixed3D
        LBLPengarang.Location = New Point(166, 243)
        LBLPengarang.Name = "LBLPengarang"
        LBLPengarang.Size = New Size(296, 26)
        LBLPengarang.TabIndex = 28
        LBLPengarang.Text = "LBLPengarang"' 
        ' Label13
        ' 
        Label13.BorderStyle = BorderStyle.Fixed3D
        Label13.Location = New Point(464, 243)
        Label13.Name = "Label13"
        Label13.Size = New Size(116, 26)
        Label13.TabIndex = 29
        Label13.Text = "Tahun"' 
        ' LBLTahun
        ' 
        LBLTahun.BorderStyle = BorderStyle.Fixed3D
        LBLTahun.Location = New Point(586, 243)
        LBLTahun.Name = "LBLTahun"
        LBLTahun.Size = New Size(151, 26)
        LBLTahun.TabIndex = 30
        LBLTahun.Text = "LBLTahun"' 
        ' Label14
        ' 
        Label14.BorderStyle = BorderStyle.Fixed3D
        Label14.Location = New Point(474, 435)
        Label14.Name = "Label14"
        Label14.Size = New Size(106, 26)
        Label14.TabIndex = 31
        Label14.Text = "Total Buku"' 
        ' LBLTotalBuku
        ' 
        LBLTotalBuku.BorderStyle = BorderStyle.Fixed3D
        LBLTotalBuku.Location = New Point(586, 435)
        LBLTotalBuku.Name = "LBLTotalBuku"
        LBLTotalBuku.Size = New Size(148, 26)
        LBLTotalBuku.TabIndex = 32
        LBLTotalBuku.Text = "LBLTotalBuku"' 
        ' DataGridView2
        ' 
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(44, 511)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(709, 129)
        DataGridView2.TabIndex = 33
        ' 
        ' Label15
        ' 
        Label15.BorderStyle = BorderStyle.Fixed3D
        Label15.Location = New Point(44, 647)
        Label15.Name = "Label15"
        Label15.Size = New Size(97, 23)
        Label15.TabIndex = 34
        Label15.Text = "Telah Pinjam"' 
        ' LBLTelahPinjam
        ' 
        LBLTelahPinjam.BorderStyle = BorderStyle.Fixed3D
        LBLTelahPinjam.Location = New Point(147, 647)
        LBLTelahPinjam.Name = "LBLTelahPinjam"
        LBLTelahPinjam.Size = New Size(97, 23)
        LBLTelahPinjam.TabIndex = 35
        ' 
        ' FormTransPinjam
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(813, 699)
        Controls.Add(LBLTelahPinjam)
        Controls.Add(Label15)
        Controls.Add(DataGridView2)
        Controls.Add(LBLTotalBuku)
        Controls.Add(Label14)
        Controls.Add(LBLTahun)
        Controls.Add(Label13)
        Controls.Add(LBLPengarang)
        Controls.Add(Label12)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label11)
        Controls.Add(LBLJudul)
        Controls.Add(Label10)
        Controls.Add(TextBox1)
        Controls.Add(Label9)
        Controls.Add(LBLNamaPetugas)
        Controls.Add(LBLJam)
        Controls.Add(LBLTanggal)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(LBLTelepon)
        Controls.Add(LBLAlamat)
        Controls.Add(LBLNama)
        Controls.Add(ComboBox1)
        Controls.Add(LBLNoPinjam)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormTransPinjam"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Peminjaman Buku"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLNoPinjam As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LBLNama As Label
    Friend WithEvents LBLAlamat As Label
    Friend WithEvents LBLTelepon As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LBLTanggal As Label
    Friend WithEvents LBLJam As Label
    Friend WithEvents LBLNamaPetugas As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLJudul As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label12 As Label
    Friend WithEvents LBLPengarang As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LBLTahun As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LBLTotalBuku As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents LBLTelahPinjam As Label
End Class
