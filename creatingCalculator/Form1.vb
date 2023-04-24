Public Class Form1
    Private firstvalue, secondvalue, result As Double
    Private op As String

    Private Sub number_click(sender As Object, e As EventArgs) Handles Button7.Click, Button6.Click, Button5.Click, Button20.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click
        Dim b As Button = sender

        If (txtdisplay.Text = "0") Then
            txtdisplay.Text = ""
            txtdisplay.Text = b.Text

        ElseIf (b.Text = ".") Then
            If (Not txtdisplay.Text.Contains(".")) Then
                txtdisplay.Text = txtdisplay.Text + b.Text
            End If
        Else
            txtdisplay.Text = CStr(txtdisplay.Text + b.Text)
        End If


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        secondvalue = txtdisplay.Text
        If op = "+" Then
            result = firstvalue + secondvalue
            txtdisplay.Text = result
        ElseIf op = "-" Then
            result = firstvalue - secondvalue
            txtdisplay.Text = result
        ElseIf op = "/" Then
            result = firstvalue / secondvalue
            txtdisplay.Text = result
        ElseIf op = "*" Then
            result = firstvalue * secondvalue
            txtdisplay.Text = result
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtdisplay.Text.Contains("-") Then
            txtdisplay.Text = txtdisplay.Text.Remove(0, 1)
        Else
            txtdisplay.Text = "-" + txtdisplay.Text
        End If
    End Sub


    Private Sub Btnbackspace_Click(sender As Object, e As EventArgs) Handles Btnbackspace.Click
        If (txtdisplay.Text.Length > 0) Then

            txtdisplay.Text = txtdisplay.Text.Remove(txtdisplay.Text.Length - 1, 1)

        End If



        If (txtdisplay.Text.Length = 0) Then

            txtdisplay.Text = "0"

        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (txtdisplay.Text.Length > 0) Then

            txtdisplay.Text = "0"

        End If

    End Sub

    Private Sub operator_click(sender As Object, e As EventArgs) Handles txtdisplay.Click, Button9.Click, Button8.Click, Button11.Click, Button10.Click
        Dim b As Button = sender
        firstvalue = txtdisplay.Text
        op = b.Text
        txtdisplay.Text = "0"
    End Sub






End Class
