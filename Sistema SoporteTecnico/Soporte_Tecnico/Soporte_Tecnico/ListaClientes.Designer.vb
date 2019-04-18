<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaClientes))
        Me.GcClientes = New DevExpress.XtraGrid.GridControl()
        Me.GvClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TxtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.RgActivos = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.GcClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RgActivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GcClientes
        '
        Me.GcClientes.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GcClientes.Location = New System.Drawing.Point(11, 144)
        Me.GcClientes.MainView = Me.GvClientes
        Me.GcClientes.Name = "GcClientes"
        Me.GcClientes.Size = New System.Drawing.Size(507, 227)
        Me.GcClientes.TabIndex = 6
        Me.GcClientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvClientes})
        '
        'GvClientes
        '
        Me.GvClientes.GridControl = Me.GcClientes
        Me.GvClientes.Name = "GvClientes"
        Me.GvClientes.OptionsBehavior.Editable = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(11, 35)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtBuscar.Properties.Appearance.Options.UseFont = True
        Me.TxtBuscar.Size = New System.Drawing.Size(254, 22)
        Me.TxtBuscar.TabIndex = 1
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNuevo.Appearance.Options.UseFont = True
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 107)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 31)
        Me.BtnNuevo.TabIndex = 3
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnModificar
        '
        Me.BtnModificar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnModificar.Appearance.Options.UseFont = True
        Me.BtnModificar.Location = New System.Drawing.Point(93, 107)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 31)
        Me.BtnModificar.TabIndex = 4
        Me.BtnModificar.Text = "Modificar"
        '
        'RgActivos
        '
        Me.RgActivos.Location = New System.Drawing.Point(12, 63)
        Me.RgActivos.Name = "RgActivos"
        Me.RgActivos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RgActivos.Properties.Appearance.Options.UseFont = True
        Me.RgActivos.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Activo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Inactivo")})
        Me.RgActivos.Size = New System.Drawing.Size(156, 25)
        Me.RgActivos.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(11, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(101, 16)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Nombre cliente:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelar.Appearance.Options.UseFont = True
        Me.BtnCancelar.Location = New System.Drawing.Point(174, 107)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 31)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.Image = Global.Soporte_Tecnico.My.Resources.Resources.user
        Me.Label1.Location = New System.Drawing.Point(367, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 123)
        Me.Label1.TabIndex = 7
        '
        'ListaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(530, 383)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.RgActivos)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.GcClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ListaClientes"
        Me.Text = "Lista de clientes"
        CType(Me.GcClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RgActivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GcClientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvClientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RgActivos As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
End Class
