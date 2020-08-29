Imports MySql.Data.MySqlClient
Imports Library_Managenemt.MDITest

Public Class Parent_Window

    Protected Overrides Sub SetVisibleCore(ByVal value As Boolean)
        If Not Me.IsHandleCreated Then
            Me.CreateHandle()
            value = False
        End If
        MyBase.SetVisibleCore(value)
    End Sub

    Private Sub Parent_Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Startup.Close()

        form_Name_Auto_Complete()
        '----------code for making mdi parent background color---------

        Dim ctl As Control
        Dim ctlMDI As MdiClient

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Me.BackColor

            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next

        '-----------codes for removig 3d boder effect from mdi parent form-----------
        ' codes in module1

        MDIClientSupport.SetBevel(Me, False)


        '---------mdi child declare---------
        Dashbord.Show()
        Dashbord.MdiParent = Me
        Dashbord.Dock = DockStyle.Fill

    End Sub

    Private Sub Parent_Window_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        '---------code for responsive drawer effect----------

        If Me.Width > 1020 Then
            Drawer.Width = 250
        Else
            Drawer.Width = 0
        End If

    End Sub

    Private Sub Parent_Window_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate

        '----------code for Display name of actove form name----------

        If ActiveMdiChild Is Nothing Then
            Active_Menu.Text = ""
        Else
            Active_Menu.Text = ActiveMdiChild.Text
        End If

    End Sub

    Public Sub Closing_All()

        '---------code for closing all active mdi child forms----------
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next

    End Sub

    '---------------------------------tool strip menu items list -------------------------------------------------------------
    Public Sub StudentToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem3.Click

        Choose_Button_Invisivle()
        Closing_All()


        '---------mdi child declare---------
        Student_Book_Issue.Show()
        Student_Book_Issue.MdiParent = Me
        Student_Book_Issue.Dock = DockStyle.Fill


    End Sub

    Private Sub FacultyToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem3.Click

        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Faculty_Book_Issue.Show()
        Faculty_Book_Issue.MdiParent = Me
        Faculty_Book_Issue.Dock = DockStyle.Fill


    End Sub

    Private Sub StudentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem1.Click

        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Student_Registation.Show()
        Student_Registation.MdiParent = Me
        Student_Registation.Dock = DockStyle.Fill

    End Sub

    Private Sub FacultyToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem2.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Faculty_Registation.Show()
        Faculty_Registation.MdiParent = Me
        Faculty_Registation.Dock = DockStyle.Fill
    End Sub

    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Student_Edit.Show()
        Student_Edit.MdiParent = Me
        Student_Edit.Dock = DockStyle.Fill
    End Sub

    Private Sub FacultyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem1.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Faculty_Edit.Show()
        Faculty_Edit.MdiParent = Me
        Faculty_Edit.Dock = DockStyle.Fill
    End Sub




    Private Sub EntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntryToolStripMenuItem.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Book_Entry.Show()
        Book_Entry.MdiParent = Me
        Book_Entry.Dock = DockStyle.Fill
    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Book_Edit.Show()
        Book_Edit.MdiParent = Me
        Book_Edit.Dock = DockStyle.Fill
    End Sub

    Private Sub ViewToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem2.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Book_View.Show()
        Book_View.MdiParent = Me
        Book_View.Dock = DockStyle.Fill
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Book_Search.Show()
        Book_Search.MdiParent = Me
        Book_Search.Dock = DockStyle.Fill
    End Sub

    Private Sub StudentToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem4.Click
        Choose_Button_Invisivle()
        Closing_All()


        '---------mdi child declare---------
        Student_Book_Return.Show()
        Student_Book_Return.MdiParent = Me
        Student_Book_Return.Dock = DockStyle.Fill

    End Sub

    Private Sub FacultyToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem4.Click
        Choose_Button_Invisivle()
        Closing_All()


        '---------mdi child declare---------
        Faculty_Book_Return.Show()
        Faculty_Book_Return.MdiParent = Me
        Faculty_Book_Return.Dock = DockStyle.Fill

    End Sub

    Private Sub ViewToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem3.Click
        Choose_Button_Invisivle()
        Closing_All()


        '---------mdi child declare---------
        View_Transaction.Show()
        View_Transaction.MdiParent = Me
        View_Transaction.Dock = DockStyle.Fill

    End Sub




    Private Sub StudentToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem2.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Student_View.Show()
        Student_View.MdiParent = Me
        Student_View.Dock = DockStyle.Fill
    End Sub

    Private Sub FacultyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Faculty_view.Show()
        Faculty_view.MdiParent = Me
        Faculty_view.Dock = DockStyle.Fill
    End Sub


    Private Sub FacultyToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem6.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Faculty_delete.Show()
        Faculty_delete.MdiParent = Me
        Faculty_delete.Dock = DockStyle.Fill
    End Sub

    Private Sub ViewToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem4.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Request_Book_Offline.Show()
        Request_Book_Offline.MdiParent = Me
        Request_Book_Offline.Dock = DockStyle.Fill
    End Sub

    Private Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestToolStripMenuItem.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Request_Book_View.Show()
        Request_Book_View.MdiParent = Me
        Request_Book_View.Dock = DockStyle.Fill
    End Sub

    Private Sub ReadyBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReadyBooksToolStripMenuItem.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Ready_Book_View.Show()
        Ready_Book_View.MdiParent = Me
        Ready_Book_View.Dock = DockStyle.Fill
    End Sub

    Private Sub DeletedRequestsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletedRequestsToolStripMenuItem.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Deleted_Request_View.Show()
        Deleted_Request_View.MdiParent = Me
        Deleted_Request_View.Dock = DockStyle.Fill
    End Sub

    '------------------------------------------------------end of tool strip menu items-------------------------------------------


    Public sub Choose_Button_Invisivle()

        NB_Choose_Menu.Height = 0
        BI_Choose_Menu.Height = 0
        BR_Choose_Menu.Height = 0
        V_Choose_Menu.Height = 0
        R_Choose_Menu.Height = 0

    End sub

    Private Sub bt_NewBook_Click(sender As Object, e As EventArgs) Handles bt_NewBook.Click


        '---------condition to display form------------ 
        If ActiveMdiChild Is Nothing Then

            Choose_Button_Invisivle()
            Closing_All()
            NB_Choose_Menu.Height = 50
            NB_Choice1_Click(sender, e)

        Else
            If Not ActiveMdiChild.Equals(Book_Entry) Or ActiveMdiChild.Equals(Book_Edit) Then
                Choose_Button_Invisivle()
                Closing_All()
                NB_Choose_Menu.Height = 50
                NB_Choice1_Click(sender, e)
            End If

        End If

    End Sub

    Private Sub bt_BookIssue_Click(sender As Object, e As EventArgs) Handles bt_BookIssue.Click

        '---------condition to display form------------ 
        If ActiveMdiChild Is Nothing Then

            Choose_Button_Invisivle()
            Closing_All()
            BI_Choose_Menu.Height = 50
            BI_Choice1_Click(sender, e)

        Else
            If Not ActiveMdiChild.Equals(Student_Book_Issue) Or ActiveMdiChild.Equals(Faculty_Book_Issue) Then
                Choose_Button_Invisivle()
                Closing_All()
                BI_Choose_Menu.Height = 50
                BI_Choice1_Click(sender, e)
            End If

        End If

    End Sub

    Private Sub bt_BookReturn_Click(sender As Object, e As EventArgs) Handles bt_BookReturn.Click


        '---------condition to display form------------ 
        If ActiveMdiChild Is Nothing Then
            Choose_Button_Invisivle()
            Closing_All()
            BR_Choose_Menu.Height = 50
            BR_Choice1_Click(sender, e)

        Else
            If Not ActiveMdiChild.Equals(Student_Book_Return) Or ActiveMdiChild.Equals(Faculty_Book_Return) Then
                Choose_Button_Invisivle()
                Closing_All()
                BR_Choose_Menu.Height = 50
                BR_Choice1_Click(sender, e)
            End If

        End If

    End Sub


    Private Sub bt_Transactions_Click(sender As Object, e As EventArgs) Handles bt_Transactions.Click

        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        View_Transaction.Show()
        View_Transaction.MdiParent = Me
        View_Transaction.Dock = DockStyle.Fill


        ' *************** PREVIOUSLY WRITTEN ******************

        ''---------condition to display form------------ 
        'If ActiveMdiChild Is Nothing Then
        '    Choose_Button_Invisivle()
        '    Closing_All()
        '    T_Choose_Menu.Height = 50
        '    t_Choice1_Click(sender, e)

        'Else
        '    If Not ActiveMdiChild.Equals(View_Transaction) Or ActiveMdiChild.Equals(Student_Transaction_Search) Or ActiveMdiChild.Equals(Faculty_Transaction_Search) Then
        '        Choose_Button_Invisivle()
        '        Closing_All()
        '        T_Choose_Menu.Height = 50
        '        t_Choice1_Click(sender, e)
        '    End If

        'End If
    End Sub



    Private Sub bt_View_Click(sender As Object, e As EventArgs) Handles bt_View.Click

        '---------condition to display form------------ 
        If ActiveMdiChild Is Nothing Then
            Choose_Button_Invisivle()
            Closing_All()
            V_Choose_Menu.Height = 50
            V_Choice1_Click(sender, e)

        Else
            If Not ActiveMdiChild.Equals(Student_View) Or ActiveMdiChild.Equals(Faculty_view) Or ActiveMdiChild.Equals(Book_View) Then
                Choose_Button_Invisivle()
                Closing_All()
                V_Choose_Menu.Height = 50
                V_Choice1_Click(sender, e)
            End If

        End If

    End Sub

    Private Sub bt_Register_Click(sender As Object, e As EventArgs) Handles bt_Register.Click

        '---------condition to display form------------ 
        If ActiveMdiChild Is Nothing Then
            Choose_Button_Invisivle()
            Closing_All()
            R_Choose_Menu.Height = 50
            R_Choice1_Click(sender, e)

        Else
            If Not ActiveMdiChild.Equals(Student_Registation) Or ActiveMdiChild.Equals(Faculty_Registation) Then
                Choose_Button_Invisivle()
                Closing_All()
                R_Choose_Menu.Height = 50
                R_Choice1_Click(sender, e)
            End If

        End If
    End Sub

    Private Sub bt_Exit_Click(sender As Object, e As EventArgs) Handles bt_Exit.Click
        Application.Exit()
    End Sub

    '----------------------- book issue choice--------------------------------


    Private Sub BI_Choice1_Click(sender As Object, e As EventArgs) Handles BI_Choice1.Click

        Try

            '-------code for separator line under the button-------
            BI_Separator.Left = BI_Choice1.Left
            BI_Separator.Width = BI_Choice1.Width

            If ActiveMdiChild Is Nothing Then

                '---------mdi child declare---------
                Student_Book_Issue.Show()
                Student_Book_Issue.MdiParent = Me
                Student_Book_Issue.Dock = DockStyle.Fill


            Else
                If Not ActiveMdiChild.Equals(Student_Book_Issue) Then

                    '---------Hiding Animation---------
                    Faculty_Book_Issue.fbiHide.HideSync(Faculty_Book_Issue.FBI)

                    Closing_All()

                    '---------mdi child declare---------
                    Student_Book_Issue.Show()
                    Student_Book_Issue.MdiParent = Me
                    Student_Book_Issue.Dock = DockStyle.Fill

                    '----------making the panel invisible---------
                    Student_Book_Issue.SBI.Visible = False

                    '----------Entrance animation----------
                    Student_Book_Issue.sShow.ShowSync(Student_Book_Issue.SBI)
                End If

            End If


        Catch ex As Exception
            BI_Choice1.Enabled = False

        Finally
            BI_Choice1.Enabled = True

        End Try



    End Sub

    Private Sub BI_Choice2_Click(sender As Object, e As EventArgs) Handles BI_Choice2.Click

        Try

            '-------code for separator line under the button-------
            BI_Separator.Left = BI_Choice2.Left
            BI_Separator.Width = BI_Choice2.Width

            If ActiveMdiChild Is Nothing Then

                '---------mdi child declare---------
                Faculty_Book_Issue.Show()
                Faculty_Book_Issue.MdiParent = Me
                Faculty_Book_Issue.Dock = DockStyle.Fill


            Else
                If Not ActiveMdiChild.Equals(Faculty_Book_Issue) Then

                    '---------Hiding Animation---------
                    Student_Book_Issue.sHide.HideSync(Student_Book_Issue.SBI)

                    Closing_All()

                    '---------mdi child declare---------
                    Faculty_Book_Issue.Show()
                    Faculty_Book_Issue.MdiParent = Me
                    Faculty_Book_Issue.Dock = DockStyle.Fill

                    '----------making the panel invisible---------
                    Faculty_Book_Issue.FBI.Visible = False

                    '----------Entrance animation----------
                    Faculty_Book_Issue.fbrShow.ShowSync(Faculty_Book_Issue.FBI)
                End If

            End If


        Catch ex As Exception
            BI_Choice2.Enabled = False
        Finally
            BI_Choice2.Enabled = True
        End Try


    End Sub

    '---------------------------end of book issue choice ------------------------------

    '---------------------------book return choice ------------------------------------

    Private Sub BR_Choice1_Click(sender As Object, e As EventArgs) Handles BR_Choice1.Click

        Try

            '-------code for separator line under the button-------
            BR_Separator.Left = BR_Choice1.Left
            BR_Separator.Width = BR_Choice1.Width

            If ActiveMdiChild Is Nothing Then

                '---------mdi child declare---------
                Student_Book_Return.Show()
                Student_Book_Return.MdiParent = Me
                Student_Book_Return.Dock = DockStyle.Fill

            Else
                If Not ActiveMdiChild.Equals(Student_Book_Return) Then

                    '---------Hiding Animation---------
                    Faculty_Book_Return.fbrHide.HideSync(Faculty_Book_Return.FBR)

                    Closing_All()

                    '---------mdi child declare---------
                    Student_Book_Return.Show()
                    Student_Book_Return.MdiParent = Me
                    Student_Book_Return.Dock = DockStyle.Fill

                    '----------making the panel invisible---------
                    Student_Book_Return.SBR.Visible = False

                    '----------Entrance animation----------
                    Student_Book_Return.sbrShow.ShowSync(Student_Book_Return.SBR)

                End If

            End If

        Catch ex As Exception
            BR_Choice1.Enabled = False

        Finally
            BR_Choice1.Enabled = True

        End Try

    End Sub

    Private Sub BR_Choice2_Click(sender As Object, e As EventArgs) Handles BR_Choice2.Click

        Try

            '-------code for separator line under the button-------
            BR_Separator.Left = BR_Choice2.Left
            BR_Separator.Width = BR_Choice2.Width

            If ActiveMdiChild Is Nothing Then

                '---------mdi child declare---------
                Faculty_Book_Return.Show()
                Faculty_Book_Return.MdiParent = Me
                Faculty_Book_Return.Dock = DockStyle.Fill

            Else
                If Not ActiveMdiChild.Equals(Faculty_Book_Return) Then

                    '---------Hiding Animation---------
                    Student_Book_Return.sbrHide.HideSync(Student_Book_Return.SBR)
                    Closing_All()

                    '---------mdi child declare---------
                    Faculty_Book_Return.Show()
                    Faculty_Book_Return.MdiParent = Me
                    Faculty_Book_Return.Dock = DockStyle.Fill

                    '----------making the panel invisible---------
                    Faculty_Book_Return.FBR.Visible = False

                    '----------Entrance animation----------
                    Faculty_Book_Return.fbrShow.ShowSync(Faculty_Book_Return.FBR)
                End If

            End If

        Catch ex As Exception
            BR_Choice2.Enabled = False
        Finally
            BR_Choice2.Enabled = True
        End Try

    End Sub

    '---------------------------end of book return choice ------------------------------

    Private Sub NB_Choice1_Click(sender As Object, e As EventArgs) Handles NB_Choice1.Click

        Try

            '-------code for separator line under the button-------
            NB_Separator.Left = NB_Choice1.Left
            NB_Separator.Width = NB_Choice1.Width

            If ActiveMdiChild Is Nothing Then

                '---------mdi child declare---------
                Book_Entry.Show()
                Book_Entry.MdiParent = Me
                Book_Entry.Dock = DockStyle.Fill

            Else
                If Not ActiveMdiChild.Equals(Book_Entry) Then

                    '---------Hiding Animation---------
                    Book_Edit.beHide.HideSync(Book_Edit.BEdit)
                    Closing_All()

                    '---------mdi child declare---------
                    Book_Entry.Show()
                    Book_Entry.MdiParent = Me
                    Book_Entry.Dock = DockStyle.Fill

                    '----------making the panel invisible---------
                    Book_Entry.BEntry.Visible = False

                    '----------Entrance animation----------
                    Book_Entry.beShow.ShowSync(Book_Entry.BEntry)
                End If

            End If

        Catch ex As Exception
            NB_Choice1.Enabled = False
        Finally
            NB_Choice1.Enabled = True
        End Try


    End Sub

    Private Sub NB_Choice2_Click(sender As Object, e As EventArgs) Handles NB_Choice2.Click

        Try

            '-------code for separator line under the button-------
            NB_Separator.Left = NB_Choice2.Left
            NB_Separator.Width = NB_Choice2.Width

            If ActiveMdiChild Is Nothing Then

                '---------mdi child declare---------
                Book_Edit.Show()
                Book_Edit.MdiParent = Me
                Book_Edit.Dock = DockStyle.Fill

            Else
                If Not ActiveMdiChild.Equals(Book_Edit) Then

                    '---------Hiding Animation---------
                    Book_Entry.beHide.HideSync(Book_Entry.BEntry)
                    Closing_All()

                    '---------mdi child declare---------
                    Book_Edit.Show()
                    Book_Edit.MdiParent = Me
                    Book_Edit.Dock = DockStyle.Fill

                    '----------making the panel invisible---------
                    Book_Edit.BEdit.Visible = False

                    '----------Entrance animation----------
                    Book_Edit.beShow.ShowSync(Book_Edit.BEdit)
                End If

            End If

        Catch ex As Exception
            NB_Choice2.Enabled = False
        Finally
            NB_Choice2.Enabled = True
        End Try

    End Sub

    Private Sub R_Choice1_Click(sender As Object, e As EventArgs) Handles R_Choice1.Click

        Try

            '-------code for separator line under the button-------
            R_Separator.Left = R_Choice1.Left
            R_Separator.Width = R_Choice1.Width

            If ActiveMdiChild Is Nothing Then

                '---------mdi child declare---------
                Student_Registation.Show()
                Student_Registation.MdiParent = Me
                Student_Registation.Dock = DockStyle.Fill

            Else
                If Not ActiveMdiChild.Equals(Student_Registation) Then

                    '---------Hiding Animation---------
                    Faculty_Registation.frHide.HideSync(Faculty_Registation.FR)

                    Closing_All()

                    '---------mdi child declare---------
                    Student_Registation.Show()
                    Student_Registation.MdiParent = Me
                    Student_Registation.Dock = DockStyle.Fill

                    '----------making the panel invisible---------
                    Student_Registation.SR.Visible = False

                    '----------Entrance animation----------
                    Student_Registation.srShow.ShowSync(Student_Registation.SR)

                End If

            End If

        Catch ex As Exception
            BR_Choice1.Enabled = False

        Finally
            BR_Choice1.Enabled = True

        End Try

    End Sub

    Private Sub R_Choice2_Click(sender As Object, e As EventArgs) Handles R_Choice2.Click



        Try

            '-------code for separator line under the button-------
            R_Separator.Left = R_Choice2.Left
            R_Separator.Width = R_Choice2.Width

            If ActiveMdiChild Is Nothing Then

                '---------mdi child declare---------
                Faculty_Registation.Show()
                Faculty_Registation.MdiParent = Me
                Faculty_Registation.Dock = DockStyle.Fill

            Else
                If Not ActiveMdiChild.Equals(Faculty_Registation) Then

                    '---------Hiding Animation---------
                    Student_Registation.srHide.HideSync(Student_Registation.SR)
                    Closing_All()

                    '---------mdi child declare---------
                    Faculty_Registation.Show()
                    Faculty_Registation.MdiParent = Me
                    Faculty_Registation.Dock = DockStyle.Fill

                    '----------making the panel invisible---------
                    Faculty_Registation.FR.Visible = False

                    '----------Entrance animation----------
                    Faculty_Registation.frShow.ShowSync(Faculty_Registation.FR)
                End If

            End If

        Catch ex As Exception
            R_Choice2.Enabled = False
        Finally
            R_Choice2.Enabled = True
        End Try


    End Sub



    Private Sub V_Choice1_Click(sender As Object, e As EventArgs) Handles V_Choice1.Click

        Try

            '-------code for separator line under the button-------
            V_Separator.Left = V_Choice1.Left
            V_Separator.Width = V_Choice1.Width

            If ActiveMdiChild Is Nothing Then

                '---------mdi child declare---------
                Student_View.Show()
                Student_View.MdiParent = Me
                Student_View.Dock = DockStyle.Fill

            Else
                If Not ActiveMdiChild.Equals(Student_View) Then

                    '---------Hiding Animation---------
                    If ActiveMdiChild.Equals(Faculty_view) Then

                        Faculty_view.fvHide.HideSync(Faculty_view.FV)

                    ElseIf ActiveMdiChild.Equals(Book_View) Then

                        Book_View.bvHide.HideSync(Book_View.BV)

                    End If

                    Closing_All()

                    '---------mdi child declare---------
                    Student_View.Show()
                    Student_View.MdiParent = Me
                    Student_View.Dock = DockStyle.Fill


                    '----------making the panel invisible---------
                    Student_View.SV.Visible = False

                    '----------Entrance animation----------
                    Student_View.svShow.ShowSync(Student_View.SV)

                End If

            End If

        Catch ex As Exception
            V_Choice1.Enabled = False

        Finally
            V_Choice1.Enabled = True

        End Try

    End Sub

    Private Sub V_Choice2_Click(sender As Object, e As EventArgs) Handles V_Choice2.Click

        Try

            '-------code for separator line under the button-------
            V_Separator.Left = V_Choice2.Left
            V_Separator.Width = V_Choice2.Width

            If ActiveMdiChild Is Nothing Then

                '---------mdi child declare---------
                Faculty_view.Show()
                Faculty_view.MdiParent = Me
                Faculty_view.Dock = DockStyle.Fill

            Else
                If Not ActiveMdiChild.Equals(Faculty_view) Then

                    '---------Hiding Animation---------
                    If ActiveMdiChild.Equals(Student_View) Then

                        Student_View.svHide.HideSync(Student_View.SV)

                    ElseIf ActiveMdiChild.Equals(Book_View) Then

                        Book_View.bvHide.HideSync(Book_View.BV)

                    End If

                    Closing_All()

                    '---------mdi child declare---------
                    Faculty_view.Show()
                    Faculty_view.MdiParent = Me
                    Faculty_view.Dock = DockStyle.Fill


                    '----------making the panel invisible---------
                    Faculty_view.FV.Visible = False

                    '----------Entrance animation----------
                    Faculty_view.fvShow.ShowSync(Faculty_view.FV)

                End If

            End If

        Catch ex As Exception
            V_Choice2.Enabled = False

        Finally
            V_Choice2.Enabled = True

        End Try

    End Sub

    Private Sub V_Choice3_Click(sender As Object, e As EventArgs) Handles V_Choice3.Click

        Try

            '-------code for separator line under the button-------
            V_Separator.Left = V_Choice3.Left
            V_Separator.Width = V_Choice3.Width

            If ActiveMdiChild Is Nothing Then

                '---------mdi child declare---------
                Book_View.Show()
                Book_View.MdiParent = Me
                Book_View.Dock = DockStyle.Fill

            Else
                If Not ActiveMdiChild.Equals(Book_View) Then

                    '---------Hiding Animation---------
                    If ActiveMdiChild.Equals(Student_View) Then

                        Student_View.svHide.HideSync(Student_View.SV)

                    ElseIf ActiveMdiChild.Equals(Faculty_view) Then

                        Faculty_view.fvHide.HideSync(Faculty_view.FV)

                    End If

                    Closing_All()

                    '---------mdi child declare---------
                    Book_View.Show()
                    Book_View.MdiParent = Me
                    Book_View.Dock = DockStyle.Fill


                    '----------making the panel invisible---------
                    Book_View.BV.Visible = False

                    '----------Entrance animation----------
                    Book_View.bvShow.ShowSync(Book_View.BV)

                End If

            End If

        Catch ex As Exception
            V_Choice3.Enabled = False

        Finally
            V_Choice3.Enabled = True

        End Try

    End Sub


    Private Sub MembersReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MembersReportToolStripMenuItem.Click
        Choose_Button_Invisivle()
        Closing_All()


        '---------mdi child declare---------
        Student_Reoprt.Show()
        Student_Reoprt.MdiParent = Me
        Student_Reoprt.Dock = DockStyle.Fill
    End Sub

    Private Sub FineReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FineReportToolStripMenuItem.Click
        Choose_Button_Invisivle()
        Closing_All()


        '---------mdi child declare---------
        Student_Fine_Report.Show()
        Student_Fine_Report.MdiParent = Me
        Student_Fine_Report.Dock = DockStyle.Fill
    End Sub

    Private Sub IssuedBookReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssuedBookReportToolStripMenuItem.Click
        Choose_Button_Invisivle()
        Closing_All()


        '---------mdi child declare---------
        Student_Issued_Book_Report.Show()
        Student_Issued_Book_Report.MdiParent = Me
        Student_Issued_Book_Report.Dock = DockStyle.Fill
    End Sub

    Private Sub bt_Home_Click(sender As Object, e As EventArgs) Handles bt_Home.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Dashbord.Show()
        Dashbord.MdiParent = Me
        Dashbord.Dock = DockStyle.Fill

    End Sub







    ' --------------------------search bar-------------------------



    Private Function create_space(ByVal l As Integer)


        Dim space_count As String = ""
        For i = 50 - l To 1 Step -1
            space_count = space_count & "  "
        Next

        Return space_count
    End Function

    Sub form_Name_Auto_Complete()


        Try
            con.Open()
            Using com = New MySqlCommand("SELECT display_name FROM forms_db  ", con)

                Using reader = com.ExecuteReader
                    While reader.Read

                        With tb_2

                            .AutoCompleteMode = AutoCompleteMode.Suggest
                            .AutoCompleteCustomSource.Add(reader.Item(0))
                            .AutoCompleteSource = AutoCompleteSource.CustomSource

                        End With

                    End While

                    reader.Close()
                End Using
            End Using



            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub tb_2_TextChanged(sender As Object, e As EventArgs) Handles tb_2.TextChanged
        Dim check As Integer = 0
        Dim a As Form = Nothing
        Try
            con.Open()
            str = "SELECT slno,form_name FROM forms_db WHERE display_name= '" & tb_2.Text & "' "
            com = New MySqlCommand(str, con)
            reader = com.ExecuteReader
            If reader.Read Then

                check = Integer.Parse(reader.GetString("slno"))

                If check <> 0 Then

                    Dim a_type As Type = Type.GetType("Library_Managenemt." & reader.GetString("form_name"))
                    a = CType(Activator.CreateInstance(a_type), Form)


                End If

            End If

            reader.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        If check <> 0 Then
            Try
                Choose_Button_Invisivle()
                Closing_All()

                '---------mdi child declare---------
                a.Show()
                a.MdiParent = Me
                a.Dock = DockStyle.Fill

                tb_2.Text = ""
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub IndivisualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndivisualToolStripMenuItem.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Student_Delete.Show()
        Student_Delete.MdiParent = Me
        Student_Delete.Dock = DockStyle.Fill
    End Sub

    Private Sub BatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BatchToolStripMenuItem.Click
        Choose_Button_Invisivle()
        Closing_All()

        '---------mdi child declare---------
        Student_Delete_Batch.Show()
        Student_Delete_Batch.MdiParent = Me
        Student_Delete_Batch.Dock = DockStyle.Fill
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
