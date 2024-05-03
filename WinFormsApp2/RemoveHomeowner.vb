Imports MySql.Data.MySqlClient

Public Class RemoveHomeowner
    Private connectionString As String = "server=localhost;port=3306;database=hoa_database;user=root;password="

    Private Sub RemoveHomeowner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTotalHomeownersCount()
    End Sub

    Private Sub RemoveHID_TextChanged(sender As Object, e As EventArgs) Handles RemoveHID.TextChanged
        If RemoveHID.Text.Length > 6 Then
            MessageBox.Show("Please enter only 6 digits for the homeowner ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RemoveHID.Text = RemoveHID.Text.Substring(0, 6)
        End If

        If RemoveHID.Text.Length = 6 Then
            Dim homeownerId As Integer
            If Integer.TryParse(RemoveHID.Text, homeownerId) Then
                GetHomeownerDetails(homeownerId)
            Else
                ClearTextBoxes()
            End If
        Else
            ClearTextBoxes()
        End If
    End Sub

    Private Sub GetHomeownerDetails(homeownerId As Integer)
        Dim query As String = "SELECT first_name, middle_name, last_name, phone_number, email_address FROM homeowners WHERE homeowner_id = @HomeownerId"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@HomeownerId", homeownerId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            HomeownerFN.Text = reader.GetString("first_name")
                            HomeownerMN.Text = reader.GetString("middle_name")
                            HomeownerLN.Text = reader.GetString("last_name")
                            HomeownerPN.Text = reader.GetString("phone_number")
                            HomeownerEA.Text = reader.GetString("email_address")
                            HStatus.Text = "Registered"
                        Else
                            MessageBox.Show("Homeowner not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            ClearTextBoxes()
                            HStatus.Text = ""
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ClearTextBoxes()
        HomeownerFN.Clear()
        HomeownerMN.Clear()
        HomeownerLN.Clear()
        HomeownerPN.Clear()
        HomeownerEA.Clear()
        HStatus.Text = ""
    End Sub

    Private Sub RemoveHOBTN_Click(sender As Object, e As EventArgs) Handles RemoveHOBTN.Click
        If RemoveHID.Text.Trim() = "" Then
            MessageBox.Show("Please enter a homeowner ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim confirmationResult = MessageBox.Show("Are you sure you want to remove this homeowner?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmationResult = DialogResult.Yes Then
            Dim homeownerId As Integer
            If Integer.TryParse(RemoveHID.Text, homeownerId) Then
                RemoveHomeowner(homeownerId)
            Else
                MessageBox.Show("Invalid homeowner ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub RemoveHomeowner(homeownerId As Integer)
        Dim query As String = "DELETE FROM homeowners WHERE homeowner_id = @HomeownerId"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@HomeownerId", homeownerId)
                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Successful Remove", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearTextBoxes()
                    Else
                        MessageBox.Show("No homeowner found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        UpdateTotalHomeownersCount()
    End Sub

    Private Sub UpdateTotalHomeownersCount()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM homeowners"
                Using cmd As New MySqlCommand(query, conn)
                    Dim totalHomeowners As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    HCount.Text = totalHomeowners.ToString()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

End Class
