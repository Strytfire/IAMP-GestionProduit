﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddCommande
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddCommande))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnAdd = New ns1.BunifuFlatButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtNum = New ns1.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextbox1 = New ns1.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBProd = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtboxQte = New ns1.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CbCat = New System.Windows.Forms.ComboBox()
        Me.BtnDel = New ns1.BunifuFlatButton()
        Me.BtnRetour = New ns1.BunifuImageButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DGVProd = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtmontantHT = New ns1.BunifuMetroTextbox()
        Me.BtnOk = New ns1.BunifuFlatButton()
        Me.Panel1.SuspendLayout()
        CType(Me.BtnRetour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(43, 504)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(255, 16)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Montant Hors Taxes de la Commande :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(54, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Catégorie :"
        '
        'BtnAdd
        '
        Me.BtnAdd.Activecolor = System.Drawing.Color.Gray
        Me.BtnAdd.BackColor = System.Drawing.Color.Gray
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdd.BorderRadius = 7
        Me.BtnAdd.ButtonText = "Ajouter a la Commande"
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.DisabledColor = System.Drawing.Color.Gray
        Me.BtnAdd.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnAdd.Iconimage = Nothing
        Me.BtnAdd.Iconimage_right = Nothing
        Me.BtnAdd.Iconimage_right_Selected = Nothing
        Me.BtnAdd.Iconimage_Selected = Nothing
        Me.BtnAdd.IconMarginLeft = 0
        Me.BtnAdd.IconMarginRight = 0
        Me.BtnAdd.IconRightVisible = True
        Me.BtnAdd.IconRightZoom = 0R
        Me.BtnAdd.IconVisible = True
        Me.BtnAdd.IconZoom = 90.0R
        Me.BtnAdd.IsTab = False
        Me.BtnAdd.Location = New System.Drawing.Point(58, 165)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Normalcolor = System.Drawing.Color.Gray
        Me.BtnAdd.OnHovercolor = System.Drawing.Color.DarkGray
        Me.BtnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnAdd.selected = False
        Me.BtnAdd.Size = New System.Drawing.Size(153, 67)
        Me.BtnAdd.TabIndex = 6
        Me.BtnAdd.Text = "Ajouter a la Commande"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAdd.Textcolor = System.Drawing.Color.White
        Me.BtnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Ajouter / Gérer Produit :"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(189, 107)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox1.TabIndex = 40
        '
        'txtNum
        '
        Me.txtNum.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNum.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.txtNum.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.txtNum.BorderThickness = 2
        Me.txtNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNum.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNum.isPassword = False
        Me.txtNum.Location = New System.Drawing.Point(189, 47)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(155, 22)
        Me.txtNum.TabIndex = 37
        Me.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Numéro :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Produit :"
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.BunifuMetroTextbox1.BorderThickness = 2
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(189, 77)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(155, 22)
        Me.BunifuMetroTextbox1.TabIndex = 43
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Client :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Date :"
        '
        'CBProd
        '
        Me.CBProd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CBProd.Enabled = False
        Me.CBProd.FormattingEnabled = True
        Me.CBProd.Location = New System.Drawing.Point(132, 82)
        Me.CBProd.Name = "CBProd"
        Me.CBProd.Size = New System.Drawing.Size(279, 21)
        Me.CBProd.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Quantité :"
        '
        'TxtboxQte
        '
        Me.TxtboxQte.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtboxQte.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtboxQte.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.TxtboxQte.BorderThickness = 2
        Me.TxtboxQte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtboxQte.Enabled = False
        Me.TxtboxQte.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtboxQte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtboxQte.isPassword = False
        Me.TxtboxQte.Location = New System.Drawing.Point(132, 110)
        Me.TxtboxQte.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtboxQte.Name = "TxtboxQte"
        Me.TxtboxQte.Size = New System.Drawing.Size(279, 22)
        Me.TxtboxQte.TabIndex = 37
        Me.TxtboxQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "La Commande :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.CbCat)
        Me.Panel1.Controls.Add(Me.CBProd)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtboxQte)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.BtnAdd)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.BtnDel)
        Me.Panel1.Location = New System.Drawing.Point(36, 217)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 262)
        Me.Panel1.TabIndex = 50
        '
        'CbCat
        '
        Me.CbCat.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CbCat.Enabled = False
        Me.CbCat.FormattingEnabled = True
        Me.CbCat.Location = New System.Drawing.Point(132, 50)
        Me.CbCat.Name = "CbCat"
        Me.CbCat.Size = New System.Drawing.Size(279, 21)
        Me.CbCat.TabIndex = 40
        '
        'BtnDel
        '
        Me.BtnDel.Activecolor = System.Drawing.Color.Gray
        Me.BtnDel.BackColor = System.Drawing.Color.Gray
        Me.BtnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDel.BorderRadius = 7
        Me.BtnDel.ButtonText = "Retirer de la commande"
        Me.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDel.DisabledColor = System.Drawing.Color.Gray
        Me.BtnDel.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnDel.Iconimage = Nothing
        Me.BtnDel.Iconimage_right = Nothing
        Me.BtnDel.Iconimage_right_Selected = Nothing
        Me.BtnDel.Iconimage_Selected = Nothing
        Me.BtnDel.IconMarginLeft = 0
        Me.BtnDel.IconMarginRight = 0
        Me.BtnDel.IconRightVisible = True
        Me.BtnDel.IconRightZoom = 0R
        Me.BtnDel.IconVisible = True
        Me.BtnDel.IconZoom = 90.0R
        Me.BtnDel.IsTab = False
        Me.BtnDel.Location = New System.Drawing.Point(258, 165)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Normalcolor = System.Drawing.Color.Gray
        Me.BtnDel.OnHovercolor = System.Drawing.Color.DarkGray
        Me.BtnDel.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnDel.selected = False
        Me.BtnDel.Size = New System.Drawing.Size(153, 67)
        Me.BtnDel.TabIndex = 5
        Me.BtnDel.Text = "Retirer de la commande"
        Me.BtnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnDel.Textcolor = System.Drawing.Color.White
        Me.BtnDel.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnRetour
        '
        Me.BtnRetour.BackColor = System.Drawing.Color.Transparent
        Me.BtnRetour.Image = CType(resources.GetObject("BtnRetour.Image"), System.Drawing.Image)
        Me.BtnRetour.ImageActive = Nothing
        Me.BtnRetour.Location = New System.Drawing.Point(19, 17)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(30, 31)
        Me.BtnRetour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnRetour.TabIndex = 45
        Me.BtnRetour.TabStop = False
        Me.BtnRetour.Zoom = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(524, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(252, 16)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Récapitulatif des Produit Commandé :"
        '
        'DGVProd
        '
        Me.DGVProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGVProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProd.Location = New System.Drawing.Point(527, 54)
        Me.DGVProd.Name = "DGVProd"
        Me.DGVProd.Size = New System.Drawing.Size(551, 475)
        Me.DGVProd.TabIndex = 46
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Controls.Add(Me.BtnOk)
        Me.Panel2.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.txtNum)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(36, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(460, 157)
        Me.Panel2.TabIndex = 48
        '
        'txtmontantHT
        '
        Me.txtmontantHT.BackColor = System.Drawing.Color.LightCoral
        Me.txtmontantHT.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.txtmontantHT.BorderColorIdle = System.Drawing.Color.IndianRed
        Me.txtmontantHT.BorderColorMouseHover = System.Drawing.Color.LightCoral
        Me.txtmontantHT.BorderThickness = 2
        Me.txtmontantHT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmontantHT.Enabled = False
        Me.txtmontantHT.Font = New System.Drawing.Font("Omnes Semibold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmontantHT.ForeColor = System.Drawing.Color.LightCoral
        Me.txtmontantHT.isPassword = False
        Me.txtmontantHT.Location = New System.Drawing.Point(305, 498)
        Me.txtmontantHT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmontantHT.Name = "txtmontantHT"
        Me.txtmontantHT.Size = New System.Drawing.Size(191, 22)
        Me.txtmontantHT.TabIndex = 49
        Me.txtmontantHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnOk
        '
        Me.BtnOk.Activecolor = System.Drawing.Color.Gray
        Me.BtnOk.BackColor = System.Drawing.Color.Gray
        Me.BtnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOk.BorderRadius = 7
        Me.BtnOk.ButtonText = "Ok"
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.DisabledColor = System.Drawing.Color.Gray
        Me.BtnOk.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnOk.Iconimage = Nothing
        Me.BtnOk.Iconimage_right = Nothing
        Me.BtnOk.Iconimage_right_Selected = Nothing
        Me.BtnOk.Iconimage_Selected = Nothing
        Me.BtnOk.IconMarginLeft = 0
        Me.BtnOk.IconMarginRight = 0
        Me.BtnOk.IconRightVisible = True
        Me.BtnOk.IconRightZoom = 0R
        Me.BtnOk.IconVisible = True
        Me.BtnOk.IconZoom = 90.0R
        Me.BtnOk.IsTab = False
        Me.BtnOk.Location = New System.Drawing.Point(370, 60)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Normalcolor = System.Drawing.Color.Gray
        Me.BtnOk.OnHovercolor = System.Drawing.Color.DarkGray
        Me.BtnOk.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnOk.selected = False
        Me.BtnOk.Size = New System.Drawing.Size(63, 55)
        Me.BtnOk.TabIndex = 41
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnOk.Textcolor = System.Drawing.Color.White
        Me.BtnOk.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FrmAddCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1097, 546)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DGVProd)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtmontantHT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAddCommande"
        Me.Text = "FrmAddCommande"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BtnRetour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnAdd As ns1.BunifuFlatButton
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtNum As ns1.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuMetroTextbox1 As ns1.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBProd As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtboxQte As ns1.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CbCat As ComboBox
    Friend WithEvents BtnDel As ns1.BunifuFlatButton
    Friend WithEvents BtnRetour As ns1.BunifuImageButton
    Friend WithEvents Label9 As Label
    Friend WithEvents DGVProd As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtmontantHT As ns1.BunifuMetroTextbox
    Friend WithEvents BtnOk As ns1.BunifuFlatButton
End Class
