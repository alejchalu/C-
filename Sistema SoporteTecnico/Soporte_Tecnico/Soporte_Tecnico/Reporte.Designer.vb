<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnEnviar = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtCorreoCliente = New DevExpress.XtraEditors.TextEdit()
        Me.DeFechaInforme = New DevExpress.XtraEditors.DateEdit()
        Me.DeFechaSolucion = New DevExpress.XtraEditors.DateEdit()
        Me.TxtReportado = New DevExpress.XtraEditors.TextEdit()
        Me.MeCaso = New DevExpress.XtraEditors.MemoEdit()
        Me.MeSolucion = New DevExpress.XtraEditors.MemoEdit()
        Me.MePendiente = New DevExpress.XtraEditors.MemoEdit()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.CbeNombreCliente = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CbeAtendido = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.TeHoraSolucion = New DevExpress.XtraEditors.TimeEdit()
        Me.TeHoraReporte = New DevExpress.XtraEditors.TimeEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbeCasoSolucion = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.BarEnviando = New DevExpress.XtraEditors.ProgressBarControl()
        Me.LblEnviando = New DevExpress.XtraEditors.LabelControl()
        Me.BtnReenviar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TxtCorreoCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeFechaInforme.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeFechaInforme.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeFechaSolucion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeFechaSolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtReportado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MeCaso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MeSolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MePendiente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbeNombreCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbeAtendido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeHoraSolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeHoraReporte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbeCasoSolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarEnviando.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(40, 27)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(101, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nombre cliente:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(45, 57)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(96, 16)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Correo cliente:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(51, 83)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(90, 16)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Atendido por:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 113)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(129, 16)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Fecha informe caso:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(23, 141)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(118, 16)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Fecha de solución:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(29, 388)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(112, 16)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Hora de solución:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(41, 197)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(100, 16)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Reportado por:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(17, 169)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(124, 16)
        Me.LabelControl8.TabIndex = 7
        Me.LabelControl8.Text = "Hora reporte caso:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(105, 236)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(36, 16)
        Me.LabelControl9.TabIndex = 8
        Me.LabelControl9.Text = "Caso:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(83, 292)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl10.TabIndex = 9
        Me.LabelControl10.Text = "Solución:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(33, 345)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(108, 16)
        Me.LabelControl11.TabIndex = 10
        Me.LabelControl11.Text = "Tema pendiente:"
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEnviar.Appearance.Options.UseFont = True
        Me.BtnEnviar.Location = New System.Drawing.Point(150, 459)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(106, 36)
        Me.BtnEnviar.TabIndex = 13
        Me.BtnEnviar.Text = "Enviar"
        '
        'TxtCorreoCliente
        '
        Me.TxtCorreoCliente.Location = New System.Drawing.Point(147, 54)
        Me.TxtCorreoCliente.Name = "TxtCorreoCliente"
        Me.TxtCorreoCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreoCliente.Properties.Appearance.Options.UseFont = True
        Me.TxtCorreoCliente.Size = New System.Drawing.Size(252, 22)
        Me.TxtCorreoCliente.TabIndex = 2
        '
        'DeFechaInforme
        '
        Me.DeFechaInforme.EditValue = Nothing
        Me.DeFechaInforme.Location = New System.Drawing.Point(147, 110)
        Me.DeFechaInforme.Name = "DeFechaInforme"
        Me.DeFechaInforme.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeFechaInforme.Properties.Appearance.Options.UseFont = True
        Me.DeFechaInforme.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeFechaInforme.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.DeFechaInforme.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DeFechaInforme.Properties.VistaTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.DeFechaInforme.Size = New System.Drawing.Size(154, 22)
        Me.DeFechaInforme.TabIndex = 4
        '
        'DeFechaSolucion
        '
        Me.DeFechaSolucion.EditValue = Nothing
        Me.DeFechaSolucion.Location = New System.Drawing.Point(147, 138)
        Me.DeFechaSolucion.Name = "DeFechaSolucion"
        Me.DeFechaSolucion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeFechaSolucion.Properties.Appearance.Options.UseFont = True
        Me.DeFechaSolucion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeFechaSolucion.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.DeFechaSolucion.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DeFechaSolucion.Properties.VistaTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.DeFechaSolucion.Size = New System.Drawing.Size(154, 22)
        Me.DeFechaSolucion.TabIndex = 5
        '
        'TxtReportado
        '
        Me.TxtReportado.Location = New System.Drawing.Point(147, 194)
        Me.TxtReportado.Name = "TxtReportado"
        Me.TxtReportado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReportado.Properties.Appearance.Options.UseFont = True
        Me.TxtReportado.Size = New System.Drawing.Size(213, 22)
        Me.TxtReportado.TabIndex = 7
        '
        'MeCaso
        '
        Me.MeCaso.Location = New System.Drawing.Point(147, 222)
        Me.MeCaso.Name = "MeCaso"
        Me.MeCaso.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeCaso.Properties.Appearance.Options.UseFont = True
        Me.MeCaso.Size = New System.Drawing.Size(517, 49)
        Me.MeCaso.TabIndex = 8
        '
        'MeSolucion
        '
        Me.MeSolucion.Location = New System.Drawing.Point(147, 277)
        Me.MeSolucion.Name = "MeSolucion"
        Me.MeSolucion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeSolucion.Properties.Appearance.Options.UseFont = True
        Me.MeSolucion.Size = New System.Drawing.Size(517, 48)
        Me.MeSolucion.TabIndex = 9
        '
        'MePendiente
        '
        Me.MePendiente.Location = New System.Drawing.Point(147, 331)
        Me.MePendiente.Name = "MePendiente"
        Me.MePendiente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MePendiente.Properties.Appearance.Options.UseFont = True
        Me.MePendiente.Size = New System.Drawing.Size(517, 48)
        Me.MePendiente.TabIndex = 10
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Appearance.Options.UseFont = True
        Me.BtnCancelar.Location = New System.Drawing.Point(374, 459)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(106, 36)
        Me.BtnCancelar.TabIndex = 15
        Me.BtnCancelar.Text = "Cancelar"
        '
        'CbeNombreCliente
        '
        Me.CbeNombreCliente.EditValue = ""
        Me.CbeNombreCliente.Location = New System.Drawing.Point(147, 26)
        Me.CbeNombreCliente.Name = "CbeNombreCliente"
        Me.CbeNombreCliente.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.CbeNombreCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbeNombreCliente.Properties.Appearance.Options.UseFont = True
        Me.CbeNombreCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbeNombreCliente.Properties.NullText = ""
        Me.CbeNombreCliente.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CbeNombreCliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CbeNombreCliente.Properties.View = Me.GridLookUpEdit1View
        Me.CbeNombreCliente.Size = New System.Drawing.Size(252, 22)
        Me.CbeNombreCliente.TabIndex = 0
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'CbeAtendido
        '
        Me.CbeAtendido.EditValue = ""
        Me.CbeAtendido.Location = New System.Drawing.Point(147, 82)
        Me.CbeAtendido.Name = "CbeAtendido"
        Me.CbeAtendido.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.CbeAtendido.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbeAtendido.Properties.Appearance.Options.UseFont = True
        Me.CbeAtendido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbeAtendido.Properties.NullText = ""
        Me.CbeAtendido.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CbeAtendido.Properties.View = Me.GridView1
        Me.CbeAtendido.Size = New System.Drawing.Size(252, 22)
        Me.CbeAtendido.TabIndex = 3
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardar.Appearance.Options.UseFont = True
        Me.BtnGuardar.Location = New System.Drawing.Point(262, 459)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(106, 36)
        Me.BtnGuardar.TabIndex = 14
        Me.BtnGuardar.Text = "Guardar"
        '
        'TeHoraSolucion
        '
        Me.TeHoraSolucion.EditValue = New Date(1999, 1, 1, 0, 0, 0, 0)
        Me.TeHoraSolucion.Location = New System.Drawing.Point(147, 385)
        Me.TeHoraSolucion.Name = "TeHoraSolucion"
        Me.TeHoraSolucion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeHoraSolucion.Properties.Appearance.Options.UseFont = True
        Me.TeHoraSolucion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TeHoraSolucion.Properties.DisplayFormat.FormatString = "hh:mm:ss"
        Me.TeHoraSolucion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TeHoraSolucion.Properties.EditFormat.FormatString = "hh:mm:ss"
        Me.TeHoraSolucion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TeHoraSolucion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TeHoraSolucion.Size = New System.Drawing.Size(100, 22)
        Me.TeHoraSolucion.TabIndex = 11
        '
        'TeHoraReporte
        '
        Me.TeHoraReporte.EditValue = New Date(1999, 1, 1, 0, 0, 0, 0)
        Me.TeHoraReporte.Location = New System.Drawing.Point(147, 166)
        Me.TeHoraReporte.Name = "TeHoraReporte"
        Me.TeHoraReporte.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeHoraReporte.Properties.Appearance.Options.UseFont = True
        Me.TeHoraReporte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TeHoraReporte.Properties.DisplayFormat.FormatString = "hh:mm:ss"
        Me.TeHoraReporte.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TeHoraReporte.Properties.EditFormat.FormatString = "hh:mm:ss"
        Me.TeHoraReporte.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TeHoraReporte.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TeHoraReporte.Size = New System.Drawing.Size(100, 22)
        Me.TeHoraReporte.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(472, 38)
        Me.Label1.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.Label1.MinimumSize = New System.Drawing.Size(150, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 150)
        Me.Label1.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.Image = Global.Soporte_Tecnico.My.Resources.Resources.cropped_logo_site1__150x150
        Me.Label2.Location = New System.Drawing.Point(446, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 150)
        Me.Label2.TabIndex = 26
        '
        'CbeCasoSolucion
        '
        Me.CbeCasoSolucion.EditValue = ""
        Me.CbeCasoSolucion.Location = New System.Drawing.Point(147, 413)
        Me.CbeCasoSolucion.Name = "CbeCasoSolucion"
        Me.CbeCasoSolucion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.CbeCasoSolucion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbeCasoSolucion.Properties.Appearance.Options.UseFont = True
        Me.CbeCasoSolucion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbeCasoSolucion.Properties.NullText = ""
        Me.CbeCasoSolucion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CbeCasoSolucion.Properties.View = Me.GridView2
        Me.CbeCasoSolucion.Size = New System.Drawing.Size(517, 22)
        Me.CbeCasoSolucion.TabIndex = 12
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(29, 416)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(112, 16)
        Me.LabelControl12.TabIndex = 28
        Me.LabelControl12.Text = "Solución de caso:"
        '
        'BarEnviando
        '
        Me.BarEnviando.Location = New System.Drawing.Point(532, 468)
        Me.BarEnviando.Name = "BarEnviando"
        Me.BarEnviando.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
        Me.BarEnviando.Properties.Step = 25
        Me.BarEnviando.Size = New System.Drawing.Size(100, 18)
        Me.BarEnviando.TabIndex = 16
        Me.BarEnviando.Visible = False
        '
        'LblEnviando
        '
        Me.LblEnviando.Location = New System.Drawing.Point(554, 449)
        Me.LblEnviando.Name = "LblEnviando"
        Me.LblEnviando.Size = New System.Drawing.Size(56, 13)
        Me.LblEnviando.TabIndex = 17
        Me.LblEnviando.Text = "Enviando..."
        Me.LblEnviando.Visible = False
        '
        'BtnReenviar
        '
        Me.BtnReenviar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReenviar.Appearance.Options.UseFont = True
        Me.BtnReenviar.Location = New System.Drawing.Point(591, 29)
        Me.BtnReenviar.Name = "BtnReenviar"
        Me.BtnReenviar.Size = New System.Drawing.Size(73, 36)
        Me.BtnReenviar.TabIndex = 30
        Me.BtnReenviar.Text = "Reenviar"
        Me.BtnReenviar.Visible = False
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(699, 507)
        Me.Controls.Add(Me.BtnReenviar)
        Me.Controls.Add(Me.LblEnviando)
        Me.Controls.Add(Me.BarEnviando)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.CbeCasoSolucion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TeHoraReporte)
        Me.Controls.Add(Me.TeHoraSolucion)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.CbeAtendido)
        Me.Controls.Add(Me.CbeNombreCliente)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.MePendiente)
        Me.Controls.Add(Me.MeSolucion)
        Me.Controls.Add(Me.MeCaso)
        Me.Controls.Add(Me.TxtReportado)
        Me.Controls.Add(Me.DeFechaSolucion)
        Me.Controls.Add(Me.DeFechaInforme)
        Me.Controls.Add(Me.TxtCorreoCliente)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        CType(Me.TxtCorreoCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeFechaInforme.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeFechaInforme.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeFechaSolucion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeFechaSolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtReportado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MeCaso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MeSolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MePendiente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbeNombreCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbeAtendido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeHoraSolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeHoraReporte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbeCasoSolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarEnviando.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnEnviar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtCorreoCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DeFechaInforme As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DeFechaSolucion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtReportado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MeCaso As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MeSolucion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MePendiente As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CbeNombreCliente As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CbeAtendido As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TeHoraSolucion As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents TeHoraReporte As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CbeCasoSolucion As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarEnviando As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents LblEnviando As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnReenviar As DevExpress.XtraEditors.SimpleButton
End Class
