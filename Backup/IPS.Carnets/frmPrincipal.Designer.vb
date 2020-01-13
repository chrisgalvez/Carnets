<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCarnets
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCarnets))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.textboxPlla = New System.Windows.Forms.TextBox
        Me.textboxOrden = New System.Windows.Forms.TextBox
        Me.textboxAfiliado = New System.Windows.Forms.TextBox
        Me.buttonBuscar = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.listboxApoderados = New System.Windows.Forms.ListBox
        Me.BindingSourceApoderado = New System.Windows.Forms.BindingSource(Me.components)
        Me.LiquidacionDataSet1 = New IPS.Carnets.LiquidacionDataSet
        Me.TextBoxNombre = New System.Windows.Forms.TextBox
        Me.BindingSourceAfiliado = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosAfiliadoTableAdapter1 = New IPS.Carnets.LiquidacionDataSetTableAdapters.DatosAfiliadoTableAdapter
        Me.ApoderadoTableAdapter1 = New IPS.Carnets.LiquidacionDataSetTableAdapters.ApoderadoTableAdapter
        Me.ButtonSeleccionarAfiliado = New System.Windows.Forms.Button
        Me.ButtonSeleccionarApoderado = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SacarFotoButton = New System.Windows.Forms.Button
        Me.ButtonGuardar = New System.Windows.Forms.Button
        Me.CarnetsDataSet1 = New IPS.Carnets.CARNETSDataSet
        Me.FotosTableAdapter1 = New IPS.Carnets.CARNETSDataSetTableAdapters.fotosTableAdapter
        Me.GroupBoxAfiliado = New System.Windows.Forms.GroupBox
        Me.GroupBoxApoderado = New System.Windows.Forms.GroupBox
        Me.GroupBoxFoto = New System.Windows.Forms.GroupBox
        Me.ButtonCarnet = New System.Windows.Forms.Button
        CType(Me.BindingSourceApoderado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiquidacionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceAfiliado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarnetsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAfiliado.SuspendLayout()
        Me.GroupBoxApoderado.SuspendLayout()
        Me.GroupBoxFoto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plla"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Orden"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Afiliado"
        '
        'textboxPlla
        '
        Me.textboxPlla.Location = New System.Drawing.Point(9, 32)
        Me.textboxPlla.MaxLength = 3
        Me.textboxPlla.Name = "textboxPlla"
        Me.textboxPlla.Size = New System.Drawing.Size(43, 20)
        Me.textboxPlla.TabIndex = 3
        Me.textboxPlla.Text = "000"
        '
        'textboxOrden
        '
        Me.textboxOrden.Location = New System.Drawing.Point(58, 32)
        Me.textboxOrden.MaxLength = 4
        Me.textboxOrden.Name = "textboxOrden"
        Me.textboxOrden.Size = New System.Drawing.Size(51, 20)
        Me.textboxOrden.TabIndex = 4
        Me.textboxOrden.Text = "0000"
        '
        'textboxAfiliado
        '
        Me.textboxAfiliado.Location = New System.Drawing.Point(117, 32)
        Me.textboxAfiliado.MaxLength = 6
        Me.textboxAfiliado.Name = "textboxAfiliado"
        Me.textboxAfiliado.Size = New System.Drawing.Size(64, 20)
        Me.textboxAfiliado.TabIndex = 5
        Me.textboxAfiliado.Text = "000000"
        '
        'buttonBuscar
        '
        Me.buttonBuscar.Location = New System.Drawing.Point(9, 58)
        Me.buttonBuscar.Name = "buttonBuscar"
        Me.buttonBuscar.Size = New System.Drawing.Size(75, 23)
        Me.buttonBuscar.TabIndex = 6
        Me.buttonBuscar.TabStop = False
        Me.buttonBuscar.Text = "Buscar"
        Me.buttonBuscar.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayBackgroundEdge = False
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(11, 162)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowExportButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowPageNavigateButtons = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(769, 392)
        Me.CrystalReportViewer1.TabIndex = 7
        Me.CrystalReportViewer1.TabStop = False
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'listboxApoderados
        '
        Me.listboxApoderados.DataSource = Me.BindingSourceApoderado
        Me.listboxApoderados.DisplayMember = "NOMBRE"
        Me.listboxApoderados.FormattingEnabled = True
        Me.listboxApoderados.Location = New System.Drawing.Point(9, 32)
        Me.listboxApoderados.Name = "listboxApoderados"
        Me.listboxApoderados.Size = New System.Drawing.Size(193, 82)
        Me.listboxApoderados.TabIndex = 8
        '
        'BindingSourceApoderado
        '
        Me.BindingSourceApoderado.DataMember = "Apoderado"
        Me.BindingSourceApoderado.DataSource = Me.LiquidacionDataSet1
        '
        'LiquidacionDataSet1
        '
        Me.LiquidacionDataSet1.DataSetName = "LiquidacionDataSet"
        Me.LiquidacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceAfiliado, "NOMBRE", True))
        Me.TextBoxNombre.Enabled = False
        Me.TextBoxNombre.Location = New System.Drawing.Point(9, 88)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxNombre.TabIndex = 10
        Me.TextBoxNombre.TabStop = False
        '
        'BindingSourceAfiliado
        '
        Me.BindingSourceAfiliado.AllowNew = False
        Me.BindingSourceAfiliado.DataMember = "DatosAfiliado"
        Me.BindingSourceAfiliado.DataSource = Me.LiquidacionDataSet1
        '
        'DatosAfiliadoTableAdapter1
        '
        Me.DatosAfiliadoTableAdapter1.ClearBeforeFill = True
        '
        'ApoderadoTableAdapter1
        '
        Me.ApoderadoTableAdapter1.ClearBeforeFill = True
        '
        'ButtonSeleccionarAfiliado
        '
        Me.ButtonSeleccionarAfiliado.Enabled = False
        Me.ButtonSeleccionarAfiliado.Location = New System.Drawing.Point(9, 114)
        Me.ButtonSeleccionarAfiliado.Name = "ButtonSeleccionarAfiliado"
        Me.ButtonSeleccionarAfiliado.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSeleccionarAfiliado.TabIndex = 11
        Me.ButtonSeleccionarAfiliado.TabStop = False
        Me.ButtonSeleccionarAfiliado.Text = "Seleccionar"
        Me.ButtonSeleccionarAfiliado.UseVisualStyleBackColor = True
        '
        'ButtonSeleccionarApoderado
        '
        Me.ButtonSeleccionarApoderado.Location = New System.Drawing.Point(127, 117)
        Me.ButtonSeleccionarApoderado.Name = "ButtonSeleccionarApoderado"
        Me.ButtonSeleccionarApoderado.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSeleccionarApoderado.TabIndex = 12
        Me.ButtonSeleccionarApoderado.Text = "Seleccionar"
        Me.ButtonSeleccionarApoderado.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(16, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'SacarFotoButton
        '
        Me.SacarFotoButton.Location = New System.Drawing.Point(166, 30)
        Me.SacarFotoButton.Name = "SacarFotoButton"
        Me.SacarFotoButton.Size = New System.Drawing.Size(103, 23)
        Me.SacarFotoButton.TabIndex = 14
        Me.SacarFotoButton.Text = "Sacar Foto"
        Me.SacarFotoButton.UseVisualStyleBackColor = True
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Location = New System.Drawing.Point(166, 71)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(103, 23)
        Me.ButtonGuardar.TabIndex = 15
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'CarnetsDataSet1
        '
        Me.CarnetsDataSet1.DataSetName = "CARNETSDataSet"
        Me.CarnetsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FotosTableAdapter1
        '
        Me.FotosTableAdapter1.ClearBeforeFill = True
        '
        'GroupBoxAfiliado
        '
        Me.GroupBoxAfiliado.Controls.Add(Me.Label1)
        Me.GroupBoxAfiliado.Controls.Add(Me.Label2)
        Me.GroupBoxAfiliado.Controls.Add(Me.Label3)
        Me.GroupBoxAfiliado.Controls.Add(Me.textboxPlla)
        Me.GroupBoxAfiliado.Controls.Add(Me.textboxOrden)
        Me.GroupBoxAfiliado.Controls.Add(Me.ButtonSeleccionarAfiliado)
        Me.GroupBoxAfiliado.Controls.Add(Me.textboxAfiliado)
        Me.GroupBoxAfiliado.Controls.Add(Me.TextBoxNombre)
        Me.GroupBoxAfiliado.Controls.Add(Me.buttonBuscar)
        Me.GroupBoxAfiliado.Location = New System.Drawing.Point(11, 8)
        Me.GroupBoxAfiliado.Name = "GroupBoxAfiliado"
        Me.GroupBoxAfiliado.Size = New System.Drawing.Size(194, 148)
        Me.GroupBoxAfiliado.TabIndex = 16
        Me.GroupBoxAfiliado.TabStop = False
        Me.GroupBoxAfiliado.Text = "Afiliado"
        '
        'GroupBoxApoderado
        '
        Me.GroupBoxApoderado.Controls.Add(Me.listboxApoderados)
        Me.GroupBoxApoderado.Controls.Add(Me.ButtonSeleccionarApoderado)
        Me.GroupBoxApoderado.Enabled = False
        Me.GroupBoxApoderado.Location = New System.Drawing.Point(222, 8)
        Me.GroupBoxApoderado.Name = "GroupBoxApoderado"
        Me.GroupBoxApoderado.Size = New System.Drawing.Size(211, 148)
        Me.GroupBoxApoderado.TabIndex = 17
        Me.GroupBoxApoderado.TabStop = False
        Me.GroupBoxApoderado.Text = "Apoderados"
        '
        'GroupBoxFoto
        '
        Me.GroupBoxFoto.Controls.Add(Me.ButtonCarnet)
        Me.GroupBoxFoto.Controls.Add(Me.PictureBox1)
        Me.GroupBoxFoto.Controls.Add(Me.SacarFotoButton)
        Me.GroupBoxFoto.Controls.Add(Me.ButtonGuardar)
        Me.GroupBoxFoto.Enabled = False
        Me.GroupBoxFoto.Location = New System.Drawing.Point(452, 8)
        Me.GroupBoxFoto.Name = "GroupBoxFoto"
        Me.GroupBoxFoto.Size = New System.Drawing.Size(285, 148)
        Me.GroupBoxFoto.TabIndex = 18
        Me.GroupBoxFoto.TabStop = False
        Me.GroupBoxFoto.Text = "Foto"
        '
        'ButtonCarnet
        '
        Me.ButtonCarnet.Location = New System.Drawing.Point(166, 114)
        Me.ButtonCarnet.Name = "ButtonCarnet"
        Me.ButtonCarnet.Size = New System.Drawing.Size(103, 23)
        Me.ButtonCarnet.TabIndex = 16
        Me.ButtonCarnet.Text = "Carnet"
        Me.ButtonCarnet.UseVisualStyleBackColor = True
        '
        'formCarnets
        '
        Me.AcceptButton = Me.buttonBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.GroupBoxFoto)
        Me.Controls.Add(Me.GroupBoxApoderado)
        Me.Controls.Add(Me.GroupBoxAfiliado)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "formCarnets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion de Carnets"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BindingSourceApoderado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiquidacionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceAfiliado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarnetsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAfiliado.ResumeLayout(False)
        Me.GroupBoxAfiliado.PerformLayout()
        Me.GroupBoxApoderado.ResumeLayout(False)
        Me.GroupBoxFoto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents textboxPlla As System.Windows.Forms.TextBox
    Friend WithEvents textboxOrden As System.Windows.Forms.TextBox
    Friend WithEvents textboxAfiliado As System.Windows.Forms.TextBox
    Friend WithEvents buttonBuscar As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents listboxApoderados As System.Windows.Forms.ListBox
    Friend WithEvents LiquidacionDataSet1 As IPS.Carnets.LiquidacionDataSet
    Friend WithEvents DatosAfiliadoTableAdapter1 As IPS.Carnets.LiquidacionDataSetTableAdapters.DatosAfiliadoTableAdapter
    Friend WithEvents ApoderadoTableAdapter1 As IPS.Carnets.LiquidacionDataSetTableAdapters.ApoderadoTableAdapter
    Friend WithEvents BindingSourceAfiliado As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSourceApoderado As System.Windows.Forms.BindingSource
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSeleccionarAfiliado As System.Windows.Forms.Button
    Friend WithEvents ButtonSeleccionarApoderado As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SacarFotoButton As System.Windows.Forms.Button
    Friend WithEvents ButtonGuardar As System.Windows.Forms.Button
    Friend WithEvents CarnetsDataSet1 As IPS.Carnets.CARNETSDataSet
    Friend WithEvents FotosTableAdapter1 As IPS.Carnets.CARNETSDataSetTableAdapters.fotosTableAdapter
    Friend WithEvents GroupBoxAfiliado As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxApoderado As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxFoto As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonCarnet As System.Windows.Forms.Button
End Class
