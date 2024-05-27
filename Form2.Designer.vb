<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNamaMatkul = New System.Windows.Forms.TextBox()
        Me.TxtNamaDosen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtSimpan = New System.Windows.Forms.Button()
        Me.TxtIdMatkul = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Matkul:"
        '
        'TxtNamaMatkul
        '
        Me.TxtNamaMatkul.Location = New System.Drawing.Point(116, 50)
        Me.TxtNamaMatkul.Name = "TxtNamaMatkul"
        Me.TxtNamaMatkul.Size = New System.Drawing.Size(179, 20)
        Me.TxtNamaMatkul.TabIndex = 1
        '
        'TxtNamaDosen
        '
        Me.TxtNamaDosen.Location = New System.Drawing.Point(116, 94)
        Me.TxtNamaDosen.Name = "TxtNamaDosen"
        Me.TxtNamaDosen.Size = New System.Drawing.Size(179, 20)
        Me.TxtNamaDosen.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Dosen:"
        '
        'BtSimpan
        '
        Me.BtSimpan.Location = New System.Drawing.Point(116, 135)
        Me.BtSimpan.Name = "BtSimpan"
        Me.BtSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtSimpan.TabIndex = 4
        Me.BtSimpan.Text = "Simpan"
        Me.BtSimpan.UseVisualStyleBackColor = True
        '
        'TxtIdMatkul
        '
        Me.TxtIdMatkul.Location = New System.Drawing.Point(116, 12)
        Me.TxtIdMatkul.Name = "TxtIdMatkul"
        Me.TxtIdMatkul.Size = New System.Drawing.Size(179, 20)
        Me.TxtIdMatkul.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ID Matkul:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 182)
        Me.Controls.Add(Me.TxtIdMatkul)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtSimpan)
        Me.Controls.Add(Me.TxtNamaDosen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNamaMatkul)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNamaMatkul As TextBox
    Friend WithEvents TxtNamaDosen As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtSimpan As Button
    Friend WithEvents TxtIdMatkul As TextBox
    Friend WithEvents Label3 As Label
End Class
