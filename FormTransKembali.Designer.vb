<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransKembali
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
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Label11 = New Label()
        Timer1 = New Timer(components)
        LBLDenda = New Label()
        Label14 = New Label()
        LBLLamaPjm = New Label()
        Label13 = New Label()
        LBLNoPjm = New Label()
        Label12 = New Label()
        LBLJudul = New Label()
        Label10 = New Label()
        TextBox1 = New TextBox()
        Label9 = New Label()
        LBLNamaPetugas = New Label()
        LBLJam = New Label()
        LBLTanggalKbl = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        LBLNamaAgt = New Label()
        LBLNomorKbl = New Label()
        LBL_Denda = New Label()
        LBLTglPjm = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label17 = New Label()
        TxtKodeAGT = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TxtDibayar = New TextBox()
        Label5 = New Label()
        LBLKembali = New Label()
        Label18 = New Label()
        LBLTotal = New Label()
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        Label16 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(220, 351)
        Button4.Name = "Button4"
        Button4.Size = New Size(87, 30)
        Button4.TabIndex = 62
        Button4.Text = "TUTUP"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(130, 351)
        Button3.Name = "Button3"
        Button3.Size = New Size(84, 30)
        Button3.TabIndex = 61
        Button3.Text = "BATAL"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(41, 351)
        Button2.Name = "Button2"
        Button2.Size = New Size(83, 30)
        Button2.TabIndex = 60
        Button2.Text = "SIMPAN"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(706, 110)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 30)
        Button1.TabIndex = 58
        Button1.Text = "Input"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(634, 112)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(66, 23)
        TextBox2.TabIndex = 57
        TextBox2.Text = "TexBox2"' 
        ' Label11
        ' 
        Label11.BorderStyle = BorderStyle.Fixed3D
        Label11.Location = New Point(568, 112)
        Label11.Name = "Label11"
        Label11.Size = New Size(60, 23)
        Label11.TabIndex = 56
        Label11.Text = "Jml"' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' LBLDenda
        ' 
        LBLDenda.BorderStyle = BorderStyle.Fixed3D
        LBLDenda.Location = New Point(645, 351)
        LBLDenda.Name = "LBLDenda"
        LBLDenda.Size = New Size(148, 26)
        LBLDenda.TabIndex = 68
        LBLDenda.Text = "LBLDenda"' 
        ' Label14
        ' 
        Label14.BorderStyle = BorderStyle.Fixed3D
        Label14.Location = New Point(533, 351)
        Label14.Name = "Label14"
        Label14.Size = New Size(106, 26)
        Label14.TabIndex = 67
        Label14.Text = "Denda"' 
        ' LBLLamaPjm
        ' 
        LBLLamaPjm.BorderStyle = BorderStyle.Fixed3D
        LBLLamaPjm.Location = New Point(513, 148)
        LBLLamaPjm.Name = "LBLLamaPjm"
        LBLLamaPjm.Size = New Size(98, 26)
        LBLLamaPjm.TabIndex = 66
        LBLLamaPjm.Text = "LBLLamaPjm"' 
        ' Label13
        ' 
        Label13.BorderStyle = BorderStyle.Fixed3D
        Label13.Location = New Point(304, 148)
        Label13.Name = "Label13"
        Label13.Size = New Size(98, 26)
        Label13.TabIndex = 65
        Label13.Text = "Tgl Pinjam"' 
        ' LBLNoPjm
        ' 
        LBLNoPjm.BorderStyle = BorderStyle.Fixed3D
        LBLNoPjm.Location = New Point(163, 148)
        LBLNoPjm.Name = "LBLNoPjm"
        LBLNoPjm.Size = New Size(135, 26)
        LBLNoPjm.TabIndex = 64
        LBLNoPjm.Text = "LBLNoPjm"' 
        ' Label12
        ' 
        Label12.BorderStyle = BorderStyle.Fixed3D
        Label12.Location = New Point(38, 148)
        Label12.Name = "Label12"
        Label12.Size = New Size(124, 26)
        Label12.TabIndex = 63
        Label12.Text = "No Pinjam"' 
        ' LBLJudul
        ' 
        LBLJudul.BorderStyle = BorderStyle.Fixed3D
        LBLJudul.Location = New Point(304, 112)
        LBLJudul.Name = "LBLJudul"
        LBLJudul.Size = New Size(258, 23)
        LBLJudul.TabIndex = 55
        LBLJudul.Text = "LBLJudul"' 
        ' Label10
        ' 
        Label10.BorderStyle = BorderStyle.Fixed3D
        Label10.Location = New Point(250, 112)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 23)
        Label10.TabIndex = 54
        Label10.Text = "Judul"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(144, 110)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 53
        TextBox1.Text = "TextBox1"' 
        ' Label9
        ' 
        Label9.BorderStyle = BorderStyle.Fixed3D
        Label9.Location = New Point(38, 110)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 23)
        Label9.TabIndex = 52
        Label9.Text = "Kode Buku"' 
        ' LBLNamaPetugas
        ' 
        LBLNamaPetugas.BorderStyle = BorderStyle.Fixed3D
        LBLNamaPetugas.Location = New Point(626, 82)
        LBLNamaPetugas.Name = "LBLNamaPetugas"
        LBLNamaPetugas.Size = New Size(163, 23)
        LBLNamaPetugas.TabIndex = 51
        LBLNamaPetugas.Text = "LBLNamaPetugas"' 
        ' LBLJam
        ' 
        LBLJam.BorderStyle = BorderStyle.Fixed3D
        LBLJam.Location = New Point(626, 53)
        LBLJam.Name = "LBLJam"
        LBLJam.Size = New Size(163, 23)
        LBLJam.TabIndex = 50
        LBLJam.Text = "LBLJam"' 
        ' LBLTanggalKbl
        ' 
        LBLTanggalKbl.BorderStyle = BorderStyle.Fixed3D
        LBLTanggalKbl.Location = New Point(626, 23)
        LBLTanggalKbl.Name = "LBLTanggalKbl"
        LBLTanggalKbl.Size = New Size(163, 23)
        LBLTanggalKbl.TabIndex = 49
        LBLTanggalKbl.Text = "LBLTanggalKbl"' 
        ' Label8
        ' 
        Label8.BorderStyle = BorderStyle.Fixed3D
        Label8.Location = New Point(556, 82)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 23)
        Label8.TabIndex = 48
        Label8.Text = "Petugas"' 
        ' Label7
        ' 
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Location = New Point(556, 53)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 23)
        Label7.TabIndex = 47
        Label7.Text = "Jam"' 
        ' Label6
        ' 
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.Location = New Point(556, 23)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 23)
        Label6.TabIndex = 46
        Label6.Text = "Tanggal"' 
        ' LBLNamaAgt
        ' 
        LBLNamaAgt.BorderStyle = BorderStyle.Fixed3D
        LBLNamaAgt.Location = New Point(250, 51)
        LBLNamaAgt.Name = "LBLNamaAgt"
        LBLNamaAgt.Size = New Size(276, 23)
        LBLNamaAgt.TabIndex = 43
        LBLNamaAgt.Text = "LBLNamaAgt"' 
        ' LBLNomorKbl
        ' 
        LBLNomorKbl.BorderStyle = BorderStyle.Fixed3D
        LBLNomorKbl.Location = New Point(144, 23)
        LBLNomorKbl.Name = "LBLNomorKbl"
        LBLNomorKbl.Size = New Size(121, 23)
        LBLNomorKbl.TabIndex = 41
        LBLNomorKbl.Text = "LBLNomorKbl"' 
        ' LBL_Denda
        ' 
        LBL_Denda.BorderStyle = BorderStyle.Fixed3D
        LBL_Denda.Location = New Point(692, 148)
        LBL_Denda.Name = "LBL_Denda"
        LBL_Denda.Size = New Size(100, 23)
        LBL_Denda.TabIndex = 39
        LBL_Denda.Text = "LBL_Denda"' 
        ' LBLTglPjm
        ' 
        LBLTglPjm.BorderStyle = BorderStyle.Fixed3D
        LBLTglPjm.Location = New Point(408, 148)
        LBLTglPjm.Name = "LBLTglPjm"
        LBLTglPjm.Size = New Size(99, 23)
        LBLTglPjm.TabIndex = 38
        LBLTglPjm.Text = "LBLTglPjm"' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Location = New Point(38, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 37
        Label2.Text = "Kode Anggota"' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Location = New Point(38, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 36
        Label1.Text = "No Kembali"' 
        ' Label17
        ' 
        Label17.BorderStyle = BorderStyle.Fixed3D
        Label17.Location = New Point(294, 23)
        Label17.Name = "Label17"
        Label17.Size = New Size(100, 23)
        Label17.TabIndex = 72
        Label17.Text = "Telah Pinjam"' 
        ' TxtKodeAGT
        ' 
        TxtKodeAGT.Location = New Point(144, 51)
        TxtKodeAGT.Name = "TxtKodeAGT"
        TxtKodeAGT.Size = New Size(100, 23)
        TxtKodeAGT.TabIndex = 74
        TxtKodeAGT.Text = "TXTKODEAGT"' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Location = New Point(615, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 26)
        Label3.TabIndex = 75
        Label3.Text = "Denda"' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Location = New Point(533, 377)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 26)
        Label4.TabIndex = 67
        Label4.Text = "Di Bayar"' 
        ' TxtDibayar
        ' 
        TxtDibayar.Location = New Point(645, 380)
        TxtDibayar.Name = "TxtDibayar"
        TxtDibayar.Size = New Size(148, 23)
        TxtDibayar.TabIndex = 76
        TxtDibayar.Text = "TxtDibayar"' 
        ' Label5
        ' 
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Location = New Point(533, 403)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 26)
        Label5.TabIndex = 67
        Label5.Text = "Kembali"' 
        ' LBLKembali
        ' 
        LBLKembali.BorderStyle = BorderStyle.Fixed3D
        LBLKembali.Location = New Point(645, 403)
        LBLKembali.Name = "LBLKembali"
        LBLKembali.Size = New Size(148, 26)
        LBLKembali.TabIndex = 67
        LBLKembali.Text = "LBLKembali"' 
        ' Label18
        ' 
        Label18.BorderStyle = BorderStyle.Fixed3D
        Label18.Location = New Point(323, 351)
        Label18.Name = "Label18"
        Label18.Size = New Size(106, 26)
        Label18.TabIndex = 67
        Label18.Text = "Total Kembali"' 
        ' LBLTotal
        ' 
        LBLTotal.BorderStyle = BorderStyle.Fixed3D
        LBLTotal.Location = New Point(435, 351)
        LBLTotal.Name = "LBLTotal"
        LBLTotal.Size = New Size(86, 26)
        LBLTotal.TabIndex = 68
        LBLTotal.Text = "LBLTotal"' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(37, 189)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(756, 145)
        DataGridView1.TabIndex = 77
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(39, 439)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(757, 126)
        DataGridView2.TabIndex = 78
        ' 
        ' Label16
        ' 
        Label16.BorderStyle = BorderStyle.Fixed3D
        Label16.Location = New Point(400, 23)
        Label16.Name = "Label16"
        Label16.Size = New Size(100, 23)
        Label16.TabIndex = 79
        Label16.Text = "LBLTelahPinjam"' 
        ' FormTransKembali
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(830, 688)
        Controls.Add(Label16)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Controls.Add(TxtDibayar)
        Controls.Add(Label3)
        Controls.Add(TxtKodeAGT)
        Controls.Add(Label17)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label11)
        Controls.Add(LBLTotal)
        Controls.Add(LBLDenda)
        Controls.Add(LBLKembali)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label18)
        Controls.Add(Label14)
        Controls.Add(LBLLamaPjm)
        Controls.Add(Label13)
        Controls.Add(LBLNoPjm)
        Controls.Add(Label12)
        Controls.Add(LBLJudul)
        Controls.Add(Label10)
        Controls.Add(TextBox1)
        Controls.Add(Label9)
        Controls.Add(LBLNamaPetugas)
        Controls.Add(LBLJam)
        Controls.Add(LBLTanggalKbl)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(LBLNamaAgt)
        Controls.Add(LBLNomorKbl)
        Controls.Add(LBL_Denda)
        Controls.Add(LBLTglPjm)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormTransKembali"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Pengembalian Buku"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LBLTelahPinjam As Label
    Friend WithEvents LBLDenda As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LBLLamaPjm As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LBLNoPjm As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LBLJudul As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LBLNamaPetugas As Label
    Friend WithEvents LBLJam As Label
    Friend WithEvents LBLTanggalKbl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LBLNamaAgt As Label
    Friend WithEvents LBLNomorKbl As Label
    Friend WithEvents LBL_Denda As Label
    Friend WithEvents LBLTglPjm As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    'Friend WithEvents LBLTelahPinjam As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtKodeAGT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDibayar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLKembali As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents LBLTotal As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label16 As Label
End Class
