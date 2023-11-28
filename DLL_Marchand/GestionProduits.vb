

Namespace Global.MarchandPPE
    Public Class GestionProduits

        Public Shared Function GetLesProduits() As DataTable
            Return GestionBDD.Executer_Requete_Select(“SELECT * FROM produit”)
        End Function
        Public Shared Function GetLesProduitsDG() As DataTable
            Return GestionBDD.Executer_Requete_Select(“SELECT LibelleProduit ,PrixHTProduit , Img_Produit, NomFournisseur,LibelleCategorie FROM produit, fournisseur, categorie  WHERE categorie.idCategorie=produit.idCategorie AND fournisseur.idFournisseur=produit.idFournisseur”)
        End Function
        Public Shared Function GetNBProduits() As Integer
            Return GestionBDD.Executer_Requete_Scalaire("Select Count(*) From Produit")
        End Function
        Public Shared Sub AjouterProduit(id As Integer, l As String, p As String, i As String, cp As String, v As String)
            GestionBDD.Executer_Requete_Action("Insert into Produit (idProduit,LibelleProduit,PrixHTProduit,Img_Produit,idFournisseur,idCategorie) values (" & id & " ,'" & l & "','" & p & "','" & i & "','" & cp & "','" & v & "')")
        End Sub
        Public Shared Sub SupprimerProduit(id As Integer)
            GestionBDD.Executer_Requete_Action("delete from produit where idproduit = " & id)
        End Sub
        Public Shared Sub ModifierProduit(id As Integer, n As String, p As String, r As String, cp As String, v As String)
            GestionBDD.Executer_Requete_Action("update produit set LibelleProduit = '" & n & "',PrixHTProduit = '" & p & "' ,Img_Produit = '" & r & "',idFournisseur = '" & cp & "', idCategorie = '" & v & "' Where idProduit = " & id & "")
        End Sub
        Public Shared Function RechercherProduit(re As String)
            Return GestionBDD.Executer_Requete_Select("Select * FROM Produit where ((LibelleProduit LIKE '%" & re & "%') or (PrixHTProduit like '%" & re & "%'))")
            End Function
        Public Shared Function GetNomProd(idcate As String) As DataTable
            Return GestionBDD.Executer_Requete_Select(“SELECT * FROM produit WHERE idCategorie LIKE '" & idcate & "' ”)
        End Function
    End Class
End Namespace

'