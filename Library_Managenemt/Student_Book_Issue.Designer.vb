﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_Book_Issue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Book_Issue))
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.SBI = New System.Windows.Forms.Panel()
        Me.tb_8 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.dd_1 = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.bt_Issue = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bt_Reset = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lb_11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_10 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_9 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_7 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_6 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_5 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_4 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_3 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.dt_1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuMetroTextbox12 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.sShow = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.sHide = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.SBI.SuspendLayout()
        Me.SuspendLayout()
        '
        'SBI
        '
        Me.SBI.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SBI.BackColor = System.Drawing.Color.White
        Me.SBI.BackgroundImage = CType(resources.GetObject("SBI.BackgroundImage"), System.Drawing.Image)
        Me.SBI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SBI.Controls.Add(Me.tb_8)
        Me.SBI.Controls.Add(Me.dd_1)
        Me.SBI.Controls.Add(Me.BunifuCustomLabel1)
        Me.SBI.Controls.Add(Me.BunifuMetroTextbox1)
        Me.SBI.Controls.Add(Me.bt_Issue)
        Me.SBI.Controls.Add(Me.bt_Reset)
        Me.SBI.Controls.Add(Me.lb_11)
        Me.SBI.Controls.Add(Me.tb_10)
        Me.SBI.Controls.Add(Me.lb_10)
        Me.SBI.Controls.Add(Me.tb_9)
        Me.SBI.Controls.Add(Me.lb_9)
        Me.SBI.Controls.Add(Me.lb_8)
        Me.SBI.Controls.Add(Me.tb_7)
        Me.SBI.Controls.Add(Me.lb_7)
        Me.SBI.Controls.Add(Me.tb_6)
        Me.SBI.Controls.Add(Me.lb_1)
        Me.SBI.Controls.Add(Me.lb_6)
        Me.SBI.Controls.Add(Me.tb_5)
        Me.SBI.Controls.Add(Me.lb_5)
        Me.SBI.Controls.Add(Me.tb_4)
        Me.SBI.Controls.Add(Me.lb_2)
        Me.SBI.Controls.Add(Me.tb_1)
        Me.SBI.Controls.Add(Me.lb_4)
        Me.SBI.Controls.Add(Me.tb_3)
        Me.SBI.Controls.Add(Me.lb_3)
        Me.SBI.Controls.Add(Me.tb_2)
        Me.SBI.Controls.Add(Me.dt_1)
        Me.SBI.Controls.Add(Me.BunifuMetroTextbox12)
        Me.sHide.SetDecoration(Me.SBI, BunifuAnimatorNS.DecorationType.None)
        Me.sShow.SetDecoration(Me.SBI, BunifuAnimatorNS.DecorationType.None)
        Me.SBI.Location = New System.Drawing.Point(25, 29)
        Me.SBI.Name = "SBI"
        Me.SBI.Size = New System.Drawing.Size(782, 434)
        Me.SBI.TabIndex = 58
        '
        'tb_8
        '
        Me.tb_8.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_8.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_8.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_8.BorderThickness = 1
        Me.tb_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sShow.SetDecoration(Me.tb_8, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.tb_8, BunifuAnimatorNS.DecorationType.None)
        Me.tb_8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_8.ForeColor = System.Drawing.Color.Black
        Me.tb_8.isPassword = False
        Me.tb_8.Location = New System.Drawing.Point(40, 68)
        Me.tb_8.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_8.Name = "tb_8"
        Me.tb_8.Size = New System.Drawing.Size(161, 36)
        Me.tb_8.TabIndex = 1
        Me.tb_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dd_1
        '
        Me.sHide.SetDecoration(Me.dd_1, BunifuAnimatorNS.DecorationType.None)
        Me.sShow.SetDecoration(Me.dd_1, BunifuAnimatorNS.DecorationType.None)
        Me.dd_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dd_1.DropDownWidth = 154
        Me.dd_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dd_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_1.ForeColor = System.Drawing.Color.Black
        Me.dd_1.FormattingEnabled = True
        Me.dd_1.IntegralHeight = False
        Me.dd_1.ItemHeight = 21
        Me.dd_1.Location = New System.Drawing.Point(585, 284)
        Me.dd_1.Name = "dd_1"
        Me.dd_1.Size = New System.Drawing.Size(156, 29)
        Me.dd_1.TabIndex = 12
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.sShow.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(579, 260)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(76, 17)
        Me.BunifuCustomLabel1.TabIndex = 71
        Me.BunifuCustomLabel1.Text = "Request ID"
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Gray
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderThickness = 1
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sShow.SetDecoration(Me.BunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.BunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(582, 280)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(161, 36)
        Me.BunifuMetroTextbox1.TabIndex = 70
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bt_Issue
        '
        Me.bt_Issue.ActiveBorderThickness = 1
        Me.bt_Issue.ActiveCornerRadius = 1
        Me.bt_Issue.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Issue.ActiveForecolor = System.Drawing.Color.White
        Me.bt_Issue.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Issue.AutoScroll = True
        Me.bt_Issue.BackColor = System.Drawing.Color.White
        Me.bt_Issue.BackgroundImage = CType(resources.GetObject("bt_Issue.BackgroundImage"), System.Drawing.Image)
        Me.bt_Issue.ButtonText = "ISSUE"
        Me.bt_Issue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sHide.SetDecoration(Me.bt_Issue, BunifuAnimatorNS.DecorationType.None)
        Me.sShow.SetDecoration(Me.bt_Issue, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Issue.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Issue.ForeColor = System.Drawing.Color.White
        Me.bt_Issue.IdleBorderThickness = 1
        Me.bt_Issue.IdleCornerRadius = 1
        Me.bt_Issue.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Issue.IdleForecolor = System.Drawing.Color.White
        Me.bt_Issue.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Issue.Location = New System.Drawing.Point(579, 350)
        Me.bt_Issue.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Issue.Name = "bt_Issue"
        Me.bt_Issue.Size = New System.Drawing.Size(160, 50)
        Me.bt_Issue.TabIndex = 13
        Me.bt_Issue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_Reset
        '
        Me.bt_Reset.ActiveBorderThickness = 1
        Me.bt_Reset.ActiveCornerRadius = 1
        Me.bt_Reset.ActiveFillColor = System.Drawing.Color.White
        Me.bt_Reset.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.AutoScroll = True
        Me.bt_Reset.BackColor = System.Drawing.Color.White
        Me.bt_Reset.BackgroundImage = CType(resources.GetObject("bt_Reset.BackgroundImage"), System.Drawing.Image)
        Me.bt_Reset.ButtonText = "RESET"
        Me.bt_Reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sHide.SetDecoration(Me.bt_Reset, BunifuAnimatorNS.DecorationType.None)
        Me.sShow.SetDecoration(Me.bt_Reset, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Reset.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.IdleBorderThickness = 1
        Me.bt_Reset.IdleCornerRadius = 1
        Me.bt_Reset.IdleFillColor = System.Drawing.Color.White
        Me.bt_Reset.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.Location = New System.Drawing.Point(452, 350)
        Me.bt_Reset.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Reset.Name = "bt_Reset"
        Me.bt_Reset.Size = New System.Drawing.Size(115, 50)
        Me.bt_Reset.TabIndex = 14
        Me.bt_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_11
        '
        Me.lb_11.AutoSize = True
        Me.sShow.SetDecoration(Me.lb_11, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.lb_11, BunifuAnimatorNS.DecorationType.None)
        Me.lb_11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_11.ForeColor = System.Drawing.Color.Black
        Me.lb_11.Location = New System.Drawing.Point(579, 48)
        Me.lb_11.Name = "lb_11"
        Me.lb_11.Size = New System.Drawing.Size(86, 17)
        Me.lb_11.TabIndex = 65
        Me.lb_11.Text = "Books Taken"
        '
        'tb_10
        '
        Me.tb_10.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_10.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_10.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_10.BorderThickness = 1
        Me.tb_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sShow.SetDecoration(Me.tb_10, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.tb_10, BunifuAnimatorNS.DecorationType.None)
        Me.tb_10.Enabled = False
        Me.tb_10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_10.ForeColor = System.Drawing.Color.Black
        Me.tb_10.isPassword = False
        Me.tb_10.Location = New System.Drawing.Point(579, 68)
        Me.tb_10.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_10.Name = "tb_10"
        Me.tb_10.Size = New System.Drawing.Size(161, 36)
        Me.tb_10.TabIndex = 3
        Me.tb_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_10
        '
        Me.lb_10.AutoSize = True
        Me.sShow.SetDecoration(Me.lb_10, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.lb_10, BunifuAnimatorNS.DecorationType.None)
        Me.lb_10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_10.ForeColor = System.Drawing.Color.Black
        Me.lb_10.Location = New System.Drawing.Point(220, 48)
        Me.lb_10.Name = "lb_10"
        Me.lb_10.Size = New System.Drawing.Size(101, 17)
        Me.lb_10.TabIndex = 63
        Me.lb_10.Text = "Student Name"
        '
        'tb_9
        '
        Me.tb_9.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_9.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_9.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_9.BorderThickness = 1
        Me.tb_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sShow.SetDecoration(Me.tb_9, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.tb_9, BunifuAnimatorNS.DecorationType.None)
        Me.tb_9.Enabled = False
        Me.tb_9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_9.ForeColor = System.Drawing.Color.Black
        Me.tb_9.isPassword = False
        Me.tb_9.Location = New System.Drawing.Point(220, 68)
        Me.tb_9.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_9.Name = "tb_9"
        Me.tb_9.Size = New System.Drawing.Size(340, 36)
        Me.tb_9.TabIndex = 2
        Me.tb_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_9
        '
        Me.lb_9.AutoSize = True
        Me.sShow.SetDecoration(Me.lb_9, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.lb_9, BunifuAnimatorNS.DecorationType.None)
        Me.lb_9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_9.ForeColor = System.Drawing.Color.Black
        Me.lb_9.Location = New System.Drawing.Point(40, 48)
        Me.lb_9.Name = "lb_9"
        Me.lb_9.Size = New System.Drawing.Size(111, 17)
        Me.lb_9.TabIndex = 61
        Me.lb_9.Text = "Student Roll No."
        '
        'lb_8
        '
        Me.lb_8.AutoSize = True
        Me.sShow.SetDecoration(Me.lb_8, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.lb_8, BunifuAnimatorNS.DecorationType.None)
        Me.lb_8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_8.ForeColor = System.Drawing.Color.Black
        Me.lb_8.Location = New System.Drawing.Point(579, 187)
        Me.lb_8.Name = "lb_8"
        Me.lb_8.Size = New System.Drawing.Size(107, 17)
        Me.lb_8.TabIndex = 59
        Me.lb_8.Text = "Avalable Books"
        '
        'tb_7
        '
        Me.tb_7.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_7.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_7.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_7.BorderThickness = 1
        Me.tb_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sShow.SetDecoration(Me.tb_7, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.tb_7, BunifuAnimatorNS.DecorationType.None)
        Me.tb_7.Enabled = False
        Me.tb_7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_7.ForeColor = System.Drawing.Color.Black
        Me.tb_7.isPassword = False
        Me.tb_7.Location = New System.Drawing.Point(582, 207)
        Me.tb_7.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_7.Name = "tb_7"
        Me.tb_7.Size = New System.Drawing.Size(161, 36)
        Me.tb_7.TabIndex = 9
        Me.tb_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_7
        '
        Me.lb_7.AutoSize = True
        Me.sShow.SetDecoration(Me.lb_7, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.lb_7, BunifuAnimatorNS.DecorationType.None)
        Me.lb_7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_7.ForeColor = System.Drawing.Color.Black
        Me.lb_7.Location = New System.Drawing.Point(400, 187)
        Me.lb_7.Name = "lb_7"
        Me.lb_7.Size = New System.Drawing.Size(80, 17)
        Me.lb_7.TabIndex = 57
        Me.lb_7.Text = "Total Books"
        '
        'tb_6
        '
        Me.tb_6.BorderColorFocused = System.Drawing.Color.Maroon
        Me.tb_6.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_6.BorderColorMouseHover = System.Drawing.Color.Maroon
        Me.tb_6.BorderThickness = 1
        Me.tb_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sShow.SetDecoration(Me.tb_6, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.tb_6, BunifuAnimatorNS.DecorationType.None)
        Me.tb_6.Enabled = False
        Me.tb_6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_6.ForeColor = System.Drawing.Color.Black
        Me.tb_6.isPassword = False
        Me.tb_6.Location = New System.Drawing.Point(400, 207)
        Me.tb_6.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_6.Name = "tb_6"
        Me.tb_6.Size = New System.Drawing.Size(161, 36)
        Me.tb_6.TabIndex = 8
        Me.tb_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.sShow.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.lb_1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_1.ForeColor = System.Drawing.Color.Black
        Me.lb_1.Location = New System.Drawing.Point(40, 261)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(73, 17)
        Me.lb_1.TabIndex = 39
        Me.lb_1.Text = "Issue Date"
        '
        'lb_6
        '
        Me.lb_6.AutoSize = True
        Me.sShow.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.lb_6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_6.ForeColor = System.Drawing.Color.Black
        Me.lb_6.Location = New System.Drawing.Point(220, 187)
        Me.lb_6.Name = "lb_6"
        Me.lb_6.Size = New System.Drawing.Size(108, 17)
        Me.lb_6.TabIndex = 37
        Me.lb_6.Text = "Volume/Edition"
        '
        'tb_5
        '
        Me.tb_5.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_5.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_5.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_5.BorderThickness = 1
        Me.tb_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sShow.SetDecoration(Me.tb_5, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.tb_5, BunifuAnimatorNS.DecorationType.None)
        Me.tb_5.Enabled = False
        Me.tb_5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_5.ForeColor = System.Drawing.Color.Black
        Me.tb_5.isPassword = False
        Me.tb_5.Location = New System.Drawing.Point(220, 207)
        Me.tb_5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_5.Name = "tb_5"
        Me.tb_5.Size = New System.Drawing.Size(160, 36)
        Me.tb_5.TabIndex = 7
        Me.tb_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_5
        '
        Me.lb_5.AutoSize = True
        Me.sShow.SetDecoration(Me.lb_5, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.lb_5, BunifuAnimatorNS.DecorationType.None)
        Me.lb_5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_5.ForeColor = System.Drawing.Color.Black
        Me.lb_5.Location = New System.Drawing.Point(40, 187)
        Me.lb_5.Name = "lb_5"
        Me.lb_5.Size = New System.Drawing.Size(61, 17)
        Me.lb_5.TabIndex = 16
        Me.lb_5.Text = "ISBN No."
        '
        'tb_4
        '
        Me.tb_4.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_4.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_4.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_4.BorderThickness = 1
        Me.tb_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sShow.SetDecoration(Me.tb_4, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.tb_4, BunifuAnimatorNS.DecorationType.None)
        Me.tb_4.Enabled = False
        Me.tb_4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_4.ForeColor = System.Drawing.Color.Black
        Me.tb_4.isPassword = False
        Me.tb_4.Location = New System.Drawing.Point(40, 207)
        Me.tb_4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_4.Name = "tb_4"
        Me.tb_4.Size = New System.Drawing.Size(161, 36)
        Me.tb_4.TabIndex = 6
        Me.tb_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_2
        '
        Me.lb_2.AutoSize = True
        Me.sShow.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.lb_2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.ForeColor = System.Drawing.Color.Black
        Me.lb_2.Location = New System.Drawing.Point(220, 260)
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Size = New System.Drawing.Size(67, 17)
        Me.lb_2.TabIndex = 14
        Me.lb_2.Text = "Book No."
        '
        'tb_1
        '
        Me.tb_1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderThickness = 1
        Me.tb_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sShow.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
        Me.tb_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_1.ForeColor = System.Drawing.Color.Black
        Me.tb_1.isPassword = False
        Me.tb_1.Location = New System.Drawing.Point(220, 280)
        Me.tb_1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_1.Name = "tb_1"
        Me.tb_1.Size = New System.Drawing.Size(340, 36)
        Me.tb_1.TabIndex = 11
        Me.tb_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_4
        '
        Me.lb_4.AutoSize = True
        Me.sShow.SetDecoration(Me.lb_4, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.lb_4, BunifuAnimatorNS.DecorationType.None)
        Me.lb_4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_4.ForeColor = System.Drawing.Color.Black
        Me.lb_4.Location = New System.Drawing.Point(400, 116)
        Me.lb_4.Name = "lb_4"
        Me.lb_4.Size = New System.Drawing.Size(95, 17)
        Me.lb_4.TabIndex = 12
        Me.lb_4.Text = "Author Name"
        '
        'tb_3
        '
        Me.tb_3.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_3.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_3.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_3.BorderThickness = 1
        Me.tb_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sShow.SetDecoration(Me.tb_3, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.tb_3, BunifuAnimatorNS.DecorationType.None)
        Me.tb_3.Enabled = False
        Me.tb_3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_3.ForeColor = System.Drawing.Color.Black
        Me.tb_3.isPassword = False
        Me.tb_3.Location = New System.Drawing.Point(400, 136)
        Me.tb_3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_3.Name = "tb_3"
        Me.tb_3.Size = New System.Drawing.Size(340, 36)
        Me.tb_3.TabIndex = 5
        Me.tb_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_3
        '
        Me.lb_3.AutoSize = True
        Me.sShow.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.lb_3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_3.ForeColor = System.Drawing.Color.Black
        Me.lb_3.Location = New System.Drawing.Point(40, 116)
        Me.lb_3.Name = "lb_3"
        Me.lb_3.Size = New System.Drawing.Size(68, 17)
        Me.lb_3.TabIndex = 10
        Me.lb_3.Text = "Book Title"
        '
        'tb_2
        '
        Me.tb_2.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderThickness = 1
        Me.tb_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sShow.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.tb_2.Enabled = False
        Me.tb_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_2.ForeColor = System.Drawing.Color.Black
        Me.tb_2.isPassword = False
        Me.tb_2.Location = New System.Drawing.Point(40, 136)
        Me.tb_2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_2.Name = "tb_2"
        Me.tb_2.Size = New System.Drawing.Size(340, 36)
        Me.tb_2.TabIndex = 4
        Me.tb_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dt_1
        '
        Me.dt_1.BackColor = System.Drawing.Color.White
        Me.dt_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dt_1.BorderRadius = 0
        Me.sHide.SetDecoration(Me.dt_1, BunifuAnimatorNS.DecorationType.None)
        Me.sShow.SetDecoration(Me.dt_1, BunifuAnimatorNS.DecorationType.None)
        Me.dt_1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_1.ForeColor = System.Drawing.Color.Black
        Me.dt_1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_1.FormatCustom = ""
        Me.dt_1.Location = New System.Drawing.Point(43, 282)
        Me.dt_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dt_1.Name = "dt_1"
        Me.dt_1.Size = New System.Drawing.Size(158, 34)
        Me.dt_1.TabIndex = 10
        Me.dt_1.Value = New Date(2018, 1, 15, 0, 0, 0, 0)
        '
        'BunifuMetroTextbox12
        '
        Me.BunifuMetroTextbox12.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox12.BorderColorIdle = System.Drawing.Color.Gray
        Me.BunifuMetroTextbox12.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox12.BorderThickness = 1
        Me.BunifuMetroTextbox12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sShow.SetDecoration(Me.BunifuMetroTextbox12, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me.BunifuMetroTextbox12, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMetroTextbox12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox12.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox12.isPassword = False
        Me.BunifuMetroTextbox12.Location = New System.Drawing.Point(41, 280)
        Me.BunifuMetroTextbox12.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextbox12.Name = "BunifuMetroTextbox12"
        Me.BunifuMetroTextbox12.Size = New System.Drawing.Size(160, 36)
        Me.BunifuMetroTextbox12.TabIndex = 52
        Me.BunifuMetroTextbox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'sShow
        '
        Me.sShow.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.sShow.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.sShow.DefaultAnimation = Animation1
        '
        'sHide
        '
        Me.sHide.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.sHide.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.sHide.DefaultAnimation = Animation2
        '
        'Student_Book_Issue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 591)
        Me.Controls.Add(Me.SBI)
        Me.sShow.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.sHide.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-1000, -1000)
        Me.Name = "Student_Book_Issue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Student Book Issue"
        Me.SBI.ResumeLayout(False)
        Me.SBI.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SBI As Panel
    Friend WithEvents lb_11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_10 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_9 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_7 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_6 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_5 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_4 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_3 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents dt_1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuMetroTextbox12 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents sShow As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents sHide As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents bt_Issue As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bt_Reset As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents dd_1 As ComboBox
    Friend WithEvents tb_8 As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
