<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmuser
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Informations = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtpassworduser = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtloginuser = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtnomuser = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnnewuser = New DevComponents.DotNetBar.ButtonX()
        Me.btndeleteuser = New DevComponents.DotNetBar.ButtonX()
        Me.btnannuler = New DevComponents.DotNetBar.ButtonX()
        Me.btnenregistrer = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dguser = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomuser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Login = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdsearchuser = New System.Windows.Forms.ComboBox()
        Me.btnsearchuser = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dgsearchu = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Informations.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.dguser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dgsearchu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Informations
        '
        Me.Informations.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Informations.CanvasColor = System.Drawing.SystemColors.Control
        Me.Informations.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Informations.Controls.Add(Me.LabelX4)
        Me.Informations.Controls.Add(Me.LabelX3)
        Me.Informations.Controls.Add(Me.TextBoxX4)
        Me.Informations.Controls.Add(Me.txtpassworduser)
        Me.Informations.Controls.Add(Me.txtloginuser)
        Me.Informations.Controls.Add(Me.txtnomuser)
        Me.Informations.Controls.Add(Me.LabelX2)
        Me.Informations.Controls.Add(Me.LabelX1)
        Me.Informations.DisabledBackColor = System.Drawing.Color.Empty
        Me.Informations.Location = New System.Drawing.Point(12, 12)
        Me.Informations.Name = "Informations"
        Me.Informations.Size = New System.Drawing.Size(467, 192)
        '
        '
        '
        Me.Informations.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Informations.Style.BackColorGradientAngle = 90
        Me.Informations.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Informations.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Informations.Style.BorderBottomWidth = 1
        Me.Informations.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Informations.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Informations.Style.BorderLeftWidth = 1
        Me.Informations.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Informations.Style.BorderRightWidth = 1
        Me.Informations.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Informations.Style.BorderTopWidth = 1
        Me.Informations.Style.CornerDiameter = 4
        Me.Informations.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Informations.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Informations.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Informations.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Informations.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Informations.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Informations.TabIndex = 0
        Me.Informations.Text = "Informations de connexion"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(12, 125)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(212, 31)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "Retapez le mot de passe"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(101, 88)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(123, 31)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Mot de passe"
        '
        'TextBoxX4
        '
        '
        '
        '
        Me.TextBoxX4.Border.Class = "TextBoxBorder"
        Me.TextBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX4.Location = New System.Drawing.Point(251, 125)
        Me.TextBoxX4.Name = "TextBoxX4"
        Me.TextBoxX4.PreventEnterBeep = True
        Me.TextBoxX4.Size = New System.Drawing.Size(207, 31)
        Me.TextBoxX4.TabIndex = 5
        Me.TextBoxX4.UseSystemPasswordChar = True
        '
        'txtpassworduser
        '
        '
        '
        '
        Me.txtpassworduser.Border.Class = "TextBoxBorder"
        Me.txtpassworduser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtpassworduser.Location = New System.Drawing.Point(251, 88)
        Me.txtpassworduser.Name = "txtpassworduser"
        Me.txtpassworduser.PreventEnterBeep = True
        Me.txtpassworduser.Size = New System.Drawing.Size(207, 31)
        Me.txtpassworduser.TabIndex = 4
        Me.txtpassworduser.UseSystemPasswordChar = True
        '
        'txtloginuser
        '
        '
        '
        '
        Me.txtloginuser.Border.Class = "TextBoxBorder"
        Me.txtloginuser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtloginuser.Location = New System.Drawing.Point(251, 51)
        Me.txtloginuser.Name = "txtloginuser"
        Me.txtloginuser.PreventEnterBeep = True
        Me.txtloginuser.Size = New System.Drawing.Size(207, 31)
        Me.txtloginuser.TabIndex = 3
        '
        'txtnomuser
        '
        '
        '
        '
        Me.txtnomuser.Border.Class = "TextBoxBorder"
        Me.txtnomuser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnomuser.Location = New System.Drawing.Point(251, 14)
        Me.txtnomuser.Name = "txtnomuser"
        Me.txtnomuser.PreventEnterBeep = True
        Me.txtnomuser.Size = New System.Drawing.Size(207, 31)
        Me.txtnomuser.TabIndex = 2
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(178, 51)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(46, 31)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Login"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(178, 14)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(46, 31)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Nom"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.btnnewuser)
        Me.GroupPanel2.Controls.Add(Me.btndeleteuser)
        Me.GroupPanel2.Controls.Add(Me.btnannuler)
        Me.GroupPanel2.Controls.Add(Me.btnenregistrer)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 210)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(467, 142)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 1
        Me.GroupPanel2.Text = "Actions"
        '
        'btnnewuser
        '
        Me.btnnewuser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnnewuser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnnewuser.Location = New System.Drawing.Point(281, 4)
        Me.btnnewuser.Name = "btnnewuser"
        Me.btnnewuser.Size = New System.Drawing.Size(145, 40)
        Me.btnnewuser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnnewuser.Symbol = ""
        Me.btnnewuser.SymbolColor = System.Drawing.Color.Black
        Me.btnnewuser.TabIndex = 3
        Me.btnnewuser.Text = "Nouveau"
        '
        'btndeleteuser
        '
        Me.btndeleteuser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btndeleteuser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btndeleteuser.Location = New System.Drawing.Point(49, 67)
        Me.btndeleteuser.Name = "btndeleteuser"
        Me.btndeleteuser.Size = New System.Drawing.Size(130, 40)
        Me.btndeleteuser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btndeleteuser.Symbol = ""
        Me.btndeleteuser.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndeleteuser.TabIndex = 2
        Me.btndeleteuser.Text = "Supprimer"
        '
        'btnannuler
        '
        Me.btnannuler.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnannuler.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnannuler.Location = New System.Drawing.Point(281, 69)
        Me.btnannuler.Name = "btnannuler"
        Me.btnannuler.Size = New System.Drawing.Size(145, 40)
        Me.btnannuler.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnannuler.Symbol = ""
        Me.btnannuler.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnannuler.TabIndex = 1
        Me.btnannuler.Text = "Annuler"
        '
        'btnenregistrer
        '
        Me.btnenregistrer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnenregistrer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnenregistrer.Location = New System.Drawing.Point(49, 4)
        Me.btnenregistrer.Name = "btnenregistrer"
        Me.btnenregistrer.Size = New System.Drawing.Size(130, 40)
        Me.btnenregistrer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnenregistrer.Symbol = ""
        Me.btnenregistrer.SymbolColor = System.Drawing.Color.Green
        Me.btnenregistrer.TabIndex = 0
        Me.btnenregistrer.Text = "Enregistrer"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.dguser)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(485, 12)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(358, 192)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 2
        Me.GroupPanel3.Text = "Utilisateurs inscrits"
        '
        'dguser
        '
        Me.dguser.AllowUserToAddRows = False
        Me.dguser.AllowUserToDeleteRows = False
        Me.dguser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dguser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nomuser, Me.Login, Me.mot})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dguser.DefaultCellStyle = DataGridViewCellStyle1
        Me.dguser.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dguser.Location = New System.Drawing.Point(3, 3)
        Me.dguser.Name = "dguser"
        Me.dguser.ReadOnly = True
        Me.dguser.RowTemplate.Height = 24
        Me.dguser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dguser.Size = New System.Drawing.Size(344, 153)
        Me.dguser.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "Identifiant"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'nomuser
        '
        Me.nomuser.HeaderText = "Nom "
        Me.nomuser.Name = "nomuser"
        Me.nomuser.ReadOnly = True
        '
        'Login
        '
        Me.Login.HeaderText = "Login"
        Me.Login.Name = "Login"
        Me.Login.ReadOnly = True
        '
        'mot
        '
        Me.mot.HeaderText = "Mot de passe"
        Me.mot.Name = "mot"
        Me.mot.ReadOnly = True
        '
        'cmdsearchuser
        '
        Me.cmdsearchuser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmdsearchuser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmdsearchuser.FormattingEnabled = True
        Me.cmdsearchuser.Location = New System.Drawing.Point(491, 210)
        Me.cmdsearchuser.Name = "cmdsearchuser"
        Me.cmdsearchuser.Size = New System.Drawing.Size(155, 33)
        Me.cmdsearchuser.TabIndex = 3
        '
        'btnsearchuser
        '
        Me.btnsearchuser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnsearchuser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsearchuser.Location = New System.Drawing.Point(683, 210)
        Me.btnsearchuser.Name = "btnsearchuser"
        Me.btnsearchuser.Size = New System.Drawing.Size(152, 33)
        Me.btnsearchuser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnsearchuser.Symbol = ""
        Me.btnsearchuser.SymbolColor = System.Drawing.Color.Gray
        Me.btnsearchuser.TabIndex = 4
        Me.btnsearchuser.Text = "Rechercher"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.dgsearchu)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(485, 252)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(358, 100)
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
        Me.GroupPanel1.TabIndex = 5
        Me.GroupPanel1.Text = "Resultat de la recherche"
        '
        'dgsearchu
        '
        Me.dgsearchu.AllowUserToAddRows = False
        Me.dgsearchu.AllowUserToDeleteRows = False
        Me.dgsearchu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgsearchu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgsearchu.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgsearchu.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgsearchu.Location = New System.Drawing.Point(3, 12)
        Me.dgsearchu.Name = "dgsearchu"
        Me.dgsearchu.ReadOnly = True
        Me.dgsearchu.RowTemplate.Height = 24
        Me.dgsearchu.Size = New System.Drawing.Size(344, 55)
        Me.dgsearchu.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nom"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Login"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Password"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Frmuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(852, 360)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.btnsearchuser)
        Me.Controls.Add(Me.cmdsearchuser)
        Me.Controls.Add(Me.GroupPanel3)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.Informations)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "Frmuser"
        Me.Text = "Frmuser"
        Me.Informations.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        CType(Me.dguser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.dgsearchu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Informations As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtpassworduser As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtloginuser As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtnomuser As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnannuler As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnenregistrer As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dguser As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomuser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Login As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnnewuser As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btndeleteuser As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdsearchuser As System.Windows.Forms.ComboBox
    Friend WithEvents btnsearchuser As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dgsearchu As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
