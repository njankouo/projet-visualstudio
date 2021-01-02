Public Class FrmMenu

    Private Sub FonctionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FonctionToolStripMenuItem.Click
        FrmFonction.Show()


    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub FrmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PersonnelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonnelToolStripMenuItem.Click
        FrmPersonnel.Show()

    End Sub

    Private Sub FichierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FichierToolStripMenuItem.Click

    End Sub

    Private Sub TraitementsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TraitementsToolStripMenuItem.Click

    End Sub

    Private Sub PaiementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaiementToolStripMenuItem.Click
        Frmpaiement.Show()
    End Sub

    Private Sub UtilisateurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UtilisateurToolStripMenuItem.Click
        Frmutilisateur.Show()








    End Sub
End Class