Imports System.Windows.Forms.DataVisualization
Imports System.Windows.Forms.Timer

Public Class USB

    Private phandle As Integer

    ' Declaración de Buffers de lectura / escritura.
    Private BufferInSize As Short = 8 ' Declaramos el tamaño del buffer de entrada.
    Private BufferOutSize As Short = 8 ' Declaramos el tamaño del buffer de salida.
    Private BufferIn(BufferInSize) As Byte ' Variable que contiene los datos de salida cuyo tamaño lo designa BufferInSize.
    Private BufferOut(BufferOutSize) As Byte ' Variable que contiene los datos de salida cuyo tamaño lo designa BufferOutSize

    Private VendorID As Short = 6017 ' Variable que contiene el ID del vendedor del producto USB.
    Private ProductID As Short = 2000
    Private Grafica As System.Windows.Forms.DataVisualization.Charting.Chart
    Private Grafica2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Private Estado As System.Windows.Forms.PictureBox
    Private swith As Boolean = vbFalse
    Private lectura As Boolean = vbFalse

    Private conect As Boolean
    Private i As Double = 0
    Private op As Integer = 0
    Private sw As Integer = 0
    Private Bin1 As String = Nothing
    Private Bin2 As String = Nothing
    Private contador As Integer = 0
    Private id As Integer = 0
    Private id2 As Integer = 0
    Private tempo As Integer = 0
    Private baseDatos As Boolean = False
    Private visorDatos As Boolean = False

    Private Tiempo_buffer As Timer
    Private OscilacionBar As Double

    Public ReadOnly Property EstadoConexion As Boolean
        Get
            Return conect
        End Get
    End Property

    Private WriteOnly Property EstadoConexion2 As Boolean
        Set(ByVal value As Boolean)
            conect = value
        End Set
    End Property

    Public Property Id_Producto As Integer
        Get
            Return ProductID
        End Get
        Set(ByVal value As Integer)
            ProductID = value
        End Set
    End Property

    Public Property Id_Vendedor As Integer
        Get
            Return VendorID
        End Get
        Set(ByVal value As Integer)
            VendorID = value
        End Set
    End Property

    Public Property Buffer_Entrada As Short
        Get
            Return BufferInSize
        End Get
        Set(ByVal value As Short)
            BufferInSize = value
        End Set
    End Property

    Public Property Buffer_Salida As Short
        Get
            Return BufferOutSize
        End Get
        Set(ByVal value As Short)
            BufferOutSize = value
        End Set
    End Property

    Public Sub Connect(ByVal form As System.Windows.Forms.Form, ByRef visualizacion As System.Windows.Forms.Form, ByRef graf As System.Windows.Forms.DataVisualization.Charting.Chart, ByRef graf2 As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal est As System.Windows.Forms.PictureBox, ByRef amplitud1 As Integer, ByRef amplitud2 As Integer, ByVal basedatos As Conexion, ByRef Oscilacion As Double)
        Grafica = graf
        Grafica2 = graf2
        Estado = est
        visual = visualizacion
        conex = basedatos
        OscilacionBar = Oscilacion

        Debug.Items.Add("")
        Debug.Items.Add("Caracteristicas del Dispositivo:")
        Debug.Items.Add("VID:" & Hex(VendorID))
        Debug.Items.Add("PID:" & Hex(ProductID))
        Debug.Items.Add("IN_BUFFER: " & BufferInSize.ToString & " bytes")
        Debug.Items.Add("OUT_BUFFER: " & BufferOutSize.ToString & " bytes")

        ConnectToHID(form, Me)
        Timers()
    End Sub

    Public Sub Desconect()
        If Not Debug Is Nothing Then
            Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> Dispositivo desconectado por el usuario;")
            DisconnectFromHID() ' Desconectamos el dispositivo USB de la aplicación.
            Debug.Items.Add("")
            Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> Conexion con el Dispositivo Cerrada;")
            lectura = vbFalse
        End If
    End Sub

    '*****************************************************************
    ' Un dispositivo USB ha sido conectado.
    '*****************************************************************
    Public Sub OnPlugged(ByVal pHandle As Integer)
        If hidGetVendorID(pHandle) = VendorID And hidGetProductID(pHandle) = ProductID And conect = vbFalse Then
            Debug.Items.Add("")
            Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> El dispositivo ha sido conectado;")
            'MsgBox("El dispositivo ha sido conectado correctamente, se procedera a leer los datos.", MsgBoxStyle.Exclamation)
            Estado.BackColor = System.Drawing.Color.Lime
            conect = vbTrue
        End If
    End Sub

    '*****************************************************************
    ' Un dispositivo USB ha sido desconectado.
    '*****************************************************************
    Public Sub OnUnplugged(ByVal pHandle As Integer)
        If hidGetVendorID(pHandle) = VendorID And hidGetProductID(pHandle) = ProductID And conect = vbTrue Then
            hidSetReadNotify(hidGetHandle(VendorID, ProductID), False)
            Desconect()
            Estado.BackColor = System.Drawing.Color.Red
            conect = vbFalse
        End If
    End Sub

    '***********************************************************************
    ' Llamada a Notificación de cambios en el controlador en caso 
    ' de que todos los dispositivos hallan sido conectados o desconectados.
    '***********************************************************************
    Public Sub OnChanged()
        ' Toma el manejador del dispositivo en el cuál estemos interasados, luego
        ' luego setea esta notificación a 1 - esto asegura que tengamos una lectura.
        ' Se recibirán notificaciones siempre y cuando hayan datos para leer.
        'pHandle = hidGetHandle(VendorID, ProductID)
        hidSetReadNotify(hidGetHandle(VendorID, ProductID), True)
    End Sub

    '*****************************************************************
    ' this is how you write some data...
    '*****************************************************************
    Public Sub WriteSomeData(ByVal data As Byte)
        BufferOut(0) = 0   ' first by is always the report ID
        BufferOut(1) = data  ' first data item, etc etc

        ' write the data (don't forget, pass the whole array)...
        'hidWriteEx(VendorID, ProductID, BufferOut(0))
    End Sub

    '*****************************************************************
    ' En un evento de lectura....
    '*****************************************************************
    Public Sub OnRead(ByVal pHandle As Integer)
        If hidRead(pHandle, BufferIn(0)) Then
            If EstadoConexion = vbTrue Then
                If lectura = vbFalse Then Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> Lectura de Datos en curso;") : lectura = vbTrue
                Dim img(3) As Integer

                img(0) = BufferIn(7) 'msb parte alta canal 0
                img(1) = BufferIn(6) 'lsb parte baja canal 0
                img(2) = BufferIn(5) 'msb parte alta canal 1
                img(3) = BufferIn(4) 'lsb parte baja canal 1

                op = 5 * conversionBytes(img(0), img(1))
                sw = 5 * conversionBytes(img(2), img(3))

                Grafica.Series.Item(0).Points.AddXY(0, op) ' amp1 y amp2 siempre deben ser 0
                Grafica2.Series.Item(0).Points.AddXY(0, sw)

                If contador = (OscilacionBar + 1) Then
                    Grafica.Series.Item(0).Points.RemoveAt(0)
                    Grafica2.Series.Item(0).Points.RemoveAt(0)
                    contador -= 1
                End If

                If baseDatos = True Then InyeccionSQL()
                If visorDatos = True Then VisualizacionB()
                contador += 1
                tempo += 1
            End If
        End If
    End Sub

    Public Function Buffer() As Integer
        'If EstadoConexion = vbTrue Then
        '    If lectura = vbFalse Then Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> Lectura de Datos en curso;") : lectura = vbTrue
        '    Dim img(3) As Integer

        '    img(0) = BufferIn(7) 'msb parte alta canal 0
        '    img(1) = BufferIn(6) 'lsb parte baja canal 0
        '    img(2) = BufferIn(5) 'msb parte alta canal 1
        '    img(3) = BufferIn(4) 'lsb parte baja canal 1

        '    op = 5 * conversionBytes(img(0), img(1))
        '    sw = 5 * conversionBytes(img(2), img(3))

        '    Grafica.Series.Item(0).Points.AddXY(0, op) ' amp1 y amp2 siempre deben ser 0
        '    Grafica2.Series.Item(0).Points.AddXY(0, sw)

        '    If contador = (OscilacionBar + 1) Then
        '        Grafica.Series.Item(0).Points.RemoveAt(0)
        '        Grafica2.Series.Item(0).Points.RemoveAt(0)
        '        contador -= 1
        '    End If

        '    If baseDatos = True Then InyeccionSQL()
        '    If visorDatos = True Then VisualizacionB()
        '    contador += 1
        '    tempo += 1
        'End If
        'Return 0
    End Function

    Public Sub ActivarBaseDatos()
        Select Case baseDatos
            Case True
                baseDatos = False
            Case False
                baseDatos = True
        End Select
    End Sub

    Public Sub ActivarVisor()
        Select Case visorDatos
            Case True
                visorDatos = False
            Case False
                visorDatos = True
        End Select
    End Sub

    Private Function conversionBytes(ByVal b1 As Byte, ByVal b2 As Byte) As Integer
        Bin1 = Convert.ToString(b1, 2) ' Base 2
        Bin1 = Bin1.PadLeft(2, "0")
        Bin2 = Convert.ToString(b2, 2) ' Base 2
        Bin2 = Bin2.PadLeft(8, "0")
        Dim base = Bin1 & Bin2
        Dim op = Convert.ToInt32(base, 2) ' Realiza una concatenacion entre ambos valores y la concatenacion la convierte a integer
        Return op
    End Function

    Public Function Timers() As Integer 'inicializo el timer para poder graficar los datos en menor tiempo que en el que los manda la tarjeta
        If Tiempo_buffer Is Nothing Then
            Tiempo_buffer = New Timer
            Tiempo_buffer.Enabled = vbTrue
            Tiempo_buffer.Interval = 2
            AddHandler Tiempo_buffer.Tick, AddressOf Buffer
            Tiempo_buffer.Start()
        End If

        Return 0
    End Function

    Public Function InyeccionSQL() As Integer
        Dim estado As ConnectionState = conex.ConexionMysqlEstado()
        Dim sql As String = Nothing
        QUERY(estado, "INSERT INTO `grafica1` (`x`,`y`) VALUES (" & tempo & "," & op & ");", id)
        QUERY(estado, "INSERT INTO `grafica2` (`x`,`y`) VALUES (" & tempo & "," & sw & ");", id2)

        sql = "INSERT INTO `registro` (`id_grafica1`, `id_grafica2`, `fecha`) VALUES (" & id & "," & id2 & ",'" & DateTime.Now.ToShortDateString() & " " & DateTime.Now.ToLongTimeString & "');"
        archivos.Backup(sql)
        If estado = ConnectionState.Open Then conex.DDL(sql)

        Return 0
    End Function

    Public Sub QUERY(ByVal estado As ConnectionState, ByVal sql As String, ByRef identificador As Integer)
        Try
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader = Nothing
            If estado = ConnectionState.Open Then conex.DDL(sql)
            If estado = ConnectionState.Open Then reader = conex.DDL("SELECT @@identity AS id")
            If reader.Read() Then : identificador = reader("id") : End If
            reader.Close()

            archivos.Backup(sql)
        Catch ex As Exception

        End Try
    End Sub

    Public Function VisualizacionB() As Integer 'visualizacion del puerto b
        Dim count As Integer = 1
        visual.Controls.Item(1).Text = Bin1.ToString
        visual.Controls.Item(3).Text = Bin2.ToString
        visual.Controls.Item(5).Text = contador.ToString
        visual.Controls.Item(7).Text = sw.ToString
        visual.Controls.Item(9).Text = op.ToString
        For u = 11 To 24 Step 2 : visual.Controls.Item(u).Text = BufferIn(count) : count += 1 : Next

        Return 0
    End Function
End Class
