Imports System.Data.OleDb

Public Class Dashboard
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rosal\Documents\Users_Account.accdb;")
    Dim votersCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rosal\Documents\Voters_Information.accdb;")

    Private _firstName As String
    Private _accountType As String


    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    Public Property AccountType As String
        Get
            Return _accountType
        End Get
        Set(value As String)
            _accountType = value
        End Set
    End Property

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackBTN.Visible = False
        OverviewBTN_Click(sender, e)
        Label1.Text = FirstName
        Label2.Text = AccountType
    End Sub

    Private Sub ExitDashboard_Click(sender As Object, e As EventArgs) Handles ExitDashboard.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub AddCandidateBTN_Click(sender As Object, e As EventArgs) Handles addCandidateBTN.Click
        If AddHomeowner.Visible OrElse Overview.Visible OrElse RemoveHomeowner.Visible OrElse RemoveCandidate.Visible Then
            AddHomeowner.Close()
            Overview.Close()
            RemoveHomeowner.Close()
            RemoveCandidate.Close()
        End If
        With AddCandidate
            .TopLevel = False
            Panel6.Controls.Add(AddCandidate)
            .BringToFront()
            .Show()
            BackBTN.Visible = True
        End With
    End Sub

    Private Sub AddHomeownerBTN_Click(sender As Object, e As EventArgs) Handles addHomeownerBTN.Click
        If AddCandidate.Visible OrElse Overview.Visible OrElse RemoveHomeowner.Visible OrElse RemoveCandidate.Visible Then
            AddCandidate.Close()
            Overview.Close()
            RemoveHomeowner.Close()
            RemoveCandidate.Close()
        End If
        With AddHomeowner
            .TopLevel = False
            Panel6.Controls.Add(AddHomeowner)
            .BringToFront()
            .Show()
            BackBTN.Visible = True
        End With
    End Sub

    Private Sub OverviewBTN_Click(sender As Object, e As EventArgs) Handles OverviewBTN.Click
        If AddHomeowner.Visible OrElse AddCandidate.Visible OrElse RemoveHomeowner.Visible OrElse RemoveCandidate.Visible Then
            AddHomeowner.Close()
            AddCandidate.Close()
            RemoveHomeowner.Close()
            RemoveCandidate.Close()
        End If
        With Overview
            .TopLevel = False
            Panel6.Controls.Add(Overview)
            .BringToFront()
            .Show()
            BackBTN.Visible = True
        End With
    End Sub

    Private Sub RemoveHomeownerBTN_Click(sender As Object, e As EventArgs) Handles RemoveHomeownerBTN.Click
        If AddHomeowner.Visible OrElse AddCandidate.Visible OrElse Overview.Visible OrElse RemoveCandidate.Visible Then
            AddHomeowner.Close()
            AddCandidate.Close()
            Overview.Close()
            RemoveCandidate.Close()
        End If
        With RemoveHomeowner
            .TopLevel = False
            Panel6.Controls.Add(RemoveHomeowner)
            .BringToFront()
            .Show()
            BackBTN.Visible = True
        End With
    End Sub

    Private Sub RemoveCandidateBTN_Click(sender As Object, e As EventArgs) Handles RemoveCandidateBTN.Click
        If AddHomeowner.Visible OrElse AddCandidate.Visible OrElse Overview.Visible OrElse RemoveHomeowner.Visible Then
            AddHomeowner.Close()
            AddCandidate.Close()
            Overview.Close()
            RemoveHomeowner.Close()
        End If
        With RemoveCandidate
            .TopLevel = False
            Panel6.Controls.Add(RemoveCandidate)
            .BringToFront()
            .Show()
            BackBTN.Visible = True
        End With
    End Sub

    Private Sub BackBTN_Click(sender As Object, e As EventArgs) Handles BackBTN.Click
        OverviewBTN_Click(sender, e)
    End Sub


End Class
