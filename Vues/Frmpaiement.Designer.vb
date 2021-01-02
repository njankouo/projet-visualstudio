<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmpaiement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmpaiement))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtmontant = New System.Windows.Forms.TextBox()
        Me.txtdate = New System.Windows.Forms.DateTimePicker()
        Me.txtpaiement = New System.Windows.Forms.TextBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.dgpaiement = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type_paiement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_paiement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personnel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbpersonnel = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgpaiement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmbpersonnel)
        Me.GroupBox1.Controls.Add(Me.txtmontant)
        Me.GroupBox1.Controls.Add(Me.txtdate)
        Me.GroupBox1.Controls.Add(Me.txtpaiement)
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Controls.Add(Me.label3)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Brush Script MT", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 471)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "paiment"
        '
        'txtmontant
        '
        Me.txtmontant.Location = New System.Drawing.Point(125, 228)
        Me.txtmontant.Name = "txtmontant"
        Me.txtmontant.Size = New System.Drawing.Size(173, 27)
        Me.txtmontant.TabIndex = 8
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(125, 156)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(173, 27)
        Me.txtdate.TabIndex = 7
        '
        'txtpaiement
        '
        Me.txtpaiement.Location = New System.Drawing.Point(125, 73)
        Me.txtpaiement.Name = "txtpaiement"
        Me.txtpaiement.Size = New System.Drawing.Size(173, 27)
        Me.txtpaiement.TabIndex = 6
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(197, 387)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(110, 40)
        Me.btndelete.TabIndex = 5
        Me.btndelete.Text = "supprimer"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(21, 387)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(110, 40)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "enregistrer"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(17, 299)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 19)
        Me.label4.TabIndex = 3
        Me.label4.Text = "personnel"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(17, 228)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(49, 19)
        Me.label3.TabIndex = 2
        Me.label3.Text = "montant"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(16, 156)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(96, 19)
        Me.label2.TabIndex = 1
        Me.label2.Text = "date de paiement"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(17, 73)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(95, 19)
        Me.label1.TabIndex = 0
        Me.label1.Text = "type de paiement"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(485, 63)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(332, 472)
        Me.ListBox1.TabIndex = 1
        '
        'dgpaiement
        '
        Me.dgpaiement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpaiement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.type_paiement, Me.date_paiement, Me.montant, Me.personnel})
        Me.dgpaiement.Location = New System.Drawing.Point(372, 63)
        Me.dgpaiement.Name = "dgpaiement"
        Me.dgpaiement.Size = New System.Drawing.Size(525, 472)
        Me.dgpaiement.TabIndex = 2
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        '
        'type_paiement
        '
        Me.type_paiement.HeaderText = "type_paiement"
        Me.type_paiement.Name = "type_paiement"
        '
        'date_paiement
        '
        Me.date_paiement.HeaderText = "date_paiement"
        Me.date_paiement.Name = "date_paiement"
        '
        'montant
        '
        Me.montant.HeaderText = "montant"
        Me.montant.Name = "montant"
        '
        'personnel
        '
        Me.personnel.HeaderText = "personnel"
        Me.personnel.Name = "personnel"
        '
        'cmbpersonnel
        '
        Me.cmbpersonnel.FormattingEnabled = True
        Me.cmbpersonnel.Location = New System.Drawing.Point(125, 296)
        Me.cmbpersonnel.Name = "cmbpersonnel"
        Me.cmbpersonnel.Size = New System.Drawing.Size(173, 27)
        Me.cmbpersonnel.TabIndex = 9
        '
        'Frmpaiement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(902, 551)
        Me.Controls.Add(Me.dgpaiement)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frmpaiement"
        Me.Text = "Frmpaiement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgpaiement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents dgpaiement As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type_paiement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_paiement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents montant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents personnel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtmontant As System.Windows.Forms.TextBox
    Friend WithEvents txtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtpaiement As System.Windows.Forms.TextBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents cmbpersonnel As System.Windows.Forms.ComboBox
End Class
