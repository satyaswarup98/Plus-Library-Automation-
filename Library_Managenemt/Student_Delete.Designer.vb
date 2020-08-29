<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Delete
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Delete))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.sdShow = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BS = New System.Windows.Forms.Panel()
        Me.tb_2 = New System.Windows.Forms.TextBox()
        Me.bt_Save = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bt_Reset = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_3 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_18 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_14 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_16 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_17 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.sdHide = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BS.SuspendLayout()
        Me.SuspendLayout()
        '
        'sdShow
        '
        Me.sdShow.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.sdShow.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.sdShow.DefaultAnimation = Animation1
        '
        'BS
        '
        Me.BS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BS.BackgroundImage = CType(resources.GetObject("BS.BackgroundImage"), System.Drawing.Image)
        Me.BS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BS.Controls.Add(Me.tb_2)
        Me.BS.Controls.Add(Me.bt_Save)
        Me.BS.Controls.Add(Me.bt_Reset)
        Me.BS.Controls.Add(Me.BunifuCustomLabel3)
        Me.BS.Controls.Add(Me.BunifuCustomLabel4)
        Me.BS.Controls.Add(Me.tb_3)
        Me.BS.Controls.Add(Me.lb_12)
        Me.BS.Controls.Add(Me.BunifuCustomLabel2)
        Me.BS.Controls.Add(Me.lb_18)
        Me.BS.Controls.Add(Me.lb_6)
        Me.BS.Controls.Add(Me.lb_4)
        Me.BS.Controls.Add(Me.lb_10)
        Me.BS.Controls.Add(Me.lb_14)
        Me.BS.Controls.Add(Me.lb_8)
        Me.BS.Controls.Add(Me.lb_16)
        Me.BS.Controls.Add(Me.lb_17)
        Me.BS.Controls.Add(Me.lb_5)
        Me.BS.Controls.Add(Me.lb_3)
        Me.BS.Controls.Add(Me.lb_9)
        Me.BS.Controls.Add(Me.lb_13)
        Me.BS.Controls.Add(Me.lb_7)
        Me.BS.Controls.Add(Me.lb_15)
        Me.BS.Controls.Add(Me.lb_1)
        Me.BS.Controls.Add(Me.tb_1)
        Me.BS.Controls.Add(Me.lb_2)
        Me.BS.Controls.Add(Me.BunifuMetroTextbox1)
        Me.sdHide.SetDecoration(Me.BS, BunifuAnimatorNS.DecorationType.None)
        Me.sdShow.SetDecoration(Me.BS, BunifuAnimatorNS.DecorationType.None)
        Me.BS.Location = New System.Drawing.Point(25, 32)
        Me.BS.Name = "BS"
        Me.BS.Size = New System.Drawing.Size(782, 472)
        Me.BS.TabIndex = 62
        '
        'tb_2
        '
        Me.tb_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sdShow.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.tb_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_2.Location = New System.Drawing.Point(223, 74)
        Me.tb_2.Name = "tb_2"
        Me.tb_2.Size = New System.Drawing.Size(515, 20)
        Me.tb_2.TabIndex = 2
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
        Me.bt_Save.ButtonText = "DELETE"
        Me.bt_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sdHide.SetDecoration(Me.bt_Save, BunifuAnimatorNS.DecorationType.None)
        Me.sdShow.SetDecoration(Me.bt_Save, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Save.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Save.ForeColor = System.Drawing.Color.White
        Me.bt_Save.IdleBorderThickness = 1
        Me.bt_Save.IdleCornerRadius = 1
        Me.bt_Save.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Save.IdleForecolor = System.Drawing.Color.White
        Me.bt_Save.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Save.Location = New System.Drawing.Point(580, 382)
        Me.bt_Save.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Save.Name = "bt_Save"
        Me.bt_Save.Size = New System.Drawing.Size(160, 50)
        Me.bt_Save.TabIndex = 4
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
        Me.sdHide.SetDecoration(Me.bt_Reset, BunifuAnimatorNS.DecorationType.None)
        Me.sdShow.SetDecoration(Me.bt_Reset, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Reset.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.IdleBorderThickness = 1
        Me.bt_Reset.IdleCornerRadius = 1
        Me.bt_Reset.IdleFillColor = System.Drawing.Color.White
        Me.bt_Reset.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Reset.Location = New System.Drawing.Point(453, 382)
        Me.bt_Reset.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Reset.Name = "bt_Reset"
        Me.bt_Reset.Size = New System.Drawing.Size(115, 50)
        Me.bt_Reset.TabIndex = 5
        Me.bt_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.sdShow.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(602, 341)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(138, 17)
        Me.BunifuCustomLabel3.TabIndex = 90
        Me.BunifuCustomLabel3.Text = "Eg. Retired, Transfered"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.sdShow.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(40, 282)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(184, 17)
        Me.BunifuCustomLabel4.TabIndex = 89
        Me.BunifuCustomLabel4.Text = "Reason for Record Deletion"
        '
        'tb_3
        '
        Me.tb_3.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_3.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_3.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_3.BorderThickness = 1
        Me.tb_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sdShow.SetDecoration(Me.tb_3, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.tb_3, BunifuAnimatorNS.DecorationType.None)
        Me.tb_3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_3.ForeColor = System.Drawing.Color.Black
        Me.tb_3.isPassword = False
        Me.tb_3.Location = New System.Drawing.Point(40, 302)
        Me.tb_3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_3.Name = "tb_3"
        Me.tb_3.Size = New System.Drawing.Size(700, 36)
        Me.tb_3.TabIndex = 3
        Me.tb_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_12
        '
        Me.lb_12.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_12, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_12, BunifuAnimatorNS.DecorationType.None)
        Me.lb_12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_12.ForeColor = System.Drawing.Color.Black
        Me.lb_12.Location = New System.Drawing.Point(136, 163)
        Me.lb_12.Name = "lb_12"
        Me.lb_12.Size = New System.Drawing.Size(14, 21)
        Me.lb_12.TabIndex = 84
        Me.lb_12.Text = ":"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.sdShow.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(39, 163)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(66, 21)
        Me.BunifuCustomLabel2.TabIndex = 83
        Me.BunifuCustomLabel2.Text = "Roll No."
        '
        'lb_18
        '
        Me.lb_18.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_18, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_18, BunifuAnimatorNS.DecorationType.None)
        Me.lb_18.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_18.ForeColor = System.Drawing.Color.Black
        Me.lb_18.Location = New System.Drawing.Point(566, 241)
        Me.lb_18.Name = "lb_18"
        Me.lb_18.Size = New System.Drawing.Size(14, 21)
        Me.lb_18.TabIndex = 82
        Me.lb_18.Text = ":"
        '
        'lb_6
        '
        Me.lb_6.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_6, BunifuAnimatorNS.DecorationType.None)
        Me.lb_6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_6.ForeColor = System.Drawing.Color.Black
        Me.lb_6.Location = New System.Drawing.Point(566, 124)
        Me.lb_6.Name = "lb_6"
        Me.lb_6.Size = New System.Drawing.Size(14, 21)
        Me.lb_6.TabIndex = 81
        Me.lb_6.Text = ":"
        '
        'lb_4
        '
        Me.lb_4.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_4, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_4, BunifuAnimatorNS.DecorationType.None)
        Me.lb_4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_4.ForeColor = System.Drawing.Color.Black
        Me.lb_4.Location = New System.Drawing.Point(137, 124)
        Me.lb_4.Name = "lb_4"
        Me.lb_4.Size = New System.Drawing.Size(14, 21)
        Me.lb_4.TabIndex = 80
        Me.lb_4.Text = ":"
        '
        'lb_10
        '
        Me.lb_10.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_10, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_10, BunifuAnimatorNS.DecorationType.None)
        Me.lb_10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_10.ForeColor = System.Drawing.Color.Black
        Me.lb_10.Location = New System.Drawing.Point(566, 163)
        Me.lb_10.Name = "lb_10"
        Me.lb_10.Size = New System.Drawing.Size(14, 21)
        Me.lb_10.TabIndex = 78
        Me.lb_10.Text = ":"
        '
        'lb_14
        '
        Me.lb_14.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_14, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_14, BunifuAnimatorNS.DecorationType.None)
        Me.lb_14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_14.ForeColor = System.Drawing.Color.Black
        Me.lb_14.Location = New System.Drawing.Point(566, 202)
        Me.lb_14.Name = "lb_14"
        Me.lb_14.Size = New System.Drawing.Size(14, 21)
        Me.lb_14.TabIndex = 76
        Me.lb_14.Text = ":"
        '
        'lb_8
        '
        Me.lb_8.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_8, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_8, BunifuAnimatorNS.DecorationType.None)
        Me.lb_8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_8.ForeColor = System.Drawing.Color.Black
        Me.lb_8.Location = New System.Drawing.Point(165, 202)
        Me.lb_8.MaximumSize = New System.Drawing.Size(250, 70)
        Me.lb_8.Name = "lb_8"
        Me.lb_8.Size = New System.Drawing.Size(14, 21)
        Me.lb_8.TabIndex = 75
        Me.lb_8.Text = ":"
        '
        'lb_16
        '
        Me.lb_16.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_16, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_16, BunifuAnimatorNS.DecorationType.None)
        Me.lb_16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_16.ForeColor = System.Drawing.Color.Black
        Me.lb_16.Location = New System.Drawing.Point(137, 241)
        Me.lb_16.Name = "lb_16"
        Me.lb_16.Size = New System.Drawing.Size(14, 21)
        Me.lb_16.TabIndex = 79
        Me.lb_16.Text = ":"
        '
        'lb_17
        '
        Me.lb_17.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_17, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_17, BunifuAnimatorNS.DecorationType.None)
        Me.lb_17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_17.ForeColor = System.Drawing.Color.Black
        Me.lb_17.Location = New System.Drawing.Point(434, 241)
        Me.lb_17.Name = "lb_17"
        Me.lb_17.Size = New System.Drawing.Size(62, 21)
        Me.lb_17.TabIndex = 74
        Me.lb_17.Text = "Mobile"
        '
        'lb_5
        '
        Me.lb_5.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_5, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_5, BunifuAnimatorNS.DecorationType.None)
        Me.lb_5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_5.ForeColor = System.Drawing.Color.Black
        Me.lb_5.Location = New System.Drawing.Point(434, 124)
        Me.lb_5.Name = "lb_5"
        Me.lb_5.Size = New System.Drawing.Size(111, 21)
        Me.lb_5.TabIndex = 73
        Me.lb_5.Text = "Date Of Birth"
        '
        'lb_3
        '
        Me.lb_3.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_3, BunifuAnimatorNS.DecorationType.None)
        Me.lb_3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_3.ForeColor = System.Drawing.Color.Black
        Me.lb_3.Location = New System.Drawing.Point(40, 124)
        Me.lb_3.Name = "lb_3"
        Me.lb_3.Size = New System.Drawing.Size(58, 21)
        Me.lb_3.TabIndex = 72
        Me.lb_3.Text = "Name"
        '
        'lb_9
        '
        Me.lb_9.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_9, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_9, BunifuAnimatorNS.DecorationType.None)
        Me.lb_9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_9.ForeColor = System.Drawing.Color.Black
        Me.lb_9.Location = New System.Drawing.Point(434, 163)
        Me.lb_9.Name = "lb_9"
        Me.lb_9.Size = New System.Drawing.Size(63, 21)
        Me.lb_9.TabIndex = 70
        Me.lb_9.Text = "Session"
        '
        'lb_13
        '
        Me.lb_13.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_13, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_13, BunifuAnimatorNS.DecorationType.None)
        Me.lb_13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_13.ForeColor = System.Drawing.Color.Black
        Me.lb_13.Location = New System.Drawing.Point(434, 202)
        Me.lb_13.Name = "lb_13"
        Me.lb_13.Size = New System.Drawing.Size(107, 21)
        Me.lb_13.TabIndex = 68
        Me.lb_13.Text = "Blood Group"
        '
        'lb_7
        '
        Me.lb_7.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_7, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_7, BunifuAnimatorNS.DecorationType.None)
        Me.lb_7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_7.ForeColor = System.Drawing.Color.Black
        Me.lb_7.Location = New System.Drawing.Point(40, 202)
        Me.lb_7.Name = "lb_7"
        Me.lb_7.Size = New System.Drawing.Size(119, 21)
        Me.lb_7.TabIndex = 66
        Me.lb_7.Text = "Fathers Name"
        '
        'lb_15
        '
        Me.lb_15.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_15, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_15, BunifuAnimatorNS.DecorationType.None)
        Me.lb_15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_15.ForeColor = System.Drawing.Color.Black
        Me.lb_15.Location = New System.Drawing.Point(40, 241)
        Me.lb_15.Name = "lb_15"
        Me.lb_15.Size = New System.Drawing.Size(77, 21)
        Me.lb_15.TabIndex = 71
        Me.lb_15.Text = "E-mail ID"
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.sdShow.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.lb_1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_1.ForeColor = System.Drawing.Color.Black
        Me.lb_1.Location = New System.Drawing.Point(40, 45)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(54, 17)
        Me.lb_1.TabIndex = 57
        Me.lb_1.Text = "Roll No"
        '
        'tb_1
        '
        Me.tb_1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderThickness = 1
        Me.tb_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sdShow.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
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
        Me.sdShow.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.lb_2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.ForeColor = System.Drawing.Color.Black
        Me.lb_2.Location = New System.Drawing.Point(220, 45)
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Size = New System.Drawing.Size(101, 17)
        Me.lb_2.TabIndex = 14
        Me.lb_2.Text = "Student Name"
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Gray
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderThickness = 1
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sdShow.SetDecoration(Me.BunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me.BunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMetroTextbox1.Enabled = False
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(220, 65)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(520, 36)
        Me.BunifuMetroTextbox1.TabIndex = 94
        Me.BunifuMetroTextbox1.TabStop = False
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'sdHide
        '
        Me.sdHide.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.sdHide.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.sdHide.DefaultAnimation = Animation2
        '
        'Student_Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 591)
        Me.Controls.Add(Me.BS)
        Me.sdShow.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.sdHide.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-1000, -1000)
        Me.Name = "Student_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Student Delete"
        Me.BS.ResumeLayout(False)
        Me.BS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sdShow As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents sdHide As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BS As Panel
    Friend WithEvents lb_12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_18 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_14 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_16 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_17 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bt_Save As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bt_Reset As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_3 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_2 As TextBox
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
