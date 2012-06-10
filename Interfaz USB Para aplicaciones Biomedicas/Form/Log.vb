Public Class Log

    Private Sub Log_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TXTlog.Text = My.Settings.Logs
    End Sub

    Private Sub BorrarHistorialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarHistorialToolStripMenuItem.Click
        If MsgBox("¿Realmente desea borrar todo el historia creado hasta ahora?", MsgBoxStyle.Exclamation, My.Application.Info.AssemblyName) = MsgBoxResult.Ok Then
            My.Settings.Logs = Nothing
            Me.TXTlog.Text = My.Settings.Logs
        End If
    End Sub
End Class