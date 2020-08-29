Imports MySql.Data.MySqlClient
Public Class Book_Edit
    Dim status_text As Integer

    Private Sub tb_1_OnValueChanged(sender As Object, e As EventArgs) Handles tb_1.OnValueChanged

        Try
            con.Open()
            str = "SELECT ISBN_NO,book_name,Author_name, publication_name,purchase_date,price,publication_year,pages,edition,catagory,status FROM Book_Entry_db WHERE Book_no= '" & tb_1.Text & "' "
            com = New MySqlCommand(str, con)
            reader = com.ExecuteReader
            If reader.Read Then
                tb_2.Text = reader.GetString("ISBN_no")
                tb_3.Text = reader.GetString("Book_name")
                dd_1.Text = reader.GetString("Publication_year")
                dd_2.Text = reader.GetString("catagory")
                status_text = reader.GetString("status")
                If status_text = 1 Then
                    dd_3.Text = "Avalable"

                Else
                    dd_3.Text = "Out Of Stock"
                End If

                dt_1.Value = reader.GetString("purchase_date")
                tb_4.Text = reader.GetString("Author_name")
                tb_5.Text = reader.GetString("Publication_name")
                tb_6.Text = reader.GetString("Price")
                tb_7.Text = reader.GetString("Pages")
                tb_8.Text = reader.GetString("edition")



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
        tb_6.Text = ""
        tb_7.Text = ""
        tb_8.Text = ""
        dt_1.Value = Today
        dd_1.SelectedIndex = -1
        dd_2.SelectedIndex = -1
        dd_3.SelectedIndex = -1


    End Sub

    Private Sub bt_Save_Click(sender As Object, e As EventArgs) Handles bt_Save.Click
        Try
            dtt = dt_1.Value.ToString("yyyy-MM-dd")

            con.Open()
            str = "UPDATE Book_Entry_db SET ISBN_no='" & tb_2.Text & "', Book_name= '" & tb_3.Text & "', publication_year= '" & dd_1.Text & "', catagory='" & dd_2.Text & "',status='" & dd_3.Text & "',purchase_date= '" & dtt & "', author_name ='" & tb_4.Text & "', publication_name='" & tb_5.Text & "',price='" & tb_6.Text & "',pages='" & tb_7.Text & "',Edition='" & tb_6.Text & "' WHERE Book_no='" & tb_1.Text & "'"
            com = New MySqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox("Data Updated Sucessfully", MessageBoxIcon.Information, Title:="Book Edit")
            con.Close()
            tb_1.Text = ""
            Clear_Data()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub bt_Reset_Click(sender As Object, e As EventArgs) Handles bt_Reset.Click
        tb_1.Text = ""
        Clear_Data()
    End Sub



    Private Sub dt_1_onValueChanged(sender As Object, e As EventArgs) Handles dt_1.onValueChanged
        If dt_1.Value.Date > Now.Date Then
            dt_1.Value = Today
            MsgBox("Incorect Date", MessageBoxIcon.Exclamation, Title:="Book Edit")
        End If
    End Sub

    Private Sub tb_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_1.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 45 Then

                    e.Handled = True

                End If
            End If
        End If
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub


    Private Sub tb_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_2.KeyPress
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

    Private Sub tb_4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_4.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 45 Then

                e.Handled = True

            End If
        End If
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub
    Private Sub tb_7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_7.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then

                e.Handled = True

            End If
        End If
    End Sub
    Private Sub tb_6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_6.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 8 Then

                e.Handled = True

            End If
        End If
    End Sub


    Private Sub tb_5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_5.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 45 Then

                e.Handled = True

            End If
        End If
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub



    Private Sub tb_8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_8.KeyPress
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

    Private Sub Year_Display()

        For j = Now.Year To 1970 Step -1
            dd_1.Items.Add(j)
        Next

    End Sub


    Sub Add_Category()
        Try
            con.Open()
            str = "select category from category_db"
            com = New MySqlCommand(str, con)
            sqlda_BEdit = New MySqlDataAdapter(com)
            ds_BEdit.Clear()
            sqlda_BEdit.Fill(ds_BEdit, "category_db")
            con.Close()

            dd_2.DataSource = ds_BEdit.Tables("category_db")
            dd_2.DisplayMember = "category"
            dd_2.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub Book_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Year_Display()
        Add_Category()
    End Sub
End Class