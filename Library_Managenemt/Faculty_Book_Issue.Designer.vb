<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Faculty_Book_Issue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Faculty_Book_Issue))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.FBI = New System.Windows.Forms.Panel()
        Me.bt_Confirm = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bt_Reset = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lb_11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_10 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_9 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_8 = New Bunifu.Framework.UI.BunifuMetroTextbox()
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
        Me.tb_0 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.fbrShow = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.fbiHide = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.FBI.SuspendLayout()
        Me.SuspendLayout()
        '
        'FBI
        '
        Me.FBI.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FBI.BackgroundImage = CType(resources.GetObject("FBI.BackgroundImage"), System.Drawing.Image)
        Me.FBI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FBI.Controls.Add(Me.bt_Confirm)
        Me.FBI.Controls.Add(Me.bt_Reset)
        Me.FBI.Controls.Add(Me.lb_11)
        Me.FBI.Controls.Add(Me.tb_10)
        Me.FBI.Controls.Add(Me.lb_10)
        Me.FBI.Controls.Add(Me.tb_9)
        Me.FBI.Controls.Add(Me.lb_9)
        Me.FBI.Controls.Add(Me.tb_8)
        Me.FBI.Controls.Add(Me.lb_1)
        Me.FBI.Controls.Add(Me.lb_6)
        Me.FBI.Controls.Add(Me.tb_5)
        Me.FBI.Controls.Add(Me.lb_5)
        Me.FBI.Controls.Add(Me.tb_4)
        Me.FBI.Controls.Add(Me.lb_2)
        Me.FBI.Controls.Add(Me.tb_1)
        Me.FBI.Controls.Add(Me.lb_4)
        Me.FBI.Controls.Add(Me.tb_3)
        Me.FBI.Controls.Add(Me.lb_3)
        Me.FBI.Controls.Add(Me.tb_2)
        Me.FBI.Controls.Add(Me.dt_1)
        Me.FBI.Controls.Add(Me.tb_0)
        Me.fbiHide.SetDecoration(Me.FBI, BunifuAnimatorNS.DecorationType.None)
        Me.fbrShow.SetDecoration(Me.FBI, BunifuAnimatorNS.DecorationType.None)
        Me.FBI.Location = New System.Drawing.Point(25, 26)
        Me.FBI.Margin = New System.Windows.Forms.Padding(0)
        Me.FBI.Name = "FBI"
        Me.FBI.Size = New System.Drawing.Size(782, 396)
        Me.FBI.TabIndex = 59
        '
        'bt_Confirm
        '
        Me.bt_Confirm.ActiveBorderThickness = 1
        Me.bt_Confirm.ActiveCornerRadius = 1
        Me.bt_Confirm.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Confirm.ActiveForecolor = System.Drawing.Color.White
        Me.bt_Confirm.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Confirm.AutoScroll = True
        Me.bt_Confirm.BackColor = System.Drawing.Color.White
        Me.bt_Confirm.BackgroundImage = CType(resources.GetObject("bt_Confirm.BackgroundImage"), System.Drawing.Image)
        Me.bt_Confirm.ButtonText = "ISSUE"
        Me.bt_Confirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fbiHide.SetDecoration(Me.bt_Confirm, BunifuAnimatorNS.DecorationType.None)
        Me.fbrShow.SetDecoration(Me.bt_Confirm, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Confirm.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Confirm.ForeColor = System.Drawing.Color.White
        Me.bt_Confirm.IdleBorderThickness = 1
        Me.bt_Confirm.IdleCornerRadius = 1
        Me.bt_Confirm.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Confirm.IdleForecolor = System.Drawing.Color.White
        Me.bt_Confirm.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Confirm.Location = New System.Drawing.Point(578, 311)
        Me.bt_Confirm.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Confirm.Name = "bt_Confirm"
        Me.bt_Confirm.Size = New System.Drawing.Size(160, 50)
        Me.bt_Confirm.TabIndex = 4
        Me.bt_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.fbiHide.SetDecoration(Me.bt_Reset, BunifuAnimatorNS.DecorationType.None)
        Me.fbrShow.SetDecoration(Me.bt_Reset, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Reset.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.IdleBorderThickness = 1
        Me.bt_Reset.IdleCornerRadius = 1
        Me.bt_Reset.IdleFillColor = System.Drawing.Color.White
        Me.bt_Reset.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.Location = New System.Drawing.Point(451, 311)
        Me.bt_Reset.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Reset.Name = "bt_Reset"
        Me.bt_Reset.Size = New System.Drawing.Size(115, 50)
        Me.bt_Reset.TabIndex = 5
        Me.bt_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_11
        '
        Me.lb_11.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_11, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.lb_11, BunifuAnimatorNS.DecorationType.None)
        Me.lb_11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_11.ForeColor = System.Drawing.Color.Black
        Me.lb_11.Location = New System.Drawing.Point(578, 208)
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
        Me.fbrShow.SetDecoration(Me.tb_10, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.tb_10, BunifuAnimatorNS.DecorationType.None)
        Me.tb_10.Enabled = False
        Me.tb_10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_10.ForeColor = System.Drawing.Color.Black
        Me.tb_10.isPassword = False
        Me.tb_10.Location = New System.Drawing.Point(578, 228)
        Me.tb_10.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_10.Name = "tb_10"
        Me.tb_10.Size = New System.Drawing.Size(161, 36)
        Me.tb_10.TabIndex = 64
        Me.tb_10.TabStop = False
        Me.tb_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_10
        '
        Me.lb_10.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_10, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.lb_10, BunifuAnimatorNS.DecorationType.None)
        Me.lb_10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_10.ForeColor = System.Drawing.Color.Black
        Me.lb_10.Location = New System.Drawing.Point(219, 208)
        Me.lb_10.Name = "lb_10"
        Me.lb_10.Size = New System.Drawing.Size(97, 17)
        Me.lb_10.TabIndex = 63
        Me.lb_10.Text = "Faculty Name"
        '
        'tb_9
        '
        Me.tb_9.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_9.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_9.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_9.BorderThickness = 1
        Me.tb_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fbrShow.SetDecoration(Me.tb_9, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.tb_9, BunifuAnimatorNS.DecorationType.None)
        Me.tb_9.Enabled = False
        Me.tb_9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_9.ForeColor = System.Drawing.Color.Black
        Me.tb_9.isPassword = False
        Me.tb_9.Location = New System.Drawing.Point(219, 228)
        Me.tb_9.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_9.Name = "tb_9"
        Me.tb_9.Size = New System.Drawing.Size(340, 36)
        Me.tb_9.TabIndex = 62
        Me.tb_9.TabStop = False
        Me.tb_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_9
        '
        Me.lb_9.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_9, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.lb_9, BunifuAnimatorNS.DecorationType.None)
        Me.lb_9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_9.ForeColor = System.Drawing.Color.Black
        Me.lb_9.Location = New System.Drawing.Point(39, 208)
        Me.lb_9.Name = "lb_9"
        Me.lb_9.Size = New System.Drawing.Size(70, 17)
        Me.lb_9.TabIndex = 61
        Me.lb_9.Text = "Faculty ID"
        '
        'tb_8
        '
        Me.tb_8.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_8.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_8.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_8.BorderThickness = 1
        Me.tb_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fbrShow.SetDecoration(Me.tb_8, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.tb_8, BunifuAnimatorNS.DecorationType.None)
        Me.tb_8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_8.ForeColor = System.Drawing.Color.Black
        Me.tb_8.isPassword = False
        Me.tb_8.Location = New System.Drawing.Point(39, 228)
        Me.tb_8.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_8.Name = "tb_8"
        Me.tb_8.Size = New System.Drawing.Size(161, 36)
        Me.tb_8.TabIndex = 3
        Me.tb_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.lb_1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_1.ForeColor = System.Drawing.Color.Black
        Me.lb_1.Location = New System.Drawing.Point(40, 53)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(73, 17)
        Me.lb_1.TabIndex = 39
        Me.lb_1.Text = "Issue Date"
        '
        'lb_6
        '
        Me.lb_6.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.lb_6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_6.ForeColor = System.Drawing.Color.Black
        Me.lb_6.Location = New System.Drawing.Point(580, 129)
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
        Me.fbrShow.SetDecoration(Me.tb_5, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.tb_5, BunifuAnimatorNS.DecorationType.None)
        Me.tb_5.Enabled = False
        Me.tb_5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_5.ForeColor = System.Drawing.Color.Black
        Me.tb_5.isPassword = False
        Me.tb_5.Location = New System.Drawing.Point(580, 149)
        Me.tb_5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_5.Name = "tb_5"
        Me.tb_5.Size = New System.Drawing.Size(160, 36)
        Me.tb_5.TabIndex = 11
        Me.tb_5.TabStop = False
        Me.tb_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_5
        '
        Me.lb_5.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_5, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.lb_5, BunifuAnimatorNS.DecorationType.None)
        Me.lb_5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_5.ForeColor = System.Drawing.Color.Black
        Me.lb_5.Location = New System.Drawing.Point(400, 129)
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
        Me.fbrShow.SetDecoration(Me.tb_4, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.tb_4, BunifuAnimatorNS.DecorationType.None)
        Me.tb_4.Enabled = False
        Me.tb_4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_4.ForeColor = System.Drawing.Color.Black
        Me.tb_4.isPassword = False
        Me.tb_4.Location = New System.Drawing.Point(400, 149)
        Me.tb_4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_4.Name = "tb_4"
        Me.tb_4.Size = New System.Drawing.Size(161, 36)
        Me.tb_4.TabIndex = 12
        Me.tb_4.TabStop = False
        Me.tb_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_2
        '
        Me.lb_2.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.lb_2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.ForeColor = System.Drawing.Color.Black
        Me.lb_2.Location = New System.Drawing.Point(220, 53)
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
        Me.fbrShow.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
        Me.tb_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_1.ForeColor = System.Drawing.Color.Black
        Me.tb_1.isPassword = False
        Me.tb_1.Location = New System.Drawing.Point(220, 73)
        Me.tb_1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_1.Name = "tb_1"
        Me.tb_1.Size = New System.Drawing.Size(160, 36)
        Me.tb_1.TabIndex = 2
        Me.tb_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_4
        '
        Me.lb_4.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_4, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.lb_4, BunifuAnimatorNS.DecorationType.None)
        Me.lb_4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_4.ForeColor = System.Drawing.Color.Black
        Me.lb_4.Location = New System.Drawing.Point(40, 129)
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
        Me.fbrShow.SetDecoration(Me.tb_3, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.tb_3, BunifuAnimatorNS.DecorationType.None)
        Me.tb_3.Enabled = False
        Me.tb_3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_3.ForeColor = System.Drawing.Color.Black
        Me.tb_3.isPassword = False
        Me.tb_3.Location = New System.Drawing.Point(40, 149)
        Me.tb_3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_3.Name = "tb_3"
        Me.tb_3.Size = New System.Drawing.Size(340, 36)
        Me.tb_3.TabIndex = 5
        Me.tb_3.TabStop = False
        Me.tb_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_3
        '
        Me.lb_3.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.lb_3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_3.ForeColor = System.Drawing.Color.Black
        Me.lb_3.Location = New System.Drawing.Point(400, 53)
        Me.lb_3.Name = "lb_3"
        Me.lb_3.Size = New System.Drawing.Size(84, 17)
        Me.lb_3.TabIndex = 10
        Me.lb_3.Text = "Book Name"
        '
        'tb_2
        '
        Me.tb_2.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderThickness = 1
        Me.tb_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fbrShow.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.tb_2.Enabled = False
        Me.tb_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_2.ForeColor = System.Drawing.Color.Black
        Me.tb_2.isPassword = False
        Me.tb_2.Location = New System.Drawing.Point(400, 73)
        Me.tb_2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_2.Name = "tb_2"
        Me.tb_2.Size = New System.Drawing.Size(340, 36)
        Me.tb_2.TabIndex = 4
        Me.tb_2.TabStop = False
        Me.tb_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dt_1
        '
        Me.dt_1.BackColor = System.Drawing.Color.White
        Me.dt_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dt_1.BorderRadius = 0
        Me.fbiHide.SetDecoration(Me.dt_1, BunifuAnimatorNS.DecorationType.None)
        Me.fbrShow.SetDecoration(Me.dt_1, BunifuAnimatorNS.DecorationType.None)
        Me.dt_1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_1.ForeColor = System.Drawing.Color.Black
        Me.dt_1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_1.FormatCustom = ""
        Me.dt_1.Location = New System.Drawing.Point(43, 75)
        Me.dt_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dt_1.Name = "dt_1"
        Me.dt_1.Size = New System.Drawing.Size(158, 34)
        Me.dt_1.TabIndex = 1
        Me.dt_1.Value = New Date(2017, 12, 25, 23, 59, 59, 0)
        '
        'tb_0
        '
        Me.tb_0.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_0.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_0.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_0.BorderThickness = 1
        Me.tb_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fbrShow.SetDecoration(Me.tb_0, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me.tb_0, BunifuAnimatorNS.DecorationType.None)
        Me.tb_0.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_0.ForeColor = System.Drawing.Color.Black
        Me.tb_0.isPassword = False
        Me.tb_0.Location = New System.Drawing.Point(41, 73)
        Me.tb_0.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_0.Name = "tb_0"
        Me.tb_0.Size = New System.Drawing.Size(160, 36)
        Me.tb_0.TabIndex = 52
        Me.tb_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'fbrShow
        '
        Me.fbrShow.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.fbrShow.Cursor = Nothing
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
        Me.fbrShow.DefaultAnimation = Animation2
        '
        'fbiHide
        '
        Me.fbiHide.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.fbiHide.Cursor = Nothing
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
        Me.fbiHide.DefaultAnimation = Animation1
        '
        'Faculty_Book_Issue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 591)
        Me.Controls.Add(Me.FBI)
        Me.fbrShow.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.fbiHide.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-1000, -1000)
        Me.Name = "Faculty_Book_Issue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Faculty Book Issue"
        Me.FBI.ResumeLayout(False)
        Me.FBI.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FBI As Panel
    Friend WithEvents lb_11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_10 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_9 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_8 As Bunifu.Framework.UI.BunifuMetroTextbox
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
    Friend WithEvents tb_0 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents fbrShow As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents fbiHide As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents bt_Confirm As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bt_Reset As Bunifu.Framework.UI.BunifuThinButton2
End Class
