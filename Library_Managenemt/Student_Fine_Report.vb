Imports MySql.Data.MySqlClient

Public Class Student_Fine_Report

    Private Sub Year_Display()

        For j = Now.Year To Now.Year - 3 Step -1
            dd_2.Items.Add(j & "-" & j + 2)
        Next

    End Sub
    Private Sub Student_Fine_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Year_Display()
        MsgBox("CHOOSE YOUR SEASSION", MsgBoxStyle.Information, Title:="Fine Report")

    End Sub

    Private Sub dd_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dd_2.SelectedIndexChanged
        Try
            con.Open()
            str = "SELECT student_book_issue_db.roll_no, student_book_issue_db.s_name,SUM(student_book_issue_db.fine) 'fine' FROM student_book_issue_db JOIN student_registation_db ON student_book_issue_db.roll_no=student_registation_db.roll_no WHERE student_registation_db.session='" & dd_2.Text & "' GROUP BY student_book_issue_db.roll_no"
            com = New MySqlCommand(str, con)
            sqlda_SFR = New MySqlDataAdapter(com)

            ds_SFR.Clear()

            sqlda_SFR.Fill(ds_SFR, "student_book_issue_db")
            con.Close()

            Dim cryRpt As New Fine_Report

            cryRpt.SetDataSource(ds_SFR)
            CrystalReportViewer1.ReportSource = cryRpt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class