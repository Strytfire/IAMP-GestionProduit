
Imports System.Data.SqlTypes
Imports MarchandPPE


Public Class FrmASMProduit
    Dim position
    Private Sub FrmASMProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopLevel = False
        Me.Parent = FrmAccueil.Panel3
        Me.Top = 0
        Me.Left = 0
        Rafraichir()
        dgvLesProduits.DataSource = GestionProduits.GetLesProduitsDG()
        GestionInterface.AlimenterComboBox(CmbFour, GestionFournisseur.GetLesFournisseurs, “NomFournisseur”, “idFournisseur”)
        GestionInterface.AlimenterComboBox(CbCat, GestionCatégorie.GetLesCategorie(), "LibelleCategorie", "idCategorie")
        CmbFour.Enabled = False
        CbCat.Enabled = False
    End Sub

    Public Sub Rafraichir()
        Dim MesProduits As DataTable = GestionProduits.GetLesProduits()
        TxtBCP.Text = MesProduits.Rows(position).Item(0)
        TxtBLibP.Text = MesProduits.Rows(position).Item(1)
        TxtBPrixP.Text = MesProduits.Rows(position).Item(4)
        TxtBQteP.Text = MesProduits.Rows(position).Item(3)
        CmbFour.SelectedValue = MesProduits.Rows(position).Item(6)
        CbCat.SelectedValue = MesProduits.Rows(position).Item(7)



    End Sub

    Private Sub BtnFinProd_Click(sender As Object, e As EventArgs) Handles BtnFinProd.Click
        position = GestionProduits.GetNBProduits() - 1
        Rafraichir()
    End Sub

    Private Sub BtnSuivProd_Click(sender As Object, e As EventArgs) Handles BtnSuivProd.Click
        If (position < GestionProduits.GetNBProduits() - 1) Then
            position = position + 1
        End If
        Rafraichir()
    End Sub

    Private Sub BtnPreProd_Click(sender As Object, e As EventArgs) Handles BtnPreProd.Click
        If (position > 0) Then
            position = position - 1
        End If
        Rafraichir()
    End Sub

    Private Sub BtnDebutProd_Click(sender As Object, e As EventArgs) Handles BtnDebutProd.Click
        position = 0
        Rafraichir()
    End Sub

    Private Sub BtnAddPro_Click(sender As Object, e As EventArgs) Handles BtnAddPro.Click
        If BtnAddPro.Text = "Ajouter" Then
            BtnAddPro.Text = "Valider"
            TxtBCP.Text = GestionBDD.Generer_Cle_Primaire("IdProduit", "Produit")
            TxtBLibP.Text = ""
            TxtBPrixP.Text = ""
            TxtBQteP.Text = ""
            CbCat.Enabled = True
            CmbFour.Enabled = True
        Else
            Dim n, r, cp, v As String
            Dim p As Decimal
            Dim answer As Integer
            answer = MsgBox("Voulez vous vraiment ajouter le Produit N° " & TxtBCP.Text & " Ajouter", MessageBoxButtons.YesNo)
            If answer = vbYes Then
                '(ValidNomPrenom(n) And ValidNomPrenom(p))
                MsgBox("Produit n° " & TxtBCP.Text & " Ajouter")
                Dim id As Integer
                id = TxtBCP.Text
                n = TxtBLibP.Text
                p = TxtBPrixP.Text
                r = TxtBQteP.Text
                cp = CbCat.SelectedValue
                v = CmbFour.SelectedValue
                GestionProduits.AjouterProduit(id, n, p, r, cp, v)
                BtnAddPro.Text = "Ajouter"
                dgvLesProduits.DataSource = GestionProduits.GetLesProduitsDG()
                CbCat.Enabled = False
                CmbFour.Enabled = False
                Rafraichir()

            End If
        End If
    End Sub

    Private Sub BtnSuppProd_Click(sender As Object, e As EventArgs) Handles BtnSuppProd.Click
        Dim id As Integer
        Dim answer As Integer
        id = TxtBCP.Text
        answer = MsgBox("Voulez vous vraiment suprimmer le Produit N° " & TxtBCP.Text & " Supprimer", MessageBoxButtons.YesNo)
        If answer = vbYes Then
            MsgBox("Client n° " & TxtBCP.Text & " Supprimer")
            GestionProduits.SupprimerProduit(id)
            dgvLesProduits.DataSource = GestionProduits.GetLesProduitsDG()
            position = 0
            Rafraichir()
        Else
        End If
    End Sub

    Private Sub BtnModifProd_Click(sender As Object, e As EventArgs) Handles BtnModifProd.Click
        If BtnAddPro.Text = "Modifier" Then
            BtnAddPro.Text = "Validé"
            CbCat.Enabled = True
            CmbFour.Enabled = True
        Else
            Dim answer = MsgBox("Voulez vous vraiment modifier le client N° " & TxtBCP.Text & " Modification", MessageBoxButtons.YesNo)
            If answer = vbYes Then
                Dim id As Integer
                Dim p As String
                Dim n, r, cp, v As String
                id = TxtBCP.Text
                n = TxtBLibP.Text
                p = TxtBPrixP.Text
                r = TxtBQteP.Text
                cp = CbCat.SelectedValue
                v = CmbFour.SelectedValue
                GestionProduits.ModifierProduit(id, n, p, r, cp, v)
                dgvLesProduits.DataSource = GestionProduits.GetLesProduitsDG()
                Rafraichir()
            End If
        End If
    End Sub

    Private Sub TxtBRechercheProd_OnValueChanged(sender As Object, e As EventArgs) Handles TxtBRechercheProd.OnValueChanged
        Dim re As String
        Try
            re = TxtBRechercheProd.Text
        Catch
            Exit Sub
        End Try
        dgvLesProduits.DataSource = GestionProduits.RechercherProduit(re)
    End Sub

    Private Sub BtnPDFProduit_Click(sender As Object, e As EventArgs) Handles BtnPDFProduit.Click
        GestionPDF.genererpdfdepuisdatatable(" Liste des Produits", GestionProduits.GetLesProduitsDG(), GestionProduits.GetNBProduits())
    End Sub

End Class