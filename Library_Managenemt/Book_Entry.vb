Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Book_Entry
    Dim a(50) As String
    Dim book_no_i, book_no_j, book_no_diff As Integer



    Sub Add_Category()
        Try
            con.Open()
            str = "select category from category_db"
            com = New MySqlCommand(str, con)
            sqlda_BEntry = New MySqlDataAdapter(com)
            ds_BEntry.Clear()
            sqlda_BEntry.Fill(ds_BEntry, "category_db")
            con.Close()

            dd_2.DataSource = ds_BEntry.Tables("category_db")
            dd_2.DisplayMember = "category"

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Autogen_Book_Entry_ID()
        Try
            con.Open()
            str = "select max(book_entry_id) from book_entry_db"
            com = New MySqlCommand(str, con)
            tb_1.Text = com.ExecuteScalar + 1
            con.Close()

        Catch ex As Exception
            tb_1.Text = 1
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Year_Display()

        For j = Now.Year To 1970 Step -1
            dd_1.Items.Add(j)
        Next

    End Sub

    Private Function check_null()
        If tb_2.Text = "" Or tb_3.Text = "" Or tb_4.Text = "" Or tb_5.Text = "" Or tb_6.Text = "" Or tb_7.Text = "" Or tb_8.Text = "" Or tb_9.Text = "" Or tb_10.Text = "" Or tb_11.Text = "" Or dd_1.Text = "" Or dd_2.Text = "" Or dd_3.Text = "" Then
            MsgBox("Please Fill All Data", MessageBoxIcon.Exclamation, Title:="Book Entry")
            Return 0
        Else
            Return 1

        End If
    End Function



    Private Sub Book_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Add_Category()
        Year_Display()
        Autogen_Book_Entry_ID()

    End Sub

    Private Sub bt_AddCatagory_Click(sender As Object, e As EventArgs) Handles bt_AddCatagory.Click
        Category_Entry.Show()
    End Sub

    Private Sub bt_Save_Click(sender As Object, e As EventArgs) Handles bt_Save.Click
        Dim check As Integer = check_null()
        If check = 1 Then


            If InStr(1, UCase(tb_11.Text), "-") Then
                Dim middle = tb_11.Text.IndexOf("-")

                book_no_i = Val(tb_11.Text.Substring(0, middle))
                book_no_j = Val(tb_11.Text.Substring(middle + 1, tb_11.Text.Length - (middle + 1)))

                If book_no_i > book_no_j Then
                    book_no_i = book_no_i + book_no_j
                    book_no_j = book_no_i - book_no_j
                    book_no_i = book_no_i - book_no_j
                End If

                book_no_diff = (book_no_j + 1) - book_no_i

            Else
                book_no_i = Val(tb_1.Text)
                book_no_diff = 1
            End If

            If book_no_diff <> Val(tb_10.Text) Then

                MsgBox("Quantity Not Matched with Total Book No Given ", MessageBoxIcon.Exclamation, Title:="Book Entry")
            Else



                Dim Status_Text As Integer

                Try
                    dtt = dt_1.Value.ToString("yyyy-MM-dd")
                    dtt2 = dt_2.Value.ToString("yyyy-MM-dd")

                    If dd_3.SelectedIndex = 0 Then
                        Status_Text = 1
                    Else
                        Status_Text = 0
                    End If


                    Dim b_no As String

                    If book_no_diff = 1 Then
                        con.Open()
                        b_no = tb_3.Text & "-" & tb_11.Text

                        str = "INSERT INTO book_entry_db (book_entry_id, date_of_entry, ISBN_no, book_no, book_name, author_name, publication_name, purchase_date, price, publication_year, pages, edition, catagory, status) VALUES ('" & tb_1.Text & "','" & dtt & "', '" & tb_2.Text & "', '" & b_no & "', '" & tb_4.Text & "', '" & tb_5.Text & "', '" & tb_6.Text & "', '" & dtt2 & "','" & tb_7.Text & "','" & dd_1.Text & "','" & tb_8.Text & "','" & tb_9.Text & "','" & dd_2.Text & "'," & Status_Text & " )"
                        com = New MySqlCommand(str, con)
                        com.ExecuteNonQuery()
                        con.Close()
                        Autogen_Book_Entry_ID()
                    Else
                        For i = book_no_i To book_no_j
                            con.Open()

                            b_no = tb_3.Text & "-" & i

                            str = "INSERT INTO book_entry_db (book_entry_id, date_of_entry, ISBN_no, book_no, book_name, author_name, publication_name, purchase_date, price, publication_year, pages, edition, catagory, status) VALUES ('" & tb_1.Text & "','" & dtt & "', '" & tb_2.Text & "', '" & b_no & "', '" & tb_4.Text & "', '" & tb_5.Text & "', '" & tb_6.Text & "', '" & dtt2 & "','" & tb_7.Text & "','" & dd_1.Text & "','" & tb_8.Text & "','" & tb_9.Text & "','" & dd_2.Text & "'," & Status_Text & " )"
                            com = New MySqlCommand(str, con)
                            com.ExecuteNonQuery()
                            con.Close()
                            Autogen_Book_Entry_ID()
                        Next

                    End If

                    MsgBox("Data saved sucessfully", MessageBoxIcon.Exclamation, Title:="Book Entry")



                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try

            End If
        End If
    End Sub


    Private Sub bt_Reset_Click(sender As Object, e As EventArgs) Handles bt_Reset.Click
        tb_2.Text = ""
        tb_3.Text = ""
        tb_4.Text = ""
        tb_5.Text = ""
        tb_6.Text = ""
        tb_7.Text = ""
        tb_8.Text = ""
        tb_9.Text = ""
        dt_1.Value = Today
        dt_2.Value = Today
        dd_1.SelectedIndex = -1
        dd_2.SelectedIndex = -1
        dd_3.SelectedIndex = -1

    End Sub


    '*************VALIDATIONS**************************************

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


    Private Sub tb_5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_5.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

                e.Handled = True

            End If
        End If
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub


    Private Sub tb_6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_6.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

                e.Handled = True

            End If
        End If
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub


    Private Sub tb_7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_7.KeyPress

        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 8 Then

                e.Handled = True

            End If
        End If
    End Sub

    Private Sub tb_8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_8.KeyPress

        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then

                e.Handled = True

            End If
        End If
    End Sub

    Private Sub tb_10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_10.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then

                e.Handled = True

            End If
        End If
    End Sub

    Private Sub dt_1_onValueChanged(sender As Object, e As EventArgs) Handles dt_1.onValueChanged
        If dt_1.Value.Date > Now.Date Then
            dt_1.Value = Today
            MsgBox("Incorect Date", MessageBoxIcon.Exclamation, Title:="Book Entry")

        End If
    End Sub

    Private Sub dt_2_onValueChanged(sender As Object, e As EventArgs) Handles dt_2.onValueChanged
        If dt_2.Value.Date > Now.Date Then
            dt_2.Value = Today
            MsgBox("Incorect Date", MessageBoxIcon.Exclamation, Title:="Book Entry")
        End If
    End Sub


    Private Sub tb_9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_9.KeyPress
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

    Private Sub tb_3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_3.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) <> 8 Then

                e.Handled = True

            End If
        End If
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If

    End Sub



    Private Sub tb_11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_11.KeyPress

        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 45 Then

                e.Handled = True

            End If
        End If
        If InStr(1, UCase(tb_11.Text), "-") And Asc(e.KeyChar) = 45 Then

            e.Handled = True

        End If

    End Sub



    Private Sub tb_10_Leave(sender As Object, e As EventArgs) Handles tb_10.Leave
        If tb_10.Text <> "" Then
            If tb_10.Text < Val(1) Then
                MsgBox("invalid Quantity", MessageBoxIcon.Exclamation, Title:="Book Entry")
                tb_10.Text = ""
            End If
        End If
    End Sub

    Private Sub tb_11_Leave(sender As Object, e As EventArgs) Handles tb_11.Leave
        If tb_10.Text = "" Then
            MsgBox("First Specify Quantity", MessageBoxIcon.Exclamation, Title:="Book Entry")
            tb_11.Text = ""
        ElseIf tb_10.Text = Val(1) And InStr(1, UCase(tb_11.Text), "-") Then
            MsgBox("Multiple Book No is not allowed for Single quntity", MessageBoxIcon.Exclamation, Title:="Book Entry")
            tb_11.Text = ""
        ElseIf tb_10.Text > Val(1) And InStr(1, UCase(tb_11.Text), "-") = False Then
            MsgBox("Single Book No is not allowed for Multiple quntity", MessageBoxIcon.Exclamation, Title:="Book Entry")
            tb_11.Text = ""
        End If
    End Sub


End Class