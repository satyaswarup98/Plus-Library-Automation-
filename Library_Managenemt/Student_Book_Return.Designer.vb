<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Book_Return
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Book_Return))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.SBR = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dd_1 = New System.Windows.Forms.ComboBox()
        Me.bt_Confirm = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bt_Reset = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lb_9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_7 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_5 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_4 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.dt_1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuMetroTextbox12 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.sbrShow = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.sbrHide = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.SBR.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SBR
        '
        Me.SBR.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SBR.BackColor = System.Drawing.Color.White
        Me.SBR.BackgroundImage = CType(resources.GetObject("SBR.BackgroundImage"), System.Drawing.Image)
        Me.SBR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SBR.Controls.Add(Me.DataGridView1)
        Me.SBR.Controls.Add(Me.dd_1)
        Me.SBR.Controls.Add(Me.bt_Confirm)
        Me.SBR.Controls.Add(Me.bt_Reset)
        Me.SBR.Controls.Add(Me.lb_9)
        Me.SBR.Controls.Add(Me.tb_7)
        Me.SBR.Controls.Add(Me.lb_7)
        Me.SBR.Controls.Add(Me.tb_5)
        Me.SBR.Controls.Add(Me.lb_5)
        Me.SBR.Controls.Add(Me.tb_4)
        Me.SBR.Controls.Add(Me.lb_1)
        Me.SBR.Controls.Add(Me.lb_6)
        Me.SBR.Controls.Add(Me.lb_2)
        Me.SBR.Controls.Add(Me.tb_1)
        Me.SBR.Controls.Add(Me.lb_3)
        Me.SBR.Controls.Add(Me.tb_2)
        Me.SBR.Controls.Add(Me.dt_1)
        Me.SBR.Controls.Add(Me.BunifuMetroTextbox12)
        Me.sbrHide.SetDecoration(Me.SBR, BunifuAnimatorNS.DecorationType.None)
        Me.sbrShow.SetDecoration(Me.SBR, BunifuAnimatorNS.DecorationType.None)
        Me.SBR.Location = New System.Drawing.Point(25, 5)
        Me.SBR.Name = "SBR"
        Me.SBR.Size = New System.Drawing.Size(782, 583)
        Me.SBR.TabIndex = 59
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sbrHide.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.sbrShow.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(44, 138)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(696, 261)
        Me.DataGridView1.TabIndex = 86
        '
        'dd_1
        '
        Me.sbrHide.SetDecoration(Me.dd_1, BunifuAnimatorNS.DecorationType.None)
        Me.sbrShow.SetDecoration(Me.dd_1, BunifuAnimatorNS.DecorationType.None)
        Me.dd_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dd_1.DropDownWidth = 154
        Me.dd_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dd_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_1.ForeColor = System.Drawing.Color.Black
        Me.dd_1.FormattingEnabled = True
        Me.dd_1.IntegralHeight = False
        Me.dd_1.ItemHeight = 21
        Me.dd_1.Items.AddRange(New Object() {"O+ve", "O-ve", "A+", "B+", "AB+"})
        Me.dd_1.Location = New System.Drawing.Point(224, 438)
        Me.dd_1.Name = "dd_1"
        Me.dd_1.Size = New System.Drawing.Size(156, 29)
        Me.dd_1.TabIndex = 3
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
        Me.bt_Confirm.ButtonText = "CONFIRM"
        Me.bt_Confirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sbrHide.SetDecoration(Me.bt_Confirm, BunifuAnimatorNS.DecorationType.None)
        Me.sbrShow.SetDecoration(Me.bt_Confirm, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Confirm.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Confirm.ForeColor = System.Drawing.Color.White
        Me.bt_Confirm.IdleBorderThickness = 1
        Me.bt_Confirm.IdleCornerRadius = 1
        Me.bt_Confirm.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Confirm.IdleForecolor = System.Drawing.Color.White
        Me.bt_Confirm.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Confirm.Location = New System.Drawing.Point(580, 488)
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
        Me.sbrHide.SetDecoration(Me.bt_Reset, BunifuAnimatorNS.DecorationType.None)
        Me.sbrShow.SetDecoration(Me.bt_Reset, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Reset.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.IdleBorderThickness = 1
        Me.bt_Reset.IdleCornerRadius = 1
        Me.bt_Reset.IdleFillColor = System.Drawing.Color.White
        Me.bt_Reset.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.Location = New System.Drawing.Point(453, 488)
        Me.bt_Reset.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Reset.Name = "bt_Reset"
        Me.bt_Reset.Size = New System.Drawing.Size(115, 50)
        Me.bt_Reset.TabIndex = 5
        Me.bt_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_9
        '
        Me.lb_9.AutoSize = True
        Me.sbrShow.SetDecoration(Me.lb_9, BunifuAnimatorNS.DecorationType.None)
        Me.sbrHide.SetDecoration(Me.lb_9, BunifuAnimatorNS.DecorationType.None)
        Me.lb_9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_9.ForeColor = System.Drawing.Color.Black
        Me.lb_9.Location = New System.Drawing.Point(396, 414)
        Me.lb_9.Name = "lb_9"
        Me.lb_9.Size = New System.Drawing.Size(84, 17)
        Me.lb_9.TabIndex = 65
        Me.lb_9.Text = "Book Name"
        '
        'tb_7
        '
        Me.tb_7.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_7.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_7.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_7.BorderThickness = 1
        Me.tb_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sbrShow.SetDecoration(Me.tb_7, BunifuAnimatorNS.DecorationType.None)
        Me.sbrHide.SetDecoration(Me.tb_7, BunifuAnimatorNS.DecorationType.None)
        Me.tb_7.Enabled = False
        Me.tb_7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_7.ForeColor = System.Drawing.Color.Black
        Me.tb_7.isPassword = False
        Me.tb_7.Location = New System.Drawing.Point(399, 436)
        Me.tb_7.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_7.Name = "tb_7"
        Me.tb_7.Size = New System.Drawing.Size(341, 36)
        Me.tb_7.TabIndex = 6
        Me.tb_7.TabStop = False
        Me.tb_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_7
        '
        Me.lb_7.AutoSize = True
        Me.sbrShow.SetDecoration(Me.lb_7, BunifuAnimatorNS.DecorationType.None)
        Me.sbrHide.SetDecoration(Me.lb_7, BunifuAnimatorNS.DecorationType.None)
        Me.lb_7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_7.ForeColor = System.Drawing.Color.Black
        Me.lb_7.Location = New System.Drawing.Point(220, 414)
        Me.lb_7.Name = "lb_7"
        Me.lb_7.Size = New System.Drawing.Size(67, 17)
        Me.lb_7.TabIndex = 61
        Me.lb_7.Text = "Book No."
        '
        'tb_5
        '
        Me.tb_5.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_5.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_5.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_5.BorderThickness = 1
        Me.tb_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sbrShow.SetDecoration(Me.tb_5, BunifuAnimatorNS.DecorationType.None)
        Me.sbrHide.SetDecoration(Me.tb_5, BunifuAnimatorNS.DecorationType.None)
        Me.tb_5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_5.ForeColor = System.Drawing.Color.Black
        Me.tb_5.isPassword = False
        Me.tb_5.Location = New System.Drawing.Point(220, 434)
        Me.tb_5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_5.Name = "tb_5"
        Me.tb_5.Size = New System.Drawing.Size(161, 36)
        Me.tb_5.TabIndex = 60
        Me.tb_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_5
        '
        Me.lb_5.AutoSize = True
        Me.sbrShow.SetDecoration(Me.lb_5, BunifuAnimatorNS.DecorationType.None)
        Me.sbrHide.SetDecoration(Me.lb_5, BunifuAnimatorNS.DecorationType.None)
        Me.lb_5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_5.ForeColor = System.Drawing.Color.Black
        Me.lb_5.Location = New System.Drawing.Point(570, 45)
        Me.lb_5.Name = "lb_5"
        Me.lb_5.Size = New System.Drawing.Size(68, 17)
        Me.lb_5.TabIndex = 59
        Me.lb_5.Text = "Total Fine"
        '
        'tb_4
        '
        Me.tb_4.BorderColorFocused = System.Drawing.Color.Maroon
        Me.tb_4.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_4.BorderColorMouseHover = System.Drawing.Color.Maroon
        Me.tb_4.BorderThickness = 1
        Me.tb_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sbrShow.SetDecoration(Me.tb_4, BunifuAnimatorNS.DecorationType.None)
        Me.sbrHide.SetDecoration(Me.tb_4, BunifuAnimatorNS.DecorationType.None)
        Me.tb_4.Enabled = False
        Me.tb_4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_4.ForeColor = System.Drawing.Color.Black
        Me.tb_4.isPassword = False
        Me.tb_4.Location = New System.Drawing.Point(570, 65)
        Me.tb_4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_4.Name = "tb_4"
        Me.tb_4.Size = New System.Drawing.Size(170, 36)
        Me.tb_4.TabIndex = 3
        Me.tb_4.TabStop = False
        Me.tb_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.sbrShow.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.sbrHide.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.lb_1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_1.ForeColor = System.Drawing.Color.Black
        Me.lb_1.Location = New System.Drawing.Point(40, 414)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(85, 17)
        Me.lb_1.TabIndex = 39
        Me.lb_1.Text = "Return Date"
        '
        'lb_6
        '
        Me.lb_6.AutoSize = True
        Me.sbrShow.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.sbrHide.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.lb_6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_6.ForeColor = System.Drawing.Color.Black
        Me.lb_6.Location = New System.Drawing.Point(41, 118)
        Me.lb_6.Name = "lb_6"
        Me.lb_6.Size = New System.Drawing.Size(120, 17)
        Me.lb_6.TabIndex = 16
        Me.lb_6.Text = "Book Issue Details"
        '
        'lb_2
        '
        Me.lb_2.AutoSize = True
        Me.sbrShow.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.sbrHide.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.lb_2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.ForeColor = System.Drawing.Color.Black
        Me.lb_2.Location = New System.Drawing.Point(41, 45)
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Size = New System.Drawing.Size(58, 17)
        Me.lb_2.TabIndex = 14
        Me.lb_2.Text = "Roll No."
        '
        'tb_1
        '
        Me.tb_1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderThickness = 1
        Me.tb_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sbrShow.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
        Me.sbrHide.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
        Me.tb_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_1.ForeColor = System.Drawing.Color.Black
        Me.tb_1.isPassword = False
        Me.tb_1.Location = New System.Drawing.Point(41, 65)
        Me.tb_1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_1.Name = "tb_1"
        Me.tb_1.Size = New System.Drawing.Size(160, 36)
        Me.tb_1.TabIndex = 1
        Me.tb_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_3
        '
        Me.lb_3.AutoSize = True
        Me.sbrShow.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.sbrHide.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.lb_3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_3.ForeColor = System.Drawing.Color.Black
        Me.lb_3.Location = New System.Drawing.Point(220, 45)
        Me.lb_3.Name = "lb_3"
        Me.lb_3.Size = New System.Drawing.Size(48, 17)
        Me.lb_3.TabIndex = 10
        Me.lb_3.Text = "Name"
        '
        'tb_2
        '
        Me.tb_2.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderThickness = 1
        Me.tb_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sbrShow.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.sbrHide.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.tb_2.Enabled = False
        Me.tb_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_2.ForeColor = System.Drawing.Color.Black
        Me.tb_2.isPassword = False
        Me.tb_2.Location = New System.Drawing.Point(220, 65)
        Me.tb_2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_2.Name = "tb_2"
        Me.tb_2.Size = New System.Drawing.Size(340, 36)
        Me.tb_2.TabIndex = 2
        Me.tb_2.TabStop = False
        Me.tb_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dt_1
        '
        Me.dt_1.BackColor = System.Drawing.Color.White
        Me.dt_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dt_1.BorderRadius = 0
        Me.sbrHide.SetDecoration(Me.dt_1, BunifuAnimatorNS.DecorationType.None)
        Me.sbrShow.SetDecoration(Me.dt_1, BunifuAnimatorNS.DecorationType.None)
        Me.dt_1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_1.ForeColor = System.Drawing.Color.Black
        Me.dt_1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_1.FormatCustom = ""
        Me.dt_1.Location = New System.Drawing.Point(43, 436)
        Me.dt_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dt_1.Name = "dt_1"
        Me.dt_1.Size = New System.Drawing.Size(158, 34)
        Me.dt_1.TabIndex = 2
        Me.dt_1.Value = New Date(2018, 3, 11, 0, 0, 0, 0)
        '
        'BunifuMetroTextbox12
        '
        Me.BunifuMetroTextbox12.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox12.BorderColorIdle = System.Drawing.Color.Gray
        Me.BunifuMetroTextbox12.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox12.BorderThickness = 1
        Me.BunifuMetroTextbox12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sbrShow.SetDecoration(Me.BunifuMetroTextbox12, BunifuAnimatorNS.DecorationType.None)
        Me.sbrHide.SetDecoration(Me.BunifuMetroTextbox12, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMetroTextbox12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox12.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox12.isPassword = False
        Me.BunifuMetroTextbox12.Location = New System.Drawing.Point(41, 434)
        Me.BunifuMetroTextbox12.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextbox12.Name = "BunifuMetroTextbox12"
        Me.BunifuMetroTextbox12.Size = New System.Drawing.Size(160, 36)
        Me.BunifuMetroTextbox12.TabIndex = 52
        Me.BunifuMetroTextbox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'sbrShow
        '
        Me.sbrShow.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.sbrShow.Cursor = Nothing
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
        Me.sbrShow.DefaultAnimation = Animation2
        '
        'sbrHide
        '
        Me.sbrHide.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.sbrHide.Cursor = Nothing
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
        Me.sbrHide.DefaultAnimation = Animation1
        '
        'Student_Book_Return
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 608)
        Me.Controls.Add(Me.SBR)
        Me.sbrShow.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.sbrHide.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-1000, -1000)
        Me.Name = "Student_Book_Return"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Student Book Return"
        Me.SBR.ResumeLayout(False)
        Me.SBR.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SBR As Panel
    Friend WithEvents lb_9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_7 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_5 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_4 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents dt_1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuMetroTextbox12 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents sbrHide As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents sbrShow As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents bt_Confirm As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bt_Reset As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents dd_1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
