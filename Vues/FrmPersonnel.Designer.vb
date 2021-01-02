<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPersonnel
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbfonction = New System.Windows.Forms.ComboBox()
        Me.dgDateTimer = New System.Windows.Forms.DateTimePicker()
        Me.txtsalairenegocier = New System.Windows.Forms.TextBox()
        Me.txtlieunaissance = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbsexe = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txttelephone = New System.Windows.Forms.TextBox()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.btnprintp = New DevComponents.DotNetBar.ButtonX()
        Me.btnsavebon = New DevComponents.DotNetBar.ButtonX()
        Me.btndeletep = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rechercher = New DevComponents.DotNetBar.ButtonX()
        Me.cmbcombo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.dgdata = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgpersonnel = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fonction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datenaissance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lieunaissance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salairenegocier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpersonnel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbfonction)
        Me.GroupBox1.Controls.Add(Me.dgDateTimer)
        Me.GroupBox1.Controls.Add(Me.txtsalairenegocier)
        Me.GroupBox1.Controls.Add(Me.txtlieunaissance)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbsexe)
        Me.GroupBox1.Controls.Add(Me.txttelephone)
        Me.GroupBox1.Controls.Add(Me.txtnom)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(332, 275)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations"
        '
        'cmbfonction
        '
        Me.cmbfonction.FormattingEnabled = True
        Me.cmbfonction.Location = New System.Drawing.Point(140, 133)
        Me.cmbfonction.Name = "cmbfonction"
        Me.cmbfonction.Size = New System.Drawing.Size(186, 21)
        Me.cmbfonction.TabIndex = 16
        '
        'dgDateTimer
        '
        Me.dgDateTimer.Location = New System.Drawing.Point(140, 169)
        Me.dgDateTimer.Name = "dgDateTimer"
        Me.dgDateTimer.Size = New System.Drawing.Size(188, 20)
        Me.dgDateTimer.TabIndex = 15
        '
        'txtsalairenegocier
        '
        Me.txtsalairenegocier.Location = New System.Drawing.Point(140, 246)
        Me.txtsalairenegocier.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsalairenegocier.Name = "txtsalairenegocier"
        Me.txtsalairenegocier.Size = New System.Drawing.Size(188, 20)
        Me.txtsalairenegocier.TabIndex = 14
        '
        'txtlieunaissance
        '
        Me.txtlieunaissance.Location = New System.Drawing.Point(140, 206)
        Me.txtlieunaissance.Margin = New System.Windows.Forms.Padding(2)
        Me.txtlieunaissance.Name = "txtlieunaissance"
        Me.txtlieunaissance.Size = New System.Drawing.Size(188, 20)
        Me.txtlieunaissance.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 246)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Salaire negocier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 206)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Lieu de naissance"
        '
        'cmbsexe
        '
        Me.cmbsexe.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.cmbsexe.DisplayMember = "Text"
        Me.cmbsexe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbsexe.FormattingEnabled = True
        Me.cmbsexe.ItemHeight = 16
        Me.cmbsexe.Location = New System.Drawing.Point(140, 57)
        Me.cmbsexe.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbsexe.Name = "cmbsexe"
        Me.cmbsexe.Size = New System.Drawing.Size(188, 22)
        Me.cmbsexe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbsexe.TabIndex = 10
        '
        'txttelephone
        '
        Me.txttelephone.Location = New System.Drawing.Point(140, 93)
        Me.txttelephone.Margin = New System.Windows.Forms.Padding(2)
        Me.txttelephone.Name = "txttelephone"
        Me.txttelephone.Size = New System.Drawing.Size(188, 20)
        Me.txttelephone.TabIndex = 7
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(140, 22)
        Me.txtnom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(188, 20)
        Me.txtnom.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 169)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date de naissance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 133)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fonction"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telephone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sexe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonX4)
        Me.GroupBox2.Controls.Add(Me.btnprintp)
        Me.GroupBox2.Controls.Add(Me.btnsavebon)
        Me.GroupBox2.Controls.Add(Me.btndeletep)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 289)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(332, 193)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Location = New System.Drawing.Point(190, 120)
        Me.ButtonX4.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(136, 46)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.TabIndex = 7
        Me.ButtonX4.Text = "NOUVEAU"
        Me.ButtonX4.UseMnemonic = False
        '
        'btnprintp
        '
        Me.btnprintp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnprintp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnprintp.Location = New System.Drawing.Point(7, 120)
        Me.btnprintp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnprintp.Name = "btnprintp"
        Me.btnprintp.Size = New System.Drawing.Size(136, 46)
        Me.btnprintp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnprintp.TabIndex = 6
        Me.btnprintp.Text = "IMPRIMMER"
        '
        'btnsavebon
        '
        Me.btnsavebon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnsavebon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsavebon.Location = New System.Drawing.Point(4, 35)
        Me.btnsavebon.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsavebon.Name = "btnsavebon"
        Me.btnsavebon.Size = New System.Drawing.Size(139, 48)
        Me.btnsavebon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnsavebon.TabIndex = 5
        Me.btnsavebon.Text = "ENREGISTRER"
        '
        'btndeletep
        '
        Me.btndeletep.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btndeletep.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btndeletep.Location = New System.Drawing.Point(190, 35)
        Me.btndeletep.Margin = New System.Windows.Forms.Padding(2)
        Me.btndeletep.Name = "btndeletep"
        Me.btndeletep.Size = New System.Drawing.Size(136, 48)
        Me.btndeletep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btndeletep.TabIndex = 4
        Me.btndeletep.Text = "SUPRIMMER"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rechercher)
        Me.GroupBox3.Controls.Add(Me.cmbcombo)
        Me.GroupBox3.Controls.Add(Me.dgdata)
        Me.GroupBox3.Controls.Add(Me.dgpersonnel)
        Me.GroupBox3.Location = New System.Drawing.Point(345, 10)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(570, 473)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Donnees"
        '
        'rechercher
        '
        Me.rechercher.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.rechercher.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.rechercher.Location = New System.Drawing.Point(162, 279)
        Me.rechercher.Name = "rechercher"
        Me.rechercher.Size = New System.Drawing.Size(86, 23)
        Me.rechercher.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rechercher.TabIndex = 3
        Me.rechercher.Text = "rechercher"
        '
        'cmbcombo
        '
        Me.cmbcombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcombo.DisplayMember = "Text"
        Me.cmbcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcombo.FormattingEnabled = True
        Me.cmbcombo.ItemHeight = 14
        Me.cmbcombo.Location = New System.Drawing.Point(7, 279)
        Me.cmbcombo.Name = "cmbcombo"
        Me.cmbcombo.Size = New System.Drawing.Size(158, 20)
        Me.cmbcombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbcombo.TabIndex = 2
        '
        'dgdata
        '
        Me.dgdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdata.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgdata.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgdata.Location = New System.Drawing.Point(254, 224)
        Me.dgdata.Name = "dgdata"
        Me.dgdata.Size = New System.Drawing.Size(248, 244)
        Me.dgdata.TabIndex = 1
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        '
        'Column2
        '
        Me.Column2.HeaderText = "nom"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "sexe"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "telephone"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "fonction"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "date de naissance"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "lieu de naissance"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "salaire negocier"
        Me.Column8.Name = "Column8"
        '
        'dgpersonnel
        '
        Me.dgpersonnel.AllowUserToAddRows = False
        Me.dgpersonnel.AllowUserToDeleteRows = False
        Me.dgpersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpersonnel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.nom, Me.sexe, Me.telephone, Me.fonction, Me.datenaissance, Me.lieunaissance, Me.salairenegocier})
        Me.dgpersonnel.Location = New System.Drawing.Point(7, 17)
        Me.dgpersonnel.Margin = New System.Windows.Forms.Padding(2)
        Me.dgpersonnel.Name = "dgpersonnel"
        Me.dgpersonnel.ReadOnly = True
        Me.dgpersonnel.RowTemplate.Height = 24
        Me.dgpersonnel.Size = New System.Drawing.Size(559, 202)
        Me.dgpersonnel.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'nom
        '
        Me.nom.HeaderText = "Nom"
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        '
        'sexe
        '
        Me.sexe.HeaderText = "Sexe"
        Me.sexe.Name = "sexe"
        Me.sexe.ReadOnly = True
        '
        'telephone
        '
        Me.telephone.HeaderText = "Telephone"
        Me.telephone.Name = "telephone"
        Me.telephone.ReadOnly = True
        '
        'fonction
        '
        Me.fonction.HeaderText = "Fonction"
        Me.fonction.Name = "fonction"
        Me.fonction.ReadOnly = True
        '
        'datenaissance
        '
        Me.datenaissance.HeaderText = "Date de naissance"
        Me.datenaissance.Name = "datenaissance"
        Me.datenaissance.ReadOnly = True
        '
        'lieunaissance
        '
        Me.lieunaissance.HeaderText = "Lieu de naissance"
        Me.lieunaissance.Name = "lieunaissance"
        Me.lieunaissance.ReadOnly = True
        '
        'salairenegocier
        '
        Me.salairenegocier.HeaderText = "Salaire negocier"
        Me.salairenegocier.Name = "salairenegocier"
        Me.salairenegocier.ReadOnly = True
        '
        'FrmPersonnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 490)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmPersonnel"
        Me.Text = "FrmPersonnel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpersonnel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txttelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtnom As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgpersonnel As System.Windows.Forms.DataGridView
    Friend WithEvents cmbsexe As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtsalairenegocier As System.Windows.Forms.TextBox
    Friend WithEvents txtlieunaissance As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btndeletep As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnprintp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnsavebon As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgDateTimer As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbfonction As System.Windows.Forms.ComboBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sexe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telephone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fonction As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datenaissance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lieunaissance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salairenegocier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rechercher As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbcombo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents dgdata As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
