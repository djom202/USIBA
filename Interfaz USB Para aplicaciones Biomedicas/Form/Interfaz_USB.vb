Public Class Interfaz_USB

    Public arc As New AccesoDatos.Archivo()
    Public USB As New AccesoDatos.USB()
    Public Conexion As New AccesoDatos.Conexion()
    Public indice As Integer = 0
    Public indice2 As Integer = 0
    Public indice3 As Integer = 0
    Public cerrar As Boolean = False
    Private basedatos As Boolean = False
    Private visordatos As Boolean = False

    Private Sub Hora_windows_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hora_windows.Tick
        StatusStrip1.Items(0).Text = DateTime.Now.ToShortTimeString ' Mostramos la hora de Windows.
    End Sub

    '**********************************************************************
    ' En caso de que el formulario se cierre el dispositivo se desconecta.
    '**********************************************************************
    Private Sub Interfaz_USB_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> Cerrada la aplicacion;")
        Desconectar_USB()
        cerrar = True
    End Sub

    Private Sub Desconectar_USB()
        USB.Desconect()
        My.Settings.Logs += "Fecha: " & DateTime.Now.ToShortDateString() & vbCrLf
        For k = 1 To Me.Debug.Items.Count - 1 : My.Settings.Logs += Me.Debug.Items.Item(k).ToString & vbCrLf : Next
        My.Settings.Save()
        arc.Log(My.Settings.Logs)
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub Interfaz_USB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Verificacion()
        Debug.Items.Add("Consola:")

        If Conexion.ConexionMySQL(Debug, My.Settings.server, My.Settings.port, My.Settings.usuario, My.Settings.password, My.Settings.basedatos) = vbFalse Then
            Debug.Items.Add("Conexion a la Base de Datos: " & Conexion.ConexionMysqlEstado.ToString & ";")
            Debug.Items.Add("Error en la conexion;")
        Else
            Debug.Items.Add("Conexion a la Base de Datos: " & Conexion.ConexionMysqlEstado.ToString & ";")
        End If

        USB.Connect(Iteracion, My.Forms.Visualizacion, Chart, Chart2, Pbox, indice, indice2, Conexion, My.Settings.g1valorx_max) 'inicio de la conexion USB
        Debug.Items.Add("")

        Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> " & My.Application.Info.ProductName & ", version " & My.Application.Info.Version.ToString & ";")
        Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> Ing. en sistemas de la U.S.B;")
        Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> Visite www.altiviaot.probandoando.com/home/site/;")
        Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> Sugerecias, escribir a altiviaot@live.com;")
        Debug.Items.Add("")
        Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> Aplicacion Lista para recibir del Dispositivo;")

        If USB.EstadoConexion = vbFalse Then Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> Dispositivo aún no enlazado;")

        Select Case My.Settings.g2valorx_max
            Case 50 : OscilacionBar.Value = 1
            Case 100 : OscilacionBar.Value = 2
            Case 200 : OscilacionBar.Value = 3
            Case 300 : OscilacionBar.Value = 4
            Case 400 : OscilacionBar.Value = 5
            Case 500 : OscilacionBar.Value = 6
        End Select

        Select Case (My.Settings.g1valory_max / 1000)
            Case 1 : Amplitud1.Value = 1
            Case 2 : Amplitud1.Value = 2
            Case 3 : Amplitud1.Value = 3
            Case 4 : Amplitud1.Value = 4
            Case 5 : Amplitud1.Value = 5
            Case 6 : Amplitud1.Value = 6
            Case 7 : Amplitud1.Value = 7
        End Select

        Select Case (My.Settings.g2valory_max / 1000)
            Case 1 : Amplitud2.Value = 1
            Case 2 : Amplitud2.Value = 2
            Case 3 : Amplitud2.Value = 3
            Case 4 : Amplitud2.Value = 4
            Case 5 : Amplitud2.Value = 5
            Case 6 : Amplitud1.Value = 6
            Case 7 : Amplitud1.Value = 7
        End Select


        Me.LBLindice.Text = My.Settings.g1valory_max.ToString
        Me.LBLindice2.Text = My.Settings.g2valory_max.ToString
        Me.LBLindice3.Text = My.Settings.g2valorx_max.ToString

        '*****************************LIMITES DE OSCILACION****************************
        Chart.ChartAreas.Item(0).AxisY.Minimum = My.Settings.g1valory_min
        Chart.ChartAreas.Item(0).AxisY.Maximum = My.Settings.g1valory_max

        Chart.ChartAreas.Item(0).AxisX.Minimum = My.Settings.g1valorx_min
        Chart.ChartAreas.Item(0).AxisX.Maximum = My.Settings.g1valorx_max

        Chart2.ChartAreas.Item(0).AxisY.Minimum = My.Settings.g2valory_min
        Chart2.ChartAreas.Item(0).AxisY.Maximum = My.Settings.g2valory_max

        Chart2.ChartAreas.Item(0).AxisX.Minimum = My.Settings.g2valorx_min
        Chart2.ChartAreas.Item(0).AxisX.Maximum = My.Settings.g2valorx_max

        '******************************************************************************
    End Sub

    Private Sub Verificacion()
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/mcHID.dll") = vbFalse Then
            My.Computer.FileSystem.WriteAllBytes("mcHID.dll", My.Resources.mcHID, False)
        End If

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/AccesoDatos.dll") = vbFalse Then
            My.Computer.FileSystem.WriteAllBytes("AccesoDatos.dll", My.Resources.AccesoDatos, False)
        End If

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/MySql_Data.dll") = vbFalse Then
            My.Computer.FileSystem.WriteAllBytes("MySql_Data.dll", My.Resources.MySql_Data, False)
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Conexion.DesconexionMySQL()
        End
    End Sub

    Private Sub CerrarConexiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarConexiónToolStripMenuItem.Click
        Desconectar_USB()
    End Sub

    Private Sub AbrirConexiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirConexiónToolStripMenuItem.Click
        USB.Connect(Iteracion, My.Forms.Visualizacion, Chart, Chart2, Pbox, indice, indice2, Conexion, My.Settings.g1valorx_max) 'inicio de la conexion USB
    End Sub

    Private Sub ConfiguracionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionesToolStripMenuItem.Click
        My.Forms.Configuraciones.ShowDialog()
        'guarda los valores asignados de grafica1
        Chart.ChartAreas.Item(0).AxisY.Minimum = My.Settings.g1valory_min
        Chart.ChartAreas.Item(0).AxisY.Maximum = My.Settings.g1valory_max
        Chart.ChartAreas.Item(0).AxisX.Minimum = My.Settings.g1valorx_min
        Chart.ChartAreas.Item(0).AxisX.Maximum = My.Settings.g1valorx_max
        ''y grafica2
        Chart2.ChartAreas.Item(0).AxisY.Minimum = My.Settings.g2valory_min
        Chart2.ChartAreas.Item(0).AxisY.Maximum = My.Settings.g2valory_max
        Chart2.ChartAreas.Item(0).AxisX.Minimum = My.Settings.g2valorx_min
        Chart2.ChartAreas.Item(0).AxisX.Maximum = My.Settings.g2valorx_max
    End Sub

    Private Sub Amplitud1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Amplitud1.Scroll
        Dim limite As Integer = 0
        Select Case Amplitud1.Value
            Case 1 : limite = Amplitud1.Value * 1000
            Case 2 : limite = Amplitud1.Value * 1000
            Case 3 : limite = Amplitud1.Value * 1000
            Case 4 : limite = Amplitud1.Value * 1000
            Case 5 : limite = Amplitud1.Value * 1000
            Case 6 : limite = Amplitud1.Value * 1000
            Case 7 : limite = Amplitud1.Value * 1000
        End Select

        Try
            My.Settings.g1valory_max = limite
            My.Settings.Save()
            indice = limite.ToString
            Me.LBLindice.Text = limite.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Amplitud2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Amplitud2.Scroll
        Dim limite As Integer = 0
        Select Case Amplitud2.Value
            Case 1 : limite = Amplitud2.Value * 1000
            Case 2 : limite = Amplitud2.Value * 1000
            Case 3 : limite = Amplitud2.Value * 1000
            Case 4 : limite = Amplitud2.Value * 1000
            Case 5 : limite = Amplitud2.Value * 1000
            Case 6 : limite = Amplitud2.Value * 1000
            Case 7 : limite = Amplitud2.Value * 1000
        End Select

        Try
            My.Settings.g2valory_max = limite
            My.Settings.Save()
            indice2 = limite.ToString
            Me.LBLindice2.Text = limite.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub OscilacionBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OscilacionBar.Scroll
        Dim limite As Integer = 0
        Select Case OscilacionBar.Value
            Case 1 : limite = 50
            Case 2 : limite = 100
            Case 3 : limite = 200
            Case 4 : limite = 300
            Case 5 : limite = 400
            Case 6 : limite = 500
        End Select

        Try
            My.Settings.g1valorx_max = limite
            My.Settings.g2valorx_max = limite

            My.Settings.Save()
            Me.LBLindice3.Text = limite.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub VisorDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisorDeDatosToolStripMenuItem.Click
        My.Forms.Visualizacion.Show(Me)
    End Sub

    Private Sub Limites_Graficas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limites_Graficas.Tick
        Chart.ChartAreas.Item(0).AxisY.Minimum = My.Settings.g1valory_min
        Chart.ChartAreas.Item(0).AxisY.Maximum = My.Settings.g1valory_max

        Chart.ChartAreas.Item(0).AxisX.Minimum = My.Settings.g1valorx_min
        Chart.ChartAreas.Item(0).AxisX.Maximum = My.Settings.g1valorx_max

        Chart2.ChartAreas.Item(0).AxisY.Minimum = My.Settings.g2valory_min
        Chart2.ChartAreas.Item(0).AxisY.Maximum = My.Settings.g2valory_max

        Chart2.ChartAreas.Item(0).AxisX.Minimum = My.Settings.g2valorx_min
        Chart2.ChartAreas.Item(0).AxisX.Maximum = My.Settings.g2valorx_max
    End Sub

    Private Sub VisorDeEventosAnterioresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisorDeEventosAnterioresToolStripMenuItem.Click
        My.Forms.Log.Show(Me)
    End Sub

    Private Sub ActivarBaseDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivarBaseDeDatosToolStripMenuItem.Click
       USB.ActivarBaseDatos()
    End Sub

    Private Sub ActivarVisorDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivarVisorDeDatosToolStripMenuItem.Click
        USB.ActivarVisor()
    End Sub
End Class