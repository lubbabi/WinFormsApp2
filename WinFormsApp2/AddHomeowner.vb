Imports MySql.Data.MySqlClient
Imports System.IO

Public Class AddHomeowner
    Private connectionString As String = "server=localhost;port=3306;database=hoa_database;user=root;password="
    Private selectedImagePath As String = ""
    Private random As New Random()

    Private Sub AddHomeowner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTotalHomeownersCount()
    End Sub

    Private Sub SubmitBTN_Click(sender As Object, e As EventArgs) Handles SubmitBTN.Click
        If selectedImagePath = "" Then
            Dim addPhotoResult = MessageBox.Show("Do you want to add a photo for this homeowner?", "Confirmation", MessageBoxButtons.YesNo)
            If addPhotoResult = DialogResult.Yes Then
                SelectImage_Click(sender, e)
                Exit Sub
            End If
        End If

        If HomeownerFN.Text.Trim = "" OrElse
           HomeownerLN.Text.Trim() = "" OrElse
           HomeownerAge.Text.Trim() = "" OrElse
           HomeownerGender.Text.Trim() = "" OrElse
           HomeownerDOB.Value = Date.MinValue OrElse
           HomeownerFA.Text.Trim() = "" OrElse
           HomeownerPN.Text.Trim() = "" OrElse
           HomeownerEA.Text.Trim() = "" Then
            MessageBox.Show("Please complete all the homeowner details.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirmationResult = MessageBox.Show("Are you sure you want to save this homeowner's details?", "Confirmation", MessageBoxButtons.YesNo)

        If confirmationResult = DialogResult.Yes Then
            Dim homeownerId As Integer = GenerateRandomHomeownerId()
            Dim firstName = HomeownerFN.Text
            Dim middleName As String = HomeownerMN.Text
            Dim lastName As String = HomeownerLN.Text
            Dim age As String = HomeownerAge.Text
            Dim gender As String = HomeownerGender.Text
            Dim dob As Date = HomeownerDOB.Value
            Dim address As String = HomeownerFA.Text
            Dim phoneNumber As String = HomeownerPN.Text
            Dim emailAddress As String = HomeownerEA.Text

            Using conn As New MySqlConnection(connectionString)
                Try
                    conn.Open()
                    Dim query = "INSERT INTO homeowners (homeowner_id, first_name, middle_name, last_name, age, gender, date_of_birth, address, phone_number, email_address, photo) VALUES (@HomeownerId, @FirstName, @MiddleName, @LastName, @Age, @Gender, @DOB, @Address, @PhoneNumber, @EmailAddress, @Photo)"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@HomeownerId", homeownerId)
                        cmd.Parameters.AddWithValue("@FirstName", firstName)
                        cmd.Parameters.AddWithValue("@MiddleName", middleName)
                        cmd.Parameters.AddWithValue("@LastName", lastName)
                        cmd.Parameters.AddWithValue("@Age", age)
                        cmd.Parameters.AddWithValue("@Gender", gender)
                        cmd.Parameters.AddWithValue("@DOB", dob)
                        cmd.Parameters.AddWithValue("@Address", address)
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                        cmd.Parameters.AddWithValue("@EmailAddress", emailAddress)

                        If selectedImagePath <> "" Then
                            Dim imageData = File.ReadAllBytes(selectedImagePath)
                            cmd.Parameters.AddWithValue("@Photo", imageData)
                        Else
                            cmd.Parameters.AddWithValue("@Photo", DBNull.Value)
                        End If

                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Homeowner details saved successfully." & vbCrLf & "Homeowner ID: " & homeownerId, "Approved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End If
        UpdateTotalHomeownersCount()
    End Sub

    Private Function GenerateRandomHomeownerId() As Integer
        Return random.Next(100000, 999999) ' Generates a random 6-digit number
    End Function

    Private Sub UpdateTotalHomeownersCount()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM homeowners"
                Using cmd As New MySqlCommand(query, conn)
                    Dim totalHomeowners As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    THBox.Text = totalHomeowners.ToString()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub SelectImage_Click(sender As Object, e As EventArgs) Handles SelectImage.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif"
        openFileDialog.Title = "Select Image"
        If openFileDialog.ShowDialog = DialogResult.OK Then
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

End Class
