Imports MySql.Data.MySqlClient
Public Class SignUpofPatient
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Buttonclose_Click(sender As Object, e As EventArgs) Handles Buttonclose.Click
        Hide()
        loginforPatient.Show()

    End Sub

    Private Sub ButtonSignup_Click(sender As Object, e As EventArgs) Handles ButtonSignup.Click

        'check if feilds are empty
        'check if username already exixst   
        Dim name As String = TextBoxname.Text
        Dim email As String = TextBoxemail.Text
        Dim username As String = TextBoxusername.Text
        Dim pass As String = TextBoxpassword.Text
        Dim cpass As String = TextBoxcpassword.Text
        Dim mobileno As String = TextBoxmno.Text
        Dim dob As String = TextBoxdob.Text

        If name.Trim() = "" Or email.Trim() = "" Or username.Trim() = "" Or pass.Trim() = "" Or mobileno.Trim() = "" Then

            MessageBox.Show("One or More Fields are Blank", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf Not String.Equals(pass, cpass) Then

            MessageBox.Show("Wrong Password", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf usernameExist(username) Then

            MessageBox.Show("This Username Already Used, Choose Another", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            'add new users
            Dim conn As New myconnection()
            Dim command As New MySqlCommand("INSERT INTO `patient`( `f_name`, `username`, `email_id`, `password`, `contact`, `DOB`) VALUES (@name,@usn,@email,@pass,@mno,@dob)", conn.getConnection())

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
            command.Parameters.Add("@mno", MySqlDbType.Int64).Value = mobileno
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass
            command.Parameters.Add("@DOB", MySqlDbType.Date).Value = dob

            conn.openConnection()
            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Registration Complete", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim lpage As New loginforPatient()

            Else
                MessageBox.Show("Something Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.closeConnection()

            End If
        End If

    End Sub

    'create function to check if the username already exixst
    Private Function usernameExist(ByVal username As String) As Boolean

        Dim conn As New myconnection()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT  `username` FROM `patient` WHERE `username`=@usn ", conn.getConnection())
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username

        adapter.SelectCommand = command
        adapter.Fill(table)

        'if username exist return true
        If table.Rows.Count > 0 Then

            Return True
            'if not return false 
        Else
            Return False

        End If
    End Function

    Private Sub Buttonclose_MouseEnter(sender As Object, e As EventArgs) Handles Buttonclose.MouseEnter

        Buttonclose.ForeColor = Color.White

    End Sub

    Private Sub Buttonclose_MouseLeave(sender As Object, e As EventArgs) Handles Buttonclose.MouseLeave

        Buttonclose.ForeColor = Color.Red

    End Sub
    Private Sub Labelgotologin_Click(sender As Object, e As EventArgs) Handles Labelgotologin.Click

        Hide()
        loginforPatient.Show()


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles RoundButton1.Click
        Dim main As New loginoption
        main.Show()
        Hide()
    End Sub
End Class