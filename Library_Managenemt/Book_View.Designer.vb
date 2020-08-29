<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Book_View
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Book_View))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.bvShow = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BV = New System.Windows.Forms.Panel()
        Me.lb_50 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tb_2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lb_18 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_14 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_16 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_17 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.textbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.bvHide = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BV.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bvShow
        '
        Me.bvShow.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.bvShow.Cursor = Nothing
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
        Me.bvShow.DefaultAnimation = Animation1
        '
        'BV
        '
        Me.BV.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BV.BackgroundImage = CType(resources.GetObject("BV.BackgroundImage"), System.Drawing.Image)
        Me.BV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BV.Controls.Add(Me.lb_50)
        Me.BV.Controls.Add(Me.TextBox2)
        Me.BV.Controls.Add(Me.tb_2)
        Me.BV.Controls.Add(Me.DataGridView1)
        Me.BV.Controls.Add(Me.lb_18)
        Me.BV.Controls.Add(Me.lb_6)
        Me.BV.Controls.Add(Me.lb_4)
        Me.BV.Controls.Add(Me.lb_10)
        Me.BV.Controls.Add(Me.lb_12)
        Me.BV.Controls.Add(Me.lb_14)
        Me.BV.Controls.Add(Me.lb_8)
        Me.BV.Controls.Add(Me.lb_16)
        Me.BV.Controls.Add(Me.lb_17)
        Me.BV.Controls.Add(Me.lb_5)
        Me.BV.Controls.Add(Me.lb_3)
        Me.BV.Controls.Add(Me.lb_9)
        Me.BV.Controls.Add(Me.lb_11)
        Me.BV.Controls.Add(Me.lb_13)
        Me.BV.Controls.Add(Me.lb_7)
        Me.BV.Controls.Add(Me.lb_15)
        Me.BV.Controls.Add(Me.lb_1)
        Me.BV.Controls.Add(Me.tb_1)
        Me.BV.Controls.Add(Me.lb_2)
        Me.BV.Controls.Add(Me.textbox1)
        Me.bvHide.SetDecoration(Me.BV, BunifuAnimatorNS.DecorationType.None)
        Me.bvShow.SetDecoration(Me.BV, BunifuAnimatorNS.DecorationType.None)
        Me.BV.Location = New System.Drawing.Point(25, 5)
        Me.BV.Name = "BV"
        Me.BV.Size = New System.Drawing.Size(782, 562)
        Me.BV.TabIndex = 59
        '
        'lb_50
        '
        Me.lb_50.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_50, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_50, BunifuAnimatorNS.DecorationType.None)
        Me.lb_50.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lb_50.Location = New System.Drawing.Point(180, 376)
        Me.lb_50.Name = "lb_50"
        Me.lb_50.Size = New System.Drawing.Size(421, 23)
        Me.lb_50.TabIndex = 93
        Me.lb_50.Text = "FOR BOOK TRANSACTION DETAILS  ENTER BOOK NO"
        Me.lb_50.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bvShow.SetDecoration(Me.TextBox2, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.TextBox2, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(223, 74)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(0, 20)
        Me.TextBox2.TabIndex = 92
        '
        'tb_2
        '
        Me.tb_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bvShow.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.tb_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_2.Location = New System.Drawing.Point(224, 74)
        Me.tb_2.Name = "tb_2"
        Me.tb_2.Size = New System.Drawing.Size(512, 20)
        Me.tb_2.TabIndex = 2
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
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bvHide.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.bvShow.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
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
        Me.DataGridView1.Location = New System.Drawing.Point(40, 262)
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
        Me.DataGridView1.Size = New System.Drawing.Size(700, 255)
        Me.DataGridView1.TabIndex = 89
        '
        'lb_18
        '
        Me.lb_18.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_18, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_18, BunifuAnimatorNS.DecorationType.None)
        Me.lb_18.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_18.ForeColor = System.Drawing.Color.Black
        Me.lb_18.Location = New System.Drawing.Point(586, 225)
        Me.lb_18.Name = "lb_18"
        Me.lb_18.Size = New System.Drawing.Size(14, 21)
        Me.lb_18.TabIndex = 82
        Me.lb_18.Text = ":"
        '
        'lb_6
        '
        Me.lb_6.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.lb_6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_6.ForeColor = System.Drawing.Color.Black
        Me.lb_6.Location = New System.Drawing.Point(586, 120)
        Me.lb_6.Name = "lb_6"
        Me.lb_6.Size = New System.Drawing.Size(14, 21)
        Me.lb_6.TabIndex = 81
        Me.lb_6.Text = ":"
        '
        'lb_4
        '
        Me.lb_4.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_4, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_4, BunifuAnimatorNS.DecorationType.None)
        Me.lb_4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_4.ForeColor = System.Drawing.Color.Black
        Me.lb_4.Location = New System.Drawing.Point(202, 120)
        Me.lb_4.Name = "lb_4"
        Me.lb_4.Size = New System.Drawing.Size(14, 21)
        Me.lb_4.TabIndex = 80
        Me.lb_4.Text = ":"
        '
        'lb_10
        '
        Me.lb_10.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_10, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_10, BunifuAnimatorNS.DecorationType.None)
        Me.lb_10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_10.ForeColor = System.Drawing.Color.Black
        Me.lb_10.Location = New System.Drawing.Point(586, 155)
        Me.lb_10.Name = "lb_10"
        Me.lb_10.Size = New System.Drawing.Size(14, 21)
        Me.lb_10.TabIndex = 78
        Me.lb_10.Text = ":"
        '
        'lb_12
        '
        Me.lb_12.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_12, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_12, BunifuAnimatorNS.DecorationType.None)
        Me.lb_12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_12.ForeColor = System.Drawing.Color.Black
        Me.lb_12.Location = New System.Drawing.Point(202, 190)
        Me.lb_12.Name = "lb_12"
        Me.lb_12.Size = New System.Drawing.Size(14, 21)
        Me.lb_12.TabIndex = 77
        Me.lb_12.Text = ":"
        '
        'lb_14
        '
        Me.lb_14.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_14, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_14, BunifuAnimatorNS.DecorationType.None)
        Me.lb_14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_14.ForeColor = System.Drawing.Color.Black
        Me.lb_14.Location = New System.Drawing.Point(586, 190)
        Me.lb_14.Name = "lb_14"
        Me.lb_14.Size = New System.Drawing.Size(14, 21)
        Me.lb_14.TabIndex = 76
        Me.lb_14.Text = ":"
        '
        'lb_8
        '
        Me.lb_8.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_8, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_8, BunifuAnimatorNS.DecorationType.None)
        Me.lb_8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_8.ForeColor = System.Drawing.Color.Black
        Me.lb_8.Location = New System.Drawing.Point(202, 155)
        Me.lb_8.Name = "lb_8"
        Me.lb_8.Size = New System.Drawing.Size(14, 21)
        Me.lb_8.TabIndex = 75
        Me.lb_8.Text = ":"
        '
        'lb_16
        '
        Me.lb_16.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_16, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_16, BunifuAnimatorNS.DecorationType.None)
        Me.lb_16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_16.ForeColor = System.Drawing.Color.Black
        Me.lb_16.Location = New System.Drawing.Point(202, 225)
        Me.lb_16.Name = "lb_16"
        Me.lb_16.Size = New System.Drawing.Size(14, 21)
        Me.lb_16.TabIndex = 79
        Me.lb_16.Text = ":"
        '
        'lb_17
        '
        Me.lb_17.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_17, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_17, BunifuAnimatorNS.DecorationType.None)
        Me.lb_17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_17.ForeColor = System.Drawing.Color.Black
        Me.lb_17.Location = New System.Drawing.Point(440, 225)
        Me.lb_17.Name = "lb_17"
        Me.lb_17.Size = New System.Drawing.Size(59, 21)
        Me.lb_17.TabIndex = 74
        Me.lb_17.Text = "Status"
        '
        'lb_5
        '
        Me.lb_5.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_5, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_5, BunifuAnimatorNS.DecorationType.None)
        Me.lb_5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_5.ForeColor = System.Drawing.Color.Black
        Me.lb_5.Location = New System.Drawing.Point(440, 120)
        Me.lb_5.Name = "lb_5"
        Me.lb_5.Size = New System.Drawing.Size(130, 21)
        Me.lb_5.TabIndex = 73
        Me.lb_5.Text = "Purchage Date"
        '
        'lb_3
        '
        Me.lb_3.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.lb_3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_3.ForeColor = System.Drawing.Color.Black
        Me.lb_3.Location = New System.Drawing.Point(40, 120)
        Me.lb_3.Name = "lb_3"
        Me.lb_3.Size = New System.Drawing.Size(74, 21)
        Me.lb_3.TabIndex = 72
        Me.lb_3.Text = "ISBN No."
        '
        'lb_9
        '
        Me.lb_9.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_9, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_9, BunifuAnimatorNS.DecorationType.None)
        Me.lb_9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_9.ForeColor = System.Drawing.Color.Black
        Me.lb_9.Location = New System.Drawing.Point(440, 155)
        Me.lb_9.Name = "lb_9"
        Me.lb_9.Size = New System.Drawing.Size(47, 21)
        Me.lb_9.TabIndex = 70
        Me.lb_9.Text = "Price"
        '
        'lb_11
        '
        Me.lb_11.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_11, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_11, BunifuAnimatorNS.DecorationType.None)
        Me.lb_11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_11.ForeColor = System.Drawing.Color.Black
        Me.lb_11.Location = New System.Drawing.Point(40, 190)
        Me.lb_11.Name = "lb_11"
        Me.lb_11.Size = New System.Drawing.Size(149, 21)
        Me.lb_11.TabIndex = 69
        Me.lb_11.Text = "Publication Name"
        '
        'lb_13
        '
        Me.lb_13.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_13, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_13, BunifuAnimatorNS.DecorationType.None)
        Me.lb_13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_13.ForeColor = System.Drawing.Color.Black
        Me.lb_13.Location = New System.Drawing.Point(440, 190)
        Me.lb_13.Name = "lb_13"
        Me.lb_13.Size = New System.Drawing.Size(129, 21)
        Me.lb_13.TabIndex = 68
        Me.lb_13.Text = "Volume/Edition"
        '
        'lb_7
        '
        Me.lb_7.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_7, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_7, BunifuAnimatorNS.DecorationType.None)
        Me.lb_7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_7.ForeColor = System.Drawing.Color.Black
        Me.lb_7.Location = New System.Drawing.Point(40, 155)
        Me.lb_7.Name = "lb_7"
        Me.lb_7.Size = New System.Drawing.Size(117, 21)
        Me.lb_7.TabIndex = 66
        Me.lb_7.Text = "Author Name"
        '
        'lb_15
        '
        Me.lb_15.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_15, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_15, BunifuAnimatorNS.DecorationType.None)
        Me.lb_15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_15.ForeColor = System.Drawing.Color.Black
        Me.lb_15.Location = New System.Drawing.Point(40, 225)
        Me.lb_15.Name = "lb_15"
        Me.lb_15.Size = New System.Drawing.Size(86, 21)
        Me.lb_15.TabIndex = 71
        Me.lb_15.Text = "Catagory"
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.lb_1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_1.ForeColor = System.Drawing.Color.Black
        Me.lb_1.Location = New System.Drawing.Point(40, 45)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(67, 17)
        Me.lb_1.TabIndex = 57
        Me.lb_1.Text = "Book No."
        '
        'tb_1
        '
        Me.tb_1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderThickness = 1
        Me.tb_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bvShow.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
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
        'lb_2
        '
        Me.lb_2.AutoSize = True
        Me.bvShow.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.lb_2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.ForeColor = System.Drawing.Color.Black
        Me.lb_2.Location = New System.Drawing.Point(220, 45)
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Size = New System.Drawing.Size(84, 17)
        Me.lb_2.TabIndex = 14
        Me.lb_2.Text = "Book Name"
        '
        'textbox1
        '
        Me.textbox1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.textbox1.BorderColorIdle = System.Drawing.Color.Gray
        Me.textbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.textbox1.BorderThickness = 1
        Me.textbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bvShow.SetDecoration(Me.textbox1, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me.textbox1, BunifuAnimatorNS.DecorationType.None)
        Me.textbox1.Enabled = False
        Me.textbox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox1.ForeColor = System.Drawing.Color.Black
        Me.textbox1.isPassword = False
        Me.textbox1.Location = New System.Drawing.Point(220, 65)
        Me.textbox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.textbox1.Name = "textbox1"
        Me.textbox1.Size = New System.Drawing.Size(520, 36)
        Me.textbox1.TabIndex = 91
        Me.textbox1.TabStop = False
        Me.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bvHide
        '
        Me.bvHide.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.bvHide.Cursor = Nothing
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
        Me.bvHide.DefaultAnimation = Animation2
        '
        'Book_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 589)
        Me.Controls.Add(Me.BV)
        Me.bvShow.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.bvHide.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-1000, -1000)
        Me.Name = "Book_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Book View"
        Me.BV.ResumeLayout(False)
        Me.BV.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bvShow As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents bvHide As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BV As Panel
    Friend WithEvents lb_1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_18 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_14 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_16 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_17 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tb_2 As TextBox
    Friend WithEvents textbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lb_50 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
