<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConnexion
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
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.btnconnecter = New DevComponents.DotNetBar.ButtonX()
        Me.lbconnexion = New System.Windows.Forms.LinkLabel()
        Me.Login = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtpassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtlogin = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(185, 115)
        Me.ButtonX1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(154, 38)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolColor = System.Drawing.Color.Red
        Me.ButtonX1.TabIndex = 6
        Me.ButtonX1.Text = "Annuler"
        '
        'btnconnecter
        '
        Me.btnconnecter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnconnecter.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnconnecter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnconnecter.Location = New System.Drawing.Point(13, 115)
        Me.btnconnecter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnconnecter.Name = "btnconnecter"
        Me.btnconnecter.Size = New System.Drawing.Size(152, 38)
        Me.btnconnecter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnconnecter.Symbol = ""
        Me.btnconnecter.SymbolColor = System.Drawing.Color.DarkGreen
        Me.btnconnecter.TabIndex = 5
        Me.btnconnecter.Text = "Connexion"
        '
        'lbconnexion
        '
        Me.lbconnexion.AutoSize = True
        Me.lbconnexion.Location = New System.Drawing.Point(78, 225)
        Me.lbconnexion.Name = "lbconnexion"
        Me.lbconnexion.Size = New System.Drawing.Size(206, 19)
        Me.lbconnexion.TabIndex = 5
        Me.lbconnexion.TabStop = True
        Me.lbconnexion.Text = "Creer un compte utilisateur !"
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        '
        '
        Me.Login.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Login.Location = New System.Drawing.Point(80, 26)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(48, 23)
        Me.Login.TabIndex = 6
        Me.Login.Text = "Login"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(13, 67)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(115, 23)
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "Mot de passe"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.ButtonX1)
        Me.GroupPanel1.Controls.Add(Me.txtpassword)
        Me.GroupPanel1.Controls.Add(Me.btnconnecter)
        Me.GroupPanel1.Controls.Add(Me.Login)
        Me.GroupPanel1.Controls.Add(Me.txtlogin)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(351, 198)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 8
        Me.GroupPanel1.Text = "Interface de connexion"
        '
        'txtpassword
        '
        '
        '
        '
        Me.txtpassword.Border.Class = "TextBoxBorder"
        Me.txtpassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtpassword.Location = New System.Drawing.Point(134, 59)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PreventEnterBeep = True
        Me.txtpassword.Size = New System.Drawing.Size(179, 26)
        Me.txtpassword.TabIndex = 10
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtlogin
        '
        '
        '
        '
        Me.txtlogin.Border.Class = "TextBoxBorder"
        Me.txtlogin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtlogin.Location = New System.Drawing.Point(134, 22)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.PreventEnterBeep = True
        Me.txtlogin.Size = New System.Drawing.Size(179, 26)
        Me.txtlogin.TabIndex = 9
        '
        'FrmConnexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 264)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.lbconnexion)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FrmConnexion"
        Me.Text = "FrmConnexion"
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnconnecter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbconnexion As System.Windows.Forms.LinkLabel
    Friend WithEvents Login As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtpassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtlogin As DevComponents.DotNetBar.Controls.TextBoxX
End Class
