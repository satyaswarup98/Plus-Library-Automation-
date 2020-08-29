Imports MySql.Data.MySqlClient


Public Class Student_Reoprt

    Private Sub Year_Display()

        For j = Now.Year To Now.Year - 3 Step -1
            dd_2.Items.Add(j & "-" & j + 2)
        Next

    End Sub

    Private Sub Student_Reoprt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Year_Display()
        MsgBox("CHOOSE YOUR SEASSION", MsgBoxStyle.Information, Title:="Student Report")
    End Sub

    Private Sub dd_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dd_2.SelectedIndexChanged
        Try
            con.Open()
            str = "SELECT *  FROM student_registation_db where session='" & dd_2.Text & "'  "

            com = New MySqlCommand(str, con)
            sqlda_SR = New MySqlDataAdapter(com)

            ds_SR.Clear()

            sqlda_SR.Fill(ds_SR, "student_registation_db")
            con.Close()

            Dim cryRpt As New Member_Report

            cryRpt.SetDataSource(ds_SR)
            CrystalReportViewer1.ReportSource = cryRpt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


End Class