Imports System.Windows
Imports MySql.Data.MySqlClient
Module Module1
    Dim str As String = "server = localhost; user id = root; password = ; database = visual;"
    Public db As New MySqlConnection(str)
    Public myCommand As MySqlCommand
    Public myAdapter As MySqlDataAdapter
    Public myDataset As DataSet
    Public myReader As MySqlDataReader

    Public Sub bukaDB()
        Try
            tutupDB()
            db.Open()
            MessageBox.Show("Connection Successfully", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show("Caution!" & ex.Message, "connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub tutupDB()
        If db.State = ConnectionState.Open Then
            db.Close()
        End If
    End Sub

    Public Sub tambahMatkul(ByVal idMatkul As String, ByVal namaMatkul As String, namaDosen As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "INSERT INTO matkul (idMatkul, namaMatkul, namaDosen) VALUES (@idMatkul, @namaMatkul, @namaDosen)"
        myCommand.Parameters.AddWithValue("@idMatkul", idMatkul)
        myCommand.Parameters.AddWithValue("@namaMatkul", namaMatkul)
        myCommand.Parameters.AddWithValue("@namaDosen", namaDosen)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            tutupDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")
        Finally
            tutupDB()
        End Try
    End Sub

    Public Function getTabelTugas() As DataTable
        Dim myViewTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT matkul.namaMatkul, matkul.namaDosen, tugas.judul, tugas.kategori, tugas.tenggat FROM matkul JOIN tugas ON matkul.namaMatkul = tugas.namaMatkul", db)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet
            myAdapter.Fill(myDataset)
            myViewTable = myDataset.Tables(0)
            Return (myViewTable)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            tutupDB()
        End Try
    End Function

    Public Sub tambahTugas(ByVal idTugas As String, ByVal matkul As String, ByVal judul As String, ByVal kategori As String, ByVal tenggat As DateTime)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "INSERT INTO tugas (idTugas, namaMatkul, judul, kategori, tenggat) VALUES (@idTugas, @namaMatkul, @judul, @kategori, @tenggat)"
        myCommand.Parameters.AddWithValue("@idTugas", idTugas)
        myCommand.Parameters.AddWithValue("@namaMatkul", matkul)
        myCommand.Parameters.AddWithValue("@judul", judul)
        myCommand.Parameters.AddWithValue("@kategori", kategori)
        myCommand.Parameters.AddWithValue("@tenggat", tenggat)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            tutupDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")
        Finally
            tutupDB()
        End Try
    End Sub

    Public Sub hapusMatkul(ByVal namaMatkul As String)
        Dim query As String = "DELETE FROM matkul WHERE namaMatkul = @namaMatkul"

        Try
            bukaDB()
            Using myCommand As New MySqlCommand(query, db)
                myCommand.Parameters.AddWithValue("@namaMatkul", namaMatkul)
                myCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat menghapus data: " & ex.Message)
        Finally
            tutupDB()
        End Try
    End Sub

    Public Sub TugasSelesai(ByVal judul As String, ByVal namaMatkul As String)
        Dim query As String = "DELETE FROM tugas WHERE judul = @judul AND namaMatkul = @namaMatkul"

        Try
            bukaDB()
            Using myCommand As New MySqlCommand(query, db)
                myCommand.Parameters.AddWithValue("@judul", judul)
                myCommand.Parameters.AddWithValue("@namaMatkul", namaMatkul)
                myCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat menghapus data: " & ex.Message)
        Finally
            tutupDB()
        End Try
    End Sub

    Public Sub editMatkul(ByVal idMatkul As String, ByVal namaMatkul As String, ByVal namaDosen As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "UPDATE matkul SET namaMatkul = @namaMatkulBaru, namaDosen = @namaDosenBaru WHERE idMatkul = @idMatkul"
        myCommand.Parameters.AddWithValue("@idMatkul", idMatkul)
        myCommand.Parameters.AddWithValue("@namaMatkulBaru", namaMatkul)
        myCommand.Parameters.AddWithValue("@namaDosenBaru", namaDosen)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            tutupDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")
        Finally
            tutupDB()
        End Try
    End Sub


End Module