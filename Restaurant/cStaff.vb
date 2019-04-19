Imports System.Data.SqlClient

Public Class cStaff

#Region "Fields"

    Private _StaffID As Guid
    Private _StaffPositionID As Guid
    Private _StaffName As String
    Private _StaffSurname As String
    Private _Password As String
    Private _UserName As String
    Private _StaffSituation As Boolean

#End Region

#Region "Properties"

    Public Property StaffID As Guid
        Get
            Return _StaffID
        End Get
        Set(value As Guid)
            _StaffID = value
        End Set
    End Property

    Public Property StaffPositionID As Guid
        Get
            Return _StaffPositionID
        End Get
        Set(value As Guid)
            _StaffPositionID = value
        End Set
    End Property

    Public Property StaffName As String
        Get
            Return _StaffName
        End Get
        Set(value As String)
            _StaffName = value
        End Set
    End Property

    Public Property StaffSurname As String
        Get
            Return _StaffSurname
        End Get
        Set(value As String)
            _StaffSurname = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
        End Set
    End Property

    Public Property UserName As String
        Get
            Return _UserName
        End Get
        Set(value As String)
            _UserName = value
        End Set
    End Property

    Public Property StaffSituation As Boolean
        Get
            Return _StaffSituation
        End Get
        Set(value As Boolean)
            _StaffSituation = value
        End Set
    End Property

#End Region

    Dim General As New cGeneral

    Public Function StaffLoginControl(ByVal password As String, ByVal userName As String) As Boolean

        Dim Result As Boolean = False

        Dim con As New SqlConnection(General.conString)
        Dim cmd As New SqlCommand("SELECT * FROM STAFF WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD", con)

        cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = userName
        cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = password

        Try

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Result = Convert.ToBoolean(cmd.ExecuteNonQuery)

        Catch ex As Exception
            Dim ErrorMessage As String = ex.Message
        End Try

        Return Result

    End Function

End Class
