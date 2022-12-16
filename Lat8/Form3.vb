Imports System.IO
Public Class Form3
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If Not String.IsNullOrEmpty(Form1.data_perpustakaan.GSFotoKoleksi) Then
            PictBook.Load(Form1.data_perpustakaan.GSFotoKoleksi)
            PictBook.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblNamaKoleksiValue.Text = Form1.data_perpustakaan.GSNama
        LblJenisKoleksiValue.Text = Form1.data_perpustakaan.GSJenisKoleksi
        LblDeskripsiValue.Text = Form1.data_perpustakaan.GSDeskripsi
        LblPenerbitValue.Text = Form1.data_perpustakaan.GSPenerbit
        LblTahunTerbitValue.Text = Form1.data_perpustakaan.GSTahunTerbit
        LblLokasiRakValue.Text = Form1.data_perpustakaan.GSLokasiRak
        LblTanggalMasukKoleksiValue.Text = Form1.data_perpustakaan.GSTanggalMasukKoleksi
        LblStokValue.Text = Form1.data_perpustakaan.GSStok
        LblBahasaValue.Text = Form1.data_perpustakaan.GSBahasa

        ListBoxKategori.Items.Clear()

        For Each kel In Form1.data_perpustakaan.GSKategori
            ListBoxKategori.Items.Add(kel)
        Next

        Form1.data_perpustakaan.GSKategori.Clear()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class