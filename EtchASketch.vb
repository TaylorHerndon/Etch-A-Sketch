Option Explicit On
Option Strict On

Imports System.IO

'Taylor Herndon
'RCET0265
'Spring 2021
'Etch-A-Sketch
'

Public Class EtchASketchForum

    Sub StartupSettings() Handles Me.Activated

        Static onlyRunOnce As Boolean

        If Not onlyRunOnce Then

            PictureBox.CreateGraphics.Clear(Color.White) 'Set the background of the picturebox to white

            HandDrawButton.BackColor = Color.WhiteSmoke 'Set default button color
            OscilloscopeButton.BackColor = Color.WhiteSmoke 'Set default button color

            StorePen(Color.Black, 1) 'Set default pen
            PenSizeNumericControl.Value = 1 'Select 1px as the default pen size
            PenSizeNumericControl.Maximum = 32 'Set 32px as the maximum pen size
            PenSizeNumericControl.Minimum = 1 'Set 1px as the minimium pen size

            AmplitudeControl.Value = 1 'Set default amplitude to "1V"
            AmplitudeControl.Maximum = 50 'Set max amplitude to "50V"
            AmplitudeControl.Minimum = 1 'Set minimum amplitude to "1V"

            FrequencyControl.Value = 1 'Set default frequency to 1Hz
            FrequencyControl.Maximum = 100 'Set max frequency to 100Hz
            FrequencyControl.Minimum = 1 'Set min frequenct to 1Hz

            StorePen(Color.Black, -1) 'Store the default pen

            DrawLine(New Point(-2, -2), New Point(-2, -2), False) 'Set the bitmap to a white background

            ColorDialog.AnyColor = True 'Choose color dialog type

        End If

        onlyRunOnce = True

    End Sub

    Sub OscilloscopeButtonPress() Handles OscilloscopeButton.Click, OscilloscopeToolStripMenuItem.Click

        StoreDrawState(2)

        'Clear button sets the background of the picturebox to white
        PictureBox.CreateGraphics.Clear(Color.White)

        PenSizeNumericControl.Value = 1 'Set pen width to 1px
        StorePen(Color.Black, 1)

        DrawLine(New Point(CInt(PictureBox.Width / 2), 0), New Point(CInt(PictureBox.Width / 2), PictureBox.Height), False) 'Draw a midpoint vertical line
        DrawLine(New Point(0, CInt(PictureBox.Height / 2)), New Point(PictureBox.Width, CInt(PictureBox.Height / 2)), False) 'Draw a midpoint horizontal line

        'Draw graticule lines on the y axis
        For i = 1 To 10

            DrawLine(New Point(CInt(PictureBox.Width / 2 - 10), CInt(PictureBox.Height / 10 * i)),
                     New Point(CInt(PictureBox.Width / 2 + 10), CInt(PictureBox.Height / 10 * i)), False)

        Next

        For i = 1 To 10

            DrawLine(New Point(CInt(PictureBox.Width / 10 * i), CInt(PictureBox.Height / 2 - 10)),
                     New Point(CInt(PictureBox.Width / 10 * i), CInt(PictureBox.Height / 2 + 10)), False)

        Next

    End Sub

    Sub SineButtonPress() Handles SineWaveButton.Click, DrawSineToolStripMenuItem.Click

        If StoreDrawState(-1) <> 2 Then

            Exit Sub

        End If

        PenSizeNumericControl.Value = 1 'Set pen width to 1px
        StorePen(Color.Blue, 1)

        DrawLine(New Point(0, CInt(PictureBox.Height / 2)), New Point(0, CInt(PictureBox.Height / 2)), False) 'Set the previous stored position to the start of the sine wave

        'Draw a sine wave
        For X = 0 To PictureBox.Width * FrequencyControl.Value

            DrawLine(New Point(0, 0),
                     New Point(CInt(X / CInt(FrequencyControl.Value)), CInt(Math.Sin(X / PictureBox.Width * 2 * Math.PI) * AmplitudeControl.Value * (PictureBox.Height / 10) + PictureBox.Height / 2)), True)

        Next

    End Sub

    Sub CosineButtonPress() Handles CosineButton.Click, DrawCosineToolStripMenuItem.Click

        If StoreDrawState(-1) <> 2 Then

            Exit Sub

        End If

        PenSizeNumericControl.Value = 1 'Set pen width to 1px
        StorePen(Color.Green, 1)

        DrawLine(New Point(0, CInt(PictureBox.Height / 2)), New Point(0, CInt(PictureBox.Height / 2)), False) 'Set the previous stored position to the start of the sine wave

        'Draw a cosine wave
        For X = 0 To PictureBox.Width * FrequencyControl.Value

            DrawLine(New Point(0, 0),
                     New Point(CInt(X / CInt(FrequencyControl.Value)), CInt(Math.Cos(X / PictureBox.Width * 2 * Math.PI) * AmplitudeControl.Value * (PictureBox.Height / 10) + PictureBox.Height / 2)), True)

        Next

    End Sub

    Sub TanButtonPress() Handles TangentButton.Click, DrawTangentToolStripMenuItem.Click

        If StoreDrawState(-1) <> 2 Then

            Exit Sub

        End If

        PenSizeNumericControl.Value = 1 'Set pen width to 1px
        StorePen(Color.Red, 1)

        DrawLine(New Point(0, CInt(PictureBox.Height / 2)), New Point(0, CInt(PictureBox.Height / 2)), False) 'Set the previous stored position to the start of the sine wave

        'Draw a tangent wave
        For X = 0 To PictureBox.Width * FrequencyControl.Value

            DrawLine(New Point(0, 0),
                     New Point(CInt(X / CInt(FrequencyControl.Value)), CInt(Math.Tan(X / PictureBox.Width * 2 * Math.PI) * AmplitudeControl.Value * (PictureBox.Height / 10) + PictureBox.Height / 2)), True)

        Next

    End Sub

    Sub PictureBoxMouseMove() Handles PictureBox.MouseMove

        'Get the current mouse position and offset it by a set ammount
        Dim offsetMousePosition As Point = New Point(MousePosition.X - Me.Left - 15, MousePosition.Y - Me.Top - 60)

        If StoreDrawState(-1) <> 1 Then

            'If the hand draw state is not selected exit the sub
            Exit Sub

        End If

        If MouseButtons = MouseButtons.Left Then

            'Draw a line from the last mouse position to the current one
            DrawLine(MousePosition, offsetMousePosition, True)

        Else

            'If the mouse ever moves on the canvas and the mouse is not held down then reset previous point to 0,0
            'This makes it so that the user does not have to draw one continuous line
            DrawLine(New Point(0, 0), New Point(0, 0), False)

        End If

    End Sub

    Sub PictureBoxMouseLeave() Handles PictureBox.MouseLeave

        'If the mouse ever leaves the picture box then reset the previous point to 0,0 this stops unwanted lines from being drawn
        DrawLine(New Point(0, 0), New Point(0, 0), False)

    End Sub

    Function DrawLine(firstPosition As Point, secondPosition As Point, usePreviousPosition As Boolean) As Bitmap

        'Storing a bitmap and a graphics object used to draw on the bit map, this is used later to save the drawn image
        Static myBitmap As Bitmap = New Bitmap(PictureBox.Width, PictureBox.Height)
        Static bitmapGraphics As Graphics = Graphics.FromImage(myBitmap)

        If firstPosition = New Point(-2, -2) Then

            'If 2, -2 is the given first position clear the bitmap and end the function

            Dim eraser As Pen = New Pen(Color.White)

            For i = 0 To myBitmap.Width

                'Draw a transparent line on each pixel
                bitmapGraphics.DrawLine(eraser, New Point(i, 0), New Point(i, myBitmap.Height))

            Next

            Return Nothing

        End If

        'Storing the previous point and picture box graphics object
        Static previousPosition As Point
        Static pictureBoxState As Graphics = PictureBox.CreateGraphics

        If firstPosition = New Point(-1, -1) Then

            Return myBitmap 'In the case that a (-1, -1) point was given as the first position return the bitmap

        End If

        If usePreviousPosition Then

            If previousPosition <> New Point(0, 0) Then

                pictureBoxState.DrawLine(StorePen(Color.Transparent, -1), previousPosition, secondPosition) 'Draw the line on the canvas
                bitmapGraphics.DrawLine(StorePen(Color.Transparent, -1), previousPosition, secondPosition) 'Draw the line on a bitmap

            Else

                previousPosition = secondPosition 'Update previous position
                Return Nothing

            End If

        Else

            pictureBoxState.DrawLine(StorePen(Color.Transparent, -1), firstPosition, secondPosition) 'Draw the line on the canvas
            bitmapGraphics.DrawLine(StorePen(Color.Transparent, -1), firstPosition, secondPosition) 'Draw the line on a bitmap

        End If

        previousPosition = secondPosition
        Return Nothing

    End Function

    Sub UpdatePenSize() Handles PenSizeNumericControl.ValueChanged

        Dim penSize As Single

        penSize = PenSizeNumericControl.Value

        StorePen(Color.Transparent, penSize)

    End Sub

    Function StorePen(penColor As Color, penWidth As Single) As Pen

        Static myPen As Pen

        'If pen color is transparent return the pen
        If penColor <> Color.Transparent Then

            myPen = New Pen(penColor)

        End If

        'If a penWidth is given then set the pencolor and penWidth this means that to set pen width pen color must also be selected
        If penWidth > 0 Then

            myPen = New Pen(penColor, penWidth)

        End If

        Return myPen

    End Function

    Sub SaveButtonPress() Handles SaveButton.Click, SaveToolStripMenuItem.Click

        Dim solutionDirectory As String = System.IO.Directory.GetCurrentDirectory

        If File.Exists(solutionDirectory & "\MyPictures") Then

            'Continue

        Else

            'If there is no "MyPictures" directory then create it
            System.IO.Directory.CreateDirectory(solutionDirectory & "\MyPictures")

        End If

        'Generating a file name
        Dim fileName As String = "My Amazing Drawing 0.png"

        For i = 0 To 9999

            If File.Exists(solutionDirectory & "\MyPictures\" & fileName) Then

                'If the currently selected file name is taken increment to the next number
                fileName = "My Amazing Drawing " & CStr(i) & ".png"

            Else

                'If the currently selected file name is open exit the loop
                Exit For

            End If

        Next

        'Retrive the bitmap that has been stored in the DrawLine Function
        Dim pictureBitmap As Bitmap = DrawLine(New Point(-1, -1), New Point(-1, -1), False)


        Try

            'Save the bitmap as a .png to the MyPictures directory
            pictureBitmap.Save(solutionDirectory & "\MyPictures\" & fileName, System.Drawing.Imaging.ImageFormat.Png)

            'Confirm sucess and tell the user where their image is located
            MsgBox("Your picture has been saved in: " & solutionDirectory & "\MyPictures\" & fileName, MsgBoxStyle.OkOnly, "File saved successfully!")

        Catch ex As Exception

            'Notify the user if there was an error
            MsgBox("An error has occurred when saving your picture.", MsgBoxStyle.OkOnly, "File Save Error")

        End Try

    End Sub

    Function StoreDrawState(newDrawState As Integer) As Integer

        Static storedDrawState As Integer

        If newDrawState > 0 Then

            storedDrawState = newDrawState

        End If

        'Set the button colors based on draw mode
        Select Case storedDrawState

            Case 0

                HandDrawButton.BackColor = Color.WhiteSmoke
                OscilloscopeButton.BackColor = Color.WhiteSmoke

            Case 1

                HandDrawButton.BackColor = Color.DarkGreen
                OscilloscopeButton.BackColor = Color.WhiteSmoke

            Case 2

                HandDrawButton.BackColor = Color.WhiteSmoke
                OscilloscopeButton.BackColor = Color.DarkGreen

            Case Else

                HandDrawButton.BackColor = Color.WhiteSmoke
                OscilloscopeButton.BackColor = Color.WhiteSmoke

        End Select

        Return storedDrawState

    End Function

    Sub HandDrawButtonPress() Handles HandDrawButton.Click, EnableHandDrawToolStripMenuItem.Click

        'Change the draw state if the hand draw button is pressed
        If StoreDrawState(-1) <> 1 Then

            StoreDrawState(1)

        Else

            StoreDrawState(0)

        End If

    End Sub

    Sub PictureBoxMouseButtonPress(sender As System.Object, e As MouseEventArgs) Handles PictureBox.MouseDown

        '4194304 is the ID for a middle mouse click
        If e.Button = 4194304 Then

            ColorDialog.ShowDialog()
            StorePen(ColorDialog.Color, -1)

        Else

        End If

    End Sub

    Sub SelectColor() Handles PenColorButton.Click, ChageColorMenuItem.Click

        ColorDialog.ShowDialog()
        StorePen(ColorDialog.Color, -1)

    End Sub

    Sub ClearButtonPress() Handles ClearButton.Click, ClearToolStripMenuItem.Click

        Dim originalYPos As Integer = Me.Top
        Dim shakeDirection As Boolean = False

        For i = 0 To 5 'Shake Shake Shake Shake

            If shakeDirection Then

                Me.Top = Me.Top + 20

            Else

                Me.Top = Me.Top - 20

            End If

            shakeDirection = Not shakeDirection
            System.Threading.Thread.Sleep(100)

        Next

        'Clear button sets the background of the picturebox to white
        PictureBox.CreateGraphics.Clear(Color.White)

        'Clear the stored bitmap
        DrawLine(New Point(-2, -2), New Point(-2, -2), False)

        For i = 0 To 5 'Shake Shake Shake Shake Round 2

            If shakeDirection Then

                Me.Top = Me.Top + 20

            Else

                Me.Top = Me.Top - 20

            End If

            shakeDirection = Not shakeDirection
            System.Threading.Thread.Sleep(100)

        Next

        Me.Top = originalYPos 'Return the form to its original position

    End Sub

    Sub ExitButtonPress() Handles ExitButton.Click, ExitToolStripMenuItem.Click

        End

    End Sub

End Class