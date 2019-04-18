<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.BtnReporte = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnConfiguracion = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnClientes = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCerrar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnColaboradores = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.SuspendLayout()
        '
        'BtnReporte
        '
        Me.BtnReporte.Image = Global.Soporte_Tecnico.My.Resources.Resources.categoria
        Me.BtnReporte.Location = New System.Drawing.Point(30, 19)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(136, 148)
        Me.BtnReporte.TabIndex = 0
        Me.BtnReporte.Text = "REPORTE"
        '
        'BtnConfiguracion
        '
        Me.BtnConfiguracion.Image = Global.Soporte_Tecnico.My.Resources.Resources.admin
        Me.BtnConfiguracion.Location = New System.Drawing.Point(172, 19)
        Me.BtnConfiguracion.Name = "BtnConfiguracion"
        Me.BtnConfiguracion.Size = New System.Drawing.Size(136, 148)
        Me.BtnConfiguracion.TabIndex = 1
        Me.BtnConfiguracion.Text = "CONFIGURACIÓN"
        '
        'BtnClientes
        '
        Me.BtnClientes.Image = Global.Soporte_Tecnico.My.Resources.Resources.Usuarios
        Me.BtnClientes.Location = New System.Drawing.Point(30, 199)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(136, 147)
        Me.BtnClientes.TabIndex = 2
        Me.BtnClientes.Text = "CLIENTES"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCerrar.Appearance.Options.UseFont = True
        Me.BtnCerrar.Location = New System.Drawing.Point(95, 393)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(138, 37)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.Text = "CERRAR"
        '
        'BtnColaboradores
        '
        Me.BtnColaboradores.Image = Global.Soporte_Tecnico.My.Resources.Resources.clientes
        Me.BtnColaboradores.Location = New System.Drawing.Point(172, 199)
        Me.BtnColaboradores.Name = "BtnColaboradores"
        Me.BtnColaboradores.Size = New System.Drawing.Size(136, 148)
        Me.BtnColaboradores.TabIndex = 3
        Me.BtnColaboradores.Text = "COLABORADORES"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(67, 173)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 20)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Reportes"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(196, 173)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(88, 20)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Configuración"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(71, 353)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 20)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Clientes"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(193, 353)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(91, 20)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Colaboradores"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(345, 451)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.BtnColaboradores)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.BtnConfiguracion)
        Me.Controls.Add(Me.BtnReporte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnConfiguracion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnClientes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnColaboradores As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
