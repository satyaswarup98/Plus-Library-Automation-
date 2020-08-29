Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Faculty_Registation

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

            MsgBox("Please Fill All Data", MessageBoxIcon.Exclamation, Title:="Faculty Registation")

        Else
            If IsValidEmailformat(tb_4.Text).Equals(False) Then
                MsgBox("Invalid Email-ID", MessageBoxIcon.Exclamation, Title:="Faculty Registation")

            ElseIf tb_5.Text.Length <> 10 Then

                MsgBox("Invalid Mobile No", MessageBoxIcon.Exclamation, Title:="Faculty Registation")
            Else

                Try
                    dtt = dt_1.Value.ToString("yyyy-MM-dd")

                    con.Open()
                    str = "INSERT INTO faculty_registation_db (faculty_id, dob, faculty_name, address, designation, blood_group, email, mobile) VALUES ('" & tb_1.Text & "','" & dtt & "', '" & tb_2.Text & "', '" & tb_3.Text & "','" & dd_1.Text & "','" & dd_2.Text & "', '" & tb_4.Text & "', '" & tb_5.Text & "')"
                    com = New MySqlCommand(str, con)
                    com.ExecuteNonQuery()
                    MsgBox("User Registered", MessageBoxIcon.Information, Title:="Faculty Registation")
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

    Private Sub tb_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_2.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

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
            MsgBox("Incorect Date", MessageBoxIcon.Exclamation, Title:="Faculty Registation")

        End If
    End Sub

    Private Sub Autogen_Faculty_ID()
        Try
            con.Open()
            str = "select max(faculty_id) from faculty_registation_db"
            com = New MySqlCommand(str, con)
            tb_1.Text = com.ExecuteScalar + 1
            con.Close()

        Catch ex As Exception
            tb_1.Text = 1
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub Faculty_Registation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Autogen_Faculty_ID()
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


End Class