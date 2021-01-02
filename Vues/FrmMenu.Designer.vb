<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonnelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FonctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaiementToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraitementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaiementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EtatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AidesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilisateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.TraitementsToolStripMenuItem, Me.AidesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(948, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(65, 23)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonnelToolStripMenuItem, Me.FonctionToolStripMenuItem, Me.PaiementToolStripMenuItem1})
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(136, 24)
        Me.NouveauToolStripMenuItem.Text = "Nouveau"
        '
        'PersonnelToolStripMenuItem
        '
        Me.PersonnelToolStripMenuItem.Name = "PersonnelToolStripMenuItem"
        Me.PersonnelToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.PersonnelToolStripMenuItem.Text = "Personnel"
        '
        'FonctionToolStripMenuItem
        '
        Me.FonctionToolStripMenuItem.Name = "FonctionToolStripMenuItem"
        Me.FonctionToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.FonctionToolStripMenuItem.Text = "Fonction"
        '
        'PaiementToolStripMenuItem1
        '
        Me.PaiementToolStripMenuItem1.Name = "PaiementToolStripMenuItem1"
        Me.PaiementToolStripMenuItem1.Size = New System.Drawing.Size(141, 24)
        Me.PaiementToolStripMenuItem1.Text = "paiement"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(136, 24)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'TraitementsToolStripMenuItem
        '
        Me.TraitementsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaiementToolStripMenuItem, Me.EtatsToolStripMenuItem, Me.UtilisateurToolStripMenuItem})
        Me.TraitementsToolStripMenuItem.Name = "TraitementsToolStripMenuItem"
        Me.TraitementsToolStripMenuItem.Size = New System.Drawing.Size(96, 23)
        Me.TraitementsToolStripMenuItem.Text = "Traitements"
        '
        'PaiementToolStripMenuItem
        '
        Me.PaiementToolStripMenuItem.Name = "PaiementToolStripMenuItem"
        Me.PaiementToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.PaiementToolStripMenuItem.Text = "Paiement"
        '
        'EtatsToolStripMenuItem
        '
        Me.EtatsToolStripMenuItem.Name = "EtatsToolStripMenuItem"
        Me.EtatsToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.EtatsToolStripMenuItem.Text = "Etats"
        '
        'AidesToolStripMenuItem
        '
        Me.AidesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.AidesToolStripMenuItem.Name = "AidesToolStripMenuItem"
        Me.AidesToolStripMenuItem.Size = New System.Drawing.Size(56, 23)
        Me.AidesToolStripMenuItem.Text = "Aides"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(85, 24)
        Me.ToolStripMenuItem2.Text = "?"
        '
        'UtilisateurToolStripMenuItem
        '
        Me.UtilisateurToolStripMenuItem.Name = "UtilisateurToolStripMenuItem"
        Me.UtilisateurToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.UtilisateurToolStripMenuItem.Text = "utilisateur"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplicationGespaie.My.Resources.Resources.gerer_la_paie
        Me.ClientSize = New System.Drawing.Size(948, 289)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMenu"
        Me.Text = "FrmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonnelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FonctionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TraitementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaiementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EtatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AidesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaiementToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilisateurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
