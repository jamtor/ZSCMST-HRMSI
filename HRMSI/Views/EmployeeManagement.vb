Imports System.Management

Public Class EmployeeManagement
    Dim dataTbl As New DataTable

    Private Sub loadEmployeMngt()
        Using sql As New SqlDataAdapter("SELECT * FROM F1_EMPLOYEE", msCon)
            dataTbl.Clear() : sql.Fill(dataTbl)
            bsEmp.DataSource = dataTbl
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

            getC1Employee_spouse(bsEmp.Current("id"))
            getC1Employee_children(bsEmp.Current("id"))
            getC1Employee_parents(bsEmp.Current("id"))
            getC1Employee_education(bsEmp.Current("id"))
            getC2Employee_Eligibility(bsEmp.Current("id"))
        End If
    End Sub
    Private Sub getC1Employee_education(ByVal empId As String)
        Dim dt As New DataTable
        Using qry As New SqlDataAdapter("SELECT * FROM CI_EMP_EDU WHERE employeeId = '" & empId & "'", msCon)
            dt.Clear() : qry.Fill(dt)
            bsEdu.DataSource = dt
        End Using
    End Sub
    Private Sub getC1Employee_parents(ByVal empId As String)
        Dim dt As New DataTable
        Using qry As New SqlDataAdapter("SELECT * FROM CI_EMP_PARENTS WHERE employeeId = '" & empId & "'", msCon)
            dt.Clear() : qry.Fill(dt)
            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("parent_type") = "Father" Then
                    FBtbt45.Text = NullText(dt.Rows(0).Item("lastName"))
                    FBtbt46.Text = NullText(dt.Rows(0).Item("firstName"))
                    FBtbt47.Text = NullText(dt.Rows(0).Item("midName"))
                    FBtbt48.Text = NullText(dt.Rows(0).Item("nameExt"))
                End If
                If dt.Rows(1).Item("parent_type") = "Mother" Then
                    FBtbt49.Text = NullText(dt.Rows(1).Item("lastName"))
                    FBtbt50.Text = NullText(dt.Rows(1).Item("firstName"))
                    FBtbt51.Text = NullText(dt.Rows(1).Item("midName"))
                    FBtbt52.Text = NullText(dt.Rows(1).Item("nameExt"))
                End If
            Else
                custom_tbt("FBtbt", 45, 52)
            End If
        End Using
    End Sub
    Private Sub getC2Employee_Eligibility(ByVal x As String)
        Dim dt As New DataTable
        Using qry As New SqlDataAdapter("select * from getC2Employee_Eligibility('" & x & "')", msCon)
            dt.Clear() : qry.Fill(dt)
            bsEligibility.DataSource = dt
        End Using
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        textBoxEnabled()
    End Sub
    Private Sub textBoxEnabled()
        For i = 1 To 31
            Dim tb = Me.Controls.Find("tbt" & i, True)
            If tb.Length > 0 Then
                tb(0).Enabled = True
            End If
        Next
        dgView.Enabled = False
    End Sub

    Private Sub bsEligibility_CurrentItemChanged(sender As Object, e As EventArgs) Handles bsEligibility.CurrentItemChanged
        If bsEligibility.Count > 0 Then
            CSEtbt1.Text = NullText(bsEligibility.Current("career_service"))
        End If
    End Sub
    Private Sub getC1Employee_children(ByVal empId As String)
        Dim dt As New DataTable
        Using qry As New SqlDataAdapter("SELECT * FROM CI_EMP_CHILD WHERE employeeId = '" & empId & "'", msCon)
            dt.Clear() : qry.Fill(dt)
            If dt.Rows.Count > 0 Then
                bsChild.DataSource = dt
            Else
                bsChild.DataSource = Nothing
            End If
        End Using
    End Sub
    Private Sub getC1Employee_spouse(ByVal empId As String)
        Dim dt As New DataTable
        Using qry As New SqlDataAdapter("select * from CI_EMP_SPOUSE where employeeId = '" & empId & "' ", msCon)
            dt.Clear() : qry.Fill(dt)
            If dt.Rows.Count > 0 Then
                FBtbt33.Text = NullText(dt.Rows(0).Item("spouse_lastName"))
                FBtbt34.Text = NullText(dt.Rows(0).Item("spouse_firstName"))
                FBtbt35.Text = NullText(dt.Rows(0).Item("spouse_middleName"))
                FBtbt36.Text = NullText(dt.Rows(0).Item("spouse_extension"))
                FBtbt37.Text = NullText(dt.Rows(0).Item("spouse_occupation"))
                FBtbt38.Text = NullText(dt.Rows(0).Item("spouse_employer"))
                FBtbt39.Text = NullText(dt.Rows(0).Item("spouse_employer_add"))
                FBtbt40.Text = NullText(dt.Rows(0).Item("spouse_employer_tel"))
            Else
                custom_tbt("FBtbt", 33, 40)
            End If
        End Using
    End Sub
    Private Sub custom_tbt(ByVal controlName As String, startInt As Integer, endInt As Integer)
        For i = startInt To endInt
            Dim tb = Me.Controls.Find(controlName & i, True)
            If tb.Length > 0 Then
                tb(0).Text = Nothing
            End If
        Next
    End Sub

    Private Sub bsChild_CurrentItemChanged(sender As Object, e As EventArgs) Handles bsChild.CurrentItemChanged
        If bsChild.Count > 0 Then
            FBtbt41.Text = NullText(bsChild.Current("child_lastname"))
            FBtbt42.Text = NullText(bsChild.Current("child_firstname"))
            FBtbt43.Text = NullText(bsChild.Current("child_midname"))
            FBtbt44.Text = NullText(bsChild.Current("child_ext"))
        Else
            custom_tbt("FBtbt", 41, 44)
        End If
    End Sub

    Private Sub bsEdu_CurrentItemChanged(sender As Object, e As EventArgs) Handles bsEdu.CurrentItemChanged
        If bsEdu.Count > 0 Then
            EBtbt53.Text = NullText(bsEdu.Current(""))
            EBtbt53.Text = NullText(bsEdu.Current(""))
            EBtbt53.Text = NullText(bsEdu.Current(""))
            EBtbt53.Text = NullText(bsEdu.Current(""))
            EBtbt53.Text = NullText(bsEdu.Current(""))
            EBtbt53.Text = NullText(bsEdu.Current(""))
        End If
    End Sub
End Class
