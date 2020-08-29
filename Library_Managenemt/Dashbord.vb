Imports System.Globalization
Imports Bunifu.DataViz
Imports MySql.Data.MySqlClient

Public Class Dashbord
    Dim pb(5) As Integer
    Dim available_books, total_books, student_issued_books, faculty_issued_books, total_issued_books, requested_books, ready_books, total_students, total_faculty As Integer
    Dim pb_max, pb_min As Double
    Dim count(5) As Double
    Private Sub Dashbord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----------READING TOTAL BOOKS---------
        Try
            con.Open()
            str = "SELECT count(*) FROM book_entry_db  "
            com = New MySqlCommand(str, con)
            total_books = com.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


        '----------READING student issued BOOKS---------
        Try
            con.Open()
            str = "SELECT count(*) FROM student_book_issue_db where status=1  "
            com = New MySqlCommand(str, con)
            student_issued_books = com.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        '----------READING faculty issued BOOKS---------
        Try
            con.Open()
            str = "SELECT count(*) FROM faculty_book_issue_db where status=1  "
            com = New MySqlCommand(str, con)
            faculty_issued_books = com.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


        '----------total issued BOOKS---------

        total_issued_books = student_issued_books + faculty_issued_books

        '----------READING TOTAL students---------
        Try
            con.Open()
            str = "SELECT count(*) FROM student_registation_db  "
            com = New MySqlCommand(str, con)
            total_students = com.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        '----------READING TOTAL faculty---------
        Try
            con.Open()
            str = "SELECT count(*) FROM faculty_registation_db  "
            com = New MySqlCommand(str, con)
            total_faculty = com.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        '----------READING BOOK ISSUE PER MONTHS---------

        Dim y, m As Integer
        y = Now.Year
        m = Now.Month
        For i = 0 To 4
            dtt = DateSerial(y, m + 1, 0).ToString("yyyy-MM-dd")
            dtt2 = DateSerial(y, m, 1).ToString("yyyy-MM-dd")


            Try
                con.Open()
                str = "SELECT count(*) FROM student_book_issue_db where issue_date BETWEEN '" & dtt2 & "' and '" & dtt & "'  "
                com = New MySqlCommand(str, con)
                pb(i) = com.ExecuteScalar
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try



            Dim lbs = Me.Controls.Find("lbm_" & i, True)
            If lbs.Length > 0 Then
                lbs(0).Text = New DateTime(y, DateSerial(y, m, 1).ToString("MM"), 1).ToString("MMM", CultureInfo.InvariantCulture)
            End If
            m -= 1

        Next

        '----------READING AVAILABLE BOOKS---------
        Try
            con.Open()
            str = "SELECT count(*) FROM book_entry_db where status=1  "
            com = New MySqlCommand(str, con)
            available_books = com.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        '----------READING REQUESTED BOOKS---------
        Try
            con.Open()
            str = "SELECT count(*) FROM book_request_db WHERE  status= 1 "
            com = New MySqlCommand(str, con)
            requested_books = com.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        '----------READING READY BOOKS---------
        Try
            con.Open()
            str = "SELECT COUNT(*) FROM book_request_db WHERE  status= 0 "
            com = New MySqlCommand(str, con)
            ready_books = com.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        pb_max = 100 / pb.Max


        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True

        If IsNumeric(pb(0)) <> True And IsNumeric(pb(1)) <> True And IsNumeric(pb(2)) <> True And IsNumeric(pb(3)) <> True And IsNumeric(pb(4)) <> True Then
        Else
            If pb(0) <> 0 Or pb(1) <> 0 Or pb(2) <> 0 Or pb(3) <> 0 Or pb(4) <> 0 Then
                Timer5.Enabled = True
                Timer6.Enabled = True
                Timer7.Enabled = True
                Timer8.Enabled = True
                Timer9.Enabled = True
            End If

        End If
            If IsNumeric(total_books) = True And IsNumeric(available_books) = True Then
            If total_books <> 0 Then
                Timer10.Enabled = True
            End If


            If IsNumeric(ready_books) = True And IsNumeric(requested_books) = True Then
                If ready_books <> 0 Or requested_books <> 0 Then
                    Timer11.Enabled = True
                End If
            End If

            If IsNumeric(total_issued_books) = True And IsNumeric(student_issued_books) = True Then

                If total_issued_books <> 0 Then
                    Timer12.Enabled = True
                End If

            End If

        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Val(lb_1.Text) >= total_books Then
            Timer1.Enabled = False
        Else
            lb_1.Text = Val(lb_1.Text) + 1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Val(lb_2.Text) >= total_issued_books Then
            Timer2.Enabled = False
        Else
            lb_2.Text = Val(lb_2.Text) + 1
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Val(lb_3.Text) >= total_students Then
            Timer3.Enabled = False
        Else
            lb_3.Text = Val(lb_3.Text) + 1
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If Val(lb_4.Text) >= total_faculty Then
            Timer4.Enabled = False
        Else
            lb_4.Text = Val(lb_4.Text) + 1
        End If
    End Sub


    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        If Val(pb_1.Value) >= Math.Floor(pb_max * pb(0)) Then
            Timer5.Enabled = False
        Else
            pb_1.Value = Val(pb_1.Value) + 1
            count(0) += (pb(0) / Math.Floor(pb_max * pb(0)))
            lb_5.Text = Math.Round(count(0), 1)
        End If

    End Sub


    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick

        If Val(pb_2.Value) >= Math.Floor(pb_max * pb(1)) Then
            Timer6.Enabled = False
        Else
            pb_2.Value = Val(pb_2.Value) + 1
            count(1) += (pb(1) / Math.Floor(pb_max * pb(1)))
            lb_6.Text = Math.Round(count(1), 1)
        End If

    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick

        If Val(pb_3.Value) >= Math.Floor(pb_max * pb(2)) Then
            Timer7.Enabled = False
        Else
            pb_3.Value = Val(pb_3.Value) + 1
            count(2) += (pb(2) / Math.Floor(pb_max * pb(2)))
            lb_7.Text = Math.Round(count(2), 1)

        End If

    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick

        If Val(pb_4.Value) >= Math.Floor(pb_max * pb(3)) Then
            Timer8.Enabled = False
        Else
            pb_4.Value = Val(pb_4.Value) + 1
            count(3) += (pb(3) / Math.Floor(pb_max * pb(3)))
            lb_8.Text = Math.Round(count(3), 1)
        End If

    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick


        If Val(pb_5.Value) >= Math.Floor(pb_max * pb(4)) Then
            Timer9.Enabled = False
        Else
            pb_5.Value = Val(pb_5.Value) + 1
            count(4) += (pb(4) / Math.Floor(pb_max * pb(4)))
            lb_9.Text = Math.Round(count(4), 1)
        End If

    End Sub


    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick

        If Val(cp_2.Value) >= ((available_books / total_books) * 100) Then
            Timer10.Enabled = False
        Else
            cp_2.Value = cp_2.Value + 1
        End If

    End Sub


    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick

        If Val(cp_1.Value) >= ((ready_books / (ready_books + requested_books)) * 100) Then
            Timer11.Enabled = False
        Else
            cp_1.Value = cp_1.Value + 1
        End If

    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        If Val(g_1.Value) >= ((student_issued_books / total_issued_books) * 100) Then
            Timer12.Enabled = False
        Else
            g_1.Value = g_1.Value + 1
        End If
    End Sub


End Class