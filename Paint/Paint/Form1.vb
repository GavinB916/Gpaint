Public Class Form1
    Dim mouse As Boolean = False
    Dim Radius As Integer = 3
    Dim Mybrush As New SolidBrush(Color.Black)
    Dim pxpos As Integer
    Dim pypos As Integer
    Dim xpos As Integer
    Dim ypos As Integer





    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics


        pxpos = xpos
        pypos = ypos

        xpos = Me.MousePosition.X - Me.Location.X - 15
        ypos = Me.MousePosition.Y - Me.Location.Y - 40

        Label1.Text = Me.MousePosition.X - Me.Location.X - 15
        Label2.Text = Me.MousePosition.Y - Me.Location.Y - 40

        If mouse = True Then
            draw.DrawLine(New Pen(Mybrush, Radius), pxpos, pypos, xpos, ypos)
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        mouse = True
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        mouse = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Mybrush.Color = Color.Red

    End Sub
    Private Sub Form2_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

    End Sub

    Private Sub Form2_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Mybrush.Color = Color.Orange
    End Sub
    Private Sub Form3_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

    End Sub

    Private Sub Form3_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp


    End Sub

    Private Sub Form1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        Radius += 1
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ColorDialog1.ShowDialog()
        Mybrush.Color = ColorDialog1.Color
    End Sub
End Class