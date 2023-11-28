
Public Class FrmAccueil
    Dim Cl As New FrmASMClient
    Dim Pr As New FrmASMProduit
    Dim Co As New FrmAMSCommande

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Close()

    End Sub

    Private Sub BtnClient_Click(sender As Object, e As EventArgs) Handles BtnClient.Click

        BtnClient.BackColor = Color.FromArgb(228, 228, 228)
        FrmAddCommande.Close()
        FrmCommandeBis.Close()
        FrmAMSCommande.Close()
        FrmASMProduit.Close()
        FrmStat.Close()
        FrmMail.Close()
        FrmASMClient.Show()
        Label3.Text = "Client"
        If Label3.Visible = False Then
            Label3.Visible = Visible
        End If
    End Sub

    Private Sub BtnClient_Leave(sender As Object, e As EventArgs) Handles BtnClient.Leave
        BtnClient.BackColor = Color.FromArgb(246, 246, 246)
    End Sub

    Private Sub btnProduit_Click(sender As Object, e As EventArgs) Handles btnProduit.Click
        FrmAddCommande.Close()
        FrmMail.Close()
        FrmCommandeBis.Close()
        FrmAMSCommande.Close()
        FrmStat.Close()
        FrmASMProduit.Show()
        FrmASMClient.Close()
        btnProduit.BackColor = Color.FromArgb(228, 228, 228)
        Label3.Text = "Produit"
        If Label3.Visible = False Then
            Label3.Visible = Visible
        End If
    End Sub

    Private Sub btnProduit_Leave(sender As Object, e As EventArgs) Handles btnProduit.Leave
        btnProduit.BackColor = Color.FromArgb(246, 246, 246)
    End Sub

    Private Sub btnCommande_Click(sender As Object, e As EventArgs) Handles btnCommande.Click
        FrmMail.Close()
        FrmAddCommande.Close()
        FrmCommandeBis.Close()
        FrmAMSCommande.Show()
        FrmASMClient.Close()
        FrmStat.Close()
        FrmASMProduit.Close()
        btnCommande.BackColor = Color.FromArgb(228, 228, 228)
        Label3.Text = "Commande"
        If Label3.Visible = False Then
            Label3.Visible = Visible
        End If
    End Sub

    Private Sub btnCommande_Leave(sender As Object, e As EventArgs) Handles btnCommande.Leave
        btnCommande.BackColor = Color.FromArgb(246, 246, 246)
    End Sub

    Private Sub btnFournisseur_Click(sender As Object, e As EventArgs) Handles btnFournisseur.Click
        FrmAddCommande.Close()
        FrmCommandeBis.Close()
        FrmAMSCommande.Close()
        FrmASMClient.Close()
        FrmStat.Close()
        FrmASMProduit.Close()
        FrmMail.Close()
        btnFournisseur.BackColor = Color.FromArgb(228, 228, 228)
        Label3.Text = "Fournisseur"
        If Label3.Visible = False Then
            Label3.Visible = Visible
        End If
    End Sub

    Private Sub btnFournisseur_Leave(sender As Object, e As EventArgs) Handles btnFournisseur.Leave

        btnFournisseur.BackColor = Color.FromArgb(246, 246, 246)
    End Sub

    Private Sub btnCat_Click(sender As Object, e As EventArgs) Handles btnCat.Click
        FrmAddCommande.Close()
        FrmCommandeBis.Close()
        FrmAMSCommande.Close()
        FrmMail.Close()
        FrmStat.Close()
        FrmASMClient.Close()
        FrmASMProduit.Close()
        btnCat.BackColor = Color.FromArgb(228, 228, 228)
        Label3.Text = "Catégorie"
        If Label3.Visible = False Then
            Label3.Visible = Visible
        End If
    End Sub

    Private Sub btnCat_Leave(sender As Object, e As EventArgs) Handles btnCat.Leave
        btnCat.BackColor = Color.FromArgb(246, 246, 246)
    End Sub

    Private Sub btnStat_Click(sender As Object, e As EventArgs) Handles btnStat.Click
        FrmAddCommande.Close()
        FrmCommandeBis.Close()
        FrmAMSCommande.Close()
        FrmStat.Show()
        FrmMail.Close()
        FrmASMClient.Close()
        FrmASMProduit.Close()
        btnStat.BackColor = Color.FromArgb(228, 228, 228)
        Label3.Text = "Statistique"
        If Label3.Visible = False Then
            Label3.Visible = Visible
        End If
    End Sub

    Private Sub btnStat_Leave(sender As Object, e As EventArgs) Handles btnStat.Leave
        btnStat.BackColor = Color.FromArgb(246, 246, 246)
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        FrmMail.Close()
        FrmAddCommande.Close()
        FrmCommandeBis.Close()
        FrmAMSCommande.Close()
        FrmStat.Close()
        FrmASMClient.Close()
        FrmASMProduit.Close()
        btnInfo.BackColor = Color.FromArgb(228, 228, 228)
        Label3.Text = "A Propos"
        If Label3.Visible = False Then
            Label3.Visible = Visible
        End If
    End Sub

    Private Sub btnInfo_Leave(sender As Object, e As EventArgs) Handles btnInfo.Leave
        btnInfo.BackColor = Color.FromArgb(246, 246, 246)
    End Sub


End Class
