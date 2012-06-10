<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuraciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTTguardar = New System.Windows.Forms.Button()
        Me.ComboBases = New System.Windows.Forms.ComboBox()
        Me.TXTpuerto = New System.Windows.Forms.TextBox()
        Me.TXTpassword = New System.Windows.Forms.TextBox()
        Me.TXTusuario = New System.Windows.Forms.TextBox()
        Me.TXTservidor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXTg2valory_min = New System.Windows.Forms.TextBox()
        Me.TXTg2valorx_min = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTg2valory_max = New System.Windows.Forms.TextBox()
        Me.TXTg2valorx_max = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BttGuardar2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTg1valory_min = New System.Windows.Forms.TextBox()
        Me.TXTg1valorx_min = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTg1valory_max = New System.Windows.Forms.TextBox()
        Me.TXTg1valorx_max = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LISTgraficas = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BTTguardartipo = New System.Windows.Forms.Button()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTTguardar
        '
        Me.BTTguardar.Location = New System.Drawing.Point(143, 169)
        Me.BTTguardar.Name = "BTTguardar"
        Me.BTTguardar.Size = New System.Drawing.Size(75, 23)
        Me.BTTguardar.TabIndex = 3
        Me.BTTguardar.Text = "Guardar"
        Me.BTTguardar.UseVisualStyleBackColor = True
        '
        'ComboBases
        '
        Me.ComboBases.FormattingEnabled = True
        Me.ComboBases.Location = New System.Drawing.Point(99, 22)
        Me.ComboBases.Name = "ComboBases"
        Me.ComboBases.Size = New System.Drawing.Size(111, 21)
        Me.ComboBases.TabIndex = 2
        '
        'TXTpuerto
        '
        Me.TXTpuerto.Location = New System.Drawing.Point(99, 127)
        Me.TXTpuerto.MaxLength = 6
        Me.TXTpuerto.Name = "TXTpuerto"
        Me.TXTpuerto.Size = New System.Drawing.Size(111, 20)
        Me.TXTpuerto.TabIndex = 1
        Me.TXTpuerto.Text = "3306"
        Me.TXTpuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTpassword
        '
        Me.TXTpassword.Location = New System.Drawing.Point(99, 101)
        Me.TXTpassword.MaxLength = 15
        Me.TXTpassword.Name = "TXTpassword"
        Me.TXTpassword.Size = New System.Drawing.Size(111, 20)
        Me.TXTpassword.TabIndex = 1
        Me.TXTpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXTpassword.UseSystemPasswordChar = True
        '
        'TXTusuario
        '
        Me.TXTusuario.Location = New System.Drawing.Point(99, 75)
        Me.TXTusuario.MaxLength = 15
        Me.TXTusuario.Name = "TXTusuario"
        Me.TXTusuario.Size = New System.Drawing.Size(111, 20)
        Me.TXTusuario.TabIndex = 1
        Me.TXTusuario.Text = "USIBA"
        Me.TXTusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTservidor
        '
        Me.TXTservidor.Location = New System.Drawing.Point(99, 49)
        Me.TXTservidor.MaxLength = 15
        Me.TXTservidor.Name = "TXTservidor"
        Me.TXTservidor.Size = New System.Drawing.Size(111, 20)
        Me.TXTservidor.TabIndex = 1
        Me.TXTservidor.Text = "Localhost"
        Me.TXTservidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Puerto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Servidor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Base de Datos:"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(247, 234)
        Me.TabControl.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.BTTguardar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(239, 208)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "MySQL"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TXTservidor)
        Me.GroupBox3.Controls.Add(Me.TXTusuario)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.ComboBases)
        Me.GroupBox3.Controls.Add(Me.TXTpassword)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TXTpuerto)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 157)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Conexion"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.BttGuardar2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(239, 208)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Limites de Graficas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXTg2valory_min)
        Me.GroupBox2.Controls.Add(Me.TXTg2valorx_min)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TXTg2valory_max)
        Me.GroupBox2.Controls.Add(Me.TXTg2valorx_max)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 77)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grafica 2"
        '
        'TXTg2valory_min
        '
        Me.TXTg2valory_min.BackColor = System.Drawing.Color.White
        Me.TXTg2valory_min.Location = New System.Drawing.Point(157, 19)
        Me.TXTg2valory_min.MaxLength = 5
        Me.TXTg2valory_min.Name = "TXTg2valory_min"
        Me.TXTg2valory_min.Size = New System.Drawing.Size(54, 20)
        Me.TXTg2valory_min.TabIndex = 0
        Me.TXTg2valory_min.Text = "0"
        Me.TXTg2valory_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTg2valorx_min
        '
        Me.TXTg2valorx_min.BackColor = System.Drawing.Color.White
        Me.TXTg2valorx_min.Location = New System.Drawing.Point(51, 19)
        Me.TXTg2valorx_min.MaxLength = 5
        Me.TXTg2valorx_min.Name = "TXTg2valorx_min"
        Me.TXTg2valorx_min.Size = New System.Drawing.Size(54, 20)
        Me.TXTg2valorx_min.TabIndex = 0
        Me.TXTg2valorx_min.Text = "0"
        Me.TXTg2valorx_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(114, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Max-y:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Max-x:"
        '
        'TXTg2valory_max
        '
        Me.TXTg2valory_max.Location = New System.Drawing.Point(157, 45)
        Me.TXTg2valory_max.MaxLength = 5
        Me.TXTg2valory_max.Name = "TXTg2valory_max"
        Me.TXTg2valory_max.Size = New System.Drawing.Size(54, 20)
        Me.TXTg2valory_max.TabIndex = 4
        Me.TXTg2valory_max.Text = "5000"
        Me.TXTg2valory_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTg2valorx_max
        '
        Me.TXTg2valorx_max.Location = New System.Drawing.Point(51, 45)
        Me.TXTg2valorx_max.MaxLength = 5
        Me.TXTg2valorx_max.Name = "TXTg2valorx_max"
        Me.TXTg2valorx_max.Size = New System.Drawing.Size(54, 20)
        Me.TXTg2valorx_max.TabIndex = 4
        Me.TXTg2valorx_max.Text = "5000"
        Me.TXTg2valorx_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(114, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Min-y:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Min-x:"
        '
        'BttGuardar2
        '
        Me.BttGuardar2.Location = New System.Drawing.Point(144, 177)
        Me.BttGuardar2.Name = "BttGuardar2"
        Me.BttGuardar2.Size = New System.Drawing.Size(75, 23)
        Me.BttGuardar2.TabIndex = 5
        Me.BttGuardar2.Text = "Guardar"
        Me.BttGuardar2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTg1valory_min)
        Me.GroupBox1.Controls.Add(Me.TXTg1valorx_min)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXTg1valory_max)
        Me.GroupBox1.Controls.Add(Me.TXTg1valorx_max)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 77)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grafica 1"
        '
        'TXTg1valory_min
        '
        Me.TXTg1valory_min.BackColor = System.Drawing.Color.White
        Me.TXTg1valory_min.Location = New System.Drawing.Point(157, 19)
        Me.TXTg1valory_min.MaxLength = 5
        Me.TXTg1valory_min.Name = "TXTg1valory_min"
        Me.TXTg1valory_min.Size = New System.Drawing.Size(54, 20)
        Me.TXTg1valory_min.TabIndex = 0
        Me.TXTg1valory_min.Text = "0"
        Me.TXTg1valory_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTg1valorx_min
        '
        Me.TXTg1valorx_min.BackColor = System.Drawing.Color.White
        Me.TXTg1valorx_min.Location = New System.Drawing.Point(51, 19)
        Me.TXTg1valorx_min.MaxLength = 5
        Me.TXTg1valorx_min.Name = "TXTg1valorx_min"
        Me.TXTg1valorx_min.Size = New System.Drawing.Size(54, 20)
        Me.TXTg1valorx_min.TabIndex = 0
        Me.TXTg1valorx_min.Text = "0"
        Me.TXTg1valorx_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(114, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Max-y:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Max-x:"
        '
        'TXTg1valory_max
        '
        Me.TXTg1valory_max.Location = New System.Drawing.Point(157, 45)
        Me.TXTg1valory_max.MaxLength = 5
        Me.TXTg1valory_max.Name = "TXTg1valory_max"
        Me.TXTg1valory_max.Size = New System.Drawing.Size(54, 20)
        Me.TXTg1valory_max.TabIndex = 4
        Me.TXTg1valory_max.Text = "5000"
        Me.TXTg1valory_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTg1valorx_max
        '
        Me.TXTg1valorx_max.Location = New System.Drawing.Point(51, 45)
        Me.TXTg1valorx_max.MaxLength = 5
        Me.TXTg1valorx_max.Name = "TXTg1valorx_max"
        Me.TXTg1valorx_max.Size = New System.Drawing.Size(54, 20)
        Me.TXTg1valorx_max.TabIndex = 4
        Me.TXTg1valorx_max.Text = "5000"
        Me.TXTg1valorx_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(114, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Min-y:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Min-x:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.BTTguardartipo)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(239, 208)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tipo de Graficas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LISTgraficas)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(225, 165)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo"
        '
        'LISTgraficas
        '
        Me.LISTgraficas.FormattingEnabled = True
        Me.LISTgraficas.Location = New System.Drawing.Point(6, 42)
        Me.LISTgraficas.Name = "LISTgraficas"
        Me.LISTgraficas.Size = New System.Drawing.Size(213, 108)
        Me.LISTgraficas.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Nombre:"
        '
        'BTTguardartipo
        '
        Me.BTTguardartipo.Location = New System.Drawing.Point(156, 177)
        Me.BTTguardartipo.Name = "BTTguardartipo"
        Me.BTTguardartipo.Size = New System.Drawing.Size(75, 23)
        Me.BTTguardartipo.TabIndex = 0
        Me.BTTguardartipo.Text = "Guardar"
        Me.BTTguardartipo.UseVisualStyleBackColor = True
        '
        'Configuraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 234)
        Me.Controls.Add(Me.TabControl)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(218, 266)
        Me.Name = "Configuraciones"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuraciones"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TXTpuerto As System.Windows.Forms.TextBox
    Friend WithEvents TXTpassword As System.Windows.Forms.TextBox
    Friend WithEvents TXTusuario As System.Windows.Forms.TextBox
    Friend WithEvents TXTservidor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBases As System.Windows.Forms.ComboBox
    Friend WithEvents BTTguardar As System.Windows.Forms.Button
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTg1valorx_max As System.Windows.Forms.TextBox
    Friend WithEvents TXTg1valorx_min As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BttGuardar2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTg2valorx_min As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTg2valorx_max As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTg2valory_min As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TXTg2valory_max As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TXTg1valory_min As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXTg1valory_max As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BTTguardartipo As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LISTgraficas As System.Windows.Forms.ListBox
End Class
