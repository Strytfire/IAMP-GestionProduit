Imports ModeleIAPM
Public Class FrmAMSCommande
    Dim position

    Private Sub FrmAMSCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopLevel = False
        Me.Parent = FrmAccueil.Panel3
        Me.Top = 0
        Me.Left = 0
        dgvCom.DataSource = GestionCommande.DGCommande()
        Rafraichir()
        GestionInterface.AlimenterComboBox(CbCliCom, GestionClient.GetLesClientsCB(), “Patronyme”, “idClient”)
    End Sub

    Public Sub btnConsultCom_Click(sender As Object, e As EventArgs) Handles btnConsultCom.Click
        Dim idcom As Integer
        Dim Date_ As Date
        idcom = TxtBNumCom.Text
        Date_ = TxtBDateCom.Text
        FrmCommandeBis.idcom = idcom
        FrmCommandeBis.Date_ = Date_
        Me.Hide()
        FrmCommandeBis.Show()




    End Sub
    Public Sub Rafraichir()
        Try
            dgvCom.DataSource = DGCommande()
            Dim LesCommandes As DataTable = DGCommande()
            TxtBNumCom.Text = LesCommandes.Rows(position).Item(0)
            TxtBDateCom.Text = LesCommandes.Rows(position).Item(1)
            CbCliCom.Text = LesCommandes.Rows(position).Item(2)

            dgvCom.ClearSelection()
            dgvCom.Rows(position).Selected = True
        Catch
        End Try

    End Sub

    Private Sub BtnDebCom_Click(sender As Object, e As EventArgs) Handles BtnDebCom.Click
        position = 0
        Rafraichir()
    End Sub

    Private Sub BtnPrecCom_Click(sender As Object, e As EventArgs) Handles BtnPrecCom.Click
        If (position > 0) Then
            position = position - 1
        End If
        Rafraichir()
    End Sub

    Private Sub BtnAddCom_Click(sender As Object, e As EventArgs) Handles BtnAddCom.Click
        FrmAddCommande.Show()
    End Sub

    Private Sub BtnSuiComm_Click(sender As Object, e As EventArgs) Handles BtnSuiComm.Click
        If (position < GetNBCommandes() - 1) Then
            position = position + 1
        End If
        Rafraichir()
    End Sub

    Private Sub BtnFinCom_Click(sender As Object, e As EventArgs) Handles BtnFinCom.Click
        position = GetNBCommandes() - 1
        Rafraichir()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Dim idcom As Integer
        idcom = TxtBNumCom.Text
        GestionCommande.SuprimerCommande(idcom)
        Rafraichir()
    End Sub
End Class