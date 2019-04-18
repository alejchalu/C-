<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaColaboradores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaColaboradores))
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.RgActivos = New DevExpress.XtraEditors.RadioGroup()
        Me.BtnModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.GcColaboradores = New DevExpress.XtraGrid.GridControl()
        Me.GvColaboradores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.RgActivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcColaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvColaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelar.Appearance.Options.UseFont = True
        Me.BtnCancelar.Location = New System.Drawing.Point(185, 105)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 31)
        Me.BtnCancelar.TabIndex = 11
        Me.BtnCancelar.Text = "Cancelar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(22, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(136, 16)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "Nombre colaborador:"
        '
        'RgActivos
        '
        Me.RgActivos.Location = New System.Drawing.Point(22, 61)
        Me.RgActivos.Name = "RgActivos"
        Me.RgActivos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RgActivos.Properties.Appearance.Options.UseFont = True
        Me.RgActivos.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Activo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Inactivo")})
        Me.RgActivos.Size = New System.Drawing.Size(156, 25)
        Me.RgActivos.TabIndex = 8
        '
        'BtnModificar
        '
        Me.BtnModificar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnModificar.Appearance.Options.UseFont = True
        Me.BtnModificar.Location = New System.Drawing.Point(104, 105)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 31)
        Me.BtnModificar.TabIndex = 10
        Me.BtnModificar.Text = "Modificar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNuevo.Appearance.Options.UseFont = True
        Me.BtnNuevo.Location = New System.Drawing.Point(23, 105)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 31)
        Me.BtnNuevo.TabIndex = 9
        Me.BtnNuevo.Text = "Nuevo"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(22, 33)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtBuscar.Properties.Appearance.Options.UseFont = True
        Me.TxtBuscar.Size = New System.Drawing.Size(254, 22)
        Me.TxtBuscar.TabIndex = 7
        '
        'GcColaboradores
        '
        Me.GcColaboradores.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GcColaboradores.Location = New System.Drawing.Point(12, 142)
        Me.GcColaboradores.MainView = Me.GvColaboradores
        Me.GcColaboradores.Name = "GcColaboradores"
        Me.GcColaboradores.Size = New System.Drawing.Size(526, 236)
        Me.GcColaboradores.TabIndex = 13
        Me.GcColaboradores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvColaboradores})
        '
        'GvColaboradores
        '
        Me.GvColaboradores.GridControl = Me.GcColaboradores
        Me.GvColaboradores.Name = "GvColaboradores"
        Me.GvColaboradores.OptionsBehavior.Editable = False
        '
        'Label1
        '
        Me.Label1.Image = Global.Soporte_Tecnico.My.Resources.Resources.moderator
        Me.Label1.Location = New System.Drawing.Point(351, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 128)
        Me.Label1.TabIndex = 14
        '
        'ListaColaboradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(551, 386)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.RgActivos)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.GcColaboradores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ListaColaboradores"
        Me.Text = "Lista de colaboradores"
        CType(Me.RgActivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcColaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvColaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RgActivos As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents BtnModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GcColaboradores As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvColaboradores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As Label
End Class
