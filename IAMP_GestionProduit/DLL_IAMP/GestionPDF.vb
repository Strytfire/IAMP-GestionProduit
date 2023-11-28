Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports DLL_IAMP.GestionClient
Imports System.Data

Namespace Global.ModeleIAPM
    Public Class GestionPDF
        Public Shared Sub genererpdfdepuisdatatable(ByVal titre As String, ByVal lesdonnees As DataTable, NB As Integer)
            Dim Doc As Document = New Document
            Dim TitreDoc As Paragraph
            Dim image As Paragraph
            Dim tableau_entete As PdfPTable
            Dim tableau_ligne As PdfPTable
            Dim cellule As PdfPCell = New PdfPCell
            Dim imageURL As String = "logo.png"
            Dim jpg As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(imageURL)
            jpg.ScaleToFit(140.0F, 120.0F)
            jpg.SpacingBefore = 10.0F
            jpg.SpacingAfter = 10.0F
            jpg.Alignment = Element.ALIGN_MIDDLE
            Try
                PdfWriter.GetInstance(Doc, New System.IO.FileStream(“d:\fichier.pdf”,
                System.IO.FileMode.Create))
                'Pour créer le fichier pdf où vous voulez changez le chemin ici.
                Doc.Open()

                image = New Paragraph
                image.Add(jpg)
                Doc.Add(image)
                Doc.Add(New Paragraph(" "))

                TitreDoc = New Paragraph
                TitreDoc.Alignment = Element.ALIGN_CENTER
                TitreDoc.Add("BTS SIO SLAM")
                Doc.Add(TitreDoc)
                Doc.Add(New Paragraph(" "))

                'entête de la page
                tableau_entete = New PdfPTable(2)
                'création d’un tableau de 2 colonnes
                cellule.Colspan = 0
                'création d’un tableau a 2 colonnes
                tableau_entete.AddCell(" Projet GestStageEtud ")
                'ecriture dans les case du tableau
                tableau_entete.AddCell(titre + DateTime.Now)
                Doc.Add(tableau_entete)
                'Ajoute le tableau au document. Vous pouvez ajouter un texte ou une variable qui 
                'contient tout le texte que vous voulez inserer
                tableau_ligne = New PdfPTable(1)
                tableau_ligne.SpacingBefore = 20
                Dim nblignes As Integer
                Dim nbcolonnes As Integer
                Dim uneligne As String = " "
                nblignes = NB
                nbcolonnes = lesdonnees.Columns.Count
                cellule.Colspan = 5
                Dim I, j As Integer
                For I = 0 To nblignes - 1
                    For j = 0 To nbcolonnes - 1
                        uneligne = uneligne & “ - “ & lesdonnees.Rows(I).Item(j)
                    Next
                    tableau_ligne.AddCell(uneligne)
                    tableau_ligne.AddCell(" ")
                    uneligne = " "
                Next
                Doc.Add(tableau_ligne)
            Catch e As Exception
                MsgBox(" Erreur sur le fichier Pdf " & e.Message)
            End Try
            Doc.Close()
            Process.Start("d:\Fichier.pdf") 'Lance le fichier pdf
        End Sub

        Public Shared Sub genererpdfdepuisdatatableCo(ByVal titre As String, ByVal lesdonnees As DataTable)
            Dim Doc As Document = New Document
            Dim tableau_entete As PdfPTable
            Dim tableau_type As PdfPTable
            Dim tableau_ligne As PdfPTable
            Dim cellule As PdfPCell = New PdfPCell
            Dim imageURL As String = "logo.png"
            Dim jpg As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(imageURL)
            jpg.ScaleToFit(140.0F, 120.0F)
            jpg.SpacingBefore = 10.0F
            jpg.SpacingAfter = 10.0F
            jpg.Alignment = Element.ALIGN_MIDDLE

            Try
                PdfWriter.GetInstance(Doc, New System.IO.FileStream(“d:\fichier.pdf”, System.IO.FileMode.Create))
                'Pour créer le fichier pdf où vous voulez changez le chemin ici.
                Doc.Open()

                Doc.Add(jpg)

                Dim para As Paragraph


                para = New Paragraph
                para.Add("BTS SIO SLAM - VB.NEt")
                para.SpacingBefore = 10.0F
                para.SpacingAfter = 10.0F
                para.Alignment = Element.ALIGN_CENTER
                Doc.Add(para)


                'entête de la page
                tableau_entete = New PdfPTable(2)
                'création d’un tableau de 2 colonnes
                cellule.Colspan = 0
                'création d’un tableau a 2 colonnes
                tableau_entete.AddCell("Projet IAPM")
                'ecriture dans les case du tableau
                tableau_entete.AddCell(titre + " aux : " + DateTime.Now)
                Doc.Add(tableau_entete)
                'Ajoute le tableau au document. Vous pouvez ajouter un texte ou une variable qui 
                'contient tout le texte que vous voulez inserer
                tableau_type = New PdfPTable(5)
                cellule.Colspan = 0
                tableau_type.AddCell("Numero Ligne")
                tableau_type.AddCell("Nom du Produit")
                tableau_type.AddCell("Prix du Produit")
                tableau_type.AddCell("Quantité")
                tableau_type.AddCell("Prix Total")

                Doc.Add(tableau_type)

                tableau_ligne = New PdfPTable(1)
                tableau_ligne.SpacingBefore = 20
                Dim nblignes As Integer
                Dim nbcolonnes As Integer
                Dim uneligne As String = " "
                nblignes = lesdonnees.Rows.Count
                nbcolonnes = lesdonnees.Columns.Count
                cellule.Colspan = 5
                Dim I, j As Integer
                For I = 0 To nblignes - 1
                    For j = 0 To nbcolonnes - 1
                        uneligne = uneligne & “      |      “ & lesdonnees.Rows(I).Item(j)
                    Next
                    tableau_ligne.AddCell(uneligne)
                    tableau_ligne.AddCell(" ")
                    uneligne = " "
                Next
                Doc.Add(tableau_ligne)
            Catch e As Exception
                MsgBox(" Erreur sur le fichier Pdf " & e.Message)
            End Try
            Doc.Close()
            Process.Start("d:\Fichier.pdf") 'Lance le fichier pdf
        End Sub

    End Class
End Namespace


