Imports MarchandPPE

Public Class FrmCommandeBis
    Dim position
    Public idcom As Integer
    Public Date_ As Date
    Private Sub FrmCommandeBis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopLevel = False
        Me.Parent = FrmAccueil.Panel3
        Me.Top = 0
        Me.Left = 0
        txtNum.Text = idcom
        BunifuMetroTextbox1.Text = Date_
        txtmontantHT.Text = GestionCommande.GetMontantHT(idcom)
        DGVProd.DataSource = GestionCommande.GetLesProduitByCommande(txtNum.Text)
        GestionInterface.AlimenterComboBox(ComboBox1, GestionClient.GetClientByID(txtNum.Text), “Patronyme”, “idClient”)
        GestionInterface.AlimenterComboBox(CbCat, GestionCatégorie.GetLesCategorie(), “LibelleCategorie”, “idCategorie”)
        GestionInterface.AlimenterComboBox(CBProd, GestionProduits.GetNomProd(CbCat.SelectedValue.ToString), "libelleProduit", "idProduit")





    End Sub



    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        FrmAMSCommande.dgvCom.DataSource = GestionCommande.DGCommande()
        FrmAMSCommande.Show()
        Me.Close()


    End Sub


    Private Sub CbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCat.SelectedIndexChanged
        GestionInterface.AlimenterComboBox(CBProd, GestionProduits.GetNomProd(CbCat.SelectedValue.ToString), "libelleProduit", "idProduit")
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Try
            Dim IdC As Integer = txtNum.Text
            Dim IdP As Integer = CBProd.SelectedValue
            Dim C As Integer = TxtboxQte.Text
            GestionCommande.AjouterLigneCommande(IdC, IdP, C)
            DGVProd.DataSource = GestionCommande.GetLesProduitByCommande(txtNum.Text)
            txtmontantHT.Text = GestionCommande.GetMontantHT(txtNum.Text)

        Catch
            MessageBox.Show("Vous devais deja posèder se produit veuillez le suprimé et le reajouter pour modifier la quantité")
        End Try
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Try
            Dim idCo, IdPro As String
            idCo = txtNum.Text
            IdPro = DGVProd.CurrentRow.Cells(0).Value
            GestionCommande.Supprimerlignecom(idCo, IdPro)
            DGVProd.DataSource = GestionCommande.GetLesProduitByCommande(txtNum.Text)

            txtmontantHT.Text = GestionCommande.GetMontantHT(txtNum.Text)
        Catch
            MessageBox.Show("Commande Vide ou non attribuer")
            txtmontantHT.Text = "0"
        End Try
    End Sub

    Private Sub FrmCommandeBis_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Me.Close()
    End Sub

    Private Sub FrmCommandeBis_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Idcom = Convert.ToInt32(txtNum.Text)
        If GestionCommande.GetLesProduitByCommande(Idcom).rows.count = 0 Then
            GestionCommande.SuprimerCommande(Idcom)

        End If
    End Sub

    Private Sub BtnPDFProduit_Click(sender As Object, e As EventArgs) Handles BtnPDFProduit.Click
        Dim idcom As String
        idcom = txtNum.Text
        GestionPDF.genererpdfdepuisdatatableCo(" Liste des Produits dans la commande de " & ComboBox1.Text & "", GestionCommande.GetLesProduitByCommande(idcom))
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        FrmMail.Show()
        Me.Hide()
    End Sub
End Class