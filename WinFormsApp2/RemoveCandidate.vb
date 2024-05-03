Imports MySql.Data.MySqlClient

Public Class RemoveCandidate
    Private connectionString As String = "server=localhost;port=3306;database=hoa_database;user=root;password="

    Private Sub RemoveHomeowner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTotalCandidatesCount()
    End Sub

    Private Sub RemoveHID_TextChanged(sender As Object, e As EventArgs) Handles RemoveCID.TextChanged
        If RemoveCID.Text.Length > 6 Then
            MessageBox.Show("Please enter only 6 digits for the candidate ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RemoveCID.Text = RemoveCID.Text.Substring(0, 6)
        End If

        If RemoveCID.Text.Length = 6 Then
            Dim candidateId As Integer
            If Integer.TryParse(RemoveCID.Text, candidateId) Then
                GetCandidateDetails(candidateId)
            Else
                ClearTextBoxes()
            End If
        Else
            ClearTextBoxes()
        End If
    End Sub

    Private Sub GetCandidateDetails(candidateId As Integer)
        Dim query As String = "SELECT first_name, middle_name, last_name, phone_number, email_address FROM candidates WHERE candidate_id = @CandidateId"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CandidateId", candidateId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            CandidateFN.Text = reader.GetString("first_name")
                            CandidateMN.Text = reader.GetString("middle_name")
                            CandidateLN.Text = reader.GetString("last_name")
                            CandidatePN.Text = reader.GetString("phone_number")
                            CandidateEA.Text = reader.GetString("email_address")
                            CStatus.Text = "Registered"
                        Else
                            MessageBox.Show("Homeowner not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            ClearTextBoxes()
                            CStatus.Text = ""
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ClearTextBoxes()
        CandidateFN.Clear()
        CandidateMN.Clear()
        CandidateLN.Clear()
        CandidatePN.Clear()
        CandidateEA.Clear()
        CStatus.Text = ""
    End Sub

    Private Sub RemoveCABTN_Click(sender As Object, e As EventArgs) Handles RemoveCABTN.Click
        If RemoveCID.Text.Trim() = "" Then
            MessageBox.Show("Please enter a candidate ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim confirmationResult = MessageBox.Show("Are you sure you want to remove this candidate?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmationResult = DialogResult.Yes Then
            Dim candidateId As Integer
            If Integer.TryParse(RemoveCID.Text, candidateId) Then
                RemoveCandidate(candidateId)
            Else
                MessageBox.Show("Invalid candidate ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub RemoveCandidate(candidateId As Integer)
        Dim query As String = "DELETE FROM candidates WHERE candidate_id = @CandidateId"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CandidateId", candidateId)
                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Successful Remove", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearTextBoxes()
                    Else
                        MessageBox.Show("No candidate found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        UpdateTotalCandidatesCount()
    End Sub

    Private Sub UpdateTotalCandidatesCount()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM candidates"
                Using cmd As New MySqlCommand(query, conn)
                    Dim totalCandidates As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    CCount.Text = totalCandidates.ToString()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

End Class
