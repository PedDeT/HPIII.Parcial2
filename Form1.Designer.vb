<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        Usuario = New Label()
        Label1 = New Label()
        LoginTBUsuario = New TextBox()
        LoginTBContrasena = New TextBox()
        LoginBtnEntrar = New Button()
        Panel1 = New Panel()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Usuario
        ' 
        Usuario.AutoSize = True
        Usuario.BackColor = Color.Transparent
        Usuario.Font = New Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Usuario.ForeColor = SystemColors.ActiveCaptionText
        Usuario.Location = New Point(543, 160)
        Usuario.Name = "Usuario"
        Usuario.Size = New Size(95, 31)
        Usuario.TabIndex = 0
        Usuario.Text = "Usuario"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(523, 244)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 31)
        Label1.TabIndex = 1
        Label1.Text = "Contraseña"
        ' 
        ' LoginTBUsuario
        ' 
        LoginTBUsuario.Location = New Point(454, 194)
        LoginTBUsuario.Multiline = True
        LoginTBUsuario.Name = "LoginTBUsuario"
        LoginTBUsuario.Size = New Size(267, 27)
        LoginTBUsuario.TabIndex = 2
        ' 
        ' LoginTBContrasena
        ' 
        LoginTBContrasena.ForeColor = SystemColors.ActiveCaptionText
        LoginTBContrasena.Location = New Point(454, 278)
        LoginTBContrasena.Name = "LoginTBContrasena"
        LoginTBContrasena.Size = New Size(267, 27)
        LoginTBContrasena.TabIndex = 3
        LoginTBContrasena.UseSystemPasswordChar = True
        ' 
        ' LoginBtnEntrar
        ' 
        LoginBtnEntrar.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        LoginBtnEntrar.FlatAppearance.BorderSize = 0
        LoginBtnEntrar.FlatStyle = FlatStyle.Flat
        LoginBtnEntrar.Font = New Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LoginBtnEntrar.ForeColor = SystemColors.ControlLightLight
        LoginBtnEntrar.Location = New Point(484, 342)
        LoginBtnEntrar.Name = "LoginBtnEntrar"
        LoginBtnEntrar.Size = New Size(213, 43)
        LoginBtnEntrar.TabIndex = 4
        LoginBtnEntrar.Text = "INICIAR SESIÓN"
        LoginBtnEntrar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.RoyalBlue
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(-4, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(313, 454)
        Panel1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.ForeColor = Color.DodgerBlue
        Label4.Location = New Point(390, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(423, 46)
        Label4.TabIndex = 7
        Label4.Text = "Bienvenido a JK SisTicket"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(58, 138)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(187, 181)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(11, 419)
        Label3.Name = "Label3"
        Label3.Size = New Size(171, 22)
        Label3.TabIndex = 7
        Label3.Text = "Derechos reservados"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(28, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(252, 41)
        Label2.TabIndex = 6
        Label2.Text = "INICIAR SESIÓN"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(890, 450)
        Controls.Add(Label4)
        Controls.Add(LoginTBUsuario)
        Controls.Add(LoginBtnEntrar)
        Controls.Add(LoginTBContrasena)
        Controls.Add(Label1)
        Controls.Add(Usuario)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Login"
        Opacity = 0.98R
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOGIN"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Usuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginTBUsuario As TextBox
    Friend WithEvents LoginTBContrasena As TextBox
    Friend WithEvents LoginBtnEntrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
