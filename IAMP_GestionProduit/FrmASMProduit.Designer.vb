<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmASMProduit
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmASMProduit))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtBRechercheProd = New ns1.BunifuMetroTextbox()
        Me.BtnPDFProduit = New ns1.BunifuFlatButton()
        Me.BtnModifProd = New ns1.BunifuFlatButton()
        Me.BtnSuppProd = New ns1.BunifuFlatButton()
        Me.BtnAddPro = New ns1.BunifuFlatButton()
        Me.BtnSuivProd = New ns1.BunifuImageButton()
        Me.BtnPreProd = New ns1.BunifuImageButton()
        Me.BtnFinProd = New ns1.BunifuImageButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnDebutProd = New ns1.BunifuImageButton()
        Me.TxtBQteP = New ns1.BunifuMetroTextbox()
        Me.TxtBPrixP = New ns1.BunifuMetroTextbox()
        Me.TxtBLibP = New ns1.BunifuMetroTextbox()
        Me.TxtBCP = New ns1.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvLesProduits = New System.Windows.Forms.DataGridView()
        Me.CmbFour = New System.Windows.Forms.ComboBox()
        Me.CbCat = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.BtnSuivProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPreProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFinProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDebutProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLesProduits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(611, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Recherche :"
        '
        'TxtBRechercheProd
        '
        Me.TxtBRechercheProd.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtBRechercheProd.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtBRechercheProd.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.TxtBRechercheProd.BorderThickness = 2
        Me.TxtBRechercheProd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBRechercheProd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBRechercheProd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBRechercheProd.isPassword = False
        Me.TxtBRechercheProd.Location = New System.Drawing.Point(722, 23)
        Me.TxtBRechercheProd.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBRechercheProd.Name = "TxtBRechercheProd"
        Me.TxtBRechercheProd.Size = New System.Drawing.Size(266, 30)
        Me.TxtBRechercheProd.TabIndex = 15
        Me.TxtBRechercheProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnPDFProduit
        '
        Me.BtnPDFProduit.Activecolor = System.Drawing.Color.Gray
        Me.BtnPDFProduit.BackColor = System.Drawing.Color.DarkGray
        Me.BtnPDFProduit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPDFProduit.BorderRadius = 7
        Me.BtnPDFProduit.ButtonText = "Générer PDF"
        Me.BtnPDFProduit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPDFProduit.DisabledColor = System.Drawing.Color.Gray
        Me.BtnPDFProduit.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnPDFProduit.Iconimage = Nothing
        Me.BtnPDFProduit.Iconimage_right = Nothing
        Me.BtnPDFProduit.Iconimage_right_Selected = Nothing
        Me.BtnPDFProduit.Iconimage_Selected = Nothing
        Me.BtnPDFProduit.IconMarginLeft = 0
        Me.BtnPDFProduit.IconMarginRight = 0
        Me.BtnPDFProduit.IconRightVisible = True
        Me.BtnPDFProduit.IconRightZoom = 0R
        Me.BtnPDFProduit.IconVisible = True
        Me.BtnPDFProduit.IconZoom = 90.0R
        Me.BtnPDFProduit.IsTab = False
        Me.BtnPDFProduit.Location = New System.Drawing.Point(113, 140)
        Me.BtnPDFProduit.Name = "BtnPDFProduit"
        Me.BtnPDFProduit.Normalcolor = System.Drawing.Color.DarkGray
        Me.BtnPDFProduit.OnHovercolor = System.Drawing.Color.Gray
        Me.BtnPDFProduit.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnPDFProduit.selected = False
        Me.BtnPDFProduit.Size = New System.Drawing.Size(136, 48)
        Me.BtnPDFProduit.TabIndex = 7
        Me.BtnPDFProduit.Text = "Générer PDF"
        Me.BtnPDFProduit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPDFProduit.Textcolor = System.Drawing.Color.White
        Me.BtnPDFProduit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnModifProd
        '
        Me.BtnModifProd.Activecolor = System.Drawing.Color.Gray
        Me.BtnModifProd.BackColor = System.Drawing.Color.Gray
        Me.BtnModifProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModifProd.BorderRadius = 7
        Me.BtnModifProd.ButtonText = "Modifier"
        Me.BtnModifProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModifProd.DisabledColor = System.Drawing.Color.Gray
        Me.BtnModifProd.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnModifProd.Iconimage = Nothing
        Me.BtnModifProd.Iconimage_right = Nothing
        Me.BtnModifProd.Iconimage_right_Selected = Nothing
        Me.BtnModifProd.Iconimage_Selected = Nothing
        Me.BtnModifProd.IconMarginLeft = 0
        Me.BtnModifProd.IconMarginRight = 0
        Me.BtnModifProd.IconRightVisible = True
        Me.BtnModifProd.IconRightZoom = 0R
        Me.BtnModifProd.IconVisible = True
        Me.BtnModifProd.IconZoom = 90.0R
        Me.BtnModifProd.IsTab = False
        Me.BtnModifProd.Location = New System.Drawing.Point(401, 131)
        Me.BtnModifProd.Name = "BtnModifProd"
        Me.BtnModifProd.Normalcolor = System.Drawing.Color.Gray
        Me.BtnModifProd.OnHovercolor = System.Drawing.Color.DarkGray
        Me.BtnModifProd.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnModifProd.selected = False
        Me.BtnModifProd.Size = New System.Drawing.Size(136, 48)
        Me.BtnModifProd.TabIndex = 6
        Me.BtnModifProd.Text = "Modifier"
        Me.BtnModifProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnModifProd.Textcolor = System.Drawing.Color.White
        Me.BtnModifProd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnSuppProd
        '
        Me.BtnSuppProd.Activecolor = System.Drawing.Color.Gray
        Me.BtnSuppProd.BackColor = System.Drawing.Color.Gray
        Me.BtnSuppProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSuppProd.BorderRadius = 7
        Me.BtnSuppProd.ButtonText = "Supprimer"
        Me.BtnSuppProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSuppProd.DisabledColor = System.Drawing.Color.Gray
        Me.BtnSuppProd.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnSuppProd.Iconimage = Nothing
        Me.BtnSuppProd.Iconimage_right = Nothing
        Me.BtnSuppProd.Iconimage_right_Selected = Nothing
        Me.BtnSuppProd.Iconimage_Selected = Nothing
        Me.BtnSuppProd.IconMarginLeft = 0
        Me.BtnSuppProd.IconMarginRight = 0
        Me.BtnSuppProd.IconRightVisible = True
        Me.BtnSuppProd.IconRightZoom = 0R
        Me.BtnSuppProd.IconVisible = True
        Me.BtnSuppProd.IconZoom = 90.0R
        Me.BtnSuppProd.IsTab = False
        Me.BtnSuppProd.Location = New System.Drawing.Point(401, 77)
        Me.BtnSuppProd.Name = "BtnSuppProd"
        Me.BtnSuppProd.Normalcolor = System.Drawing.Color.Gray
        Me.BtnSuppProd.OnHovercolor = System.Drawing.Color.DarkGray
        Me.BtnSuppProd.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSuppProd.selected = False
        Me.BtnSuppProd.Size = New System.Drawing.Size(136, 48)
        Me.BtnSuppProd.TabIndex = 5
        Me.BtnSuppProd.Text = "Supprimer"
        Me.BtnSuppProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSuppProd.Textcolor = System.Drawing.Color.White
        Me.BtnSuppProd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnAddPro
        '
        Me.BtnAddPro.Activecolor = System.Drawing.Color.Gray
        Me.BtnAddPro.BackColor = System.Drawing.Color.Gray
        Me.BtnAddPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddPro.BorderRadius = 7
        Me.BtnAddPro.ButtonText = "Ajouter"
        Me.BtnAddPro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddPro.DisabledColor = System.Drawing.Color.Gray
        Me.BtnAddPro.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnAddPro.Iconimage = Nothing
        Me.BtnAddPro.Iconimage_right = Nothing
        Me.BtnAddPro.Iconimage_right_Selected = Nothing
        Me.BtnAddPro.Iconimage_Selected = Nothing
        Me.BtnAddPro.IconMarginLeft = 0
        Me.BtnAddPro.IconMarginRight = 0
        Me.BtnAddPro.IconRightVisible = True
        Me.BtnAddPro.IconRightZoom = 0R
        Me.BtnAddPro.IconVisible = True
        Me.BtnAddPro.IconZoom = 90.0R
        Me.BtnAddPro.IsTab = False
        Me.BtnAddPro.Location = New System.Drawing.Point(401, 23)
        Me.BtnAddPro.Name = "BtnAddPro"
        Me.BtnAddPro.Normalcolor = System.Drawing.Color.Gray
        Me.BtnAddPro.OnHovercolor = System.Drawing.Color.DarkGray
        Me.BtnAddPro.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnAddPro.selected = False
        Me.BtnAddPro.Size = New System.Drawing.Size(136, 48)
        Me.BtnAddPro.TabIndex = 4
        Me.BtnAddPro.Text = "Ajouter"
        Me.BtnAddPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAddPro.Textcolor = System.Drawing.Color.White
        Me.BtnAddPro.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnSuivProd
        '
        Me.BtnSuivProd.BackColor = System.Drawing.Color.Transparent
        Me.BtnSuivProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSuivProd.Image = CType(resources.GetObject("BtnSuivProd.Image"), System.Drawing.Image)
        Me.BtnSuivProd.ImageActive = Nothing
        Me.BtnSuivProd.Location = New System.Drawing.Point(200, 69)
        Me.BtnSuivProd.Name = "BtnSuivProd"
        Me.BtnSuivProd.Size = New System.Drawing.Size(49, 56)
        Me.BtnSuivProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSuivProd.TabIndex = 3
        Me.BtnSuivProd.TabStop = False
        Me.BtnSuivProd.Zoom = 10
        '
        'BtnPreProd
        '
        Me.BtnPreProd.BackColor = System.Drawing.Color.Transparent
        Me.BtnPreProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPreProd.Image = CType(resources.GetObject("BtnPreProd.Image"), System.Drawing.Image)
        Me.BtnPreProd.ImageActive = Nothing
        Me.BtnPreProd.Location = New System.Drawing.Point(106, 69)
        Me.BtnPreProd.Name = "BtnPreProd"
        Me.BtnPreProd.Size = New System.Drawing.Size(49, 56)
        Me.BtnPreProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnPreProd.TabIndex = 2
        Me.BtnPreProd.TabStop = False
        Me.BtnPreProd.Zoom = 10
        '
        'BtnFinProd
        '
        Me.BtnFinProd.BackColor = System.Drawing.Color.Transparent
        Me.BtnFinProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFinProd.Image = CType(resources.GetObject("BtnFinProd.Image"), System.Drawing.Image)
        Me.BtnFinProd.ImageActive = Nothing
        Me.BtnFinProd.Location = New System.Drawing.Point(264, 69)
        Me.BtnFinProd.Name = "BtnFinProd"
        Me.BtnFinProd.Size = New System.Drawing.Size(49, 56)
        Me.BtnFinProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFinProd.TabIndex = 2
        Me.BtnFinProd.TabStop = False
        Me.BtnFinProd.Zoom = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Gestion des Produit :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtBRechercheProd)
        Me.Panel1.Controls.Add(Me.BtnPDFProduit)
        Me.Panel1.Controls.Add(Me.BtnModifProd)
        Me.Panel1.Controls.Add(Me.BtnSuppProd)
        Me.Panel1.Controls.Add(Me.BtnAddPro)
        Me.Panel1.Controls.Add(Me.BtnSuivProd)
        Me.Panel1.Controls.Add(Me.BtnPreProd)
        Me.Panel1.Controls.Add(Me.BtnFinProd)
        Me.Panel1.Controls.Add(Me.BtnDebutProd)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(28, 304)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 211)
        Me.Panel1.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(592, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Image du produit :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(722, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 119)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'BtnDebutProd
        '
        Me.BtnDebutProd.BackColor = System.Drawing.Color.Transparent
        Me.BtnDebutProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDebutProd.Image = CType(resources.GetObject("BtnDebutProd.Image"), System.Drawing.Image)
        Me.BtnDebutProd.ImageActive = Nothing
        Me.BtnDebutProd.Location = New System.Drawing.Point(42, 69)
        Me.BtnDebutProd.Name = "BtnDebutProd"
        Me.BtnDebutProd.Size = New System.Drawing.Size(49, 56)
        Me.BtnDebutProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnDebutProd.TabIndex = 1
        Me.BtnDebutProd.TabStop = False
        Me.BtnDebutProd.Zoom = 10
        '
        'TxtBQteP
        '
        Me.TxtBQteP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBQteP.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtBQteP.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtBQteP.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.TxtBQteP.BorderThickness = 2
        Me.TxtBQteP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBQteP.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBQteP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBQteP.isPassword = False
        Me.TxtBQteP.Location = New System.Drawing.Point(227, 156)
        Me.TxtBQteP.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBQteP.Name = "TxtBQteP"
        Me.TxtBQteP.Size = New System.Drawing.Size(217, 30)
        Me.TxtBQteP.TabIndex = 33
        Me.TxtBQteP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtBPrixP
        '
        Me.TxtBPrixP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBPrixP.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtBPrixP.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtBPrixP.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.TxtBPrixP.BorderThickness = 2
        Me.TxtBPrixP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBPrixP.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBPrixP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBPrixP.isPassword = False
        Me.TxtBPrixP.Location = New System.Drawing.Point(173, 109)
        Me.TxtBPrixP.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBPrixP.Name = "TxtBPrixP"
        Me.TxtBPrixP.Size = New System.Drawing.Size(314, 30)
        Me.TxtBPrixP.TabIndex = 32
        Me.TxtBPrixP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtBLibP
        '
        Me.TxtBLibP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBLibP.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtBLibP.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtBLibP.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.TxtBLibP.BorderThickness = 2
        Me.TxtBLibP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBLibP.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBLibP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBLibP.isPassword = False
        Me.TxtBLibP.Location = New System.Drawing.Point(174, 61)
        Me.TxtBLibP.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBLibP.Name = "TxtBLibP"
        Me.TxtBLibP.Size = New System.Drawing.Size(314, 30)
        Me.TxtBLibP.TabIndex = 31
        Me.TxtBLibP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtBCP
        '
        Me.TxtBCP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBCP.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtBCP.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtBCP.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.TxtBCP.BorderThickness = 2
        Me.TxtBCP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBCP.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBCP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBCP.isPassword = False
        Me.TxtBCP.Location = New System.Drawing.Point(174, 18)
        Me.TxtBCP.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBCP.Name = "TxtBCP"
        Me.TxtBCP.Size = New System.Drawing.Size(313, 30)
        Me.TxtBCP.TabIndex = 30
        Me.TxtBCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Catégorie :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Fournisseur :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Image Produit :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Prix HT :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Libellé Produit :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Code Produit :"
        '
        'dgvLesProduits
        '
        Me.dgvLesProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLesProduits.Location = New System.Drawing.Point(520, 25)
        Me.dgvLesProduits.Name = "dgvLesProduits"
        Me.dgvLesProduits.Size = New System.Drawing.Size(551, 255)
        Me.dgvLesProduits.TabIndex = 21
        '
        'CmbFour
        '
        Me.CmbFour.BackColor = System.Drawing.SystemColors.Control
        Me.CmbFour.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbFour.FormattingEnabled = True
        Me.CmbFour.Location = New System.Drawing.Point(228, 209)
        Me.CmbFour.Name = "CmbFour"
        Me.CmbFour.Size = New System.Drawing.Size(259, 24)
        Me.CmbFour.TabIndex = 35
        '
        'CbCat
        '
        Me.CbCat.BackColor = System.Drawing.SystemColors.Control
        Me.CbCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCat.FormattingEnabled = True
        Me.CbCat.Location = New System.Drawing.Point(228, 248)
        Me.CbCat.Name = "CbCat"
        Me.CbCat.Size = New System.Drawing.Size(259, 24)
        Me.CbCat.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(517, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Liste des Produit :"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(451, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 20)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = ".jpg"
        '
        'FrmASMProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1097, 546)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CbCat)
        Me.Controls.Add(Me.CmbFour)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtBQteP)
        Me.Controls.Add(Me.TxtBPrixP)
        Me.Controls.Add(Me.TxtBLibP)
        Me.Controls.Add(Me.TxtBCP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvLesProduits)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmASMProduit"
        Me.Text = "FrmASMProduit"
        CType(Me.BtnSuivProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPreProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFinProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDebutProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLesProduits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents TxtBRechercheProd As ns1.BunifuMetroTextbox
    Friend WithEvents BtnPDFProduit As ns1.BunifuFlatButton
    Friend WithEvents BtnModifProd As ns1.BunifuFlatButton
    Friend WithEvents BtnSuppProd As ns1.BunifuFlatButton
    Friend WithEvents BtnAddPro As ns1.BunifuFlatButton
    Friend WithEvents BtnSuivProd As ns1.BunifuImageButton
    Friend WithEvents BtnPreProd As ns1.BunifuImageButton
    Friend WithEvents BtnFinProd As ns1.BunifuImageButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnDebutProd As ns1.BunifuImageButton
    Friend WithEvents TxtBQteP As ns1.BunifuMetroTextbox
    Friend WithEvents TxtBPrixP As ns1.BunifuMetroTextbox
    Friend WithEvents TxtBLibP As ns1.BunifuMetroTextbox
    Friend WithEvents TxtBCP As ns1.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvLesProduits As DataGridView
    Friend WithEvents CmbFour As ComboBox
    Friend WithEvents CbCat As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label11 As Label
End Class
