Imports System.IO
Public Class Form2

    'Public Shared foto_buku
    'Public Shared nama As String
    'Public Shared jenis_koleksi As String
    'Public Shared deskripsi As String
    'Public Shared penerbit As String
    'Public Shared tahun_terbit As String
    'Public Shared lokasi_rak As String
    'Public Shared tanggal_masuk_koleksi As String
    'Public Shared stok As String
    'Public Shared bahasa As String
    'Public Shared kategori As New List(Of String)

    Dim max_char_deskripsi = 50

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Photo"
        OpenFileDialog1.Filter = "Image|*.bpm|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        PictureBook.Load(OpenFileDialog1.FileName)
        PictureBook.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub TxtNamaKoleksi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNamaKoleksi.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Insert String Only")
        End If
    End Sub

    Private Sub RtbDeskripsi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RtbDeskripsi.KeyPress
        If RtbDeskripsi.Text.Length >= max_char_deskripsi Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Max Length")
            End If
        End If
    End Sub

    Private Sub RdnBahasaIndonesia_CheckedChanged(sender As Object, e As EventArgs) Handles RdnBahasaIndonesia.CheckedChanged
        Form1.data_perpustakaan.GSBahasa = "Bahasa Indonesia"
    End Sub

    Private Sub RdnBahasaInggris_CheckedChanged(sender As Object, e As EventArgs) Handles RdnBahasaInggris.CheckedChanged
        Form1.data_perpustakaan.GSBahasa = "Bahasa Inggris"
    End Sub

    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        Form1.data_perpustakaan.GSNama = TxtNamaKoleksi.Text
        Form1.data_perpustakaan.GSJenisKoleksi = CbJenisKoleksi.SelectedItem()
        Form1.data_perpustakaan.GSDeskripsi = RtbDeskripsi.Text
        Form1.data_perpustakaan.GSPenerbit = TxtPenerbit.Text
        Form1.data_perpustakaan.GSTahunTerbit = TxtTahunTerbit.Text
        Form1.data_perpustakaan.GSLokasiRak = TxtLokasiRak.Text
        Form1.data_perpustakaan.GSTanggalMasukKoleksi = TanggalMasukKoleksi.Value.ToShortDateString
        Form1.data_perpustakaan.GSStok = TxtStok.Text
        Form1.data_perpustakaan.GSFotoKoleksi = OpenFileDialog1.FileName

        If ChckSains.Checked() Then
            Form1.data_perpustakaan.GSKategori.Add("Sains")
        End If

        If ChckSosial.Checked() Then
            Form1.data_perpustakaan.GSKategori.Add("Sosial")
        End If

        If ChckTeknologi.Checked() Then
            Form1.data_perpustakaan.GSKategori.Add("Teknologi")
        End If

        If ChckBudaya.Checked() Then
            Form1.data_perpustakaan.GSKategori.Add("Budaya")
        End If

        Dim tampilkan_koleksi = New Form3()
        tampilkan_koleksi.Show()

        Me.Close()

        Form1.ListBoxKoleksi.Items.Add(Form1.data_perpustakaan.GSNama)

        Dim convertedKoleksi = Form1.data_perpustakaan.ConvertKoleksiToString(Form1.data_perpustakaan.GSKategori)
        Form1.data_perpustakaan.AddKoleksiDataTable(Form1.data_perpustakaan.GSFotoKoleksi,
                                                    Form1.data_perpustakaan.GSNama,
                                                    Form1.data_perpustakaan.GSJenisKoleksi,
                                                    Form1.data_perpustakaan.GSPenerbit,
                                                    Form1.data_perpustakaan.GSDeskripsi,
                                                    Form1.data_perpustakaan.GSTahunTerbit,
                                                    Form1.data_perpustakaan.GSLokasiRak,
                                                    Form1.data_perpustakaan.GSTanggalMasukKoleksi,
                                                    Form1.data_perpustakaan.GSStok,
                                                    Form1.data_perpustakaan.GSBahasa,
                                                    convertedKoleksi)
    End Sub
End Class