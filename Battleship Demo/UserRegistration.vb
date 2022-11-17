Imports System.IO
Imports System.Text


Public Class UserRegistration

    Dim validInput As Boolean

    Private Sub validateText(sender As Object, e As EventArgs) Handles UserTxt.TextChanged, PassTxt.TextChanged

        Dim Username, Password As String

        ErrorOutput.Text = Nothing
        Username = UserTxt.Text
        Password = PassTxt.Text
        validInput = True
        ErrorOutput.Visible = True
        ErrorOutput.Text = Nothing

        If Username <> Nothing Or Password <> Nothing Then
            If (Username.Length < 4) Or (Password.Length < 4) Then
                ErrorOutput.Text += "Username must be more than 4 characters. "
                validInput = False
            End If
            If (Username.Length > 8) Or (Password.Length > 8) Then
                ErrorOutput.Text += "Username must be less than 8 characters. "
                validInput = False
            End If
            If IsNumeric(Password) = False Then
                ErrorOutput.Text += "Password must contain one or more numbers. "
                ' validInput = False
            End If
        ElseIf Username = Nothing Or Password = Nothing Then
            ErrorOutput.Text += "Please enter your desired username and password. "
            validInput = False
        End If
        If validInput <> False Then
            validInput = True
            ErrorOutput.Text = Nothing
            ErrorOutput.Visible = False
        End If



    End Sub

    Private Sub Signup(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Username, Password As String
        Username = UserTxt.Text
        Password = PassTxt.Text

        Dim UserLength As Integer
        UserLength = Form1.Users.Length

        Dim successfulOp As Boolean

        If validInput = True Then

            successfulOp = WriteToBUD(Username, Password, UserLength)
            Console.WriteLine("New User Added: " & Username)
        Else
            MessageBox.Show(ErrorOutput.Text)
            Exit Sub

        End If

        If successfulOp Then
            Login(sender, e)

        End If

    End Sub

    Private Sub TestStreamReader(sender As Object, e As EventArgs) Handles Button2.Click

        Dim localdatetime As Date
        localdatetime = DateTime.Now
        WriteToBUD("TestUser" & localdatetime.ToString, "TestPass", Form1.Users.Length)

    End Sub

    Private Function WriteToBUD(username As String, password As String, UserLength As Integer)
        Dim retrievedUser As String
        Dim localstop As Boolean
        Dim indexfound As Integer
        For i = 0 To Form1.Users.GetLength(1)
            Console.WriteLine(Form1.Users.GetLength(1))
            If localstop = False Then
                Console.WriteLine(i)
                retrievedUser = Form1.Users(i, 0)
                If retrievedUser = username Then
                    indexfound = i
                    localstop = True
                End If
                If i = Form1.Users.Length - 1 Then
                    localstop = True
                End If
            End If
        Next

        If indexfound <> Nothing Then
            MessageBox.Show("That user already exists, please login to this account or choose a different username")
            Return False
            Exit Function
        End If

        Using BUDFile As StreamWriter = File.AppendText("userData/BUD.Txt")
            ReDim Form1.Users(UserLength + 1, 2)
            BUDFile.WriteLine(username)

            BUDFile.WriteLine(password)
        End Using
        Form1.LoadBud()
        Return True
    End Function

    Private Sub Login(sender As Object, e As EventArgs) Handles Button3.Click


        If validInput = True Then


            Dim username, password As String
            username = UserTxt.Text
            password = PassTxt.Text

            Dim indexfound As Integer = Nothing
            Dim retrievedUser As String
            Dim localstop As Boolean
            For i = 0 To Form1.Users.GetLength(1)
                If localstop = False Then
                    Console.WriteLine(i)
                    retrievedUser = Form1.Users(i, 0)
                    If retrievedUser = username Then
                        Console.WriteLine("Username found at: " & i)
                        indexfound = i
                        localstop = True
                    End If
                    If i = Form1.Users.Length - 1 Then
                        localstop = True
                    End If
                End If

            Next

            If indexfound <> Nothing Then
                If Form1.Users(indexfound, 1) = password Then

                    For i = 1 To 4
                        If Form1.Players(i) = username Then
                            MessageBox.Show("User already signed as player " & i)
                            Exit Sub
                        End If
                    Next

                    Form1.Players(PlayerNum.Value) = username
                    MessageBox.Show(username & " successfully signed in as Player" & PlayerNum.Value)
                    Exit Sub
                End If
            End If

            If indexfound = Nothing Or Form1.Users(indexfound, 1) <> password Then
                MessageBox.Show("Username or password incorrect, please retype your username and password and try again")
                Exit Sub
            End If

        Else
            MessageBox.Show(ErrorOutput.Text)
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Public Sub LoadBud()

        Dim stringreader As String
        stringreader = "initial"

        Using stream As New FileStream("userData/BUD.Txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite),
            reader As New StreamReader(stream)
            For i = 0 To Form1.Users.Length - 1
                Dim localUser, localPass As String


                localUser = reader.ReadLine()
                If localUser <> Nothing Then

                    Form1.Users(i, 0) = localUser
                    localPass = reader.ReadLine()


                    Form1.Users(i, 1) = localPass
                    Console.WriteLine("Username: " & Form1.Users(i, 0) & ", Password: " & Form1.Users(i, 1))
                Else

                End If
            Next
            reader.Close()
        End Using

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub
End Class
