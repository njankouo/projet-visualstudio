Public Class FrmPersonnel
    Dim personne As New Personnel
    Private Sub formtobd()
        personne.nom = txtnom.Text
        personne.sexe = cmbsexe.Text
        personne.telephone = txttelephone.Text
        personne.datenaissance = dgDateTimer.Value
        personne.lieunaissance = txtlieunaissance.Text
        personne.salairenegocier = txtsalairenegocier.Text
        personne.fonction = FonctionControllers.find(cmbfonction.Text)
    End Sub
    Private Sub vider()
        txtnom.Text = ""
        cmbsexe.Text = ""
        dgpersonnel.Text = ""
        txtlieunaissance.Text = ""
        txtsalairenegocier.Text = ""
        txttelephone.Text = ""
        cmbfonction.Text = ""
        personne = New Personnel()
        txtnom.Focus()
    End Sub
    Private Sub chargeListfonction()
        Dim listpersonnel As List(Of Personnel) = PersonnelControllers.findAll()
        dgpersonnel.Rows.Clear()
        Dim ps As List(Of Fonction) = FonctionControllers.findAll() '
        cmbfonction.Items.Clear() '
        For Each f As Fonction In ps '
            cmbfonction.Items.Add(f.Libelle) '
        Next '
        For Each p As Personnel In listpersonnel
            dgpersonnel.Rows.Add(New String() {p.id.ToString(), p.nom, p.sexe, p.telephone, p.fonction.Libelle, p.datenaissance, p.lieunaissance, p.salairenegocier})
        Next

    End Sub
   


    Private Sub FrmPersonnel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chargeListfonction()
        chargecombobox()
    End Sub

    Private Sub dgpersonnel_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgpersonnel.CellClick
        personne.id = Integer.Parse(dgpersonnel.CurrentRow.Cells(0).Value.ToString())
        txtnom.Text = dgpersonnel.CurrentRow.Cells(1).Value.ToString()
        cmbsexe.Text = dgpersonnel.CurrentRow.Cells(2).Value.ToString()
        txttelephone.Text = dgpersonnel.CurrentRow.Cells(3).Value.ToString()
        cmbfonction.Text = dgpersonnel.CurrentRow.Cells(4).Value.ToString()
        dgpersonnel.Text = dgpersonnel.CurrentRow.Cells(5).Value.ToString()
        txtlieunaissance.Text = dgpersonnel.CurrentRow.Cells(6).Value.ToString()
        txtsalairenegocier.Text = dgpersonnel.CurrentRow.Cells(7).Value.ToString()
    End Sub
    'recupere tout les personnels
    Private Sub chargecombobox()
        Dim a As List(Of Personnel) = PersonnelControllers.findAll()
        cmbcombo.Items.Clear()
        For Each p As Personnel In a
            cmbcombo.Items.Add(p.nom)
        Next
    End Sub
    Private Sub btndeletep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeletep.Click
        Try
            personne.id = Integer.Parse(dgpersonnel.CurrentRow.Cells(0).Value.ToString())
            PersonnelControllers.delete(personne.id)
            chargeListfonction()
            vider()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub btnsavebon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsavebon.Click
        Try
            formtobd()
            PersonnelControllers.save(personne)
            vider()
            chargeListfonction()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbfonction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfonction.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub cmbsexe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsexe.SelectedIndexChanged
      
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtlieunaissance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlieunaissance.TextChanged

    End Sub

    Private Sub rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rechercher.Click
        Dim p = PersonnelControllers.bosco(cmbcombo.Text)
        dgdata.Rows.Clear()

        dgdata.Rows.Add(New String() {p.id.ToString(), p.nom, p.sexe, p.telephone, p.fonction.Libelle, p.datenaissance, p.lieunaissance, p.salairenegocier})


    End Sub

    Private Sub txttelephone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttelephone.TextChanged

    End Sub
End Class

