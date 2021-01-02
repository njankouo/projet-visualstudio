<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmconexion1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmconexion1))
        Me.btnannuler = New System.Windows.Forms.Button()
        Me.btnconexion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtlogin = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnannuler
        '
        Me.btnannuler.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnannuler.Location = New System.Drawing.Point(48, 283)
        Me.btnannuler.Name = "btnannuler"
        Me.btnannuler.Size = New System.Drawing.Size(105, 39)
        Me.btnannuler.TabIndex = 0
        Me.btnannuler.Text = "annuler"
        Me.btnannuler.UseVisualStyleBackColor = False
        '
        'btnconexion
        '
        Me.btnconexion.BackColor = System.Drawing.Color.DarkCyan
        Me.btnconexion.Location = New System.Drawing.Point(238, 283)
        Me.btnconexion.Name = "btnconexion"
        Me.btnconexion.Size = New System.Drawing.Size(122, 39)
        Me.btnconexion.TabIndex = 1
        Me.btnconexion.Text = "conexion"
        Me.btnconexion.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "password"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.txtlogin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnannuler)
        Me.GroupBox1.Controls.Add(Me.btnconexion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(255, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 510)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "conexion"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(66, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(310, 43)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "creer un utilisateur"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(129, 161)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(64)
        Me.txtpassword.Size = New System.Drawing.Size(191, 20)
        Me.txtpassword.TabIndex = 5
        Me.txtpassword.UseSystemPasswordChar = True
        Me.txtpassword.UseWaitCursor = True
        '
        'txtlogin
        '
        Me.txtlogin.Location = New System.Drawing.Point(129, 46)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(191, 20)
        Me.txtlogin.TabIndex = 4
        '
        'Frmconexion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1113, 557)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frmconexion1"
        Me.Text = "Frmconexion1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnannuler As System.Windows.Forms.Button
    Friend WithEvents btnconexion As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtlogin As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
