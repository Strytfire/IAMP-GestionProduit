Imports IAMP_GestionProduit.GestionBDD
Public Class FrmBDD

    Private Sub TxtBoxConnectName_Enter(sender As Object, e As EventArgs) Handles TxtBoxConnectName.Enter
        If TxtBoxConnectName.Text = "Nom Du Serveur" Then
            TxtBoxConnectName.Text = ""
        End If
    End Sub

    Private Sub TxtBoxConnectName_Leave(sender As Object, e As EventArgs) Handles TxtBoxConnectName.Leave
        If TxtBoxConnectName.Text = "" Then
            TxtBoxConnectName.Text = "Nom Du Serveur"
        End If
    End Sub

    Private Sub TextBoxConnectNBDD_Enter(sender As Object, e As EventArgs) Handles TextBoxConnectNBDD.Enter
        If TextBoxConnectNBDD.Text = "Nom de la base de donnée" Then
            TextBoxConnectNBDD.Text = ""
        End If
    End Sub

    Private Sub TextBoxConnectNBDD_Leave(sender As Object, e As EventArgs) Handles TextBoxConnectNBDD.Leave
        If TextBoxConnectNBDD.Text = "" Then
            TextBoxConnectNBDD.Text = "Nom de la base de donnée"
        End If
    End Sub

    Private Sub TextBoxConnectLog_Enter(sender As Object, e As EventArgs) Handles TextBoxConnectLog.Enter
        If TextBoxConnectLog.Text = "Login" Then
            TextBoxConnectLog.Text = ""
        End If
    End Sub

    Private Sub TextBoxConnectLog_Leave(sender As Object, e As EventArgs) Handles TextBoxConnectLog.Leave
        If TextBoxConnectLog.Text = "" Then
            TextBoxConnectLog.Text = "Login"
        End If
    End Sub

    Private Sub TextBoxConnectMDP_Enter(sender As Object, e As EventArgs) Handles TextBoxConnectMDP.Enter
        If TextBoxConnectMDP.Text = "Mot de passe" Then
            TextBoxConnectMDP.Text = ""
        End If
    End Sub

    Private Sub BtnConnexion_Click(sender As Object, e As EventArgs) Handles BtnConnexion.Click
        GestionBDD.Serveur = TxtBoxConnectName.Text
        GestionBDD.BDD = TextBoxConnectNBDD.Text
        GestionBDD.Login = TextBoxConnectLog.Text
        GestionBDD.Mdp = TextBoxConnectMDP.Text


        Try
            SeConnecter()
            FrmAccueil.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Erreur dans les paramètres de connection : Serveur / BDD / Login / Mdp")
        End Try
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub
End Class