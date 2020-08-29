Imports MySql.Data.MySqlClient

Public Class View_Transaction
    Private Sub dt_1_onValueChanged(sender As Object, e As EventArgs) Handles dt_1.onValueChanged
        If dt_1.Value.Date > Now.Date Then
            dt_1.Value = Today
            MsgBox("Incorect Date", MessageBoxIcon.Exclamation, Title:="Book Entry")
        Else

            datagrid_show(dd_3.SelectedIndex)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub View_Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_1.Value = "01-01-2015"
        dt_2.Value = Today
        dd_3.SelectedIndex = 0
        datagrid_show(dd_3.SelectedIndex)
    End Sub

    Private Sub dt_2_onValueChanged(sender As Object, e As EventArgs) Handles dt_2.onValueChanged
        If dt_2.Value.Date > Now.Date Then
            dt_2.Value = Today
            MsgBox("Incorect Date", MessageBoxIcon.Exclamation, Title:="Book Entry")
        Else
            datagrid_show(dd_3.SelectedIndex)
        End If
    End Sub

    Private Sub datagrid_show(ByRef A As Integer)

        dtt = dt_1.Value.ToString("yyyy-MM-dd")
        dtt2 = dt_2.Value.ToString("yyyy-MM-dd")
        'DATAGRIDVIEW CODE

        Try
            con.Open()
            If A = 0 Then
                str = "SELECT  issue_date 'ISSUE DATE',roll_no 'ROLL NO',book_no 'BOOK NO',book_name 'BOOK',return_date 'RETURN DATE' FROM student_book_issue_db where issue_date BETWEEN '" & dtt & "' and '" & dtt2 & "'  "
            Else
                str = "SELECT  issue_date 'ISSUE DATE',roll_no 'ROLL NO',book_no 'BOOK NO',book_name 'BOOK',return_date 'RETURN DATE' FROM student_book_issue_db where return_date BETWEEN '" & dtt & "' and '" & dtt2 & "'  "

            End If
            com = New MySqlCommand(str, con)
            sqlda_SBR = New MySqlDataAdapter(com)

                ds_SBR.Clear()

                sqlda_SBR.Fill(ds_SBR, "category_db")
                con.Close()

                DataGridView1.DataSource = ds_SBR
                DataGridView1.DataMember = "category_db"

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub


    Private Sub dd_3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dd_3.SelectedIndexChanged
        datagrid_show(dd_3.SelectedIndex)
    End Sub
End Class