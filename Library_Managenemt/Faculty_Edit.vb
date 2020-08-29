Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class Faculty_Edit

    Dim data_read As Integer
    Function IsValidEmailformat(ByVal s As String) As Boolean
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function
    Private Sub tb_1_OnValueChanged(sender As Object, e As EventArgs) Handles tb_1.OnValueChanged

        Try
            con.Open()
            str = "SELECT faculty_id,dob,faculty_name, address, designation,blood_group, email, mobile FROM faculty_registation_db WHERE faculty_id= '" & tb_1.Text & "' "
            com = New MySqlCommand(str, con)
            reader = com.ExecuteReader
            If reader.Read Then
                tb_2.Text = reader.GetString("faculty_name")
                tb_3.Text = reader.GetString("address")
                dd_1.Text = reader.GetString("designation")
                dd_2.Text = reader.GetString("blood_group")
                dt_1.Value = reader.GetString("dob").Substring(0, 10)
                tb_4.Text = reader.GetString("email")
                tb_5.Text = reader.GetString("mobile")
                data_read = 1
            Else
                Clear_Data()
                data_read = 0
            End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub Clear_Data()
        tb_2.Text = ""
        tb_3.Text = ""
        tb_4.Text = ""
        tb_5.Text = ""
        dt_1.Value = Today
        dd_1.SelectedIndex = -1
        dd_2.SelectedIndex = -1

    End Sub

    Private Sub bt_Save_Click(sender As Object, e As EventArgs) Handles bt_Save.Click
        If data_read <> 1 Then
            MsgBox("Invalid Faculty ID", MessageBoxIcon.Exclamation, Title:="Faculty Edit")
        ElseIf tb_1.Text = "" Or tb_2.Text = "" Or tb_3.Text = "" Or tb_4.Text = "" Or tb_5.Text = "" Or dd_1.Text = "" Or dd_2.Text = "" Then

            MsgBox("Please Fill All Data", MessageBoxIcon.Exclamation, Title:="Faculty Edit")

        Else
            If IsValidEmailformat(tb_4.Text).Equals(False) Then
                MsgBox("Invalid Email-ID", MessageBoxIcon.Exclamation, Title:="Faculty Edit")

            ElseIf tb_5.Text.Length <> 10 Then

                MsgBox("Invalid Mobile No", MessageBoxIcon.Exclamation, Title:="Faculty Edit")
            Else


                Try
                    dtt = dt_1.Value.ToString("yyyy-MM-dd")
                    con.Open()

                    str = "UPDATE faculty_registation_db SET dob='" & dtt & "',faculty_name='" & tb_2.Text & "', address= '" & tb_3.Text & "', designation='" & dd_1.Text & "', blood_group='" & dd_2.Text & "', email ='" & tb_4.Text & "', mobile='" & tb_5.Text & "' WHERE faculty_id='" & tb_1.Text & "'"


                    com = New MySqlCommand(str, con)
                    com.ExecuteNonQuery()

                    MsgBox("Data Updated Sucessfully", MessageBoxIcon.Information, Title:="Faculty Edit")
                    con.Close()
                    tb_1.Text = ""
                    Clear_Data()

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub bt_Reset_Click(sender As Object, e As EventArgs) Handles bt_Reset.Click
        tb_1.Text = ""
        Clear_Data()
    End Sub


    Private Sub dt_1_onValueChanged(sender As Object, e As EventArgs) Handles dt_1.onValueChanged
        If dt_1.Value.Date > Now.Date Then
            dt_1.Value = Today
            MsgBox("Incorect Date", MessageBoxIcon.Exclamation, Title:="Faculty Edit")
        End If
    End Sub

    Private Sub tb_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_1.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
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