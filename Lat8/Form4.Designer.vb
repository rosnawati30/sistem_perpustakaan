﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.LabelKoleksi = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah ingin menghapus koleksi?"
        '
        'LabelKoleksi
        '
        Me.LabelKoleksi.AutoSize = True
        Me.LabelKoleksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKoleksi.ForeColor = System.Drawing.Color.Red
        Me.LabelKoleksi.Location = New System.Drawing.Point(190, 109)
        Me.LabelKoleksi.Name = "LabelKoleksi"
        Me.LabelKoleksi.Size = New System.Drawing.Size(104, 25)
        Me.LabelKoleksi.TabIndex = 1
        Me.LabelKoleksi.Text = "Koleksi A"
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(195, 184)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(99, 33)
        Me.BtnHapus.TabIndex = 2
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 252)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LabelKoleksi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Hapus Koleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelKoleksi As Label
    Friend WithEvents BtnHapus As Button
End Class
