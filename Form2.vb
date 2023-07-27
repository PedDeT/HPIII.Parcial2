Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient
Imports OfficeOpenXml

Public Class Administracion
    Public Property UserName As String

    'Public connectionString As String = "Data Source=DESKTOP-910LQQK;Initial Catalog=TICKET;Integrated Security=True; Encrypt=False"'
    Public connectionString As String = "Data Source=RENE_RUIZ\SQLEXPRESS;Initial Catalog=TICKET;Integrated Security=True; Encrypt=False"
    Private administracionForm As Administracion
    Public Sub Administracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdministracionManual.Visible = False
        AdministracionVersion.Visible = False
        AdministracionReporte.Visible = False
        AdministracionItinerario.Visible = False
        AdministracionCrearSoporte.Visible = False
        AdministracionActualizarSoporte.Visible = False
        AdministracionCerrarSoporte.Visible = False
        AdministracionCrearEquipo.Visible = False

        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim command As New SqlCommand("SELECT Nombre FROM USUARIOS WHERE Nombre LIKE '%Equipo%'", connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        While reader.Read()
            AdministracionCBEquipo.Items.Add(reader("Nombre").ToString())
        End While
        reader.Close()
        connection.Close()

        Dim connection2 As New SqlConnection(connectionString)
        connection2.Open()
        Dim command2 As New SqlCommand("SELECT TipoSoporte FROM PRECIOSOPORTE", connection2)
        Dim reader2 As SqlDataReader = command2.ExecuteReader()
        While reader2.Read()
            AdministracionTBTipoSoporte.Items.Add(reader2("TipoSoporte").ToString())
        End While
        reader2.Close()
        connection2.Close()
    End Sub

    Private Sub ShowPanel(panel As Panel)
        Dim container As Control = panel.Parent

        For Each p As Panel In container.Controls.OfType(Of Panel)()
            p.Visible = False
        Next

        panel.Visible = True
    End Sub

    Private Sub CerrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem1.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub AgendarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendarToolStripMenuItem.Click
        ShowPanel(AdministracionCrearSoporte)
    End Sub
    'Boton Actualizar soporte
    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        ShowPanel(AdministracionActualizarSoporte)
        Dim connection6 As New SqlConnection(connectionString)
        connection6.Open()
        Dim command6 As New SqlCommand("SELECT IdTicket FROM TICKETS WHERE Estado = 'Abierto'", connection6)
        Dim reader6 As SqlDataReader = command6.ExecuteReader()
        AdministracionCBActualizarSoporte.Items.Clear()
        While reader6.Read()
            AdministracionCBActualizarSoporte.Items.Add(reader6("IdTicket").ToString())
        End While
        reader6.Close()
    End Sub
    '----------------------- Boton Cerrar soporte -----------------------------------------
    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        ShowPanel(AdministracionCerrarSoporte)
        Dim connection7 As New SqlConnection(connectionString)
        connection7.Open()
        Dim command7 As New SqlCommand("SELECT IdTicket FROM TICKETS WHERE Estado = 'Abierto'", connection7)
        Dim reader7 As SqlDataReader = command7.ExecuteReader()
        llenarDGCerrarReporte()
        AdministracionCBCerrarSoporte.Items.Clear()
        While reader7.Read()
            AdministracionCBCerrarSoporte.Items.Add(reader7("IdTicket").ToString())
        End While
        reader7.Close()
    End Sub
    ' Funcion para llenar el datagrid 
    Public Sub llenarDGCerrarReporte()
        Dim cmd As SqlCommand
        Dim connection7 As New SqlConnection(connectionString)
        connection7.Open()
        cmd = New SqlCommand("SELECT *from TICKETS WHERE Estado = 'Abierto' ", connection7) 'hacemos el query de la tabla Books Authors
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DGSeleccionarSoporte.DataSource = dt
    End Sub
    Private Sub CrearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearToolStripMenuItem.Click
        ShowPanel(AdministracionCrearEquipo)
    End Sub

    Private Sub ItinerarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItinerarioToolStripMenuItem.Click
        ShowPanel(AdministracionItinerario)
        PopulateDGItinerario()
    End Sub


    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click
        ShowPanel(AdministracionReporte)
        PopulateDGReporte()
    End Sub

    Private Sub ManualDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click
        ShowPanel(AdministracionManual)
    End Sub

    Private Sub VersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionToolStripMenuItem.Click
        ShowPanel(AdministracionVersion)
    End Sub

    Private Sub AdministracionBtnCrearEquipo_Click(sender As Object, e As EventArgs) Handles AdministracionBtnCrearEquipo.Click
        Dim idUsuario As Integer = GetNextIdUsuario()
        Dim nombre As String = "Equipo" & (idUsuario - 1).ToString()
        Dim usuario As String = "equipo" & (idUsuario - 1).ToString()
        Dim contrasena As String = "equipo" & (idUsuario - 1).ToString()
        Dim sql As String = "INSERT INTO USUARIOS (IdUsuario, Nombre, Usuario, Contrasena) " &
                        "VALUES (@IdUsuario, @Nombre, @Usuario, @Contrasena)"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@IdUsuario", idUsuario)
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@Usuario", usuario)
                command.Parameters.AddWithValue("@Contrasena", contrasena)
                AdministracionTBNombreEquipo.Text = nombre
                AdministracionTBUsuarioEquipo.Text = usuario
                AdministracionTBContrasenaEquipo.Text = contrasena
                command.ExecuteNonQuery()
            End Using

            connection.Close()
            AdministracionTBNombreEquipo.Clear()
            AdministracionTBUsuarioEquipo.Clear()
            AdministracionTBContrasenaEquipo.Clear()
        End Using
        MessageBox.Show("Equipo creado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Function GetNextIdUsuario() As Integer
        Dim nextIdUsuario As Integer = 1
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sql As String = "SELECT MAX(IdUsuario) FROM USUARIOS"
            Using command As New SqlCommand(sql, connection)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    nextIdUsuario = Convert.ToInt32(result) + 1
                End If
            End Using
            connection.Close()
        End Using
        Return nextIdUsuario
    End Function

    Private Sub AdministracionBtnCrearSoporte_Click(sender As Object, e As EventArgs) Handles AdministracionBtnCrearSoporte.Click
        If String.IsNullOrWhiteSpace(AdministracionTBCliente.Text) OrElse String.IsNullOrWhiteSpace(AdministracionCBEquipo.Text) OrElse String.IsNullOrWhiteSpace(AdministracionTBTipoSoporte.Text) OrElse AdministracionMCInicio.SelectionRange.Start = Date.MinValue OrElse AdministracionMCFinal.SelectionRange.Start = Date.MinValue Then
            MessageBox.Show("Por favor ingrese todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            Dim cliente As String = AdministracionTBCliente.Text
            Dim equipo As String = AdministracionCBEquipo.Text
            Dim tipoSoporte As String = AdministracionTBTipoSoporte.Text
            Dim fechaInicio As Date = AdministracionMCInicio.SelectionRange.Start
            Dim fechaFin As Date = AdministracionMCFinal.SelectionRange.Start
            Dim numDays As Integer = (fechaFin - fechaInicio).Days + 1
            Dim precioSoporte As Decimal = FetchPrecioSoporte(tipoSoporte)
            Dim nextID As Integer = GetNextIdTicket()
            Dim costoInicio As Decimal = numDays * precioSoporte
            SaveTicket(nextID, cliente, equipo, tipoSoporte, fechaInicio, fechaFin, costoInicio)
            AdministracionTBCostoInicial.Text = costoInicio.ToString()
            AdministracionTBCliente.Clear()
            AdministracionTBCostoInicial.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Funcion para buscar el precio del tipo de soporte a realizar
    Private Function FetchPrecioSoporte(tipoSoporte As String) As Decimal
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("SELECT PrecioSoporte FROM PRECIOSOPORTE WHERE TipoSoporte = @TipoSoporte", connection)
            command.Parameters.AddWithValue("@TipoSoporte", tipoSoporte)
            Dim precioSoporte As Object = command.ExecuteScalar()

            If precioSoporte IsNot Nothing AndAlso Not DBNull.Value.Equals(precioSoporte) Then
                Return Convert.ToDecimal(precioSoporte)
            Else
                Throw New Exception("Precio no encontrado.")
            End If
            connection.Close()
        End Using
    End Function
    ' Funcion para aumentar el id del ticket generado
    Private Function GetNextIdTicket() As Integer
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("SELECT MAX(IdTicket) FROM TICKETS", connection)
            Dim result As Object = command.ExecuteScalar()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                Return Convert.ToInt32(result) + 1
            Else
                Return 1
            End If
            connection.Close()
        End Using
    End Function

    Private Sub SaveTicket(idTicket As Integer, cliente As String, equipo As String, tipoSoporte As String, fechaInicio As Date, fechaFin As Date, costoInicio As Decimal)
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim commandConflict As New SqlCommand("SELECT COUNT(*) FROM TICKETS WHERE Equipo = @Equipo AND Estado = 'Abierto' AND ((FechadeInicio <= @FechaFin AND FechaFin >= @FechaInicio) OR (FechadeInicio >= @FechaInicio AND FechaFin <= @FechaFin) OR (FechadeInicio <= @FechaInicio AND FechaFin >= @FechaFin))", connection)
            commandConflict.Parameters.AddWithValue("@Equipo", equipo)
            commandConflict.Parameters.AddWithValue("@FechaInicio", fechaInicio)
            commandConflict.Parameters.AddWithValue("@FechaFin", fechaFin)
            Dim conflictCount As Integer = Convert.ToInt32(commandConflict.ExecuteScalar())
            If conflictCount > 0 Then
                MessageBox.Show("Las fechas se traslapan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim commandInsert As New SqlCommand("INSERT INTO TICKETS (IdTicket, Cliente, Equipo, TipodeSoporte, FechadeInicio, FechaFin, CostoInicio, Estado) VALUES (@IdTicket, @Cliente, @Equipo, @TipoSoporte, @FechaInicio, @FechaFin, @CostoInicio, @Estado)", connection)
            Dim estado As String = "Abierto"
            commandInsert.Parameters.AddWithValue("@IdTicket", idTicket)
            commandInsert.Parameters.AddWithValue("@Cliente", cliente)
            commandInsert.Parameters.AddWithValue("@Equipo", equipo)
            commandInsert.Parameters.AddWithValue("@TipoSoporte", tipoSoporte)
            commandInsert.Parameters.AddWithValue("@FechaInicio", fechaInicio)
            commandInsert.Parameters.AddWithValue("@FechaFin", fechaFin)
            commandInsert.Parameters.AddWithValue("@CostoInicio", costoInicio)
            commandInsert.Parameters.AddWithValue("@Estado", estado)
            commandInsert.ExecuteNonQuery()
            MessageBox.Show("Ticket creado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
        End Using
    End Sub

    Private Sub AdministracionBtnActualizarSoporte_Click(sender As Object, e As EventArgs) Handles AdministracionBtnActualizarSoporte.Click
        If String.IsNullOrWhiteSpace(AdministracionCBActualizarSoporte.Text) OrElse String.IsNullOrWhiteSpace(AdministracionNDActualizarSoporte.Text) OrElse String.IsNullOrWhiteSpace(AdministracionTBComentario.Text) Then
            MessageBox.Show("Por favor ingrese todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            Dim ticketid As Integer = AdministracionCBActualizarSoporte.Text
            Dim costoadicional As Decimal = AdministracionNDActualizarSoporte.Text
            Dim comentario As String = AdministracionTBComentario.Text
            UpdateTicket(ticketid, costoadicional, comentario)
            AdministracionTBComentario.Clear()
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

    Private Sub AdministracionBtnCerrarSoporte_Click(sender As Object, e As EventArgs) Handles AdministracionBtnCerrarSoporte.Click
        If String.IsNullOrWhiteSpace(AdministracionCBCerrarSoporte.Text) Then
            MessageBox.Show("Por favor ingrese todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            Dim ticketid As Integer = Convert.ToInt32(AdministracionCBCerrarSoporte.Text)
            CloseTicket(ticketid)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Cierra el ticket 
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
    ' Llenar Data grid de Itinerario, los soportes abiertos  
    Private Sub PopulateDGItinerario()
        AdministracionDGItinerario.Columns.Clear()
        AdministracionDGItinerario.Rows.Clear()
        AdministracionDGItinerario.Columns.Add("IdTicket", "Id de Ticket")
        AdministracionDGItinerario.Columns.Add("Cliente", "Cliente")
        AdministracionDGItinerario.Columns.Add("Equipo", "Equipo")
        AdministracionDGItinerario.Columns.Add("TipoSoporte", "Tipo de Soporte")
        AdministracionDGItinerario.Columns.Add("FechaInicio", "Fecha de Inicio")
        AdministracionDGItinerario.Columns.Add("FechaFin", "Fecha de Fin")
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("SELECT IdTicket, Cliente, Equipo, TipodeSoporte, FechadeInicio, FechaFin FROM TICKETS WHERE Estado = 'Abierto'", connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim idTicket As Integer = Convert.ToInt32(reader("IdTicket"))
                Dim cliente As String = reader("Cliente").ToString()
                Dim equipo As String = reader("Equipo").ToString()
                Dim tipoSoporte As String = reader("TipodeSoporte").ToString()
                Dim fechaInicio As Date = Convert.ToDateTime(reader("FechadeInicio"))
                Dim fechaFin As Date = Convert.ToDateTime(reader("FechaFin"))
                Dim formattedFechaInicio As String = fechaInicio.ToString("dd/MM/yyyy")
                Dim formattedFechaFin As String = fechaFin.ToString("dd/MM/yyyy")
                AdministracionDGItinerario.Rows.Add(idTicket, cliente, equipo, tipoSoporte, formattedFechaInicio, formattedFechaFin)
            End While
            reader.Close()
            connection.Close()
        End Using
    End Sub

    ' funcion para llenar el data grid REPORTE
    Private Sub PopulateDGReporte()
        AdministracionDGReporte.Columns.Clear()
        AdministracionDGReporte.Rows.Clear()
        AdministracionDGReporte.Columns.Add("IdTicket", "Id de Ticket")
        AdministracionDGReporte.Columns.Add("Cliente", "Cliente")
        AdministracionDGReporte.Columns.Add("Equipo", "Equipo")
        AdministracionDGReporte.Columns.Add("TipoSoporte", "Tipo de Soporte")
        AdministracionDGReporte.Columns.Add("FechaInicio", "Fecha de Inicio")
        AdministracionDGReporte.Columns.Add("FechaFin", "Fecha de Fin")
        AdministracionDGReporte.Columns.Add("CostoInicio", "Costo Inicial")
        AdministracionDGReporte.Columns.Add("CostoAdicional", "Costos Adicionales")
        AdministracionDGReporte.Columns.Add("Comentarios", "Comentarios")
        AdministracionDGReporte.Columns.Add("CostoTotal", "Costo Total")

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("SELECT IdTicket, Cliente, Equipo, TipodeSoporte, FechadeInicio, FechaFin, CostoInicio, CostoAdicional, Comentarios, CostoTotal FROM TICKETS WHERE Estado = 'Cerrado'", connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim idTicket As Integer = Convert.ToInt32(reader("IdTicket"))
                Dim cliente As String = reader("Cliente").ToString()
                Dim equipo As String = reader("Equipo").ToString()
                Dim tipoSoporte As String = reader("TipodeSoporte").ToString()
                Dim fechaInicio As Date = Convert.ToDateTime(reader("FechadeInicio"))
                Dim fechaFin As Date = Convert.ToDateTime(reader("FechaFin"))
                Dim formattedFechaInicio As String = fechaInicio.ToString("dd/MM/yyyy")
                Dim formattedFechaFin As String = fechaFin.ToString("dd/MM/yyyy")
                Dim costoinicial As Decimal = reader("CostoInicio")
                Dim costoadicional As Decimal? = If(reader.IsDBNull(reader.GetOrdinal("CostoAdicional")), Nothing, Convert.ToDecimal(reader("CostoAdicional")))
                Dim comentarios As String = If(reader.IsDBNull(reader.GetOrdinal("Comentarios")), "", reader("Comentarios").ToString())
                Dim costototal As Decimal = reader("CostoTotal")
                Dim formattedCostoInicial As String = costoinicial.ToString("0.00")
                Dim formattedCostoAdicional As String = If(costoadicional.HasValue, costoadicional.Value.ToString("0.00"), "")
                Dim formattedCostoTotal As String = costototal.ToString("0.00")
                AdministracionDGReporte.Rows.Add(idTicket, cliente, equipo, tipoSoporte, formattedFechaInicio, formattedFechaFin, formattedCostoInicial, formattedCostoAdicional, comentarios, formattedCostoTotal)
            End While
            reader.Close()
            connection.Close()
        End Using


    End Sub
    ' ------- Boton para exportar los clientes de soportes cerrados
    Private Sub AdministracionBtnExportarReporte_Click(sender As Object, e As EventArgs) Handles AdministracionBtnExportarReporte.Click
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Using excelPackage As New ExcelPackage()
            Dim worksheet As ExcelWorksheet = excelPackage.Workbook.Worksheets.Add("Reporte")
            For i As Integer = 0 To AdministracionDGReporte.Columns.Count - 1
                worksheet.Cells(1, i + 1).Value = AdministracionDGReporte.Columns(i).HeaderText
            Next

            For i As Integer = 0 To AdministracionDGReporte.Rows.Count - 1
                For j As Integer = 0 To AdministracionDGReporte.Columns.Count - 1
                    Dim value As Object = AdministracionDGReporte.Rows(i).Cells(j).Value
                    If j = 6 Or j = 7 Then
                        If value IsNot Nothing AndAlso Not DBNull.Value.Equals(value) Then
                            Dim decimalValue As Decimal = Convert.ToDecimal(value)
                            worksheet.Cells(i + 2, j + 1).Value = decimalValue
                            worksheet.Cells(i + 2, j + 1).Style.Numberformat.Format = "0.00"
                        End If
                    ElseIf j = 9 Then
                        If value IsNot Nothing AndAlso Not DBNull.Value.Equals(value) Then
                            Dim decimalValue As Decimal = Convert.ToDecimal(value)
                            worksheet.Cells(i + 2, j + 1).Value = decimalValue
                            worksheet.Cells(i + 2, j + 1).Style.Numberformat.Format = "0.00"
                        End If
                    Else
                        worksheet.Cells(i + 2, j + 1).Value = value
                    End If
                Next
            Next

            Dim lastRowIndex As Integer = AdministracionDGReporte.Rows.Count + 1
            Dim costoTotalColumnRange As ExcelRange = worksheet.Cells(2, 10, lastRowIndex, 10)
            costoTotalColumnRange.Style.Numberformat.Format = "0.00"
            Dim sumFormula As String = $"SUM(J2:J{lastRowIndex})"
            worksheet.Cells(lastRowIndex + 1, 10).Formula = sumFormula
            worksheet.Cells(lastRowIndex + 1, 9).Value = "Total Reporte"

            For i As Integer = 1 To AdministracionDGReporte.Columns.Count
                worksheet.Column(i).AutoFit()
            Next

            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
            saveFileDialog.Title = "Save Excel File"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim file As New FileInfo(saveFileDialog.FileName)
                excelPackage.SaveAs(file)
                MessageBox.Show("Excel guardado exitosamente")
            End If
        End Using
    End Sub

End Class