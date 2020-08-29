Imports MySql.Data.MySqlClient
Public Class Category_Entry

    Dim Check_Repeat As Integer
    Private Sub category_entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub bt_Save_Click(sender As Object, e As EventArgs) Handles bt_Save.Click

        Try
            con.Open()
            str = "SELECT count(*) from category_db where category= '" & tb_1.Text.Trim & "' "
            com = New MySqlCommand(str, con)
            reader = com.ExecuteReader

            If reader.Read Then
                Check_Repeat = reader.GetString("count(*)")
            End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
            con.Close()
        End Try

        If Check_Repeat > 0 Then
            MsgBox("category already exist", MessageBoxIcon.Exclamation, Title:="Category Entry")
        ElseIf tb_1.Text = "" Then
            MsgBox("No category to save", MessageBoxIcon.Exclamation, Title:="Category Entry")
        Else
            Try
                con.Open()
                str = "INSERT INTO category_db (category) VALUES ('" & tb_1.Text & "' )"
                com = New MySqlCommand(str, con)
                com.ExecuteNonQuery()

                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
            Book_Entry.Add_Category()
            Me.Close()
        End If

    End Sub

    Private Sub bt_Cancel_Click(sender As Object, e As EventArgs) Handles bt_Cancel.Click
        Me.Close()
    End Sub



    Private Sub tb_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_1.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

                e.Handled = True

            End If
        End If
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

End Class