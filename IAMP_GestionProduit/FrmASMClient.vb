Imports System.Net
Imports MarchandPPE
Imports Org.BouncyCastle.Asn1.TeleTrust

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
        TktBRueCli.Text = MesClients.Rows(position).Item(5)
        TktBCodePos.Text = MesClients.Rows(position).Item(7)
        TktBVilCli.Text = MesClients.Rows(position).Item(6)
        TktBEmail.Text = MesClients.Rows(position).Item(4)
        TktBlog.Text = MesClients.Rows(position).Item(8)
        TktBtel.Text = MesClients.Rows(position).Item(3)


    End Sub

    Private Sub BtnFin_Click(sender As Object, e As EventArgs) Handles BtnFin.Click
        position = GestionClient.GetNBClients() - 1
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
            TxtBIdCli.Text = GestionBDD.Generer_Cle_Primaire("Id_Utilisateur", "Utilisateur")
            TxtBNomCli.Text = ""
            TktBPreCli.Text = ""
            TktBRueCli.Text = ""
            TktBCodePos.Text = ""
            TktBVilCli.Text = ""
            TktBtel.Text = ""
            TktBlog.Text = ""
            TktBEmail.Text = ""
        Else
            Dim n, p, r, t, v, log, em As String
            Dim answer As Integer
            answer = MsgBox("Voulez vous vraiment ajouter le client N° " & TxtBIdCli.Text & " Ajouter", MessageBoxButtons.YesNo)
            If answer = vbYes Then
                'And (ValidNomPrenom(n) And ValidNomPrenom(p)) Then
                MsgBox("Client n° " & TxtBIdCli.Text & " Ajouter")
                Dim id, cp As Integer
                id = TxtBIdCli.Text
                n = TxtBNomCli.Text
                p = TktBPreCli.Text
                r = TktBRueCli.Text
                cp = TktBCodePos.Text
                v = TktBVilCli.Text
                t = TktBtel.Text
                log = TktBlog.Text
                em = TktBEmail.Text
                GestionClient.AjouterClient(id, n, p, t, em, r, v, cp, log)
                BtnAddCli.Text = "Ajouter"
                dgvLstClient.DataSource = GestionClient.GetLesClients()
                Rafraichir()
            End If
        End If
    End Sub

    Private Sub BtnDelCli_Click(sender As Object, e As EventArgs) Handles BtnDelCli.Click
        Dim id As Integer
        Dim answer As Integer
        id = TxtBIdCli.Text
        answer = MsgBox("Voulez vous vraiment suprimmer le client N° " & TxtBIdCli.Text & " Supprimer", MessageBoxButtons.YesNo)
        If answer = vbYes Then
            MsgBox("Client n° " & TxtBIdCli.Text & " Supprimer")
            GestionClient.SupprimerClient(id)
            dgvLstClient.DataSource = GestionClient.GetLesClients()
            position = 0
            Rafraichir()
        Else
        End If
    End Sub

    Private Sub BtnModifCli_Click(sender As Object, e As EventArgs) Handles BtnModifCli.Click
        Dim answer = MsgBox("Voulez vous vraiment modifier le client N° " & TxtBIdCli.Text & " Modification", MessageBoxButtons.YesNo)
        If answer = vbYes Then
            Dim id, cp As Integer
            Dim n, p, r, tel, v, logi, mail As String
            id = TxtBIdCli.Text
            n = TxtBNomCli.Text
            p = TktBPreCli.Text
            r = TktBRueCli.Text
            cp = TktBCodePos.Text
            v = TktBVilCli.Text
            tel = TktBtel.Text
            logi = TktBlog.Text
            mail = TktBEmail.Text
            GestionClient.ModifierClient(id, n, p, r, cp, v, tel, logi, mail)
            dgvLstClient.DataSource = GestionClient.GetLesClients()
            Rafraichir()
        End If
    End Sub

    Private Sub BtnPDF_Click(sender As Object, e As EventArgs) Handles BtnPDF.Click
        GestionPDF.genererpdfdepuisdatatable(" Liste des Client ", GestionClient.GetLesClients(), GestionClient.GetNBClients())
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