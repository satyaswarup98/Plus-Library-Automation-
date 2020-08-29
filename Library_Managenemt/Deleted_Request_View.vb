Imports MySql.Data.MySqlClient

Public Class Deleted_Request_View
    Dim request_id As Integer
    Dim roll_no As String

    Public Sub View_Deleted_Requests(ByVal roll_no As String)
        Try
            con.Open()
            If roll_no = "" Then
                str = "SELECT request_date 'DATE',roll_no 'ROLL NO',book_name 'BOOK', author_name 'AUTHOR', EDITION, publication_name 'PUBLICATION' ,  request_id, isbn_no FROM book_request_db WHERE  status= 2 "
            Else
                str = "SELECT request_date 'DATE',roll_no 'ROLL NO',book_name 'BOOK', author_name 'AUTHOR', EDITION, publication_name 'PUBLICATION' ,  request_id FROM book_request_db WHERE  status= 2 AND roll_no LIKE '" & roll_no + "%" & "'  "

            End If
            com = New MySqlCommand(str, con)
            sqlda_DRV = New MySqlDataAdapter(com)

            ds_DRV.Clear()

            sqlda_DRV.Fill(ds_DRV, "category_db")
            con.Close()

            DataGridView1.DataSource = ds_DRV
            DataGridView1.DataMember = "category_db"

            '--HIDING ISBN COLUMN--
            DataGridView1.Columns("request_id").Visible = False
            DataGridView1.Columns("isbn_no").Visible = False


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub Deleted_Request_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Student_Name_Auto_Complete()
        View_Deleted_Requests("")

    End Sub

    Private Sub tb_1_OnValueChanged(sender As Object, e As EventArgs) Handles tb_1.OnValueChanged

        Try
                con.Open()
                str = "SELECT roll_no,s_name FROM student_registation_db WHERE roll_no= '" & tb_1.Text & "' "
                com = New MySqlCommand(str, con)
                reader = com.ExecuteReader
                If reader.Read Then
                    tb_2.Text = reader.GetString("s_name")

                End If

                reader.Close()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try

            View_Deleted_Requests(tb_1.Text)

        If tb_1.Text.Length < 8 Then
            tb_2.Text = ""

        End If
    End Sub

    Dim Book_Issue_Count, Book_Request_Count, Available_Books_Count, Requests_For_A_Book, Same_Book_Is_Issued, Same_Book_Is_Requested As Integer



    Private Sub bt_Undo_Click(sender As Object, e As EventArgs) Handles bt_Undo.Click

        request_id = DataGridView1.CurrentRow.Cells("request_id").Value
        roll_no = DataGridView1.CurrentRow.Cells("ROLL NO").Value


        'CODE FOR STUDENT PREVIOUS BOOK ISSUE DETAILS
        Try
            con.Open()
            str = "select count(*) from student_book_issue_db where roll_no= '" & roll_no & "' and status=1 "
            com = New MySqlCommand(str, con)
            Book_Issue_Count = com.ExecuteScalar
            con.Close()
        Catch ex As Exception
            Book_Issue_Count = 0
        Finally
            con.Close()
        End Try


        If Book_Issue_Count >= 3 Then

            MsgBox("You Have Already Issued Three Books", MessageBoxIcon.Warning, Title:="Undo Request")

        Else

            'CODE FOR STUDENT PREVIOUS BOOK REQUEST DETAILS
            Try
                con.Open()
                str = "select count(*) from  book_request_db where roll_no= '" & roll_no & "' and status IN(0,1) "
                com = New MySqlCommand(str, con)
                Book_Request_Count = com.ExecuteScalar
                con.Close()
            Catch ex As Exception
                Book_Request_Count = 0
            Finally
                con.Close()
            End Try

            If Book_Request_Count >= 2 Then

                MsgBox("You Have Already Requested For Two Books", MessageBoxIcon.Warning, Title:="Undo Request")

            Else

                ' CODE TO CHECK NO OF AVALABLE BOOKS OF SAME ISBN
                Try
                    con.Open()
                    str = "SELECT sum(status) FROM book_entry_db WHERE isbn_no='" & DataGridView1.CurrentRow.Cells("isbn_no").Value & "'"
                    com = New MySqlCommand(str, con)
                    Available_Books_Count = com.ExecuteScalar
                    con.Close()
                Catch ex As Exception
                    Available_Books_Count = 0
                Finally
                    con.Close()
                End Try

                If Available_Books_Count < 1 Then

                    MsgBox("Book Is Not Available In The Stock", MessageBoxIcon.Information, Title:="Undo Request")

                Else

                    ' CODE FOR COUNT NO OF BOOK REQUESTED FOR SAME ISBN NO
                    Try
                        con.Open()
                        str = "select count(*) from  book_request_db where isbn_no='" & DataGridView1.CurrentRow.Cells("isbn_no").Value & "' AND status = 1"
                        com = New MySqlCommand(str, con)
                        Requests_For_A_Book = com.ExecuteScalar
                        con.Close()
                    Catch ex As Exception
                        Requests_For_A_Book = 0
                    Finally
                        con.Close()
                    End Try

                    If Requests_For_A_Book >= Available_Books_Count Then

                        MsgBox("All Available Books Are Already Requested", MessageBoxIcon.Information, Title:="Undo Request")

                    Else


                        'CODE TO CHECK IF STUDENT HAVE ISSUES THE SAME BOOK WHICH IS REQUESTED
                        Try
                            con.Open()

                            str = " SELECT COUNT(*) FROM student_book_issue_db WHERE roll_no= '" & roll_no & "' and ISBN_no= '" & DataGridView1.CurrentRow.Cells("isbn_no").Value & "' and status=1 GROUP BY roll_no"
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
                                str = "select count(*) from  book_request_db where roll_no= '" & roll_no & "' and status IN(0,1) AND ISBN_no='" & DataGridView1.CurrentRow.Cells("isbn_no").Value & "' "
                                com = New MySqlCommand(str, con)
                                Same_Book_Is_Requested = com.ExecuteScalar
                                con.Close()
                            Catch ex As Exception
                                Same_Book_Is_Requested = 0
                            Finally
                                con.Close()
                            End Try

                            If Same_Book_Is_Requested <> 0 Then

                                MsgBox("You Have Already Requested For The Book", MessageBoxIcon.Warning, Title:="Undo Request")

                            Else

                                'CODE FOR UNDO command to book request table

                                Dim Delete_Request As Integer = MessageBox.Show("Conform to Undo Deleted Request Of Roll No : " + roll_no, "Undo Request", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                                If Delete_Request = DialogResult.Yes Then
                                    Try
                                        con.Open()
                                        str = "UPDATE book_request_db SET status=1 WHERE request_id='" & request_id & "' "
                                        com = New MySqlCommand(str, con)
                                        com.ExecuteNonQuery()
                                        con.Close()

                                    Catch ex As Exception
                                        MsgBox(ex.Message)
                                    Finally
                                        con.Close()
                                    End Try
                                    View_Deleted_Requests(tb_1.Text)
                                Else

                                End If

                            End If

                        End If

                    End If

                End If

            End If

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

    Private Sub tb_2_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 45 Then

                e.Handled = True

            End If
        End If
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub



    Private Function create_space(ByVal l As Integer)


        Dim space_count As String = ""
        For i = 30 - l To 1 Step -1
            space_count = space_count & "  "
        Next

        Return space_count
    End Function

    Sub Student_Name_Auto_Complete()


        Try
            con.Open()
            Using com = New MySqlCommand("SELECT s_name, roll_no FROM student_registation_db  ", con)

                Using reader = com.ExecuteReader
                    While reader.Read

                        With tb_2

                            .AutoCompleteMode = AutoCompleteMode.Suggest
                            .AutoCompleteCustomSource.Add(reader.Item(0) & create_space(reader.Item(0).ToString.Length) & "[ " & reader.Item(1) & " ]")
                            .AutoCompleteSource = AutoCompleteSource.CustomSource

                        End With

                    End While

                    reader.Close()
                End Using
            End Using



            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub tb_2_TextChanged(sender As Object, e As EventArgs) Handles tb_2.TextChanged
        Try
            If tb_2.Text.Contains("[") Then

                tb_1.Text = tb_2.Text.Substring(tb_2.Text.IndexOf("[") + 2, 8)
            End If

        Catch ex As Exception

        End Try
    End Sub

End Class