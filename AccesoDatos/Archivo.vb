Public Class Archivo

    Private pach As String = My.Application.Info.DirectoryPath & "\Logs\" & DateTime.Now.ToLongDateString() & " a las " & DateTime.Now.Hour.ToString & "_" & Date.Now.Minute.ToString & "_" & Date.Now.Second & ".log"
    Private _backup As String = My.Application.Info.DirectoryPath & "\Logs\" & DateTime.Now.ToLongDateString() & " a las " & DateTime.Now.Hour.ToString & "_" & Date.Now.Minute.ToString & "_" & Date.Now.Second & ".backup"
    Private pach_2 As String = My.Application.Info.DirectoryPath & "\Logs"

    Public Sub New()
        CrearDirectorio()
    End Sub

    Public Sub Log(ByVal texto As String)
        CrearDirectorio()
        Dim fileExists = My.Computer.FileSystem.FileExists(pach)
        If fileExists = vbFalse Then My.Computer.FileSystem.WriteAllText(pach, texto, False) Else My.Computer.FileSystem.WriteAllText(pach, texto, True)
    End Sub

    Public Sub Backup(ByVal texto As String)
        My.Computer.FileSystem.WriteAllText(_backup, texto, True)
    End Sub

    Private Sub CrearDirectorio()
        Dim folderExists = My.Computer.FileSystem.DirectoryExists(pach_2)
        If folderExists = vbFalse Then My.Computer.FileSystem.CreateDirectory(pach_2)
    End Sub
End Class
