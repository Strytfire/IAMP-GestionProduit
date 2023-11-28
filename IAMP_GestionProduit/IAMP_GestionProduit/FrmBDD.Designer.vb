<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBDD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBDD))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBoxConnectName = New ns1.BunifuMaterialTextbox()
        Me.TextBoxConnectNBDD = New ns1.BunifuMaterialTextbox()
        Me.TextBoxConnectLog = New ns1.BunifuMaterialTextbox()
        Me.TextBoxConnectMDP = New ns1.BunifuMaterialTextbox()
        Me.BtnConnexion = New ns1.BunifuFlatButton()
        Me.BunifuImageButton2 = New ns1.BunifuImageButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-284, -11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1049, 660)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TxtBoxConnectName
        '
        Me.TxtBoxConnectName.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.TxtBoxConnectName.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TxtBoxConnectName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBoxConnectName.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxConnectName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBoxConnectName.HintForeColor = System.Drawing.Color.Empty
        Me.TxtBoxConnectName.HintText = ""
        Me.TxtBoxConnectName.isPassword = False
        Me.TxtBoxConnectName.LineFocusedColor = System.Drawing.Color.Blue
        Me.TxtBoxConnectName.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtBoxConnectName.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TxtBoxConnectName.LineThickness = 2
        Me.TxtBoxConnectName.Location = New System.Drawing.Point(63, 245)
        Me.TxtBoxConnectName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxConnectName.Name = "TxtBoxConnectName"
        Me.TxtBoxConnectName.Size = New System.Drawing.Size(314, 27)
        Me.TxtBoxConnectName.TabIndex = 3
        Me.TxtBoxConnectName.Text = "Nom Du Serveur"
        Me.TxtBoxConnectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TextBoxConnectNBDD
        '
        Me.TextBoxConnectNBDD.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TextBoxConnectNBDD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxConnectNBDD.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxConnectNBDD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxConnectNBDD.HintForeColor = System.Drawing.Color.Empty
        Me.TextBoxConnectNBDD.HintText = ""
        Me.TextBoxConnectNBDD.isPassword = False
        Me.TextBoxConnectNBDD.LineFocusedColor = System.Drawing.Color.Blue
        Me.TextBoxConnectNBDD.LineIdleColor = System.Drawing.Color.Gray
        Me.TextBoxConnectNBDD.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TextBoxConnectNBDD.LineThickness = 2
        Me.TextBoxConnectNBDD.Location = New System.Drawing.Point(63, 289)
        Me.TextBoxConnectNBDD.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxConnectNBDD.Name = "TextBoxConnectNBDD"
        Me.TextBoxConnectNBDD.Size = New System.Drawing.Size(314, 27)
        Me.TextBoxConnectNBDD.TabIndex = 4
        Me.TextBoxConnectNBDD.Text = "Nom de la base de donnée"
        Me.TextBoxConnectNBDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TextBoxConnectLog
        '
        Me.TextBoxConnectLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TextBoxConnectLog.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxConnectLog.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxConnectLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxConnectLog.HintForeColor = System.Drawing.Color.Empty
        Me.TextBoxConnectLog.HintText = ""
        Me.TextBoxConnectLog.isPassword = False
        Me.TextBoxConnectLog.LineFocusedColor = System.Drawing.Color.Blue
        Me.TextBoxConnectLog.LineIdleColor = System.Drawing.Color.Gray
        Me.TextBoxConnectLog.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TextBoxConnectLog.LineThickness = 3
        Me.TextBoxConnectLog.Location = New System.Drawing.Point(63, 330)
        Me.TextBoxConnectLog.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxConnectLog.Name = "TextBoxConnectLog"
        Me.TextBoxConnectLog.Size = New System.Drawing.Size(314, 27)
        Me.TextBoxConnectLog.TabIndex = 5
        Me.TextBoxConnectLog.Text = "Login"
        Me.TextBoxConnectLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TextBoxConnectMDP
        '
        Me.TextBoxConnectMDP.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TextBoxConnectMDP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxConnectMDP.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxConnectMDP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxConnectMDP.HintForeColor = System.Drawing.Color.Empty
        Me.TextBoxConnectMDP.HintText = ""
        Me.TextBoxConnectMDP.isPassword = False
        Me.TextBoxConnectMDP.LineFocusedColor = System.Drawing.Color.Blue
        Me.TextBoxConnectMDP.LineIdleColor = System.Drawing.Color.Gray
        Me.TextBoxConnectMDP.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TextBoxConnectMDP.LineThickness = 3
        Me.TextBoxConnectMDP.Location = New System.Drawing.Point(63, 368)
        Me.TextBoxConnectMDP.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxConnectMDP.Name = "TextBoxConnectMDP"
        Me.TextBoxConnectMDP.Size = New System.Drawing.Size(314, 27)
        Me.TextBoxConnectMDP.TabIndex = 6
        Me.TextBoxConnectMDP.Text = "Mot de passe"
        Me.TextBoxConnectMDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnConnexion
        '
        Me.BtnConnexion.Activecolor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnConnexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnConnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnConnexion.BorderRadius = 7
        Me.BtnConnexion.ButtonText = "Connexion"
        Me.BtnConnexion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConnexion.DisabledColor = System.Drawing.Color.Gray
        Me.BtnConnexion.Font = New System.Drawing.Font("Omnes Regular", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConnexion.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnConnexion.Iconimage = Nothing
        Me.BtnConnexion.Iconimage_right = Nothing
        Me.BtnConnexion.Iconimage_right_Selected = Nothing
        Me.BtnConnexion.Iconimage_Selected = Nothing
        Me.BtnConnexion.IconMarginLeft = 0
        Me.BtnConnexion.IconMarginRight = 0
        Me.BtnConnexion.IconRightVisible = True
        Me.BtnConnexion.IconRightZoom = 0R
        Me.BtnConnexion.IconVisible = True
        Me.BtnConnexion.IconZoom = 90.0R
        Me.BtnConnexion.IsTab = False
        Me.BtnConnexion.Location = New System.Drawing.Point(147, 430)
        Me.BtnConnexion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnConnexion.Name = "BtnConnexion"
        Me.BtnConnexion.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnConnexion.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnConnexion.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnConnexion.selected = False
        Me.BtnConnexion.Size = New System.Drawing.Size(212, 45)
        Me.BtnConnexion.TabIndex = 7
        Me.BtnConnexion.Text = "Connexion"
        Me.BtnConnexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnConnexion.Textcolor = System.Drawing.Color.White
        Me.BtnConnexion.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(389, 8)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(24, 24)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton2.TabIndex = 8
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'FrmBDD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 619)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.BtnConnexion)
        Me.Controls.Add(Me.TextBoxConnectMDP)
        Me.Controls.Add(Me.TextBoxConnectLog)
        Me.Controls.Add(Me.TextBoxConnectNBDD)
        Me.Controls.Add(Me.TxtBoxConnectName)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBDD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBDD"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBoxConnectName As ns1.BunifuMaterialTextbox
    Friend WithEvents TextBoxConnectMDP As ns1.BunifuMaterialTextbox
    Friend WithEvents TextBoxConnectLog As ns1.BunifuMaterialTextbox
    Friend WithEvents TextBoxConnectNBDD As ns1.BunifuMaterialTextbox
    Friend WithEvents BtnConnexion As ns1.BunifuFlatButton
    Friend WithEvents BunifuImageButton2 As ns1.BunifuImageButton
End Class
