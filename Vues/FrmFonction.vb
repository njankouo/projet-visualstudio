Public Class FrmFonction
    Dim f As Fonction = New Fonction()
    Private Sub formtobd()
        f.Libelle = txtlibelle.Text
        f.SalaireBase = Int32.Parse(txtsalairebase.Text)
    End Sub
    Private Sub chargelist()
        Dim fs As List(Of Fonction) = FonctionControllers.findAll()
        dgfonction.Rows.Clear()
        For Each f As Fonction In fs
            dgfonction.Rows.Add(New String() {f.Id.ToString(), f.Libelle, f.SalaireBase.ToString()})
        Next
    End Sub
    Private Sub FrmFonction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            chargelist()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub vider()
        txtlibelle.Text = ""
        txtsalairebase.Text = ""
        f = New Fonction()
        txtlibelle.Focus()
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtlibelle.Text = "" Then
            MessageBox.Show("entrer la fonction")
            Exit Sub
        End If
        If txtsalairebase.Text = "" Then
            MessageBox.Show("entrer le salaire de base")
            Exit Sub
        End If
        Try
            formtobd() 'ajoute une fonction 
            FonctionControllers.save(f) 'ajoute dans la base de données
            chargelist() 'actualise le datagridview
            vider() 'vide les champs
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgfonction_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgfonction.CellClick
        f.Id = Integer.Parse(dgfonction.CurrentRow.Cells(0).Value.ToString())
        txtlibelle.Text = dgfonction.CurrentRow.Cells(1).Value.ToString()
        txtsalairebase.Text = dgfonction.CurrentRow.Cells(2).Value.ToString()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If txtlibelle.Text = "" Then
            MessageBox.Show("entrer la fonction")
            Exit Sub
        End If
        If txtsalairebase.Text = "" Then
            MessageBox.Show("entrer le salaire de base")
            Exit Sub
        End If
        Try
            f.Id = Integer.Parse(dgfonction.CurrentRow.Cells(0).Value.ToString())
            FonctionControllers.delete(f.Id)
            chargelist()
            vider()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        vider()
    End Sub

    Private Sub txtsalairebase_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsalairebase.KeyPress
        'Dim ch As Char = e.KeyChar
        '    if !Char.IsDigit(ch) and ch != 8 && ch != 46 then
        '    e.Handled = True
        'End If




    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Try
            Dim fretatlist As New FrmEtat()
            fretatlist.printListFonction()
            fretatlist.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub dgfonction_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgfonction.CellContentClick

    End Sub
End Class