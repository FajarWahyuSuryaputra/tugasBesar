Imports MySql.Data.MySqlClient

Public Class Form1
    Sub viewMatkul()
        bukaDB()
        CbMatkul.Items.Clear()
        myCommand = New MySqlCommand("SELECT namaMatkul FROM matkul", db)
        myReader = myCommand.ExecuteReader
        Do While myReader.Read
            CbMatkul.Items.Add(myReader.Item(0))
        Loop
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaDB()
        CbMatkul.Items.Clear()
        viewMatkul()
        DataGridView1.DataSource = getTabelTugas()
    End Sub

    Private Sub BtTambahMatkul_Click(sender As Object, e As EventArgs) Handles BtTambahMatkul.Click
        AddHandler Form2.matkulDitambah, AddressOf viewMatkul
        Form2.Show()
    End Sub

    Private Sub BtSimpan_Click(sender As Object, e As EventArgs) Handles BtSimpan.Click
        If CbMatkul.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(TxtJudul.Text) AndAlso CbKategori.SelectedItem IsNot Nothing Then
            Dim namaMatkul As String = CbMatkul.SelectedItem.ToString()
            Dim judul As String = TxtJudul.Text
            Dim kategori As String = CbKategori.SelectedItem.ToString()
            Dim tenggat As DateTime = DateTimePicker1.Value

            tambahTugas(TxtIdTugas.Text, namaMatkul, judul, kategori, tenggat)

            DataGridView1.DataSource = getTabelTugas()
        Else
            MessageBox.Show("Pastikan semua data sudah diisi.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        CbMatkul.SelectedItem = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString
        TxtJudul.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString
        CbKategori.SelectedItem = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            CbMatkul.SelectedItem = row.Cells("namaMatkul").Value.ToString()
            TxtJudul.Text = row.Cells("judul").Value.ToString()
            CbKategori.Text = row.Cells("kategori").Value.ToString()
            DateTimePicker1.Value = DateTime.Parse(row.Cells("tenggat").Value.ToString())
        End If
    End Sub

    Private Sub BtHapusMatkul_Click(sender As Object, e As EventArgs) Handles BtHapusMatkul.Click
        If CbMatkul.SelectedItem IsNot Nothing Then
            Dim namaMatkul As String = CbMatkul.SelectedItem.ToString()
            Dim confirmResult As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus mata kuliah ini?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo)
            If confirmResult = DialogResult.Yes Then
                hapusMatkul(namaMatkul)
                viewMatkul()
                DataGridView1.DataSource = getTabelTugas()
            End If
        Else
            MessageBox.Show("Pilih mata kuliah yang ingin dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub BtSelesai_Click(sender As Object, e As EventArgs) Handles BtSelesai.Click
        If TxtJudul.Text IsNot Nothing Then
            TugasSelesai(TxtJudul.Text, CbMatkul.SelectedItem.ToString)

            DataGridView1.DataSource = getTabelTugas()
        Else
            MessageBox.Show("Pilih Judul Tugas yang Telah Selesai.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtEdit_Click(sender As Object, e As EventArgs) Handles BtEdit.Click
        Form3.Show()
    End Sub

    Private Sub CbMatkul_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMatkul.SelectedIndexChanged
        Form3.tampilForEdit(CbMatkul.SelectedItem.ToString())
    End Sub
End Class
