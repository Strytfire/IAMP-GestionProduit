<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMail))
        Me.btn_Go = New System.Windows.Forms.Button()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.txtDe = New ns1.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtA = New ns1.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSuj = New ns1.BunifuMetroTextbox()
        Me.txtMess = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmdp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Go
        '
        Me.btn_Go.Location = New System.Drawing.Point(271, 439)
        Me.btn_Go.Name = "btn_Go"
        Me.btn_Go.Size = New System.Drawing.Size(142, 46)
        Me.btn_Go.TabIndex = 2
        Me.btn_Go.Text = "Envoyer "
        Me.btn_Go.UseVisualStyleBackColor = True
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(452, 12)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(617, 483)
        Me.AxAcroPDF1.TabIndex = 6
        '
        'txtDe
        '
        Me.txtDe.BackColor = System.Drawing.SystemColors.Control
        Me.txtDe.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDe.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.txtDe.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.txtDe.BorderThickness = 2
        Me.txtDe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDe.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDe.isPassword = False
        Me.txtDe.Location = New System.Drawing.Point(100, 23)
        Me.txtDe.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDe.Name = "txtDe"
        Me.txtDe.Size = New System.Drawing.Size(313, 30)
        Me.txtDe.TabIndex = 34
        Me.txtDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "De :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "A :"
        '
        'txtA
        '
        Me.txtA.BackColor = System.Drawing.SystemColors.Control
        Me.txtA.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.txtA.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.txtA.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.txtA.BorderThickness = 2
        Me.txtA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtA.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtA.isPassword = False
        Me.txtA.Location = New System.Drawing.Point(100, 61)
        Me.txtA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(313, 30)
        Me.txtA.TabIndex = 36
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Sujet :"
        '
        'txtSuj
        '
        Me.txtSuj.BackColor = System.Drawing.SystemColors.Control
        Me.txtSuj.BorderColorFocused = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSuj.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark
        Me.txtSuj.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow
        Me.txtSuj.BorderThickness = 2
        Me.txtSuj.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSuj.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSuj.isPassword = False
        Me.txtSuj.Location = New System.Drawing.Point(100, 99)
        Me.txtSuj.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSuj.Name = "txtSuj"
        Me.txtSuj.Size = New System.Drawing.Size(313, 30)
        Me.txtSuj.TabIndex = 38
        Me.txtSuj.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtMess
        '
        Me.txtMess.Location = New System.Drawing.Point(100, 136)
        Me.txtMess.Name = "txtMess"
        Me.txtMess.Size = New System.Drawing.Size(313, 281)
        Me.txtMess.TabIndex = 40
        Me.txtMess.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Message :"
        '
        'txtmdp
        '
        Me.txtmdp.Location = New System.Drawing.Point(118, 453)
        Me.txtmdp.Name = "txtmdp"
        Me.txtmdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmdp.Size = New System.Drawing.Size(135, 20)
        Me.txtmdp.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Omnes Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 456)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Mot de passe :"
        '
        'FrmMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1081, 507)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtmdp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMess)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSuj)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDe)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.btn_Go)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMail"
        Me.Text = "FrmMail"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Go As Button
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents txtDe As ns1.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtA As ns1.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSuj As ns1.BunifuMetroTextbox
    Friend WithEvents txtMess As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmdp As TextBox
    Friend WithEvents Label5 As Label
End Class
