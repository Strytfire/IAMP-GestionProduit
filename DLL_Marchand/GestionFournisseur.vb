﻿
Namespace Global.MarchandPPE
    Public Class GestionFournisseur
        Public Shared Function GetLesFournisseurs() As DataTable
            Return GestionBDD.Executer_Requete_Select(“SELECT * FROM fournisseur”)
        End Function
    End Class
End Namespace