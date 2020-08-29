Imports MySql.Data.MySqlClient

Public Class Faculty_view
    Private Sub clear_data()
        lb_4.Text = ":" + ""
        lb_6.Text = ":" + ""
        lb_8.Text = ":" + ""
        lb_10.Text = ":" + ""
        lb_14.Text = ":" + ""
        lb_16.Text = ":" + ""
        lb_18.Text = ":" + ""

        tb_2.Text = ""
        DataGridView1.DataMember = Nothing

    End Sub

    Private Sub database_ritrival()

        Try
            con.Open()
            str = "SELECT issue_date 'ISSUE Dt',book_no 'BOOK NO',book_name 'BOOK NAME', AUTHOR_NAME 'AUTHOR', return_date 'RETURN Dt' FROM Faculty_book_issue_db WHERE  faculty_id='" & tb_1.Text & "' "
            com = New MySqlCommand(str, con)
            sqlda_SV = New MySqlDataAdapter(com)

            ds_SV.Clear()

            sqlda_SV.Fill(ds_SV, "category_db")
            con.Close()

            DataGridView1.DataSource = ds_SV
            DataGridView1.DataMember = "category_db"





        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub tb_1_OnValueChanged(sender As Object, e As EventArgs) Handles tb_1.OnValueChanged
        Dim show_table As Integer = 0
        Try
            con.Open()
            str = "SELECT faculty_name,dob,address, designation, blood_group, email, mobile FROM faculty_registation_db WHERE faculty_id= '" & tb_1.Text & "' "
            com = New MySqlCommand(str, con)
            reader = com.ExecuteReader
            If reader.Read Then
                tb_2.Text = reader.GetString("faculty_name")
                lb_4.Text = ":   " + reader.GetString("faculty_name")
                lb_6.Text = ":   " + reader.GetString("dob").Substring(0, 10)
                lb_8.Text = ":   " + reader.GetString("address")
                lb_10.Text = ":   " + reader.GetString("designation")
                lb_14.Text = ":   " + reader.GetString("blood_group")
                lb_16.Text = ":   " + reader.GetString("email")
                lb_18.Text = ":   " + reader.GetString("mobile")
                show_table = 1
            Else
                clear_data()
            End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        If show_table = 1 Then
            database_ritrival()

        End If




    End Sub

    Private Sub tb_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_1.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
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
        For i = 50 - l To 1 Step -1
            space_count = space_count & "  "
        Next

        Return space_count
    End Function

    Sub faculty_Name_Auto_Complete()


        Try
            con.Open()
            Using com = New MySqlCommand("SELECT faculty_name, faculty_id FROM faculty_registation_db  ", con)

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

                tb_1.Text = tb_2.Text.Substring(tb_2.Text.IndexOf("[") + 2, tb_2.Text.IndexOf("]") - (tb_2.Text.IndexOf("[") + 3))
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Faculty_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        faculty_Name_Auto_Complete()
    End Sub
End Class