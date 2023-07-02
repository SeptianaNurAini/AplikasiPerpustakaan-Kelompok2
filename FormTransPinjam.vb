Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormTransPinjam
    Sub KondisiAwal()
        Call NoOtomatis()
        Call MunculKodeAnggota()
        LBLNamaPetugas.Text = Form1.STLabel4.Text
        LBLNama.Text = ""
        LBLAlamat.Text = ""
        LBLTelepon.Text = ""
        LBLJudul.Text = ""
        LBLPengarang.Text = ""
        LBLTahun.Text = ""
        LBLTotalBuku.Text = ""
        ComboBox1.Text = ""
        Call BuatKolom()
    End Sub
    Private Sub FormTransPinjam_Load(sender As Object, e As EventArgs)
        Call KondisiAwal()
        LBLTanggal.Text = Today

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        LBLJam.Text = TimeOfDay
    End Sub

    Sub NoOtomatis()
        Call Koneksi()
        Cmd = New SqlCommand("Select * from TBL_PINJAM where NoPinjam in (select max(NoPinjam) from TBL_PINJAM)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "PJM" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "PJM" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNoPinjam.Text = UrutanKode
        'TextBox2.Focus()
    End Sub
    Sub MunculKodeAnggota()
        Call Koneksi()
        ComboBox1.Items.Clear()
        Cmd = New SqlCommand("Select * from tbl_anggota", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Call Koneksi()
        Cmd = New SqlCommand("select * from tbl_anggota where  kodeanggota='" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNama.Text = Rd!NamaAnggota
            LBLAlamat.Text = Rd!AlamatAnggota
            LBLTelepon.Text = Rd!TelpAnggota
            Call CekPinjaman()
        End If

    End Sub


    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode Buku")
        DataGridView1.Columns.Add("Judul", "Judul Buku")
        DataGridView1.Columns.Add("Pengarang", "Pengarang")
        DataGridView1.Columns.Add("Penerbit", "Penerbit")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("select *from tbl_buku where kodebuku='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Buku tidak ada", vbCritical)
            Else
                TextBox1.Text = Rd.Item("KodeBuku")
                LBLJudul.Text = Rd.Item("JudulBuku")
                LBLPengarang.Text = Rd.Item("PengarangBuku")
                LBLTahun.Text = Rd.Item("TahunBuku")
                TextBox2.Enabled = True
                TextBox2.Text = "1"
            End If
        End If
    End Sub

    Sub RumusTotalBuku()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + DataGridView1.Rows(i).Cells(4).Value
            LBLTotalBuku.Text = HitungItem
        Next
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If LBLNama.Text = "" Or Label9.Text = "" Then
            MsgBox("Transaksi Tidak Ada, silahkan lakukan transaksi terlebih dahulu", vbCritical)
        Else
            Call Koneksi()
            Dim tglsql As String
            tglsql = Format(Today, "yyyy-MM-dd")
            Dim PinjamBuku As String = "insert into tbl_pinjam values ('" & LBLNoPinjam.Text & "', '" & tglsql & "', '" & LBLJam.Text & "', '" & ComboBox1.Text & "', '" & LBLTotalBuku.Text & "', '" & LBLTotalBuku.Text & "' , '" & Form1.STLabel2.Text & "')"
            Cmd = New SqlCommand(PinjamBuku, Conn)
            Cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Call Koneksi()
                Dim SimpanDetail As String = "insert into tbl_detailpinjam values('" & LBLNoPinjam.Text & "', '" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(4).Value & "')"
                Cmd = New SqlCommand(SimpanDetail, Conn)
                Cmd.ExecuteNonQuery()
                Call Koneksi()
                Cmd = New SqlCommand("select * from tbl_buku where kodebuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Call Koneksi()
                Dim KurangiStok As String = "update tbl_buku set StokBuku = '" & Rd.Item("StokBuku") - DataGridView1.Rows(Baris).Cells(4).Value & "' where KodeBuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                Cmd = New SqlCommand(KurangiStok, Conn)
                Cmd.ExecuteNonQuery()

            Next
            Call KondisiAwal()
            MsgBox("Transaksi Telah Berhasil Disimpan", vbInformation)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Call KondisiAwal()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If Val(LBLTelahPinjam.Text) + Val(LBLTotalBuku.Text) >= 5 Or Val(LBLTotalBuku.Text) + Val(TextBox2.Text) > 5 Then
            MsgBox("Buku yang dipinjam melebihi maksimal!", vbCritical)
        Else
            If LBLJudul.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Silahkan masukkan Kode Buku dan Tekan ENTER!", vbCritical)

            Else
                DataGridView1.Rows.Add(New String() {TextBox1.Text, LBLJudul.Text, LBLPengarang.Text, LBLTahun.Text, TextBox2.Text})
                TextBox1.Text = ""
                TextBox2.Text = ""
                LBLJudul.Text = ""
                TextBox2.Text = ""
                LBLPengarang.Text = ""
                LBLTahun.Text = ""
                Call RumusTotalBuku()
            End If
        End If
    End Sub

    Sub CekPinjaman()
        Call Koneksi()
        Da = New SqlDataAdapter("select tbl_buku.KodeBuku,JudulBuku,JumlahBuku from tbl_anggota, tbl_pinjam,tbl_buku,tbl_detailpinjam where tbl_buku.kodebuku=tbl_detailpinjam.kodebuku and tbl_pinjam.nopinjam=tbl_detailpinjam.nopinjam and tbl_anggota.kodeanggota=tbl_pinjam.kodeanggota and tbl_anggota.kodeanggota='" & ComboBox1.Text & "' AND tbl_detailpinjam.jumlahbuku>0", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Detail")
        DataGridView2.DataSource = Ds.Tables("Detail")
        LBLTelahPinjam.Text = DataGridView2.Rows.Count - 1
        DataGridView2.ReadOnly = True

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class