Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormTransKembali
    Private Sub KondisiAwal()
        TxtKodeAGT.Text = ""
        LBLNamaAgt.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        LBLJudul.Text = ""
        TextBox2.Text = ""
        LBLTglPjm.Text = ""
        LBLLamaPjm.Text = ""
        LBL_Denda.Text = ""
        LBLNoPjm.Text = ""

        TxtDibayar.Text = ""
        LBLDenda.Text = ""
        LBLKembali.Text = ""
        Label16.Text = ""


    End Sub
    Private Sub KondisiAwal2()
        TextBox1.Text = ""
        TextBox2.Text = ""
        LBLJudul.Text = ""
        TextBox2.Text = ""
        LBLTglPjm.Text = ""
        LBLLamaPjm.Text = ""
        LBL_Denda.Text = ""
        LBLNoPjm.Text = ""
        TxtDibayar.Text = ""
        LBLDenda.Text = ""
        LBLKembali.Text = ""
    End Sub

    Sub TampilGrid()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode Buku")
        DataGridView1.Columns.Add("Nomor", "Nomor Pinjam")
        DataGridView1.Columns.Add("Judul", "Judul Buku")
        DataGridView1.Columns.Add("Jumlah", "Jumlah Pinjam")
        DataGridView1.Columns.Add("Tanggal", "Tanggal Pinjam")
        DataGridView1.Columns.Add("Lama", "Lama Pinjam")
        DataGridView1.Columns.Add("Denda", "Denda")
        'DataGridView1.Columns(0).Width = 70
        'DataGridView1.Columns(1).Width = 75
        ' DataGridView1.Columns(2).Width = 150
        'DataGridView1.Columns(3).Width = 50
        'DataGridView1.Columns(4).Width = 75
        'DataGridView1.Columns(5).Width = 50
        'DataGridView1.Columns(6).Width = 75


    End Sub
    Sub TampilGrid2()
        DataGridView2.Columns.Add("Kode", "Kode")
        DataGridView2.Columns.Add("Judul", "Judul Buku")
        DataGridView2.Columns.Add("Jumlah", "Jumlah")
        DataGridView2.ReadOnly = True
    End Sub
    Sub Otomatis()
        Call Koneksi()
        Cmd = New SqlCommand("Select * from TBL_KEMBALI where NoKembali in (select max(NoKembali) from TBL_KEMBALI)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "KBL" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "KBL" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNomorKbl.Text = UrutanKode
        'TextBox2.Focus()
    End Sub

    Private Sub FormTransKembali_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Koneksi()
        Call Otomatis()
        LBLTanggalKbl.Text = Today
    End Sub

    Private Sub FormTransKembali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call Koneksi()
        Call TampilGrid()
        ' Call HapusMaster()
        Call Otomatis()
        LBLNamaPetugas.Text = Form1.STLabel4.Text

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub
    Sub Pinjaman()
        Call Koneksi()
        Da = New SqlDataAdapter("Select TBL_BUKU.KodeBuku, JudulBuku, JumlahBuku From TBL_Anggota, Tbl_Pinjam,Tbl_buku, Tbl_detailPinjam where tbl_buku.kodebuku = tbl_detailpinjam.kodebuku and tbl_pinjam.NoPinjam=TBL_DetailPinjam.NoPinjam and TBL_Anggota.kodeAnggota = TBL_Pinjam.Kodeanggota and TBL_Anggota.KodeAnggota = '" & TxtKodeAGT.Text & "' and TBL_DetailPinjam.JumlahBuku>0", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Detail")
        DataGridView2.DataSource = Ds.Tables("Detail")
        DataGridView2.ReadOnly = True
        DataGridView2.Columns(0).Width = 80
        DataGridView2.Columns(1).Width = 300
        DataGridView2.Columns(2).Width = 100
    End Sub
    Sub CariData()
        Call Koneksi()
        Cmd = New SqlCommand("Select * From TBL_ANggota where KodeAnggota= '" & TxtKodeAGT.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNamaAgt.Text = Rd.Item("NamaAnggota")
            Call Koneksi()
            Cmd = New SqlCommand("Select KodeAnggota From tbl_pinjam where KodeAnggota =  '" & TxtKodeAGT.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Call Koneksi()
                Cmd = New SqlCommand("Select SUM(TotalPinjam) as Ketemu From TBL_Pinjam where KodeAnggota =  '" & TxtKodeAGT.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Label16.Text = Rd.Item(0)
                Call Pinjaman()
            End If
        End If
    End Sub

    Private Sub TxtKodeAGT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKodeAGT.KeyPress
        If e.KeyChar = Chr(13) Then
            Call CariData()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("Select distinct TBL_Buku.KodeBuku, TBL_DetailPinjam.NoPinjam, JudulBuku, JumlahBuku, TglPinjam From TBL_Anggota, Tbl_pinjam, Tbl_Buku, Tbl_detailPinjam where TBL_Buku.KodeBuku=TBL_DetailPinjam.KodeBuku and Tbl_Pinjam.NoPinjam = TBL_detailPinjam.NoPinjam and Tbl_Anggota.KodeAnggota = Tbl_pinjam.KodeAnggota and Tbl_Anggota.KodeAnggota = '" & TxtKodeAGT.Text & "' and TBL_DetailPinjam.KodeBuku = '" & TextBox1.Text & "'and TBL_DetailPinjam.JumlahBuku>0", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Buku Bukan Yang dipinjam")
            Else
                LBLNoPjm.Text = Rd.Item(1)
                LBLJudul.Text = Rd.Item(2)
                LBLTglPjm.Text = Rd.Item(4)
                TextBox2.Text = Rd.Item(3)
                LBLLamaPjm.Text = DateDiff(DateInterval.Day, Rd.Item(4), Today())
                If LBLLamaPjm.Text > 5 Then
                    LBL_Denda.Text = Val((LBLLamaPjm.Text - 5) * 1000)
                Else
                    LBL_Denda.Text = 0
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Add(New String() {TextBox1.Text, LBLNoPjm.Text, LBLJudul.Text, TextBox2.Text, LBLTglPjm.Text, LBLLamaPjm.Text, LBL_Denda.Text})
        Call HapusMaster()
        Call TotalDenda()
        Call TotalKembali()
    End Sub

    Sub HapusMaster()
        TextBox1.Text = ""
        LBLNoPjm.Text = ""
        LBLJudul.Text = ""
        LBLTglPjm.Text = ""
        TextBox2.Text = ""
        LBLLamaPjm.Text = ""
        LBL_Denda.Text = ""
    End Sub
    Sub TotalDenda()
        Dim subtot As Integer = 0
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            subtot += Val(DataGridView1.Rows(I).Cells(6).Value)
            LBLDenda.Text = subtot
        Next
    End Sub
    Sub TotalKembali()
        Dim subtot As Integer = 0
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            subtot += Val(DataGridView1.Rows(I).Cells(3).Value)
            LBLTotal.Text = subtot
        Next
    End Sub

    Private Sub TxtDibayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDibayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TxtDibayar.Text) < Val(LBLDenda.Text) Then
                MsgBox("Pembayaran Kurang", vbCritical)
                TxtDibayar.Focus()
            ElseIf Val(TxtDibayar.Text) = Val(LBLDenda.Text) Then
                LBLKembali.Text = 0
                Button2.Focus()
            Else
                LBLKembali.Text = Val(LBLDenda.Text) - Val(TxtDibayar.Text)
                Button2.Focus()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TxtKodeAGT.Text = "" Or LBLDenda.Text = "" Or LBLKembali.Text = "" Then
            MsgBox("Transaksi Tidak ada, silahkan lakukan transaksi lebih dahulu ", vbCritical)
        Else
            Call Koneksi()
            Dim tglsql As String
            tglsql = Format(Today, "yyyy-MM-dd")
            Dim BukuKembali As String = "Insert into tbl_kembali(NoKembali, TglKembali, TotalKembali, Denda, Dibayar, Kembali, KodeAnggota, KodePetugas) values ('" & LBLNomorKbl.Text & "', '" & tglsql & "', '" & LBLTotal.Text & "', '" & TxtDibayar.Text & "', '" & LBLDenda.Text & "', '" & LBLKembali.Text & "', '" & TxtKodeAGT.Text & "', '" & Form1.STLabel2.Text & "')"
            Cmd = New SqlCommand(BukuKembali, Conn)
            Cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Call Koneksi()
                Dim SimpanDetail As String = "Insert into tbl_detailkembali (NoKembali,KodeBuku,JumlahBuku) values('" & LBLNomorKbl.Text & "', '" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(3).Value & "')"
                Cmd = New SqlCommand(SimpanDetail, Conn)
                Cmd.ExecuteNonQuery()

                'update buku
                Call Koneksi()
                Cmd = New SqlCommand("select * from tbl_buku where kodebuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Call Koneksi()
                Dim KurangiStok As String = "update tbl_buku set StokBuku = '" & Rd.Item("StokBuku") + DataGridView1.Rows(Baris).Cells(3).Value & "' where KodeBuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                Cmd = New SqlCommand(KurangiStok, Conn)
                Cmd.ExecuteNonQuery()

                ''update pinjam buku
                'Call Koneksi()
                'Cmd = New SqlCommand("select * from tbl_buku where kodebuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                'Rd = Cmd.ExecuteReader
                'Rd.Read()
                'Call Koneksi()
                'Dim UpdatePinjamBuku As String = "update tbl_buku set StokBuku = '" & Rd.Item("StokBuku") + DataGridView1.Rows(Baris).Cells(3).Value & "' where KodeBuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                'Cmd = New SqlCommand(UpdatePinjamBuku, Conn)
                'Cmd.ExecuteNonQuery()

                'update detail pinjam
                Call Koneksi()
                Cmd = New SqlCommand("select JumlahBuku from TBL_detailPinjam where KodeBuku= '" & DataGridView1.Rows(Baris).Cells(0).Value & "' and NoPinjam= '" & DataGridView1.Rows(Baris).Cells(1).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    Call Koneksi()
                    Dim updatedetailpinjam As String = "update TBL_detailPinjam set JumlahBuku='" & Rd.Item(0) - DataGridView1.Rows(Baris).Cells(3).Value & " ' where KodeBuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "' and NoPinjam= '" & DataGridView1.Rows(Baris).Cells(1).Value & "'"
                    Cmd = New SqlCommand(updatedetailpinjam, Conn)
                    Cmd.ExecuteNonQuery()
                End If

                'Update Total Pinjam
                Call Koneksi()
                Cmd = New SqlCommand("select totalPinjam from TBL_pinjam where NoPinjam='" & DataGridView1.Rows(Baris).Cells(1).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    Call Koneksi()
                    Dim Sqleditpjm As String = "update TBL_pinjam set totalPinjam='" & Rd.Item(0) - DataGridView1.Rows(Baris).Cells(3).Value & "' where NoPinjam='" & DataGridView1.Rows(Baris).Cells(1).Value & "'"
                    Cmd = New SqlCommand(Sqleditpjm, Conn)
                    Cmd.ExecuteNonQuery()
                End If

            Next
            Call KondisiAwal()
            Call Otomatis()
            DataGridView1.Columns.Clear()
            DataGridView2.Columns.Clear()
            MsgBox("Transaksi Telah Berhasil Disimpan", vbInformation)
            Call TampilGrid()
        End If
    End Sub


End Class