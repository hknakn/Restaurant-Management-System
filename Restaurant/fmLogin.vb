Public Class fmLogin

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "Form Events"

    Private Sub FmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' To prevent from Thread error
        Control.CheckForIllegalCrossThreadCalls = False

        ' Load form slowly with animation
        BunifuFormFadeTransition1.ShowAsyc(Me)

        picComLogo.Select()

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim Staff As New cStaff
        Dim Result As Boolean = Staff.StaffLoginControl(txtPassword.Text, txtUser.Text)

        If Result Then

            Dim Menu As New fmMenu
            Dim StaffMove As New cStaffMovements

            Staff.GetStaffInfo()

            StaffMove.StaffMoveID = Guid.NewGuid
            StaffMove.StaffID = Staff.StaffID
            StaffMove.Movement = "Giriş Yaptı."
            StaffMove.MoveDate = DateTime.Now
            StaffMove.StaffMoveSave(StaffMove)

            Me.Hide()
            Menu.Show()
        Else
            MessageBox.Show("Kullanıcı adı veya şifre hatalı")
        End If

    End Sub

    Private Sub PicClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub TxtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        txtPassword.isPassword = True
    End Sub

    Private Sub TxtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        txtPassword.ResetText()
    End Sub

    Private Sub TxtUser_Enter(sender As Object, e As EventArgs) Handles txtUser.Enter
        txtUser.ResetText()
    End Sub

#End Region

#Region "Cursor Change on Close Image"

    Private Sub PicClose_MouseEnter(sender As Object, e As EventArgs) Handles picClose.MouseEnter
        picClose.Cursor = Cursors.Hand
    End Sub

    Private Sub PicClose_MouseLeave(sender As Object, e As EventArgs) Handles picClose.MouseLeave
        picClose.Cursor = Cursors.[Default]
    End Sub

#End Region

End Class