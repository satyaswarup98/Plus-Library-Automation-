Imports MySql.Data.MySqlClient

Public Class Startup
    Dim flag As Integer
    Dim con1 As New MySqlConnection(" Server = 127.0.0.1 ; Port = 3306  ; User = root ; Password = ; ")
    Dim com1 As New MySqlCommand
    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.TopMost = True

        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



        If pb_1.Value = 15 Then

            Try

                Dim psi1 As New ProcessStartInfo("C:\xampp\apache_start.bat")
                Dim psi2 As New ProcessStartInfo("C:\xampp\mysql_start.bat")

                psi1.CreateNoWindow = True
                psi1.WindowStyle = ProcessWindowStyle.Hidden
                psi2.CreateNoWindow = True
                psi2.WindowStyle = ProcessWindowStyle.Hidden

                Process.Start(psi1)
                Process.Start(psi2)
            Catch ex As Exception
                Timer1.Enabled = False

                Dim a As Integer = MessageBox.Show("Srever Not Found" & vbCrLf & "Required To install XAMPP installer server package" & vbCrLf & "https://www.apachefriends.org/download.html", "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                If a = DialogResult.OK Then
                    Application.Exit()
                Else
                    Application.Exit()
                End If
            Finally

            End Try


        End If

        If pb_1.Value = 65 Then
            Timer1.Interval = 300

            For i = 0 To 1
                Try
                    con1.Open()
                    str = "CREATE DATABASE IF NOT EXISTS library_db"
                    com1 = New MySqlCommand(str, con1)
                    com1.ExecuteNonQuery()
                    con1.Close()
                    i = 1
                Catch ex As Exception
                    i = 0
                Finally
                    con1.Close()
                End Try
            Next

        End If


        If pb_1.Value = 75 Then

            Timer1.Interval = 100

            Try
                con.Open()
                str = " CREATE TABLE IF NOT EXISTS `book_entry_db` ( `book_entry_id` int(11) Not NULL AUTO_INCREMENT, `date_of_entry` date Not NULL, `ISBN_no` bigint(40) Not NULL,`book_no` varchar(10) Not NULL, `book_name` varchar(40) Not NULL,`author_name` varchar(35) Not NULL, `publication_name` varchar(35) Not NULL, `purchase_date` date Not NULL, `price` float Not NULL, `publication_year` int(4) Not NULL, `pages` int(11) Not NULL, `edition` varchar(10) Not NULL, `catagory` varchar(30) Not NULL, `status` varchar(10) Not NULL, PRIMARY KEY(`book_no`), UNIQUE KEY `unique` (`book_entry_id`))"
                com = New MySqlCommand(str, con)
                com.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
            Finally
                con.Close()
            End Try


            Try
            con.Open()
                str = "CREATE TABLE IF NOT EXISTS `book_request_db` ( `request_id` int(11) NOT NULL AUTO_INCREMENT, `request_date` date NOT NULL, `roll_no` varchar(15) NOT NULL, `book_name` varchar(30) NOT NULL, `ISBN_no` varchar(20) NOT NULL, `author_name` varchar(30) NOT NULL, `publication_name` varchar(30) NOT NULL, `edition` varchar(15) NOT NULL, `status` int(11) NOT NULL, `notes` varchar(50) NOT NULL, PRIMARY KEY (`request_id`))"
                com = New MySqlCommand(str, con)
            com.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try


            Try
                con.Open()
                str = "CREATE TABLE IF NOT EXISTS `student_registation_db` ( `roll_no` varchar(8) NOT NULL, `dob` date NOT NULL, `s_name` varchar(35) NOT NULL, `f_name` varchar(35) NOT NULL, `blood_group` varchar(5) NOT NULL, `session` varchar(15) NOT NULL, `email` varchar(40) NOT NULL, `mobile` bigint(10) NOT NULL,`notes` varchar(50) NOT NULL, PRIMARY KEY (`roll_no`), UNIQUE KEY `email` (`email`), UNIQUE KEY `mobile` (`mobile`)) "
                com = New MySqlCommand(str, con)
                com.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
            Finally
                con.Close()
            End Try

            Try
                con.Open()
                str = "CREATE TABLE IF NOT EXISTS `student_book_issue_db` ( `issue_id` int(11) NOT NULL AUTO_INCREMENT, `issue_date` date NOT NULL, `book_no` varchar(20) NOT NULL, `book_name` varchar(40) NOT NULL, `author_name` varchar(40) NOT NULL, `ISBN_no` varchar(20) NOT NULL, `edition` varchar(20) NOT NULL, `roll_no` varchar(30) NOT NULL, `S_name` varchar(20) NOT NULL, `status` int(8) NOT NULL, `return_date` date NOT NULL, `date_diffrence` int(30) NOT NULL, `fine` int(11) NOT NULL, `notes` varchar(50) NOT NULL, PRIMARY KEY (`issue_id`)) "
                com = New MySqlCommand(str, con)
                com.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
            Finally
                con.Close()
            End Try

            Try
                con.Open()
                str = "CREATE TABLE IF NOT EXISTS `deleted_student_db` LIKE `student_registation_db` "
                com = New MySqlCommand(str, con)
                com.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
            Finally
                con.Close()
            End Try

            Try
                con.Open()
                str = "CREATE TABLE IF NOT EXISTS `faculty_registation_db` ( `faculty_id` int(20) NOT NULL, `dob` date NOT NULL, `faculty_name` varchar(35) NOT NULL, `address` varchar(200) NOT NULL, `designation` varchar(30) NOT NULL, `blood_group` varchar(5) NOT NULL, `email` varchar(40) NOT NULL, `mobile` bigint(10) NOT NULL, `notes` varchar(50) NOT NULL, PRIMARY KEY (`faculty_id`), UNIQUE KEY `email` (`email`), UNIQUE KEY `mobile` (`mobile`))  "
                com = New MySqlCommand(str, con)
                com.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
            Finally
                con.Close()
            End Try

            Try
                con.Open()
                str = "CREATE TABLE IF NOT EXISTS `faculty_book_issue_db` ( `issue_id` int(11) NOT NULL AUTO_INCREMENT, `issue_date` date NOT NULL, `book_no` varchar(20) NOT NULL, `book_name` varchar(40) NOT NULL, `author_name` varchar(40) NOT NULL, `ISBN_no` varchar(20) NOT NULL, `edition` varchar(20) NOT NULL, `faculty_id` varchar(30) NOT NULL, `faculty_name` varchar(20) NOT NULL, `status` int(8) NOT NULL, PRIMARY KEY (`issue_id`)) "
                com = New MySqlCommand(str, con)
                com.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
            Finally
                con.Close()
            End Try

            Try
                con.Open()
                str = "CREATE TABLE IF NOT EXISTS `deleted_faculty_db` LIKE `faculty_registation_db` "
                com = New MySqlCommand(str, con)
                com.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
            Finally
                con.Close()
            End Try

            Try
                con.Open()
                str = "CREATE TABLE IF NOT EXISTS `category_db` ( `category` varchar(30) NOT NULL, PRIMARY KEY (`category`))"
                com = New MySqlCommand(str, con)
                com.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
            Finally
                con.Close()
            End Try


            Try
                con.Open()
                str = "CREATE TABLE IF NOT EXISTS forms_db (slno int(11) NOT NULL AUTO_INCREMENT, form_name varchar(40) NOT NULL, display_name varchar(40) NOT NULL, PRIMARY KEY (slno)) "
                com = New MySqlCommand(str, con)
                com.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
            Finally
                con.Close()
            End Try

        End If

        If pb_1.Value = 80 Then
            Timer1.Interval = 20
            Try
                Parent_Window.Show()
            Catch ex As Exception
            End Try
        End If

        If pb_1.Value = 99 Then
            Try
                Parent_Window.Show()
            Catch ex As Exception
            End Try


        End If

        If pb_1.Value >= 100 Then
            Timer1.Enabled = False
            Me.Hide()
        Else
            pb_1.Value += 1
        End If

    End Sub
End Class