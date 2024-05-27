Imports MySql.Data.MySqlClient

Public Class Form3
    Public Sub tampilForEdit(ByVal namaMatkul As String)
        bukaDB()

        TxtIdMatkul.Text = ""
        TxtNamaMatkulBaru.Text = ""
        TxtNamaDosenBaru.Text = ""

        Dim query As String = "SELECT * FROM matkul WHERE namaMatkul = @namaMatkul"
        Try
            Using myCommand As New MySqlCommand(query, db)
                myCommand.Parameters.AddWithValue("@namaMatkul", namaMatkul)
                Using myReader As MySqlDataReader = myCommand.ExecuteReader()
                    If myReader.Read() Then
                        TxtIdMatkul.Text = myReader("idMatkul").ToString()
                        TxtNamaMatkulBaru.Text = myReader("namaMatkul").ToString()
                        TxtNamaDosenBaru.Text = myReader("namaDosen").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            tutupDB()
        End Try
    End Sub
    Public Sub BtEdit_Click(sender As Object, e As EventArgs) Handles BtEdit.Click
        editMatkul(TxtIdMatkul.Text, TxtNamaMatkulBaru.Text, TxtNamaDosenBaru.Text)

        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaDB()
    End Sub


End Class