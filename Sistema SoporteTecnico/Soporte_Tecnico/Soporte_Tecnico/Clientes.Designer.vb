<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.CeActivo = New DevExpress.XtraEditors.CheckEdit()
        Me.TxtCorreo = New DevExpress.XtraEditors.TextEdit()
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.CeActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCorreo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(20, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(119, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nombre comercial:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(20, 66)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Correo:"
        '
        'CeActivo
        '
        Me.CeActivo.Location = New System.Drawing.Point(18, 111)
        Me.CeActivo.Name = "CeActivo"
        Me.CeActivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CeActivo.Properties.Appearance.Options.UseFont = True
        Me.CeActivo.Properties.Caption = "Activo"
        Me.CeActivo.Size = New System.Drawing.Size(75, 21)
        Me.CeActivo.TabIndex = 3
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(20, 85)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtCorreo.Properties.Appearance.Options.UseFont = True
        Me.TxtCorreo.Size = New System.Drawing.Size(238, 22)
        Me.TxtCorreo.TabIndex = 2
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardar.Appearance.Options.UseFont = True
        Me.BtnGuardar.Location = New System.Drawing.Point(20, 136)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(93, 52)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "Guardar"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(20, 40)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtNombre.Properties.Appearance.Options.UseFont = True
        Me.TxtNombre.Size = New System.Drawing.Size(238, 22)
        Me.TxtNombre.TabIndex = 1
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelar.Appearance.Options.UseFont = True
        Me.BtnCancelar.Location = New System.Drawing.Point(119, 136)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(93, 52)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(271, 210)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.CeActivo)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.CeActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCorreo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CeActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TxtCorreo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
End Class
