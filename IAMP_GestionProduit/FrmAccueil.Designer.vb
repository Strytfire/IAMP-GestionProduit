<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAccueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAccueil))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnCat = New System.Windows.Forms.Button()
        Me.btnStat = New System.Windows.Forms.Button()
        Me.btnCommande = New System.Windows.Forms.Button()
        Me.BtnClient = New System.Windows.Forms.Button()
        Me.btnFournisseur = New System.Windows.Forms.Button()
        Me.btnProduit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuImageButton1 = New ns1.BunifuImageButton()
        Me.BunifuImageButton2 = New ns1.BunifuImageButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 25
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnInfo)
        Me.Panel1.Controls.Add(Me.btnCat)
        Me.Panel1.Controls.Add(Me.btnStat)
        Me.Panel1.Controls.Add(Me.btnCommande)
        Me.Panel1.Controls.Add(Me.BtnClient)
        Me.Panel1.Controls.Add(Me.btnFournisseur)
        Me.Panel1.Controls.Add(Me.btnProduit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 647)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 627)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "V 1.2"
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnInfo.FlatAppearance.BorderSize = 0
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.Image = CType(resources.GetObject("btnInfo.Image"), System.Drawing.Image)
        Me.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInfo.Location = New System.Drawing.Point(0, 438)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(200, 53)
        Me.btnInfo.TabIndex = 18
        Me.btnInfo.Text = "          A Propos"
        Me.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnCat
        '
        Me.btnCat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCat.FlatAppearance.BorderSize = 0
        Me.btnCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCat.Image = CType(resources.GetObject("btnCat.Image"), System.Drawing.Image)
        Me.btnCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCat.Location = New System.Drawing.Point(0, 332)
        Me.btnCat.Name = "btnCat"
        Me.btnCat.Size = New System.Drawing.Size(200, 53)
        Me.btnCat.TabIndex = 17
        Me.btnCat.Text = "          Catégorie"
        Me.btnCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCat.UseVisualStyleBackColor = False
        '
        'btnStat
        '
        Me.btnStat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnStat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStat.FlatAppearance.BorderSize = 0
        Me.btnStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStat.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStat.Image = CType(resources.GetObject("btnStat.Image"), System.Drawing.Image)
        Me.btnStat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStat.Location = New System.Drawing.Point(0, 385)
        Me.btnStat.Name = "btnStat"
        Me.btnStat.Size = New System.Drawing.Size(200, 53)
        Me.btnStat.TabIndex = 16
        Me.btnStat.Text = "          Statistique"
        Me.btnStat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStat.UseVisualStyleBackColor = False
        '
        'btnCommande
        '
        Me.btnCommande.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCommande.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCommande.FlatAppearance.BorderSize = 0
        Me.btnCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommande.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommande.Image = CType(resources.GetObject("btnCommande.Image"), System.Drawing.Image)
        Me.btnCommande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommande.Location = New System.Drawing.Point(0, 226)
        Me.btnCommande.Name = "btnCommande"
        Me.btnCommande.Size = New System.Drawing.Size(200, 53)
        Me.btnCommande.TabIndex = 15
        Me.btnCommande.Text = "          Commande"
        Me.btnCommande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCommande.UseVisualStyleBackColor = False
        '
        'BtnClient
        '
        Me.BtnClient.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnClient.FlatAppearance.BorderSize = 0
        Me.BtnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClient.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClient.Image = CType(resources.GetObject("BtnClient.Image"), System.Drawing.Image)
        Me.BtnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClient.Location = New System.Drawing.Point(0, 120)
        Me.BtnClient.Name = "BtnClient"
        Me.BtnClient.Size = New System.Drawing.Size(200, 53)
        Me.BtnClient.TabIndex = 4
        Me.BtnClient.Text = "          Client"
        Me.BtnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClient.UseVisualStyleBackColor = False
        '
        'btnFournisseur
        '
        Me.btnFournisseur.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnFournisseur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFournisseur.FlatAppearance.BorderSize = 0
        Me.btnFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFournisseur.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFournisseur.Image = CType(resources.GetObject("btnFournisseur.Image"), System.Drawing.Image)
        Me.btnFournisseur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFournisseur.Location = New System.Drawing.Point(0, 279)
        Me.btnFournisseur.Name = "btnFournisseur"
        Me.btnFournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFournisseur.Size = New System.Drawing.Size(200, 53)
        Me.btnFournisseur.TabIndex = 14
        Me.btnFournisseur.Text = "          Fournisseur"
        Me.btnFournisseur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFournisseur.UseVisualStyleBackColor = False
        '
        'btnProduit
        '
        Me.btnProduit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnProduit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnProduit.FlatAppearance.BorderSize = 0
        Me.btnProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduit.Font = New System.Drawing.Font("Omnes Regular", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduit.Image = CType(resources.GetObject("btnProduit.Image"), System.Drawing.Image)
        Me.btnProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduit.Location = New System.Drawing.Point(0, 173)
        Me.btnProduit.Name = "btnProduit"
        Me.btnProduit.Size = New System.Drawing.Size(200, 53)
        Me.btnProduit.TabIndex = 13
        Me.btnProduit.Text = "          Produit"
        Me.btnProduit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProduit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 650)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "V1.0"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1201, 16)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(34, 35)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton1.TabIndex = 2
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1243, 16)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(34, 35)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton2.TabIndex = 3
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(992, 101)
        Me.Panel2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Omnes Regular", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 34)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Accueil"
        Me.Label3.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(200, 101)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1097, 546)
        Me.Panel3.TabIndex = 5
        '
        'FrmAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1297, 645)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAccueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "wb"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuImageButton2 As ns1.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As ns1.BunifuImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnClient As Button
    Friend WithEvents btnCat As Button
    Friend WithEvents btnStat As Button
    Friend WithEvents btnCommande As Button
    Friend WithEvents btnFournisseur As Button
    Friend WithEvents btnProduit As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
