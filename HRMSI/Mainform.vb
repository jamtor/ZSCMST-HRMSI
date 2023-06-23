Imports System.Drawing.Text
Imports Microsoft.VisualBasic.Logging

Public Class Mainform

    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbopen()
    End Sub

    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click
        Dim UserControl As New EmployeeManagement()
        UserControl.Dock = DockStyle.Fill
        MainPanel.Controls.Add(UserControl)
        MainTabs.Visible = False
    End Sub

    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton1.Click
        MainPanel.Controls.Clear()
        MainTabs.Visible = True
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Close()
        Application.Exit()
    End Sub
End Class
