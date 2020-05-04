'/--------------------------------------------------------------------
'/ This Program is used to demonstrate the form back color changed   -
'/ on button click event, this also allow user to change the font    -
'/ font color of textboxes on button click event and this also allow -
'/ user to display the text of one textbox into another label control-
'/ Name: Muhammad Malik                                              -
'/ Date 01/27/2020                                                   -
'/--------------------------------------------------------------------

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Font color of textbox1 changed to red. 
        TextBox1.ForeColor = Color.Red

        ' Font color of textbox2 changed to blue.
        TextBox2.ForeColor = Color.Blue
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Check if form background color is green,
        ' if yes then change the back color of form to Yellow.
        If (Me.BackColor = Color.Green) Then
            ' Change the form back color to Yellow.
            Me.BackColor = Color.Yellow

            ' return the control.
            Return
        End If

        ' If above condition is not true then,
        ' Change the form back color to Green.
        Me.BackColor = Color.Green
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Close the application on Exit button click.
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' copy the text from textbox2 (blue) to the Label3
        Label3.Text = TextBox2.Text
    End Sub
End Class
