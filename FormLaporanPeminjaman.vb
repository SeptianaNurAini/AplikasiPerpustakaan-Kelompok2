Imports System.Data.SqlClient
Public Class FormLaporanPeminjaman
    Dim nobln As String


    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    AxCrystalReport.SelectionFormula = "Month({TBL_PINJAM.TglPinjam})='" & ComboBox1.Value & "'"
    '    AxCrystalReport.ReportFileName = "Month({TBL_PINJAM.TglPinjam})='" & ComboBox1.Value & "'"
    'End Sub


    Private Sub FormLaporanPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tampildatablnthn()
    End Sub
    Sub tampilsemua()
        Call Koneksi()
        Da = New SqlDataAdapter("select * from tbl_pinjam", Conn)
        'Da = New SqlDataAdapter("select tbl_pinjam.NoPinjam, tbl_pinjam.TglPinjam, tbl_pinjam.KodeAnggota, 
        '                        tbl_detailpinjam.KodeBuku from tbl_pinjam, tbl_detailpinjam
        '                        where tbl_pinjam.nopinjam = tbl_detailpinjam.nopinjam", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tbl_pinjam")
        DataGridView1.DataSource = (Ds.Tables("tbl_pinjam"))
    End Sub
    Sub tampil()
        If rbsemua.Checked = True Then
            tampilsemua()
        ElseIf rbblnthn.Checked = True Then
            tampilblnthn()
        End If
    End Sub
    Sub tampildatablnthn()
        Dim i As Integer
        For i = 2022 To Year(Now)
            ComboBox2.Items.Add(i)
        Next
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("")
        ComboBox1.Items.Add("Januari")
        ComboBox1.Items.Add("Februari")
        ComboBox1.Items.Add("Maret")
        ComboBox1.Items.Add("April")
        ComboBox1.Items.Add("Mei")
        ComboBox1.Items.Add("Juni")
        ComboBox1.Items.Add("Juli")
        ComboBox1.Items.Add("Agustus")
        ComboBox1.Items.Add("September")
        ComboBox1.Items.Add("Oktober")
        ComboBox1.Items.Add("November")
        ComboBox1.Items.Add("Desember")


    End Sub

    Sub tampilblnthn()
        If ComboBox1.Text <> "" And ComboBox2.Text <> "" Then
            Try
                Me.Cursor = Cursors.WaitCursor
                Call Koneksi()
                Ds = New DataSet
                'Dim Str As String = "select tbl_pinjam.NoPinjam, tbl_detailpinjam.KodeBuku where month(tglpinjam) = '" & nobln & "' 
                '           from tbl_pinjam, tbl_detailpinjam where tbl_pinjam.nopinjam = tbl_detailpinjam.nopinjam and year (tglpinjam) = '" & ComboBox2.Text & "' order by tglpinjam"

                Dim Str As String = "select * from tbl_pinjam where month(tglpinjam) = '" & nobln & "' and year (tglpinjam) = '" & ComboBox2.Text & "' order by tglpinjam"
                Da = New SqlDataAdapter(Str, Conn)
                Da.Fill(Ds)

                DataGridView1.DataSource = Ds.Tables(0)
                Me.Cursor = Cursors.Default
                Conn.Close()
                Conn.Dispose()

            Catch ex As Exception

            End Try
        ElseIf ComboBox1.Text = "" And ComboBox2.Text <> "" Then
            Try
                Me.Cursor = Cursors.WaitCursor
                Call Koneksi()
                Ds = New DataSet
                Dim Str As String = "select * from tbl_pinjam where  year (tglpinjam) = '" & ComboBox2.Text & "' order by tglpinjam"
                Da = New SqlDataAdapter(Str, Conn)
                Da.Fill(Ds)

                DataGridView1.DataSource = Ds.Tables(0)
                Me.Cursor = Cursors.Default
                Conn.Close()
                Conn.Dispose()

            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Januari" Then
            nobln = "01"
        ElseIf ComboBox1.Text = "Februari" Then
            nobln = "02"
        ElseIf ComboBox1.Text = "Maret" Then
            nobln = "03"
        ElseIf ComboBox1.Text = "April" Then
            nobln = "04"
        ElseIf ComboBox1.Text = "Mei" Then
            nobln = "05"
        ElseIf ComboBox1.Text = "Juni" Then
            nobln = "06"
        ElseIf ComboBox1.Text = "Juli" Then
            nobln = "07"
        ElseIf ComboBox1.Text = "Agustus" Then
            nobln = "08"
        ElseIf ComboBox1.Text = "September" Then
            nobln = "09"
        ElseIf ComboBox1.Text = "Oktober" Then
            nobln = "10"
        ElseIf ComboBox1.Text = "November" Then
            nobln = "11"
        ElseIf ComboBox1.Text = "Desember" Then
            nobln = "12"
        Else
            nobln = "00"
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub rbsemua_CheckedChanged(sender As Object, e As EventArgs) Handles rbsemua.CheckedChanged
        tampil()
    End Sub

    Private Sub rbblnthn_CheckedChanged(sender As Object, e As EventArgs) Handles rbblnthn.CheckedChanged
        tampil()
    End Sub
End Class