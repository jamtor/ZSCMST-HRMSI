Imports System.Management

Public Class EmployeeManagement
    Dim dt As New DataTable

    Private Sub loadEmployeMngt()
        Using sql As New SqlDataAdapter("SELECT * FROM CI_EMP", msCon)
            dt.Clear() : sql.Fill(dt)
            bsEmp.DataSource = dt
            If dt.Rows.Count > 0 Then
                Debug.Print(dt.Rows.Count)
            End If
        End Using
    End Sub

    Private Sub EmployeeManagement_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadEmployeMngt()
    End Sub
End Class
