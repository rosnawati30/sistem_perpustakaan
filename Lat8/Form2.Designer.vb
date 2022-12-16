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
        Me.PictureBook = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNamaKoleksi = New System.Windows.Forms.TextBox()
        Me.CbJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.RtbDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.TxtTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TxtLokasiRak = New System.Windows.Forms.TextBox()
        Me.TanggalMasukKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdnBahasaInggris = New System.Windows.Forms.RadioButton()
        Me.RdnBahasaIndonesia = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChckBudaya = New System.Windows.Forms.CheckBox()
        Me.ChckTeknologi = New System.Windows.Forms.CheckBox()
        Me.ChckSosial = New System.Windows.Forms.CheckBox()
        Me.ChckSains = New System.Windows.Forms.CheckBox()
        Me.BtnTambahKoleksi = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBook
        '
        Me.PictureBook.Location = New System.Drawing.Point(12, 60)
        Me.PictureBook.Name = "PictureBook"
        Me.PictureBook.Size = New System.Drawing.Size(136, 154)
        Me.PictureBook.TabIndex = 0
        Me.PictureBook.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tambah Koleksi"
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(12, 220)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(136, 23)
        Me.BtnTambahGambar.TabIndex = 2
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Koleksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(182, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jenis Koleksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(182, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Deskripsi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(182, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Penerbit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(182, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Tahun Terbit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(182, 382)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tanggal Masuk Koleksi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(182, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Lokasi Rak"
        '
        'TxtNamaKoleksi
        '
        Me.TxtNamaKoleksi.Location = New System.Drawing.Point(359, 60)
        Me.TxtNamaKoleksi.Name = "TxtNamaKoleksi"
        Me.TxtNamaKoleksi.Size = New System.Drawing.Size(231, 22)
        Me.TxtNamaKoleksi.TabIndex = 10
        '
        'CbJenisKoleksi
        '
        Me.CbJenisKoleksi.FormattingEnabled = True
        Me.CbJenisKoleksi.Items.AddRange(New Object() {"Jurnal", "Novel", "Kamus", "E-Book", "Ensiklopedia"})
        Me.CbJenisKoleksi.Location = New System.Drawing.Point(359, 106)
        Me.CbJenisKoleksi.Name = "CbJenisKoleksi"
        Me.CbJenisKoleksi.Size = New System.Drawing.Size(231, 24)
        Me.CbJenisKoleksi.TabIndex = 11
        '
        'RtbDeskripsi
        '
        Me.RtbDeskripsi.Location = New System.Drawing.Point(359, 148)
        Me.RtbDeskripsi.Name = "RtbDeskripsi"
        Me.RtbDeskripsi.Size = New System.Drawing.Size(231, 96)
        Me.RtbDeskripsi.TabIndex = 12
        Me.RtbDeskripsi.Text = ""
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(359, 260)
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(231, 22)
        Me.TxtPenerbit.TabIndex = 13
        '
        'TxtTahunTerbit
        '
        Me.TxtTahunTerbit.Location = New System.Drawing.Point(359, 299)
        Me.TxtTahunTerbit.Name = "TxtTahunTerbit"
        Me.TxtTahunTerbit.Size = New System.Drawing.Size(231, 22)
        Me.TxtTahunTerbit.TabIndex = 14
        '
        'TxtLokasiRak
        '
        Me.TxtLokasiRak.Location = New System.Drawing.Point(359, 340)
        Me.TxtLokasiRak.Name = "TxtLokasiRak"
        Me.TxtLokasiRak.Size = New System.Drawing.Size(231, 22)
        Me.TxtLokasiRak.TabIndex = 15
        '
        'TanggalMasukKoleksi
        '
        Me.TanggalMasukKoleksi.Location = New System.Drawing.Point(359, 382)
        Me.TanggalMasukKoleksi.Name = "TanggalMasukKoleksi"
        Me.TanggalMasukKoleksi.Size = New System.Drawing.Size(231, 22)
        Me.TanggalMasukKoleksi.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(182, 418)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Stok"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(182, 560)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Kategori"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(182, 457)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 16)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Bahasa"
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(359, 418)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(231, 22)
        Me.TxtStok.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdnBahasaInggris)
        Me.GroupBox1.Controls.Add(Me.RdnBahasaIndonesia)
        Me.GroupBox1.Location = New System.Drawing.Point(359, 457)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 83)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'RdnBahasaInggris
        '
        Me.RdnBahasaInggris.AutoSize = True
        Me.RdnBahasaInggris.Location = New System.Drawing.Point(7, 48)
        Me.RdnBahasaInggris.Name = "RdnBahasaInggris"
        Me.RdnBahasaInggris.Size = New System.Drawing.Size(118, 20)
        Me.RdnBahasaInggris.TabIndex = 1
        Me.RdnBahasaInggris.TabStop = True
        Me.RdnBahasaInggris.Text = "Bahasa Inggris"
        Me.RdnBahasaInggris.UseVisualStyleBackColor = True
        '
        'RdnBahasaIndonesia
        '
        Me.RdnBahasaIndonesia.AutoSize = True
        Me.RdnBahasaIndonesia.Location = New System.Drawing.Point(7, 22)
        Me.RdnBahasaIndonesia.Name = "RdnBahasaIndonesia"
        Me.RdnBahasaIndonesia.Size = New System.Drawing.Size(137, 20)
        Me.RdnBahasaIndonesia.TabIndex = 0
        Me.RdnBahasaIndonesia.TabStop = True
        Me.RdnBahasaIndonesia.Text = "Bahasa Indonesia"
        Me.RdnBahasaIndonesia.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChckBudaya)
        Me.GroupBox2.Controls.Add(Me.ChckTeknologi)
        Me.GroupBox2.Controls.Add(Me.ChckSosial)
        Me.GroupBox2.Controls.Add(Me.ChckSains)
        Me.GroupBox2.Location = New System.Drawing.Point(359, 560)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 135)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'ChckBudaya
        '
        Me.ChckBudaya.AutoSize = True
        Me.ChckBudaya.Location = New System.Drawing.Point(6, 100)
        Me.ChckBudaya.Name = "ChckBudaya"
        Me.ChckBudaya.Size = New System.Drawing.Size(76, 20)
        Me.ChckBudaya.TabIndex = 3
        Me.ChckBudaya.Text = "Budaya"
        Me.ChckBudaya.UseVisualStyleBackColor = True
        '
        'ChckTeknologi
        '
        Me.ChckTeknologi.AutoSize = True
        Me.ChckTeknologi.Location = New System.Drawing.Point(6, 74)
        Me.ChckTeknologi.Name = "ChckTeknologi"
        Me.ChckTeknologi.Size = New System.Drawing.Size(90, 20)
        Me.ChckTeknologi.TabIndex = 2
        Me.ChckTeknologi.Text = "Teknologi"
        Me.ChckTeknologi.UseVisualStyleBackColor = True
        '
        'ChckSosial
        '
        Me.ChckSosial.AutoSize = True
        Me.ChckSosial.Location = New System.Drawing.Point(6, 48)
        Me.ChckSosial.Name = "ChckSosial"
        Me.ChckSosial.Size = New System.Drawing.Size(67, 20)
        Me.ChckSosial.TabIndex = 1
        Me.ChckSosial.Text = "Sosial"
        Me.ChckSosial.UseVisualStyleBackColor = True
        '
        'ChckSains
        '
        Me.ChckSains.AutoSize = True
        Me.ChckSains.Location = New System.Drawing.Point(7, 22)
        Me.ChckSains.Name = "ChckSains"
        Me.ChckSains.Size = New System.Drawing.Size(63, 20)
        Me.ChckSains.TabIndex = 0
        Me.ChckSains.Text = "Sains"
        Me.ChckSains.UseVisualStyleBackColor = True
        '
        'BtnTambahKoleksi
        '
        Me.BtnTambahKoleksi.Location = New System.Drawing.Point(457, 713)
        Me.BtnTambahKoleksi.Name = "BtnTambahKoleksi"
        Me.BtnTambahKoleksi.Size = New System.Drawing.Size(133, 40)
        Me.BtnTambahKoleksi.TabIndex = 23
        Me.BtnTambahKoleksi.Text = "Tambah Koleksi"
        Me.BtnTambahKoleksi.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 771)
        Me.Controls.Add(Me.BtnTambahKoleksi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtStok)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TanggalMasukKoleksi)
        Me.Controls.Add(Me.TxtLokasiRak)
        Me.Controls.Add(Me.TxtTahunTerbit)
        Me.Controls.Add(Me.TxtPenerbit)
        Me.Controls.Add(Me.RtbDeskripsi)
        Me.Controls.Add(Me.CbJenisKoleksi)
        Me.Controls.Add(Me.TxtNamaKoleksi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBook)
        Me.Name = "Form2"
        Me.Text = "Tambah Koleksi"
        CType(Me.PictureBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBook As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNamaKoleksi As TextBox
    Friend WithEvents CbJenisKoleksi As ComboBox
    Friend WithEvents RtbDeskripsi As RichTextBox
    Friend WithEvents TxtPenerbit As TextBox
    Friend WithEvents TxtTahunTerbit As TextBox
    Friend WithEvents TxtLokasiRak As TextBox
    Friend WithEvents TanggalMasukKoleksi As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtStok As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdnBahasaInggris As RadioButton
    Friend WithEvents RdnBahasaIndonesia As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ChckSosial As CheckBox
    Friend WithEvents ChckSains As CheckBox
    Friend WithEvents ChckTeknologi As CheckBox
    Friend WithEvents ChckBudaya As CheckBox
    Friend WithEvents BtnTambahKoleksi As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
