<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.TxtIdMatkul = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtEdit = New System.Windows.Forms.Button()
        Me.TxtNamaDosenBaru = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNamaMatkulBaru = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtIdMatkul
        '
        Me.TxtIdMatkul.Location = New System.Drawing.Point(112, 11)
        Me.TxtIdMatkul.Name = "TxtIdMatkul"
        Me.TxtIdMatkul.Size = New System.Drawing.Size(179, 20)
        Me.TxtIdMatkul.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ID Matkul:"
        '
        'BtEdit
        '
        Me.BtEdit.Location = New System.Drawing.Point(112, 134)
        Me.BtEdit.Name = "BtEdit"
        Me.BtEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtEdit.TabIndex = 12
        Me.BtEdit.Text = "Edit"
        Me.BtEdit.UseVisualStyleBackColor = True
        '
        'TxtNamaDosenBaru
        '
        Me.TxtNamaDosenBaru.Location = New System.Drawing.Point(112, 93)
        Me.TxtNamaDosenBaru.Name = "TxtNamaDosenBaru"
        Me.TxtNamaDosenBaru.Size = New System.Drawing.Size(179, 20)
        Me.TxtNamaDosenBaru.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nama Dosen:"
        '
        'TxtNamaMatkulBaru
        '
        Me.TxtNamaMatkulBaru.Location = New System.Drawing.Point(112, 49)
        Me.TxtNamaMatkulBaru.Name = "TxtNamaMatkulBaru"
        Me.TxtNamaMatkulBaru.Size = New System.Drawing.Size(179, 20)
        Me.TxtNamaMatkulBaru.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nama Matkul:"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 172)
        Me.Controls.Add(Me.TxtIdMatkul)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtEdit)
        Me.Controls.Add(Me.TxtNamaDosenBaru)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNamaMatkulBaru)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtIdMatkul As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtEdit As Button
    Friend WithEvents TxtNamaDosenBaru As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNamaMatkulBaru As TextBox
    Friend WithEvents Label1 As Label
End Class
