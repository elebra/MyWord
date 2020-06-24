Public Class DevModeDialog

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Memory.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Memory.Text = PerformanceCounter1.NextValue
        WindowsVer.Text = My.Computer.Info.OSVersion
        If My.Computer.Info.OSVersion >= "6.2" Then
            Compatable.Text = "Y"
        Else
            Compatable.Text = "N"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class