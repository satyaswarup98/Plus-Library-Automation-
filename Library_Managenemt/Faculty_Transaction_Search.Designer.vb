<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Faculty_Transaction_Search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Faculty_Transaction_Search))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.ftsShow = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.FTS = New System.Windows.Forms.Panel()
        Me.lb_2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuMetroTextbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bt_Search = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.ftsHide = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.FTS.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ftsShow
        '
        Me.ftsShow.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.ftsShow.Cursor = Nothing
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
        Me.ftsShow.DefaultAnimation = Animation1
        '
        'FTS
        '
        Me.FTS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FTS.BackgroundImage = CType(resources.GetObject("FTS.BackgroundImage"), System.Drawing.Image)
        Me.FTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FTS.Controls.Add(Me.lb_2)
        Me.FTS.Controls.Add(Me.tb_2)
        Me.FTS.Controls.Add(Me.lb_1)
        Me.FTS.Controls.Add(Me.BunifuMetroTextbox2)
        Me.FTS.Controls.Add(Me.DataGridView1)
        Me.FTS.Controls.Add(Me.bt_Search)
        Me.ftsHide.SetDecoration(Me.FTS, BunifuAnimatorNS.DecorationType.None)
        Me.ftsShow.SetDecoration(Me.FTS, BunifuAnimatorNS.DecorationType.None)
        Me.FTS.Location = New System.Drawing.Point(25, 5)
        Me.FTS.Name = "FTS"
        Me.FTS.Size = New System.Drawing.Size(782, 529)
        Me.FTS.TabIndex = 60
        '
        'lb_2
        '
        Me.lb_2.AutoSize = True
        Me.ftsShow.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.ftsHide.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.lb_2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.ForeColor = System.Drawing.Color.Black
        Me.lb_2.Location = New System.Drawing.Point(221, 45)
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Size = New System.Drawing.Size(48, 17)
        Me.lb_2.TabIndex = 85
        Me.lb_2.Text = "Name"
        '
        'tb_2
        '
        Me.tb_2.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_2.BorderThickness = 1
        Me.tb_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ftsShow.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.ftsHide.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.tb_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_2.ForeColor = System.Drawing.Color.Black
        Me.tb_2.isPassword = False
        Me.tb_2.Location = New System.Drawing.Point(220, 65)
        Me.tb_2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_2.Name = "tb_2"
        Me.tb_2.Size = New System.Drawing.Size(340, 36)
        Me.tb_2.TabIndex = 84
        Me.tb_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.ftsShow.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.ftsHide.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.lb_1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_1.ForeColor = System.Drawing.Color.Black
        Me.lb_1.Location = New System.Drawing.Point(38, 45)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(70, 17)
        Me.lb_1.TabIndex = 83
        Me.lb_1.Text = "Faculty ID"
        '
        'BunifuMetroTextbox2
        '
        Me.BunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.Gray
        Me.BunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderThickness = 1
        Me.BunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ftsShow.SetDecoration(Me.BunifuMetroTextbox2, BunifuAnimatorNS.DecorationType.None)
        Me.ftsHide.SetDecoration(Me.BunifuMetroTextbox2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMetroTextbox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox2.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox2.isPassword = False
        Me.BunifuMetroTextbox2.Location = New System.Drawing.Point(38, 65)
        Me.BunifuMetroTextbox2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextbox2.Name = "BunifuMetroTextbox2"
        Me.BunifuMetroTextbox2.Size = New System.Drawing.Size(160, 36)
        Me.BunifuMetroTextbox2.TabIndex = 82
        Me.BunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ftsHide.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.ftsShow.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.DataGridView1.Location = New System.Drawing.Point(40, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(700, 355)
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
        Me.ftsHide.SetDecoration(Me.bt_Search, BunifuAnimatorNS.DecorationType.None)
        Me.ftsShow.SetDecoration(Me.bt_Search, BunifuAnimatorNS.DecorationType.None)
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
        'ftsHide
        '
        Me.ftsHide.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.ftsHide.Cursor = Nothing
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
        Me.ftsHide.DefaultAnimation = Animation2
        '
        'Faculty_Transaction_Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 554)
        Me.Controls.Add(Me.FTS)
        Me.ftsShow.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.ftsHide.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-1000, -1000)
        Me.Name = "Faculty_Transaction_Search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Faculty Transaction Search"
        Me.FTS.ResumeLayout(False)
        Me.FTS.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ftsShow As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents ftsHide As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents FTS As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bt_Search As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lb_2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuMetroTextbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
