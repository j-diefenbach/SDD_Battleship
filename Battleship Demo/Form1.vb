Imports System.IO
Imports System.Text


Public Class Form1
    Public controlManager As New ControlsManager
    Public CurrentPlayer As Integer
    Public Players(4) As String
    Public playernum As Integer
    Dim RectanglesToDraw(10) As Rectangle
    Public Users(10, 2) As String
    Public attackPhase As Boolean

    Public UserReg As UserRegistration
    Public horizontal As Boolean








    Private Sub Button80_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Public Sub GridClick(sender As Object, e As EventArgs)

        Dim xpos, ypos As Int16
        xpos = Val(Strings.Mid(sender.name, 1, 1))
        ypos = Val(Strings.Mid(sender.name, 2, 1))

        If attackPhase Then

            Dim localstring As String
            localstring = MsgBox("Fire?", vbQuestion + vbYesNo)
            If localstring = vbYes Then
                MessageBox.Show("The targeted square has: " & Ships(xpos, ypos, Strings.Mid(sender.name, 3, 1)))

            Else

            End If



        Else
            If Val(Strings.Mid(sender.name, 3, 1)) = CurrentPlayer Then
                Console.WriteLine(sender.name & " Button clicked")

                If SelectedShip <> Nothing Then
                    ShipFiller(New Point(xpos, ypos), Strings.Mid(sender.name, 3, 1))
                Else

                End If

                RefreshPanels()
            Else
                Console.WriteLine(sender.name & " Button clicked")

                MessageBox.Show("Player" & Strings.Mid(sender.name, 3, 1) & "'s grid clicked, You are player " & CurrentPlayer)
            End If
        End If




    End Sub

    Public Sub RefreshPanels()
        Dim i As Integer
        For i = Controls.Count - 1 To 0 Step -1
            If TypeOf Controls(i) Is TableLayoutPanel Then
                Dim control As Control
                control = Controls(i).GetChildAtPoint(New Point(0, 0))
                UpdateLook(Mid(control.Name, 3, 1), Controls(i))
            End If
        Next
    End Sub

    Private Function DrawOnControl(control As Object, color As Color, width As Integer)
        Using g As Graphics = control.CreateGraphics()
            Dim bluePen As New Drawing.Pen(color, width)
            g.DrawRectangle(bluePen, New Rectangle(0, 0, control.width - width * 0.25, control.height - width * 0.25))
        End Using
    End Function




    Public Sub GridEnter(sender As Object, e As EventArgs)
        'sender.FlatAppearance.BorderColor = Color.White
        'sender.FlatAppearance.BorderSize = 3
        Dim xPos As String
        Dim yPos As String
        xPos = (Val(Strings.Mid(sender.name, 2, 1)) + 1).ToString


        yPos = Chr(65 + Val(Strings.Mid(sender.name, 1, 1)))

        DrawOnControl(sender, Color.White, 5)


        SelectedGrid.Text = yPos & xPos

    End Sub
    Public Sub GridHover(sender As Object, e As EventArgs)

        If Strings.Right(sender.name, 1) <> CurrentPlayer.ToString And attackPhase Then
            Dim i As Integer, j As Integer
            Dim localBtn As Control
            Dim localPanel As TableLayoutPanel
            localPanel = sender.parent
            j = Val(Strings.Mid(sender.name, 2, 1))
            For i = 0 To 9
                If i.ToString <> Strings.Mid(sender.name, 1, 1) Then
                    localBtn = localPanel.GetControlFromPosition(i, j)

                    DrawOnControl(localBtn, Color.White, 2)
                End If


            Next
            i = Val(Strings.Mid(sender.name, 1, 1))
            For j = 0 To 9
                If j.ToString <> Strings.Mid(sender.name, 2, 1) Then
                    localBtn = localPanel.GetControlFromPosition(i, j)
                    DrawOnControl(localBtn, Color.White, 2)
                End If

            Next
            DrawOnControl(sender, Color.White, 5)

        Else
            GridEnter(sender, e)
        End If


    End Sub
    Public Sub GridLeave(sender As Object, e As EventArgs)

        Dim i As Integer, j As Integer
        Dim localBtn As Control
        Dim localPanel As TableLayoutPanel
        localPanel = sender.parent
        sender.parent.Invalidate(True)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TicUpdate.Enabled = False

        fillShitGrid()
        AddUserRegPopup(sender, e)
        CurrentPlayer = 1
        playernum = 2
        UserReg.LoadBud()

    End Sub

    Private Sub GridDemo_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub CreateGrid(position As Point, size As Point, player As Integer)

        Dim LocalPanel As New TableLayoutPanel
        LocalPanel.Size = size
        Controls.Add(LocalPanel)

        Dim i As Integer
        For i = 1 To 10
            LocalPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
        Next
        For i = 1 To 10
            LocalPanel.RowStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
        Next

    End Sub

    Private Sub StartGame(sender As Object, e As EventArgs) Handles BeginBtn.Click

        BeginBtn.Visible = False
        LoginBtn.Visible = False
        ReturnToMenuBtn.Visible = True
        FlipBtn.Visible = True
        RotateBtn.Visible = True




        GridVisualise()
        controlManager.LayoutPanels(2)



        AddShipSelection(False)
    End Sub



    Private Sub AddUserRegPopup(sender As Object, e As EventArgs)

        UserReg = New UserRegistration
        Controls.Add(UserReg)
        UserReg.Location = New Point(Me.Width * 0.5 - UserReg.Width * 0.5, Me.Height * 0.5 - UserReg.Height * 0.5)
        UserReg.Visible = False
    End Sub

    Private Function UserRegVisible() Handles LoginBtn.Click
        UserReg.Visible = True
        Console.WriteLine("Opened User Registration")
    End Function


    Public Sub LoadBud()
        'Dim fileReader As System.IO.StreamReader

        'fileReader = My.Computer.FileSystem.OpenTextFileReader("UserData/BUD.Txt")
        Dim stringreader As String
        stringreader = "initial"

        Using stream As New FileStream("userData/BUD.Txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite),
            reader As New StreamReader(stream)
            For i = 0 To Users.Length - 1
                Dim localUser, localPass As String


                localUser = reader.ReadLine()
                If localUser <> Nothing Then

                    Users(i, 0) = localUser
                    localPass = reader.ReadLine()


                    Users(i, 1) = localPass
                    Console.WriteLine("Username: " & Users(i, 0) & ", Password: " & Users(i, 1))
                Else

                End If
            Next
            reader.Close()
        End Using

    End Sub

    Private Sub GridOutputTxt_SelectedIndexChanged(sender As Object, e As EventArgs)
        outputShitGrid(2)
    End Sub

    Private Sub RotateShips(sender As Object, e As EventArgs) Handles RotateBtn.Click


        If Mid(SelectedShip, 2, 1) = "H" Then
            SelectedShip = Mid(SelectedShip, 1, 1) & "V" & Mid(SelectedShip, 3, 2)
        Else
            SelectedShip = Mid(SelectedShip, 1, 1) & "H" & Mid(SelectedShip, 3, 2)

        End If

        If horizontal Then
            horizontal = False
        Else
            horizontal = True
        End If

        AddShipSelection(horizontal)



    End Sub

    Public Sub FlipPanelBtnClick(sender As Object, e As EventArgs) Handles FlipBtn.Click

        If ShipsLeftToPlace = 0 Then
            If CurrentPlayer < playernum Then
                CurrentPlayer += 1
                controlManager.RearrangePanels()
                ResetShipSelection()
                RefreshPanels()



            Else
                MessageBox.Show("All Players Placed - Proceed to attack phase")
                CurrentPlayer = 1
                attackPhase = True
                controlManager.RearrangePanels()
                ResetShipSelection()
                RefreshPanels()
                RefreshPanels()

            End If

        Else
            MessageBox.Show("Please place your remaining " & ShipsLeftToPlace & " ships.")

        End If


    End Sub
End Class
