Public Class Start



    Private Sub Start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Info.OSVersion >= "6.2" Then
            Timer1.Start()
        Else
            MessageBox.Show("You Are Running Upsupported Version Of Windows.", "Not Compatable", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Hide()
        Form1.Show()
        Timer1.Stop()
    End Sub
End Class