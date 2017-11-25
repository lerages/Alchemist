Public Class Form1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)

#Region "controls"
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Label_casts.MouseMove, Label_min.MouseMove, Label_max.MouseMove, Label_min.MouseMove, Label_interval.MouseMove, Picture_hat.MouseMove, Label_Title.MouseMove, Picture_icon.MouseMove, Label_mousedown.MouseMove, Label_clicksleft.MouseMove, Label_clickInterval.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Label_casts.MouseDown, Label_min.MouseDown, Label_max.MouseDown, Label_min.MouseDown, Label_interval.MouseDown, Picture_hat.MouseDown, Label_Title.MouseDown, Picture_icon.MouseDown, Label_mousedown.MouseDown, Label_clicksleft.MouseDown, Label_clickInterval.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Label_casts.MouseUp, Label_min.MouseUp, Label_max.MouseUp, Label_min.MouseUp, Label_interval.MouseUp, Picture_hat.MouseUp, Label_Title.MouseUp, Picture_icon.MouseUp, Label_mousedown.MouseUp, Label_clicksleft.MouseUp, Label_clickInterval.MouseUp
        drag = False
    End Sub





#End Region




    Private Sub sendClicks(ByVal delay As Integer)

        mouse_event(&H2, 0, 0, 0, 0) 'mouse down
        System.Threading.Thread.Sleep(delay)
        mouse_event(&H4, 0, 0, 0, 0) 'mouse up
    End Sub

    Function valuesValidated()
        If TextBox_downMin.Text < TextBox_downMax.Text Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_toggle.Click
        If valuesValidated() Then
            castsLeft = TextBox_nCasts.Text
            If ClickTimer.Enabled Then
                ClickTimer.Stop()
                Button_toggle.Text = "Start"
            Else
                ClickTimer.Interval = TextBox_clickInterval.Text
                ClickTimer.Start()
                Button_toggle.Text = "Stop"
            End If
        Else
            MsgBox("Minimum value must not exceed maximum value")
        End If

    End Sub
    Dim castsLeft As Integer = 0
    Dim clickIntervalModifier As Integer = 0
    Private Function getRandom(ByVal min As Integer, ByVal max As Integer)
        Return Int((max - min + 1) * Rnd() + min)
    End Function


    Private Sub updateLabels(ByVal downDelay)
        Label_mousedown.Text = "Mouse down: " + downDelay.ToString
        Label_clicksleft.Text = "Clicks left: " + castsLeft.ToString
        Label_clickInterval.Text = "Click interval: " + ClickTimer.Interval.ToString
    End Sub
    Private Sub iterateCounter()
        castsLeft = castsLeft - 1
    End Sub


    Private Sub ClickTimer_Tick(sender As Object, e As EventArgs) Handles ClickTimer.Tick
        iterateCounter()

        clickIntervalModifier = getRandom(getRandom(-200, 100), getRandom(-132, 200))
        ClickTimer.Interval = TextBox_clickInterval.Text + clickIntervalModifier

        Dim downDelay As Integer = getRandom(TextBox_downMin.Text, TextBox_downMax.Text)
        updateLabels(downDelay)
        sendClicks(downDelay)
    End Sub


#Region "Input validation"
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_downMin.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_nCasts.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_downMax.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_clickInterval.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles exitButton.MouseHover
        With exitButton
            .ForeColor = Color.FromArgb(255, 255, 87)
        End With
    End Sub

    Private Sub exitButton_MouseLeave(sender As Object, e As EventArgs) Handles exitButton.MouseLeave
        With exitButton
            .ForeColor = Color.White
        End With
    End Sub





#End Region
End Class
