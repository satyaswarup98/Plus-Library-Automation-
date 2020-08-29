Imports MySql.Data.MySqlClient

Public Class Request_Book_Offline

    Dim Invalid_Roll, Book_Request_Count, Book_Issue_Count, Requests_For_A_Book, Same_Book_Is_Issued, Same_Book_Is_Requested As Integer

    '----------CODE FOR AUTO SUGGESTION IN DATA GRIG VIEW-------------

    Private Sub tb_1_TextChanged(sender As Object, e As EventArgs) Handles tb_1.TextChanged
        If tb_1.Text <> "" Then
            View_Book_List(tb_1.Text)
        Else
            DataGridView1.DataMember = Nothing
        End If
    End Sub


    Sub View_Book_List(ByVal book_name As String)

        Try
            con.Open()
            str = "SELECT book_name 'BOOK', author_name 'AUTHOR', EDITION, publication_name 'PUBLICATION', count(*) 'TOTAL', sum(status) 'AVAILABLE', ISBN_no FROM book_entry_db WHERE  book_name LIKE '" & book_name + "%" & "'  GROUP BY author_name"
            com = New MySqlCommand(str, con)

            sqlda_RBO = New MySqlDataAdapter(com)

            ds_RBO.Clear()
            sqlda_RBO.Fill(ds_RBO, "category_db")
            con.Close()

            DataGridView1.DataSource = ds_RBO
            DataGridView1.DataMember = "category_db"

            '--HIDING ISBN COLUMN--
            DataGridView1.Columns("isbn_no").Visible = False


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub



    '----------CODE FOR SHOING NAME IN BOX----------------------

    Private Sub tb_2_OnValueChanged(sender As Object, e As EventArgs) Handles tb_2.OnValueChanged

        If tb_2.Text.Length = 8 Then
            Try
                con.Open()
                str = "SELECT roll_no,s_name FROM student_registation_db WHERE roll_no= '" & tb_2.Text & "' "
                com = New MySqlCommand(str, con)
                reader = com.ExecuteReader
                If reader.Read Then
                    tb_3.Text = reader.GetString("s_name")
                    Invalid_Roll = 1
                End If

                reader.Close()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try


        Else
            tb_3.Text = ""
            Invalid_Roll = 0

        End If
    End Sub




    Private Sub bt_Request_Click(sender As Object, e As EventArgs) Handles bt_Request.Click


        If DataGridView1.DataMember <> "category_db" Then

            MsgBox("No Book Selected", MessageBoxIcon.Warning, Title:="Book Request")

        Else

            If Invalid_Roll <> 1 Then

                MsgBox("Invalid Roll No./ Student Not Registerd", MessageBoxIcon.Warning, Title:="Book Request")

            Else

                'CODE FOR STUDENT PREVIOUS BOOK ISSUE DETAILS
                Try
                    con.Open()
                    str = "select count(*) from student_book_issue_db where roll_no= '" & tb_2.Text & "' and status=1 "
                    com = New MySqlCommand(str, con)
                    Book_Issue_Count = com.ExecuteScalar
                    con.Close()
                Catch ex As Exception
                    Book_Issue_Count = 0
                Finally
                    con.Close()
                End Try


                If Book_Issue_Count >= 3 Then

                    MsgBox("You Have Already Issued Three Books", MessageBoxIcon.Warning, Title:="Book Request")

                Else

                    'CODE FOR STUDENT PREVIOUS BOOK REQUEST DETAILS
                    Try
                        con.Open()
                        str = "select count(*) from  book_request_db where roll_no= '" & tb_2.Text & "' and status IN(0,1) "
                        com = New MySqlCommand(str, con)
                        Book_Request_Count = com.ExecuteScalar
                        con.Close()
                    Catch ex As Exception
                        Book_Request_Count = 0
                    Finally
                        con.Close()
                    End Try

                    If Book_Request_Count >= 2 Then

                        MsgBox("You Have Already Requested For Two Books", MessageBoxIcon.Warning, Title:="Book Request")

                    Else

                        ' CODE TO CHECK NO OF AVALABLE BOOKS OF SAME ISBN

                        If DataGridView1.CurrentRow.Cells("AVAILABLE").Value < 1 Then

                            MsgBox("Book Is Not Available In The Stock", MessageBoxIcon.Information, Title:="Book Request")

                        Else

                            ' CODE FOR COUNT NO OF BOOK REQUESTED FOR SAME ISBN NO
                            Try
                                con.Open()
                                str = "select count(*) from  book_request_db where isbn_no='" & DataGridView1.CurrentRow.Cells("isbn_no").Value & "' AND status =1 "
                                com = New MySqlCommand(str, con)
                                Requests_For_A_Book = com.ExecuteScalar
                                con.Close()
                            Catch ex As Exception
                                Requests_For_A_Book = 0
                            Finally
                                con.Close()
                            End Try

                            If Requests_For_A_Book >= DataGridView1.CurrentRow.Cells("AVAILABLE").Value Then

                                MsgBox("All Available Books Are Already Requested", MessageBoxIcon.Information, Title:="Book Request")

                            Else


                                'CODE TO CHECK IF STUDENT HAVE ISSUES THE SAME BOOK WHICH IS REQUESTED
                                Try
                                    con.Open()

                                    str = " SELECT COUNT(*) FROM student_book_issue_db WHERE roll_no= '" & tb_2.Text & "' and ISBN_no= '" & DataGridView1.CurrentRow.Cells("isbn_no").Value & "' and status=1 GROUP BY roll_no"
                                    com = New MySqlCommand(str, con)
                                    Same_Book_Is_Issued = com.ExecuteScalar
                                    con.Close()
                                Catch ex As Exception

                                    Same_Book_Is_Issued = 0
                                Finally
                                    con.Close()
                                End Try

                                If Same_Book_Is_Issued <> 0 Then

                                    MsgBox("You Have Already Issued The Same Book", MessageBoxIcon.Stop, Title:="Book Request")

                                Else

                                    'CODE FOR STUDENT PREVIOUS BOOK REQUEST DETAILS
                                    Try
                                        con.Open()
                                        str = "select count(*) from  book_request_db where roll_no= '" & tb_2.Text & "' and status IN(0,1) AND ISBN_no='" & DataGridView1.CurrentRow.Cells("isbn_no").Value & "' "
                                        com = New MySqlCommand(str, con)
                                        Same_Book_Is_Requested = com.ExecuteScalar
                                        con.Close()
                                    Catch ex As Exception
                                        Same_Book_Is_Requested = 0
                                    Finally
                                        con.Close()
                                    End Try

                                    If Same_Book_Is_Requested <> 0 Then

                                        MsgBox("You Have Already Requested For The Book", MessageBoxIcon.Warning, Title:="Book Request")

                                    Else

                                        'write insert command for book request table
                                        Try
                                            dtt = Now.ToString("yyyy-MM-dd")

                                            con.Open()
                                            str = "insert into book_request_db(request_date,roll_no,book_name,isbn_no,author_name,publication_name,edition,status)values('" & dtt & "','" & tb_2.Text & "','" & DataGridView1.CurrentRow.Cells("BOOK").Value & "','" & DataGridView1.CurrentRow.Cells("isbn_no").Value & "','" & DataGridView1.CurrentRow.Cells("AUTHOR").Value & "','" & DataGridView1.CurrentRow.Cells("PUBLICATION").Value & "','" & DataGridView1.CurrentRow.Cells("EDITION").Value & "',1)"
                                            com = New MySqlCommand(str, con)
                                            com.ExecuteNonQuery()
                                            MsgBox("Book Request Submited For the Roll No: " + tb_2.Text, MessageBoxIcon.Asterisk, Title:="Book Request")
                                            con.Close()
                                        Catch ex As Exception
                                            MsgBox(ex.Message)
                                        Finally
                                            con.Close()
                                        End Try

                                    End If

                                End If

                            End If

                        End If

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub tb_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_2.KeyPress
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
        If tb_2.Text.Length >= 8 Then
            If Asc(e.KeyChar) <> 8 Then


                e.Handled = True

            End If
        End If
    End Sub

    Private Sub tb_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_1.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 45 Then

                e.Handled = True

            End If
        End If
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub
End Class