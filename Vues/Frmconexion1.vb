Public Class Frmconexion1

    Private Sub btnconexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim result As Boolean = utilisateurcontrollers.contrôle(txtlogin.Text, txtpassword.Text)
        If result = True Then
            FrmMenu.Show()
        End If
        If result = False Then
            MessageBox.Show("Mot de passe ou Login erone")
        End If
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnanuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Application.Exit()
    End Sub

    Private Sub FrmConnexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtlogin.Focus()
    End Sub

   

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnannuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnannuler.Click
        Me.Close()
    End Sub

    Private Sub btnconexion_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconexion.Click
        Dim result As Boolean = utilisateurcontrollers.contrôle(txtlogin.Text, txtpassword.Text)
        If result = True Then
            FrmMenu.Show()
        End If
        If result = False Then
            MessageBox.Show("Mot de passe ou Login erone")
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Frmutilisateur.Show()
    End Sub

    Private Sub Frmconexion1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class