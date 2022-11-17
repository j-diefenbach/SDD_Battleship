Public Module Layout

    Public Ships(10, 10, 4) As String
    Public ShipsLeftToPlace As Integer
    Public SelectedShip As String
    Public outputVis As New ListBox
    Public GridVisualiser As New Form
    Dim ShipPanel As Panel

    Public WithEvents TicUpdate As New Timer

    Public Function ResetShipSelection()
        Form1.Controls.Remove(ShipPanel)
        ShipPanel = Nothing
        AddShipSelection(True)
    End Function


    Public Function AddShipSelection(horizontal As Boolean)


        Dim ShipButtons(5) As Button

        Dim i As Integer
        Dim createButtons As Integer
        createButtons = False
        Dim size As Integer
        size = 30

        If IsNothing(ShipPanel) Then
            ShipsLeftToPlace = 5
            Dim localpanel As New Panel
            localpanel.Size = New Point((size + 10) * 5, (size + 20) * 5)
            localpanel.Location = New Point(650, 300)

            ShipPanel = localpanel

            createButtons = True



        Else

            For i = ShipPanel.Controls.Count - 1 To 0 Step -1

                Dim j As Integer
                Select Case ShipPanel.Controls(i).Name
                    Case Is = "A"
                        j = 1
                    Case Is = "B"
                        j = 2
                    Case Is = "C"
                        j = 3
                    Case Is = "D"
                        j = 4
                    Case Is = "P"
                        j = 5
                End Select

                ShipButtons(j) = ShipPanel.Controls(i)

            Next


        End If






        Dim initialloc As Point
        initialloc = New Point(0, 0)
        Dim deltaloc As Point

        If horizontal Then
            deltaloc = New Point(0, 50)
        Else
            deltaloc = New Point(40, 0)
        End If

        For i = 1 To 5

            If createButtons = False Then
                'If ShipButtons(i).Enabled Then
                Dim localbtn As Button
                localbtn = ShipButtons(i)
                Select Case i
                    Case 1
                        AddSingleShipSelector(initialloc, localbtn, horizontal, size)
                    Case 2
                        AddSingleShipSelector(initialloc, localbtn, horizontal, size)
                    Case 3
                        AddSingleShipSelector(initialloc, localbtn, horizontal, size)
                    Case 4
                        AddSingleShipSelector(initialloc, localbtn, horizontal, size)
                    Case 5
                        AddSingleShipSelector(initialloc, localbtn, horizontal, size)

                End Select
                initialloc += deltaloc

                'End If

            Else


                Dim localbtn As New Button


                Select Case i
                    Case 1
                        localbtn.Name = "A"
                        ShipButtons(i) = AddSingleShipSelector(initialloc, localbtn, horizontal, size)
                    Case 2
                        localbtn.Name = "B"
                        ShipButtons(i) = AddSingleShipSelector(initialloc, localbtn, horizontal, size)
                    Case 3
                        localbtn.Name = "C"
                        ShipButtons(i) = AddSingleShipSelector(initialloc, localbtn, horizontal, size)
                    Case 4
                        localbtn.Name = "D"
                        ShipButtons(i) = AddSingleShipSelector(initialloc, localbtn, horizontal, size)
                    Case 5
                        localbtn.Name = "P"
                        ShipButtons(i) = AddSingleShipSelector(initialloc, localbtn, horizontal, size)
                End Select
                initialloc += deltaloc


            End If


        Next


        Form1.Controls.Add(ShipPanel)


    End Function

    Public Function AddSingleShipSelector(position As Point, ship As Button, horizontal As Boolean, size As Integer)



        Dim localbutton As New Button
        localbutton = ship
        Dim localheight As Integer
        localheight = 30
        Select Case ship.Name
            Case Is = "B"
                localbutton.Text = "Battleship"
                localbutton.Name = "B"


                If horizontal Then
                    localbutton.Size = New Point(localheight * 4, localheight)
                Else
                    localbutton.Size = New Point(localheight, localheight * 4)
                End If

            Case Is = "A"
                localbutton.Text = "Aircraft Carrier"
                localbutton.Name = "A"

                If horizontal Then
                    localbutton.Size = New Point(localheight * 5, localheight)
                Else
                    localbutton.Size = New Point(localheight, localheight * 5)
                End If

            Case Is = "C"
                localbutton.Text = "Cruiser"
                localbutton.Name = "C"

                If horizontal Then
                    localbutton.Size = New Point(localheight * 3, localheight)
                Else
                    localbutton.Size = New Point(localheight, localheight * 3)
                End If

            Case Is = "D"
                localbutton.Text = "Destroyer"
                localbutton.Name = "D"

                If horizontal Then
                    localbutton.Size = New Point(localheight * 3, localheight)
                Else
                    localbutton.Size = New Point(localheight, localheight * 3)
                End If


            Case Is = "P"
                localbutton.Text = "Patrol Boat"
                localbutton.Name = "P"

                If horizontal Then
                    localbutton.Size = New Point(localheight * 2, localheight)
                Else
                    localbutton.Size = New Point(localheight, localheight * 2)
                End If


        End Select


        AddHandler localbutton.Click, AddressOf ShipSelected
        localbutton.Location = position
        ShipPanel.Controls.Add(localbutton)

        Return localbutton

    End Function

    Public Function GridVisualise()

        TicUpdate.Interval = 100
        TicUpdate.Enabled = True

        GridVisualiser = New Form
        GridVisualiser.Size = New Point(400, 400)
        GridVisualiser.Name = "GridVis"
        GridVisualiser.Show()

        outputVis.Name = "Listgrid"

        outputVis.BackColor = Color.SteelBlue
        outputVis.ForeColor = Color.White
        outputVis.Size = New Point(400, 400)
        GridVisualiser.Controls.Add(outputVis)


    End Function

    Sub ShipSelected(sender As Object, e As EventArgs)



        If SelectedShip <> Nothing Then
                For i = ShipPanel.Controls.Count - 1 To 0 Step -1
                If ShipPanel.Controls(i).Name = Left(SelectedShip, 1) Then
                    ShipPanel.Controls(i).Enabled = True
                End If

            Next
            End If

        Dim horizontal As Char
        If sender.width < sender.height Then
            horizontal = "V"
        Else
            horizontal = "H"
        End If
        SelectedShip = Left(sender.text, 1) & horizontal & "1" & "O"

        sender.enabled = False







    End Sub

    Public Sub TimerUpdate(sender As Object, e As EventArgs) Handles TicUpdate.Tick
        outputShitGrid(2)
    End Sub

    Public Function outputShitGrid(player As Integer)
        Dim localrow As String
        outputVis.Items.Clear()

        For j = 0 To 9
            For i = 0 To 9
                localrow += Ships(i, j, player) & " "
            Next
            outputVis.Items.Add(localrow)
            outputVis.Items.Add(vbTab)
            localrow = Nothing
        Next

    End Function

    Public Function fillShitGrid()

        For x = 1 To 4
            For i = 0 To 9
                For j = 0 To 9
                    Ships(i, j, x) = "OOOO"
                Next
            Next
        Next

    End Function

    Public Function ShipFiller(SelectedGrid As Point, player As Integer)
        Dim shipstring As String
        shipstring = SelectedShip

        Dim horizontal As Boolean
        If Strings.Mid(shipstring, 2, 1) = "H" Then
            horizontal = True
        Else
            horizontal = False
        End If

        Dim ShipTiles(5) As Point
        Dim Ship As Char
        Dim TileNo As Integer
        Ship = Strings.Mid(shipstring, 1, 1)

        Select Case Ship
            Case Is = "A"
                TileNo = 5
            Case Is = "B"
                TileNo = 4
            Case Is = "C"
                TileNo = 3
            Case Is = "D"
                TileNo = 3
            Case Is = "P"
                TileNo = 2

        End Select

        Dim i As Integer

        For i = 1 To 5
            ShipTiles(i) = New Point(11, 11) 'Instead of 0,0 as nothing value
            '  which means that A1 which Is represented As 0, 0 will be ignored as it Is the same as the default value
        Next
        If horizontal Then
            For i = 1 To TileNo
                ShipTiles(i) = New Point(SelectedGrid.X + i - 1, SelectedGrid.Y)
            Next

        Else
            For i = 1 To TileNo
                ShipTiles(i) = New Point(SelectedGrid.X, SelectedGrid.Y + i - 1)
            Next


        End If

        Dim overlap As Boolean
        overlap = False
        For i = 1 To TileNo
            Dim overflow As Boolean = False

            If ShipTiles(i).X < 0 Or ShipTiles(i).X > 9 Then
                overlap = True
                overflow = True
            End If
            If ShipTiles(i).Y < 0 Or ShipTiles(i).Y > 9 Then
                overlap = True
                overflow = True
            End If
            If overflow = False Then 'stop overflow error
                Console.WriteLine(Ships(ShipTiles(i).X, ShipTiles(i).Y, player))
                If Ships(ShipTiles(i).X, ShipTiles(i).Y, player) <> "OOOO" Then
                    overlap = True
                End If
            End If

        Next

        If overlap = False Then
            For i = 1 To 5
                If ShipTiles(i) <> New Point(11, 11) Then
                    Dim x, y As Integer

                    x = ShipTiles(i).X
                    y = ShipTiles(i).Y



                    If x < 10 And y < 10 Then
                        Ships(ShipTiles(i).X, ShipTiles(i).Y, player) = Ship & Strings.Mid(shipstring, 2, 1) & i & "O"

                    End If
                End If
            Next

            SelectedShip = "OOOO"
            ShipsLeftToPlace += -1


        Else

            MessageBox.Show("Illegal placement")
            SelectedShip = shipstring


        End If





    End Function


    Public Function UpdateLook(player As Integer, panel As TableLayoutPanel)



        If player = Form1.CurrentPlayer Then
            For i = 0 To 9
                For j = 0 To 9


                    Dim shipString As String
                    shipString = Ships(i, j, player)

                    Dim control As PictureBox
                    control = panel.GetControlFromPosition(i, j)

                    Select Case Mid(shipString, 1, 1)
                        Case Is = "A"
                            control.BackColor = Color.White
                        Case Is = "B"
                            control.BackColor = Color.Blue
                        Case Is = "C"
                            control.BackColor = Color.Green
                        Case Is = "D"
                            control.BackColor = Color.Yellow
                        Case Is = "P"
                            control.BackColor = Color.Gray
                    End Select


                Next
            Next

        Else
            For i = 0 To 9
                For j = 0 To 9


                    Dim shipString As String
                    shipString = Ships(i, j, player)

                    Dim control As PictureBox
                    control = panel.GetControlFromPosition(i, j)

                    Select Case Mid(shipString, 4, 1)
                        Case Is = "O"
                            control.BackColor = Color.DodgerBlue
                        Case Is = "X"
                            control.BackColor = Color.Red
                        Case Is = "M"
                            control.BackColor = Color.White

                    End Select


                Next
            Next
        End If











    End Function

    Public Function AttackLayout()
        Form1.Controls.Remove(ShipPanel)
        ShipPanel = Nothing
    End Function

End Module
