Imports MySql.Data.MySqlClient

Public Class Faculty_Book_Issue
    Dim Book_Not_Available As Integer
    Dim check As Integer
    Private Sub book_details()
        Try
            con.Open()
            str = "SELECT ISBN_no,book_name,Author_name,edition FROM Book_Entry_db WHERE book_no= '" & tb_1.Text & "' "
            com = New MySqlCommand(str, con)
            reader = com.ExecuteReader
            If reader.Read Then
                tb_2.Text = reader.GetString("book_name")
                tb_3.Text = reader.GetString("author_name")
                tb_4.Text = reader.GetString("isbn_no")
                tb_5.Text = reader.GetString("edition")
                check = 1
            Else
                tb_2.Text = ""
                tb_3.Text = ""
                tb_4.Text = ""
                tb_5.Text = ""



                check = 0

            End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        If check = 1 Then


            Try
                con.Open()
                str = "select status FROM Book_Entry_db WHERE book_no= '" & tb_1.Text & "'   "
                com = New MySqlCommand(str, con)
                reader = com.ExecuteReader
                If reader.Read Then
                    Book_Not_Available = reader.GetString("status")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

            End Try
        End If
    End Sub
    Private Sub tb_1_OnValueChanged(sender As Object, e As EventArgs) Handles tb_1.OnValueChanged

        book_details()
    End Sub
    Private Sub faculty_details()

        Try
            con.Open()
            str = "SELECT faculty_name FROM faculty_registation_db WHERE faculty_id= '" & tb_8.Text & "' "
            com = New MySqlCommand(str, con)

            reader = com.ExecuteReader

            If reader.Read Then
                tb_9.Text = reader.GetString("faculty_name")
            Else
                tb_9.Text = ""
            End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        If tb_9.Text <> "" Then


            Try
                con.Open()
                str = "SELECT  sum(status) FROM faculty_book_issue_db WHERE faculty_id= '" & tb_8.Text & "' "
                com = New MySqlCommand(str, con)
                reader = com.ExecuteReader
                If reader.Read Then

                    tb_10.Text = reader.GetString("sum(status)")
                Else

                    tb_10.Text = ""
                End If

                reader.Close()
                con.Close()
            Catch ex As Exception
                tb_10.Text = ""
            Finally
                con.Close()
            End Try

        End If



    End Sub
    Private Sub tb_8_OnValueChanged(sender As Object, e As EventArgs) Handles tb_8.OnValueChanged


        faculty_details()
    End Sub

    Private Sub book_issue()

        If Book_Not_Available = 0 Then
            MsgBox("Book is Not Available in the Stock ", MessageBoxIcon.Exclamation, Title:="Book Issue")
        Else


            'WRITTING ALL CONTENT  TO BOOK ISSUE TABLE
            Try
                dtt = dt_1.Value.ToString("yyyy-MM-dd")

                con.Open()
                str = "insert into faculty_book_issue_db(issue_date,book_no,book_name,author_name,isbn_no,edition,faculty_id,faculty_name,status)values('" & dtt & "','" & tb_1.Text & "','" & tb_2.Text & "','" & tb_3.Text & "','" & tb_4.Text & "','" & tb_5.Text & "','" & tb_8.Text & "','" & tb_9.Text & "',1)"
                com = New MySqlCommand(str, con)
                com.ExecuteNonQuery()

                MsgBox("Book Issued For the Faculty ID: " + tb_8.Text, MessageBoxIcon.Information, Title:="Book Issue")

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
            book_details()
            faculty_details()
        End If
    End Sub

    Private Sub bt_Confirm_Click(sender As Object, e As EventArgs) Handles bt_Confirm.Click
        book_issue()

    End Sub



    Private Sub bt_Reset_Click(sender As Object, e As EventArgs) Handles bt_Reset.Click
        tb_1.Text = ""
        tb_2.Text = ""
        tb_3.Text = ""
        tb_4.Text = ""
        tb_5.Text = ""

        tb_8.Text = ""
        tb_9.Text = ""
        tb_10.Text = ""

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

    Private Sub tb_8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_8.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then

                e.Handled = True

            End If
        End If
    End Sub
End Class