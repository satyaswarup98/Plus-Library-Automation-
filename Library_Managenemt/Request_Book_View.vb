Imports MySql.Data.MySqlClient

Public Class Request_Book_View
    Public Result As Integer
    Public ISBN, Roll_No As String

    Public Sub View_Requests()
        Try
            con.Open()
            str = "SELECT request_date 'REQ. DATE', roll_no 'ROLL NO',book_name 'BOOK', author_name 'AUTHOR', EDITION, publication_name 'PUBLICATION', ISBN_no FROM book_request_db WHERE  status= 1 " ' UNION SELECT count(*), sum(status) FROM book_entry_db WHERE "
            com = New MySqlCommand(str, con)
            sqlda_RVB = New MySqlDataAdapter(com)

            ds_RVB.Clear()

            sqlda_RVB.Fill(ds_RVB, "category_db")
            con.Close()

            DataGridView1.DataSource = ds_RVB
            DataGridView1.DataMember = "category_db"

            '--HIDING ISBN COLUMN--
            DataGridView1.Columns("isbn_no").Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub Book_Ready()

        Try
            ISBN = DataGridView1.CurrentRow.Cells("isbn_no").Value
            Roll_No = DataGridView1.CurrentRow.Cells("ROLL NO").Value
        Catch ex As Exception
            ISBN = ""
            Roll_No = ""
        End Try

        Result = MessageBox.Show("Conform Book Ready For Roll No : " + Roll_No, "Conform Book Ready", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If Result = DialogResult.Yes Then
            Try

                con.Open()
                str = "UPDATE book_request_db SET status=0 WHERE ISBN_no='" & ISBN & "' AND roll_no='" & Roll_No & "'"
                com = New MySqlCommand(str, con)
                com.ExecuteNonQuery()
                con.Close()
                View_Requests()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        Else

        End If

    End Sub

    Private Sub Request_Book_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        View_Requests()

    End Sub

    Private Sub bt_Ready_Click(sender As Object, e As EventArgs) Handles bt_Ready.Click

        Book_Ready()

    End Sub

    Private Sub bt_Delete_Click(sender As Object, e As EventArgs) Handles bt_Delete.Click

        Try

            ISBN = DataGridView1.CurrentRow.Cells("isbn_no").Value
            Roll_No = DataGridView1.CurrentRow.Cells("ROLL NO").Value

        Catch ex As Exception
            ISBN = ""
            Roll_No = ""
        End Try

        Request_Book_View_Indivisual_Popup.Request_Delete()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Request_Book_View_Indivisual_Popup.Show()
    End Sub

End Class