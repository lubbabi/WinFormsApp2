Imports MySql.Data.MySqlClient
Imports System.IO

Public Class AddCandidate
    Private connectionString As String = "server=localhost;port=3306;database=hoa_database;user=root;password="
    Private selectedImagePath As String = ""
    Private random As New Random()

    Private Sub AddCandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTotalCandidatesCount()

        CategoryCB.Items.Add("Board of Director")
        CategoryCB.Items.Add("Officer")

        CandidatePosition.Items.Add("President")
        CandidatePosition.Items.Add("Vice President")
        CandidatePosition.Items.Add("Secretary")
        CandidatePosition.Items.Add("Treasurer")
        CandidatePosition.Items.Add("Auditor")
    End Sub

    Private Sub SubmitBTN_Click(sender As Object, e As EventArgs) Handles SubmitBTN.Click
        Dim candidateId As Integer = GenerateRandomCandidateID()

        ' Check if a photo is selected
        If selectedImagePath = "" Then
            Dim addPhotoResult As DialogResult = MessageBox.Show("Do you want to add a photo for this candidate?", "Confirmation", MessageBoxButtons.YesNo)
            If addPhotoResult = DialogResult.Yes Then
                SelectImage_Click(sender, e)
                Exit Sub
            End If
        End If

        ' Check if all required fields are filled
        If CandidateFN.Text.Trim() = "" OrElse
           CandidateLN.Text.Trim() = "" OrElse
           CandidateGender.Text.Trim() = "" OrElse
           DateOfBirth.Value = DateTime.MinValue OrElse
           CandidateCS.Text.Trim() = "" OrElse
           CandidateFA.Text.Trim() = "" OrElse
           CandidatePN.Text.Trim() = "" OrElse
           CandidateEA.Text.Trim() = "" Then
            MessageBox.Show("Please complete all the candidate details.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Confirmation message before saving candidate details
        Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to save this candidate's details?", "Confirmation", MessageBoxButtons.YesNo)

        If confirmationResult = DialogResult.Yes Then
            Dim firstName As String = CandidateFN.Text
            Dim middleName As String = CandidateMN.Text
            Dim lastName As String = CandidateLN.Text
            Dim gender As String = CandidateGender.Text
            Dim dob As Date = DateOfBirth.Value
            Dim civilStatus As String = CandidateCS.Text
            Dim address As String = CandidateFA.Text
            Dim phoneNumber As String = CandidatePN.Text
            Dim emailAddress As String = CandidateEA.Text

            ' Get selected category
            Dim category As String = CategoryCB.Text

            Try
                ' Save candidate photo to a local folder
                Dim photoFileName As String = "Candidate_" & candidateId & Path.GetExtension(selectedImagePath)
                Dim destinationPath As String = Path.Combine("C:\xampp\htdocs\tests\user\candidate_photos", photoFileName)
                File.Copy(selectedImagePath, destinationPath)

                ' Save the photo path to the database
                Dim photoPath As String = "candidate_photos/" & photoFileName

                ' Now, we just save the details without the photo
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim query As String = ""
                    If category = "Board of Director" Then
                        ' Insert into HOA Board of Directors table
                        query = "INSERT INTO hoa_board_of_directors (boardID, position, first_name, middle_name, last_name, gender, civil_status, date_of_birth, phone_number, email_address, photo_path) VALUES (@CandidateID, @Position, @FirstName, @MiddleName, @LastName, @Gender, @CivilStatus, @DOB, @PhoneNumber, @EmailAddress, @PhotoPath)"
                    ElseIf category = "Officer" Then
                        ' Insert into HOA Officers table
                        query = "INSERT INTO hoa_officers (officerID, position, first_name, middle_name, last_name, gender, civil_status, date_of_birth, phone_number, email_address, photo_path) VALUES (@CandidateID, @Position, @FirstName, @MiddleName, @LastName, @Gender, @CivilStatus, @DOB, @PhoneNumber, @EmailAddress, @PhotoPath)"
                    End If

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@CandidateID", candidateId)
                        cmd.Parameters.AddWithValue("@Position", CandidatePosition.Text)
                        cmd.Parameters.AddWithValue("@FirstName", firstName)
                        cmd.Parameters.AddWithValue("@MiddleName", middleName)
                        cmd.Parameters.AddWithValue("@LastName", lastName)
                        cmd.Parameters.AddWithValue("@Gender", gender)
                        cmd.Parameters.AddWithValue("@DOB", dob)
                        cmd.Parameters.AddWithValue("@CivilStatus", civilStatus)
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                        cmd.Parameters.AddWithValue("@EmailAddress", emailAddress)
                        cmd.Parameters.AddWithValue("@PhotoPath", photoPath)

                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Candidate details saved successfully." & vbCrLf & "Candidate ID: " & candidateId, "Approved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ResetInputs()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
        UpdateTotalCandidatesCount()
    End Sub

    Private Sub UpdateTotalCandidatesCount()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT SUM(total) FROM (SELECT COUNT(*) AS total FROM hoa_board_of_directors UNION ALL SELECT COUNT(*) AS total FROM hoa_officers) AS combined"
                Using cmd As New MySqlCommand(query, conn)
                    Dim totalCandidates As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    TABox.Text = totalCandidates.ToString()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub SelectImage_Click(sender As Object, e As EventArgs) Handles SelectImage.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif"
        openFileDialog.Title = "Select Image"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            selectedImagePath = openFileDialog.FileName
            ImageBox.Image = Image.FromFile(selectedImagePath)
            ImageFileName.Text = Path.GetFileName(selectedImagePath)
            SelectImage.Text = "Selected"
        End If
    End Sub

    Private Sub DeleteImage_Click(sender As Object, e As EventArgs) Handles DeleteImage.Click
        ImageBox.Image = Nothing
        ImageFileName.Text = ""
        selectedImagePath = ""
        SelectImage.Text = "Select Image"
    End Sub

    Private Function GenerateRandomCandidateID() As String
        Return random.Next(100000, 999999).ToString() ' Generates a random 6-digit number
    End Function

    Private Sub ResetInputs()
        CandidateFN.Text = ""
        CandidateMN.Text = ""
        CandidateLN.Text = ""
        CandidateGender.Text = ""
        DateOfBirth.Value = DateTime.Today
        CandidateCS.Text = ""
        CandidateFA.Text = ""
        CandidatePN.Text = ""
        CandidateEA.Text = ""

        ImageBox.Image = Nothing
        ImageFileName.Text = ""
        selectedImagePath = ""

        CategoryCB.SelectedIndex = -1
        CandidatePosition.SelectedIndex = -1

        SelectImage.Text = "Select Image"
    End Sub

End Class
