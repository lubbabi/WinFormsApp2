Imports System.Data.OleDb

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RegistrationForm.Hide()
    End Sub

    Private Sub LoginBTN_Click(sender As Object, e As EventArgs) Handles LoginBTN.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rosal\Documents\Users_Account.accdb;")
        If LoginUsernameTB.Text = "" OrElse LoginPasswordTB.Text = "" Then
            MessageBox.Show("Username and Password are required.", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using con
            con.Open()

            ' Check if the username and password match the records in the database
            Dim query As String = "SELECT COUNT(*) FROM accounts WHERE [username] = @username AND [password] = @password"
            Using cmd As New OleDbCommand(query, con)
                cmd.Parameters.AddWithValue("@username", LoginUsernameTB.Text.Trim())
                cmd.Parameters.AddWithValue("@password", LoginPasswordTB.Text.Trim())

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    ' Retrieve FirstName and AccountType from the database
                    Dim queryUserInfo As String = "SELECT FirstName, AccountType FROM accounts WHERE [username] = @username"
                    Using cmdUserInfo As New OleDbCommand(queryUserInfo, con)
                        cmdUserInfo.Parameters.AddWithValue("@username", LoginUsernameTB.Text.Trim())

                        Using reader As OleDbDataReader = cmdUserInfo.ExecuteReader()
                            If reader.Read() Then
                                Dim firstName As String = reader("FirstName").ToString()
                                Dim accountType As String = reader("AccountType").ToString()

                                Dim dashboardForm As New Dashboard With {
                                    .FirstName = firstName,
                                    .AccountType = accountType
                                }
                                dashboardForm.Show()
                                Me.Hide()
                            End If
                        End Using
                    End Using
                Else
                    MessageBox.Show("Incorrect username or password. Please try again.", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub ResetPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ResetPassword.LinkClicked
        PasswordResetForm.Show()
        Me.Hide()
    End Sub

    Private Sub CreateAccountLINK_LinkClicked(sender As Object, e As EventArgs) Handles CreateAccountLINK.LinkClicked
        AccountCreation.Show()
        Me.Hide()
    End Sub

    Private Sub CloseProgram_Click(sender As Object, e As EventArgs) Handles CloseProgram.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MainWindow.Close()
            Me.Close()
        End If
    End Sub


End Class
