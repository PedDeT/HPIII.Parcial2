Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity.Client

Public Class Login
    'Conexiones 
    'Public connectionString As String = "Data Source=DESKTOP-910LQQK;Initial Catalog=TICKET;Integrated Security=True; Encrypt=False"'
    Public connectionString As String = "Data Source=RENE_RUIZ\SQLEXPRESS;Initial Catalog=TICKET;Integrated Security=True; Encrypt=False"
    'Boton para iniciar sesion 
    Private Sub LoginBtnEntrar_Click(sender As Object, e As EventArgs) Handles LoginBtnEntrar.Click
        Dim username As String = LoginTBUsuario.Text
        Dim password As String = LoginTBContrasena.Text
        Using connection As New SqlConnection(connectionString)

            connection.Open()
            Dim query As String = "SELECT COUNT(*) FROM USUARIOS WHERE Usuario = @Username AND Contrasena = @Password"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Password", password)

            Dim result As Integer = CInt(command.ExecuteScalar())
            If result > 0 Then
                If username = "Admin" Then
                    Administracion.UserName = username
                    Administracion.Show()
                    LoginTBUsuario.Clear()
                    LoginTBContrasena.Clear()
                    Me.Hide()
                Else
                    Equipo.UserName = username
                    Equipo.Show()
                    LoginTBUsuario.Clear()
                    LoginTBContrasena.Clear()
                    Me.Hide()
                End If
            Else
                ' Display error message
                MessageBox.Show("Usuario o Contrasena Invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoginTBContrasena.Clear()
                LoginTBUsuario.Clear()
            End If
        End Using

    End Sub
End Class
