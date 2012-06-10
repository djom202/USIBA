Public Class Configuraciones

    Private toSave As Boolean = vbFalse

    Private Sub Configuraciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Interfaz_USB.Conexion.SuperConexionMySQL()
        Me.TXTusuario.Text = My.Settings.usuario
        Me.TXTpassword.Text = My.Settings.password
        Me.TXTservidor.Text = My.Settings.server
        Me.ComboBases.Text = My.Settings.basedatos
        Me.TXTpuerto.Text = My.Settings.port

        Me.TXTg1valorx_min.Text = My.Settings.g1valorx_max.ToString
        Me.TXTg1valorx_max.Text = My.Settings.g1valorx_min.ToString
        Me.TXTg1valory_min.Text = My.Settings.g1valory_min.ToString
        Me.TXTg1valory_max.Text = My.Settings.g1valory_max.ToString

        Me.TXTg2valorx_min.Text = My.Settings.g2valory_max.ToString
        Me.TXTg2valorx_max.Text = My.Settings.g2valory_min.ToString
        Me.TXTg2valory_min.Text = My.Settings.g2valorx_min.ToString
        Me.TXTg2valory_max.Text = My.Settings.g2valorx_max.ToString

        Me.TXTg1valorx_min.BackColor = Color.White
        Me.TXTg1valorx_max.BackColor = Color.White
        Me.TXTg1valory_min.BackColor = Color.White
        Me.TXTg1valory_max.BackColor = Color.White

        Me.TXTg2valorx_min.BackColor = Color.White
        Me.TXTg2valorx_max.BackColor = Color.White
        Me.TXTg2valory_min.BackColor = Color.White
        Me.TXTg2valory_max.BackColor = Color.White

        'tipo de graficas que se pueden usar!
        With LISTgraficas.Items
            .Add(DataVisualization.Charting.SeriesChartType.Area.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.Bar.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.BoxPlot.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.Bubble.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.Candlestick.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.Column.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.Doughnut.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.ErrorBar.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.FastLine.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.FastPoint.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.Funnel.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.PointAndFigure.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.Polar.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.Pyramid.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.Radar.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.Range.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.RangeBar.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.RangeColumn.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.Renko.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.Spline.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.SplineArea.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.SplineRange.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.StackedArea.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.StackedArea100.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.StackedBar.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.StackedBar100.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.StackedColumn.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.StackedColumn100.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.StepLine.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.Stock.ToString)
            .Add(DataVisualization.Charting.SeriesChartType.ThreeLineBreak.ToString)
        End With
        


        If Interfaz_USB.Conexion.ConexionMysqlEstado = Data.ConnectionState.Open Then
            Dim op As MySql.Data.MySqlClient.MySqlDataReader = Interfaz_USB.Conexion.DDL("show databases;")
            If Not op Is Nothing Then
                While op.Read()
                    Me.ComboBases.Items.Add(op("database"))
                End While
            End If
        End If
    End Sub

    Private Sub BTTguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTTguardar.Click
        Interfaz_USB.Conexion.DesconexionMySQL()

        My.Settings.usuario = Me.TXTusuario.Text
        My.Settings.password = Me.TXTpassword.Text
        My.Settings.server = Me.TXTservidor.Text
        My.Settings.basedatos = Me.ComboBases.Text
        My.Settings.port = Me.TXTpuerto.Text
        My.Settings.Save()

        For indice As Integer = 1 To 3
            Interfaz_USB.Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> Abortada la conexion con el servidor de base de datos;")
            Interfaz_USB.Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> Restableciendo conexion " & indice & "...")
            Interfaz_USB.Conexion.ConexionMySQL(Interfaz_USB.Debug, My.Settings.server, My.Settings.port, My.Settings.usuario, My.Settings.password, My.Settings.basedatos)
            Threading.Thread.Sleep(100)
            If Interfaz_USB.Conexion.ConexionMysqlEstado = System.Data.ConnectionState.Open Then
                Interfaz_USB.Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> Restablecida la conexion con el servidor de DB;")
                Exit Sub
            End If
        Next

        If Interfaz_USB.Conexion.ConexionMysqlEstado = System.Data.ConnectionState.Closed Then
            Interfaz_USB.Debug.Items.Add("[" & DateTime.Now.ToLongTimeString & "] >> No se pudo establecer conexion con el servidor de DB;")
        End If
    End Sub

    Private Sub Validar()
        For Each t As TextBox In Me.Controls 'valida que los campos de texto contengan un valor diferente de nada.
            If t.Text = Nothing Then
                MsgBox("Por favor digite un valor entre 0 y 8000 (sugerido 5000)", MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
                t.BackColor = Color.Red
                t.Focus()
                Exit Sub
            End If
        Next

        If Not Me.TXTg1valorx_min.Text = Nothing And Not Me.TXTg1valorx_max.Text = Nothing And Not Me.TXTg1valory_min.Text = Nothing And Not Me.TXTg1valory_max.Text = Nothing Then
            For Each t As TextBox In Me.Controls 'valida que los campos de texto contengan un valor mayor que 0.
                If Val(t.Text) < 0 Then
                    MsgBox("El valor debe ser mayor a 0.", MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
                    t.Focus()
                End If
            Next

            For Each t As TextBox In Me.Controls 'valida que los campos de texto contengan un valor entre 0 y 8000.
                If Val(t.Text) > 8000 Then
                    MsgBox("El valor debe estar comprendido entre 0 y 8000 (sugerido 5000).", MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
                    t.BackColor = Color.Red
                    t.Focus()
                    Exit Sub
                Else
                    t.BackColor = Color.White
                End If
            Next

            toSave = True
            Exit Sub 'cumplio con todos los requerimientos y se le da la posibilidad de guardar cambios!
        Else
            Validar()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttGuardar2.Click
        If toSave = vbTrue Then
            My.Settings.g1valorx_max = Val(Me.TXTg1valorx_min.Text)
            My.Settings.g1valorx_min = Val(Me.TXTg1valorx_max.Text)
            My.Settings.g1valory_max = Val(Me.TXTg1valorx_min.Text)
            My.Settings.g1valory_min = Val(Me.TXTg1valorx_max.Text)


            My.Settings.g2valorx_max = Val(Me.TXTg2valorx_min.Text)
            My.Settings.g2valorx_min = Val(Me.TXTg2valorx_max.Text)
            My.Settings.g2valory_max = Val(Me.TXTg2valorx_min.Text)
            My.Settings.g2valory_min = Val(Me.TXTg2valorx_max.Text)
            My.Settings.Save()
            toSave = False
        ElseIf toSave = vbFalse Then
            MsgBox("Debe Asignar correctamente los valores antes.", MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub TXTg1valorx_min_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTg1valorx_min.Validating
        Try
            Validar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXTg2valorx_max_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTg2valorx_max.Validating
        Try
            Validar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXTg2valory_min_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTg2valory_min.Validating
        Try
            Validar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXTg1valory_max_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTg1valory_max.Validating
        Try
            Validar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXTg1valorx_max_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTg1valorx_max.Validating
        Try
            Validar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXTg1valory_min_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTg1valory_min.Validating
        Try
            Validar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXTg2valory_max_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTg2valory_max.Validating
        Try
            Validar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTTguardartipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTTguardartipo.Click
        My.Settings.tipo_grafica = ListaGraficas(Interfaz_USB.Chart.Series(0))
        ListaGraficas(Interfaz_USB.Chart2.Series(0))
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Function ListaGraficas(ByVal obj As Object) As DataVisualization.Charting.SeriesChartType
        With obj
            Select Case LISTgraficas.SelectedIndex
                Case 1 : .ChartType = DataVisualization.Charting.SeriesChartType.Area
                Case 2 : .ChartType = DataVisualization.Charting.SeriesChartType.Bar
                Case 3 : .ChartType = DataVisualization.Charting.SeriesChartType.BoxPlot
                Case 4 : .ChartType = DataVisualization.Charting.SeriesChartType.Bubble
                Case 5 : .ChartType = DataVisualization.Charting.SeriesChartType.Candlestick
                Case 6 : .ChartType = DataVisualization.Charting.SeriesChartType.Column
                Case 7 : .ChartType = DataVisualization.Charting.SeriesChartType.Doughnut
                Case 8 : .ChartType = DataVisualization.Charting.SeriesChartType.ErrorBar
                Case 9 : .ChartType = DataVisualization.Charting.SeriesChartType.FastLine
                Case 10 : .ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
                Case 11 : .ChartType = DataVisualization.Charting.SeriesChartType.Funnel
                Case 12 : .ChartType = DataVisualization.Charting.SeriesChartType.Kagi
                Case 13 : .ChartType = DataVisualization.Charting.SeriesChartType.Line
                Case 14 : .ChartType = DataVisualization.Charting.SeriesChartType.Pie
                Case 15 : .ChartType = DataVisualization.Charting.SeriesChartType.Point
                Case 16 : .ChartType = DataVisualization.Charting.SeriesChartType.PointAndFigure
                Case 17 : .ChartType = DataVisualization.Charting.SeriesChartType.Polar
                Case 18 : .ChartType = DataVisualization.Charting.SeriesChartType.Pyramid
                Case 19 : .ChartType = DataVisualization.Charting.SeriesChartType.Radar
                Case 20 : .ChartType = DataVisualization.Charting.SeriesChartType.Range
                Case 21 : .ChartType = DataVisualization.Charting.SeriesChartType.RangeBar
                Case 22 : .ChartType = DataVisualization.Charting.SeriesChartType.RangeColumn
                Case 23 : .ChartType = DataVisualization.Charting.SeriesChartType.Renko
                Case 24 : .ChartType = DataVisualization.Charting.SeriesChartType.Spline
                Case 25 : .ChartType = DataVisualization.Charting.SeriesChartType.SplineArea
                Case 26 : .ChartType = DataVisualization.Charting.SeriesChartType.SplineRange
                Case 27 : .ChartType = DataVisualization.Charting.SeriesChartType.StackedArea
                Case 28 : .ChartType = DataVisualization.Charting.SeriesChartType.StackedArea100
                Case 29 : .ChartType = DataVisualization.Charting.SeriesChartType.StackedBar
                Case 30 : .ChartType = DataVisualization.Charting.SeriesChartType.StackedBar100
                Case 31 : .ChartType = DataVisualization.Charting.SeriesChartType.StackedColumn
                Case 32 : .ChartType = DataVisualization.Charting.SeriesChartType.StackedColumn100
                Case 33 : .ChartType = DataVisualization.Charting.SeriesChartType.StepLine
                Case 34 : .ChartType = DataVisualization.Charting.SeriesChartType.Stock
                Case 35 : .ChartType = DataVisualization.Charting.SeriesChartType.ThreeLineBreak
            End Select
            Return .chartType
        End With
    End Function
End Class