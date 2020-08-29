<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Faculty_Search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Faculty_Search))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.FS = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bt_Search = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lb_2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lb_1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.fsShow = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.fsHide = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.bt_Delete = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bt_Edit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bt_Issue = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bt_View = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.FS.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FS
        '
        Me.FS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FS.BackgroundImage = CType(resources.GetObject("FS.BackgroundImage"), System.Drawing.Image)
        Me.FS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FS.Controls.Add(Me.bt_Delete)
        Me.FS.Controls.Add(Me.bt_Edit)
        Me.FS.Controls.Add(Me.bt_Issue)
        Me.FS.Controls.Add(Me.bt_View)
        Me.FS.Controls.Add(Me.DataGridView1)
        Me.FS.Controls.Add(Me.bt_Search)
        Me.FS.Controls.Add(Me.lb_2)
        Me.FS.Controls.Add(Me.tb_2)
        Me.FS.Controls.Add(Me.lb_1)
        Me.FS.Controls.Add(Me.tb_1)
        Me.fsHide.SetDecoration(Me.FS, BunifuAnimatorNS.DecorationType.None)
        Me.fsShow.SetDecoration(Me.FS, BunifuAnimatorNS.DecorationType.None)
        Me.FS.Location = New System.Drawing.Point(25, 5)
        Me.FS.Name = "FS"
        Me.FS.Size = New System.Drawing.Size(782, 539)
        Me.FS.TabIndex = 80
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.fsHide.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.fsShow.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.DataGridView1.Location = New System.Drawing.Point(40, 123)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(700, 311)
        Me.DataGridView1.TabIndex = 78
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
        Me.fsHide.SetDecoration(Me.bt_Search, BunifuAnimatorNS.DecorationType.None)
        Me.fsShow.SetDecoration(Me.bt_Search, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Search.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.bt_Search.TabIndex = 77
        Me.bt_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_2
        '
        Me.lb_2.AutoSize = True
        Me.fsShow.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.fsHide.SetDecoration(Me.lb_2, BunifuAnimatorNS.DecorationType.None)
        Me.lb_2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.ForeColor = System.Drawing.Color.Black
        Me.lb_2.Location = New System.Drawing.Point(221, 45)
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
        Me.fsShow.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.fsHide.SetDecoration(Me.tb_2, BunifuAnimatorNS.DecorationType.None)
        Me.tb_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_2.ForeColor = System.Drawing.Color.Black
        Me.tb_2.isPassword = False
        Me.tb_2.Location = New System.Drawing.Point(220, 65)
        Me.tb_2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_2.Name = "tb_2"
        Me.tb_2.Size = New System.Drawing.Size(340, 36)
        Me.tb_2.TabIndex = 57
        Me.tb_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.fsShow.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
        Me.fsHide.SetDecoration(Me.lb_1, BunifuAnimatorNS.DecorationType.None)
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
        Me.fsShow.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
        Me.fsHide.SetDecoration(Me.tb_1, BunifuAnimatorNS.DecorationType.None)
        Me.tb_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_1.ForeColor = System.Drawing.Color.Black
        Me.tb_1.isPassword = False
        Me.tb_1.Location = New System.Drawing.Point(40, 65)
        Me.tb_1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_1.Name = "tb_1"
        Me.tb_1.Size = New System.Drawing.Size(160, 36)
        Me.tb_1.TabIndex = 55
        Me.tb_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'fsShow
        '
        Me.fsShow.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.fsShow.Cursor = Nothing
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
        Me.fsShow.DefaultAnimation = Animation2
        '
        'fsHide
        '
        Me.fsHide.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.fsHide.Cursor = Nothing
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
        Me.fsHide.DefaultAnimation = Animation1
        '
        'bt_Delete
        '
        Me.bt_Delete.ActiveBorderThickness = 1
        Me.bt_Delete.ActiveCornerRadius = 1
        Me.bt_Delete.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Delete.ActiveForecolor = System.Drawing.Color.White
        Me.bt_Delete.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Delete.AutoScroll = True
        Me.bt_Delete.BackColor = System.Drawing.Color.White
        Me.bt_Delete.BackgroundImage = CType(resources.GetObject("bt_Delete.BackgroundImage"), System.Drawing.Image)
        Me.bt_Delete.ButtonText = "DELETE"
        Me.bt_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fsHide.SetDecoration(Me.bt_Delete, BunifuAnimatorNS.DecorationType.None)
        Me.fsShow.SetDecoration(Me.bt_Delete, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Delete.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Delete.ForeColor = System.Drawing.Color.White
        Me.bt_Delete.IdleBorderThickness = 1
        Me.bt_Delete.IdleCornerRadius = 1
        Me.bt_Delete.IdleFillColor = System.Drawing.Color.White
        Me.bt_Delete.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Delete.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Delete.Location = New System.Drawing.Point(580, 445)
        Me.bt_Delete.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Delete.Name = "bt_Delete"
        Me.bt_Delete.Size = New System.Drawing.Size(160, 50)
        Me.bt_Delete.TabIndex = 82
        Me.bt_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_Edit
        '
        Me.bt_Edit.ActiveBorderThickness = 1
        Me.bt_Edit.ActiveCornerRadius = 1
        Me.bt_Edit.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Edit.ActiveForecolor = System.Drawing.Color.White
        Me.bt_Edit.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Edit.AutoScroll = True
        Me.bt_Edit.BackColor = System.Drawing.Color.White
        Me.bt_Edit.BackgroundImage = CType(resources.GetObject("bt_Edit.BackgroundImage"), System.Drawing.Image)
        Me.bt_Edit.ButtonText = "EDIT"
        Me.bt_Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fsHide.SetDecoration(Me.bt_Edit, BunifuAnimatorNS.DecorationType.None)
        Me.fsShow.SetDecoration(Me.bt_Edit, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Edit.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Edit.ForeColor = System.Drawing.Color.White
        Me.bt_Edit.IdleBorderThickness = 1
        Me.bt_Edit.IdleCornerRadius = 1
        Me.bt_Edit.IdleFillColor = System.Drawing.Color.White
        Me.bt_Edit.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Edit.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Edit.Location = New System.Drawing.Point(400, 445)
        Me.bt_Edit.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Edit.Name = "bt_Edit"
        Me.bt_Edit.Size = New System.Drawing.Size(160, 50)
        Me.bt_Edit.TabIndex = 81
        Me.bt_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.fsHide.SetDecoration(Me.bt_Issue, BunifuAnimatorNS.DecorationType.None)
        Me.fsShow.SetDecoration(Me.bt_Issue, BunifuAnimatorNS.DecorationType.None)
        Me.bt_Issue.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Issue.ForeColor = System.Drawing.Color.White
        Me.bt_Issue.IdleBorderThickness = 1
        Me.bt_Issue.IdleCornerRadius = 1
        Me.bt_Issue.IdleFillColor = System.Drawing.Color.White
        Me.bt_Issue.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Issue.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Issue.Location = New System.Drawing.Point(40, 445)
        Me.bt_Issue.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Issue.Name = "bt_Issue"
        Me.bt_Issue.Size = New System.Drawing.Size(160, 50)
        Me.bt_Issue.TabIndex = 80
        Me.bt_Issue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_View
        '
        Me.bt_View.ActiveBorderThickness = 1
        Me.bt_View.ActiveCornerRadius = 1
        Me.bt_View.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_View.ActiveForecolor = System.Drawing.Color.White
        Me.bt_View.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_View.AutoScroll = True
        Me.bt_View.BackColor = System.Drawing.Color.White
        Me.bt_View.BackgroundImage = CType(resources.GetObject("bt_View.BackgroundImage"), System.Drawing.Image)
        Me.bt_View.ButtonText = "VIEW"
        Me.bt_View.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fsHide.SetDecoration(Me.bt_View, BunifuAnimatorNS.DecorationType.None)
        Me.fsShow.SetDecoration(Me.bt_View, BunifuAnimatorNS.DecorationType.None)
        Me.bt_View.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_View.ForeColor = System.Drawing.Color.White
        Me.bt_View.IdleBorderThickness = 1
        Me.bt_View.IdleCornerRadius = 1
        Me.bt_View.IdleFillColor = System.Drawing.Color.White
        Me.bt_View.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_View.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_View.Location = New System.Drawing.Point(220, 445)
        Me.bt_View.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_View.Name = "bt_View"
        Me.bt_View.Size = New System.Drawing.Size(160, 50)
        Me.bt_View.TabIndex = 79
        Me.bt_View.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Faculty_Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 564)
        Me.Controls.Add(Me.FS)
        Me.fsShow.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.fsHide.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-1000, -1000)
        Me.Name = "Faculty_Search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Faculty Search"
        Me.FS.ResumeLayout(False)
        Me.FS.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FS As Panel
    Friend WithEvents bt_Search As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lb_2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lb_1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents fsHide As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents fsShow As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents bt_Delete As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bt_Edit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bt_Issue As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bt_View As Bunifu.Framework.UI.BunifuThinButton2
End Class
