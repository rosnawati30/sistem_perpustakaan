Imports System.Text

Public Class DataPerpustakaan
    Private foto_koleksi
    Private nama As String
    Private jenis_koleksi
    Private deskripsi
    Private penerbit
    Private tahun_terbit
    Private lokasi_rak
    Private tanggal_masuk_koleksi
    Private stok
    Private bahasa
    Private kategori As New List(Of String)
    Private koleksiDataTable As New ArrayList()

    Public Property GSFotoKoleksi() As String
        Get
            Return foto_koleksi
        End Get
        Set(value As String)
            foto_koleksi = value
        End Set
    End Property

    Public Property GSNama() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property GSJenisKoleksi() As String
        Get
            Return jenis_koleksi
        End Get
        Set(value As String)
            jenis_koleksi = value
        End Set
    End Property

    Public Property GSDeskripsi() As String
        Get
            Return deskripsi
        End Get
        Set(value As String)
            deskripsi = value
        End Set
    End Property

    Public Property GSPenerbit() As String
        Get
            Return penerbit
        End Get
        Set(value As String)
            penerbit = value
        End Set
    End Property

    Public Property GSTahunTerbit() As String
        Get
            Return tahun_terbit
        End Get
        Set(value As String)
            tahun_terbit = value
        End Set
    End Property

    Public Property GSLokasiRak() As String
        Get
            Return lokasi_rak
        End Get
        Set(value As String)
            lokasi_rak = value
        End Set
    End Property

    Public Property GSTanggalMasukKoleksi() As String
        Get
            Return tanggal_masuk_koleksi
        End Get
        Set(value As String)
            tanggal_masuk_koleksi = value
        End Set
    End Property

    Public Property GSStok() As String
        Get
            Return stok
        End Get
        Set(value As String)
            stok = value
        End Set
    End Property

    Public Property GSBahasa() As String
        Get
            Return bahasa
        End Get
        Set(value As String)
            bahasa = value
        End Set
    End Property

    Public Property GSKategori As List(Of String)
        Get
            Return kategori
        End Get
        Set(value As List(Of String))
            kategori = value
        End Set
    End Property

    Public Function AddKoleksiDataTable(dir_gambar As String,
                                        nama_koleksi As String,
                                        jenis_koleksi As String,
                                        penerbit_koleksi As String,
                                        deskripsi_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As String,
                                        stock_koleksi As String,
                                        bahasa_koleksi As String,
                                        kategori_koleksi As String)
        koleksiDataTable.Add({dir_gambar,
                             nama_koleksi,
                             jenis_koleksi,
                             penerbit_koleksi,
                             deskripsi_koleksi,
                             tahun_terbit,
                             lokasi_rak,
                             tanggal_masuk,
                             stock_koleksi,
                             bahasa_koleksi,
                             kategori_koleksi})
    End Function

    Public Function RemoveKoleksiDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        'Convert to string
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        'Convert to List
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function
End Class
