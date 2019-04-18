<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuracion))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtSMTP = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUsuarioSMTP = New DevExpress.XtraEditors.TextEdit()
        Me.TxtContraseñaSMTP = New DevExpress.XtraEditors.TextEdit()
        Me.SePuerto = New DevExpress.XtraEditors.SpinEdit()
        Me.CeSSL = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtDeCorreo = New DevExpress.XtraEditors.TextEdit()
        Me.MeCopiaCorreos = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtAsunto = New DevExpress.XtraEditors.TextEdit()
        Me.MeCuerpo = New DevExpress.XtraEditors.MemoEdit()
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtRutaArchivo = New DevExpress.XtraEditors.TextEdit()
        Me.OfBuscar = New System.Windows.Forms.OpenFileDialog()
        Me.BtnBuscar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TxtSMTP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUsuarioSMTP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtContraseñaSMTP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SePuerto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CeSSL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDeCorreo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MeCopiaCorreos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAsunto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MeCuerpo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRutaArchivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(41, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "SMTP:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(41, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(91, 16)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Usuario SMTP:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(41, 103)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(118, 16)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Contraseña SMTP:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(41, 148)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Puerto:"
        '
        'TxtSMTP
        '
        Me.TxtSMTP.Location = New System.Drawing.Point(41, 32)
        Me.TxtSMTP.Name = "TxtSMTP"
        Me.TxtSMTP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtSMTP.Properties.Appearance.Options.UseFont = True
        Me.TxtSMTP.Size = New System.Drawing.Size(248, 22)
        Me.TxtSMTP.TabIndex = 1
        '
        'TxtUsuarioSMTP
        '
        Me.TxtUsuarioSMTP.Location = New System.Drawing.Point(41, 77)
        Me.TxtUsuarioSMTP.Name = "TxtUsuarioSMTP"
        Me.TxtUsuarioSMTP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtUsuarioSMTP.Properties.Appearance.Options.UseFont = True
        Me.TxtUsuarioSMTP.Size = New System.Drawing.Size(248, 22)
        Me.TxtUsuarioSMTP.TabIndex = 2
        '
        'TxtContraseñaSMTP
        '
        Me.TxtContraseñaSMTP.Location = New System.Drawing.Point(41, 122)
        Me.TxtContraseñaSMTP.Name = "TxtContraseñaSMTP"
        Me.TxtContraseñaSMTP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtContraseñaSMTP.Properties.Appearance.Options.UseFont = True
        Me.TxtContraseñaSMTP.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseñaSMTP.Size = New System.Drawing.Size(248, 22)
        Me.TxtContraseñaSMTP.TabIndex = 3
        '
        'SePuerto
        '
        Me.SePuerto.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SePuerto.Location = New System.Drawing.Point(41, 167)
        Me.SePuerto.Name = "SePuerto"
        Me.SePuerto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.SePuerto.Properties.Appearance.Options.UseFont = True
        Me.SePuerto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SePuerto.Size = New System.Drawing.Size(75, 22)
        Me.SePuerto.TabIndex = 4
        '
        'CeSSL
        '
        Me.CeSSL.Location = New System.Drawing.Point(39, 196)
        Me.CeSSL.Name = "CeSSL"
        Me.CeSSL.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CeSSL.Properties.Appearance.Options.UseFont = True
        Me.CeSSL.Properties.Caption = "SSL"
        Me.CeSSL.Size = New System.Drawing.Size(75, 21)
        Me.CeSSL.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(41, 222)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(69, 16)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "De correo:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(41, 269)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(282, 16)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Copia correos(deben ir separados por "";"") :"
        '
        'TxtDeCorreo
        '
        Me.TxtDeCorreo.Location = New System.Drawing.Point(41, 241)
        Me.TxtDeCorreo.Name = "TxtDeCorreo"
        Me.TxtDeCorreo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtDeCorreo.Properties.Appearance.Options.UseFont = True
        Me.TxtDeCorreo.Size = New System.Drawing.Size(248, 22)
        Me.TxtDeCorreo.TabIndex = 6
        '
        'MeCopiaCorreos
        '
        Me.MeCopiaCorreos.Location = New System.Drawing.Point(41, 291)
        Me.MeCopiaCorreos.Name = "MeCopiaCorreos"
        Me.MeCopiaCorreos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.MeCopiaCorreos.Properties.Appearance.Options.UseFont = True
        Me.MeCopiaCorreos.Size = New System.Drawing.Size(248, 84)
        Me.MeCopiaCorreos.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(325, 12)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl7.TabIndex = 13
        Me.LabelControl7.Text = "Asunto:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(325, 58)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(51, 16)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "Cuerpo:"
        '
        'TxtAsunto
        '
        Me.TxtAsunto.Location = New System.Drawing.Point(325, 31)
        Me.TxtAsunto.Name = "TxtAsunto"
        Me.TxtAsunto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtAsunto.Properties.Appearance.Options.UseFont = True
        Me.TxtAsunto.Size = New System.Drawing.Size(249, 22)
        Me.TxtAsunto.TabIndex = 8
        '
        'MeCuerpo
        '
        Me.MeCuerpo.Location = New System.Drawing.Point(325, 77)
        Me.MeCuerpo.Name = "MeCuerpo"
        Me.MeCuerpo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.MeCuerpo.Properties.Appearance.Options.UseFont = True
        Me.MeCuerpo.Size = New System.Drawing.Size(249, 82)
        Me.MeCuerpo.TabIndex = 9
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardar.Appearance.Options.UseFont = True
        Me.BtnGuardar.Location = New System.Drawing.Point(353, 240)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(94, 55)
        Me.BtnGuardar.TabIndex = 12
        Me.BtnGuardar.Text = "Guardar"
        '
        'BtnModificar
        '
        Me.BtnModificar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnModificar.Appearance.Options.UseFont = True
        Me.BtnModificar.Location = New System.Drawing.Point(453, 240)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(94, 55)
        Me.BtnModificar.TabIndex = 13
        Me.BtnModificar.Text = "Modificar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelar.Appearance.Options.UseFont = True
        Me.BtnCancelar.Location = New System.Drawing.Point(401, 301)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(94, 55)
        Me.BtnCancelar.TabIndex = 14
        Me.BtnCancelar.Text = "Cancelar"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(325, 173)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(108, 16)
        Me.LabelControl9.TabIndex = 20
        Me.LabelControl9.Text = "Ruta de archivo:"
        '
        'TxtRutaArchivo
        '
        Me.TxtRutaArchivo.Location = New System.Drawing.Point(325, 195)
        Me.TxtRutaArchivo.Name = "TxtRutaArchivo"
        Me.TxtRutaArchivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtRutaArchivo.Properties.Appearance.Options.UseFont = True
        Me.TxtRutaArchivo.Size = New System.Drawing.Size(249, 22)
        Me.TxtRutaArchivo.TabIndex = 10
        '
        'OfBuscar
        '
        Me.OfBuscar.CheckFileExists = False
        Me.OfBuscar.CheckPathExists = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Appearance.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Appearance.Options.UseFont = True
        Me.BtnBuscar.Location = New System.Drawing.Point(580, 194)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(41, 23)
        Me.BtnBuscar.TabIndex = 11
        Me.BtnBuscar.Text = "Buscar"
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(633, 387)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtRutaArchivo)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.MeCuerpo)
        Me.Controls.Add(Me.TxtAsunto)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.MeCopiaCorreos)
        Me.Controls.Add(Me.TxtDeCorreo)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.CeSSL)
        Me.Controls.Add(Me.SePuerto)
        Me.Controls.Add(Me.TxtContraseñaSMTP)
        Me.Controls.Add(Me.TxtUsuarioSMTP)
        Me.Controls.Add(Me.TxtSMTP)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Configuracion"
        Me.Text = "Configuracion"
        CType(Me.TxtSMTP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUsuarioSMTP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtContraseñaSMTP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SePuerto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CeSSL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDeCorreo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MeCopiaCorreos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAsunto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MeCuerpo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRutaArchivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtSMTP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUsuarioSMTP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtContraseñaSMTP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SePuerto As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CeSSL As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtDeCorreo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MeCopiaCorreos As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtAsunto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MeCuerpo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtRutaArchivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OfBuscar As OpenFileDialog
    Friend WithEvents BtnBuscar As DevExpress.XtraEditors.SimpleButton
End Class
