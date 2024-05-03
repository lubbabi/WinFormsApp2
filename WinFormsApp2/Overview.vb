Imports MySql.Data.MySqlClient

Public Class Overview
    Private connectionString As String = "server=localhost;port=3306;database=hoa_database;user=root;password="

    Private Sub Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateHomeownersCount()
        UpdateCandidatesCount()
    End Sub

    Private Sub UpdateHomeownersCount()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM homeowners"
                Using cmd As New MySqlCommand(query, conn)
                    Dim homeownersCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    HCount.Text = homeownersCount.ToString()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub UpdateCandidatesCount()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM candidates"
                Using cmd As New MySqlCommand(query, conn)
                    Dim candidatesCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    CCount.Text = candidatesCount.ToString()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ViewListHomeowners_Click(sender As Object, e As EventArgs) Handles ViewListHomeowners.Click
        With HomeownersList
            .TopLevel = False
            Panel2.Controls.Add(HomeownersList)
            .BringToFront()
            .Show()
            PopulateHomeownersTable(HomeownersList.HomeownersDataGridView)
            Label4.Text = "LIST OF HOMEOWNERS"
        End With
    End Sub

    Private Sub ViewListCandidates_Click(sender As Object, e As EventArgs) Handles ViewListCandidates.Click
        With CandidatesList
            .TopLevel = False
            Panel2.Controls.Add(CandidatesList)
            .BringToFront()
            .Show()
            PopulateCandidatesTable(CandidatesList.CandidatesDataGridView)
            Label4.Text = "LIST OF CANDIDATES"
        End With
    End Sub

    Private Sub PopulateHomeownersTable(dataGridView As DataGridView)
        Dim dt As New DataTable()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                ' Select all columns except the photo column
                Dim query As String = "SELECT homeowner_id, first_name, middle_name, last_name, age, gender, address, phone_number, email_address FROM homeowners"
                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
                dataGridView.DataSource = dt

                ' Update column headers to proper format and center them
                For Each column As DataGridViewColumn In dataGridView.Columns
                    column.HeaderText = ToProperCase(column.HeaderText)
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Next
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub PopulateCandidatesTable(dataGridView As DataGridView)
        Dim dt As New DataTable()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                ' Select all columns except the photo column
                Dim query As String = "SELECT candidate_id, first_name, middle_name, last_name, gender, date_of_birth, place_of_birth, civil_status, address, phone_number, email_address FROM candidates"
                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
                dataGridView.DataSource = dt

                ' Update column headers to proper format and center them
                For Each column As DataGridViewColumn In dataGridView.Columns
                    column.HeaderText = ToProperCase(column.HeaderText)
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Next
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function ToProperCase(value As String) As String
        Dim result As String = ""
        Dim words As String() = value.Split(" "c)
        For Each word As String In words
            If result.Length > 0 Then
                result &= " "
            End If
            Dim parts As String() = word.Split("_"c)
            For Each part As String In parts
                If part.Length > 0 Then
                    result &= part(0).ToString().ToUpper() & part.Substring(1).ToLower()
                End If
            Next
        Next
        Return result
    End Function



End Class
