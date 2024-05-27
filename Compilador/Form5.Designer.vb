<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCaracteres = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtOperadores = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtOperandos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtOperaciones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.dkrIzqueirdo = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.PictureBox()
        Me.btnLimpiar = New System.Windows.Forms.PictureBox()
        Me.btnCompilar = New System.Windows.Forms.PictureBox()
        Me.btnAnalizr = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.PictureBox()
        Me.btnNuevoInput = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarCompiladorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompilarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtNLineas = New System.Windows.Forms.Label()
        Me.btnErrores = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.btnProcesos = New System.Windows.Forms.PictureBox()
        Me.gpxError = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblErrorTemp = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.dkrIzqueirdo.SuspendLayout()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCompilar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAnalizr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNuevoInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.btnErrores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnProcesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxError.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtCaracteres)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(56, 366)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 265)
        Me.Panel1.TabIndex = 5
        '
        'txtCaracteres
        '
        Me.txtCaracteres.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.txtCaracteres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCaracteres.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaracteres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.txtCaracteres.Location = New System.Drawing.Point(7, 30)
        Me.txtCaracteres.Margin = New System.Windows.Forms.Padding(20)
        Me.txtCaracteres.Multiline = True
        Me.txtCaracteres.Name = "txtCaracteres"
        Me.txtCaracteres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCaracteres.Size = New System.Drawing.Size(208, 235)
        Me.txtCaracteres.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(714, 98)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(718, 95)
        Me.Panel4.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 22)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Label5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Caracteres"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtOperadores)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(498, 366)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(215, 265)
        Me.Panel2.TabIndex = 6
        '
        'txtOperadores
        '
        Me.txtOperadores.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.txtOperadores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOperadores.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperadores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.txtOperadores.Location = New System.Drawing.Point(0, 30)
        Me.txtOperadores.Margin = New System.Windows.Forms.Padding(20)
        Me.txtOperadores.Multiline = True
        Me.txtOperadores.Name = "txtOperadores"
        Me.txtOperadores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOperadores.Size = New System.Drawing.Size(208, 235)
        Me.txtOperadores.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Operadores"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtOperandos)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(277, 366)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(215, 265)
        Me.Panel3.TabIndex = 6
        '
        'txtOperandos
        '
        Me.txtOperandos.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.txtOperandos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOperandos.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperandos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.txtOperandos.Location = New System.Drawing.Point(7, 30)
        Me.txtOperandos.Margin = New System.Windows.Forms.Padding(20)
        Me.txtOperandos.Multiline = True
        Me.txtOperandos.Name = "txtOperandos"
        Me.txtOperandos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOperandos.Size = New System.Drawing.Size(208, 235)
        Me.txtOperandos.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Operandos"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtOperaciones)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(719, 366)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(465, 265)
        Me.Panel5.TabIndex = 7
        '
        'txtOperaciones
        '
        Me.txtOperaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.txtOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOperaciones.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.txtOperaciones.Location = New System.Drawing.Point(7, 31)
        Me.txtOperaciones.Margin = New System.Windows.Forms.Padding(20)
        Me.txtOperaciones.Multiline = True
        Me.txtOperaciones.Name = "txtOperaciones"
        Me.txtOperaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOperaciones.Size = New System.Drawing.Size(458, 235)
        Me.txtOperaciones.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Opereaciones"
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInput.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.txtInput.Location = New System.Drawing.Point(63, 38)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(90)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInput.Size = New System.Drawing.Size(1121, 318)
        Me.txtInput.TabIndex = 10
        Me.txtInput.Text = "|| Comienza por escribir ... ||"
        '
        'dkrIzqueirdo
        '
        Me.dkrIzqueirdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.dkrIzqueirdo.Controls.Add(Me.btnSalir)
        Me.dkrIzqueirdo.Controls.Add(Me.btnLimpiar)
        Me.dkrIzqueirdo.Controls.Add(Me.btnCompilar)
        Me.dkrIzqueirdo.Controls.Add(Me.btnAnalizr)
        Me.dkrIzqueirdo.Controls.Add(Me.btnGuardar)
        Me.dkrIzqueirdo.Controls.Add(Me.btnNuevoInput)
        Me.dkrIzqueirdo.Controls.Add(Me.PictureBox1)
        Me.dkrIzqueirdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.dkrIzqueirdo.Location = New System.Drawing.Point(0, 0)
        Me.dkrIzqueirdo.Name = "dkrIzqueirdo"
        Me.dkrIzqueirdo.Size = New System.Drawing.Size(49, 661)
        Me.dkrIzqueirdo.TabIndex = 11
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(3, 615)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(43, 43)
        Me.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.Location = New System.Drawing.Point(3, 248)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(43, 43)
        Me.btnLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnLimpiar.TabIndex = 18
        Me.btnLimpiar.TabStop = False
        '
        'btnCompilar
        '
        Me.btnCompilar.Image = CType(resources.GetObject("btnCompilar.Image"), System.Drawing.Image)
        Me.btnCompilar.Location = New System.Drawing.Point(3, 199)
        Me.btnCompilar.Name = "btnCompilar"
        Me.btnCompilar.Size = New System.Drawing.Size(43, 43)
        Me.btnCompilar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCompilar.TabIndex = 17
        Me.btnCompilar.TabStop = False
        '
        'btnAnalizr
        '
        Me.btnAnalizr.Image = CType(resources.GetObject("btnAnalizr.Image"), System.Drawing.Image)
        Me.btnAnalizr.Location = New System.Drawing.Point(3, 150)
        Me.btnAnalizr.Name = "btnAnalizr"
        Me.btnAnalizr.Size = New System.Drawing.Size(43, 43)
        Me.btnAnalizr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAnalizr.TabIndex = 16
        Me.btnAnalizr.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(3, 101)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(43, 43)
        Me.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.TabStop = False
        '
        'btnNuevoInput
        '
        Me.btnNuevoInput.Image = CType(resources.GetObject("btnNuevoInput.Image"), System.Drawing.Image)
        Me.btnNuevoInput.Location = New System.Drawing.Point(3, 52)
        Me.btnNuevoInput.Name = "btnNuevoInput"
        Me.btnNuevoInput.Size = New System.Drawing.Size(43, 43)
        Me.btnNuevoInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnNuevoInput.TabIndex = 14
        Me.btnNuevoInput.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Gadugi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 5)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(49, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1135, 27)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStripTop"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarCompiladorToolStripMenuItem, Me.RegresarToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(58, 23)
        Me.OpcionesToolStripMenuItem.Text = "Menú"
        '
        'IniciarCompiladorToolStripMenuItem
        '
        Me.IniciarCompiladorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IniciarCompiladorToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.IniciarCompiladorToolStripMenuItem.Name = "IniciarCompiladorToolStripMenuItem"
        Me.IniciarCompiladorToolStripMenuItem.Size = New System.Drawing.Size(136, 24)
        Me.IniciarCompiladorToolStripMenuItem.Text = "Limpiar"
        '
        'RegresarToolStripMenuItem
        '
        Me.RegresarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.RegresarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RegresarToolStripMenuItem.Name = "RegresarToolStripMenuItem"
        Me.RegresarToolStripMenuItem.Size = New System.Drawing.Size(136, 24)
        Me.RegresarToolStripMenuItem.Text = "Regresar"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.CompilarToolStripMenuItem})
        Me.AyudaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(74, 23)
        Me.AyudaToolStripMenuItem.Text = "Ejecutar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(139, 24)
        Me.SalirToolStripMenuItem.Text = "Analizar"
        '
        'CompilarToolStripMenuItem
        '
        Me.CompilarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.CompilarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CompilarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CompilarToolStripMenuItem.Name = "CompilarToolStripMenuItem"
        Me.CompilarToolStripMenuItem.Size = New System.Drawing.Size(139, 24)
        Me.CompilarToolStripMenuItem.Text = "Compilar"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel6.Controls.Add(Me.txtNLineas)
        Me.Panel6.Controls.Add(Me.btnErrores)
        Me.Panel6.Controls.Add(Me.PictureBox7)
        Me.Panel6.Controls.Add(Me.PictureBox8)
        Me.Panel6.Controls.Add(Me.PictureBox9)
        Me.Panel6.Controls.Add(Me.PictureBox10)
        Me.Panel6.Controls.Add(Me.PictureBox11)
        Me.Panel6.Controls.Add(Me.btnProcesos)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(49, 637)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1135, 24)
        Me.Panel6.TabIndex = 13
        '
        'txtNLineas
        '
        Me.txtNLineas.AutoSize = True
        Me.txtNLineas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.txtNLineas.Location = New System.Drawing.Point(11, 8)
        Me.txtNLineas.Name = "txtNLineas"
        Me.txtNLineas.Size = New System.Drawing.Size(0, 13)
        Me.txtNLineas.TabIndex = 10
        Me.txtNLineas.UseMnemonic = False
        '
        'btnErrores
        '
        Me.btnErrores.Image = CType(resources.GetObject("btnErrores.Image"), System.Drawing.Image)
        Me.btnErrores.Location = New System.Drawing.Point(1086, 3)
        Me.btnErrores.Name = "btnErrores"
        Me.btnErrores.Size = New System.Drawing.Size(20, 20)
        Me.btnErrores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnErrores.TabIndex = 19
        Me.btnErrores.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(3, 248)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(43, 43)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 18
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(3, 199)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(43, 43)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 17
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(3, 150)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(43, 43)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 16
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(3, 101)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(43, 43)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 15
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(3, 52)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(43, 43)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 14
        Me.PictureBox11.TabStop = False
        '
        'btnProcesos
        '
        Me.btnProcesos.Image = CType(resources.GetObject("btnProcesos.Image"), System.Drawing.Image)
        Me.btnProcesos.Location = New System.Drawing.Point(1112, 3)
        Me.btnProcesos.Name = "btnProcesos"
        Me.btnProcesos.Size = New System.Drawing.Size(20, 20)
        Me.btnProcesos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnProcesos.TabIndex = 13
        Me.btnProcesos.TabStop = False
        '
        'gpxError
        '
        Me.gpxError.Controls.Add(Me.Label6)
        Me.gpxError.Controls.Add(Me.lblErrorTemp)
        Me.gpxError.Location = New System.Drawing.Point(794, 424)
        Me.gpxError.Name = "gpxError"
        Me.gpxError.Size = New System.Drawing.Size(361, 210)
        Me.gpxError.TabIndex = 14
        Me.gpxError.TabStop = False
        Me.gpxError.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(334, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "x"
        '
        'lblErrorTemp
        '
        Me.lblErrorTemp.AutoSize = True
        Me.lblErrorTemp.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorTemp.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblErrorTemp.Location = New System.Drawing.Point(7, 21)
        Me.lblErrorTemp.Name = "lblErrorTemp"
        Me.lblErrorTemp.Size = New System.Drawing.Size(51, 19)
        Me.lblErrorTemp.TabIndex = 0
        Me.lblErrorTemp.Text = "Error: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(1159, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 21)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "x"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gpxError)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dkrIzqueirdo)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compilador"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.dkrIzqueirdo.ResumeLayout(False)
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCompilar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAnalizr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNuevoInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.btnErrores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnProcesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxError.ResumeLayout(False)
        Me.gpxError.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtCaracteres As TextBox
    Friend WithEvents txtOperadores As TextBox
    Friend WithEvents txtOperandos As TextBox
    Friend WithEvents txtOperaciones As TextBox
    Friend WithEvents dkrIzqueirdo As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IniciarCompiladorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegresarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompilarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLimpiar As PictureBox
    Friend WithEvents btnCompilar As PictureBox
    Friend WithEvents btnAnalizr As PictureBox
    Friend WithEvents btnGuardar As PictureBox
    Friend WithEvents btnNuevoInput As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnErrores As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents btnProcesos As PictureBox
    Friend WithEvents btnSalir As PictureBox
    Friend WithEvents txtNLineas As Label
    Friend WithEvents gpxError As GroupBox
    Friend WithEvents lblErrorTemp As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
