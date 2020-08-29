Imports MySql.Data.MySqlClient

Public Class Student_Book_Return
    Dim Book_Not_Taken As Integer

    Private Sub clear_data()
        dt_1.Value = Today
        tb_2.Text = ""

        tb_4.Text = ""

        tb_7.Text = ""
        ' dd_1.Items.Clear()
        dd_1.Text = ""
        DataGridView1.DataMember = Nothing

    End Sub

    Private Sub Fill_Data()
        If tb_1.Text.Length = 8 Then


            'CHECKING FOR BOOK TAKEN OR NOT
            Try
                con.Open()
                str = "SELECT COUNT(status) FROM student_book_issue_db WHERE roll_no= '" & tb_1.Text & "' "
                com = New MySqlCommand(str, con)
                Book_Not_Taken = com.ExecuteScalar
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try

            'READING NAME
            Try
                con.Open()
                str = "SELECT s_name FROM student_registation_db WHERE roll_no= '" & tb_1.Text & "' "
                com = New MySqlCommand(str, con)
                tb_2.Text = com.ExecuteScalar
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try


            If Book_Not_Taken > 0 Then






                'READING NO OF BOOKS TAKEN AND TOTAL FINE

                Try
                    con.Open()
                    str = "SELECT  sum(status), sum(fine) FROM student_book_issue_db WHERE roll_no='" & tb_1.Text & "' GROUP BY roll_no "
                    com = New MySqlCommand(str, con)
                    reader = com.ExecuteReader

                    If reader.Read Then
                        '     tb_3.Text = reader("sum(status)")
                        tb_4.Text = reader("sum(fine)")

                    End If
                    reader.Close()

                Catch ex As Exception
                    MsgBox("STUDENT HAS NOT ISSUED ANY BOOK", MessageBoxIcon.Error, Title:="Student Book Return")
                    Book_Not_Taken = 1
                Finally
                    con.Close()
                End Try



                'DATAGRIDVIEW CODE

                Try
                    con.Open()
                    str = "SELECT  issue_date 'ISSUE DATE',book_name 'BOOK',author_name 'AUTHOR',edition 'EDITION',return_date 'RETURN DATE',fine 'FINE' FROM student_book_issue_db WHERE roll_no='" & tb_1.Text & "'  "
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
                Dim previous_book_no As String = ""

                'READING BOOK NOS

                Try
                    con.Open()
                    str = "SELECT book_no FROM student_book_issue_db WHERE roll_no='" & tb_1.Text & "' AND status=1 "
                    com = New MySqlCommand(str, con)

                    sqlda_SBR2 = New MySqlDataAdapter(com)
                    ds_SBR2.Clear()
                    sqlda_SBR2.Fill(ds_SBR2, "student_book_issue_db")
                    con.Close()

                    dd_1.DataSource = ds_SBR2.Tables("student_book_issue_db")
                    dd_1.DisplayMember = "book_no"

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try

                ' READING BOOK NAME

                Try
                    con.Close()
                    con.Open()
                    str = "SELECT   book_name FROM student_book_issue_db WHERE book_no='" & dd_1.Text & "' GROUP BY book_no "
                    com = New MySqlCommand(str, con)
                    reader = com.ExecuteReader

                    If reader.Read Then

                        tb_7.Text = reader("book_name")

                    End If
                    If dd_1.Text = Nothing Then
                        tb_7.Text = ""
                    End If
                    reader.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try



            End If


        Else
            clear_data()

        End If
    End Sub
    Private Sub tb_1_OnValueChanged(sender As Object, e As EventArgs) Handles tb_1.OnValueChanged
        Fill_Data()
    End Sub
    Dim Date_Diffrence As Integer
    Dim fine As Integer
    Private Sub dd_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dd_1.SelectedIndexChanged

        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Open()
            str = "SELECT   book_name FROM student_book_issue_db WHERE book_no='" & dd_1.Text & "' GROUP BY book_no "
            com = New MySqlCommand(str, con)
            reader = com.ExecuteReader



            If reader.Read Then

                tb_7.Text = reader("book_name")

            End If
            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Book_Returned()
        Try
            con.Close()
            con.Open()
            str = "SELECT  issue_date FROM student_book_issue_db WHERE book_no='" & dd_1.Text & "' AND status=1 "
            com = New MySqlCommand(str, con)
            reader = com.ExecuteReader

            If reader.Read Then

                Date_Diffrence = DateDiff(DateInterval.Day, reader("issue_date").Date, dt_1.Value.Date)
            End If
            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

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
        If Date_Diffrence > 30 Then

            fine = (Date_Diffrence - 30) * 0.1
        Else
            fine = 0
        End If
        Try
            con.Open()
            str = "UPDATE student_book_issue_db SET status=0, return_date= ' " & dtt & " ', date_diffrence=" & Date_Diffrence & ", fine=" & fine & " WHERE book_no='" & dd_1.Text & "' AND status=1 "
            com = New MySqlCommand(str, con)
            com.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub bt_Confirm_Click(sender As Object, e As EventArgs) Handles bt_Confirm.Click
        If tb_2.Text = "" Then

            MsgBox("Invalid  ROLL NO. : " & tb_1.Text, MessageBoxIcon.Error, Title:="Book Return")

        ElseIf tb_7.Text = "" Then

            MsgBox("NO BOOK ISSUED TO ROLL NO. : " & tb_1.Text, MessageBoxIcon.Exclamation, Title:="Book Return")

        Else
            Dim Delete_Request As Integer = MessageBox.Show("Conform Book Return For Roll No : " + tb_1.Text, "Undo Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Delete_Request = DialogResult.Yes Then
                Book_Returned()
                MsgBox("BOOK IS RETURNED", MessageBoxIcon.Information, Title:="Book Return")
                Fill_Data()

            End If
        End If

    End Sub

    Private Sub bt_Reset_Click(sender As Object, e As EventArgs) Handles bt_Reset.Click
        tb_1.Text = ""
        clear_data()
    End Sub

    Private Sub tb_2_OnValueChanged(sender As Object, e As EventArgs) Handles tb_2.OnValueChanged

    End Sub

    Private Sub dt_1_onValueChanged(sender As Object, e As EventArgs) Handles dt_1.onValueChanged
        If dt_1.Value.Date > Now.Date Then
            dt_1.Value = Today
            MsgBox("Incorect Date", MessageBoxIcon.Exclamation, Title:="Book Entry")
        End If
    End Sub

    Private Sub tb_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_1.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                If Asc(e.KeyChar) <> 8 Then

                    e.Handled = True

                End If
            End If
        End If
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        If tb_1.Text.Length >= 8 Then
            If Asc(e.KeyChar) <> 8 Then


                e.Handled = True

            End If
        End If
    End Sub
End Class