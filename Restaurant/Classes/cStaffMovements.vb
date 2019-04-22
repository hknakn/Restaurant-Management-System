Imports System.Data.SqlClient

Public Class cStaffMovements

    Dim General As New cGeneral

#Region "Fields"

    Private _StaffMoveID As Guid
    Private _StaffID As Guid
    Private _Movement As String
    Private _MoveDate As DateTime
    Private _Situation As Boolean

#End Region

#Region "Properties"

    Public Property StaffMoveID As Guid
        Get
            Return _StaffMoveID
        End Get
        Set(value As Guid)
            _StaffMoveID = value
        End Set
    End Property

    Public Property StaffID As Guid
        Get
            Return _StaffID
        End Get
        Set(value As Guid)
            _StaffID = value
        End Set
    End Property

    Public Property Movement As String
        Get
            Return _Movement
        End Get
        Set(value As String)
            _Movement = value
        End Set
    End Property

    Public Property MoveDate As Date
        Get
            Return _MoveDate
        End Get
        Set(value As Date)
            _MoveDate = value
        End Set
    End Property

    Public Property Situation As Boolean
        Get
            Return _Situation
        End Get
        Set(value As Boolean)
            _Situation = value
        End Set
    End Property

#End Region

    Public Function StaffMoveSave(ByVal staffMovements As cStaffMovements)

        Dim Result As Boolean = False

        Dim con As New SqlConnection(General.conString)
        Dim cmd As New SqlCommand("INSERT INTO StaffMovements(StaffMoveID, StaffID, Movement, Date)VALUES(@StaffMoveID, @StaffID,@Movement,@Date)", con)

        Try

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd.Parameters.Add("@StaffMoveID", SqlDbType.UniqueIdentifier).Value = staffMovements.StaffMoveID
            cmd.Parameters.Add("@StaffID", SqlDbType.UniqueIdentifier).Value = staffMovements.StaffID
            cmd.Parameters.Add("@Movement", SqlDbType.VarChar).Value = staffMovements.Movement
            cmd.Parameters.Add("@Date", SqlDbType.VarChar).Value = staffMovements.MoveDate


            Result = Convert.ToBoolean(cmd.ExecuteNonQuery)

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        End Try

    End Function

End Class
