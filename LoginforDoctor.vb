Imports MySql.Data.MySqlClient
Public Class LoginforDoctor
    Private Sub Buttonclose_Click(sender As Object, e As EventArgs) Handles Buttonclose.Click
        Hide()
        loginoption.Show()


    End Sub

    Private Sub Labelgotosignup_Click(sender As Object, e As EventArgs) Handles Labelgotosignup.Click
        Hide()
        SignUpofDoctor.Show()

    End Sub
    Private Sub Buttonclose_MouseEnter(sender As Object, e As EventArgs) Handles Buttonclose.MouseEnter

        Buttonclose.ForeColor = Color.White
    End Sub

    Private Sub Buttonclose_MouseLeave(sender As Object, e As EventArgs) Handles Buttonclose.MouseLeave

        Buttonclose.ForeColor = Color.Red

    End Sub
    Private Sub TextBoxusername_Enter(sender As Object, e As EventArgs) Handles TextBoxusername.Enter

        'Clear the textbox when the textbox get focus
        Dim Username As String = TextBoxusername.Text
        'check if Username is empty
        'check if the textbox contains the defualt value "Username"
        If Username.Trim().ToLower = "username" Or Username.Trim() = "" Then
            'clear the textbox
            TextBoxusername.Text = ""
            'change the textbox for color 
            TextBoxusername.ForeColor = Color.Black

        End If
    End Sub
    Private Sub TextBoxpassword_Enter(sender As Object, e As EventArgs) Handles TextBoxpassword.Enter

        'Clear the textbox when the textbox get focus
        Dim password As String = TextBoxpassword.Text
        'check if password is empty
        'check if the textbox contains the defualt value "password"
        If password.Trim().ToLower = "password" Or password.Trim() = "" Then
            'clear the textbox
            TextBoxpassword.Text = ""
            'change the textdsbox for color 
            TextBoxpassword.ForeColor = Color.Black
            'use system password
            TextBoxpassword.UseSystemPasswordChar = True
        End If
    End Sub

    'button login
    Private Sub Button2Click(sender As Object, e As EventArgs) Handles Button2.Click

        'before the user can login we need to check if the textboxes are empty 
        'if they contain the defualt values( username & password )
        'check if this user exit in the database 

        Dim conn As New myconnection()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT `username`, `password` FROM `doctor` WHERE `username`=@usn AND `password`=@pass", conn.getConnection())

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBoxusername.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxpassword.Text

        If TextBoxusername.Text.Trim() = "" Or TextBoxusername.Text.Trim().ToLower() = "username" Then

            MessageBox.Show("Enter Your Username", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf TextBoxpassword.Text.Trim() = "" Or TextBoxpassword.Text.Trim().ToLower() = "password" Then

            MessageBox.Show("Enter Your Password", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            adapter.SelectCommand = command
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                Me.Hide()
                Dim mainappform As New doctorhomepage()
                mainappform.Show()
                MessageBox.Show("welcome to Carecroft Doctor")

            Else
                MessageBox.Show("This Username Or Password Doesn't Exit", "Loggin Unsuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If

    End Sub



    Private Sub LoginforDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class