
'MIS 322
'Damanbir Singh
'LAP1
'9/29/2022

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'form color

        BackColor = Color.CornflowerBlue

        '"enter input" in input textbox

        typeInputTextBox.Text = "Enter Input"


    End Sub

    Private Sub copyPasteButton_Click(sender As Object, e As EventArgs) Handles copyPasteButton.Click

        'copy and paste the input

        copyInputTextBox.Text = typeInputTextBox.Text


    End Sub

    Private Sub yellowButton_Click(sender As Object, e As EventArgs) Handles yellowButton.Click

        'change back color to yellow

        BackColor = Color.Yellow


    End Sub

    Private Sub blueButton_Click(sender As Object, e As EventArgs) Handles blueButton.Click

        'change back color to blue

        BackColor = Color.Blue


    End Sub

    Private Sub redButton_Click(sender As Object, e As EventArgs) Handles redButton.Click

        'change back color to red

        BackColor = Color.Red


    End Sub

    Private Sub hideCopyButton_Click(sender As Object, e As EventArgs) Handles hideCopyButton.Click

        'hide copy of input label and textbox

        copyOfInputLabel.Visible = False
        copyInputTextBox.Visible = False


    End Sub

    Private Sub showCopyButton_Click(sender As Object, e As EventArgs) Handles showCopyButton.Click

        'show copy of input label and textbox

        copyInputTextBox.Visible = True
        copyOfInputLabel.Visible = True


    End Sub

    Private Sub resetFormButton_Click(sender As Object, e As EventArgs) Handles resetFormButton.Click

        'reset the form

        typeInputTextBox.Clear()
        copyInputTextBox.Clear()
        copyInputTextBox.Visible = True
        copyOfInputLabel.Visible = True
        BackColor = Color.CornflowerBlue

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        'close form and stop application

        Close()

    End Sub



End Class
