Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Double
        Dim d As Integer
        Dim x1, x2


        a = (InputBox("1е число"))
        b = (InputBox("2е число"))
        c = (InputBox("3е число"))
        d = Val(b ^ 2 - 4 * a * c)

        MsgBox(d)

        If d > 0 Then
            x1 = (-b + d ^ 0.5) / 2 * a
            x2 = (-b - d ^ 0.5) / 2 * a
            MsgBox(x1)
            MsgBox(x2)
        ElseIf d = 0 Then
            x1 = -b / 2 * a
            MsgBox(x1)
        Else
            MsgBox("<0")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a
        a = InputBox("a=")
        For i = 1 To a
            MsgBox(i)
        Next i
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a, b As Integer

        a = Val(InputBox("a"))
        b = Val(InputBox("b"))
        MsgBox("Сумма " & a + b)

    End Sub
End Class
