﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Faculty_Edit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Faculty_Edit))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.FE = New System.Windows.Forms.Panel()
        Me.dd_2 = New System.Windows.Forms.ComboBox()
        Me.BunifuMetroTextbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bt_Save = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bt_Reset = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.tb_3 = New System.Windows.Forms.TextBox()
        Me.lb_6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_4 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_5 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.dd_1 = New System.Windows.Forms.ComboBox()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.dt_1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuMetroTextbox8 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.feShow = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.feHide = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.FE.SuspendLayout()
        Me.SuspendLayout()
        '
        'FE
        '
        Me.FE.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FE.BackgroundImage = CType(resources.GetObject("FE.BackgroundImage"), System.Drawing.Image)
        Me.FE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FE.Controls.Add(Me.dd_2)
        Me.FE.Controls.Add(Me.BunifuMetroTextbox2)
        Me.FE.Controls.Add(Me.BunifuCustomLabel1)
        Me.FE.Controls.Add(Me.bt_Save)
        Me.FE.Controls.Add(Me.bt_Reset)
        Me.FE.Controls.Add(Me.tb_3)
        Me.FE.Controls.Add(Me.lb_6)
        Me.FE.Controls.Add(Me.tb_4)
        Me.FE.Controls.Add(Me.lb_7)
        Me.FE.Controls.Add(Me.tb_5)
        Me.FE.Controls.Add(Me.lb_4)
        Me.FE.Controls.Add(Me.lb_5)
        Me.FE.Controls.Add(Me.lb_3)
        Me.FE.Controls.Add(Me.lb_2)
        Me.FE.Controls.Add(Me.tb_2)
        Me.FE.Controls.Add(Me.lb_1)
        Me.FE.Controls.Add(Me.tb_1)
        Me.FE.Controls.Add(Me.dd_1)
        Me.FE.Controls.Add(Me.BunifuMetroTextbox1)
        Me.FE.Controls.Add(Me.dt_1)
        Me.FE.Controls.Add(Me.BunifuMetroTextbox8)
        Me.feHide.SetDecoration(Me.FE, BunifuAnimatorNS.DecorationType.None)
        Me.feShow.SetDecoration(Me.FE, BunifuAnimatorNS.DecorationType.None)
        Me.FE.Location = New System.Drawing.Point(25, 33)
        Me.FE.Name = "FE"
        Me.FE.Size = New System.Drawing.Size(782, 434)
        Me.FE.TabIndex = 79
        '
        'dd_2
        '
        Me.feHide.SetDecoration(Me.dd_2, BunifuAnimatorNS.DecorationType.None)
        Me.feShow.SetDecoration(Me.dd_2, BunifuAnimatorNS.DecorationType.None)
        Me.dd_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dd_2.DropDownWidth = 154
        Me.dd_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dd_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_2.ForeColor = System.Drawing.Color.Black
        Me.dd_2.FormattingEnabled = True
        Me.dd_2.IntegralHeight = False
        Me.dd_2.ItemHeight = 21
        Me.dd_2.Items.AddRange(New Object() {"A+ve", "B+ve", "A-ve", "B-ve", "O+ve", "O-ve", "AB+ve", "AB-ve"})
        Me.dd_2.Location = New System.Drawing.Point(582, 142)
        Me.dd_2.Name = "dd_2"
        Me.dd_2.Size = New System.Drawing.Size(156, 29)
        Me.dd_2.TabIndex = 6
        '
        'BunifuMetroTextbox2
        '
        Me.BunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.Gray
        Me.BunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderThickness = 1
        Me.BunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.feShow.SetDecoration(Me.BunifuMetroTextbox2, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.BunifuMetroTextbox2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMetroTextbox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox2.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox2.isPassword = False
        Me.BunifuMetroTextbox2.Location = New System.Drawing.Point(580, 138)
        Me.BunifuMetroTextbox2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextbox2.Name = "BunifuMetroTextbox2"
        Me.BunifuMetroTextbox2.Size = New System.Drawing.Size(160, 36)
        Me.BunifuMetroTextbox2.TabIndex = 85
        Me.BunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.feShow.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(220, 45)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(88, 17)
        Me.BunifuCustomLabel1.TabIndex = 81
        Me.BunifuCustomLabel1.Text = "Date of Birth"
        '
        'bt_Save
        '
        Me.bt_Save.ActiveBorderThickness = 1
        Me.bt_Save.ActiveCornerRadius = 1
        Me.bt_Save.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Save.ActiveForecolor = System.Drawing.Color.White
        Me.bt_Save.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Save.AutoScroll = True
        Me.bt_Save.BackColor = System.Drawing.Color.White
        Me.bt_Save.BackgroundImage = CType(resources.GetObject("bt_Save.BackgroundImage"), System.Drawing.Image)
        Me.bt_Save.ButtonText = "SAVE"
        Me.bt_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.feHide.SetDecoration(Me.bt_Save, BunifuAnimatorNS.DecorationType.None)
        Me.feShow.SetDecoration(Me.bt_Save, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Save.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Save.ForeColor = System.Drawing.Color.White
        Me.bt_Save.IdleBorderThickness = 1
        Me.bt_Save.IdleCornerRadius = 1
        Me.bt_Save.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Save.IdleForecolor = System.Drawing.Color.White
        Me.bt_Save.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Save.Location = New System.Drawing.Point(551, 348)
        Me.bt_Save.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Save.Name = "bt_Save"
        Me.bt_Save.Size = New System.Drawing.Size(160, 50)
        Me.bt_Save.TabIndex = 9
        Me.bt_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.feHide.SetDecoration(Me.bt_Reset, BunifuAnimatorNS.DecorationType.None)
        Me.feShow.SetDecoration(Me.bt_Reset, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Reset.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.IdleBorderThickness = 1
        Me.bt_Reset.IdleCornerRadius = 1
        Me.bt_Reset.IdleFillColor = System.Drawing.Color.White
        Me.bt_Reset.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.Location = New System.Drawing.Point(424, 348)
        Me.bt_Reset.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Reset.Name = "bt_Reset"
        Me.bt_Reset.Size = New System.Drawing.Size(115, 50)
        Me.bt_Reset.TabIndex = 10
        Me.bt_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_3
        '
        Me.feShow.SetDecoration(Me.tb_3, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.tb_3, BunifuAnimatorNS.DecorationType.None)
        Me.tb_3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_3.Location = New System.Drawing.Point(40, 136)
        Me.tb_3.Multiline = True
        Me.tb_3.Name = "tb_3"
        Me.tb_3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.tb_3.Size = New System.Drawing.Size(340, 107)
        Me.tb_3.TabIndex = 4
        '
        'lb_6
        '
        Me.lb_6.AutoSize = True
        Me.feShow.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.lb_6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_6.ForeColor = System.Drawing.Color.Black
        Me.lb_6.Location = New System.Drawing.Point(400, 187)
        Me.lb_6.Name = "lb_6"
        Me.lb_6.Size = New System.Drawing.Size(64, 17)
        Me.lb_6.TabIndex = 70
        Me.lb_6.Text = "E-mail ID"
        '
        'tb_4
        '
        Me.tb_4.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_4.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_4.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_4.BorderThickness = 1
        Me.tb_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.feShow.SetDecoration(Me.tb_4, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.tb_4, BunifuAnimatorNS.DecorationType.None)
        Me.tb_4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_4.ForeColor = System.Drawing.Color.Black
        Me.tb_4.isPassword = False
        Me.tb_4.Location = New System.Drawing.Point(400, 207)
        Me.tb_4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_4.Name = "tb_4"
        Me.tb_4.Size = New System.Drawing.Size(340, 36)
        Me.tb_4.TabIndex = 7
        Me.tb_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_7
        '
        Me.lb_7.AutoSize = True
        Me.feShow.SetDecoration(Me.lb_7, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.lb_7, BunifuAnimatorNS.DecorationType.None)
        Me.lb_7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_7.ForeColor = System.Drawing.Color.Black
        Me.lb_7.Location = New System.Drawing.Point(40, 259)
        Me.lb_7.Name = "lb_7"
        Me.lb_7.Size = New System.Drawing.Size(51, 17)
        Me.lb_7.TabIndex = 68
        Me.lb_7.Text = "Mobile"
        '
        'tb_5
        '
        Me.tb_5.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_5.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_5.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_5.BorderThickness = 1
        Me.tb_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.feShow.SetDecoration(Me.tb_5, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.tb_5, BunifuAnimatorNS.DecorationType.None)
        Me.tb_5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_5.ForeColor = System.Drawing.Color.Black
        Me.tb_5.isPassword = False
        Me.tb_5.Location = New System.Drawing.Point(40, 279)
        Me.tb_5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_5.Name = "tb_5"
        Me.tb_5.Size = New System.Drawing.Size(340, 36)
        Me.tb_5.TabIndex = 8
        Me.tb_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_4
        '
        Me.lb_4.AutoSize = True
        Me.feShow.SetDecoration(Me.lb_4, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.lb_4, BunifuAnimatorNS.DecorationType.None)
        Me.lb_4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_4.ForeColor = System.Drawing.Color.Black
        Me.lb_4.Location = New System.Drawing.Point(400, 116)
        Me.lb_4.Name = "lb_4"
        Me.lb_4.Size = New System.Drawing.Size(85, 17)
        Me.lb_4.TabIndex = 66
        Me.lb_4.Text = "Designation"
        '
        'lb_5
        '
        Me.lb_5.AutoSize = True
        Me.feShow.SetDecoration(Me.lb_5, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.lb_5, BunifuAnimatorNS.DecorationType.None)
        Me.lb_5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_5.ForeColor = System.Drawing.Color.Black
        Me.lb_5.Location = New System.Drawing.Point(580, 116)
        Me.lb_5.Name = "lb_5"
        Me.lb_5.Size = New System.Drawing.Size(88, 17)
        Me.lb_5.TabIndex = 62
        Me.lb_5.Text = "Blood group"
        '
        'lb_3
        '
        Me.lb_3.AutoSize = True
        Me.feShow.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.lb_3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_3.ForeColor = System.Drawing.Color.Black
        Me.lb_3.Location = New System.Drawing.Point(40, 116)
        Me.lb_3.Name = "lb_3"
        Me.lb_3.Size = New System.Drawing.Size(57, 17)
        Me.lb_3.TabIndex = 60
        Me.lb_3.Text = "Address"
        '
        'lb_2
        '
        Me.lb_2.AutoSize = True
        Me.feShow.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.lb_2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.ForeColor = System.Drawing.Color.Black
        Me.lb_2.Location = New System.Drawing.Point(400, 45)
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Size = New System.Drawing.Size(48, 17)
        Me.lb_2.TabIndex = 58
        Me.lb_2.Text = "Name"
        '
        'tb_2
        '
        Me.tb_2.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderThickness = 1
        Me.tb_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.feShow.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.tb_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_2.ForeColor = System.Drawing.Color.Black
        Me.tb_2.isPassword = False
        Me.tb_2.Location = New System.Drawing.Point(400, 65)
        Me.tb_2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_2.Name = "tb_2"
        Me.tb_2.Size = New System.Drawing.Size(340, 36)
        Me.tb_2.TabIndex = 3
        Me.tb_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.feShow.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.lb_1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_1.ForeColor = System.Drawing.Color.Black
        Me.lb_1.Location = New System.Drawing.Point(40, 45)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(70, 17)
        Me.lb_1.TabIndex = 56
        Me.lb_1.Text = "Faculty ID"
        '
        'tb_1
        '
        Me.tb_1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderThickness = 1
        Me.tb_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.feShow.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
        Me.tb_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_1.ForeColor = System.Drawing.Color.Black
        Me.tb_1.isPassword = False
        Me.tb_1.Location = New System.Drawing.Point(40, 65)
        Me.tb_1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_1.Name = "tb_1"
        Me.tb_1.Size = New System.Drawing.Size(160, 36)
        Me.tb_1.TabIndex = 1
        Me.tb_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dd_1
        '
        Me.feHide.SetDecoration(Me.dd_1, BunifuAnimatorNS.DecorationType.None)
        Me.feShow.SetDecoration(Me.dd_1, BunifuAnimatorNS.DecorationType.None)
        Me.dd_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dd_1.DropDownWidth = 154
        Me.dd_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dd_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_1.ForeColor = System.Drawing.Color.Black
        Me.dd_1.FormattingEnabled = True
        Me.dd_1.IntegralHeight = False
        Me.dd_1.ItemHeight = 21
        Me.dd_1.Items.AddRange(New Object() {"Professor", "Associate Proffessor", "Assistant Proffessor", "Demonstrator", "Techinical Assistant", "Librarian"})
        Me.dd_1.Location = New System.Drawing.Point(402, 140)
        Me.dd_1.Name = "dd_1"
        Me.dd_1.Size = New System.Drawing.Size(156, 29)
        Me.dd_1.TabIndex = 83
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Gray
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderThickness = 1
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.feShow.SetDecoration(Me.BunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.BunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(400, 136)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(160, 36)
        Me.BunifuMetroTextbox1.TabIndex = 84
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dt_1
        '
        Me.dt_1.BackColor = System.Drawing.Color.White
        Me.dt_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dt_1.BorderRadius = 0
        Me.feHide.SetDecoration(Me.dt_1, BunifuAnimatorNS.DecorationType.None)
        Me.feShow.SetDecoration(Me.dt_1, BunifuAnimatorNS.DecorationType.None)
        Me.dt_1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_1.ForeColor = System.Drawing.Color.Black
        Me.dt_1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_1.FormatCustom = "yyyy-MM-dd"
        Me.dt_1.Location = New System.Drawing.Point(222, 67)
        Me.dt_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dt_1.Name = "dt_1"
        Me.dt_1.Size = New System.Drawing.Size(158, 34)
        Me.dt_1.TabIndex = 2
        Me.dt_1.Value = New Date(2018, 3, 31, 0, 0, 0, 0)
        '
        'BunifuMetroTextbox8
        '
        Me.BunifuMetroTextbox8.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox8.BorderColorIdle = System.Drawing.Color.Gray
        Me.BunifuMetroTextbox8.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox8.BorderThickness = 1
        Me.BunifuMetroTextbox8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.feShow.SetDecoration(Me.BunifuMetroTextbox8, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me.BunifuMetroTextbox8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMetroTextbox8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox8.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox8.isPassword = False
        Me.BunifuMetroTextbox8.Location = New System.Drawing.Point(220, 65)
        Me.BunifuMetroTextbox8.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextbox8.Name = "BunifuMetroTextbox8"
        Me.BunifuMetroTextbox8.Size = New System.Drawing.Size(160, 36)
        Me.BunifuMetroTextbox8.TabIndex = 82
        Me.BunifuMetroTextbox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'feShow
        '
        Me.feShow.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.feShow.Cursor = Nothing
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
        Me.feShow.DefaultAnimation = Animation2
        '
        'feHide
        '
        Me.feHide.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.feHide.Cursor = Nothing
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
        Me.feHide.DefaultAnimation = Animation1
        '
        'Faculty_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 591)
        Me.Controls.Add(Me.FE)
        Me.feShow.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.feHide.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-1000, -1000)
        Me.Name = "Faculty_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Faculty Edit"
        Me.FE.ResumeLayout(False)
        Me.FE.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FE As Panel
    Friend WithEvents tb_3 As TextBox
    Friend WithEvents lb_6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_4 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_5 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents feHide As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents feShow As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents bt_Save As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bt_Reset As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dd_1 As ComboBox
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents dd_2 As ComboBox
    Friend WithEvents BunifuMetroTextbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents dt_1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuMetroTextbox8 As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
