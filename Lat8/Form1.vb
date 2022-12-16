Public Class Form1

    Public Shared data_perpustakaan As DataPerpustakaan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        data_perpustakaan = New DataPerpustakaan
        UpdateDataTableArrayList()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Form2.Show()

    End Sub

    Private Sub BtnKurang_Click(sender As Object, e As EventArgs) Handles BtnKurang.Click
        If ListBoxKoleksi.SelectedIndex = -1 Then
            MessageBox.Show("Pilih koleksi yang ingin dihapus.")
        Else
            Dim hapus = New Form4()
            hapus.Show()
        End If
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        ListBoxKoleksi.ClearSelected()
    End Sub

    Public Sub UpdateDataTableArrayList()
        DataGridKoleksi.Rows.Clear()
        For Each rowKoleksi In data_perpustakaan.getKoleksiDataTable()
            Dim dataTable As String() = {rowKoleksi(1),
                                        rowKoleksi(2),
                                        rowKoleksi(3),
                                        rowKoleksi(5)}
            DataGridKoleksi.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateDataTableArrayList()
    End Sub
End Class
