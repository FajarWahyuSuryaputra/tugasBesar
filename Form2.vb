Public Class Form2
    Public Event matkulDitambah()
    Private Sub BtSimpan_Click(sender As Object, e As EventArgs) Handles BtSimpan.Click
        tambahMatkul(TxtIdMatkul.Text, TxtNamaMatkul.Text, TxtNamaDosen.Text)

        RaiseEvent matkulDitambah()
        Me.Close()
    End Sub
End Class