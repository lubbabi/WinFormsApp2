Imports System.Data.OleDb
Imports Newtonsoft.Json.Linq
Imports IronQr

Public Class RegistrationForm
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rosal\Documents\Voters_Information.accdb;")
    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        VerifyCheck.Visible = False

        Dim toolTip As New ToolTip()

        ' List of text boxes to apply the tooltip
        Dim textBoxes() As TextBox = {LastNameTB, FirstNameTB, MiddleNameTB, DateOfBirth, PlaceOfBirth, SexTB, PhilSysCN}

        ' Set tooltip for each text box
        For Each textBox As TextBox In textBoxes
            toolTip.SetToolTip(textBox, "These fields are automatically filled when your PhilSys ID is verified.")
        Next
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Me.Close()
    End Sub

    Private Sub SubmitBTN_Click(sender As Object, e As EventArgs) Handles SubmitBTN.Click
        ' Check if any required field is left blank
        If Not AreAllFieldsFilled() Then
            MessageBox.Show("Please complete all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the PCN already exists in the database
        If Not IsPCNAlreadyRegistered(PhilSysCN.Text) Then
            ' PCN is not registered, proceed with registration
            Dim result As DialogResult = MessageBox.Show("Before submitting, understand: By clicking 'Submit', you agree to participate in electronic voting. Your data will be confidential and used solely for electoral purposes.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            If result = DialogResult.OK Then
                Try
                    con.Open()
                    Dim cmd As New OleDbCommand("INSERT INTO info (LastName, FirstName, MiddleName, DateOfBirth, PlaceOfBirth, Sex, PCN, HouseNoStreet, MunicipalityCity, StateProvince, Barangay, PhoneNumber, EmailAddress, UniqueKey) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", con)
                    cmd.Parameters.AddWithValue("@LastName", LastNameTB.Text)
                    cmd.Parameters.AddWithValue("@FirstName", FirstNameTB.Text)
                    cmd.Parameters.AddWithValue("@MiddleName", MiddleNameTB.Text)
                    cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth.Text)
                    cmd.Parameters.AddWithValue("@PlaceOfBirth", PlaceOfBirth.Text)
                    cmd.Parameters.AddWithValue("@Sex", SexTB.Text)
                    cmd.Parameters.AddWithValue("@PCN", PhilSysCN.Text)
                    cmd.Parameters.AddWithValue("@HouseNoStreet", HouseNoStreetTB.Text)
                    cmd.Parameters.AddWithValue("@MunicipalityCity", MunicipalityCityTB.Text)
                    cmd.Parameters.AddWithValue("@StateProvince", StateProvinceTB.Text)
                    cmd.Parameters.AddWithValue("@Barangay", BarangayTB.Text)
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTB.Text)
                    cmd.Parameters.AddWithValue("@EmailAddress", EmailAddressTB.Text)
                    cmd.Parameters.AddWithValue("@UniqueKey", AccountCreation.UniqueKey)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Registration success! Thank you for registration.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("An error occurred while processing your request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try
            End If
        Else
            VerificationResultTB.Text = "Warning: Duplicate registration is illegal. Verify your information or contact the election commission."
            MessageBox.Show("You are already registered.", "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' Disable all buttons and textboxes except the exit button
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox AndAlso ctrl.Name <> "VerificationResultTB" Then
                    CType(ctrl, TextBox).Text = ""
                    ctrl.Enabled = False
                ElseIf TypeOf ctrl Is Button AndAlso ctrl.Name <> "ExitBTN" Then
                    ctrl.Enabled = False
                End If
            Next

            ' Ensure VerificationResultTB is not cleared
            VerificationResultTB.Enabled = True
            VerifyCheck.Visible = False
        End If
    End Sub

    Private Function AreAllFieldsFilled() As Boolean
        ' Check if any of the required fields are blank
        If String.IsNullOrWhiteSpace(LastNameTB.Text) OrElse
       String.IsNullOrWhiteSpace(FirstNameTB.Text) OrElse
       String.IsNullOrWhiteSpace(MiddleNameTB.Text) OrElse
       String.IsNullOrWhiteSpace(DateOfBirth.Text) OrElse
       String.IsNullOrWhiteSpace(PlaceOfBirth.Text) OrElse
       String.IsNullOrWhiteSpace(SexTB.Text) OrElse
       String.IsNullOrWhiteSpace(PhilSysCN.Text) OrElse
       String.IsNullOrWhiteSpace(HouseNoStreetTB.Text) OrElse
       String.IsNullOrWhiteSpace(MunicipalityCityTB.Text) OrElse
       String.IsNullOrWhiteSpace(StateProvinceTB.Text) OrElse
       String.IsNullOrWhiteSpace(BarangayTB.Text) OrElse
       String.IsNullOrWhiteSpace(PhoneNumberTB.Text) OrElse
       String.IsNullOrWhiteSpace(EmailAddressTB.Text) Then
            Return False
        End If

        Return True
    End Function

    Private Function IsPCNAlreadyRegistered(pcn As String) As Boolean
        Dim isRegistered As Boolean = False
        Try
            con.Open()
            Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM info WHERE PCN = ?", con)
            cmd.Parameters.AddWithValue("@PCN", pcn)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                ' PCN already exists in the database
                isRegistered = True
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking PCN registration: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        Return isRegistered
    End Function

    Private Sub SelectID_Click(sender As Object, e As EventArgs) Handles SelectID.Click
        Dim open As New OpenFileDialog
        VerifyBTN.Text = "Verify"
        If open.ShowDialog() = DialogResult.OK Then
            FileName.Text = IO.Path.GetFileName(open.FileName)
            QRImage.Image = Image.FromFile(open.FileName)
        End If
    End Sub

    Private Sub VerifyBTN_Click(sender As Object, e As EventArgs) Handles VerifyBTN.Click
        VerifyBTN.Enabled = False
        VerifyBTN.Text = "Scanning..."

        ProgressBar1.Visible = True
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.MarqueeAnimationSpeed = 30
        VerificationResultTB.Clear()
        VerifyCheck.Visible = False

        ' Start the background worker to perform the scanning operation
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If QRImage.Image IsNot Nothing Then
            Try
                Dim bmp As Bitmap = New Bitmap(QRImage.Image)
                Dim reader As New QrReader()
                Dim results As IEnumerable(Of QrResult) = reader.Read(New QrImageInput(bmp))

                If results.Any() Then
                    Dim result As QrResult = results.First()
                    Dim jsonObject = JObject.Parse(result.Value)
                    Dim subject = jsonObject("subject")

                    ' Extract data from JSON
                    Dim lastName = subject.Value(Of String)("lName")
                    Dim firstName = subject.Value(Of String)("fName")
                    Dim middleName = subject.Value(Of String)("mName")
                    Dim sex = subject.Value(Of String)("sex")
                    Dim dob = subject.Value(Of String)("DOB")
                    Dim pob = subject.Value(Of String)("POB")
                    Dim pcn = subject.Value(Of String)("PCN")

                    ' Set the extracted values directly to e.Result
                    e.Result = {lastName, firstName, middleName, sex, dob, pob, pcn}
                Else
                    e.Result = "• Please ensure that the image contains a clear and valid QR code." & Environment.NewLine & Environment.NewLine &
                               "• You may also try adjusting the position or angle of the image for better scanning."
                End If
            Catch ex As Exception
                e.Result = "Only QR codes from National IDs are valid." & Environment.NewLine & Environment.NewLine &
                           "• Please ensure that the image contains a QR code from a National ID." & Environment.NewLine & Environment.NewLine &
                           "• You may also try adjusting the position or angle of the image for better scanning."

            End Try
        Else
            e.Result = "No image selected. Choose an image with a QR code."
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        VerifyBTN.Text = "Verified!"
        VerifyBTN.Enabled = True

        If e.Error IsNot Nothing Then
            MessageBox.Show("An error occurred: " & e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If TypeOf e.Result Is String Then
                VerifyBTN.Text = "Please Try Again!"
                VerificationResultTB.Text = DirectCast(e.Result, String)
            ElseIf TypeOf e.Result Is String() Then
                Dim data As String() = DirectCast(e.Result, String())
                VerificationResultTB.Text = Environment.NewLine & Environment.NewLine & "PhilID has been Verified"
                VerifyCheck.Visible = True

                ' Update TextBoxes with parsed values
                LastNameTB.Text = data(0)
                FirstNameTB.Text = data(1)
                MiddleNameTB.Text = data(2)
                SexTB.Text = data(3)
                DateOfBirth.Text = data(4)
                PlaceOfBirth.Text = data(5)
                PhilSysCN.Text = data(6)
            End If
        End If

        ' Hide the progress bar
        ProgressBar1.Visible = False
    End Sub

End Class