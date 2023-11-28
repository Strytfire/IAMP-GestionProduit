Imports System.Data
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace Global.ModeleIAPM
    Public Class GestionInterface

        Public Shared Sub AlimenterComboBox(ByRef macombo As ComboBox, masource As DataTable, mondisplay As String, mavaleur As String)
            macombo.DataSource = masource
            macombo.DisplayMember = mondisplay
            If mavaleur <> "" Then
                macombo.ValueMember = mavaleur
            End If
        End Sub

        Public Shared Function RemplaceApostrophesSlash(ByRef unechaine As String) As String
            Dim ch As String
            ch = unechaine.Replace("'", "/")
            Return ch
        End Function
        Public Shared Function RemplaceSlashApostrophes(ByRef unechaine As String) As String
            Dim ch As String
            ch = unechaine.Replace("/", "'")
            Return ch
        End Function

        Public Shared Function RemplaceSlashApostrophesDataTable(ByRef lesdonnees As DataTable)
            Dim nblignes As Integer
            Dim nbcolonnes As Integer
            Dim test As String = ""
            nblignes = lesdonnees.Rows.Count
            nbcolonnes = lesdonnees.Columns.Count
            Dim i, j As Integer
            For i = 0 To nblignes - 1
                For j = 0 To nbcolonnes - 1
                    'Attention le replace ne s'applique qu'au type String : utilisation de la classe de base Object :'
                    If Object.ReferenceEquals(lesdonnees.Rows(i).Item(j).GetType(), test.GetType()) Then
                        lesdonnees.Rows(i).Item(j) = RemplaceSlashApostrophes(lesdonnees.Rows(i).Item(j))
                    End If
                Next
            Next
            Return lesdonnees
        End Function
        Public Shared Function ValidMail(ByVal adresse As String) As Boolean
            Dim myRegex As System.Text.RegularExpressions.Regex
            myRegex = New Regex("^([\w]+)@([\w]+)\.([\w]+)$")
            '([\w]+) ==> caractère alphanumérique apparaissant une fois ou plus
            Return myRegex.IsMatch(adresse) 'retourne true ou false selon la vérification
        End Function
        Public Shared Function ValidNom(ByRef nom As String) As Boolean
            Dim myRegex As System.Text.RegularExpressions.Regex
            myRegex = New Regex("^[^0-9]+$")
            Return myRegex.IsMatch(nom)
        End Function
        Public Shared Function ValidNum(ByRef num As String) As Boolean
            Dim myRegex As System.Text.RegularExpressions.Regex
            myRegex = New Regex("^[0-9]{1,5}$")
            Return myRegex.IsMatch(num)
        End Function


    End Class
End Namespace




