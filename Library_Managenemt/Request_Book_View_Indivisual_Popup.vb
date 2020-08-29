Imports MySql.Data.MySqlClient
Public Class Request_Book_View_Indivisual_Popup

    Dim ISBN_NO, Roll_No As String

    Public Sub Reset_Me()        'FOR READY OPTION CLICK

        Me.Text = "Indivisual Requests"
        Me.Height = 320
        bt_Delete.Location = New Point(270, 210)
        bt_Ready.Location = New Point(390, 210)
        lb_19.Visible = False
        lb_20.Visible = False
        tb_1.Visible = False

    End Sub

    Public Sub Request_Delete()         'FOR DELETE OPTION CLICK

        Me.Show()
        Me.Text = "Delete Request"
        Me.Height = 395
        bt_Delete.Location = New Point(270, 285)
        bt_Ready.Location = New Point(390, 285)
        lb_19.Visible = True
        lb_20.Visible = True
        tb_1.Visible = True

    End Sub

    Private Sub bt_Ready_Click(sender As Object, e As EventArgs) Handles bt_Ready.Click

        Reset_Me()
        Request_Book_View.Book_Ready()

        If Request_Book_View.Result = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub Request_Book_View_Indivisual_Popup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TopMost = True
        lb_2.Text = ":   " + Request_Book_View.DataGridView1.CurrentRow.Cells("BOOK").Value
        lb_4.Text = ":   " + Request_Book_View.DataGridView1.CurrentRow.Cells("ROLL NO").Value
        lb_6.Text = ":   " + Request_Book_View.DataGridView1.CurrentRow.Cells("AUTHOR").Value
        lb_10.Text = ":   " + Request_Book_View.DataGridView1.CurrentRow.Cells("PUBLICATION").Value
        lb_14.Text = ":   " + Request_Book_View.DataGridView1.CurrentRow.Cells("EDITION").Value
        lb_18.Text = ":   " + Request_Book_View.DataGridView1.CurrentRow.Cells("REQ. DATE").Value

        ISBN_NO = Request_Book_View.DataGridView1.CurrentRow.Cells("isbn_no").Value
        Roll_No = Request_Book_View.DataGridView1.CurrentRow.Cells("ROLL NO").Value

        'CODE FOR READ TOTAL BOOKS 

        Try
            con.Open()
            str = "SELECT  count(*) FROM book_entry_db WHERE  ISBN_NO='" & ISBN_NO & "'"
            com = New MySqlCommand(str, con)
            lb_8.Text = ":   " & com.ExecuteScalar
            con.Close()
        Catch ex As Exception
            lb_8.Text = ":   " & "0"
        Finally
            con.Close()
        End Try

        'CODE FOR READ AVAILABLE BOOKS

        Try
            con.Open()
            str = "SELECT  sum(status) FROM book_entry_db WHERE  ISBN_NO= '" & ISBN_NO & "'"
            com = New MySqlCommand(str, con)
            lb_12.Text = ":   " & com.ExecuteScalar
            con.Close()
        Catch ex As Exception
            lb_12.Text = ":   " & "0"
        Finally
            con.Close()
        End Try

        ' CODE FOR COUNT NO OF BOOK REQUESTED FOR SAME ISBN NO

        Try
            con.Open()
            str = "select count(*) from  book_request_db where isbn_no='" & ISBN_NO & "'  AND status IN(0,1)"
            com = New MySqlCommand(str, con)
            lb_16.Text = ":   " & com.ExecuteScalar
            con.Close()
        Catch ex As Exception

            lb_16.Text = ":   " & "0"
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub bt_Delete_Click(sender As Object, e As EventArgs) Handles bt_Delete.Click

        If Me.Height < 390 Then

            Request_Delete()

        Else
            If tb_1.Text = "" Or tb_1.Text.Length < 4 Then
                tb_1.BorderColorIdle = Color.Red
                tb_1.BorderColorFocused = Color.Red
                MsgBox("Proper Reson Required", MessageBoxIcon.Error, Title:="Reason Required")

            Else

                Dim Delete_Request As Integer = MessageBox.Show("Conform Delete Request Of Roll No : " + Roll_No, "Conform Request Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If Delete_Request = DialogResult.Yes Then

                    Me.Close()
                    Try
                        con.Open()
                        str = "UPDATE book_request_db SET status=2 WHERE ISBN_no='" & ISBN_NO & "' AND roll_no='" & Roll_No & "'"
                        com = New MySqlCommand(str, con)
                        com.ExecuteNonQuery()
                        con.Close()
                        Request_Book_View.View_Requests()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        con.Close()
                    End Try

                End If

            End If
        End If

    End Sub

End Class