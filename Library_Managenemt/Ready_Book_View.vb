Imports MySql.Data.MySqlClient

Public Class Ready_Book_View


    Private Sub View_Ready_Requests(ByVal roll_no As String)
        Try
            con.Open()
            If roll_no = "" Then
                str = "SELECT request_date 'REQ. DATE',roll_no 'ROLL NO',book_name 'NAME', author_name 'AUTOHR', EDITION, publication_name 'PUBLICATION', ISBN_no FROM book_request_db WHERE  status= 0 "
            Else
                str = "SELECT request_date 'REQ. DATE',roll_no 'ROLL NO',book_name 'NAME', author_name 'AUTOHR', EDITION, publication_name 'PUBLICATION', ISBN_no FROM book_request_db WHERE  status= 0 AND roll_no LIKE '" & roll_no + "%" & "' "

            End If
            com = New MySqlCommand(str, con)
            sqlda_Ready_Book = New MySqlDataAdapter(com)

            ds_Ready_Book.Clear()

            sqlda_Ready_Book.Fill(ds_Ready_Book, "category_db")
            con.Close()

            DataGridView1.DataSource = ds_Ready_Book
            DataGridView1.DataMember = "category_db"

            '--HIDING ISBN COLUMN--
            DataGridView1.Columns("isbn_no").Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Ready_Book_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Student_Name_Auto_Complete()
        View_Ready_Requests("")
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

            View_Ready_Requests(tb_1.Text)

        If tb_1.Text.Length < 8 Then


            tb_2.Text = ""


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


    Private Sub bt_Issue_Click(sender As Object, e As EventArgs) Handles bt_Issue.Click
        Isbn_Read = DataGridView1.CurrentRow.Cells("isbn_no").Value
        Roll_No_Read = DataGridView1.CurrentRow.Cells("ROLL NO").Value

        Transfered_From_Ready_Book_Status = 1

        Parent_Window.StudentToolStripMenuItem3_Click(sender, e)
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