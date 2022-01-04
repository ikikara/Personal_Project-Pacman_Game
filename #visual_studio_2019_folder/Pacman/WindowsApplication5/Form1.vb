Public Class Form1
    Dim pacmananimation As New Label
    Dim direction As New Label

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.D Then
            direction.Text = "right"
        End If
        If e.KeyCode = Keys.A Then
            direction.Text = "left"
        End If
        If e.KeyCode = Keys.S Then
            direction.Text = "down"
        End If
        If e.KeyCode = Keys.W Then
            direction.Text = "up"
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If direction.Text = "right" Then
            PACMAN.Location = New Point(PACMAN.Location.X + 1, PACMAN.Location.Y)
            If pacmananimation.Text = "1" Then
                PACMAN.BackgroundImage = My.Resources.PRO
                pacmananimation.Text = "0"
            Else
                PACMAN.BackgroundImage = My.Resources.PRC
                pacmananimation.Text = "1"
            End If

            If PACMAN.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                PACMAN.Left = PictureBox1.Left - PACMAN.Width
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                PACMAN.Left = PictureBox2.Left - PACMAN.Width
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox3.Bounds) Then
                PACMAN.Left = PictureBox3.Left - PACMAN.Width
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox4.Bounds) Then
                PACMAN.Left = PictureBox4.Left - PACMAN.Width
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox5.Bounds) Then
                PACMAN.Left = PictureBox5.Left - PACMAN.Width
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                PACMAN.Left = PictureBox6.Left - PACMAN.Width
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox7.Bounds) Then
                PACMAN.Left = PictureBox7.Left - PACMAN.Width
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox8.Bounds) Then
                PACMAN.Left = PictureBox8.Left - PACMAN.Width
            End If
        End If

        If direction.Text = "left" Then
            PACMAN.Location = New Point(PACMAN.Location.X - 1, PACMAN.Location.Y)
            If pacmananimation.Text = "1" Then
                PACMAN.BackgroundImage = My.Resources.PLO
                pacmananimation.Text = "0"
            Else
                PACMAN.BackgroundImage = My.Resources.PLC
                pacmananimation.Text = "1"
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                PACMAN.Left = PictureBox1.Right
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                PACMAN.Left = PictureBox2.Right
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox3.Bounds) Then
                PACMAN.Left = PictureBox3.Right
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox4.Bounds) Then
                PACMAN.Left = PictureBox4.Right
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox5.Bounds) Then
                PACMAN.Left = PictureBox5.Right
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                PACMAN.Left = PictureBox6.Right
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox7.Bounds) Then
                PACMAN.Left = PictureBox7.Right
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox8.Bounds) Then
                PACMAN.Left = PictureBox8.Right
            End If
        End If

        If direction.Text = "down" Then
            PACMAN.Location = New Point(PACMAN.Location.X, PACMAN.Location.Y + 1)
            If pacmananimation.Text = "1" Then
                PACMAN.BackgroundImage = My.Resources.PDO
                pacmananimation.Text = "0"
            Else
                PACMAN.BackgroundImage = My.Resources.PDC
                pacmananimation.Text = "1"
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                PACMAN.Top = PictureBox1.Top - PACMAN.Height
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                PACMAN.Top = PictureBox2.Top - PACMAN.Height
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox3.Bounds) Then
                PACMAN.Top = PictureBox3.Top - PACMAN.Height
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox4.Bounds) Then
                PACMAN.Top = PictureBox4.Top - PACMAN.Height
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox5.Bounds) Then
                PACMAN.Top = PictureBox5.Top - PACMAN.Height
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                PACMAN.Top = PictureBox6.Top - PACMAN.Height
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox7.Bounds) Then
                PACMAN.Top = PictureBox7.Top - PACMAN.Height
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox8.Bounds) Then
                PACMAN.Top = PictureBox8.Top - PACMAN.Height
            End If
        End If

        If direction.Text = "up" Then
            PACMAN.Location = New Point(PACMAN.Location.X, PACMAN.Location.Y - 1)
            If pacmananimation.Text = "1" Then
                PACMAN.BackgroundImage = My.Resources.PUO
                pacmananimation.Text = "0"
            Else
                PACMAN.BackgroundImage = My.Resources.PUC
                pacmananimation.Text = "1"
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                PACMAN.Top = PACMAN.Bottom - 19
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                PACMAN.Top = PACMAN.Bottom - 19
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox3.Bounds) Then
                PACMAN.Top = PACMAN.Bottom - 19
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox4.Bounds) Then
                PACMAN.Top = PACMAN.Bottom - 19
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox5.Bounds) Then
                PACMAN.Top = PACMAN.Bottom - 19
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                PACMAN.Top = PACMAN.Bottom - 19
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox7.Bounds) Then
                PACMAN.Top = PACMAN.Bottom - 19
            End If
            If PACMAN.Bounds.IntersectsWith(PictureBox8.Bounds) Then
                PACMAN.Top = PACMAN.Bottom - 19
            End If
        End If
    End Sub

    Private Sub orange_ghost_Click(sender As Object, e As EventArgs) Handles orange_ghost.Click

        Dim Xr As Integer
        Dim Yr As Integer

        Dim DirectionX As Boolean
        Dim DirectionY As Boolean

        Dim ChangeDT As Integer

        Dim ChangeX As Byte
        Dim ChangeY As Byte

        Dim orange As PictureBox
        



    End Sub
End Class

