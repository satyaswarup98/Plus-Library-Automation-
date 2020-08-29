Imports MySql.Data.MySqlClient
Public Class Book_Search
    Private Sub BS_Paint(sender As Object, e As PaintEventArgs) Handles BS.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub


    Private Sub database_ritrival(ByVal book_name As String)

        Try
            con.Open()
            str = "SELECT book_name 'BOOK', author_name 'AUTHOR', EDITION, publication_name 'PUBLICATION', count(*) 'TOTAL', sum(status) 'AVAILABLE' FROM book_entry_db WHERE  book_name LIKE '" & book_name + "%" & "'  GROUP BY author_name"

            com = New MySqlCommand(str, con)
            sqlda_BS = New MySqlDataAdapter(com)

            ds_BS.Clear()

            sqlda_BS.Fill(ds_BS, "category_db")
            con.Close()

            DataGridView1.DataSource = ds_BS
            DataGridView1.DataMember = "category_db"





        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub tb_1_OnValueChanged(sender As Object, e As EventArgs) Handles tb_1.OnValueChanged
        If tb_1.Text <> "" Then
            database_ritrival(tb_1.Text)
        Else
            DataGridView1.DataMember = Nothing
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub tb_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_1.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 45 Then

                e.Handled = True

            End If
        End If
        If Char.IsLower(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub
End Class