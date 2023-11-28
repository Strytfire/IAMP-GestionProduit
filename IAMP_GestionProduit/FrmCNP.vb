Public Class FrmCNP
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        FrmStat.Show()
        Me.Close()


    End Sub

    Private Sub FrmCNP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmStat.Hide()
        Me.TopLevel = False
        Me.Parent = FrmAccueil.Panel3
        Me.Top = 10
        Me.Left = 0
    End Sub
End Class