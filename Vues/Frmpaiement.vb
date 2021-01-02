Public Class Frmpaiement
    Dim payement As New paiement
    Private Sub formtobd()
        payement.type_paiement = txtpaiement.Text
        payement.date_paiement = txtdate.Text
        payement.montant = txtmontant.Text

        payement.personnel = PersonnelControllers.find(cmbpersonnel.Text)
    End Sub

    Private Sub vider()
        txtpaiement.Text = ""

        dgpaiement.Text = ""
        txtdate.Text = ""

        txtmontant.Text = ""

        cmbpersonnel.Text = ""


        payement = New paiement()
        txtpaiement.Focus()
    End Sub
    Private Sub chargeListpersonnel()
        Dim listpaiement As List(Of paiement) = paiementControllers.findall()
        dgpaiement.Rows.Clear()
        Dim ps As List(Of Personnel) = PersonnelControllers.findAll() '
        cmbpersonnel.Items.Clear() '

        For Each p As Personnel In ps '
            cmbpersonnel.Items.Add(p.nom) '
        Next '
        For Each p As paiement In listpaiement
            dgpaiement.Rows.Add(New String() {p.id.ToString(), p.type_paiement, p.date_paiement, p.montant, p.personnel.nom})
        Next

    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnsavep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub FrmPersonnel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chargeListpersonnel()
    End Sub

    Private Sub dgpaiement_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgpaiement.CellClick, dgpaiement.CellContentClick
        payement.id = Integer.Parse(dgpaiement.CurrentRow.Cells(0).Value.ToString())
        txtpaiement.Text = dgpaiement.CurrentRow.Cells(1).Value.ToString()
        txtdate.Text = dgpaiement.CurrentRow.Cells(2).Value.ToString()
        txtmontant.Text = dgpaiement.CurrentRow.Cells(3).Value.ToString()
        cmbpersonnel.Text = dgpaiement.CurrentRow.Cells(4).Value.ToString()
        dgpaiement.Text = dgpaiement.CurrentRow.Cells(4).Value.ToString()


    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            payement.id = Integer.Parse(dgpaiement.CurrentRow.Cells(0).Value.ToString())
            paiementControllers.delete(payement.id)
            chargeListpersonnel()
            vider()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click

    End Sub



    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            formtobd()
            paiementControllers.save(payement)
            vider()
            chargeListpersonnel()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtpaiement_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles label1.TextChanged

    End Sub
End Class

