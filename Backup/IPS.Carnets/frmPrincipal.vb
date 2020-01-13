Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports WIA
Imports WIA_Scripting_Library
Imports System.IO
Imports System.Drawing.Text


Public Class formCarnets

    Private _ParaAfiliado As Boolean = True
    Private retriever As New ImageRetriever

    Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonBuscar.Click
        GroupBoxApoderado.Enabled = False
        GroupBoxFoto.Enabled = False
        ButtonSeleccionarAfiliado.Enabled = False
        Try
            DatosAfiliadoTableAdapter1.FillByPOA(LiquidacionDataSet1.DatosAfiliado, _
                                             textboxPlla.Text, textboxOrden.Text, _
                                             textboxAfiliado.Text)
            ApoderadoTableAdapter1.FillByPOA(LiquidacionDataSet1.Apoderado, _
                                             textboxPlla.Text, textboxOrden.Text, _
                                             textboxAfiliado.Text)
        Catch ex As Exception
            MsgBox("Error al conectar a la Base de Datos..." + ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try
        Try
            If LiquidacionDataSet1.DatosAfiliado.Count > 0 Then
                ButtonSeleccionarAfiliado.Enabled = True
                Me.Text = "Impresion de Carnets " + BindingSourceAfiliado.Current("NOMBRE")
                If LiquidacionDataSet1.Apoderado.Count > 0 Then
                    GroupBoxApoderado.Enabled = True
                End If
            Else
                Me.Text = "Impresion de Carnets"
                MsgBox("No se encontraron afiliados con esos numeros de plla orden y afiliado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                textboxPlla.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

    End Sub

    Private Sub formCarnets_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If My.User.CurrentPrincipal.Identity.AuthenticationType = "Kerberos" Then
                If Not (My.User.IsInRole("IPS\Operadores de Carnet")) Then
                    MsgBox("El usuario " + My.User.Name + " no es un usuario con permisos para utilizar esta aplicación." & _
                            " Debe poseer una cuenta en el grupo IPS\Operadores de Carnet", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                    Application.Exit()
                End If
            Else
                If InputBox("Ingrese contraseña de administración alternativa") <> "carnets" Then
                    Application.Exit()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            Application.Exit()
        End Try
        
    End Sub

    Private Sub HideMainReportButton()
        For Each c1 As Control In CrystalReportViewer1.Controls
            If c1.GetType Is GetType(CrystalDecisions.Windows.Forms.PageView) Then
                Dim pv As CrystalDecisions.Windows.Forms.PageView = c1
                For Each c2 As Control In pv.Controls
                    If c2.GetType Is GetType(TabControl) Then
                        Dim tc As TabControl = c2
                        tc.ItemSize = New Size(0, 1)
                        tc.SizeMode = TabSizeMode.Fixed
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub ButtonSeleccionarApoderado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSeleccionarApoderado.Click
        GroupBoxAfiliado.Enabled = False
        GroupBoxApoderado.Enabled = False
        GroupBoxFoto.Enabled = True
        _ParaAfiliado = False
    End Sub

    Private Sub ButtonSeleccionarAfiliado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSeleccionarAfiliado.Click
        GroupBoxApoderado.Enabled = False
        GroupBoxFoto.Enabled = True
        _ParaAfiliado = True
    End Sub

    Private Sub SacarFotoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SacarFotoButton.Click
        Try

            Dim dlg As New CommonDialog
            'Dim dev As Device = dlg.ShowSelectDevice(WiaDeviceType.UnspecifiedDeviceType, True)

            'Dim image As Image = dlg.ShowAcquireImage(, WiaImageIntent.ColorIntent, WiaImageBias.MaximizeQuality, , False, False, True)
            'Dim imagen As Image = dev.ExecuteCommand("wiaCommandTakePicture")

            Dim images As List(Of Bitmap) = retriever.RetriveImages(ImageSelectionMode.One)

            ''REDIMENSIONO LA IMAGEN PARA QUE NO SALGA ESTIRADA
            Dim bmp As New Bitmap(480, 480, Imaging.PixelFormat.Format24bppRgb)
            Dim gr As Graphics
            gr = Graphics.FromImage(bmp)
            gr.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            gr.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            gr.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
            Dim width As Integer = images(0).Width
            Dim heigth As Integer = images(0).Height
            Dim destino As Rectangle = New Rectangle(0, 0, 480, 480)
            Dim origen As Rectangle = New Rectangle(80, 0, 480, 480)

            gr.DrawImage(images(0), destino, origen, GraphicsUnit.Pixel)

            PictureBox1.Image = bmp
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        Dim sqlcnn As New SqlConnection(My.Settings.CARNETSConnectionString)
        Dim sqlcnnCarnet As New SqlConnection(My.Settings.CARNETSConnectionString)
        Dim ms As New MemoryStream
        Dim _Existe As Boolean = False

        Try
            PictureBox1.Image.Save(ms, Imaging.ImageFormat.Jpeg)
        Catch ex As NullReferenceException
            MsgBox("Imagen vacia ...", MsgBoxStyle.OkOnly)
            Exit Sub
        End Try
        sqlcnn.Open()
        sqlcnnCarnet.Open()
        Try
            If _ParaAfiliado Then
                Dim sqlcmmAfiliadoExiste As New SqlCommand("SELECT COUNT(*) FROM AFILIADOS WHERE CONTROL = " + _
                                                          BindingSourceAfiliado.Current("CONTROL").ToString, sqlcnnCarnet)
                Dim sqlcmmAfiliado As New SqlCommand("", sqlcnnCarnet)
                ''SI EXISTE EL AFILIADO, PUEDO ACTUALIZAR LA FOTO
                If sqlcmmAfiliadoExiste.ExecuteScalar > 0 Then
                    _Existe = True
                    sqlcmmAfiliado.CommandText = "UPDATE AFILIADOS SET FOTO=@FOTO WHERE CONTROL=@CONTROL"
                Else
                    sqlcmmAfiliado.CommandText = "INSERT INTO AFILIADOS(CONTROL, FOTO) VALUES(@CONTROL, @FOTO)"
                End If

                sqlcmmAfiliado.Parameters.Add("CONTROL", SqlDbType.Int)
                sqlcmmAfiliado.Parameters.Add("FOTO", SqlDbType.Image)

                sqlcmmAfiliado.Parameters("CONTROL").Value = BindingSourceAfiliado.Current("CONTROL")
                sqlcmmAfiliado.Parameters("FOTO").Value = ms.GetBuffer

                If _Existe Then
                    If MsgBox("Ya existe ¿Desea actualizar la foto para el afiliado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        If sqlcmmAfiliado.ExecuteNonQuery() > 0 Then
                            MsgBox("Foto guardada ... ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                        End If
                    End If
                Else
                    If sqlcmmAfiliado.ExecuteNonQuery() > 0 Then
                        MsgBox("Foto guardada ... ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    End If
                End If
            Else
                Dim sqlcmmApoderadoExiste As New SqlCommand("SELECT COUNT(*) FROM APODERADOS WHERE ID=" + BindingSourceApoderado.Current("INTERNO").ToString, sqlcnnCarnet)
                Dim sqlcmmApoderado As New SqlCommand("", sqlcnn)

                If sqlcmmApoderadoExiste.ExecuteScalar > 0 Then
                    _Existe = True
                    sqlcmmApoderado.CommandText = "UPDATE APODERADOS SET FOTO=@FOTO WHERE ID=@ID"
                Else
                    sqlcmmApoderado.CommandText = "INSERT INTO APODERADOS(ID, FOTO) VALUES(@ID, @FOTO)"
                End If

                sqlcmmApoderado.Parameters.Add("ID", SqlDbType.Int)
                sqlcmmApoderado.Parameters.Add("FOTO", SqlDbType.Image)

                sqlcmmApoderado.Parameters("ID").Value = BindingSourceApoderado.Current("INTERNO")
                sqlcmmApoderado.Parameters("FOTO").Value = ms.GetBuffer

                If _Existe Then
                    If MsgBox("Ya existe ¿Desea actualizar la foto para el afiliado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        If sqlcmmApoderado.ExecuteNonQuery() > 0 Then
                            MsgBox("Foto guardada ... ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                        End If
                    End If
                Else
                    If sqlcmmApoderado.ExecuteNonQuery() > 0 Then
                        MsgBox("Foto guardada ... ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    End If
                End If
            End If
            sqlcnn.Close()
            sqlcnnCarnet.Close()
            ms.Close()
            ms.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub ButtonCarnet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCarnet.Click
        GroupBoxAfiliado.Enabled = True
        Dim report As New ReportDocument
        Dim conn As String() = My.Settings.LiquidacionConnectionString.Split(";")
        Dim server = conn(0).Substring(12)
        Dim database = conn(1).Substring(16)
        Try
            If _ParaAfiliado Then
                ''Cargamos el carnet del afiliado
                report.Load("reports/Carnet.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                report.DataSourceConnections(0).SetConnection(server, database, True)
                report.SetParameterValue("AFILIADO", textboxAfiliado.Text)
                report.SetParameterValue("ORDEN", textboxOrden.Text)
                report.SetParameterValue("PLLA", textboxPlla.Text)
            Else
                ''Cargamos el carnet del apoderado
                report.Load("reports/CarnetApoderado.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                report.DataSourceConnections(0).SetConnection(server, database, True)
                report.SetParameterValue("AFILIADO", textboxAfiliado.Text)
                report.SetParameterValue("ORDEN", textboxOrden.Text)
                report.SetParameterValue("PLLA", textboxPlla.Text)
                report.SetParameterValue("ID", BindingSourceApoderado.CurrencyManager.Current("INTERNO"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CrystalReportViewer1.ReportSource = report
        HideMainReportButton()
    End Sub

    Private Sub textboxPlla_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles textboxPlla.Enter, textboxOrden.Enter, textboxAfiliado.Enter
        sender.SelectAll()
    End Sub

    Private Sub textboxPlla_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textboxPlla.TextChanged
        If Len(textboxPlla.Text) = 3 Then
            textboxOrden.Focus()
        End If
    End Sub

    Private Sub textboxOrden_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textboxOrden.TextChanged
        If Len(textboxOrden.Text) = 4 Then
            textboxAfiliado.Focus()
        End If
    End Sub
End Class
