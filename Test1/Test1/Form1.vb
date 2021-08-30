Public Class Form1

    Private Access As New DBControl

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        'Öppna en befintlig form

        Form2.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Fylla datagrid med databas information 
        Access.ExecQuery("SELECT * FROM TEST1")

        ' Ange namn på datagrid för att fylla med data
        dgvTable.DataSource = Access.DBDT

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown



    End Sub
End Class
