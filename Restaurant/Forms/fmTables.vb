Public Class fmTables

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click

        Dim Menu As New fmMenu

        Me.Close()
        Menu.Show()

    End Sub

End Class