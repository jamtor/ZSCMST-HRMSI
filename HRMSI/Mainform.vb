Imports System.Drawing.Text
Imports Microsoft.VisualBasic.Logging

Public Class Mainform


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

    Private Sub MainPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainPanel.Paint

    End Sub

    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Close()
        Application.Exit()

    End Sub
End Class
