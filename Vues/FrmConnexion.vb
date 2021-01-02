Public Class FrmConnexion

    Private Sub btnconnecter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconnecter.Click
        Dim result As Boolean = UtilisateurControllers.controle(txtlogin.Text, txtpassword.Text)
        If result = True Then
            FrmDemarrage.Show()
        End If
        If result = False Then
            MessageBox.Show("Mot de passe ou Login erone")
        End If
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Application.Exit()
    End Sub

    Private Sub FrmConnexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtlogin.Focus()
    End Sub

    Private Sub lbconnexion_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbconnexion.LinkClicked
        Frmuser.Show()
    End Sub

    Private Sub GroupPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupPanel1.Click

    End Sub
End Class