Imports MarchandPPE

Public Class FrmStat
    Private Sub FrmStat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopLevel = False
        Me.Parent = FrmAccueil.Panel3
        Me.Top = 0
        Me.Left = 0
        DgvStat.DataSource = GestionCommande.DGCommandeStat()
    End Sub

    Private Sub BtnNP_Click(sender As Object, e As EventArgs) Handles BtnNP.Click
        Me.Hide()
        FrmCNP.Show()
    End Sub
End Class