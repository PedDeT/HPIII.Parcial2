<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administracion
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Administracion))
        MenuStrip1 = New MenuStrip()
        AdministracionToolStripMenuItem = New ToolStripMenuItem()
        SoporteToolStripMenuItem = New ToolStripMenuItem()
        AgendarToolStripMenuItem = New ToolStripMenuItem()
        ActualizarToolStripMenuItem = New ToolStripMenuItem()
        CerrarToolStripMenuItem = New ToolStripMenuItem()
        EquiposToolStripMenuItem = New ToolStripMenuItem()
        CrearToolStripMenuItem = New ToolStripMenuItem()
        ItinerarioToolStripMenuItem = New ToolStripMenuItem()
        ReporteToolStripMenuItem = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        ManualDeUsuarioToolStripMenuItem = New ToolStripMenuItem()
        VersionToolStripMenuItem = New ToolStripMenuItem()
        CerrarToolStripMenuItem1 = New ToolStripMenuItem()
        AdministracionCrearSoporte = New Panel()
        Label5 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        Label4 = New Label()
        AdministracionBtnCrearSoporte = New Button()
        Label3 = New Label()
        AdministracionTBCostoInicial = New TextBox()
        Label8 = New Label()
        AdministracionMCFinal = New MonthCalendar()
        Label7 = New Label()
        AdministracionMCInicio = New MonthCalendar()
        AdministracionTBTipoSoporte = New ComboBox()
        AdministracionCBEquipo = New ComboBox()
        AdministracionTBCliente = New TextBox()
        Label6 = New Label()
        AdministracionActualizarSoporte = New Panel()
        AdministracionTBComentario = New TextBox()
        AdministracionNDActualizarSoporte = New NumericUpDown()
        Label9 = New Label()
        Label10 = New Label()
        AdministracionBtnActualizarSoporte = New Button()
        Label11 = New Label()
        AdministracionCBActualizarSoporte = New ComboBox()
        Label12 = New Label()
        AdministracionCerrarSoporte = New Panel()
        Panel4 = New Panel()
        Label20 = New Label()
        DGSeleccionarSoporte = New DataGridView()
        Label13 = New Label()
        AdministracionCBCerrarSoporte = New ComboBox()
        AdministracionBtnCerrarSoporte = New Button()
        AdministracionReporte = New Panel()
        Panel3 = New Panel()
        Label31 = New Label()
        AdministracionBtnExportarReporte = New Button()
        AdministracionDGReporte = New DataGridView()
        AdministracionCrearEquipo = New Panel()
        Label1 = New Label()
        Panel1 = New Panel()
        Label15 = New Label()
        AdministracionTBContrasenaEquipo = New TextBox()
        Label18 = New Label()
        AdministracionTBUsuarioEquipo = New TextBox()
        Label17 = New Label()
        Label16 = New Label()
        AdministracionTBNombreEquipo = New TextBox()
        AdministracionBtnCrearEquipo = New Button()
        AdministracionItinerario = New Panel()
        Panel5 = New Panel()
        Label32 = New Label()
        Label19 = New Label()
        AdministracionDGItinerario = New DataGridView()
        AdministracionManual = New Panel()
        Label27 = New Label()
        Label26 = New Label()
        Label25 = New Label()
        Label24 = New Label()
        Label23 = New Label()
        Label14 = New Label()
        Label22 = New Label()
        AdministracionVersion = New Panel()
        Label30 = New Label()
        Label29 = New Label()
        Label28 = New Label()
        Label21 = New Label()
        PictureBox1 = New PictureBox()
        Label33 = New Label()
        MenuStrip1.SuspendLayout()
        AdministracionCrearSoporte.SuspendLayout()
        Panel2.SuspendLayout()
        AdministracionActualizarSoporte.SuspendLayout()
        CType(AdministracionNDActualizarSoporte, ComponentModel.ISupportInitialize).BeginInit()
        AdministracionCerrarSoporte.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DGSeleccionarSoporte, ComponentModel.ISupportInitialize).BeginInit()
        AdministracionReporte.SuspendLayout()
        Panel3.SuspendLayout()
        CType(AdministracionDGReporte, ComponentModel.ISupportInitialize).BeginInit()
        AdministracionCrearEquipo.SuspendLayout()
        Panel1.SuspendLayout()
        AdministracionItinerario.SuspendLayout()
        Panel5.SuspendLayout()
        CType(AdministracionDGItinerario, ComponentModel.ISupportInitialize).BeginInit()
        AdministracionManual.SuspendLayout()
        AdministracionVersion.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.RoyalBlue
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AdministracionToolStripMenuItem, ItinerarioToolStripMenuItem, ReporteToolStripMenuItem, AyudaToolStripMenuItem, CerrarToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1023, 35)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AdministracionToolStripMenuItem
        ' 
        AdministracionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SoporteToolStripMenuItem, EquiposToolStripMenuItem})
        AdministracionToolStripMenuItem.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point)
        AdministracionToolStripMenuItem.ForeColor = SystemColors.ControlLightLight
        AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        AdministracionToolStripMenuItem.Size = New Size(164, 31)
        AdministracionToolStripMenuItem.Text = "Administracion"
        ' 
        ' SoporteToolStripMenuItem
        ' 
        SoporteToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgendarToolStripMenuItem, ActualizarToolStripMenuItem, CerrarToolStripMenuItem})
        SoporteToolStripMenuItem.Name = "SoporteToolStripMenuItem"
        SoporteToolStripMenuItem.Size = New Size(170, 32)
        SoporteToolStripMenuItem.Text = "Soporte"
        ' 
        ' AgendarToolStripMenuItem
        ' 
        AgendarToolStripMenuItem.Name = "AgendarToolStripMenuItem"
        AgendarToolStripMenuItem.Size = New Size(188, 32)
        AgendarToolStripMenuItem.Text = "Agendar"
        ' 
        ' ActualizarToolStripMenuItem
        ' 
        ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        ActualizarToolStripMenuItem.Size = New Size(188, 32)
        ActualizarToolStripMenuItem.Text = "Actualizar"
        ' 
        ' CerrarToolStripMenuItem
        ' 
        CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        CerrarToolStripMenuItem.Size = New Size(188, 32)
        CerrarToolStripMenuItem.Text = "Cerrar"
        ' 
        ' EquiposToolStripMenuItem
        ' 
        EquiposToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CrearToolStripMenuItem})
        EquiposToolStripMenuItem.Name = "EquiposToolStripMenuItem"
        EquiposToolStripMenuItem.Size = New Size(170, 32)
        EquiposToolStripMenuItem.Text = "Equipos"
        ' 
        ' CrearToolStripMenuItem
        ' 
        CrearToolStripMenuItem.Name = "CrearToolStripMenuItem"
        CrearToolStripMenuItem.Size = New Size(147, 32)
        CrearToolStripMenuItem.Text = "Crear"
        ' 
        ' ItinerarioToolStripMenuItem
        ' 
        ItinerarioToolStripMenuItem.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ItinerarioToolStripMenuItem.ForeColor = SystemColors.ControlLightLight
        ItinerarioToolStripMenuItem.Name = "ItinerarioToolStripMenuItem"
        ItinerarioToolStripMenuItem.Size = New Size(109, 31)
        ItinerarioToolStripMenuItem.Text = "Itinerario"
        ' 
        ' ReporteToolStripMenuItem
        ' 
        ReporteToolStripMenuItem.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ReporteToolStripMenuItem.ForeColor = SystemColors.ControlLightLight
        ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        ReporteToolStripMenuItem.Size = New Size(97, 31)
        ReporteToolStripMenuItem.Text = "Reporte"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ManualDeUsuarioToolStripMenuItem, VersionToolStripMenuItem})
        AyudaToolStripMenuItem.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point)
        AyudaToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(84, 31)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' ManualDeUsuarioToolStripMenuItem
        ' 
        ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        ManualDeUsuarioToolStripMenuItem.Size = New Size(270, 32)
        ManualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario"
        ' 
        ' VersionToolStripMenuItem
        ' 
        VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        VersionToolStripMenuItem.Size = New Size(270, 32)
        VersionToolStripMenuItem.Text = "Version"
        ' 
        ' CerrarToolStripMenuItem1
        ' 
        CerrarToolStripMenuItem1.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CerrarToolStripMenuItem1.ForeColor = SystemColors.ControlLightLight
        CerrarToolStripMenuItem1.Name = "CerrarToolStripMenuItem1"
        CerrarToolStripMenuItem1.Size = New Size(147, 31)
        CerrarToolStripMenuItem1.Text = "Cerrar Sesión"
        ' 
        ' AdministracionCrearSoporte
        ' 
        AdministracionCrearSoporte.Controls.Add(Label5)
        AdministracionCrearSoporte.Controls.Add(Panel2)
        AdministracionCrearSoporte.Controls.Add(Label4)
        AdministracionCrearSoporte.Controls.Add(AdministracionBtnCrearSoporte)
        AdministracionCrearSoporte.Controls.Add(Label3)
        AdministracionCrearSoporte.Controls.Add(AdministracionTBCostoInicial)
        AdministracionCrearSoporte.Controls.Add(Label8)
        AdministracionCrearSoporte.Controls.Add(AdministracionMCFinal)
        AdministracionCrearSoporte.Controls.Add(Label7)
        AdministracionCrearSoporte.Controls.Add(AdministracionMCInicio)
        AdministracionCrearSoporte.Controls.Add(AdministracionTBTipoSoporte)
        AdministracionCrearSoporte.Controls.Add(AdministracionCBEquipo)
        AdministracionCrearSoporte.Controls.Add(AdministracionTBCliente)
        AdministracionCrearSoporte.Controls.Add(Label6)
        AdministracionCrearSoporte.Location = New Point(-4, 28)
        AdministracionCrearSoporte.Name = "AdministracionCrearSoporte"
        AdministracionCrearSoporte.Size = New Size(1027, 532)
        AdministracionCrearSoporte.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(275, 431)
        Label5.Name = "Label5"
        Label5.Size = New Size(157, 27)
        Label5.TabIndex = 3
        Label5.Text = "Tipo de Soporte"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.CornflowerBlue
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(4, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(224, 529)
        Panel2.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(36, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 74)
        Label2.TabIndex = 0
        Label2.Text = "Crear " & vbCrLf & "Soporte"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(275, 366)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 27)
        Label4.TabIndex = 2
        Label4.Text = "Equipo"
        ' 
        ' AdministracionBtnCrearSoporte
        ' 
        AdministracionBtnCrearSoporte.BackColor = Color.CornflowerBlue
        AdministracionBtnCrearSoporte.FlatAppearance.BorderSize = 0
        AdministracionBtnCrearSoporte.FlatStyle = FlatStyle.Flat
        AdministracionBtnCrearSoporte.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point)
        AdministracionBtnCrearSoporte.ForeColor = SystemColors.ControlLightLight
        AdministracionBtnCrearSoporte.Location = New Point(756, 419)
        AdministracionBtnCrearSoporte.Name = "AdministracionBtnCrearSoporte"
        AdministracionBtnCrearSoporte.Size = New Size(239, 46)
        AdministracionBtnCrearSoporte.TabIndex = 13
        AdministracionBtnCrearSoporte.Text = "Crear"
        AdministracionBtnCrearSoporte.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(275, 313)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 27)
        Label3.TabIndex = 1
        Label3.Text = "Cliente"
        ' 
        ' AdministracionTBCostoInicial
        ' 
        AdministracionTBCostoInicial.BackColor = SystemColors.ControlLightLight
        AdministracionTBCostoInicial.Location = New Point(819, 313)
        AdministracionTBCostoInicial.Name = "AdministracionTBCostoInicial"
        AdministracionTBCostoInicial.ReadOnly = True
        AdministracionTBCostoInicial.Size = New Size(151, 27)
        AdministracionTBCostoInicial.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(680, 313)
        Label8.Name = "Label8"
        Label8.Size = New Size(124, 27)
        Label8.TabIndex = 11
        Label8.Text = "Costo Inicial"
        ' 
        ' AdministracionMCFinal
        ' 
        AdministracionMCFinal.Location = New Point(677, 77)
        AdministracionMCFinal.Name = "AdministracionMCFinal"
        AdministracionMCFinal.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(756, 49)
        Label7.Name = "Label7"
        Label7.Size = New Size(148, 27)
        Label7.TabIndex = 9
        Label7.Text = "Fecha de Cierre"
        ' 
        ' AdministracionMCInicio
        ' 
        AdministracionMCInicio.Location = New Point(275, 77)
        AdministracionMCInicio.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        AdministracionMCInicio.Name = "AdministracionMCInicio"
        AdministracionMCInicio.TabIndex = 8
        ' 
        ' AdministracionTBTipoSoporte
        ' 
        AdministracionTBTipoSoporte.FormattingEnabled = True
        AdministracionTBTipoSoporte.Location = New Point(433, 431)
        AdministracionTBTipoSoporte.Name = "AdministracionTBTipoSoporte"
        AdministracionTBTipoSoporte.Size = New Size(206, 28)
        AdministracionTBTipoSoporte.TabIndex = 7
        ' 
        ' AdministracionCBEquipo
        ' 
        AdministracionCBEquipo.FormattingEnabled = True
        AdministracionCBEquipo.Location = New Point(433, 366)
        AdministracionCBEquipo.Name = "AdministracionCBEquipo"
        AdministracionCBEquipo.Size = New Size(206, 28)
        AdministracionCBEquipo.TabIndex = 6
        ' 
        ' AdministracionTBCliente
        ' 
        AdministracionTBCliente.Location = New Point(433, 313)
        AdministracionTBCliente.Name = "AdministracionTBCliente"
        AdministracionTBCliente.Size = New Size(206, 27)
        AdministracionTBCliente.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(342, 48)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 27)
        Label6.TabIndex = 4
        Label6.Text = "Fecha de Inicio"
        ' 
        ' AdministracionActualizarSoporte
        ' 
        AdministracionActualizarSoporte.Controls.Add(AdministracionTBComentario)
        AdministracionActualizarSoporte.Controls.Add(AdministracionNDActualizarSoporte)
        AdministracionActualizarSoporte.Controls.Add(Label9)
        AdministracionActualizarSoporte.Controls.Add(Label10)
        AdministracionActualizarSoporte.Controls.Add(AdministracionBtnActualizarSoporte)
        AdministracionActualizarSoporte.Controls.Add(Label11)
        AdministracionActualizarSoporte.Controls.Add(AdministracionCBActualizarSoporte)
        AdministracionActualizarSoporte.Controls.Add(Label12)
        AdministracionActualizarSoporte.Location = New Point(-1, 28)
        AdministracionActualizarSoporte.Name = "AdministracionActualizarSoporte"
        AdministracionActualizarSoporte.Size = New Size(1024, 532)
        AdministracionActualizarSoporte.TabIndex = 2
        ' 
        ' AdministracionTBComentario
        ' 
        AdministracionTBComentario.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        AdministracionTBComentario.Location = New Point(313, 235)
        AdministracionTBComentario.Multiline = True
        AdministracionTBComentario.Name = "AdministracionTBComentario"
        AdministracionTBComentario.Size = New Size(517, 139)
        AdministracionTBComentario.TabIndex = 20
        ' 
        ' AdministracionNDActualizarSoporte
        ' 
        AdministracionNDActualizarSoporte.DecimalPlaces = 2
        AdministracionNDActualizarSoporte.Location = New Point(313, 176)
        AdministracionNDActualizarSoporte.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        AdministracionNDActualizarSoporte.Name = "AdministracionNDActualizarSoporte"
        AdministracionNDActualizarSoporte.Size = New Size(234, 27)
        AdministracionNDActualizarSoporte.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(31, 244)
        Label9.Name = "Label9"
        Label9.Size = New Size(202, 27)
        Label9.TabIndex = 18
        Label9.Text = "Agregar Comentarios"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(29, 173)
        Label10.Name = "Label10"
        Label10.Size = New Size(230, 27)
        Label10.TabIndex = 17
        Label10.Text = "Agregar Costo Adicional"
        ' 
        ' AdministracionBtnActualizarSoporte
        ' 
        AdministracionBtnActualizarSoporte.BackColor = Color.RoyalBlue
        AdministracionBtnActualizarSoporte.FlatAppearance.BorderSize = 0
        AdministracionBtnActualizarSoporte.FlatStyle = FlatStyle.Flat
        AdministracionBtnActualizarSoporte.Font = New Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        AdministracionBtnActualizarSoporte.ForeColor = SystemColors.ControlLightLight
        AdministracionBtnActualizarSoporte.Location = New Point(774, 464)
        AdministracionBtnActualizarSoporte.Name = "AdministracionBtnActualizarSoporte"
        AdministracionBtnActualizarSoporte.Size = New Size(207, 53)
        AdministracionBtnActualizarSoporte.TabIndex = 16
        AdministracionBtnActualizarSoporte.Text = "Actualizar Soporte"
        AdministracionBtnActualizarSoporte.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(22, 110)
        Label11.Name = "Label11"
        Label11.Size = New Size(273, 27)
        Label11.TabIndex = 15
        Label11.Text = "Seleccionar Soporte en Curso"
        ' 
        ' AdministracionCBActualizarSoporte
        ' 
        AdministracionCBActualizarSoporte.Font = New Font("Segoe UI Variable Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        AdministracionCBActualizarSoporte.FormattingEnabled = True
        AdministracionCBActualizarSoporte.Location = New Point(313, 110)
        AdministracionCBActualizarSoporte.Name = "AdministracionCBActualizarSoporte"
        AdministracionCBActualizarSoporte.Size = New Size(234, 30)
        AdministracionCBActualizarSoporte.TabIndex = 14
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(23, 30)
        Label12.Name = "Label12"
        Label12.Size = New Size(214, 31)
        Label12.TabIndex = 13
        Label12.Text = "Actualizar Soporte"
        ' 
        ' AdministracionCerrarSoporte
        ' 
        AdministracionCerrarSoporte.BackColor = Color.Gainsboro
        AdministracionCerrarSoporte.Controls.Add(Panel4)
        AdministracionCerrarSoporte.Controls.Add(DGSeleccionarSoporte)
        AdministracionCerrarSoporte.Controls.Add(Label13)
        AdministracionCerrarSoporte.Controls.Add(AdministracionCBCerrarSoporte)
        AdministracionCerrarSoporte.Controls.Add(AdministracionBtnCerrarSoporte)
        AdministracionCerrarSoporte.Location = New Point(-1, 28)
        AdministracionCerrarSoporte.Name = "AdministracionCerrarSoporte"
        AdministracionCerrarSoporte.Size = New Size(1024, 532)
        AdministracionCerrarSoporte.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.CornflowerBlue
        Panel4.Controls.Add(Label20)
        Panel4.Location = New Point(1, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(224, 532)
        Panel4.TabIndex = 16
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.ForeColor = SystemColors.ControlLightLight
        Label20.Location = New Point(47, 55)
        Label20.Name = "Label20"
        Label20.Size = New Size(141, 74)
        Label20.TabIndex = 0
        Label20.Text = "CERRAR " & vbCrLf & "SOPORTE" & vbCrLf
        ' 
        ' DGSeleccionarSoporte
        ' 
        DGSeleccionarSoporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGSeleccionarSoporte.Location = New Point(245, 99)
        DGSeleccionarSoporte.Name = "DGSeleccionarSoporte"
        DGSeleccionarSoporte.ReadOnly = True
        DGSeleccionarSoporte.RowHeadersWidth = 51
        DGSeleccionarSoporte.RowTemplate.Height = 29
        DGSeleccionarSoporte.Size = New Size(747, 275)
        DGSeleccionarSoporte.TabIndex = 5
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(243, 52)
        Label13.Name = "Label13"
        Label13.Size = New Size(230, 31)
        Label13.TabIndex = 0
        Label13.Text = "Seleccionar Soporte"
        ' 
        ' AdministracionCBCerrarSoporte
        ' 
        AdministracionCBCerrarSoporte.FormattingEnabled = True
        AdministracionCBCerrarSoporte.Location = New Point(711, 419)
        AdministracionCBCerrarSoporte.Name = "AdministracionCBCerrarSoporte"
        AdministracionCBCerrarSoporte.Size = New Size(281, 28)
        AdministracionCBCerrarSoporte.TabIndex = 1
        ' 
        ' AdministracionBtnCerrarSoporte
        ' 
        AdministracionBtnCerrarSoporte.BackColor = Color.CornflowerBlue
        AdministracionBtnCerrarSoporte.FlatAppearance.BorderSize = 0
        AdministracionBtnCerrarSoporte.FlatStyle = FlatStyle.Flat
        AdministracionBtnCerrarSoporte.Font = New Font("Segoe UI Variable Small Semibol", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        AdministracionBtnCerrarSoporte.Location = New Point(758, 469)
        AdministracionBtnCerrarSoporte.Name = "AdministracionBtnCerrarSoporte"
        AdministracionBtnCerrarSoporte.Size = New Size(234, 29)
        AdministracionBtnCerrarSoporte.TabIndex = 4
        AdministracionBtnCerrarSoporte.Text = "Cerrar Soporte"
        AdministracionBtnCerrarSoporte.UseVisualStyleBackColor = False
        ' 
        ' AdministracionReporte
        ' 
        AdministracionReporte.Controls.Add(Panel3)
        AdministracionReporte.Controls.Add(AdministracionBtnExportarReporte)
        AdministracionReporte.Controls.Add(AdministracionDGReporte)
        AdministracionReporte.Location = New Point(0, 28)
        AdministracionReporte.Name = "AdministracionReporte"
        AdministracionReporte.Size = New Size(1023, 532)
        AdministracionReporte.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.CornflowerBlue
        Panel3.Controls.Add(Label31)
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(224, 532)
        Panel3.TabIndex = 15
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label31.ForeColor = SystemColors.ControlLightLight
        Label31.Location = New Point(36, 47)
        Label31.Name = "Label31"
        Label31.Size = New Size(144, 74)
        Label31.TabIndex = 0
        Label31.Text = "Soportes " & vbCrLf & "Cerrados"
        ' 
        ' AdministracionBtnExportarReporte
        ' 
        AdministracionBtnExportarReporte.BackColor = Color.CornflowerBlue
        AdministracionBtnExportarReporte.FlatAppearance.BorderSize = 0
        AdministracionBtnExportarReporte.FlatStyle = FlatStyle.Flat
        AdministracionBtnExportarReporte.Font = New Font("Segoe UI Variable Display", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        AdministracionBtnExportarReporte.Location = New Point(785, 488)
        AdministracionBtnExportarReporte.Name = "AdministracionBtnExportarReporte"
        AdministracionBtnExportarReporte.Size = New Size(217, 29)
        AdministracionBtnExportarReporte.TabIndex = 2
        AdministracionBtnExportarReporte.Text = "Exportar a Excel"
        AdministracionBtnExportarReporte.UseVisualStyleBackColor = False
        ' 
        ' AdministracionDGReporte
        ' 
        AdministracionDGReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AdministracionDGReporte.Location = New Point(244, 98)
        AdministracionDGReporte.Name = "AdministracionDGReporte"
        AdministracionDGReporte.RowHeadersWidth = 51
        AdministracionDGReporte.RowTemplate.Height = 29
        AdministracionDGReporte.Size = New Size(758, 261)
        AdministracionDGReporte.TabIndex = 1
        ' 
        ' AdministracionCrearEquipo
        ' 
        AdministracionCrearEquipo.Controls.Add(Label1)
        AdministracionCrearEquipo.Controls.Add(Panel1)
        AdministracionCrearEquipo.Controls.Add(AdministracionTBContrasenaEquipo)
        AdministracionCrearEquipo.Controls.Add(Label18)
        AdministracionCrearEquipo.Controls.Add(AdministracionTBUsuarioEquipo)
        AdministracionCrearEquipo.Controls.Add(Label17)
        AdministracionCrearEquipo.Controls.Add(Label16)
        AdministracionCrearEquipo.Controls.Add(AdministracionTBNombreEquipo)
        AdministracionCrearEquipo.Controls.Add(AdministracionBtnCrearEquipo)
        AdministracionCrearEquipo.Location = New Point(0, 28)
        AdministracionCrearEquipo.Name = "AdministracionCrearEquipo"
        AdministracionCrearEquipo.Size = New Size(1023, 532)
        AdministracionCrearEquipo.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(438, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(330, 31)
        Label1.TabIndex = 9
        Label1.Text = "INFORMACIÓN DEL USUARIO"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CornflowerBlue
        Panel1.Controls.Add(Label15)
        Panel1.Location = New Point(2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(219, 529)
        Panel1.TabIndex = 8
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.ForeColor = SystemColors.ControlLightLight
        Label15.Location = New Point(28, 45)
        Label15.Name = "Label15"
        Label15.Size = New Size(168, 74)
        Label15.TabIndex = 0
        Label15.Text = "CREACIÓN " & vbCrLf & "EQUIPO"
        ' 
        ' AdministracionTBContrasenaEquipo
        ' 
        AdministracionTBContrasenaEquipo.BackColor = SystemColors.ControlLightLight
        AdministracionTBContrasenaEquipo.Location = New Point(589, 334)
        AdministracionTBContrasenaEquipo.Name = "AdministracionTBContrasenaEquipo"
        AdministracionTBContrasenaEquipo.ReadOnly = True
        AdministracionTBContrasenaEquipo.Size = New Size(207, 27)
        AdministracionTBContrasenaEquipo.TabIndex = 7
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(453, 337)
        Label18.Name = "Label18"
        Label18.Size = New Size(119, 27)
        Label18.TabIndex = 6
        Label18.Text = "Contrasena"
        ' 
        ' AdministracionTBUsuarioEquipo
        ' 
        AdministracionTBUsuarioEquipo.BackColor = SystemColors.ControlLightLight
        AdministracionTBUsuarioEquipo.Location = New Point(589, 235)
        AdministracionTBUsuarioEquipo.Name = "AdministracionTBUsuarioEquipo"
        AdministracionTBUsuarioEquipo.ReadOnly = True
        AdministracionTBUsuarioEquipo.Size = New Size(207, 27)
        AdministracionTBUsuarioEquipo.TabIndex = 5
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(453, 238)
        Label17.Name = "Label17"
        Label17.Size = New Size(84, 27)
        Label17.TabIndex = 4
        Label17.Text = "Usuario"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(453, 148)
        Label16.Name = "Label16"
        Label16.Size = New Size(89, 27)
        Label16.TabIndex = 3
        Label16.Text = "Nombre"
        ' 
        ' AdministracionTBNombreEquipo
        ' 
        AdministracionTBNombreEquipo.BackColor = SystemColors.ControlLightLight
        AdministracionTBNombreEquipo.Location = New Point(589, 141)
        AdministracionTBNombreEquipo.Name = "AdministracionTBNombreEquipo"
        AdministracionTBNombreEquipo.ReadOnly = True
        AdministracionTBNombreEquipo.Size = New Size(207, 27)
        AdministracionTBNombreEquipo.TabIndex = 2
        ' 
        ' AdministracionBtnCrearEquipo
        ' 
        AdministracionBtnCrearEquipo.BackColor = Color.RoyalBlue
        AdministracionBtnCrearEquipo.FlatAppearance.BorderSize = 0
        AdministracionBtnCrearEquipo.FlatStyle = FlatStyle.Flat
        AdministracionBtnCrearEquipo.Font = New Font("Segoe UI Variable Text Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AdministracionBtnCrearEquipo.ForeColor = SystemColors.ControlLightLight
        AdministracionBtnCrearEquipo.Location = New Point(522, 401)
        AdministracionBtnCrearEquipo.Name = "AdministracionBtnCrearEquipo"
        AdministracionBtnCrearEquipo.Size = New Size(246, 47)
        AdministracionBtnCrearEquipo.TabIndex = 1
        AdministracionBtnCrearEquipo.Text = "CREAR EQUIPO"
        AdministracionBtnCrearEquipo.UseVisualStyleBackColor = False
        ' 
        ' AdministracionItinerario
        ' 
        AdministracionItinerario.Controls.Add(Panel5)
        AdministracionItinerario.Controls.Add(Label19)
        AdministracionItinerario.Controls.Add(AdministracionDGItinerario)
        AdministracionItinerario.Location = New Point(0, 28)
        AdministracionItinerario.Name = "AdministracionItinerario"
        AdministracionItinerario.Size = New Size(1023, 532)
        AdministracionItinerario.TabIndex = 6
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.CornflowerBlue
        Panel5.Controls.Add(Label32)
        Panel5.Location = New Point(2, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(224, 532)
        Panel5.TabIndex = 17
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label32.ForeColor = SystemColors.ControlLightLight
        Label32.Location = New Point(47, 55)
        Label32.Name = "Label32"
        Label32.Size = New Size(141, 111)
        Label32.TabIndex = 0
        Label32.Text = "SOPORTE" & vbCrLf & "EN " & vbCrLf & "CURSO"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.Location = New Point(273, 75)
        Label19.Name = "Label19"
        Label19.Size = New Size(239, 31)
        Label19.TabIndex = 1
        Label19.Text = "Soportes disponibles" & vbCrLf
        ' 
        ' AdministracionDGItinerario
        ' 
        AdministracionDGItinerario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AdministracionDGItinerario.Location = New Point(273, 133)
        AdministracionDGItinerario.Name = "AdministracionDGItinerario"
        AdministracionDGItinerario.RowHeadersWidth = 51
        AdministracionDGItinerario.RowTemplate.Height = 29
        AdministracionDGItinerario.Size = New Size(709, 295)
        AdministracionDGItinerario.TabIndex = 0
        ' 
        ' AdministracionManual
        ' 
        AdministracionManual.Controls.Add(Label27)
        AdministracionManual.Controls.Add(Label26)
        AdministracionManual.Controls.Add(Label25)
        AdministracionManual.Controls.Add(Label24)
        AdministracionManual.Controls.Add(Label23)
        AdministracionManual.Controls.Add(Label14)
        AdministracionManual.Controls.Add(Label22)
        AdministracionManual.Location = New Point(0, 28)
        AdministracionManual.Name = "AdministracionManual"
        AdministracionManual.Size = New Size(1023, 532)
        AdministracionManual.TabIndex = 9
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label27.Location = New Point(35, 339)
        Label27.Name = "Label27"
        Label27.Size = New Size(881, 54)
        Label27.TabIndex = 6
        Label27.Text = "+Para crear un reporte de un soporte terminado, nos desplazaremos a ""Reporte"" y exportaremos la " & vbCrLf & "informacion del ticket en un excel. "
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI Variable Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label26.Location = New Point(59, 307)
        Label26.Name = "Label26"
        Label26.Size = New Size(112, 31)
        Label26.TabIndex = 5
        Label26.Text = "REPORTE:"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label25.Location = New Point(35, 262)
        Label25.Name = "Label25"
        Label25.Size = New Size(799, 27)
        Label25.TabIndex = 4
        Label25.Text = "+Para revisar el itinerario de los soportes abiertos disponibles, nos dirigimos a ""Itinerario"""
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI Variable Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label24.Location = New Point(53, 231)
        Label24.Name = "Label24"
        Label24.Size = New Size(138, 31)
        Label24.TabIndex = 3
        Label24.Text = "ITINERARIO:"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI Variable Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label23.Location = New Point(50, 103)
        Label23.Name = "Label23"
        Label23.Size = New Size(121, 31)
        Label23.TabIndex = 2
        Label23.Text = "SOPORTE: " & vbCrLf
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(35, 136)
        Label14.Name = "Label14"
        Label14.Size = New Size(857, 81)
        Label14.TabIndex = 1
        Label14.Text = resources.GetString("Label14.Text")
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label22.Location = New Point(36, 35)
        Label22.Name = "Label22"
        Label22.Size = New Size(312, 37)
        Label22.TabIndex = 0
        Label22.Text = "MANUAL DE USUARIO"
        ' 
        ' AdministracionVersion
        ' 
        AdministracionVersion.Controls.Add(Label30)
        AdministracionVersion.Controls.Add(Label29)
        AdministracionVersion.Controls.Add(Label28)
        AdministracionVersion.Controls.Add(Label21)
        AdministracionVersion.Location = New Point(0, 28)
        AdministracionVersion.Name = "AdministracionVersion"
        AdministracionVersion.Size = New Size(1023, 529)
        AdministracionVersion.TabIndex = 10
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Segoe UI Variable Small", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label30.Location = New Point(36, 144)
        Label30.Name = "Label30"
        Label30.Size = New Size(151, 37)
        Label30.TabIndex = 3
        Label30.Text = "-Rene Ruiz"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Segoe UI Variable Small", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label29.Location = New Point(31, 107)
        Label29.Name = "Label29"
        Label29.Size = New Size(254, 37)
        Label29.TabIndex = 2
        Label29.Text = "-Pedro De La Torre"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label28.Location = New Point(24, 48)
        Label28.Name = "Label28"
        Label28.Size = New Size(317, 40)
        Label28.TabIndex = 1
        Label28.Text = "DESARROLLADORES:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI Variable Small", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label21.Location = New Point(815, 54)
        Label21.Name = "Label21"
        Label21.Size = New Size(167, 40)
        Label21.TabIndex = 0
        Label21.Text = "Version 3.0"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(512, 138)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(401, 363)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Segoe UI Variable Text", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label33.Location = New Point(22, 61)
        Label33.Name = "Label33"
        Label33.Size = New Size(474, 40)
        Label33.TabIndex = 21
        Label33.Text = "BIENVENIDO, ADMINISTRADOR"
        ' 
        ' Administracion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1023, 561)
        Controls.Add(AdministracionCrearEquipo)
        Controls.Add(MenuStrip1)
        Controls.Add(AdministracionCrearSoporte)
        Controls.Add(AdministracionActualizarSoporte)
        Controls.Add(AdministracionCerrarSoporte)
        Controls.Add(AdministracionReporte)
        Controls.Add(AdministracionItinerario)
        Controls.Add(AdministracionManual)
        Controls.Add(AdministracionVersion)
        Controls.Add(PictureBox1)
        Controls.Add(Label33)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MainMenuStrip = MenuStrip1
        Name = "Administracion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Administrador"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        AdministracionCrearSoporte.ResumeLayout(False)
        AdministracionCrearSoporte.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        AdministracionActualizarSoporte.ResumeLayout(False)
        AdministracionActualizarSoporte.PerformLayout()
        CType(AdministracionNDActualizarSoporte, ComponentModel.ISupportInitialize).EndInit()
        AdministracionCerrarSoporte.ResumeLayout(False)
        AdministracionCerrarSoporte.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DGSeleccionarSoporte, ComponentModel.ISupportInitialize).EndInit()
        AdministracionReporte.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(AdministracionDGReporte, ComponentModel.ISupportInitialize).EndInit()
        AdministracionCrearEquipo.ResumeLayout(False)
        AdministracionCrearEquipo.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        AdministracionItinerario.ResumeLayout(False)
        AdministracionItinerario.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(AdministracionDGItinerario, ComponentModel.ISupportInitialize).EndInit()
        AdministracionManual.ResumeLayout(False)
        AdministracionManual.PerformLayout()
        AdministracionVersion.ResumeLayout(False)
        AdministracionVersion.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItinerarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquiposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AdministracionCrearSoporte As Panel
    Friend WithEvents AdministracionActualizarSoporte As Panel
    Friend WithEvents AdministracionCerrarSoporte As Panel
    Friend WithEvents AdministracionCrearEquipo As Panel
    Friend WithEvents AdministracionItinerario As Panel
    Friend WithEvents AdministracionReporte As Panel
    Friend WithEvents AdministracionManual As Panel
    Friend WithEvents AdministracionVersion As Panel
    Friend WithEvents AdministracionBtnCrearSoporte As Button
    Friend WithEvents AdministracionTBCostoInicial As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents AdministracionMCFinal As MonthCalendar
    Friend WithEvents Label7 As Label
    Friend WithEvents AdministracionMCInicio As MonthCalendar
    Friend WithEvents AdministracionTBTipoSoporte As ComboBox
    Friend WithEvents AdministracionCBEquipo As ComboBox
    Friend WithEvents AdministracionTBCliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AdministracionBtnCerrarSoporte As Button
    Friend WithEvents AdministracionCBCerrarSoporte As ComboBox
    Friend WithEvents AdministracionTBContrasenaEquipo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents AdministracionTBUsuarioEquipo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents AdministracionTBNombreEquipo As TextBox
    Friend WithEvents AdministracionBtnCrearEquipo As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents AdministracionDGItinerario As DataGridView
    Friend WithEvents AdministracionBtnExportarReporte As Button
    Friend WithEvents AdministracionDGReporte As DataGridView
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents AdministracionTBComentario As TextBox
    Friend WithEvents AdministracionNDActualizarSoporte As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents AdministracionBtnActualizarSoporte As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents AdministracionCBActualizarSoporte As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents DGSeleccionarSoporte As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label32 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label33 As Label
End Class
