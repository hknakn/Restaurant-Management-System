<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmLogin))
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblForgotPass = New System.Windows.Forms.Label()
        Me.lblNewUser = New System.Windows.Forms.Label()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.Elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picComLogo = New System.Windows.Forms.PictureBox()
        Me.picPass = New System.Windows.Forms.PictureBox()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuDragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuFormFadeTransition1 = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblUser.Location = New System.Drawing.Point(77, 46)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(199, 30)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "Kullanıcı Girişi"
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUser.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtUser.HintText = "Kullanıcı Adı"
        Me.txtUser.isPassword = False
        Me.txtUser.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.txtUser.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtUser.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.txtUser.LineThickness = 2
        Me.txtUser.Location = New System.Drawing.Point(446, 213)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(362, 39)
        Me.txtUser.TabIndex = 2
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblForgotPass
        '
        Me.lblForgotPass.AutoSize = True
        Me.lblForgotPass.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgotPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblForgotPass.Location = New System.Drawing.Point(390, 337)
        Me.lblForgotPass.Name = "lblForgotPass"
        Me.lblForgotPass.Size = New System.Drawing.Size(137, 22)
        Me.lblForgotPass.TabIndex = 4
        Me.lblForgotPass.Text = "Şifremi Unuttum"
        '
        'lblNewUser
        '
        Me.lblNewUser.AutoSize = True
        Me.lblNewUser.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblNewUser.Location = New System.Drawing.Point(699, 337)
        Me.lblNewUser.Name = "lblNewUser"
        Me.lblNewUser.Size = New System.Drawing.Size(109, 22)
        Me.lblNewUser.TabIndex = 5
        Me.lblNewUser.Text = "Yeni Kullanıcı"
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.pnl.Location = New System.Drawing.Point(82, 80)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(194, 3)
        Me.pnl.TabIndex = 1
        '
        'Elipse
        '
        Me.Elipse.ElipseRadius = 5
        Me.Elipse.TargetControl = Me
        '
        'picClose
        '
        Me.picClose.Image = Global.Restaurant.My.Resources.Resources.icons8_delete_48
        Me.picClose.Location = New System.Drawing.Point(821, 4)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(25, 25)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picClose.TabIndex = 10
        Me.picClose.TabStop = False
        '
        'picComLogo
        '
        Me.picComLogo.Image = Global.Restaurant.My.Resources.Resources.picture14867764381797
        Me.picComLogo.Location = New System.Drawing.Point(459, 12)
        Me.picComLogo.Name = "picComLogo"
        Me.picComLogo.Size = New System.Drawing.Size(231, 174)
        Me.picComLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picComLogo.TabIndex = 9
        Me.picComLogo.TabStop = False
        '
        'picPass
        '
        Me.picPass.Image = Global.Restaurant.My.Resources.Resources.icons8_secure_48
        Me.picPass.Location = New System.Drawing.Point(391, 269)
        Me.picPass.Name = "picPass"
        Me.picPass.Size = New System.Drawing.Size(48, 48)
        Me.picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPass.TabIndex = 8
        Me.picPass.TabStop = False
        '
        'picUser
        '
        Me.picUser.Image = Global.Restaurant.My.Resources.Resources.icons8_circled_user_male_skin_type_4_48
        Me.picUser.Location = New System.Drawing.Point(391, 209)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(48, 48)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUser.TabIndex = 7
        Me.picUser.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.ActiveBorderThickness = 1
        Me.btnLogin.ActiveCornerRadius = 20
        Me.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnLogin.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.ButtonText = "Giriş Yap"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnLogin.IdleBorderThickness = 1
        Me.btnLogin.IdleCornerRadius = 20
        Me.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnLogin.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnLogin.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(394, 377)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(414, 60)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = Global.Restaurant.My.Resources.Resources.Restaurant_icon_EPS_10_by_Hoeda80_8_580x386
        Me.picLogo.Location = New System.Drawing.Point(-150, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(652, 476)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtPassword.HintText = "Şifre"
        Me.txtPassword.isPassword = False
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.txtPassword.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.txtPassword.LineThickness = 2
        Me.txtPassword.Location = New System.Drawing.Point(446, 273)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(362, 39)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuDragControl
        '
        Me.BunifuDragControl.Fixed = True
        Me.BunifuDragControl.Horizontal = True
        Me.BunifuDragControl.TargetControl = Me
        Me.BunifuDragControl.Vertical = True
        '
        'BunifuFormFadeTransition1
        '
        Me.BunifuFormFadeTransition1.Delay = 1
        '
        'fmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(850, 500)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.picComLogo)
        Me.Controls.Add(Me.picPass)
        Me.Controls.Add(Me.picUser)
        Me.Controls.Add(Me.lblNewUser)
        Me.Controls.Add(Me.lblForgotPass)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.picLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fmLogin"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblForgotPass As Label
    Friend WithEvents lblNewUser As Label
    Friend WithEvents picUser As PictureBox
    Friend WithEvents picPass As PictureBox
    Friend WithEvents picComLogo As PictureBox
    Friend WithEvents pnl As Panel
    Friend WithEvents Elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents picClose As PictureBox
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents BunifuDragControl As Bunifu.Framework.UI.BunifuDragControl
    Private WithEvents BunifuFormFadeTransition1 As Bunifu.Framework.UI.BunifuFormFadeTransition
End Class
