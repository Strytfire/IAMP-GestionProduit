<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAMSCommande
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAMSCommande))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAddCom = New ns1.BunifuFlatButton()
        Me.BtnSuiComm = New ns1.BunifuImageButton()
        Me.BtnPrecCom = New ns1.BunifuImageButton()
        Me.BtnFinCom = New ns1.BunifuImageButton()
        Me.BtnDebCom = New ns1.BunifuImageButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvCom = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CbCliCom = New System.Windows.Forms.ComboBox()
        Me.TxtBDateCom = New ns1.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBNumCom = New ns1.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConsultCom = New ns1.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton5 = New ns1.BunifuFlatButton()
        Me.Panel1.SuspendLayout()
        CType(Me.BtnSuiComm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPrecCom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFinCom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDebCom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(517, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 16)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Liste des Commandes :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.BtnAddCom)
        Me.Panel1.Controls.Add(Me.BtnSuiComm)
        Me.Panel1.Controls.Add(Me.BtnPrecCom)
        Me.Panel1.Controls.Add(Me.BtnFinCom)
        Me.Panel1.Controls.Add(Me.BtnDebCom)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(28, 317)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 196)
        Me.Panel1.TabIndex = 37
        '
        'BtnAddCom
        '
        Me.BtnAddCom.Activecolor = System.Drawing.Color.Gray
        Me.BtnAddCom.BackColor = System.Drawing.Color.Gray
        Me.BtnAddCom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddCom.BorderRadius = 7
        Me.BtnAddCom.ButtonText = "Nouvelle Commande"
        Me.BtnAddCom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddCom.DisabledColor = System.Drawing.Color.Gray
        Me.BtnAddCom.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnAddCom.Iconimage = Nothing
        Me.BtnAddCom.Iconimage_right = Nothing
        Me.BtnAddCom.Iconimage_right_Selected = Nothing
        Me.BtnAddCom.Iconimage_Selected = Nothing
        Me.BtnAddCom.IconMarginLeft = 0
        Me.BtnAddCom.IconMarginRight = 0
        Me.BtnAddCom.IconRightVisible = True
        Me.BtnAddCom.IconRightZoom = 0R
        Me.BtnAddCom.IconVisible = True
        Me.BtnAddCom.IconZoom = 90.0R
        Me.BtnAddCom.IsTab = False
        Me.BtnAddCom.Location = New System.Drawing.Point(159, 85)
        Me.BtnAddCom.Name = "BtnAddCom"
        Me.BtnAddCom.Normalcolor = System.Drawing.Color.Gray
        Me.BtnAddCom.OnHovercolor = System.Drawing.Color.DarkGray
        Me.BtnAddCom.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnAddCom.selected = False
        Me.BtnAddCom.Size = New System.Drawing.Size(136, 48)
        Me.BtnAddCom.TabIndex = 4
        Me.BtnAddCom.Text = "Nouvelle Commande"
        Me.BtnAddCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAddCom.Textcolor = System.Drawing.Color.White
        Me.BtnAddCom.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnSuiComm
        '
        Me.BtnSuiComm.BackColor = System.Drawing.Color.Transparent
        Me.BtnSuiComm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSuiComm.Image = CType(resources.GetObject("BtnSuiComm.Image"), System.Drawing.Image)
        Me.BtnSuiComm.ImageActive = Nothing
        Me.BtnSuiComm.Location = New System.Drawing.Point(310, 81)
        Me.BtnSuiComm.Name = "BtnSuiComm"
        Me.BtnSuiComm.Size = New System.Drawing.Size(49, 56)
        Me.BtnSuiComm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSuiComm.TabIndex = 3
        Me.BtnSuiComm.TabStop = False
        Me.BtnSuiComm.Zoom = 10
        '
        'BtnPrecCom
        '
        Me.BtnPrecCom.BackColor = System.Drawing.Color.Transparent
        Me.BtnPrecCom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrecCom.Image = CType(resources.GetObject("BtnPrecCom.Image"), System.Drawing.Image)
        Me.BtnPrecCom.ImageActive = Nothing
        Me.BtnPrecCom.Location = New System.Drawing.Point(92, 81)
        Me.BtnPrecCom.Name = "BtnPrecCom"
        Me.BtnPrecCom.Size = New System.Drawing.Size(49, 56)
        Me.BtnPrecCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnPrecCom.TabIndex = 2
        Me.BtnPrecCom.TabStop = False
        Me.BtnPrecCom.Zoom = 10
        '
        'BtnFinCom
        '
        Me.BtnFinCom.BackColor = System.Drawing.Color.Transparent
        Me.BtnFinCom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFinCom.Image = CType(resources.GetObject("BtnFinCom.Image"), System.Drawing.Image)
        Me.BtnFinCom.ImageActive = Nothing
        Me.BtnFinCom.Location = New System.Drawing.Point(366, 81)
        Me.BtnFinCom.Name = "BtnFinCom"
        Me.BtnFinCom.Size = New System.Drawing.Size(49, 56)
        Me.BtnFinCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFinCom.TabIndex = 2
        Me.BtnFinCom.TabStop = False
        Me.BtnFinCom.Zoom = 10
        '
        'BtnDebCom
        '
        Me.BtnDebCom.BackColor = System.Drawing.Color.Transparent
        Me.BtnDebCom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDebCom.Image = CType(resources.GetObject("BtnDebCom.Image"), System.Drawing.Image)
        Me.BtnDebCom.ImageActive = Nothing
        Me.BtnDebCom.Location = New System.Drawing.Point(37, 81)
        Me.BtnDebCom.Name = "BtnDebCom"
        Me.BtnDebCom.Size = New System.Drawing.Size(49, 56)
        Me.BtnDebCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnDebCom.TabIndex = 1
        Me.BtnDebCom.TabStop = False
        Me.BtnDebCom.Zoom = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Recherche d'une commande :"
        '
        'dgvCom
        '
        Me.dgvCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCom.Location = New System.Drawing.Point(520, 38)
        Me.dgvCom.Name = "dgvCom"
        Me.dgvCom.Size = New System.Drawing.Size(551, 475)
        Me.dgvCom.TabIndex = 35
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Controls.Add(Me.CbCliCom)
        Me.Panel2.Controls.Add(Me.TxtBDateCom)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxtBNumCom)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnConsultCom)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BunifuFlatButton5)
        Me.Panel2.Location = New System.Drawing.Point(27, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(460, 274)
        Me.Panel2.TabIndex = 38
        '
        'CbCliCom
        '
        Me.CbCliCom.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CbCliCom.FormattingEnabled = True
        Me.CbCliCom.Location = New System.Drawing.Point(126, 127)
        Me.CbCliCom.Name = "CbCliCom"
        Me.CbCliCom.Size = New System.Drawing.Size(279, 21)
        Me.CbCliCom.TabIndex = 40
        '
        'TxtBDateCom
        '
        Me.TxtBDateCom.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtBDateCom.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtBDateCom.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.TxtBDateCom.BorderThickness = 2
        Me.TxtBDateCom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBDateCom.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBDateCom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBDateCom.isPassword = False
        Me.TxtBDateCom.Location = New System.Drawing.Point(126, 96)
        Me.TxtBDateCom.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBDateCom.Name = "TxtBDateCom"
        Me.TxtBDateCom.Size = New System.Drawing.Size(279, 22)
        Me.TxtBDateCom.TabIndex = 39
        Me.TxtBDateCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Omnes Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Client :"
        '
        'TxtBNumCom
        '
        Me.TxtBNumCom.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtBNumCom.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtBNumCom.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.TxtBNumCom.BorderThickness = 2
        Me.TxtBNumCom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBNumCom.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBNumCom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBNumCom.isPassword = False
        Me.TxtBNumCom.Location = New System.Drawing.Point(126, 65)
        Me.TxtBNumCom.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBNumCom.Name = "TxtBNumCom"
        Me.TxtBNumCom.Size = New System.Drawing.Size(279, 22)
        Me.TxtBNumCom.TabIndex = 37
        Me.TxtBNumCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Omnes Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Omnes Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Numéro :"
        '
        'btnConsultCom
        '
        Me.btnConsultCom.Activecolor = System.Drawing.Color.Gray
        Me.btnConsultCom.BackColor = System.Drawing.Color.Gray
        Me.btnConsultCom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultCom.BorderRadius = 7
        Me.btnConsultCom.ButtonText = "Consulter la Commande"
        Me.btnConsultCom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultCom.DisabledColor = System.Drawing.Color.Gray
        Me.btnConsultCom.Iconcolor = System.Drawing.Color.Transparent
        Me.btnConsultCom.Iconimage = Nothing
        Me.btnConsultCom.Iconimage_right = Nothing
        Me.btnConsultCom.Iconimage_right_Selected = Nothing
        Me.btnConsultCom.Iconimage_Selected = Nothing
        Me.btnConsultCom.IconMarginLeft = 0
        Me.btnConsultCom.IconMarginRight = 0
        Me.btnConsultCom.IconRightVisible = True
        Me.btnConsultCom.IconRightZoom = 0R
        Me.btnConsultCom.IconVisible = True
        Me.btnConsultCom.IconZoom = 90.0R
        Me.btnConsultCom.IsTab = False
        Me.btnConsultCom.Location = New System.Drawing.Point(47, 180)
        Me.btnConsultCom.Name = "btnConsultCom"
        Me.btnConsultCom.Normalcolor = System.Drawing.Color.Gray
        Me.btnConsultCom.OnHovercolor = System.Drawing.Color.DarkGray
        Me.btnConsultCom.OnHoverTextColor = System.Drawing.Color.White
        Me.btnConsultCom.selected = False
        Me.btnConsultCom.Size = New System.Drawing.Size(166, 73)
        Me.btnConsultCom.TabIndex = 6
        Me.btnConsultCom.Text = "Consulter la Commande"
        Me.btnConsultCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnConsultCom.Textcolor = System.Drawing.Color.White
        Me.btnConsultCom.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Commande Sélectionnée :"
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 7
        Me.BunifuFlatButton5.ButtonText = "Supprimer la Commande"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = Nothing
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 90.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(259, 180)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.DarkGray
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(166, 73)
        Me.BunifuFlatButton5.TabIndex = 5
        Me.BunifuFlatButton5.Text = "Supprimer la Commande"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FrmAMSCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1097, 546)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvCom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAMSCommande"
        Me.Text = "FrmAMSCommande"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BtnSuiComm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPrecCom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFinCom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDebCom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAddCom As ns1.BunifuFlatButton
    Friend WithEvents BtnSuiComm As ns1.BunifuImageButton
    Friend WithEvents BtnPrecCom As ns1.BunifuImageButton
    Friend WithEvents BtnFinCom As ns1.BunifuImageButton
    Friend WithEvents BtnDebCom As ns1.BunifuImageButton
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvCom As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnConsultCom As ns1.BunifuFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuFlatButton5 As ns1.BunifuFlatButton
    Friend WithEvents TxtBDateCom As ns1.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBNumCom As ns1.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbCliCom As ComboBox
End Class
