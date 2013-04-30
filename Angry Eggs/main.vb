Public Class main
    Dim hSpeed As Single = -2
    Dim vSpeed As Single = -2
    Dim rows As Integer = 5
    Dim cols As Integer = 10
    Dim topRow As Single = 0.1
    Dim rowHeight As Single = 0.1
    Dim score As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Mengecek bila telur menyentuh bagian atas window
        If egg.Top < 39 Then
            vSpeed = -vSpeed
        End If

        'Mengecek bila telur menyentuh bagian kiri window
        If egg.Left < 0 Then
            hSpeed = -hSpeed
        End If

        'Mengecek bila telur menyentuh bagian bawah window
        If egg.Bottom > Me.ClientRectangle.Height Then
            Timer1.Enabled = False
            egg.Image = My.Resources.eggbreak
            restart.Text = "NEW GAME"
            My.Computer.Audio.Play(Application.StartupPath & "\lose.wav")
            MsgBox("GAME OVER !!!" & vbNewLine & vbNewLine & "Your Score : " & score)
        End If

        Dim C As Single = egg.Left + egg.Width / 2
        'Mengecek bila telur menyentuh bat
        If C > bat.Left And C < bat.Right And vSpeed > 0 And egg.Bottom > bat.Top And egg.Top < bat.Top Then
            vSpeed = -vSpeed
            My.Computer.Audio.Play(Application.StartupPath & "\shot.wav")

            'Membelokkan bola
            Dim offset As Single = (egg.Left + egg.Width / 2) - (bat.Left + bat.Width / 2)
            Dim ratio As Single = offset / (bat.Width / 2)
            hSpeed += 3 * ratio
        End If

        'Mengecek bila telur menyentuh bagian kanan windows
        If egg.Right > Me.ClientRectangle.Width - 0 Then
            hSpeed = -hSpeed
        End If

        For Each cnt As Control In Me.Controls
            If cnt.Name = "brick" Then
                checkBrick(cnt, egg)
            End If
        Next

        egg.Left += hSpeed
        egg.Top += vSpeed
    End Sub

    Private Sub checkBrick(brick As PictureBox, ByVal egg As PictureBox)
        If brick.Visible Then
            Dim hit As Boolean = False
            Dim C As Single = egg.Left + egg.Width / 2

            'Mengecek bila telur menyentuh bagian bawah brick
            If vSpeed < 0 And C > brick.Left And C < brick.Right And egg.Top < brick.Bottom And egg.Bottom > brick.Bottom Then
                vSpeed = -vSpeed
                hit = True
            End If

            'Mengecek bila telur menyentuh bagian atas brick
            If vSpeed > 0 And C > brick.Left And C < brick.Right And egg.Bottom > brick.Top And egg.Top < brick.Top Then
                vSpeed = -vSpeed
                hit = True
            End If

            C = egg.Top + egg.Height / 2
            'Mengecek bila telur menyentuh bagian kiri brick
            If hSpeed > 0 And C > brick.Top And C < brick.Bottom And egg.Right > brick.Left And egg.Left < brick.Left Then
                hSpeed = -hSpeed
                hit = True
            End If

            'Mengecek bila telur menyentuh bagian kanan brick
            If hSpeed < 0 And C > brick.Top And C < brick.Bottom And egg.Left < brick.Right And egg.Right > brick.Right Then
                hSpeed = -hSpeed
                hit = True
            End If

            If hit Then
                brick.Visible = False
                score += brick.Tag
                My.Computer.Audio.Play(Application.StartupPath & "\oink.wav")
                scoreLabel.Text = score.ToString
                If score = 150 Then
                    Timer1.Stop()
                    restart.Text = "NEW GAME"
                    My.Computer.Audio.Play(Application.StartupPath & "\win.wav")
                    MsgBox("CONGRATULATION !!!" & vbNewLine & vbNewLine & "You Got Perfect Score : 150")
                End If
            End If
        End If
    End Sub

    Private Sub main_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        bat.Width = 0.3 * Me.ClientRectangle.Width
        bat.Height = 0.05 * Me.ClientRectangle.Height
        bat.Top = 0.95 * Me.ClientRectangle.Height
        bat.Left = e.X - (0.15 * Me.ClientRectangle.Width)
    End Sub

    Private Sub makeBrick()
        'menghapus brick lama
        For i As Integer = Me.Controls.Count - 1 To 0 Step -1
            If Me.Controls(i).Name = "brick" Then
                Me.Controls.RemoveAt(i)
            End If
        Next

        'membuat brick baru
        For r As Integer = 0 To rows - 1
            For c As Integer = 0 To cols - 1
                Dim b As New PictureBox
                Me.Controls.Add(b)
                b.Visible = True
                b.Name = "brick"
                b.Tag = rows - r
                b.Width = Me.ClientRectangle.Width / cols
                b.Height = Me.ClientRectangle.Height * rowHeight
                b.Left = c * b.Width
                b.Top = Me.ClientRectangle.Height * (topRow + r * rowHeight)
                If (r + c) Mod 2 = 0 Then
                    b.BackgroundImage = My.Resources.pig1
                Else
                    b.BackgroundImage = My.Resources.pig2
                End If
            Next
        Next

        With egg
            .Left = Me.ClientRectangle.Width / 2
            .Top = Me.ClientRectangle.Height * 0.9
            vSpeed = -3
            hSpeed = 1
        End With
        Timer1.Enabled = True
        egg.Image = My.Resources.egg
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load
        makeBrick()
        egg.Left = Me.ClientRectangle.Width / 2
        egg.Top = Me.ClientRectangle.Height * 0.9
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        makeBrick()
        score = 0
    End Sub

    Private Sub ExitGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitGameToolStripMenuItem.Click
        End
    End Sub

    Private Sub restart_Click(sender As Object, e As EventArgs) Handles restart.Click
        makeBrick()
        score = 0
        scoreLabel.Text = "0"
    End Sub
End Class
