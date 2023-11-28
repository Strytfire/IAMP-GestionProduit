<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCNP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCNP))
        Me.BtnRetour = New ns1.BunifuImageButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnOk = New ns1.BunifuFlatButton()
        Me.BunifuMetroTextbox1 = New ns1.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtNum = New ns1.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.BtnRetour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnRetour
        '
        Me.BtnRetour.BackColor = System.Drawing.Color.Transparent
        Me.BtnRetour.Image = CType(resources.GetObject("BtnRetour.Image"), System.Drawing.Image)
        Me.BtnRetour.ImageActive = Nothing
        Me.BtnRetour.Location = New System.Drawing.Point(12, 12)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(30, 31)
        Me.BtnRetour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnRetour.TabIndex = 46
        Me.BtnRetour.TabStop = False
        Me.BtnRetour.Zoom = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(632, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(412, 471)
        Me.DataGridView1.TabIndex = 47
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
        Me.Panel2.Location = New System.Drawing.Point(21, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(588, 157)
        Me.Panel2.TabIndex = 49
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
        'FrmCNP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1081, 507)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnRetour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCNP"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "FrmCNP"
        CType(Me.BtnRetour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnRetour As ns1.BunifuImageButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnOk As ns1.BunifuFlatButton
    Friend WithEvents BunifuMetroTextbox1 As ns1.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtNum As ns1.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
End Class
