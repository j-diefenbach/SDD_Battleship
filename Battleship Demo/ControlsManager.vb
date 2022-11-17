Public Class ControlsManager
    Dim Water(2) As Image
    Public Function LayoutPanels(numofPlayers As Integer)

        ' Dim i As Integer
        'For i = Form1.Controls.Count - 1 To 0 Step -1
        'If TypeOf Form1.Controls(i) Is TableLayoutPanel Then
        '  Form1.Controls.RemoveAt(i)
        'End If
        'Next




        Dim position As Point
        Dim size As Integer
        size = 300

        position = New Point(Form1.Width * 0.5 - size * 0.5, 0)

        CreatePanel(position, New Point(size, size), Form1.CurrentPlayer + 1)
        CreatePanel(New Point(position.X, size + 5), New Point(size, size), Form1.CurrentPlayer)


    End Function

    Public Function RearrangePanels()
        Dim Panels(4)
        Dim i As Integer
        Dim k As Integer = 1
        For i = Form1.Controls.Count - 1 To 0 Step -1
            If TypeOf Form1.Controls(i) Is TableLayoutPanel Then
                Panels(k) = Form1.Controls(i)
                k += 1
            End If
        Next

        Console.WriteLine(Panels(1).location.ToString)
        Console.WriteLine(Panels(2).location.ToString)

        Dim temp As Point
        temp = Panels(1).location
        Panels(1).location = Panels(2).location
        Panels(2).location = temp

        Console.WriteLine(Panels(1).location.ToString)
        Console.WriteLine(Panels(2).location.ToString)


    End Function


    Public Function CreatePanel(position As Point, size As Point, player As Integer)



        Dim LocalPanel As New TableLayoutPanel
        LocalPanel.Size = size
        LocalPanel.Location = position
        LocalPanel.Padding = New Padding(0, 0, 0, 0)
        LocalPanel.Margin = LocalPanel.Padding
        Console.WriteLine("localpanel created")

        For i = 1 To 10
            LocalPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
        Next
        For i = 1 To 10
            LocalPanel.RowStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
        Next

        Form1.Controls.Add(LocalPanel)
        FillPanel(LocalPanel, player)

    End Function

    Private Function FillPanel(panel As TableLayoutPanel, player As Integer)


        Dim defBtn As New Button
        defBtn.BackgroundImage = My.Resources.water_seamless
        defBtn.BackgroundImageLayout = ImageLayout.Zoom

        defBtn.Size = New Point(70, 70)
        defBtn.FlatStyle = FlatStyle.Flat
        defBtn.FlatAppearance.BorderSize = 1
        defBtn.FlatAppearance.BorderColor = Color.NavajoWhite
        defBtn.Margin = New Padding(0, 0, 0, 0)


        Dim index As Integer
        Dim j As Integer
        For index = 0 To 9
            For j = 0 To 9

                Dim localPB As New PictureBox
                localPB.Image = Water(1)
                localPB.Margin = New Padding(0, 0, 0, 0)
                localPB.SizeMode = PictureBoxSizeMode.StretchImage
                localPB.Size = New Point(100, 100)
                localPB.BackColor = Color.DodgerBlue
                'ControlPaint.DrawBorder(e.Graphics, localPB.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
                AddHandler localPB.Click, AddressOf Form1.GridClick
                AddHandler localPB.MouseEnter, AddressOf Form1.GridEnter
                AddHandler localPB.MouseHover, AddressOf Form1.GridHover
                AddHandler localPB.MouseLeave, AddressOf Form1.GridLeave


                Dim localBtn As New Button
                localBtn.BackgroundImage = defBtn.BackgroundImage
                localBtn.BackgroundImageLayout = defBtn.BackgroundImageLayout
                localBtn.FlatStyle = defBtn.FlatStyle
                localBtn.Margin = defBtn.Margin
                localBtn.FlatAppearance.BorderSize = 1
                localBtn.FlatAppearance.BorderColor = Color.DodgerBlue
                localBtn.FlatAppearance.BorderSize = defBtn.FlatAppearance.BorderSize
                localBtn.Size = defBtn.Size
                localPB.Name = index & j & player
                localPB.Cursor = Cursors.Cross

                AddHandler localBtn.Click, AddressOf Form1.GridClick
                AddHandler localBtn.MouseEnter, AddressOf Form1.GridEnter
                AddHandler localBtn.MouseHover, AddressOf Form1.GridHover
                AddHandler localBtn.MouseLeave, AddressOf Form1.GridLeave
                'panel.Controls.Add(localBtn, j, index)
                panel.Controls.Add(localPB, index, j)



            Next
        Next

    End Function

    Public Sub LoadImages()
        Water(1) = My.Resources.water_seamless
    End Sub

End Class
