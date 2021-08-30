Public Class Form2

    ' Nyttja DBControl.vb funktion
    Private Access As New DBControl


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub cmdCanc_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        ' Avsluta
        Me.Close()

    End Sub

    Private Sub TextBox1_validate(sender As Object, e As EventArgs) Handles txtUser.TextChanged, txtPass.TextChanged

        If Not String.IsNullOrWhiteSpace(txtUser.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPass.Text) Then cmdSave.Enabled = True

    End Sub


    Private Sub Adduser()

        'Lägga till i databasen

        Access.AddParam("@User", txtUser.Text)

        ' Insert command
        Access.ExecQuery("INSERT INTO Test1 (Namn ) " &
                        "VALUES (@User ); ")

        Form1.Refresh()

        Me.Close()



    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click


        'Lägga till i databasen

        Access.AddParam("@User", txtUser.Text)

        ' Insert command
        Access.ExecQuery("INSERT INTO Test1 (Namn ) " &
                        "VALUES (@User ); ")

        Form1.Refresh()

        Me.Close()


    End Sub
End Class