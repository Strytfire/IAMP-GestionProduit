Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mail.Attachment
Imports System.IO
Imports System.Net.Mime

Public Class FrmMail



    Private Sub btn_Go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Go.Click
        SendMail()

    End Sub

    Private Sub SendMail()

        Try
            Dim smtp_Server As New SmtpClient
            Dim email As New MailMessage
            Dim filetxt As String = "D:\fichier.pdf"
            Dim data As Net.Mail.Attachment = New Net.Mail.Attachment(filetxt)
            data.Name = "fichier.pdf"
            smtp_Server.UseDefaultCredentials = False
            smtp_Server.Credentials = New Net.NetworkCredential("simoncintrat@gmail.com", txtmdp.Text)
            smtp_Server.Port = 587
            smtp_Server.EnableSsl = True
            smtp_Server.Host = "smtp.gmail.com"
            email = New MailMessage()
            email.From = New MailAddress(txtDe.Text)
            email.To.Add(txtA.Text)
            email.Subject = txtSuj.Text
            email.IsBodyHtml = False
            email.Body = txtMess.Text
            email.Attachments.Add(data)
            smtp_Server.Send(email)
            MsgBox("OK")
        Catch
            MsgBox("dommage")
        End Try
    End Sub

    Private Sub FrmMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopLevel = False
        Me.Parent = FrmAccueil.Panel3
        Me.Top = 0
        Me.Left = 0
        AxAcroPDF1.src = "D:\fichier.pdf"
    End Sub
End Class