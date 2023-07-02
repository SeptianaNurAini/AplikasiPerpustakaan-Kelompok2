Imports System.Data.SqlClient

Module Module1
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Ds As DataSet
    Public Rd As SqlDataReader
    Public Cmd As SqlCommand
    Public MyDB As String
    Public Sub Koneksi()
        MyDB = ("Data Source=DESKTOP-D0VI36U;user id = sa; password=123456; Integrated Security=True;
                                                 initial catalog=DB_PERPUS")
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

End Module
