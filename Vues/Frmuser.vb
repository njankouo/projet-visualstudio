Public Class Frmuser
    Dim f As Utilisateur = New Utilisateur()
    Private Sub formtobd()
        f.Nom = txtnomuser.Text
        f.Login = txtloginuser.Text
        f.Password = txtpassworduser.Text
    End Sub
    'Private Sub bdtoform()
    '    txtlibelle.Text = f.Libelle
    '    txtsalairebase.Text = f.SalaireBase.ToString()
    'End Sub
    Private Sub chargelistuser()
        Dim fs As List(Of Utilisateur) = UtilisateurControllers.findAll()
        dguser.Rows.Clear()
        For Each f As Utilisateur In fs
            dguser.Rows.Add(New String() {f.Id.ToString(), f.Nom, f.Login, f.Password})
        Next
    End Sub

    Private Sub vider()
        txtnomuser.Text = ""
        txtloginuser.Text = ""
        txtpassworduser.Text = ""
        TextBoxX4.Text = ""
        f = New Utilisateur()
        txtnomuser.Focus()
    End Sub

    Private Sub viderpassword()
        TextBoxX4.Text = ""
        f = New Utilisateur()
        TextBoxX4.Focus()
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LabelX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelX2.Click

    End Sub

    Private Sub LabelX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelX1.Click

    End Sub

    Private Sub btnenregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnenregistrer.Click
        If txtnomuser.Text = "" Then
            MessageBox.Show("entrer le nom")
            Exit Sub
        End If
        If txtloginuser.Text = "" Then
            MessageBox.Show("entrer le login")
            Exit Sub
        End If
        If txtpassworduser.Text = "" Then
            MessageBox.Show("entrer le mot de passe")
            Exit Sub
        End If
        If txtpassworduser.Text <> TextBoxX4.Text Then
            MessageBox.Show("retapez le mot de passe")
            viderpassword()
            Exit Sub
        End If
        Try
            formtobd() 'ajoute une fonction 
            UtilisateurControllers.save(f) 'ajoute dans la base de données
            chargelistuser() 'actualise le datagridview
            vider() 'vide les champs
            FrmConnexion.Show()
            chargeserachuser()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub chargeserachuser()
        Dim user As List(Of Utilisateur) = UtilisateurControllers.findAll()
        cmdsearchuser.Items.Clear()
        For Each u As Utilisateur In user
            cmdsearchuser.Items.Add(u.Nom)
        Next
    End Sub

    Private Sub Frmuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            chargeserachuser()
            chargelistuser()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dguser_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dguser.CellClick
        f.Id = Integer.Parse(dguser.CurrentRow.Cells(0).Value.ToString())
        txtnomuser.Text = dguser.CurrentRow.Cells(1).Value.ToString()
        txtloginuser.Text = dguser.CurrentRow.Cells(2).Value.ToString()
        txtpassworduser.Text = dguser.CurrentRow.Cells(3).Value.ToString()
    End Sub

    Private Sub btnannuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnannuler.Click
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeleteuser.Click
        Try
            f.Id = Integer.Parse(dguser.CurrentRow.Cells(0).Value.ToString())
            UtilisateurControllers.delete(f.Id)
            chargelistuser()
            vider()
            chargeserachuser()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewuser.Click
        vider()
    End Sub

    Private Sub btnsearchuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchuser.Click
        Try
            dgsearchu.Rows.Clear()
            Dim u = UtilisateurControllers.findsearch(cmdsearchuser.Text)
            dgsearchu.Rows.Add(New String() {u.Id.ToString(), u.Nom, u.Login, u.Password})
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class