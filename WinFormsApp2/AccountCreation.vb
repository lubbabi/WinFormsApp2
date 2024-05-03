Imports System.Data.OleDb
Imports System.Text

Public Class AccountCreation
    Public Shared UniqueKey As String

    Private Sub AccountCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccountType()
    End Sub

    Private Sub AccountType()
        AccountTypeCB.Items.Add("Voter")
        AccountTypeCB.Items.Add("Candidate")
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Function GenerateUniqueKey() As String
        ' Define the characters to be used in the key
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=-"

        ' Create a StringBuilder to hold the generated key
        Dim keyBuilder As New StringBuilder()

        ' Create a random number generator
        Dim rnd As New Random()

        ' Generate a 10-character key
        For i As Integer = 1 To 10
            ' Append a random character from the defined set of characters
            keyBuilder.Append(chars(rnd.Next(0, chars.Length)))
        Next

        ' Return the generated key
        Return keyBuilder.ToString()
    End Function

    Private Sub CreateBTN_Click(sender As Object, e As EventArgs) Handles CreateBTN.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rosal\Documents\Users_Account.accdb;")

        If FirstNameTB.Text = "" OrElse
           LastNameTB.Text = "" OrElse
           EmailAddressTB.Text = "" OrElse
           GenderTB.Text = "" OrElse
           AgeNUD.Text = "" OrElse
           UsernameTB.Text = "" OrElse
           AccountTypeCB.Text = "" OrElse
           PasswordTB.Text = "" OrElse
           ConfirmPWTB.Text = "" Then
            MessageBox.Show("Complete all fields to proceed.", "Account Creation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If PasswordTB.Text <> ConfirmPWTB.Text Then
            MessageBox.Show("Passwords Do Not Match. Please Try Again", "Account Creation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using con
            con.Open()

            ' Check if username already exists
            Dim count As Integer
            Using cmd As New OleDbCommand("SELECT COUNT (*) FROM accounts WHERE [Username] = @Username", con)
                cmd.Parameters.AddWithValue("@Username", UsernameTB.Text.Trim)
                count = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            If count > 0 Then
                MessageBox.Show("Username are already taken", "Account Creation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Generate a unique key
            UniqueKey = GenerateUniqueKey()

            ' Insert new account with unique key
            Using cmd As New OleDbCommand("INSERT INTO accounts ([firstName], [lastName], [emailAddress], [gender], [age], [username], [accountType], [password], [UniqueKey]) VALUES (@FirstName, @LastName, @EmailAddress, @Gender, @Age, @Username, @AccountType, @Password, @UniqueKey)", con)
                cmd.Parameters.AddWithValue("@FirstName", FirstNameTB.Text.Trim)
                cmd.Parameters.AddWithValue("@LastName", LastNameTB.Text.Trim)
                cmd.Parameters.AddWithValue("@EmailAddress", EmailAddressTB.Text.Trim)
                cmd.Parameters.AddWithValue("@Gender", GenderTB.Text.Trim)
                cmd.Parameters.AddWithValue("@Age", AgeNUD.Value)
                cmd.Parameters.AddWithValue("@Username", UsernameTB.Text.Trim)
                cmd.Parameters.AddWithValue("@AccountType", AccountTypeCB.Text.Trim)
                cmd.Parameters.AddWithValue("@Password", PasswordTB.Text.Trim)
                cmd.Parameters.AddWithValue("@UniqueKey", UniqueKey)
                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Account Creation Successful.", "Creation Status")
                    ClearFields()
                End If
            End Using
        End Using
    End Sub

    Private Sub ClearFields()
        FirstNameTB.Clear()
        LastNameTB.Clear()
        EmailAddressTB.Clear()
        GenderTB.Clear()
        AgeNUD.Value = AgeNUD.Minimum
        UsernameTB.Clear()
        AccountTypeCB.SelectedIndex = -1
        PasswordTB.Clear()
        ConfirmPWTB.Clear()
    End Sub
End Class
