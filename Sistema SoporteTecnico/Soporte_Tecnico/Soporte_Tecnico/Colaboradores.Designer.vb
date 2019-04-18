<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Colaboradores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Colaboradores))
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.CeActivo = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CePredeterminado = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtIdEquipo = New DevExpress.XtraEditors.TextEdit()
        CType(Me.TxtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CeActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CePredeterminado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdEquipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelar.Appearance.Options.UseFont = True
        Me.BtnCancelar.Location = New System.Drawing.Point(112, 144)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(93, 52)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(14, 34)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtNombre.Properties.Appearance.Options.UseFont = True
        Me.TxtNombre.Size = New System.Drawing.Size(238, 22)
        Me.TxtNombre.TabIndex = 1
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardar.Appearance.Options.UseFont = True
        Me.BtnGuardar.Location = New System.Drawing.Point(13, 144)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(93, 52)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "Guardar"
        '
        'CeActivo
        '
        Me.CeActivo.Location = New System.Drawing.Point(145, 107)
        Me.CeActivo.Name = "CeActivo"
        Me.CeActivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CeActivo.Properties.Appearance.Options.UseFont = True
        Me.CeActivo.Properties.Caption = "Activo"
        Me.CeActivo.Size = New System.Drawing.Size(75, 21)
        Me.CeActivo.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Nombre"
        '
        'CePredeterminado
        '
        Me.CePredeterminado.Location = New System.Drawing.Point(12, 107)
        Me.CePredeterminado.Name = "CePredeterminado"
        Me.CePredeterminado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CePredeterminado.Properties.Appearance.Options.UseFont = True
        Me.CePredeterminado.Properties.Caption = "Predeterminado"
        Me.CePredeterminado.Size = New System.Drawing.Size(127, 21)
        Me.CePredeterminado.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(14, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "ID Equipo"
        '
        'TxtIdEquipo
        '
        Me.TxtIdEquipo.Location = New System.Drawing.Point(14, 81)
        Me.TxtIdEquipo.Name = "TxtIdEquipo"
        Me.TxtIdEquipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtIdEquipo.Properties.Appearance.Options.UseFont = True
        Me.TxtIdEquipo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtIdEquipo.Size = New System.Drawing.Size(100, 22)
        Me.TxtIdEquipo.TabIndex = 2
        '
        'Colaboradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(274, 208)
        Me.Controls.Add(Me.TxtIdEquipo)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.CePredeterminado)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.CeActivo)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Colaboradores"
        Me.Text = "Colaboradores"
        CType(Me.TxtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CeActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CePredeterminado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdEquipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CeActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CePredeterminado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtIdEquipo As DevExpress.XtraEditors.TextEdit
End Class
