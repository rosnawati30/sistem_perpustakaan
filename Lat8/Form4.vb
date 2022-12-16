Public Class Form4
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelKoleksi.Text = Form1.ListBoxKoleksi.SelectedItem
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Form1.ListBoxKoleksi.Items.RemoveAt(Form1.ListBoxKoleksi.SelectedIndex)
        Me.Close()
    End Sub
End Class