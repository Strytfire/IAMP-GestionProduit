Imports System.Data
Imports ModeleIAPM

Namespace Global.ModeleIAPM
    Public Class GestionCatégorie
        Public Shared Function GetLesCategorie() As DataTable
            Return GestionBDD.Executer_Requete_Select(“SELECT * FROM categorie”)
        End Function


    End Class
End Namespace

