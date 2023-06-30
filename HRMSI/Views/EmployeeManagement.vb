Imports System.Management

Public Class EmployeeManagement
    Dim dt As New DataTable

    Private Sub loadEmployeMngt()
        Using sql As New SqlDataAdapter("SELECT * FROM F1_EMPLOYEE", msCon)
            dt.Clear() : sql.Fill(dt)
            bsEmp.DataSource = dt
        End Using
    End Sub

    Private Sub EmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadEmployeMngt()
    End Sub

    Private Sub bsEmp_CurrentItemChanged(sender As Object, e As EventArgs) Handles bsEmp.CurrentItemChanged
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
            tbt13.Text = NullText(bsEmp.Current("gsisId"))
            tbt14.Text = NullText(bsEmp.Current("pagibigId"))
            tbt15.Text = NullText(bsEmp.Current("philhealthId"))
            tbt16.Text = NullText(bsEmp.Current("sssId"))
            tbt17.Text = NullText(bsEmp.Current("tinId"))
            tbt18.Text = NullText(bsEmp.Current("present_house_no"))
            tbt19.Text = NullText(bsEmp.Current("present_street"))
            tbt20.Text = NullText(bsEmp.Current("present_subdivision"))
            tbt21.Text = NullText(bsEmp.Current("present_barangay"))
            tbt22.Text = NullText(bsEmp.Current("present_city"))
            tbt23.Text = NullText(bsEmp.Current("present_province"))
            tbt24.Text = NullText(bsEmp.Current("present_zip"))
            tbt25.Text = NullText(bsEmp.Current("permanent_house_no"))
            tbt26.Text = NullText(bsEmp.Current("permanent_street"))
            tbt27.Text = NullText(bsEmp.Current("permanent_subdivision"))
            tbt28.Text = NullText(bsEmp.Current("permanent_barangay"))
            tbt29.Text = NullText(bsEmp.Current("permanent_city"))
            tbt30.Text = NullText(bsEmp.Current("permanent_province"))
            tbt31.Text = NullText(bsEmp.Current("permanent_zip"))
        End If
    End Sub
End Class
