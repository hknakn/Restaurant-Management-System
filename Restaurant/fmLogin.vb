Public Class fmLogin

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "Form Events"

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