Imports Azure.Identity
Imports Microsoft.Data.SqlClient

Public Class Equipo
    'Public connectionString As String = "Data Source=DESKTOP-910LQQK;Initial Catalog=TICKET;Integrated Security=True; Encrypt=False"'
    Public connectionString As String = "Data Source=RENE_RUIZ\SQLEXPRESS;Initial Catalog=TICKET;Integrated Security=True; Encrypt=False"

    Public Property UserName As String
    Public Sub Equipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EquipoManual.Visible = False
        EquipoVersion.Visible = False
        EquipoActualizarSoporte.Visible = False
        EquipoCerrarSoporte.Visible = False
        EquipoReporte.Visible = False

        Dim connection6 As New SqlConnection(connectionString)
        connection6.Open()
        Dim command6 As New SqlCommand("SELECT IdTicket FROM TICKETS WHERE Estado = 'Abierto' AND Equipo = @UserName", connection6)
        command6.Parameters.AddWithValue("@UserName", UserName)
        Dim reader6 As SqlDataReader = command6.ExecuteReader()
        EquipoCBActualizarSoporte.Items.Clear()
        While reader6.Read()
            EquipoCBActualizarSoporte.Items.Add(reader6("IdTicket").ToString())
        End While
        reader6.Close()
    End Sub

    Private Sub ShowPanel(panel As Panel)
        Dim container As Control = panel.Parent
        For Each p As Panel In container.Controls.OfType(Of Panel)()
            p.Visible = False
        Next
        panel.Visible = True
    End Sub

    Private Sub SoporteActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoporteActualToolStripMenuItem.Click
        ShowPanel(EquipoActualizarSoporte)
    End Sub

    Private Sub FacturarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturarToolStripMenuItem.Click
        ShowPanel(EquipoCerrarSoporte)
        llenarDGCerrarReporte()
        Dim connection7 As New SqlConnection(connectionString)
        connection7.Open()
        Dim command7 As New SqlCommand("SELECT IdTicket FROM TICKETS WHERE Estado = 'Abierto' AND Equipo = @UserName", connection7)
        command7.Parameters.AddWithValue("@UserName", UserName)
        Dim reader7 As SqlDataReader = command7.ExecuteReader()
        EquipoCBCerrarSoporte.Items.Clear()
        While reader7.Read()
            EquipoCBCerrarSoporte.Items.Add(reader7("IdTicket").ToString())
        End While
        reader7.Close()
        ShowPanel(EquipoCerrarSoporte)
    End Sub
    Public Sub llenarDGCerrarReporte()
        Dim cmd As SqlCommand
        Dim connection7 As New SqlConnection(connectionString)
        connection7.Open()
        cmd = New SqlCommand("SELECT *from TICKETS WHERE Estado = 'Abierto' ", connection7) 'hacemos el query de la tabla Books Authors
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DGCerrarSoporte.DataSource = dt
    End Sub
    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click
        ShowPanel(EquipoManual)
    End Sub

    Private Sub VersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionToolStripMenuItem.Click
        ShowPanel(EquipoVersion)
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub EquipoBtnActualizarSoporte_Click(sender As Object, e As EventArgs) Handles EquipoBtnActualizarSoporte.Click
        If String.IsNullOrWhiteSpace(EquipoCBActualizarSoporte.Text) OrElse String.IsNullOrWhiteSpace(EquipoNDActualizarSoporte.Text) OrElse String.IsNullOrWhiteSpace(EquipoTBComentario.Text) Then
            MessageBox.Show("Por favor ingrese todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            Dim ticketid As Integer = EquipoCBActualizarSoporte.Text
            Dim costoadicional As Decimal = EquipoNDActualizarSoporte.Text
            Dim comentario As String = EquipoTBComentario.Text
            UpdateTicket(ticketid, costoadicional, comentario)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateTicket(ticketid As Integer, costoadicional As Decimal, comentario As String)
        Using connection9 As New SqlConnection(connectionString)
            connection9.Open()
            Dim command As New SqlCommand("UPDATE TICKETS SET CostoAdicional = @CostoAdicional, Comentarios = @Comentarios WHERE IdTicket = @IdTicket", connection9)
            command.Parameters.AddWithValue("@CostoAdicional", costoadicional)
            command.Parameters.AddWithValue("@Comentarios", comentario)
            command.Parameters.AddWithValue("@IdTicket", ticketid)
            command.ExecuteNonQuery()
            connection9.Close()
        End Using

        MessageBox.Show("Ticket actualizado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub EquipoBtnCerrarSoporte_Click(sender As Object, e As EventArgs) Handles EquipoBtnCerrarSoporte.Click
        If String.IsNullOrWhiteSpace(EquipoCBCerrarSoporte.Text) Then
            MessageBox.Show("Por favor ingrese todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            Dim ticketid As Integer = Convert.ToInt32(EquipoCBCerrarSoporte.Text)
            CloseTicket(ticketid)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CloseTicket(ticketid As Integer)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim commandSelect As New SqlCommand("SELECT CostoInicio, CostoAdicional, FechadeInicio, FechaFin, TipodeSoporte, Comentarios FROM TICKETS WHERE IdTicket = @IdTicket", connection)
            commandSelect.Parameters.AddWithValue("@IdTicket", ticketid)

            Dim costoInicial As Decimal = 0
            Dim costoAdicional As Decimal = 0
            Dim fechaInicio As DateTime
            Dim fechaFin As DateTime
            Dim tipoSoporte As String
            Dim comentarios As String

            Using reader As SqlDataReader = commandSelect.ExecuteReader()
                If reader.Read() Then
                    costoInicial = Convert.ToDecimal(reader("CostoInicio"))
                    If Not reader.IsDBNull(reader.GetOrdinal("CostoAdicional")) Then
                        costoAdicional = Convert.ToDecimal(reader("CostoAdicional"))
                    End If
                    fechaInicio = Convert.ToDateTime(reader("FechadeInicio"))
                    fechaFin = Convert.ToDateTime(reader("FechaFin"))
                    tipoSoporte = reader("TipodeSoporte").ToString()
                    comentarios = reader("Comentarios").ToString()
                Else
                    MessageBox.Show("Ticket not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using

            Dim itbms As Decimal = Math.Round((costoInicial + costoAdicional) * 0.07, 2)
            Dim costoTotal As Decimal = Math.Round(costoInicial + costoAdicional + itbms, 2)
            Dim totalDays As Integer = CInt((fechaFin - fechaInicio).TotalDays) + 1

            Dim invoiceText As String = "Soluciones Integrales, S.A." & vbCrLf &
"Factura #: " & ticketid.ToString() & vbCrLf & vbCrLf &
"Cantidad" & vbTab & "Detalle" & vbTab & "Subtotal" & vbCrLf &
totalDays.ToString() & vbTab &
tipoSoporte & vbTab & costoInicial.ToString("0.00") & vbCrLf & vbCrLf &
"Costos Adicionales" & vbCrLf &
comentarios & vbTab & costoAdicional.ToString("0.00") & vbCrLf & vbCrLf &
"ITBMS" & vbTab & vbTab & itbms.ToString("0.00") & vbCrLf &
"Total" & vbTab & vbTab & costoTotal.ToString("0.00")

            Dim successTitle As String = "Invoice Details"
            MessageBox.Show(invoiceText, successTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim commandUpdate As New SqlCommand("UPDATE TICKETS SET CostoTotal = @CostoTotal, Estado = 'Cerrado' WHERE IdTicket = @IdTicket", connection)
            commandUpdate.Parameters.AddWithValue("@CostoTotal", costoTotal)
            commandUpdate.Parameters.AddWithValue("@IdTicket", ticketid)
            commandUpdate.ExecuteNonQuery()

            connection.Close()
        End Using
    End Sub


End Class