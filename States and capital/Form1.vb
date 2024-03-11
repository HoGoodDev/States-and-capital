'Holly Goodwill
'States and Capitals excerise 
'3/11/2024

Option Strict On
Option Infer Off
Option Explicit On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblCapital_Click(sender As Object, e As EventArgs) Handles lblCapital.Click

        If lstStates.SelectedIndex = 0 Then

            lblCapital.Text = "Boise"

        End If

        If lstStates.SelectedIndex = 1 Then

            lblCapital.Text = "Annapolis"

        End If

        If lstStates.SelectedIndex = 2 Then

            lblCapital.Text = "Columbus"

        End If

        If lstStates.SelectedIndex = 3 Then

            lblCapital.Text = "Rhode Island"

        End If

        If lstStates.SelectedIndex = 4 Then

            lblCapital.Text = "Richmond"

        End If
    End Sub

End Class
