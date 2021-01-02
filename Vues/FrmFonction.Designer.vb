<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFonction
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtsalairebase = New System.Windows.Forms.TextBox()
        Me.txtlibelle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnprint = New DevComponents.DotNetBar.ButtonX()
        Me.btnnew = New DevComponents.DotNetBar.ButtonX()
        Me.btndelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnsave = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgfonction = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgfonction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtsalairebase)
        Me.GroupBox1.Controls.Add(Me.txtlibelle)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations"
        '
        'txtsalairebase
        '
        Me.txtsalairebase.Location = New System.Drawing.Point(135, 110)
        Me.txtsalairebase.Name = "txtsalairebase"
        Me.txtsalairebase.Size = New System.Drawing.Size(180, 22)
        Me.txtsalairebase.TabIndex = 2
        '
        'txtlibelle
        '
        Me.txtlibelle.Location = New System.Drawing.Point(135, 35)
        Me.txtlibelle.Name = "txtlibelle"
        Me.txtlibelle.Size = New System.Drawing.Size(180, 22)
        Me.txtlibelle.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Salaire de Base :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Libelle :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnprint)
        Me.GroupBox2.Controls.Add(Me.btnnew)
        Me.GroupBox2.Controls.Add(Me.btndelete)
        Me.GroupBox2.Controls.Add(Me.btnsave)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 131)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions"
        '
        'btnprint
        '
        Me.btnprint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnprint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnprint.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(174, 84)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(130, 31)
        Me.btnprint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnprint.Symbol = ""
        Me.btnprint.SymbolColor = System.Drawing.Color.Black
        Me.btnprint.TabIndex = 0
        Me.btnprint.Text = "Imprimer"
        '
        'btnnew
        '
        Me.btnnew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnnew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnnew.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(26, 84)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(130, 31)
        Me.btnnew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnnew.Symbol = ""
        Me.btnnew.SymbolColor = System.Drawing.Color.Blue
        Me.btnnew.TabIndex = 0
        Me.btnnew.Text = "Nouveau"
        '
        'btndelete
        '
        Me.btndelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btndelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btndelete.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(174, 35)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(130, 31)
        Me.btndelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btndelete.Symbol = ""
        Me.btndelete.SymbolColor = System.Drawing.Color.Red
        Me.btndelete.TabIndex = 0
        Me.btndelete.Text = "Supprimer"
        '
        'btnsave
        '
        Me.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsave.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(26, 35)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(130, 31)
        Me.btnsave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnsave.Symbol = ""
        Me.btnsave.SymbolColor = System.Drawing.Color.Lime
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "Enregistrer"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgfonction)
        Me.GroupBox3.Location = New System.Drawing.Point(339, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(430, 311)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listes"
        '
        'dgfonction
        '
        Me.dgfonction.AllowUserToAddRows = False
        Me.dgfonction.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgfonction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgfonction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgfonction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgfonction.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgfonction.Location = New System.Drawing.Point(6, 19)
        Me.dgfonction.Name = "dgfonction"
        Me.dgfonction.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgfonction.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgfonction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgfonction.Size = New System.Drawing.Size(418, 286)
        Me.dgfonction.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.HeaderText = "Libelle"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Salaire Base"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'FrmFonction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 338)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmFonction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmFonction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgfonction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsalairebase As System.Windows.Forms.TextBox
    Friend WithEvents txtlibelle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgfonction As System.Windows.Forms.DataGridView
    Friend WithEvents btnprint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnnew As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btndelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnsave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
