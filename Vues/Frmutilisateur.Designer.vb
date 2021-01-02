<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmutilisateur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmutilisateur))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnannuler = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtlogin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnvalider = New System.Windows.Forms.Button()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.dgutilisateur = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomuser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.login = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgutilisateur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Teal
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnannuler)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtlogin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.btnvalider)
        Me.GroupBox1.Controls.Add(Me.txtnom)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 598)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "utilisateur"
        '
        'btnannuler
        '
        Me.btnannuler.Location = New System.Drawing.Point(87, 410)
        Me.btnannuler.Name = "btnannuler"
        Me.btnannuler.Size = New System.Drawing.Size(97, 36)
        Me.btnannuler.TabIndex = 7
        Me.btnannuler.Text = "annuler"
        Me.btnannuler.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "login"
        '
        'txtlogin
        '
        Me.txtlogin.Location = New System.Drawing.Point(99, 195)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(262, 33)
        Me.txtlogin.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "nom de l'utilisateur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "password"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(99, 298)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(262, 33)
        Me.txtpassword.TabIndex = 2
        '
        'btnvalider
        '
        Me.btnvalider.Location = New System.Drawing.Point(285, 410)
        Me.btnvalider.Name = "btnvalider"
        Me.btnvalider.Size = New System.Drawing.Size(97, 36)
        Me.btnvalider.TabIndex = 1
        Me.btnvalider.Text = "valider"
        Me.btnvalider.UseVisualStyleBackColor = True
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(99, 83)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(262, 33)
        Me.txtnom.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(536, 29)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(388, 429)
        Me.ListBox1.TabIndex = 1
        '
        'dgutilisateur
        '
        Me.dgutilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgutilisateur.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nomuser, Me.login, Me.password})
        Me.dgutilisateur.Location = New System.Drawing.Point(536, 29)
        Me.dgutilisateur.Name = "dgutilisateur"
        Me.dgutilisateur.Size = New System.Drawing.Size(792, 598)
        Me.dgutilisateur.TabIndex = 8
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        '
        'nomuser
        '
        Me.nomuser.HeaderText = "nomuser"
        Me.nomuser.Name = "nomuser"
        '
        'login
        '
        Me.login.HeaderText = "login"
        Me.login.Name = "login"
        '
        'password
        '
        Me.password.HeaderText = "password"
        Me.password.Name = "password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(172, 513)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 43)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "RETOUR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frmutilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1362, 736)
        Me.Controls.Add(Me.dgutilisateur)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Matura MT Script Capitals", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.Name = "Frmutilisateur"
        Me.Text = "utlisateur"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgutilisateur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnannuler As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtlogin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnvalider As System.Windows.Forms.Button
    Friend WithEvents txtnom As System.Windows.Forms.TextBox
    Friend WithEvents dgutilisateur As System.Windows.Forms.DataGridView
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomuser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents login As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
