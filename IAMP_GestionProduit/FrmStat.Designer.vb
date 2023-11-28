<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStat
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
        Me.DgvStat = New System.Windows.Forms.DataGridView()
        Me.BtnNP = New ns1.BunifuFlatButton()
        CType(Me.DgvStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvStat
        '
        Me.DgvStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvStat.Location = New System.Drawing.Point(25, 12)
        Me.DgvStat.Name = "DgvStat"
        Me.DgvStat.Size = New System.Drawing.Size(1044, 399)
        Me.DgvStat.TabIndex = 0
        '
        'BtnNP
        '
        Me.BtnNP.Activecolor = System.Drawing.Color.Gray
        Me.BtnNP.BackColor = System.Drawing.Color.Gray
        Me.BtnNP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNP.BorderRadius = 7
        Me.BtnNP.ButtonText = "Consulté commande non payée"
        Me.BtnNP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNP.DisabledColor = System.Drawing.Color.Gray
        Me.BtnNP.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnNP.Iconimage = Nothing
        Me.BtnNP.Iconimage_right = Nothing
        Me.BtnNP.Iconimage_right_Selected = Nothing
        Me.BtnNP.Iconimage_Selected = Nothing
        Me.BtnNP.IconMarginLeft = 0
        Me.BtnNP.IconMarginRight = 0
        Me.BtnNP.IconRightVisible = True
        Me.BtnNP.IconRightZoom = 0R
        Me.BtnNP.IconVisible = True
        Me.BtnNP.IconZoom = 90.0R
        Me.BtnNP.IsTab = False
        Me.BtnNP.Location = New System.Drawing.Point(25, 428)
        Me.BtnNP.Name = "BtnNP"
        Me.BtnNP.Normalcolor = System.Drawing.Color.Gray
        Me.BtnNP.OnHovercolor = System.Drawing.Color.DarkGray
        Me.BtnNP.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnNP.selected = False
        Me.BtnNP.Size = New System.Drawing.Size(199, 67)
        Me.BtnNP.TabIndex = 6
        Me.BtnNP.Text = "Consulté commande non payée"
        Me.BtnNP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnNP.Textcolor = System.Drawing.Color.White
        Me.BtnNP.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FrmStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1081, 507)
        Me.Controls.Add(Me.BtnNP)
        Me.Controls.Add(Me.DgvStat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmStat"
        Me.Text = "FrmStat"
        CType(Me.DgvStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvStat As DataGridView
    Friend WithEvents BtnNP As ns1.BunifuFlatButton
End Class
