Imports System.Data
Imports ModeleIAPM

Namespace Global.ModeleIAPM
    Public Class GestionProduits

        Public Shared Function GetLesProduits() As DataTable
            Return GestionBDD.Executer_Requete_Select(“SELECT * FROM produit”)
        End Function
        Public Shared Function GetLesProduitsDG() As DataTable
            Return GestionBDD.Executer_Requete_Select(“SELECT LibelleProduit, PrixHTProduit, QteStockProduit, NomFournisseur,LibelleCategorie FROM produit, fournisseur, categorie  WHERE categorie.idCategorie=produit.idCat AND fournisseur.idFournisseur=produit.idFourn”)
        End Function
        Public Shared Function GetNBProduits() As Integer
            Return GestionBDD.Executer_Requete_Scalaire("Select Count(*) From Produit")
        End Function
        Public Shared Sub AjouterProduit(id As Integer, n As String, p As String, r As String, cp As String, v As String)
            GestionBDD.Executer_Requete_Action("Insert into Produit values (" & id & " ,'" & n & "','" & p & "','" & r & "','" & cp & "','" & v & "')")
        End Sub
        Public Shared Sub SupprimerProduit(id As Integer)
            GestionBDD.Executer_Requete_Action("delete from produit where idproduit = " & id)
        End Sub
        Public Shared Sub ModifierProduit(n As String, p As String, r As String, cp As String, v As String)
            GestionBDD.Executer_Requete_Action("update produit set LibelleProduit = '" & n & "',PrixHTProduit = '" & p & "' ,QteStockProduit = '" & r & "',idFourn = '" & cp & "' Where idCat = " & v & "")
        End Sub
        Public Shared Function RechercherProduit(re As String)
            Return GestionBDD.Executer_Requete_Select("Select * FROM Produit where ((LibelleProduit LIKE '%" & re & "%') or (PrixHTProduit like '%" & re & "%'))")
        End Function
        Public Shared Function GetNomProd(idcate As String) As DataTable
            Return GestionBDD.Executer_Requete_Select(“SELECT * FROM produit WHERE IdCat LIKE '" & idcate & "' ”)
        End Function
    End Class
End Namespace
