﻿Imports System.Data.SqlClient

Public Class FormMasterAnggota
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        ComboBox1.Enabled = False
        Button1.Text = "INPUT"
        Button2.Text = "EDIT"
        Button3.Text = "HAPUS"
        Button4.Text = "TUTUP"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Call Koneksi()
        Da = New SqlDataAdapter("select * from tbl_anggota", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_anggota")
        DataGridView1.DataSource = (Ds.Tables("tbl_anggota"))
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Laki-Laki")
        ComboBox1.Items.Add("Perempuan")
    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        ComboBox1.Enabled = True
    End Sub


    Private Sub FormMasterAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Pastikan semua data terisi", vbCritical)
            Else
                Call Koneksi()
                Dim SimpanData As String = "insert into tbl_anggota values('" & TextBox1.Text & "', '" & TextBox2.Text & "','" & ComboBox1.Text & "', '" & TextBox3.Text & "',  '" & TextBox4.Text & "' )"
                Cmd = New SqlCommand(SimpanData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil di simpan", vbInformation)
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "EDIT" Then
            Button2.Text = "SIMPAN"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Pastikan semua data terisi", vbCritical)
            Else
                Call Koneksi()
                Dim EditData As String = "update tbl_anggota set namaanggota= '" & TextBox2.Text & "', alamatanggota='" & TextBox3.Text & "', telpanggota='" & TextBox4.Text & "', jeniskelamin='" & ComboBox1.Text & "' where kodeanggota= '" & TextBox1.Text & "'"
                Cmd = New SqlCommand(EditData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil di edit", vbInformation)
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "HAPUS" Then
            Button3.Text = "BUANG"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "BATAL"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Pastikan semua data terisi", vbCritical)
            Else
                Call Koneksi()
                Dim HapusData As String = "delete tbl_anggota where kodeanggota='" & TextBox1.Text & "'"
                Cmd = New SqlCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil di hapus!")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "TUTUP" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("select * from tbl_anggota where  kodeanggota='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox2.Text = Rd.Item("NamaAnggota")
                TextBox3.Text = Rd.Item("AlamatAnggota")
                TextBox4.Text = Rd.Item("TelpAnggota")
                ComboBox1.Text = Rd.Item("JenisKelamin")
            Else
                MsgBox("Data tidak ada")
            End If
        End If
    End Sub
End Class