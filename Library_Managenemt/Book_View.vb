Imports MySql.Data.MySqlClient

Public Class Book_View
    Private Sub clear_data()

        lb_4.Text = ":" + ""
        lb_6.Text = ":" + ""
        lb_8.Text = ":" + ""
        lb_10.Text = ":" + ""
        lb_14.Text = ":" + ""
        lb_16.Text = ":" + ""
        lb_18.Text = ":" + ""
        lb_12.Text = ":" + ""
        'tb_2.Text = ""
        DataGridView1.DataMember = Nothing
        lb_50.Visible = False

    End Sub

    Private Sub database_retrieval()

        Try
            con.Open()
            str = "SELECT issue_date 'ISSUE DATE', roll_no 'ROLL NO',s_name 'NAME', return_date 'RETURN DATE'  FROM student_book_issue_db WHERE book_no= '" & tb_1.Text & "' "

            com = New MySqlCommand(str, con)
            sqlda_BV = New MySqlDataAdapter(com)

            ds_BV.Clear()

            sqlda_BV.Fill(ds_BV, "category_db")
            con.Close()

            DataGridView1.DataSource = ds_BV
            DataGridView1.DataMember = "category_db"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Dim data_retrived As Integer

    Private Sub tb_1_OnValueChanged(sender As Object, e As EventArgs) Handles tb_1.OnValueChanged
        lb_50.Visible = False
        Try
            con.Open()
            str = "SELECT ISBN_no, purchase_date,book_name, Author_name,price,publication_name,edition, catagory, status FROM Book_Entry_db WHERE book_no= '" & tb_1.Text & "' "
            com = New MySqlCommand(str, con)
            reader = com.ExecuteReader
            If reader.Read Then
                tb_2.Text = reader.GetString("book_name")
                lb_4.Text = ":   " + reader.GetString("ISBN_no")
                lb_6.Text = ":   " + reader.GetString("purchase_date").Substring(0, 10)
                lb_8.Text = ":   " + reader.GetString("author_name")
                lb_10.Text = ":   " + reader.GetString("price")
                lb_12.Text = ":   " + reader.GetString("publication_name")
                lb_14.Text = ":   " + reader.GetString("edition")
                lb_16.Text = ":   " + reader.GetString("catagory")
                lb_18.Text = ":   " + reader.GetString("status")
                data_retrived = 1
            Else
                data_retrived = 0
                clear_data()

            End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        If data_retrived = 1 Then
            database_retrieval()

        End If



    End Sub

    Sub Book_Name_Auto_Complete()
        Try
            con.Open()
            Using com = New MySqlCommand("SELECT Distinct(book_name) FROM book_entry_db  ", con)

                Using reader = com.ExecuteReader
                    While reader.Read
                        With tb_2
                            .AutoCompleteMode = AutoCompleteMode.Suggest
                            .AutoCompleteCustomSource.Add(reader.Item(0))
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

    Private Sub Book_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Book_Name_Auto_Complete()
    End Sub



    Private Sub tb_2_TextChanged(sender As Object, e As EventArgs) Handles tb_2.TextChanged

        If tb_2.Text <> "" And tb_1.Text = "" Then


            Try
            con.Open()
            str = "SELECT ISBN_no, purchase_date,book_name, Author_name,price,publication_name,edition, catagory, status FROM Book_Entry_db WHERE book_name= '" & tb_2.Text & "' "
            com = New MySqlCommand(str, con)
            reader = com.ExecuteReader
            If reader.Read Then

                lb_4.Text = ":   " + reader.GetString("ISBN_no")
                lb_6.Text = ":   " + reader.GetString("purchase_date").Substring(0, 10)
                lb_8.Text = ":   " + reader.GetString("author_name")
                lb_10.Text = ":   " + reader.GetString("price")
                lb_12.Text = ":   " + reader.GetString("publication_name")
                lb_14.Text = ":   " + reader.GetString("edition")
                lb_16.Text = ":   " + reader.GetString("catagory")
                    lb_18.Text = ":   " + reader.GetString("status")
                    lb_50.Visible = True
                Else
                clear_data()
                    lb_50.Visible = False
                End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try



        Else
            DataGridView1.DataMember = Nothing
            clear_data()
        End If

    End Sub

    Private Sub tb_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_2.KeyPress
        tb_1.Text = ""
        DataGridView1.DataMember = Nothing

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


End Class
