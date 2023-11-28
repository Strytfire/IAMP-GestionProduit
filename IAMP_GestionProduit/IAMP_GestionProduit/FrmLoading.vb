Public Class FrmLoading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TimeBar.Width += 3
        If TimeBar.Width >= 679 Then

            Timer1.Stop()
            Me.Hide()
            FrmBDD.Show()
        End If


    End Sub
End Class