Public Class fmLogin

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        txtPassword.isPassword = True

    End Sub

#Region "Form Events"

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim Staff As New cStaff
        Dim Result As Boolean = Staff.StaffLoginControl(txtPassword.Text, txtUser.Text)

        If Result Then

            Dim Menu As New fmMenu
            Dim StaffMove As New cStaffMovements

            StaffMove.StaffMoveID = Guid.NewGuid
            StaffMove.StaffID = cGeneral._StaffID
            StaffMove.Movement = "Giriş Yaptı."
            StaffMove.MoveDate = DateTime.Now
            StaffMove.StaffMoveSave(StaffMove)

            Me.Hide()
            Menu.Show()

        End If

    End Sub

    Private Sub PicClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
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