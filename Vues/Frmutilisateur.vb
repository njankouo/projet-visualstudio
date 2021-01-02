Public Class Frmutilisateur
    Dim u As utilisateurvb = New utilisateurvb()
    Private Sub formtobd()
        u.nomuser = txtnom.Text
        u.login = Int32.Parse(txtlogin.Text)

        u.password = txtpassword.Text

    End Sub
    'Private Sub bdtoform()
    '    txtnom.Text = u.nomuser
    '    txtlogin.Text = u.login.ToString()
    '    txtpassword.Text = u.password

    'End Sub
    Private Sub chargelist()
        Dim fs As List(Of utilisateurvb) = utilisateurcontrollers.findAll()
        dgutilisateur.Rows.Clear()
        For Each u As utilisateurvb In fs
            dgutilisateur.Rows.Add(New String() {u.Id.ToString(), u.nomuser, u.login.ToString(), u.password.ToString})
        Next
    End Sub

    Private Sub Frmutilisateur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            chargelist()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub vider()
        txtnom.Text = ""
        txtlogin.Text = ""
        txtpassword.Text = ""

        u = New utilisateurvb()
        txtnom.Focus()
    End Sub
    Private Sub btnvalider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvalider.Click
        If txtnom.Text = "" Then
            MessageBox.Show("entrer le nom")
            Exit Sub
        End If
        If txtlogin.Text = "" Then
            MessageBox.Show("entrer le login")
            Exit Sub
        End If
        If txtpassword.Text = "" Then
            MessageBox.Show("entrer le password")
            Exit Sub
        End If
        Try
            formtobd() 'ajoute une fonction 
            utilisateurcontrollers.save(u) 'ajoute dans la base de données
            chargelist() 'actualise le datagridview
            vider() 'vide les champs
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgutilisateur_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgutilisateur.CellClick
        u.Id = Integer.Parse(dgutilisateur.CurrentRow.Cells(0).Value.ToString())
        txtnom.Text = dgutilisateur.CurrentRow.Cells(1).Value.ToString()
        txtlogin.Text = dgutilisateur.CurrentRow.Cells(2).Value.ToString()
        txtpassword.Text = dgutilisateur.CurrentRow.Cells(3).Value.ToString()
    End Sub

    Private Sub btnannuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnannuler.Click
        If txtnom.Text = "" Then
            MessageBox.Show("entrer le nom")
            Exit Sub
        End If
        If txtlogin.Text = "" Then
            MessageBox.Show("entrer le login")
            Exit Sub
        End If

        If txtpassword.Text = "" Then
            MessageBox.Show("entrer le password")
            Exit Sub
        End If
        Try
            u.Id = Integer.Parse(dgutilisateur.CurrentRow.Cells(0).Value.ToString())
            utilisateurcontrollers.delete(u.Id)
            chargelist()
            vider()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
    ' vider()
    'End Sub

    Private Sub txtlogin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlogin.KeyPress
        'Dim ch As Char = e.KeyChar
        '    if !Char.IsDigit(ch) and ch != 8 && ch != 46 then
        '    e.Handled = True
        'End If

    End Sub
    Private Sub dgutilisateur_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgutilisateur.CellContentClick

    End Sub



    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
