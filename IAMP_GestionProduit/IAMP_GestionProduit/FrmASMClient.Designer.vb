<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmASMClient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmASMClient))
        Me.dgvLstClient = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtBIdCli = New ns1.BunifuMetroTextbox()
        Me.TxtBNomCli = New ns1.BunifuMetroTextbox()
        Me.TktBPreCli = New ns1.BunifuMetroTextbox()
        Me.TktBRueCli = New ns1.BunifuMetroTextbox()
        Me.TktBCodePos = New ns1.BunifuMetroTextbox()
        Me.TktBVilCli = New ns1.BunifuMetroTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtBRecherche = New ns1.BunifuMetroTextbox()
        Me.BtnPDF = New ns1.BunifuFlatButton()
        Me.BtnModifCli = New ns1.BunifuFlatButton()
        Me.BtnDelCli = New ns1.BunifuFlatButton()
        Me.BtnAddCli = New ns1.BunifuFlatButton()
        Me.BtnSuivant = New ns1.BunifuImageButton()
        Me.BtnPrecedent = New ns1.BunifuImageButton()
        Me.BtnFin = New ns1.BunifuImageButton()
        Me.BtnDebut = New ns1.BunifuImageButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvLstClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BtnSuivant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPrecedent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDebut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLstClient
        '
        Me.dgvLstClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLstClient.Location = New System.Drawing.Point(508, 21)
        Me.dgvLstClient.Name = "dgvLstClient"
        Me.dgvLstClient.Size = New System.Drawing.Size(551, 255)
        Me.dgvLstClient.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id Client :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom Client"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Prénom Client:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Rue Client :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Code Postal :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Ville Client :"
        '
        'TxtBIdCli
        '
        Me.TxtBIdCli.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBIdCli.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtBIdCli.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtBIdCli.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.TxtBIdCli.BorderThickness = 2
        Me.TxtBIdCli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBIdCli.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBIdCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBIdCli.isPassword = False
        Me.TxtBIdCli.Location = New System.Drawing.Point(166, 15)
        Me.TxtBIdCli.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBIdCli.Name = "TxtBIdCli"
        Me.TxtBIdCli.Size = New System.Drawing.Size(314, 30)
        Me.TxtBIdCli.TabIndex = 14
        Me.TxtBIdCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtBNomCli
        '
        Me.TxtBNomCli.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBNomCli.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtBNomCli.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtBNomCli.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.TxtBNomCli.BorderThickness = 2
        Me.TxtBNomCli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBNomCli.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBNomCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBNomCli.isPassword = False
        Me.TxtBNomCli.Location = New System.Drawing.Point(166, 58)
        Me.TxtBNomCli.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBNomCli.Name = "TxtBNomCli"
        Me.TxtBNomCli.Size = New System.Drawing.Size(314, 30)
        Me.TxtBNomCli.TabIndex = 15
        Me.TxtBNomCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TktBPreCli
        '
        Me.TktBPreCli.BackColor = System.Drawing.SystemColors.Control
        Me.TktBPreCli.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.TktBPreCli.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.TktBPreCli.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.TktBPreCli.BorderThickness = 2
        Me.TktBPreCli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TktBPreCli.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TktBPreCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TktBPreCli.isPassword = False
        Me.TktBPreCli.Location = New System.Drawing.Point(166, 103)
        Me.TktBPreCli.Margin = New System.Windows.Forms.Padding(4)
        Me.TktBPreCli.Name = "TktBPreCli"
        Me.TktBPreCli.Size = New System.Drawing.Size(314, 30)
        Me.TktBPreCli.TabIndex = 16
        Me.TktBPreCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TktBRueCli
        '
        Me.TktBRueCli.BackColor = System.Drawing.SystemColors.Control
        Me.TktBRueCli.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.TktBRueCli.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.TktBRueCli.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.TktBRueCli.BorderThickness = 2
        Me.TktBRueCli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TktBRueCli.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TktBRueCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TktBRueCli.isPassword = False
        Me.TktBRueCli.Location = New System.Drawing.Point(166, 151)
        Me.TktBRueCli.Margin = New System.Windows.Forms.Padding(4)
        Me.TktBRueCli.Name = "TktBRueCli"
        Me.TktBRueCli.Size = New System.Drawing.Size(314, 30)
        Me.TktBRueCli.TabIndex = 17
        Me.TktBRueCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TktBCodePos
        '
        Me.TktBCodePos.BackColor = System.Drawing.SystemColors.Control
        Me.TktBCodePos.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.TktBCodePos.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.TktBCodePos.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.TktBCodePos.BorderThickness = 2
        Me.TktBCodePos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TktBCodePos.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TktBCodePos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TktBCodePos.isPassword = False
        Me.TktBCodePos.Location = New System.Drawing.Point(166, 196)
        Me.TktBCodePos.Margin = New System.Windows.Forms.Padding(4)
        Me.TktBCodePos.Name = "TktBCodePos"
        Me.TktBCodePos.Size = New System.Drawing.Size(314, 30)
        Me.TktBCodePos.TabIndex = 18
        Me.TktBCodePos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TktBVilCli
        '
        Me.TktBVilCli.BackColor = System.Drawing.SystemColors.Control
        Me.TktBVilCli.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.TktBVilCli.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.TktBVilCli.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.TktBVilCli.BorderThickness = 2
        Me.TktBVilCli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TktBVilCli.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TktBVilCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TktBVilCli.isPassword = False
        Me.TktBVilCli.Location = New System.Drawing.Point(166, 238)
        Me.TktBVilCli.Margin = New System.Windows.Forms.Padding(4)
        Me.TktBVilCli.Name = "TktBVilCli"
        Me.TktBVilCli.Size = New System.Drawing.Size(314, 30)
        Me.TktBVilCli.TabIndex = 19
        Me.TktBVilCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtBRecherche)
        Me.Panel1.Controls.Add(Me.BtnPDF)
        Me.Panel1.Controls.Add(Me.BtnModifCli)
        Me.Panel1.Controls.Add(Me.BtnDelCli)
        Me.Panel1.Controls.Add(Me.BtnAddCli)
        Me.Panel1.Controls.Add(Me.BtnSuivant)
        Me.Panel1.Controls.Add(Me.BtnPrecedent)
        Me.Panel1.Controls.Add(Me.BtnFin)
        Me.Panel1.Controls.Add(Me.BtnDebut)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(28, 299)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 211)
        Me.Panel1.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(629, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Recherche :"
        '
        'TxtBRecherche
        '
        Me.TxtBRecherche.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtBRecherche.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtBRecherche.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.TxtBRecherche.BorderThickness = 2
        Me.TxtBRecherche.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBRecherche.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBRecherche.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBRecherche.isPassword = False
        Me.TxtBRecherche.Location = New System.Drawing.Point(740, 60)
        Me.TxtBRecherche.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBRecherche.Name = "TxtBRecherche"
        Me.TxtBRecherche.Size = New System.Drawing.Size(266, 30)
        Me.TxtBRecherche.TabIndex = 15
        Me.TxtBRecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnPDF
        '
        Me.BtnPDF.Activecolor = System.Drawing.Color.Gray
        Me.BtnPDF.BackColor = System.Drawing.Color.DarkGray
        Me.BtnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPDF.BorderRadius = 7
        Me.BtnPDF.ButtonText = "Générer PDF"
        Me.BtnPDF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPDF.DisabledColor = System.Drawing.Color.Gray
        Me.BtnPDF.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnPDF.Iconimage = Nothing
        Me.BtnPDF.Iconimage_right = Nothing
        Me.BtnPDF.Iconimage_right_Selected = Nothing
        Me.BtnPDF.Iconimage_Selected = Nothing
        Me.BtnPDF.IconMarginLeft = 0
        Me.BtnPDF.IconMarginRight = 0
        Me.BtnPDF.IconRightVisible = True
        Me.BtnPDF.IconRightZoom = 0R
        Me.BtnPDF.IconVisible = True
        Me.BtnPDF.IconZoom = 90.0R
        Me.BtnPDF.IsTab = False
        Me.BtnPDF.Location = New System.Drawing.Point(723, 131)
        Me.BtnPDF.Name = "BtnPDF"
        Me.BtnPDF.Normalcolor = System.Drawing.Color.DarkGray
        Me.BtnPDF.OnHovercolor = System.Drawing.Color.Gray
        Me.BtnPDF.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnPDF.selected = False
        Me.BtnPDF.Size = New System.Drawing.Size(136, 48)
        Me.BtnPDF.TabIndex = 7
        Me.BtnPDF.Text = "Générer PDF"
        Me.BtnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPDF.Textcolor = System.Drawing.Color.White
        Me.BtnPDF.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnModifCli
        '
        Me.BtnModifCli.Activecolor = System.Drawing.Color.Gray
        Me.BtnModifCli.BackColor = System.Drawing.Color.Gray
        Me.BtnModifCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModifCli.BorderRadius = 7
        Me.BtnModifCli.ButtonText = "Modifier"
        Me.BtnModifCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModifCli.DisabledColor = System.Drawing.Color.Gray
        Me.BtnModifCli.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnModifCli.Iconimage = Nothing
        Me.BtnModifCli.Iconimage_right = Nothing
        Me.BtnModifCli.Iconimage_right_Selected = Nothing
        Me.BtnModifCli.Iconimage_Selected = Nothing
        Me.BtnModifCli.IconMarginLeft = 0
        Me.BtnModifCli.IconMarginRight = 0
        Me.BtnModifCli.IconRightVisible = True
        Me.BtnModifCli.IconRightZoom = 0R
        Me.BtnModifCli.IconVisible = True
        Me.BtnModifCli.IconZoom = 90.0R
        Me.BtnModifCli.IsTab = False
        Me.BtnModifCli.Location = New System.Drawing.Point(425, 131)
        Me.BtnModifCli.Name = "BtnModifCli"
        Me.BtnModifCli.Normalcolor = System.Drawing.Color.Gray
        Me.BtnModifCli.OnHovercolor = System.Drawing.Color.DarkGray
        Me.BtnModifCli.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnModifCli.selected = False
        Me.BtnModifCli.Size = New System.Drawing.Size(136, 48)
        Me.BtnModifCli.TabIndex = 6
        Me.BtnModifCli.Text = "Modifier"
        Me.BtnModifCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnModifCli.Textcolor = System.Drawing.Color.White
        Me.BtnModifCli.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnDelCli
        '
        Me.BtnDelCli.Activecolor = System.Drawing.Color.Gray
        Me.BtnDelCli.BackColor = System.Drawing.Color.Gray
        Me.BtnDelCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDelCli.BorderRadius = 7
        Me.BtnDelCli.ButtonText = "Supprimer"
        Me.BtnDelCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelCli.DisabledColor = System.Drawing.Color.Gray
        Me.BtnDelCli.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnDelCli.Iconimage = Nothing
        Me.BtnDelCli.Iconimage_right = Nothing
        Me.BtnDelCli.Iconimage_right_Selected = Nothing
        Me.BtnDelCli.Iconimage_Selected = Nothing
        Me.BtnDelCli.IconMarginLeft = 0
        Me.BtnDelCli.IconMarginRight = 0
        Me.BtnDelCli.IconRightVisible = True
        Me.BtnDelCli.IconRightZoom = 0R
        Me.BtnDelCli.IconVisible = True
        Me.BtnDelCli.IconZoom = 90.0R
        Me.BtnDelCli.IsTab = False
        Me.BtnDelCli.Location = New System.Drawing.Point(425, 77)
        Me.BtnDelCli.Name = "BtnDelCli"
        Me.BtnDelCli.Normalcolor = System.Drawing.Color.Gray
        Me.BtnDelCli.OnHovercolor = System.Drawing.Color.DarkGray
        Me.BtnDelCli.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnDelCli.selected = False
        Me.BtnDelCli.Size = New System.Drawing.Size(136, 48)
        Me.BtnDelCli.TabIndex = 5
        Me.BtnDelCli.Text = "Supprimer"
        Me.BtnDelCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnDelCli.Textcolor = System.Drawing.Color.White
        Me.BtnDelCli.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnAddCli
        '
        Me.BtnAddCli.Activecolor = System.Drawing.Color.Gray
        Me.BtnAddCli.BackColor = System.Drawing.Color.Gray
        Me.BtnAddCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddCli.BorderRadius = 7
        Me.BtnAddCli.ButtonText = "Ajouter"
        Me.BtnAddCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddCli.DisabledColor = System.Drawing.Color.Gray
        Me.BtnAddCli.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnAddCli.Iconimage = Nothing
        Me.BtnAddCli.Iconimage_right = Nothing
        Me.BtnAddCli.Iconimage_right_Selected = Nothing
        Me.BtnAddCli.Iconimage_Selected = Nothing
        Me.BtnAddCli.IconMarginLeft = 0
        Me.BtnAddCli.IconMarginRight = 0
        Me.BtnAddCli.IconRightVisible = True
        Me.BtnAddCli.IconRightZoom = 0R
        Me.BtnAddCli.IconVisible = True
        Me.BtnAddCli.IconZoom = 90.0R
        Me.BtnAddCli.IsTab = False
        Me.BtnAddCli.Location = New System.Drawing.Point(425, 23)
        Me.BtnAddCli.Name = "BtnAddCli"
        Me.BtnAddCli.Normalcolor = System.Drawing.Color.Gray
        Me.BtnAddCli.OnHovercolor = System.Drawing.Color.DarkGray
        Me.BtnAddCli.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnAddCli.selected = False
        Me.BtnAddCli.Size = New System.Drawing.Size(136, 48)
        Me.BtnAddCli.TabIndex = 4
        Me.BtnAddCli.Text = "Ajouter"
        Me.BtnAddCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAddCli.Textcolor = System.Drawing.Color.White
        Me.BtnAddCli.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnSuivant
        '
        Me.BtnSuivant.BackColor = System.Drawing.Color.Transparent
        Me.BtnSuivant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSuivant.Image = CType(resources.GetObject("BtnSuivant.Image"), System.Drawing.Image)
        Me.BtnSuivant.ImageActive = Nothing
        Me.BtnSuivant.Location = New System.Drawing.Point(201, 79)
        Me.BtnSuivant.Name = "BtnSuivant"
        Me.BtnSuivant.Size = New System.Drawing.Size(49, 56)
        Me.BtnSuivant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSuivant.TabIndex = 3
        Me.BtnSuivant.TabStop = False
        Me.BtnSuivant.Zoom = 10
        '
        'BtnPrecedent
        '
        Me.BtnPrecedent.BackColor = System.Drawing.Color.Transparent
        Me.BtnPrecedent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrecedent.Image = CType(resources.GetObject("BtnPrecedent.Image"), System.Drawing.Image)
        Me.BtnPrecedent.ImageActive = Nothing
        Me.BtnPrecedent.Location = New System.Drawing.Point(107, 79)
        Me.BtnPrecedent.Name = "BtnPrecedent"
        Me.BtnPrecedent.Size = New System.Drawing.Size(49, 56)
        Me.BtnPrecedent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnPrecedent.TabIndex = 2
        Me.BtnPrecedent.TabStop = False
        Me.BtnPrecedent.Zoom = 10
        '
        'BtnFin
        '
        Me.BtnFin.BackColor = System.Drawing.Color.Transparent
        Me.BtnFin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFin.Image = CType(resources.GetObject("BtnFin.Image"), System.Drawing.Image)
        Me.BtnFin.ImageActive = Nothing
        Me.BtnFin.Location = New System.Drawing.Point(265, 79)
        Me.BtnFin.Name = "BtnFin"
        Me.BtnFin.Size = New System.Drawing.Size(49, 56)
        Me.BtnFin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnFin.TabIndex = 2
        Me.BtnFin.TabStop = False
        Me.BtnFin.Zoom = 10
        '
        'BtnDebut
        '
        Me.BtnDebut.BackColor = System.Drawing.Color.Transparent
        Me.BtnDebut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDebut.Image = CType(resources.GetObject("BtnDebut.Image"), System.Drawing.Image)
        Me.BtnDebut.ImageActive = Nothing
        Me.BtnDebut.Location = New System.Drawing.Point(43, 79)
        Me.BtnDebut.Name = "BtnDebut"
        Me.BtnDebut.Size = New System.Drawing.Size(49, 56)
        Me.BtnDebut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnDebut.TabIndex = 1
        Me.BtnDebut.TabStop = False
        Me.BtnDebut.Zoom = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Gestion des Client :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(505, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Liste des Client :"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmASMClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1097, 546)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TktBVilCli)
        Me.Controls.Add(Me.TktBCodePos)
        Me.Controls.Add(Me.TktBRueCli)
        Me.Controls.Add(Me.TktBPreCli)
        Me.Controls.Add(Me.TxtBNomCli)
        Me.Controls.Add(Me.TxtBIdCli)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvLstClient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmASMClient"
        Me.Text = "FrmListeClient"
        CType(Me.dgvLstClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BtnSuivant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPrecedent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDebut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLstClient As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtBNomCli As ns1.BunifuMetroTextbox
    Friend WithEvents TktBPreCli As ns1.BunifuMetroTextbox
    Friend WithEvents TktBRueCli As ns1.BunifuMetroTextbox
    Friend WithEvents TktBCodePos As ns1.BunifuMetroTextbox
    Friend WithEvents TktBVilCli As ns1.BunifuMetroTextbox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnDebut As ns1.BunifuImageButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtBRecherche As ns1.BunifuMetroTextbox
    Friend WithEvents BtnPDF As ns1.BunifuFlatButton
    Friend WithEvents BtnModifCli As ns1.BunifuFlatButton
    Friend WithEvents BtnDelCli As ns1.BunifuFlatButton
    Friend WithEvents BtnAddCli As ns1.BunifuFlatButton
    Friend WithEvents BtnSuivant As ns1.BunifuImageButton
    Friend WithEvents BtnPrecedent As ns1.BunifuImageButton
    Friend WithEvents BtnFin As ns1.BunifuImageButton
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtBIdCli As ns1.BunifuMetroTextbox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
