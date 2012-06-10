Public Class Visualizacion

    Private Sub Visualizacion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Interfaz_USB.cerrar = False Then
            e.Cancel = True
            Me.Hide()
        Else
            End
            Interfaz_USB.Close()
        End If
    End Sub
End Class