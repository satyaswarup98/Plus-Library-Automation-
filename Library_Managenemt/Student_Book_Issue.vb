Imports MySql.Data.MySqlClient

Public Class Student_Book_Issue

    Dim Transferd_ISBN, Own_ISBN, Request_ID_Isbn_Read As String

    Private Sub Student_Book_Issue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Transfered_From_Ready_Book_Status = 1 Then
            tb_8.Text = Roll_No_Read
            Transfered_From_Ready_Book_Status = 0
        End If

    End Sub


    Private Sub fill_data()
        If tb_9.Text <> "" Then


            Try

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()

                If dd_1.Text = Nothing Then
                    Request_ID_Isbn_Read = 0
                End If

                str = "select  isbn_no from book_request_db where request_id='" & dd_1.Text & "' "
                com = New MySqlCommand(str, con)
                reader = com.ExecuteReader

                If reader.Read Then
                    Request_ID_Isbn_Read = reader.GetString("isbn_no")
                End If

                reader.Close()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try


            Try
                con.Open()
                str = "select book_name, author_name, ISBN_no, edition, count(*), sum(status) from book_entry_db where isbn_no='" & Request_ID_Isbn_Read & "' group by isbn_no "
                com = New MySqlCommand(str, con)
                reader = com.ExecuteReader

                If reader.Read Then
                    tb_2.Text = reader.GetString("book_name")
                    tb_3.Text = reader.GetString("author_name")
                    tb_4.Text = reader.GetString("ISBN_no")

                    Transferd_ISBN = reader.GetString("ISBN_no")

                    tb_5.Text = reader.GetString("edition")
                    tb_6.Text = reader.GetString("count(*)")
                    tb_7.Text = reader.GetString("sum(status)")
                    dt_1.Value = Today
                End If

                reader.Close()
                con.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try

        End If
    End Sub


    Private Sub dd_1_SelectedValueChanged(sender As Object, e As EventArgs) Handles dd_1.SelectedValueChanged

        fill_data()

    End Sub

    Private Sub Retrive_Data(ByVal roll_no As String)

        Try
            con.Open()
            str = "SELECT s_name FROM student_registation_db WHERE roll_no= '" & roll_no & "' "
            com = New MySqlCommand(str, con)
            reader = com.ExecuteReader

            If reader.Read Then
                tb_9.Text = reader.GetString("s_name")

            End If

            reader.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        If tb_9.Text <> "" Then

            'READING TOTAL BOOK ISSUED
            Try
                con.Open()
                str = "select  sum(status) from student_book_issue_db where roll_no='" & roll_no & "' group by roll_no "
                com = New MySqlCommand(str, con)
                reader = com.ExecuteReader

                If reader.Read Then
                    tb_10.Text = reader.GetString("sum(status)")
                End If

                reader.Close()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try

            ' BINDING REQIEST ID IN DROPDOWN

            Try
                con.Open()
                str = "select request_id from book_request_db where roll_no='" & roll_no & "' AND status=0 "
                com = New MySqlCommand(str, con)

                sqlda_SBI = New MySqlDataAdapter(com)
                ds_SBI.Clear()
                sqlda_SBI.Fill(ds_SBI, "book_request_db")
                con.Close()

                dd_1.DataSource = ds_SBI.Tables("book_request_db")
                dd_1.DisplayMember = "request_id"

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try

        End If

    End Sub


    Private Sub Clear_Data()

        tb_1.Text = ""
        tb_2.Text = ""
        tb_3.Text = ""
        tb_4.Text = ""
        tb_5.Text = ""
        tb_6.Text = ""
        tb_7.Text = ""
        'tb_8.Text = ""
        tb_9.Text = ""
        tb_10.Text = ""
        dt_1.Value = Today
        dd_1.Text = ""

    End Sub

    Private Sub bt_Reset_Click(sender As Object, e As EventArgs) Handles bt_Reset.Click
        tb_8.Text = ""
        Clear_Data()
    End Sub

    Private Sub Issue_Book()

        'WRITTING ALL CONTENT  TO BOOK ISSUE TABLE
        Try
            dtt = dt_1.Value.ToString("yyyy-MM-dd")

            con.Open()
            str = "insert into student_book_issue_db(issue_date,book_no,book_name,author_name,isbn_no,edition,roll_no,s_name,status)values('" & dtt & "','" & tb_1.Text & "','" & tb_2.Text & "','" & tb_3.Text & "','" & tb_4.Text & "','" & tb_5.Text & "','" & tb_8.Text & "','" & tb_9.Text & "',1)"
            com = New MySqlCommand(str, con)
            com.ExecuteNonQuery()

            MsgBox("Book Issued For the Roll No: " + tb_8.Text, MessageBoxIcon.Information, Title:="Book Issue")

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        'UPDATING BOOK STATUS TO UNAVALABLE IN BOOK ENTRY TABLE

        Try
            con.Open()
            str = "UPDATE book_entry_db SET status=0 WHERE book_no='" & tb_1.Text & "' "
            com = New MySqlCommand(str, con)
            com.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        'DELETING THE BOOK REQUEST

        Try
            con.Open()
            str = "DELETE FROM book_request_db WHERE roll_no='" & tb_8.Text & "' and isbn_no='" & tb_4.Text & "' "
            com = New MySqlCommand(str, con)
            com.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try



    End Sub


    Dim Own_Status As Integer

    Private Sub bt_Issue_Click(sender As Object, e As EventArgs) Handles bt_Issue.Click


        If tb_8.Text = "" Then
            MsgBox("Enter Roll No. to Proceed", MessageBoxIcon.Exclamation, Title:="Book Issue")

        ElseIf tb_9.Text = "" Then
            MsgBox("Enter a Valid Roll No", MessageBoxIcon.Exclamation, Title:="Book Issue")
        ElseIf tb_2.Text = "" Then
            MsgBox("Entered Roll No is Not Requested For Any Book", MessageBoxIcon.Exclamation, Title:="Book Issue")
        Else

            If tb_1.Text = "" Then


                MsgBox("Enter Book No. to Proceed", MessageBoxIcon.Exclamation, Title:="Book Issue")
            Else


                Try
                    con.Open()
                    str = "select isbn_no,status from  book_entry_db where book_no='" & tb_1.Text & "'  "
                    com = New MySqlCommand(str, con)

                    reader = com.ExecuteReader

                    If reader.Read Then
                        Own_ISBN = reader.GetString("isbn_no")
                        Own_Status = reader.GetString("status")

                    End If

                    reader.Close()
                    con.Close()
                Catch ex As Exception
                    Own_ISBN = 0
                Finally
                    con.Close()
                End Try

                If Transferd_ISBN.Equals(Own_ISBN) And Own_Status = 1 Then
                    Dim Delete_Request As Integer = MessageBox.Show("Conform Book Issue To Roll No : " + tb_8.Text, "Undo Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If Delete_Request = DialogResult.Yes Then
                        Issue_Book()
                        Retrive_Data(tb_8.Text)
                        fill_data()
                        If dd_1.Text = Nothing Then
                            Clear_Data()
                        End If
                    End If

                ElseIf Transferd_ISBN <> Own_ISBN Then

                    MsgBox("Enterd Book No Is Not Mathched with ISBN", MessageBoxIcon.Warning, Title:="Book Issue")

                ElseIf Own_Status = 0 Then

                    MsgBox(" Book No Is Not Available in the Stock", MessageBoxIcon.Warning, Title:="Book Issue")

                End If
            End If
        End If
    End Sub


    Private Sub tb_9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_9.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 45 Then

                e.Handled = True

            End If
        End If
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub dt_1_onValueChanged(sender As Object, e As EventArgs) Handles dt_1.onValueChanged
        If dt_1.Value.Date > Now.Date Then
            dt_1.Value = Today
            MsgBox("Incorect Date", MessageBoxIcon.Exclamation, Title:="Book Entry")
        End If
    End Sub

    Private Sub tb_3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_3.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 45 Then

                e.Handled = True

            End If
        End If
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub tb_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_2.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 45 Then

                e.Handled = True

            End If
        End If
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub tb_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_1.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 45 Then

                    e.Handled = True

                End If
            End If
        End If
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub





    Private Sub tb_8_OnValueChanged(sender As Object, e As EventArgs) Handles tb_8.OnValueChanged
        If Transfered_From_Ready_Book_Status <> 1 Then

            If tb_8.Text.Length = 8 Then

                Retrive_Data(tb_8.Text)
                fill_data()

            Else
                Clear_Data()
                dd_1.DataSource = Nothing
                dd_1.SelectedIndex = -1
            End If
        Else
            Retrive_Data(Roll_No_Read)
        End If
    End Sub

    Private Sub tb_10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_10.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then


                e.Handled = True

            End If
        End If
        If tb_5.Text.Length >= 1 Then
            If Asc(e.KeyChar) <> 8 Then


                e.Handled = True

            End If
        End If
    End Sub

    Private Sub tb_8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_8.KeyPress
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
        If tb_8.Text.Length >= 8 Then
            If Asc(e.KeyChar) <> 8 Then


                e.Handled = True

            End If
        End If
    End Sub
End Class