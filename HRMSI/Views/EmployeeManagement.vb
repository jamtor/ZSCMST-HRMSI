Imports System.Management

Public Class EmployeeManagement
    Dim dt As New DataTable

    Private Sub loadEmployeMngt()
        Using sql As New SqlDataAdapter("SELECT *, A.id, A.firstName + ' ' + A.lastName AS Name, FORMAT(A.dateHired, 'MMM dd, yyyy') AS dateH, B.description
                                        FROM CI_EMP AS A LEFT JOIN CI_EMP_STATUS AS B ON A.emp_status = B.emp_status", msCon)
            dt.Clear() : sql.Fill(dt)
            bsEmp.DataSource = dt
        End Using
    End Sub

    Private Sub EmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadEmployeMngt()
    End Sub

    Private Sub bsEmp_CurrentChanged(sender As Object, e As EventArgs) Handles bsEmp.CurrentChanged
        If bsEmp.Count > 0 Then
            tbt1.Text = NullText(bsEmp.Current("cs_no"))
            tbt2.Text = bsEmp.Current("lastName")
            tbt3.Text = bsEmp.Current("firstName")
            tbt4.Text = NullText(bsEmp.Current("extension"))
            tbt5.Text = bsEmp.Current("middleName")
            tbt6.Text = bsEmp.Current("date_of_birth")
            tbt7.Text = NullText(bsEmp.Current("place_of_birth"))
            tbt8.Text = bsEmp.Current("gender")
            tbt9.Text = NullText(bsEmp.Current("civilStatus"))
            tbt10.Value = NullNum(bsEmp.Current("height"))
            tbt11.Value = NullNum(bsEmp.Current("weight"))
            tbt12.Text = NullText(bsEmp.Current("blood_type"))
        End If
    End Sub

End Class
