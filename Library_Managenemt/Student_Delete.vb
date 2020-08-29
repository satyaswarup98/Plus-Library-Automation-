Imports MySql.Data.MySqlClient
Public Class Student_Delete
    Private Sub clear_data()

        lb_4.Text = ":" + ""
        lb_6.Text = ":" + ""
        lb_8.Text = ":" + ""
        lb_10.Text = ":" + ""
        lb_14.Text = ":" + ""
        lb_16.Text = ":" + ""
        lb_18.Text = ":" + ""
        lb_12.Text = ":" + ""
        tb_2.Text = ""
        tb_3.Text = ""


    End Sub



    Private Sub tb_1_OnValueChanged(sender As Object, e As EventArgs) Handles tb_1.OnValueChanged
        If tb_1.Text.Length = 8 Then
            Try
                con.Open()
                str = "SELECT roll_no,dob,s_name, f_name, blood_group, session, email, mobile FROM student_registation_db WHERE roll_no= '" & tb_1.Text & "' "
                com = New MySqlCommand(str, con)
                reader = com.ExecuteReader
                If reader.Read Then
                    tb_2.Text = reader.GetString("s_name")
                    lb_4.Text = ":   " + reader.GetString("s_name")
                    lb_12.Text = ":   " + reader.GetString("roll_no")
                    lb_8.Text = ":   " + reader.GetString("f_name")
                    lb_16.Text = ":   " + reader.GetString("email")
                    lb_18.Text = ":   " + reader.GetString("mobile")
                    lb_6.Text = ":   " + reader.GetString("dob").Substring(0, 10)
                    lb_14.Text = ":   " + reader.GetString("blood_group")
                    lb_10.Text = ":   " + reader.GetString("session")


                End If

                reader.Close()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try


        Else
            clear_data()

        End If
    End Sub

    Private Sub bt_Save_Click(sender As Object, e As EventArgs) Handles bt_Save.Click
        If tb_1.Text = "" Then

            MsgBox("Enter Roll No", MessageBoxIcon.Exclamation, Title:="Student Delete")

        ElseIf lb_4.Text.Equals(":") Then

            MsgBox("Enter A valid Roll No", MessageBoxIcon.Exclamation, Title:="Student Delete")

        ElseIf tb_3.Text = "" Then

            MsgBox("Provide a Reason", MessageBoxIcon.Exclamation, Title:="Student Delete")

        ElseIf tb_3.Text.Length < 5 Then

            MsgBox("Provide a Valid description of  Reason", MessageBoxIcon.Exclamation, Title:="Student Delete")

        Else


            '----------------REDING BOOK ISSUE DETAILS-----------------

            Dim a As Integer
            Try
                con.Open()
                str = "SELECT  sum(status), sum(fine) FROM student_book_issue_db WHERE roll_no='" & tb_1.Text & "' GROUP BY roll_no "
                com = New MySqlCommand(str, con)
                reader = com.ExecuteReader

                If reader.Read Then
                    If Val(reader("sum(status)")) <> 0 Then
                        a = MessageBox.Show(reader("sum(status)") & " BOOK ARE NOT RETUEND" & "TOTAL FINE : RS:" & reader("sum(fine)") & vbCr & "Do You Want To Conform Delete", "Student Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    End If

                Else
                    a = MessageBox.Show("Do You Want To Conform Delete", "Student Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try



            If a = DialogResult.Yes Then

                '------------ WRITING REASON FOR DELETE IN DATABASE---------------
                Try
                    con.Open()
                    str = " UPDATE  student_registation_db SET notes='" & tb_3.Text & "' where roll_no='" & tb_1.Text & "'"


                    com = New MySqlCommand(str, con)
                    com.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()

                End Try

                '------------ MOVING DATA FROM REGISTATION TABLE TO DELETE TABLE DATABASE---------------
                Try
                    con.Open()
                    str = "   INSERT deleted_student_db SELECT * FROM student_registation_db WHERE  roll_no='" & tb_1.Text & "'"
                    com = New MySqlCommand(str, con)
                    com.ExecuteScalar()

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()

                End Try


                '------------ DELETING  STUDENT DETAILS FROM DATABASE---------------
                Try
                    con.Open()
                    str = " DELETE FROM  student_registation_db  where roll_no='" & tb_1.Text & "'"
                    com = New MySqlCommand(str, con)
                    com.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()

                End Try

                '-------------------DELETING STUDENT EXISTING BOOK REQUEST----------------------
                Try
                    con.Open()
                    str = " DELETE FROM  book_request_db  where roll_no='" & tb_1.Text & "'"
                    com = New MySqlCommand(str, con)
                    com.ExecuteNonQuery()

                Catch ex As Exception
                    'MsgBox(ex.Message)
                Finally
                    con.Close()

                End Try


                MsgBox("Record Deleted", MsgBoxStyle.Exclamation)

                clear_data()
                tb_1.Text = ""

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

    Private Sub bt_Reset_Click(sender As Object, e As EventArgs) Handles bt_Reset.Click
        clear_data()
    End Sub



    Private Function create_space(ByVal l As Integer)


        Dim space_count As String = ""
        For i = 50 - l To 1 Step -1
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

    Private Sub Student_Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Student_Name_Auto_Complete()
    End Sub
End Class

