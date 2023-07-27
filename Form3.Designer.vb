<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipo
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
        MenuStrip1 = New MenuStrip()
        SoporteActualToolStripMenuItem = New ToolStripMenuItem()
        FacturarToolStripMenuItem = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        ManualDeUsuarioToolStripMenuItem = New ToolStripMenuItem()
        VersionToolStripMenuItem = New ToolStripMenuItem()
        CerrarToolStripMenuItem = New ToolStripMenuItem()
        EquipoActualizarSoporte = New Panel()
        Panel2 = New Panel()
        Label4 = New Label()
        EquipoTBComentario = New TextBox()
        EquipoNDActualizarSoporte = New NumericUpDown()
        Label3 = New Label()
        Label2 = New Label()
        EquipoBtnActualizarSoporte = New Button()
        Label10 = New Label()
        EquipoCBActualizarSoporte = New ComboBox()
        Label9 = New Label()
        EquipoReporte = New Panel()
        EquipoBtnFacturar = New Button()
        AdministracionDGReporte = New DataGridView()
        Label20 = New Label()
        EquipoVersion = New Panel()
        Panel4 = New Panel()
        Label7 = New Label()
        Label30 = New Label()
        Label29 = New Label()
        Label28 = New Label()
        Label5 = New Label()
        EquipoManual = New Panel()
        Label23 = New Label()
        Label14 = New Label()
        Panel3 = New Panel()
        Label6 = New Label()
        EquipoCerrarSoporte = New Panel()
        DGCerrarSoporte = New DataGridView()
        Panel1 = New Panel()
        Label15 = New Label()
        EquipoBtnCerrarSoporte = New Button()
        EquipoCBCerrarSoporte = New ComboBox()
        Label13 = New Label()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        EquipoActualizarSoporte.SuspendLayout()
        Panel2.SuspendLayout()
        CType(EquipoNDActualizarSoporte, ComponentModel.ISupportInitialize).BeginInit()
        EquipoReporte.SuspendLayout()
        CType(AdministracionDGReporte, ComponentModel.ISupportInitialize).BeginInit()
        EquipoVersion.SuspendLayout()
        Panel4.SuspendLayout()
        EquipoManual.SuspendLayout()
        Panel3.SuspendLayout()
        EquipoCerrarSoporte.SuspendLayout()
        CType(DGCerrarSoporte, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.RoyalBlue
        MenuStrip1.Font = New Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SoporteActualToolStripMenuItem, FacturarToolStripMenuItem, AyudaToolStripMenuItem, CerrarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1023, 35)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SoporteActualToolStripMenuItem
        ' 
        SoporteActualToolStripMenuItem.Font = New Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        SoporteActualToolStripMenuItem.ForeColor = SystemColors.ControlLightLight
        SoporteActualToolStripMenuItem.Name = "SoporteActualToolStripMenuItem"
        SoporteActualToolStripMenuItem.Size = New Size(167, 31)
        SoporteActualToolStripMenuItem.Text = "Soporte Actual"
        ' 
        ' FacturarToolStripMenuItem
        ' 
        FacturarToolStripMenuItem.Font = New Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        FacturarToolStripMenuItem.ForeColor = SystemColors.ControlLightLight
        FacturarToolStripMenuItem.Name = "FacturarToolStripMenuItem"
        FacturarToolStripMenuItem.Size = New Size(103, 31)
        FacturarToolStripMenuItem.Text = "Facturar"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ManualDeUsuarioToolStripMenuItem, VersionToolStripMenuItem})
        AyudaToolStripMenuItem.Font = New Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        AyudaToolStripMenuItem.ForeColor = SystemColors.ControlLightLight
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(86, 31)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' ManualDeUsuarioToolStripMenuItem
        ' 
        ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        ManualDeUsuarioToolStripMenuItem.Size = New Size(276, 32)
        ManualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario"
        ' 
        ' VersionToolStripMenuItem
        ' 
        VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        VersionToolStripMenuItem.Size = New Size(276, 32)
        VersionToolStripMenuItem.Text = "Version"
        ' 
        ' CerrarToolStripMenuItem
        ' 
        CerrarToolStripMenuItem.Font = New Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CerrarToolStripMenuItem.ForeColor = SystemColors.ControlLightLight
        CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        CerrarToolStripMenuItem.Size = New Size(151, 31)
        CerrarToolStripMenuItem.Text = "Cerrar Sesión"
        ' 
        ' EquipoActualizarSoporte
        ' 
        EquipoActualizarSoporte.Controls.Add(Panel2)
        EquipoActualizarSoporte.Controls.Add(EquipoTBComentario)
        EquipoActualizarSoporte.Controls.Add(EquipoNDActualizarSoporte)
        EquipoActualizarSoporte.Controls.Add(Label3)
        EquipoActualizarSoporte.Controls.Add(Label2)
        EquipoActualizarSoporte.Controls.Add(EquipoBtnActualizarSoporte)
        EquipoActualizarSoporte.Controls.Add(Label10)
        EquipoActualizarSoporte.Controls.Add(EquipoCBActualizarSoporte)
        EquipoActualizarSoporte.Controls.Add(Label9)
        EquipoActualizarSoporte.Location = New Point(0, 31)
        EquipoActualizarSoporte.Name = "EquipoActualizarSoporte"
        EquipoActualizarSoporte.Size = New Size(1023, 533)
        EquipoActualizarSoporte.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.CornflowerBlue
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(219, 529)
        Panel2.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(12, 50)
        Label4.Name = "Label4"
        Label4.Size = New Size(195, 74)
        Label4.TabIndex = 0
        Label4.Text = "ACTUALIZAR " & vbCrLf & "SOPORTE"
        ' 
        ' EquipoTBComentario
        ' 
        EquipoTBComentario.Location = New Point(552, 255)
        EquipoTBComentario.Multiline = True
        EquipoTBComentario.Name = "EquipoTBComentario"
        EquipoTBComentario.Size = New Size(432, 146)
        EquipoTBComentario.TabIndex = 12
        ' 
        ' EquipoNDActualizarSoporte
        ' 
        EquipoNDActualizarSoporte.DecimalPlaces = 2
        EquipoNDActualizarSoporte.Location = New Point(552, 179)
        EquipoNDActualizarSoporte.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        EquipoNDActualizarSoporte.Name = "EquipoNDActualizarSoporte"
        EquipoNDActualizarSoporte.Size = New Size(198, 27)
        EquipoNDActualizarSoporte.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(265, 255)
        Label3.Name = "Label3"
        Label3.Size = New Size(207, 27)
        Label3.TabIndex = 10
        Label3.Text = "Agregar Comentarios"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(265, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(233, 27)
        Label2.TabIndex = 9
        Label2.Text = "Agregar Costo Adicional"
        ' 
        ' EquipoBtnActualizarSoporte
        ' 
        EquipoBtnActualizarSoporte.BackColor = Color.CornflowerBlue
        EquipoBtnActualizarSoporte.FlatAppearance.BorderSize = 0
        EquipoBtnActualizarSoporte.FlatStyle = FlatStyle.Flat
        EquipoBtnActualizarSoporte.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EquipoBtnActualizarSoporte.ForeColor = SystemColors.ControlLightLight
        EquipoBtnActualizarSoporte.Location = New Point(733, 453)
        EquipoBtnActualizarSoporte.Name = "EquipoBtnActualizarSoporte"
        EquipoBtnActualizarSoporte.Size = New Size(251, 56)
        EquipoBtnActualizarSoporte.TabIndex = 8
        EquipoBtnActualizarSoporte.Text = "Actualizar Soporte"
        EquipoBtnActualizarSoporte.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(259, 102)
        Label10.Name = "Label10"
        Label10.Size = New Size(280, 27)
        Label10.TabIndex = 2
        Label10.Text = "Seleccionar Soporte en Curso"
        ' 
        ' EquipoCBActualizarSoporte
        ' 
        EquipoCBActualizarSoporte.FormattingEnabled = True
        EquipoCBActualizarSoporte.Location = New Point(552, 106)
        EquipoCBActualizarSoporte.Name = "EquipoCBActualizarSoporte"
        EquipoCBActualizarSoporte.Size = New Size(198, 28)
        EquipoCBActualizarSoporte.TabIndex = 1
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(270, 46)
        Label9.Name = "Label9"
        Label9.Size = New Size(374, 31)
        Label9.TabIndex = 0
        Label9.Text = "INFORMACIÓN POR ACTUALIZAR"
        ' 
        ' EquipoReporte
        ' 
        EquipoReporte.Controls.Add(EquipoBtnFacturar)
        EquipoReporte.Controls.Add(AdministracionDGReporte)
        EquipoReporte.Controls.Add(Label20)
        EquipoReporte.Location = New Point(0, 31)
        EquipoReporte.Name = "EquipoReporte"
        EquipoReporte.Size = New Size(1023, 529)
        EquipoReporte.TabIndex = 8
        ' 
        ' EquipoBtnFacturar
        ' 
        EquipoBtnFacturar.Location = New Point(23, 313)
        EquipoBtnFacturar.Name = "EquipoBtnFacturar"
        EquipoBtnFacturar.Size = New Size(164, 29)
        EquipoBtnFacturar.TabIndex = 2
        EquipoBtnFacturar.Text = "Exportar a Excel"
        EquipoBtnFacturar.UseVisualStyleBackColor = True
        ' 
        ' AdministracionDGReporte
        ' 
        AdministracionDGReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AdministracionDGReporte.Location = New Point(23, 80)
        AdministracionDGReporte.Name = "AdministracionDGReporte"
        AdministracionDGReporte.RowHeadersWidth = 51
        AdministracionDGReporte.RowTemplate.Height = 29
        AdministracionDGReporte.Size = New Size(727, 187)
        AdministracionDGReporte.TabIndex = 1
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(23, 30)
        Label20.Name = "Label20"
        Label20.Size = New Size(131, 20)
        Label20.TabIndex = 0
        Label20.Text = "Soportes Cerrados"
        ' 
        ' EquipoVersion
        ' 
        EquipoVersion.Controls.Add(Panel4)
        EquipoVersion.Controls.Add(Label30)
        EquipoVersion.Controls.Add(Label29)
        EquipoVersion.Controls.Add(Label28)
        EquipoVersion.Controls.Add(Label5)
        EquipoVersion.Location = New Point(0, 31)
        EquipoVersion.Name = "EquipoVersion"
        EquipoVersion.Size = New Size(1023, 530)
        EquipoVersion.TabIndex = 11
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.CornflowerBlue
        Panel4.Controls.Add(Label7)
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(228, 529)
        Panel4.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(12, 56)
        Label7.Name = "Label7"
        Label7.Size = New Size(226, 111)
        Label7.TabIndex = 0
        Label7.Text = "INFORMACIÓN " & vbCrLf & "       DEL " & vbCrLf & "  PROGRAMA" & vbCrLf
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Segoe UI Variable Small", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label30.Location = New Point(270, 168)
        Label30.Name = "Label30"
        Label30.Size = New Size(118, 31)
        Label30.TabIndex = 7
        Label30.Text = "Rene Ruiz"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Segoe UI Variable Small", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label29.Location = New Point(266, 112)
        Label29.Name = "Label29"
        Label29.Size = New Size(198, 31)
        Label29.TabIndex = 6
        Label29.Text = "Pedro De La Torre"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label28.Location = New Point(259, 53)
        Label28.Name = "Label28"
        Label28.Size = New Size(294, 37)
        Label28.TabIndex = 5
        Label28.Text = "DESARROLLADORES:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(817, 46)
        Label5.Name = "Label5"
        Label5.Size = New Size(162, 37)
        Label5.TabIndex = 4
        Label5.Text = "Version 3.0"
        ' 
        ' EquipoManual
        ' 
        EquipoManual.Controls.Add(Label23)
        EquipoManual.Controls.Add(Label14)
        EquipoManual.Controls.Add(Panel3)
        EquipoManual.Location = New Point(0, 31)
        EquipoManual.Name = "EquipoManual"
        EquipoManual.Size = New Size(1023, 529)
        EquipoManual.TabIndex = 12
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI Variable Text", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label23.Location = New Point(265, 107)
        Label23.Name = "Label23"
        Label23.Size = New Size(121, 31)
        Label23.TabIndex = 13
        Label23.Text = "SOPORTE: " & vbCrLf
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(244, 145)
        Label14.Name = "Label14"
        Label14.Size = New Size(707, 54)
        Label14.TabIndex = 12
        Label14.Text = "+Para actualizar la informacion de un soporte, ""Soporte Actual"" " & vbCrLf & "+Para cerrar un soporte, dirigete a ""Facturar"" y seleccionas el soporte deseado. " & vbCrLf
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.CornflowerBlue
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(219, 529)
        Panel3.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(33, 50)
        Label6.Name = "Label6"
        Label6.Size = New Size(146, 111)
        Label6.TabIndex = 0
        Label6.Text = "MANUAL " & vbCrLf & "     DE" & vbCrLf & "USUARIO" & vbCrLf
        ' 
        ' EquipoCerrarSoporte
        ' 
        EquipoCerrarSoporte.Controls.Add(DGCerrarSoporte)
        EquipoCerrarSoporte.Controls.Add(Panel1)
        EquipoCerrarSoporte.Controls.Add(EquipoBtnCerrarSoporte)
        EquipoCerrarSoporte.Controls.Add(EquipoCBCerrarSoporte)
        EquipoCerrarSoporte.Controls.Add(Label13)
        EquipoCerrarSoporte.Location = New Point(0, 31)
        EquipoCerrarSoporte.Name = "EquipoCerrarSoporte"
        EquipoCerrarSoporte.Size = New Size(1023, 536)
        EquipoCerrarSoporte.TabIndex = 13
        ' 
        ' DGCerrarSoporte
        ' 
        DGCerrarSoporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGCerrarSoporte.Location = New Point(270, 106)
        DGCerrarSoporte.Name = "DGCerrarSoporte"
        DGCerrarSoporte.ReadOnly = True
        DGCerrarSoporte.RowHeadersWidth = 51
        DGCerrarSoporte.RowTemplate.Height = 29
        DGCerrarSoporte.Size = New Size(728, 236)
        DGCerrarSoporte.TabIndex = 10
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CornflowerBlue
        Panel1.Controls.Add(Label15)
        Panel1.Location = New Point(-6, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(228, 529)
        Panel1.TabIndex = 9
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.ForeColor = SystemColors.ControlLightLight
        Label15.Location = New Point(43, 51)
        Label15.Name = "Label15"
        Label15.Size = New Size(141, 74)
        Label15.TabIndex = 0
        Label15.Text = "CERRAR " & vbCrLf & "SOPORTE"
        ' 
        ' EquipoBtnCerrarSoporte
        ' 
        EquipoBtnCerrarSoporte.BackColor = Color.CornflowerBlue
        EquipoBtnCerrarSoporte.FlatAppearance.BorderSize = 0
        EquipoBtnCerrarSoporte.FlatStyle = FlatStyle.Flat
        EquipoBtnCerrarSoporte.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EquipoBtnCerrarSoporte.ForeColor = SystemColors.ControlLightLight
        EquipoBtnCerrarSoporte.Location = New Point(741, 426)
        EquipoBtnCerrarSoporte.Name = "EquipoBtnCerrarSoporte"
        EquipoBtnCerrarSoporte.Size = New Size(257, 48)
        EquipoBtnCerrarSoporte.TabIndex = 4
        EquipoBtnCerrarSoporte.Text = "Cerrar Soporte"
        EquipoBtnCerrarSoporte.UseVisualStyleBackColor = False
        ' 
        ' EquipoCBCerrarSoporte
        ' 
        EquipoCBCerrarSoporte.FormattingEnabled = True
        EquipoCBCerrarSoporte.Location = New Point(802, 373)
        EquipoCBCerrarSoporte.Name = "EquipoCBCerrarSoporte"
        EquipoCBCerrarSoporte.Size = New Size(196, 28)
        EquipoCBCerrarSoporte.TabIndex = 1
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Variable Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(270, 53)
        Label13.Name = "Label13"
        Label13.Size = New Size(277, 37)
        Label13.TabIndex = 0
        Label13.Text = "Seleccionar Soporte"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(31, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 31)
        Label1.TabIndex = 15
        Label1.Text = "Bienvenido, Equipo"
        ' 
        ' Equipo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1023, 561)
        Controls.Add(MenuStrip1)
        Controls.Add(EquipoCerrarSoporte)
        Controls.Add(EquipoVersion)
        Controls.Add(EquipoManual)
        Controls.Add(EquipoActualizarSoporte)
        Controls.Add(EquipoReporte)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MainMenuStrip = MenuStrip1
        Name = "Equipo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        EquipoActualizarSoporte.ResumeLayout(False)
        EquipoActualizarSoporte.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(EquipoNDActualizarSoporte, ComponentModel.ISupportInitialize).EndInit()
        EquipoReporte.ResumeLayout(False)
        EquipoReporte.PerformLayout()
        CType(AdministracionDGReporte, ComponentModel.ISupportInitialize).EndInit()
        EquipoVersion.ResumeLayout(False)
        EquipoVersion.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        EquipoManual.ResumeLayout(False)
        EquipoManual.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        EquipoCerrarSoporte.ResumeLayout(False)
        EquipoCerrarSoporte.PerformLayout()
        CType(DGCerrarSoporte, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SoporteActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquipoActualizarSoporte As Panel
    Friend WithEvents EquipoBtnActualizarSoporte As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents EquipoCBActualizarSoporte As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents EquipoReporte As Panel
    Friend WithEvents EquipoBtnFacturar As Button
    Friend WithEvents AdministracionDGReporte As DataGridView
    Friend WithEvents Label20 As Label
    Friend WithEvents EquipoVersion As Panel
    Friend WithEvents EquipoManual As Panel
    Friend WithEvents EquipoCerrarSoporte As Panel
    Friend WithEvents EquipoBtnCerrarSoporte As Button
    Friend WithEvents EquipoCBCerrarSoporte As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EquipoTBComentario As TextBox
    Friend WithEvents EquipoNDActualizarSoporte As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents DGCerrarSoporte As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
End Class
