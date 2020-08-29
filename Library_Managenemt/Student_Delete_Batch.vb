Imports MySql.Data.MySqlClient

Public Class Student_Delete_Batch

    Private Sub Year_Display()

        For j = Now.Year - 3 To Now.Year - 10 Step -1
            dd_2.Items.Add(j & "-" & j + 2)
        Next

    End Sub
    Private Sub Student_Delete_Bathch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Year_Display()
    End Sub

    Private Sub bt_Cancel_Click(sender As Object, e As EventArgs) Handles bt_Cancel.Click
        dd_2.SelectedIndex = -1
    End Sub

    Private Sub bt_Delete_Click(sender As Object, e As EventArgs) Handles bt_Delete.Click

        If dd_2.Text = "" Then

            MsgBox("Choose a Seaaion to Delete", MessageBoxIcon.Exclamation, Title:="Student Delete")
        Else


            '----------------REDING BOOK ISSUE DETAILS-----------------

            Dim a As Integer
            Try
                con.Open()
                str = "SELECT  sum(status), sum(fine) FROM student_book_issue_db WHERE roll_no IN(SELECT  roll_no FROM student_registation_db WHERE session='" & dd_2.Text & "') GROUP BY roll_no "
                com = New MySqlCommand(str, con)
                reader = com.ExecuteReader

                If reader.Read Then
                    If Val(reader("sum(status)")) <> 0 Then
                        a = MessageBox.Show(reader("sum(status)") & " BOOKS ARE NOT RETUEND" & vbCr & "TOTAL FINE AMOUNT OF THIS BATCH IS : RS:" & reader("sum(fine)") & vbCr & "Do You Want To Conform Batch Delete", "Student Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    End If

                Else
                    a = MessageBox.Show("Do You Want To Conform Batch Delete", "Student Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try


            If a = DialogResult.Yes Then


                '------------ MOVING DATA FROM REGISTATION TABLE TO DELETE TABLE DATABASE---------------
                Try
                    con.Open()
                    str = "   INSERT deleted_student_db SELECT * FROM student_registation_db WHERE  session='" & dd_2.Text & "'"
                    com = New MySqlCommand(str, con)
                    com.ExecuteScalar()

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()

                End Try

                '-------------------DELETING STUDENT EXISTING BOOK REQUEST----------------------
                Try
                    con.Open()
                    str = " DELETE FROM  book_request_db  where roll_no IN(SELECT  roll_no FROM student_registation_db WHERE session='" & dd_2.Text & "')"
                    com = New MySqlCommand(str, con)
                    com.ExecuteNonQuery()

                Catch ex As Exception
                    'MsgBox(ex.Message)
                Finally
                    con.Close()

                End Try


                '------------ DELETING  STUDENT DETAILS FROM DATABASE---------------
                Try
                    con.Open()
                    str = " DELETE FROM  student_registation_db  where session='" & dd_2.Text & "'"
                    com = New MySqlCommand(str, con)
                    com.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()

                End Try




                MsgBox("Batch Record Deleted", MsgBoxStyle.Exclamation)

            End If
        End If
    End Sub
End Class