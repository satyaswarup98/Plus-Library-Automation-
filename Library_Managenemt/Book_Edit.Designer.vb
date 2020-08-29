<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Book_Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Book_Edit))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.BEdit = New System.Windows.Forms.Panel()
        Me.dd_3 = New System.Windows.Forms.ComboBox()
        Me.dd_2 = New System.Windows.Forms.ComboBox()
        Me.dd_1 = New System.Windows.Forms.ComboBox()
        Me.bt_Save = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bt_Reset = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lb_7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_7 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_6 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_5 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_8 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_4 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_3 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dt_1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuMetroTextbox12 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextbox3 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.beShow = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.beHide = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'BEdit
        '
        Me.BEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BEdit.BackgroundImage = CType(resources.GetObject("BEdit.BackgroundImage"), System.Drawing.Image)
        Me.BEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BEdit.Controls.Add(Me.dd_3)
        Me.BEdit.Controls.Add(Me.dd_2)
        Me.BEdit.Controls.Add(Me.dd_1)
        Me.BEdit.Controls.Add(Me.bt_Save)
        Me.BEdit.Controls.Add(Me.bt_Reset)
        Me.BEdit.Controls.Add(Me.lb_7)
        Me.BEdit.Controls.Add(Me.lb_10)
        Me.BEdit.Controls.Add(Me.tb_7)
        Me.BEdit.Controls.Add(Me.lb_13)
        Me.BEdit.Controls.Add(Me.lb_2)
        Me.BEdit.Controls.Add(Me.tb_2)
        Me.BEdit.Controls.Add(Me.lb_1)
        Me.BEdit.Controls.Add(Me.tb_1)
        Me.BEdit.Controls.Add(Me.lb_8)
        Me.BEdit.Controls.Add(Me.tb_6)
        Me.BEdit.Controls.Add(Me.lb_6)
        Me.BEdit.Controls.Add(Me.tb_5)
        Me.BEdit.Controls.Add(Me.lb_9)
        Me.BEdit.Controls.Add(Me.lb_11)
        Me.BEdit.Controls.Add(Me.tb_8)
        Me.BEdit.Controls.Add(Me.lb_4)
        Me.BEdit.Controls.Add(Me.tb_4)
        Me.BEdit.Controls.Add(Me.lb_3)
        Me.BEdit.Controls.Add(Me.tb_3)
        Me.BEdit.Controls.Add(Me.lb_12)
        Me.BEdit.Controls.Add(Me.dt_1)
        Me.BEdit.Controls.Add(Me.BunifuMetroTextbox12)
        Me.BEdit.Controls.Add(Me.BunifuMetroTextbox3)
        Me.BEdit.Controls.Add(Me.BunifuMetroTextbox1)
        Me.BEdit.Controls.Add(Me.BunifuMetroTextbox2)
        Me.beHide.SetDecoration(Me.BEdit, BunifuAnimatorNS.DecorationType.None)
        Me.beShow.SetDecoration(Me.BEdit, BunifuAnimatorNS.DecorationType.None)
        Me.BEdit.Location = New System.Drawing.Point(25, 42)
        Me.BEdit.Name = "BEdit"
        Me.BEdit.Size = New System.Drawing.Size(782, 506)
        Me.BEdit.TabIndex = 57
        '
        'dd_3
        '
        Me.beHide.SetDecoration(Me.dd_3, BunifuAnimatorNS.DecorationType.None)
        Me.beShow.SetDecoration(Me.dd_3, BunifuAnimatorNS.DecorationType.None)
        Me.dd_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dd_3.DropDownWidth = 154
        Me.dd_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dd_3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_3.ForeColor = System.Drawing.Color.Black
        Me.dd_3.FormattingEnabled = True
        Me.dd_3.IntegralHeight = False
        Me.dd_3.ItemHeight = 21
        Me.dd_3.Items.AddRange(New Object() {"Avalable", "Out Of Stock"})
        Me.dd_3.Location = New System.Drawing.Point(47, 359)
        Me.dd_3.Name = "dd_3"
        Me.dd_3.Size = New System.Drawing.Size(333, 29)
        Me.dd_3.TabIndex = 14
        '
        'dd_2
        '
        Me.beHide.SetDecoration(Me.dd_2, BunifuAnimatorNS.DecorationType.None)
        Me.beShow.SetDecoration(Me.dd_2, BunifuAnimatorNS.DecorationType.None)
        Me.dd_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dd_2.DropDownWidth = 154
        Me.dd_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dd_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_2.ForeColor = System.Drawing.Color.Black
        Me.dd_2.FormattingEnabled = True
        Me.dd_2.IntegralHeight = False
        Me.dd_2.ItemHeight = 21
        Me.dd_2.Location = New System.Drawing.Point(408, 284)
        Me.dd_2.Name = "dd_2"
        Me.dd_2.Size = New System.Drawing.Size(336, 29)
        Me.dd_2.TabIndex = 13
        '
        'dd_1
        '
        Me.beHide.SetDecoration(Me.dd_1, BunifuAnimatorNS.DecorationType.None)
        Me.beShow.SetDecoration(Me.dd_1, BunifuAnimatorNS.DecorationType.None)
        Me.dd_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dd_1.DropDownWidth = 154
        Me.dd_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dd_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_1.ForeColor = System.Drawing.Color.Black
        Me.dd_1.FormattingEnabled = True
        Me.dd_1.IntegralHeight = False
        Me.dd_1.ItemHeight = 21
        Me.dd_1.Location = New System.Drawing.Point(223, 211)
        Me.dd_1.Name = "dd_1"
        Me.dd_1.Size = New System.Drawing.Size(156, 29)
        Me.dd_1.TabIndex = 9
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
        Me.beHide.SetDecoration(Me.bt_Save, BunifuAnimatorNS.DecorationType.None)
        Me.beShow.SetDecoration(Me.bt_Save, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Save.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Save.ForeColor = System.Drawing.Color.White
        Me.bt_Save.IdleBorderThickness = 1
        Me.bt_Save.IdleCornerRadius = 1
        Me.bt_Save.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Save.IdleForecolor = System.Drawing.Color.White
        Me.bt_Save.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Save.Location = New System.Drawing.Point(572, 407)
        Me.bt_Save.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Save.Name = "bt_Save"
        Me.bt_Save.Size = New System.Drawing.Size(160, 50)
        Me.bt_Save.TabIndex = 15
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
        Me.beHide.SetDecoration(Me.bt_Reset, BunifuAnimatorNS.DecorationType.None)
        Me.beShow.SetDecoration(Me.bt_Reset, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Reset.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.IdleBorderThickness = 1
        Me.bt_Reset.IdleCornerRadius = 1
        Me.bt_Reset.IdleFillColor = System.Drawing.Color.White
        Me.bt_Reset.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.Location = New System.Drawing.Point(445, 407)
        Me.bt_Reset.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Reset.Name = "bt_Reset"
        Me.bt_Reset.Size = New System.Drawing.Size(115, 50)
        Me.bt_Reset.TabIndex = 16
        Me.bt_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_7
        '
        Me.lb_7.AutoSize = True
        Me.beShow.SetDecoration(Me.lb_7, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.lb_7, BunifuAnimatorNS.DecorationType.None)
        Me.lb_7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_7.ForeColor = System.Drawing.Color.Black
        Me.lb_7.Location = New System.Drawing.Point(43, 187)
        Me.lb_7.Name = "lb_7"
        Me.lb_7.Size = New System.Drawing.Size(106, 17)
        Me.lb_7.TabIndex = 39
        Me.lb_7.Text = "Purchage Date"
        '
        'lb_10
        '
        Me.lb_10.AutoSize = True
        Me.beShow.SetDecoration(Me.lb_10, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.lb_10, BunifuAnimatorNS.DecorationType.None)
        Me.lb_10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_10.ForeColor = System.Drawing.Color.Black
        Me.lb_10.Location = New System.Drawing.Point(580, 185)
        Me.lb_10.Name = "lb_10"
        Me.lb_10.Size = New System.Drawing.Size(47, 17)
        Me.lb_10.TabIndex = 37
        Me.lb_10.Text = "Pages"
        '
        'tb_7
        '
        Me.tb_7.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_7.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_7.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_7.BorderThickness = 1
        Me.tb_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.beShow.SetDecoration(Me.tb_7, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.tb_7, BunifuAnimatorNS.DecorationType.None)
        Me.tb_7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_7.ForeColor = System.Drawing.Color.Black
        Me.tb_7.isPassword = False
        Me.tb_7.Location = New System.Drawing.Point(580, 205)
        Me.tb_7.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_7.Name = "tb_7"
        Me.tb_7.Size = New System.Drawing.Size(160, 36)
        Me.tb_7.TabIndex = 11
        Me.tb_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_13
        '
        Me.lb_13.AutoSize = True
        Me.beShow.SetDecoration(Me.lb_13, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.lb_13, BunifuAnimatorNS.DecorationType.None)
        Me.lb_13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_13.ForeColor = System.Drawing.Color.Black
        Me.lb_13.Location = New System.Drawing.Point(43, 334)
        Me.lb_13.Name = "lb_13"
        Me.lb_13.Size = New System.Drawing.Size(46, 17)
        Me.lb_13.TabIndex = 34
        Me.lb_13.Text = "Status"
        '
        'lb_2
        '
        Me.lb_2.AutoSize = True
        Me.beShow.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.lb_2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.ForeColor = System.Drawing.Color.Black
        Me.lb_2.Location = New System.Drawing.Point(220, 45)
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Size = New System.Drawing.Size(61, 17)
        Me.lb_2.TabIndex = 32
        Me.lb_2.Text = "ISBN No."
        '
        'tb_2
        '
        Me.tb_2.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderThickness = 1
        Me.tb_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.beShow.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.tb_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_2.ForeColor = System.Drawing.Color.Black
        Me.tb_2.isPassword = False
        Me.tb_2.Location = New System.Drawing.Point(220, 65)
        Me.tb_2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_2.Name = "tb_2"
        Me.tb_2.Size = New System.Drawing.Size(160, 36)
        Me.tb_2.TabIndex = 3
        Me.tb_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.beShow.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.lb_1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_1.ForeColor = System.Drawing.Color.Black
        Me.lb_1.Location = New System.Drawing.Point(40, 45)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(67, 17)
        Me.lb_1.TabIndex = 28
        Me.lb_1.Text = "Book No."
        '
        'tb_1
        '
        Me.tb_1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderThickness = 1
        Me.tb_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.beShow.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
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
        'lb_8
        '
        Me.lb_8.AutoSize = True
        Me.beShow.SetDecoration(Me.lb_8, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.lb_8, BunifuAnimatorNS.DecorationType.None)
        Me.lb_8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_8.ForeColor = System.Drawing.Color.Black
        Me.lb_8.Location = New System.Drawing.Point(400, 189)
        Me.lb_8.Name = "lb_8"
        Me.lb_8.Size = New System.Drawing.Size(39, 17)
        Me.lb_8.TabIndex = 22
        Me.lb_8.Text = "Price"
        '
        'tb_6
        '
        Me.tb_6.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_6.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_6.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_6.BorderThickness = 1
        Me.tb_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.beShow.SetDecoration(Me.tb_6, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.tb_6, BunifuAnimatorNS.DecorationType.None)
        Me.tb_6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_6.ForeColor = System.Drawing.Color.Black
        Me.tb_6.isPassword = False
        Me.tb_6.Location = New System.Drawing.Point(400, 209)
        Me.tb_6.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_6.Name = "tb_6"
        Me.tb_6.Size = New System.Drawing.Size(160, 36)
        Me.tb_6.TabIndex = 10
        Me.tb_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_6
        '
        Me.lb_6.AutoSize = True
        Me.beShow.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.lb_6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_6.ForeColor = System.Drawing.Color.Black
        Me.lb_6.Location = New System.Drawing.Point(402, 116)
        Me.lb_6.Name = "lb_6"
        Me.lb_6.Size = New System.Drawing.Size(125, 17)
        Me.lb_6.TabIndex = 20
        Me.lb_6.Text = "Publication Name"
        '
        'tb_5
        '
        Me.tb_5.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_5.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_5.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_5.BorderThickness = 1
        Me.tb_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.beShow.SetDecoration(Me.tb_5, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.tb_5, BunifuAnimatorNS.DecorationType.None)
        Me.tb_5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_5.ForeColor = System.Drawing.Color.Black
        Me.tb_5.isPassword = False
        Me.tb_5.Location = New System.Drawing.Point(402, 136)
        Me.tb_5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_5.Name = "tb_5"
        Me.tb_5.Size = New System.Drawing.Size(340, 36)
        Me.tb_5.TabIndex = 7
        Me.tb_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_9
        '
        Me.lb_9.AutoSize = True
        Me.beShow.SetDecoration(Me.lb_9, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.lb_9, BunifuAnimatorNS.DecorationType.None)
        Me.lb_9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_9.ForeColor = System.Drawing.Color.Black
        Me.lb_9.Location = New System.Drawing.Point(220, 187)
        Me.lb_9.Name = "lb_9"
        Me.lb_9.Size = New System.Drawing.Size(113, 17)
        Me.lb_9.TabIndex = 18
        Me.lb_9.Text = "Publication Year"
        '
        'lb_11
        '
        Me.lb_11.AutoSize = True
        Me.beShow.SetDecoration(Me.lb_11, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.lb_11, BunifuAnimatorNS.DecorationType.None)
        Me.lb_11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_11.ForeColor = System.Drawing.Color.Black
        Me.lb_11.Location = New System.Drawing.Point(43, 258)
        Me.lb_11.Name = "lb_11"
        Me.lb_11.Size = New System.Drawing.Size(52, 17)
        Me.lb_11.TabIndex = 16
        Me.lb_11.Text = "Edition"
        '
        'tb_8
        '
        Me.tb_8.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_8.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_8.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_8.BorderThickness = 1
        Me.tb_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.beShow.SetDecoration(Me.tb_8, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.tb_8, BunifuAnimatorNS.DecorationType.None)
        Me.tb_8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_8.ForeColor = System.Drawing.Color.Black
        Me.tb_8.isPassword = False
        Me.tb_8.Location = New System.Drawing.Point(43, 278)
        Me.tb_8.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_8.Name = "tb_8"
        Me.tb_8.Size = New System.Drawing.Size(340, 36)
        Me.tb_8.TabIndex = 12
        Me.tb_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_4
        '
        Me.lb_4.AutoSize = True
        Me.beShow.SetDecoration(Me.lb_4, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.lb_4, BunifuAnimatorNS.DecorationType.None)
        Me.lb_4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_4.ForeColor = System.Drawing.Color.Black
        Me.lb_4.Location = New System.Drawing.Point(43, 116)
        Me.lb_4.Name = "lb_4"
        Me.lb_4.Size = New System.Drawing.Size(95, 17)
        Me.lb_4.TabIndex = 12
        Me.lb_4.Text = "Author Name"
        '
        'tb_4
        '
        Me.tb_4.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_4.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_4.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_4.BorderThickness = 1
        Me.tb_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.beShow.SetDecoration(Me.tb_4, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.tb_4, BunifuAnimatorNS.DecorationType.None)
        Me.tb_4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_4.ForeColor = System.Drawing.Color.Black
        Me.tb_4.isPassword = False
        Me.tb_4.Location = New System.Drawing.Point(43, 136)
        Me.tb_4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_4.Name = "tb_4"
        Me.tb_4.Size = New System.Drawing.Size(340, 36)
        Me.tb_4.TabIndex = 5
        Me.tb_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_3
        '
        Me.lb_3.AutoSize = True
        Me.beShow.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.lb_3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_3.ForeColor = System.Drawing.Color.Black
        Me.lb_3.Location = New System.Drawing.Point(400, 45)
        Me.lb_3.Name = "lb_3"
        Me.lb_3.Size = New System.Drawing.Size(68, 17)
        Me.lb_3.TabIndex = 10
        Me.lb_3.Text = "Book Title"
        '
        'tb_3
        '
        Me.tb_3.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_3.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_3.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_3.BorderThickness = 1
        Me.tb_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.beShow.SetDecoration(Me.tb_3, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.tb_3, BunifuAnimatorNS.DecorationType.None)
        Me.tb_3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_3.ForeColor = System.Drawing.Color.Black
        Me.tb_3.isPassword = False
        Me.tb_3.Location = New System.Drawing.Point(400, 65)
        Me.tb_3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_3.Name = "tb_3"
        Me.tb_3.Size = New System.Drawing.Size(340, 36)
        Me.tb_3.TabIndex = 4
        Me.tb_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_12
        '
        Me.lb_12.AutoSize = True
        Me.beShow.SetDecoration(Me.lb_12, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.lb_12, BunifuAnimatorNS.DecorationType.None)
        Me.lb_12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_12.ForeColor = System.Drawing.Color.Black
        Me.lb_12.Location = New System.Drawing.Point(400, 258)
        Me.lb_12.Name = "lb_12"
        Me.lb_12.Size = New System.Drawing.Size(70, 17)
        Me.lb_12.TabIndex = 24
        Me.lb_12.Text = "Catagory"
        '
        'dt_1
        '
        Me.dt_1.BackColor = System.Drawing.Color.White
        Me.dt_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dt_1.BorderRadius = 0
        Me.beHide.SetDecoration(Me.dt_1, BunifuAnimatorNS.DecorationType.None)
        Me.beShow.SetDecoration(Me.dt_1, BunifuAnimatorNS.DecorationType.None)
        Me.dt_1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_1.ForeColor = System.Drawing.Color.Black
        Me.dt_1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_1.FormatCustom = ""
        Me.dt_1.Location = New System.Drawing.Point(46, 209)
        Me.dt_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dt_1.Name = "dt_1"
        Me.dt_1.Size = New System.Drawing.Size(158, 34)
        Me.dt_1.TabIndex = 8
        Me.dt_1.Value = New Date(2018, 2, 12, 0, 0, 0, 0)
        '
        'BunifuMetroTextbox12
        '
        Me.BunifuMetroTextbox12.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox12.BorderColorIdle = System.Drawing.Color.Gray
        Me.BunifuMetroTextbox12.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox12.BorderThickness = 1
        Me.BunifuMetroTextbox12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.beShow.SetDecoration(Me.BunifuMetroTextbox12, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.BunifuMetroTextbox12, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMetroTextbox12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox12.ForeColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox12.isPassword = False
        Me.BunifuMetroTextbox12.Location = New System.Drawing.Point(44, 207)
        Me.BunifuMetroTextbox12.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextbox12.Name = "BunifuMetroTextbox12"
        Me.BunifuMetroTextbox12.Size = New System.Drawing.Size(160, 36)
        Me.BunifuMetroTextbox12.TabIndex = 52
        Me.BunifuMetroTextbox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextbox3
        '
        Me.BunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.Gray
        Me.BunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox3.BorderThickness = 1
        Me.BunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.beShow.SetDecoration(Me.BunifuMetroTextbox3, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.BunifuMetroTextbox3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMetroTextbox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox3.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox3.isPassword = False
        Me.BunifuMetroTextbox3.Location = New System.Drawing.Point(220, 207)
        Me.BunifuMetroTextbox3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextbox3.Name = "BunifuMetroTextbox3"
        Me.BunifuMetroTextbox3.Size = New System.Drawing.Size(160, 36)
        Me.BunifuMetroTextbox3.TabIndex = 59
        Me.BunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Gray
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderThickness = 1
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.beShow.SetDecoration(Me.BunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.BunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(405, 280)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(340, 36)
        Me.BunifuMetroTextbox1.TabIndex = 57
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextbox2
        '
        Me.BunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.Gray
        Me.BunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderThickness = 1
        Me.BunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.beShow.SetDecoration(Me.BunifuMetroTextbox2, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me.BunifuMetroTextbox2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMetroTextbox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox2.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox2.isPassword = False
        Me.BunifuMetroTextbox2.Location = New System.Drawing.Point(43, 354)
        Me.BunifuMetroTextbox2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextbox2.Name = "BunifuMetroTextbox2"
        Me.BunifuMetroTextbox2.Size = New System.Drawing.Size(340, 36)
        Me.BunifuMetroTextbox2.TabIndex = 58
        Me.BunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'beShow
        '
        Me.beShow.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.beShow.Cursor = Nothing
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
        Me.beShow.DefaultAnimation = Animation2
        '
        'beHide
        '
        Me.beHide.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.beHide.Cursor = Nothing
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
        Me.beHide.DefaultAnimation = Animation1
        '
        'Book_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 591)
        Me.Controls.Add(Me.BEdit)
        Me.beShow.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.beHide.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-1000, -1000)
        Me.Name = "Book_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Book Edit"
        Me.BEdit.ResumeLayout(False)
        Me.BEdit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BEdit As Panel
    Friend WithEvents bt_Save As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bt_Reset As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lb_7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_7 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_6 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_5 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_8 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_4 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_3 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dt_1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuMetroTextbox12 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents beHide As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents beShow As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuMetroTextbox3 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents dd_1 As ComboBox
    Friend WithEvents dd_3 As ComboBox
    Friend WithEvents dd_2 As ComboBox
End Class
