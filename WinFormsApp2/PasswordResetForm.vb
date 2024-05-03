Imports System.Data.OleDb
Imports System.Net
Imports System.Net.Mail

Public Class PasswordResetForm
    Dim verificationCode As String
    Dim username As String = "barangayevotingsystem@gmail.com"
    Dim password As String = "fsypuzxcxsaguzeo"


    Private Sub SendVerificationCode()
        Try
            Dim email As String = EmailAddressTB.Text.Trim()

            ' Check if the email exists in the database
            Dim query As String = "SELECT COUNT(*) FROM accounts WHERE [Email] = @email"
            Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rosal\Documents\Users_Account.accdb;")
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@email", email)
                    con.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        ' If email exists, proceed with sending verification code
                        Dim fromAddress As New MailAddress("noreply@afrilen.com", "Voting System")
                        Dim toAddress As New MailAddress(email)
                        Dim subject As String = "Password Reset OTP"
                        verificationCode = GenerateOTP()

                        ' Extracting the first name from the email address
                        Dim firstName As String = email.Split("."c, "@"c, "_"c)(0)

                        Dim body As String = "Dear " & firstName & "," & vbCrLf & vbCrLf &
                    "Your password reset OTP is: <b><span style='font-size: 1.2em;'>" & verificationCode & "</span></b>" &
                     vbCrLf & vbCrLf & "Thank you."


                        Dim smtp As New SmtpClient With {
                        .Host = "smtp.gmail.com",
                        .Port = 587,
                        .EnableSsl = True,
                        .Credentials = New NetworkCredential(username, password)
                    }

                        Dim message As New MailMessage(fromAddress, toAddress) With {
                        .Subject = subject,
                        .IsBodyHtml = True,
                        .Body = body
                    }

                        smtp.Send(message)
                        MsgBox("Verification code sent successfully!", MsgBoxStyle.Information, "Barangay E-Voting System")
                    Else
                        ' If email does not exist, display a message
                        MsgBox("The provided email address does not exist in our records.", MsgBoxStyle.Exclamation, "Barangay E-Voting System")
                    End If
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Failed to send the verification email: " & ex.Message, MsgBoxStyle.Exclamation, "Barangay E-Voting System")
        End Try
    End Sub

    Private Function GenerateOTP() As String
        Dim otp As New Random()
        Dim otpCode As String = ""

        For i As Integer = 1 To 6
            otpCode += otp.Next(0, 9).ToString()
        Next

        Return otpCode
    End Function

    Private Sub CheckVerificationCode()
        Dim enterCode As String = OTPcode.Text
        If enterCode = verificationCode Then
            MsgBox("Email verification succeeded! You can now proceed to reset your password.", MsgBoxStyle.Information, "Barangay E-Voting System")
            NewPasswordTB.Enabled = True
            ConfirmPW.Enabled = True
            ResetPasswordBTN.Enabled = True
            SendOTP.Enabled = False ' Disable the Send OTP button after verification

            SendOTP.Text = "Verified"
        Else
            MsgBox("Email verification failed! Please try again.", MsgBoxStyle.Exclamation, "Barangay E-Voting System")
        End If
    End Sub

    Private Sub SendOTP_Click(sender As Object, e As EventArgs) Handles SendOTP.Click
        If EmailAddressTB.Text = "" Then
            MsgBox("Please enter your email address.", MsgBoxStyle.Exclamation, "Barangay E-Voting System")
        ElseIf Not IsValidEmail(EmailAddressTB.Text) Then
            MsgBox("Please enter a valid email address.", MsgBoxStyle.Exclamation, "Barangay E-Voting System")
        ElseIf SendOTP.Text = "Send Code" Then
            SendVerificationCode()
            SendOTP.Text = "Verify"
        ElseIf SendOTP.Text = "Verify" Then
            CheckVerificationCode()
        End If
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New MailAddress(email)
            Return addr.Host.ToLower() = "gmail.com" AndAlso addr.Address.EndsWith("@gmail.com")
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub ResetPasswordBTN_Click(sender As Object, e As EventArgs) Handles ResetPasswordBTN.Click
        If NewPasswordTB.Text = "" Or ConfirmPW.Text = "" Then
            MsgBox("Both new password and confirmation are required!", MsgBoxStyle.Exclamation, "Barangay E-Voting System")
        ElseIf NewPasswordTB.Text <> ConfirmPW.Text Then
            MsgBox("Passwords do not match!", MsgBoxStyle.Exclamation, "Barangay E-Voting System")
        Else
            ' Implement password reset logic here after verifying OTP

            ' Update the password in the database
            Dim email As String = EmailAddressTB.Text.Trim()
            Dim newPassword As String = NewPasswordTB.Text.Trim()

            Dim query As String = "UPDATE accounts SET [password] = @password WHERE [Email] = @email"
            Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rosal\Documents\Users_Account.accdb;")
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@password", newPassword)
                    cmd.Parameters.AddWithValue("@email", email)
                    con.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Password reset successful!", MsgBoxStyle.Information, "Barangay E-Voting System")
                        ' Optionally, close the form or redirect to login page
                    Else
                        MsgBox("Failed to reset password. Please try again.", MsgBoxStyle.Exclamation, "Barangay E-Voting System")
                    End If
                End Using
            End Using
        End If
    End Sub

    Private Sub PasswordResetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewPasswordTB.Enabled = False
        ConfirmPW.Enabled = False
        ResetPasswordBTN.Enabled = False
    End Sub


    Private Sub ExitPRF_Click(sender As Object, e As EventArgs) Handles ExitPRF.Click
        ' Clear input fields
        EmailAddressTB.Clear()
        OTPcode.Clear()
        NewPasswordTB.Clear()
        ConfirmPW.Clear()

        ' Disable password fields and reset verification status
        NewPasswordTB.Enabled = False
        ConfirmPW.Enabled = False
        ResetPasswordBTN.Enabled = False

        ' Reset SendOTP button text
        SendOTP.Text = "Send Code"

        ' Close the form
        Me.Hide()
        LoginForm.Show()
    End Sub

End Class
