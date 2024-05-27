<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtHapusMatkul = New System.Windows.Forms.Button()
        Me.BtTambahMatkul = New System.Windows.Forms.Button()
        Me.BtSelesai = New System.Windows.Forms.Button()
        Me.CbKategori = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtSimpan = New System.Windows.Forms.Button()
        Me.CbMatkul = New System.Windows.Forms.ComboBox()
        Me.TxtJudul = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIdTugas = New System.Windows.Forms.TextBox()
        Me.BtEdit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtEdit)
        Me.GroupBox1.Controls.Add(Me.TxtIdTugas)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BtHapusMatkul)
        Me.GroupBox1.Controls.Add(Me.BtTambahMatkul)
        Me.GroupBox1.Controls.Add(Me.BtSelesai)
        Me.GroupBox1.Controls.Add(Me.CbKategori)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtSimpan)
        Me.GroupBox1.Controls.Add(Me.CbMatkul)
        Me.GroupBox1.Controls.Add(Me.TxtJudul)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtHapusMatkul
        '
        Me.BtHapusMatkul.Location = New System.Drawing.Point(312, 48)
        Me.BtHapusMatkul.Name = "BtHapusMatkul"
        Me.BtHapusMatkul.Size = New System.Drawing.Size(103, 23)
        Me.BtHapusMatkul.TabIndex = 10
        Me.BtHapusMatkul.Text = "Hapus Matkul"
        Me.BtHapusMatkul.UseVisualStyleBackColor = True
        '
        'BtTambahMatkul
        '
        Me.BtTambahMatkul.Location = New System.Drawing.Point(312, 17)
        Me.BtTambahMatkul.Name = "BtTambahMatkul"
        Me.BtTambahMatkul.Size = New System.Drawing.Size(103, 23)
        Me.BtTambahMatkul.TabIndex = 7
        Me.BtTambahMatkul.Text = "Tambah Matkul"
        Me.BtTambahMatkul.UseVisualStyleBackColor = True
        '
        'BtSelesai
        '
        Me.BtSelesai.Location = New System.Drawing.Point(312, 126)
        Me.BtSelesai.Name = "BtSelesai"
        Me.BtSelesai.Size = New System.Drawing.Size(103, 23)
        Me.BtSelesai.TabIndex = 6
        Me.BtSelesai.Text = "Selesai"
        Me.BtSelesai.UseVisualStyleBackColor = True
        '
        'CbKategori
        '
        Me.CbKategori.FormattingEnabled = True
        Me.CbKategori.Items.AddRange(New Object() {"individu", "kelompok", "kuis", "ujian", "presentasi."})
        Me.CbKategori.Location = New System.Drawing.Point(94, 103)
        Me.CbKategori.Name = "CbKategori"
        Me.CbKategori.Size = New System.Drawing.Size(200, 21)
        Me.CbKategori.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Kategori:"
        '
        'BtSimpan
        '
        Me.BtSimpan.Location = New System.Drawing.Point(312, 101)
        Me.BtSimpan.Name = "BtSimpan"
        Me.BtSimpan.Size = New System.Drawing.Size(103, 23)
        Me.BtSimpan.TabIndex = 5
        Me.BtSimpan.Text = "Simpan"
        Me.BtSimpan.UseVisualStyleBackColor = True
        '
        'CbMatkul
        '
        Me.CbMatkul.FormattingEnabled = True
        Me.CbMatkul.Location = New System.Drawing.Point(94, 50)
        Me.CbMatkul.Name = "CbMatkul"
        Me.CbMatkul.Size = New System.Drawing.Size(200, 21)
        Me.CbMatkul.TabIndex = 7
        '
        'TxtJudul
        '
        Me.TxtJudul.Location = New System.Drawing.Point(94, 77)
        Me.TxtJudul.Name = "TxtJudul"
        Me.TxtJudul.Size = New System.Drawing.Size(200, 20)
        Me.TxtJudul.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tenggat:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Judul Tugas:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(94, 129)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matakuliah:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(421, 192)
        Me.DataGridView1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ID Matkul:"
        '
        'TxtIdTugas
        '
        Me.TxtIdTugas.Location = New System.Drawing.Point(94, 19)
        Me.TxtIdTugas.Name = "TxtIdTugas"
        Me.TxtIdTugas.Size = New System.Drawing.Size(200, 20)
        Me.TxtIdTugas.TabIndex = 12
        '
        'BtEdit
        '
        Me.BtEdit.Location = New System.Drawing.Point(312, 75)
        Me.BtEdit.Name = "BtEdit"
        Me.BtEdit.Size = New System.Drawing.Size(103, 23)
        Me.BtEdit.TabIndex = 13
        Me.BtEdit.Text = "Edit Matkul"
        Me.BtEdit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 387)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtJudul As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtSimpan As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtSelesai As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CbMatkul As ComboBox
    Friend WithEvents CbKategori As ComboBox
    Friend WithEvents BtTambahMatkul As Button
    Friend WithEvents BtHapusMatkul As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtIdTugas As TextBox
    Friend WithEvents BtEdit As Button
End Class
