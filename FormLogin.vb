Imports System.Data.SqlClient

Public Class FormLogin
    Sub BukaKunci()
        Form1.LoginToolStripMenuItem.Enabled = False
        Form1.LogoutToolStripMenuItem.Enabled = True
        Form1.MasterToolStripMenuItem.Enabled = True
        Form1.TransaksiToolStripMenuItem.Enabled = True

        Form1.LaporanToolStripMenuItem.Enabled = True

        Form1.PictureBox1.Enabled = True
        Form1.PictureBox2.Enabled = True
        Form1.PictureBox3.Enabled = True
        Form1.PictureBox4.Enabled = True
        Form1.PictureBox5.Enabled = True
        Form1.PictureBox6.Enabled = True
        Form1.PictureBox7.Enabled = True


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Koneksi()
        Cmd = New SqlCommand("select * from TBL_PETUGAS where KodePetugas='" & TextBox1.Text & "' and PasswordPetugas='" & TextBox2.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Me.Close()
            Call BukaKunci()
            Form1.STLabel2.Text = Rd!KodePetugas
            Form1.STLabel4.Text = Rd!NamaPetugas
            Form1.STLabel6.Text = Rd!LevelPetugas
        Else
            MsgBox("Kode Petugas atau Pssword Salah!", vbCritical)
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "PTG001"
        TextBox2.Text = "admin"
        TextBox2.PasswordChar = "*"
    End Sub
End Class