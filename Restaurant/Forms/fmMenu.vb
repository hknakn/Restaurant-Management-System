Public Class fmMenu

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "Menu Item Click"

    Private Sub LblTables_Click(sender As Object, e As EventArgs) Handles pnlTables.Click, picTables.Click, lblTables.Click

        Dim Tables As New fmTables

        Me.Close()
        Tables.Show()

    End Sub

    Private Sub PnlReservation_Click(sender As Object, e As EventArgs) Handles pnlReservation.Click, picReservation.Click, lblReservation.Click

        Dim Reservation As New fmReservation

        Me.Close()
        Reservation.Show()

    End Sub

    Private Sub PicTakeAway_Click(sender As Object, e As EventArgs) Handles pnlTakeAway.Click, picTakeAway.Click, lblTakeAway.Click

        Dim TakeAway As New fmTakeAway

        Me.Close()
        TakeAway.Show()

    End Sub

    Private Sub PicCustomers_Click(sender As Object, e As EventArgs) Handles pnlCustomers.Click, picCustomers.Click, lblCustomers.Click

        Dim Customers As New fmCustomers

        Me.Close()
        Customers.Show()

    End Sub

    Private Sub PicCashier_Click(sender As Object, e As EventArgs) Handles pnlCashier.Click, picCashier.Click, lblCashier.Click

        Dim Cashier As New fmCashier

        Me.Close()
        Cashier.Show()

    End Sub

    Private Sub PicKitchen_Click(sender As Object, e As EventArgs) Handles pnlKitchen.Click, picKitchen.Click, lblKitchen.Click

        Dim Kitchen As New fmKitchen

        Me.Close()
        Kitchen.Show()

    End Sub

    Private Sub PicReports_Click(sender As Object, e As EventArgs) Handles pnlReports.Click, picReports.Click, lblReports.Click

        Dim Reports As New fmReports

        Me.Close()
        Reports.Show()

    End Sub

    Private Sub PicSettings_Click(sender As Object, e As EventArgs) Handles pnlSettings.Click, picSettings.Click, lblSettings.Click

        Dim Settings As New fmSettings

        Me.Close()
        Settings.Show()

    End Sub

    Private Sub PicLock_Click(sender As Object, e As EventArgs) Handles pnlLock.Click, picLock.Click, lblLock.Click

        Dim Lock As New fmLock

        Me.Close()
        Lock.Show()

    End Sub

    Private Sub PicExit_Click(sender As Object, e As EventArgs) Handles pnlExit.Click, picExit.Click, lblExit.Click

        If MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

#End Region

End Class