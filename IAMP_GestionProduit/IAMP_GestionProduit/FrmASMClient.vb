Imports IAMP_GestionProduit.GestionClient
Imports IAMP_GestionProduit.GestionBDD
Public Class FrmASMClient
    Dim position
    Private Sub FrmListeClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopLevel = False
        Me.Parent = FrmAccueil.Panel3
        Me.Top = 0
        Me.Left = 0
        dgvLstClient.DataSource = GestionClient.GetLesClients()
        Rafraichir()
    End Sub

    Public Sub Rafraichir()
        Dim MesClients As DataTable = GestionClient.GetLesClients()
        TxtBIdCli.Text = MesClients.Rows(position).Item(0)
        TxtBNomCli.Text = MesClients.Rows(position).Item(1)
        TktBPreCli.Text = MesClients.Rows(position).Item(2)
        TktBRueCli.Text = MesClients.Rows(position).Item(3)
        TktBCodePos.Text = MesClients.Rows(position).Item(4)
        TktBVilCli.Text = MesClients.Rows(position).Item(5)
    End Sub

    Private Sub BtnFin_Click(sender As Object, e As EventArgs) Handles BtnFin.Click
        position = GetNBClients() - 1
        Rafraichir()
    End Sub

    Private Sub BtnSuivant_Click(sender As Object, e As EventArgs) Handles BtnSuivant.Click
        If (position < GestionClient.GetNBClients() - 1) Then
            position = position + 1
        End If
        Rafraichir()
    End Sub

    Private Sub BtnPrecedent_Click(sender As Object, e As EventArgs) Handles BtnPrecedent.Click
        If (position > 0) Then
            position = position - 1
        End If
        Rafraichir()
    End Sub

    Private Sub BtnDebut_Click(sender As Object, e As EventArgs) Handles BtnDebut.Click
        position = 0
        Rafraichir()
    End Sub

    Private Sub TxtBRecherche_OnValueChanged(sender As Object, e As EventArgs) Handles TxtBRecherche.OnValueChanged
        Dim re As String
        Try
            re = TxtBRecherche.Text
        Catch
            Exit Sub
        End Try
        dgvLstClient.DataSource = GestionClient.RechercherClient(re)
    End Sub

    Private Sub BtnAddCli_Click(sender As Object, e As EventArgs) Handles BtnAddCli.Click
        If BtnAddCli.Text = "Ajouter" Then
            BtnAddCli.Text = "Valider"
            TxtBIdCli.Text = Generer_Cle_Primaire("IdClient", "Client")
            TktBVilCli.Text = ""
            TktBRueCli.Text = ""
            TktBPreCli.Text = ""
            TxtBNomCli.Text = ""
            TktBCodePos.Text = ""
        Else
            Dim n, p, r, cp, v As String
            Dim answer As Integer
            answer = MsgBox("Voulez vous vraiment ajouter le client N° " & TktBVilCli.Text & " Ajouter", MessageBoxButtons.YesNo)
            If answer = vbYes Then
                'And (ValidNomPrenom(n) And ValidNomPrenom(p)) Then
                MsgBox("Client n° " & TktBVilCli.Text & " Ajouter")
                Dim id As Integer
                id = TktBVilCli.Text
                n = TktBCodePos.Text
                p = TktBRueCli.Text
                r = TktBPreCli.Text
                cp = TxtBNomCli.Text
                v = TxtBIdCli.Text
                AjouterClient(id, n, p, r, cp, v)
                BtnAddCli.Text = "Ajouter"
                dgvLstClient.DataSource = GestionClient.GetLesClients()
                Rafraichir()
            End If
        End If
    End Sub

    Private Sub BtnDelCli_Click(sender As Object, e As EventArgs) Handles BtnDelCli.Click
        Dim id As Integer
        Dim answer As Integer
        id = TktBVilCli.Text
        answer = MsgBox("Voulez vous vraiment suprimmer le client N° " & TktBVilCli.Text & " Supprimer", MessageBoxButtons.YesNo)
        If answer = vbYes Then
            MsgBox("Client n° " & TktBVilCli.Text & " Supprimer")
            SupprimerClient(id)
            dgvLstClient.DataSource = GestionClient.GetLesClients()
            position = 0
            Rafraichir()
        Else
        End If
    End Sub

    Private Sub BtnModifCli_Click(sender As Object, e As EventArgs) Handles BtnModifCli.Click
        Dim answer = MsgBox("Voulez vous vraiment modifier le client N° " & TktBVilCli.Text & " Modification", MessageBoxButtons.YesNo)
        If answer = vbYes Then
            Dim id As Integer
            Dim n, p, r, cp, v As String
            id = TktBVilCli.Text
            n = TktBCodePos.Text
            p = TktBRueCli.Text
            r = TktBPreCli.Text
            cp = TxtBNomCli.Text
            v = TxtBIdCli.Text
            ModifierClient(id, n, p, r, cp, v)
            dgvLstClient.DataSource = GestionClient.GetLesClients()
            Rafraichir()
        End If
    End Sub

    Private Sub BtnPDF_Click(sender As Object, e As EventArgs) Handles BtnPDF.Click
        GestionPDF.genererpdfdepuisdatatable(" Liste des Client ", GetLesClients(), GetNBClients())
    End Sub

    Private Sub TxtBNomCli_Leave(sender As Object, e As EventArgs) Handles TxtBNomCli.Leave
        If GestionInterface.ValidNom(TxtBNomCli.Text) = False Then
            Me.ErrorProvider1.SetError(Me.TxtBNomCli, "Vide ou Contient des nombre")
            ErrorProvider1.Tag = 1
        Else
            Me.ErrorProvider1.SetError(Me.TxtBNomCli, "")
            ErrorProvider1.Tag = 0

        End If
    End Sub

    Private Sub TktBPreCli_Leave(sender As Object, e As EventArgs) Handles TktBPreCli.Leave
        If GestionInterface.ValidNom(TktBPreCli.Text) = False Then
            Me.ErrorProvider1.SetError(Me.TktBPreCli, "Vide ou Contient des nombre")
            ErrorProvider1.Tag = 1
        Else
            Me.ErrorProvider1.SetError(Me.TktBPreCli, "")
            ErrorProvider1.Tag = 0

        End If
    End Sub

    Private Sub TktBCodePos_Leave(sender As Object, e As EventArgs) Handles TktBCodePos.Leave
        If GestionInterface.ValidNum(TktBCodePos.Text) = False Then
            Me.ErrorProvider1.SetError(Me.TktBCodePos, "Vide ou Contient des lettre")
            ErrorProvider1.Tag = 1
        Else
            Me.ErrorProvider1.SetError(Me.TktBCodePos, "")
            ErrorProvider1.Tag = 0

        End If
    End Sub

    Private Sub TktBVilCli_Leave(sender As Object, e As EventArgs) Handles TktBVilCli.Leave
        If GestionInterface.ValidNom(TktBVilCli.Text) = False Then
            Me.ErrorProvider1.SetError(Me.TktBVilCli, "Vide ou Contient des nombre")
            ErrorProvider1.Tag = 1
        Else
            Me.ErrorProvider1.SetError(Me.TktBVilCli, "")
            ErrorProvider1.Tag = 0

        End If
    End Sub
End Class