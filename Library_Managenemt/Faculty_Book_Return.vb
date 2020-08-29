Imports MySql.Data.MySqlClient

Public Class Faculty_Book_Return

    Private Sub clear_data()
        tb_123.Text = ""
        tb_2.Text = ""
        tb_3.Text = ""
        tb_7.Text = ""
        dt_1.Value = Today
        dd_1.Text = ""
        DataGridView1.DataMember = Nothing

    End Sub

    Private Sub faculty_details()

        Try
            con.Open()
            str = "SELECT  sum(status) FROM faculty_book_issue_db WHERE faculty_id= '" & tb_123.Text & "' "
            com = New MySqlCommand(str, con)
            reader = com.ExecuteReader
            If reader.Read Then

                tb_3.Text = reader.GetString("sum(status)")
            Else

                tb_3.Text = ""
            End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            tb_3.Text = ""
        Finally
            con.Close()
        End Try


        Try
            con.Open()
            str = "SELECT faculty_name FROM faculty_registation_db WHERE faculty_id= '" & tb_123.Text & "' "
            com = New MySqlCommand(str, con)

            reader = com.ExecuteReader

            If reader.Read Then
                tb_2.Text = reader.GetString("faculty_name")
            Else
                tb_2.Text = ""
                tb_3.Text = ""
            End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        If tb_2.Text = "" Then


            DataGridView1.DataMember = Nothing
            dd_1.DataSource = Nothing
            dd_1.DisplayMember = Nothing

        Else

            'DATAGRIDVIEW CODE

            Try
                con.Open()
                str = "Select  issue_date 'ISSUE DATE',book_name 'BOOK',author_name 'AUTHOR',edition 'EDITION',return_date 'RETURN DATE' FROM faculty_book_issue_db WHERE faculty_id= '" & tb_123.Text & "'  "
                com = New MySqlCommand(str, con)
                sqlda_FBR = New MySqlDataAdapter(com)

                ds_FBR.Clear()

                sqlda_FBR.Fill(ds_FBR, "category_db")
                con.Close()

                DataGridView1.DataSource = ds_FBR
                DataGridView1.DataMember = "category_db"

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try

            'DROPDOWN CODE

            Try
                con.Open()
                str = "SELECT book_no FROM faculty_book_issue_db WHERE faculty_id='" & tb_123.Text & "' AND status=1 "
                com = New MySqlCommand(str, con)

                sqlda_FBR2 = New MySqlDataAdapter(com)
                ds_FBR2.Clear()
                sqlda_FBR2.Fill(ds_FBR2, "faculty_book_issue_db")
                con.Close()

                dd_1.DataSource = ds_FBR2.Tables("faculty_book_issue_db")
                dd_1.DisplayMember = "book_no"

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If

    End Sub


    Private Sub tb_123_OnValueChanged(sender As Object, e As EventArgs) Handles tb_123.OnValueChanged
        faculty_details()

    End Sub

    Private Sub dd_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dd_1.SelectedIndexChanged
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Open()
            str = "SELECT   book_name FROM faculty_book_issue_db WHERE book_no='" & dd_1.Text & "' GROUP BY book_no "
            com = New MySqlCommand(str, con)
            reader = com.ExecuteReader



            If reader.Read Then

                tb_7.Text = reader("book_name")
            Else
                tb_7.Text = ""

            End If
            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub bt_Confirm_Click(sender As Object, e As EventArgs) Handles bt_Confirm.Click
        Try
            con.Open()
            str = "UPDATE book_entry_db SET status=1 WHERE book_no='" & dd_1.Text & "' "
            com = New MySqlCommand(str, con)
            com.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        dtt = dt_1.Value.ToString("yyyy-MM-dd")
        Try
            con.Open()
            str = "UPDATE faculty_book_issue_db SET status=0, return_date= ' " & dtt & " ' WHERE book_no='" & dd_1.Text & "' "
            com = New MySqlCommand(str, con)
            com.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        MsgBox("BOOK IS RETURNED", MessageBoxIcon.Information, Title:="Book Return")
        faculty_details()
    End Sub

    Private Sub tb_123_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_123.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then

                e.Handled = True

            End If
        End If
    End Sub

    Private Sub bt_Reset_Click(sender As Object, e As EventArgs) Handles bt_Reset.Click
        clear_data()
    End Sub
End Class