Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient


Public Class Student_Registation

    Private Sub clear_data()
        tb_1.Text = ""
        tb_2.Text = ""
        tb_3.Text = ""
        tb_4.Text = ""
        tb_5.Text = ""
        dd_1.SelectedIndex = -1
        dd_2.SelectedIndex = -1
        dt_1.Value = Today

    End Sub

    Function IsValidEmailformat(ByVal s As String) As Boolean
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function
    Private Sub bt_Save_Click(sender As Object, e As EventArgs) Handles bt_Save.Click

        If tb_1.Text = "" Or tb_2.Text = "" Or tb_3.Text = "" Or tb_4.Text = "" Or tb_5.Text = "" Or dd_1.Text = "" Or dd_2.Text = "" Then

            MsgBox("Please Fill All Data", MessageBoxIcon.Exclamation, Title:="Student Registation")

        ElseIf tb_1.Text.Length < 8 Then

            MsgBox("Invalid Roll No", MessageBoxIcon.Exclamation, Title:="Student Registation")
        ElseIf tb_5.Text.Length < 10 Then

            MsgBox("Invalid Mobile No", MessageBoxIcon.Exclamation, Title:="Student Registation")


        Else



            If IsValidEmailformat(tb_4.Text).Equals(False) Then
                MsgBox("Invalid Email-ID", MessageBoxIcon.Exclamation, Title:="Student Registation")
            Else
                Try
                    dtt = dt_1.Value.ToString("yyyy-MM-dd")

                    con.Open()
                    str = "INSERT INTO student_registation_db (roll_no,dob,s_name, f_name, blood_group, session, email, mobile) VALUES ('" & tb_1.Text & "','" & dtt & "', '" & tb_2.Text & "', '" & tb_3.Text & "','" & dd_1.Text & "','" & dd_2.Text & "', '" & tb_4.Text & "', '" & tb_5.Text & "')"
                    com = New MySqlCommand(str, con)
                    com.ExecuteNonQuery()
                    MsgBox("User Registered", MessageBoxIcon.Information, Title:="Student Registation")
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
                clear_data()
            End If
        End If

    End Sub

    Private Sub bt_Reset_Click(sender As Object, e As EventArgs) Handles bt_Reset.Click
        clear_data()
    End Sub

    Private Sub tb_5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_5.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then


                e.Handled = True

            End If
        End If
        If tb_5.Text.Length >= 10 Then
            If Asc(e.KeyChar) <> 8 Then


                e.Handled = True

            End If
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
        If tb_2.Text.Length > 28 Then
            e.Handled = True
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

    Private Sub Year_Display()

        For j = Now.Year To Now.Year - 3 Step -1
            dd_2.Items.Add(j & "-" & j + 2)
        Next

    End Sub

    Private Sub Student_Registation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Year_Display()
    End Sub


End Class