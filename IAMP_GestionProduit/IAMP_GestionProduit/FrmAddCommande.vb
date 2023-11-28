Imports IAMP_GestionProduit.GestionClient
Imports IAMP_GestionProduit.GestionCommande
Imports IAMP_GestionProduit.GestionCatégorie
Imports IAMP_GestionProduit.GestionProduits

Public Class FrmAddCommande
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        FrmAMSCommande.dgvCom.DataSource = DGCommande()
        FrmAMSCommande.Show()
        Me.Close()
    End Sub

    Private Sub FrmAddCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmAMSCommande.Hide()
        Me.TopLevel = False
        Me.Parent = FrmAccueil.Panel3
        Me.Top = 10
        Me.Left = 0

        txtNum.Text = GestionBDD.Generer_Cle_Primaire("idCommande", "Commande")
        BunifuMetroTextbox1.Text = DateTime.Now.ToString().Substring(0, 10)
        DGVProd.DataSource = GetLesProduitByCommande(txtNum.Text)
        GestionInterface.AlimenterComboBox(ComboBox1, GetLesClientsCB, “Patronyme”, “idClient”)

        GestionInterface.AlimenterComboBox(CbCat, GetLesCategorie(), “LibelleCategorie”, “idCategorie”)
        GestionInterface.AlimenterComboBox(CBProd, GetNomProd(CbCat.SelectedValue.ToString), "libelleProduit", "idProduit")
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        Try
            CbCat.Enabled = True
            CBProd.Enabled = True
            TxtboxQte.Enabled = True
            ComboBox1.Enabled = False
            txtNum.Enabled = False
            BunifuMetroTextbox1.Enabled = False
            BtnOk.Enabled = False
            Dim IdC As Integer = txtNum.Text
            Dim DC As Date = BunifuMetroTextbox1.Text
            Dim IC As Integer = ComboBox1.SelectedValue
            AjouterCommande(IdC, DC, IC)
        Catch
            MessageBox.Show("Commande déja existante")
        End Try

    End Sub

    Private Sub FrmAddCommande_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Idcom = Convert.ToInt32(txtNum.Text)
        If GestionCommande.GetLesProduitByCommande(Idcom).rows.count = 0 Then
            GestionCommande.SuprimerCommande(Idcom)

        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            Dim IdC As Integer = txtNum.Text
            Dim IdP As Integer = CBProd.SelectedValue
            Dim C As Integer = TxtboxQte.Text
            AjouterLigneCommande(IdC, IdP, C)
            DGVProd.DataSource = GetLesProduitByCommande(txtNum.Text)
            txtmontantHT.Text = GetMontantHT(txtNum.Text)
        Catch
            MessageBox.Show("Vous devais deja posèder se produit veuillez le suprimé et le reajouter pour modifier la quantité")
        End Try
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Try
            Dim idCo, IdPro As String
            idCo = txtNum.Text
            IdPro = DGVProd.CurrentRow.Cells(0).Value
            Supprimerlignecom(idCo, IdPro)
            DGVProd.DataSource = GetLesProduitByCommande(txtNum.Text)

            txtmontantHT.Text = GetMontantHT(txtNum.Text)
        Catch
            MessageBox.Show("Commande Vide ou non Attribué")
            txtmontantHT.Text = "0"
        End Try
    End Sub

    Private Sub CbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCat.SelectedIndexChanged
        GestionInterface.AlimenterComboBox(CBProd, GetNomProd(CbCat.SelectedValue.ToString), "libelleProduit", "idProduit")
    End Sub
End Class
