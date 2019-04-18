<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaReportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaReportes))
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.RgSolucionados = New DevExpress.XtraEditors.RadioGroup()
        Me.BtnModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtCliente = New DevExpress.XtraEditors.TextEdit()
        Me.GcReportes = New DevExpress.XtraGrid.GridControl()
        Me.GvReportes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BtnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.SfExportar = New System.Windows.Forms.SaveFileDialog()
        Me.RgFormatos = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtColaborador = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.RgSolucionados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RgFormatos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtColaborador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelar.Appearance.Options.UseFont = True
        Me.BtnCancelar.Location = New System.Drawing.Point(174, 189)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 32)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(101, 16)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "Nombre cliente:"
        '
        'RgSolucionados
        '
        Me.RgSolucionados.Location = New System.Drawing.Point(12, 131)
        Me.RgSolucionados.Name = "RgSolucionados"
        Me.RgSolucionados.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RgSolucionados.Properties.Appearance.Options.UseFont = True
        Me.RgSolucionados.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Solucionado"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "No solucionado")})
        Me.RgSolucionados.Size = New System.Drawing.Size(237, 25)
        Me.RgSolucionados.TabIndex = 3
        '
        'BtnModificar
        '
        Me.BtnModificar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnModificar.Appearance.Options.UseFont = True
        Me.BtnModificar.Location = New System.Drawing.Point(93, 189)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 32)
        Me.BtnModificar.TabIndex = 5
        Me.BtnModificar.Text = "Modificar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNuevo.Appearance.Options.UseFont = True
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 189)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 32)
        Me.BtnNuevo.TabIndex = 4
        Me.BtnNuevo.Text = "Nuevo"
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(12, 33)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtCliente.Properties.Appearance.Options.UseFont = True
        Me.TxtCliente.Size = New System.Drawing.Size(254, 22)
        Me.TxtCliente.TabIndex = 1
        '
        'GcReportes
        '
        Me.GcReportes.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GcReportes.Location = New System.Drawing.Point(12, 227)
        Me.GcReportes.MainView = Me.GvReportes
        Me.GcReportes.Name = "GcReportes"
        Me.GcReportes.Size = New System.Drawing.Size(851, 270)
        Me.GcReportes.TabIndex = 9
        Me.GcReportes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvReportes})
        '
        'GvReportes
        '
        Me.GvReportes.GridControl = Me.GcReportes
        Me.GvReportes.Name = "GvReportes"
        Me.GvReportes.OptionsBehavior.Editable = False
        '
        'BtnExportar
        '
        Me.BtnExportar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnExportar.Appearance.Options.UseFont = True
        Me.BtnExportar.Location = New System.Drawing.Point(788, 168)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(75, 53)
        Me.BtnExportar.TabIndex = 8
        Me.BtnExportar.Text = "Exportar"
        '
        'RgFormatos
        '
        Me.RgFormatos.Location = New System.Drawing.Point(717, 168)
        Me.RgFormatos.Name = "RgFormatos"
        Me.RgFormatos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RgFormatos.Properties.Appearance.Options.UseFont = True
        Me.RgFormatos.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("PDF", "PDF"), New DevExpress.XtraEditors.Controls.RadioGroupItem("XLSX", "XLSX")})
        Me.RgFormatos.Size = New System.Drawing.Size(65, 53)
        Me.RgFormatos.TabIndex = 7
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(136, 16)
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "Nombre colaborador:"
        '
        'TxtColaborador
        '
        Me.TxtColaborador.Location = New System.Drawing.Point(12, 83)
        Me.TxtColaborador.Name = "TxtColaborador"
        Me.TxtColaborador.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtColaborador.Properties.Appearance.Options.UseFont = True
        Me.TxtColaborador.Size = New System.Drawing.Size(254, 22)
        Me.TxtColaborador.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Image = Global.Soporte_Tecnico.My.Resources.Resources.historial
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(427, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 141)
        Me.Label1.TabIndex = 18
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ListaReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(875, 509)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.TxtColaborador)
        Me.Controls.Add(Me.RgFormatos)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.RgSolucionados)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.GcReportes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ListaReportes"
        Me.Text = "Lista de reportes"
        CType(Me.RgSolucionados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RgFormatos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtColaborador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RgSolucionados As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents BtnModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GcReportes As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvReportes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SfExportar As SaveFileDialog
    Friend WithEvents RgFormatos As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtColaborador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
End Class
