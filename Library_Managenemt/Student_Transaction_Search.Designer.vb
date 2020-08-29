<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Transaction_Search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Transaction_Search))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.stsShow = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.STS = New System.Windows.Forms.Panel()
        Me.lb_2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bt_Search = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lb_1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.stsHide = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.STS.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stsShow
        '
        Me.stsShow.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.stsShow.Cursor = Nothing
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
        Me.stsShow.DefaultAnimation = Animation1
        '
        'STS
        '
        Me.STS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.STS.BackgroundImage = CType(resources.GetObject("STS.BackgroundImage"), System.Drawing.Image)
        Me.STS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.STS.Controls.Add(Me.lb_2)
        Me.STS.Controls.Add(Me.tb_2)
        Me.STS.Controls.Add(Me.DataGridView1)
        Me.STS.Controls.Add(Me.bt_Search)
        Me.STS.Controls.Add(Me.lb_1)
        Me.STS.Controls.Add(Me.tb_1)
        Me.stsHide.SetDecoration(Me.STS, BunifuAnimatorNS.DecorationType.None)
        Me.stsShow.SetDecoration(Me.STS, BunifuAnimatorNS.DecorationType.None)
        Me.STS.Location = New System.Drawing.Point(25, 5)
        Me.STS.Name = "STS"
        Me.STS.Size = New System.Drawing.Size(782, 529)
        Me.STS.TabIndex = 59
        '
        'lb_2
        '
        Me.lb_2.AutoSize = True
        Me.stsShow.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.stsHide.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.lb_2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.ForeColor = System.Drawing.Color.Black
        Me.lb_2.Location = New System.Drawing.Point(213, 45)
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Size = New System.Drawing.Size(101, 17)
        Me.lb_2.TabIndex = 80
        Me.lb_2.Text = "Student Name"
        '
        'tb_2
        '
        Me.tb_2.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderThickness = 1
        Me.tb_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.stsShow.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.stsHide.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.tb_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_2.ForeColor = System.Drawing.Color.Black
        Me.tb_2.isPassword = False
        Me.tb_2.Location = New System.Drawing.Point(215, 65)
        Me.tb_2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_2.Name = "tb_2"
        Me.tb_2.Size = New System.Drawing.Size(340, 36)
        Me.tb_2.TabIndex = 79
        Me.tb_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stsHide.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.stsShow.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.DataGridView1.Location = New System.Drawing.Point(40, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(700, 348)
        Me.DataGridView1.TabIndex = 55
        '
        'bt_Search
        '
        Me.bt_Search.ActiveBorderThickness = 1
        Me.bt_Search.ActiveCornerRadius = 1
        Me.bt_Search.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Search.ActiveForecolor = System.Drawing.Color.White
        Me.bt_Search.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Search.AutoScroll = True
        Me.bt_Search.BackColor = System.Drawing.Color.White
        Me.bt_Search.BackgroundImage = CType(resources.GetObject("bt_Search.BackgroundImage"), System.Drawing.Image)
        Me.bt_Search.ButtonText = "SEARCH"
        Me.bt_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.stsHide.SetDecoration(Me.bt_Search, BunifuAnimatorNS.DecorationType.None)
        Me.stsShow.SetDecoration(Me.bt_Search, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Search.Font = New System.Drawing.Font("Open Sans", 11.0!, System.Drawing.FontStyle.Bold)
        Me.bt_Search.ForeColor = System.Drawing.Color.White
        Me.bt_Search.IdleBorderThickness = 1
        Me.bt_Search.IdleCornerRadius = 1
        Me.bt_Search.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Search.IdleForecolor = System.Drawing.Color.White
        Me.bt_Search.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Search.Location = New System.Drawing.Point(580, 59)
        Me.bt_Search.Margin = New System.Windows.Forms.Padding(0)
        Me.bt_Search.Name = "bt_Search"
        Me.bt_Search.Size = New System.Drawing.Size(160, 48)
        Me.bt_Search.TabIndex = 54
        Me.bt_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.stsShow.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.stsHide.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.lb_1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_1.ForeColor = System.Drawing.Color.Black
        Me.lb_1.Location = New System.Drawing.Point(40, 45)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(58, 17)
        Me.lb_1.TabIndex = 28
        Me.lb_1.Text = "Roll No."
        '
        'tb_1
        '
        Me.tb_1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderThickness = 1
        Me.tb_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.stsShow.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
        Me.stsHide.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
        Me.tb_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_1.ForeColor = System.Drawing.Color.Black
        Me.tb_1.isPassword = False
        Me.tb_1.Location = New System.Drawing.Point(40, 65)
        Me.tb_1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_1.Name = "tb_1"
        Me.tb_1.Size = New System.Drawing.Size(160, 36)
        Me.tb_1.TabIndex = 27
        Me.tb_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'stsHide
        '
        Me.stsHide.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.stsHide.Cursor = Nothing
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
        Me.stsHide.DefaultAnimation = Animation2
        '
        'Student_Transaction_Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 554)
        Me.Controls.Add(Me.STS)
        Me.stsShow.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.stsHide.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-1000, -1000)
        Me.Name = "Student_Transaction_Search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Student Transaction Search"
        Me.STS.ResumeLayout(False)
        Me.STS.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents stsShow As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents stsHide As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents STS As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bt_Search As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lb_1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_2 As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
