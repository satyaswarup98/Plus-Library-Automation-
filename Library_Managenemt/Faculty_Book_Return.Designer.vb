<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Faculty_Book_Return
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Faculty_Book_Return))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.FBR = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tb_123 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.dd_1 = New System.Windows.Forms.ComboBox()
        Me.bt_Confirm = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bt_Reset = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lb_9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_7 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dd_2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_3 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.dt_1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuMetroTextbox12 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.fbrShow = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.fbrHide = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.FBR.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FBR
        '
        Me.FBR.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FBR.BackColor = System.Drawing.Color.White
        Me.FBR.BackgroundImage = CType(resources.GetObject("FBR.BackgroundImage"), System.Drawing.Image)
        Me.FBR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FBR.Controls.Add(Me.DataGridView1)
        Me.FBR.Controls.Add(Me.tb_123)
        Me.FBR.Controls.Add(Me.dd_1)
        Me.FBR.Controls.Add(Me.bt_Confirm)
        Me.FBR.Controls.Add(Me.bt_Reset)
        Me.FBR.Controls.Add(Me.lb_9)
        Me.FBR.Controls.Add(Me.tb_7)
        Me.FBR.Controls.Add(Me.lb_7)
        Me.FBR.Controls.Add(Me.dd_2)
        Me.FBR.Controls.Add(Me.lb_4)
        Me.FBR.Controls.Add(Me.tb_3)
        Me.FBR.Controls.Add(Me.lb_1)
        Me.FBR.Controls.Add(Me.lb_6)
        Me.FBR.Controls.Add(Me.lb_2)
        Me.FBR.Controls.Add(Me.lb_3)
        Me.FBR.Controls.Add(Me.tb_2)
        Me.FBR.Controls.Add(Me.dt_1)
        Me.FBR.Controls.Add(Me.BunifuMetroTextbox12)
        Me.fbrHide.SetDecoration(Me.FBR, BunifuAnimatorNS.DecorationType.None)
        Me.fbrShow.SetDecoration(Me.FBR, BunifuAnimatorNS.DecorationType.None)
        Me.FBR.Location = New System.Drawing.Point(25, 5)
        Me.FBR.Name = "FBR"
        Me.FBR.Size = New System.Drawing.Size(782, 562)
        Me.FBR.TabIndex = 60
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
        Me.fbrHide.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.fbrShow.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
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
        Me.DataGridView1.Location = New System.Drawing.Point(38, 132)
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
        Me.DataGridView1.Size = New System.Drawing.Size(700, 244)
        Me.DataGridView1.TabIndex = 87
        '
        'tb_123
        '
        Me.tb_123.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_123.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_123.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_123.BorderThickness = 1
        Me.tb_123.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fbrShow.SetDecoration(Me.tb_123, BunifuAnimatorNS.DecorationType.None)
        Me.fbrHide.SetDecoration(Me.tb_123, BunifuAnimatorNS.DecorationType.None)
        Me.tb_123.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_123.ForeColor = System.Drawing.Color.Black
        Me.tb_123.isPassword = False
        Me.tb_123.Location = New System.Drawing.Point(38, 65)
        Me.tb_123.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_123.Name = "tb_123"
        Me.tb_123.Size = New System.Drawing.Size(160, 36)
        Me.tb_123.TabIndex = 1
        Me.tb_123.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dd_1
        '
        Me.fbrHide.SetDecoration(Me.dd_1, BunifuAnimatorNS.DecorationType.None)
        Me.fbrShow.SetDecoration(Me.dd_1, BunifuAnimatorNS.DecorationType.None)
        Me.dd_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dd_1.DropDownWidth = 154
        Me.dd_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dd_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_1.ForeColor = System.Drawing.Color.Black
        Me.dd_1.FormattingEnabled = True
        Me.dd_1.IntegralHeight = False
        Me.dd_1.ItemHeight = 21
        Me.dd_1.Location = New System.Drawing.Point(223, 414)
        Me.dd_1.Name = "dd_1"
        Me.dd_1.Size = New System.Drawing.Size(156, 29)
        Me.dd_1.TabIndex = 70
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
        Me.fbrHide.SetDecoration(Me.bt_Confirm, BunifuAnimatorNS.DecorationType.None)
        Me.fbrShow.SetDecoration(Me.bt_Confirm, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Confirm.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Confirm.ForeColor = System.Drawing.Color.White
        Me.bt_Confirm.IdleBorderThickness = 1
        Me.bt_Confirm.IdleCornerRadius = 1
        Me.bt_Confirm.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Confirm.IdleForecolor = System.Drawing.Color.White
        Me.bt_Confirm.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Confirm.Location = New System.Drawing.Point(580, 467)
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
        Me.fbrHide.SetDecoration(Me.bt_Reset, BunifuAnimatorNS.DecorationType.None)
        Me.fbrShow.SetDecoration(Me.bt_Reset, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Reset.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.IdleBorderThickness = 1
        Me.bt_Reset.IdleCornerRadius = 1
        Me.bt_Reset.IdleFillColor = System.Drawing.Color.White
        Me.bt_Reset.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.Location = New System.Drawing.Point(453, 467)
        Me.bt_Reset.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Reset.Name = "bt_Reset"
        Me.bt_Reset.Size = New System.Drawing.Size(115, 50)
        Me.bt_Reset.TabIndex = 5
        Me.bt_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_9
        '
        Me.lb_9.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_9, BunifuAnimatorNS.DecorationType.None)
        Me.fbrHide.SetDecoration(Me.lb_9, BunifuAnimatorNS.DecorationType.None)
        Me.lb_9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_9.ForeColor = System.Drawing.Color.Black
        Me.lb_9.Location = New System.Drawing.Point(396, 388)
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
        Me.fbrShow.SetDecoration(Me.tb_7, BunifuAnimatorNS.DecorationType.None)
        Me.fbrHide.SetDecoration(Me.tb_7, BunifuAnimatorNS.DecorationType.None)
        Me.tb_7.Enabled = False
        Me.tb_7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_7.ForeColor = System.Drawing.Color.Black
        Me.tb_7.isPassword = False
        Me.tb_7.Location = New System.Drawing.Point(399, 410)
        Me.tb_7.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_7.Name = "tb_7"
        Me.tb_7.Size = New System.Drawing.Size(341, 36)
        Me.tb_7.TabIndex = 64
        Me.tb_7.TabStop = False
        Me.tb_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_7
        '
        Me.lb_7.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_7, BunifuAnimatorNS.DecorationType.None)
        Me.fbrHide.SetDecoration(Me.lb_7, BunifuAnimatorNS.DecorationType.None)
        Me.lb_7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_7.ForeColor = System.Drawing.Color.Black
        Me.lb_7.Location = New System.Drawing.Point(220, 390)
        Me.lb_7.Name = "lb_7"
        Me.lb_7.Size = New System.Drawing.Size(67, 17)
        Me.lb_7.TabIndex = 61
        Me.lb_7.Text = "Book No."
        '
        'dd_2
        '
        Me.dd_2.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.dd_2.BorderColorIdle = System.Drawing.Color.Gray
        Me.dd_2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.dd_2.BorderThickness = 1
        Me.dd_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fbrShow.SetDecoration(Me.dd_2, BunifuAnimatorNS.DecorationType.None)
        Me.fbrHide.SetDecoration(Me.dd_2, BunifuAnimatorNS.DecorationType.None)
        Me.dd_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_2.ForeColor = System.Drawing.Color.Black
        Me.dd_2.isPassword = False
        Me.dd_2.Location = New System.Drawing.Point(220, 410)
        Me.dd_2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.dd_2.Name = "dd_2"
        Me.dd_2.Size = New System.Drawing.Size(161, 36)
        Me.dd_2.TabIndex = 60
        Me.dd_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_4
        '
        Me.lb_4.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_4, BunifuAnimatorNS.DecorationType.None)
        Me.fbrHide.SetDecoration(Me.lb_4, BunifuAnimatorNS.DecorationType.None)
        Me.lb_4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_4.ForeColor = System.Drawing.Color.Black
        Me.lb_4.Location = New System.Drawing.Point(576, 45)
        Me.lb_4.Name = "lb_4"
        Me.lb_4.Size = New System.Drawing.Size(122, 17)
        Me.lb_4.TabIndex = 57
        Me.lb_4.Text = "No of Book Issued"
        '
        'tb_3
        '
        Me.tb_3.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_3.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_3.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_3.BorderThickness = 1
        Me.tb_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fbrShow.SetDecoration(Me.tb_3, BunifuAnimatorNS.DecorationType.None)
        Me.fbrHide.SetDecoration(Me.tb_3, BunifuAnimatorNS.DecorationType.None)
        Me.tb_3.Enabled = False
        Me.tb_3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_3.ForeColor = System.Drawing.Color.Black
        Me.tb_3.isPassword = False
        Me.tb_3.Location = New System.Drawing.Point(579, 65)
        Me.tb_3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_3.Name = "tb_3"
        Me.tb_3.Size = New System.Drawing.Size(161, 36)
        Me.tb_3.TabIndex = 56
        Me.tb_3.TabStop = False
        Me.tb_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.fbrHide.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.lb_1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_1.ForeColor = System.Drawing.Color.Black
        Me.lb_1.Location = New System.Drawing.Point(37, 390)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(85, 17)
        Me.lb_1.TabIndex = 39
        Me.lb_1.Text = "Return Date"
        '
        'lb_6
        '
        Me.lb_6.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.fbrHide.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.lb_6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_6.ForeColor = System.Drawing.Color.Black
        Me.lb_6.Location = New System.Drawing.Point(40, 112)
        Me.lb_6.Name = "lb_6"
        Me.lb_6.Size = New System.Drawing.Size(120, 17)
        Me.lb_6.TabIndex = 16
        Me.lb_6.Text = "Book Issue Details"
        '
        'lb_2
        '
        Me.lb_2.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.fbrHide.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.lb_2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.ForeColor = System.Drawing.Color.Black
        Me.lb_2.Location = New System.Drawing.Point(40, 45)
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Size = New System.Drawing.Size(70, 17)
        Me.lb_2.TabIndex = 14
        Me.lb_2.Text = "Faculty ID"
        '
        'lb_3
        '
        Me.lb_3.AutoSize = True
        Me.fbrShow.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.fbrHide.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.lb_3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_3.ForeColor = System.Drawing.Color.Black
        Me.lb_3.Location = New System.Drawing.Point(220, 45)
        Me.lb_3.Name = "lb_3"
        Me.lb_3.Size = New System.Drawing.Size(97, 17)
        Me.lb_3.TabIndex = 10
        Me.lb_3.Text = "Faculty Name"
        '
        'tb_2
        '
        Me.tb_2.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderThickness = 1
        Me.tb_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fbrShow.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.fbrHide.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.tb_2.Enabled = False
        Me.tb_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_2.ForeColor = System.Drawing.Color.Black
        Me.tb_2.isPassword = False
        Me.tb_2.Location = New System.Drawing.Point(220, 65)
        Me.tb_2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_2.Name = "tb_2"
        Me.tb_2.Size = New System.Drawing.Size(340, 36)
        Me.tb_2.TabIndex = 85
        Me.tb_2.TabStop = False
        Me.tb_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dt_1
        '
        Me.dt_1.BackColor = System.Drawing.Color.White
        Me.dt_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dt_1.BorderRadius = 0
        Me.fbrHide.SetDecoration(Me.dt_1, BunifuAnimatorNS.DecorationType.None)
        Me.fbrShow.SetDecoration(Me.dt_1, BunifuAnimatorNS.DecorationType.None)
        Me.dt_1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_1.ForeColor = System.Drawing.Color.Black
        Me.dt_1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_1.FormatCustom = ""
        Me.dt_1.Location = New System.Drawing.Point(40, 412)
        Me.dt_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dt_1.Name = "dt_1"
        Me.dt_1.Size = New System.Drawing.Size(158, 34)
        Me.dt_1.TabIndex = 2
        Me.dt_1.Value = New Date(2018, 1, 15, 0, 0, 0, 0)
        '
        'BunifuMetroTextbox12
        '
        Me.BunifuMetroTextbox12.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox12.BorderColorIdle = System.Drawing.Color.Gray
        Me.BunifuMetroTextbox12.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox12.BorderThickness = 1
        Me.BunifuMetroTextbox12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fbrShow.SetDecoration(Me.BunifuMetroTextbox12, BunifuAnimatorNS.DecorationType.None)
        Me.fbrHide.SetDecoration(Me.BunifuMetroTextbox12, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMetroTextbox12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox12.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox12.isPassword = False
        Me.BunifuMetroTextbox12.Location = New System.Drawing.Point(38, 410)
        Me.BunifuMetroTextbox12.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextbox12.Name = "BunifuMetroTextbox12"
        Me.BunifuMetroTextbox12.Size = New System.Drawing.Size(160, 36)
        Me.BunifuMetroTextbox12.TabIndex = 52
        Me.BunifuMetroTextbox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        'fbrHide
        '
        Me.fbrHide.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.fbrHide.Cursor = Nothing
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
        Me.fbrHide.DefaultAnimation = Animation1
        '
        'Faculty_Book_Return
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 586)
        Me.Controls.Add(Me.FBR)
        Me.fbrShow.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.fbrHide.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-1000, -1000)
        Me.Name = "Faculty_Book_Return"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Faculty Book Return"
        Me.FBR.ResumeLayout(False)
        Me.FBR.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FBR As Panel
    Friend WithEvents lb_9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_7 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dd_2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_3 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents dt_1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuMetroTextbox12 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents fbrHide As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents fbrShow As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents bt_Confirm As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bt_Reset As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents dd_1 As ComboBox
    Friend WithEvents tb_123 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents DataGridView1 As DataGridView
End Class
