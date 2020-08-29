<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Deleted_Request_View
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Deleted_Request_View))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DRV = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bt_Undo = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lb_2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lb_1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tb_1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_2 = New System.Windows.Forms.TextBox()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.DRV.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DRV
        '
        Me.DRV.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DRV.BackgroundImage = CType(resources.GetObject("DRV.BackgroundImage"), System.Drawing.Image)
        Me.DRV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DRV.Controls.Add(Me.DataGridView1)
        Me.DRV.Controls.Add(Me.bt_Undo)
        Me.DRV.Controls.Add(Me.lb_2)
        Me.DRV.Controls.Add(Me.lb_1)
        Me.DRV.Controls.Add(Me.tb_1)
        Me.DRV.Controls.Add(Me.tb_2)
        Me.DRV.Controls.Add(Me.BunifuMetroTextbox1)
        Me.DRV.Location = New System.Drawing.Point(25, 5)
        Me.DRV.Name = "DRV"
        Me.DRV.Size = New System.Drawing.Size(782, 562)
        Me.DRV.TabIndex = 84
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
        Me.DataGridView1.Location = New System.Drawing.Point(41, 126)
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
        Me.DataGridView1.Size = New System.Drawing.Size(700, 388)
        Me.DataGridView1.TabIndex = 84
        '
        'bt_Undo
        '
        Me.bt_Undo.ActiveBorderThickness = 1
        Me.bt_Undo.ActiveCornerRadius = 1
        Me.bt_Undo.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Undo.ActiveForecolor = System.Drawing.Color.White
        Me.bt_Undo.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Undo.AutoScroll = True
        Me.bt_Undo.BackColor = System.Drawing.Color.White
        Me.bt_Undo.BackgroundImage = CType(resources.GetObject("bt_Undo.BackgroundImage"), System.Drawing.Image)
        Me.bt_Undo.ButtonText = "UNDO DELETE"
        Me.bt_Undo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Undo.Font = New System.Drawing.Font("Open Sans", 11.0!, System.Drawing.FontStyle.Bold)
        Me.bt_Undo.ForeColor = System.Drawing.Color.White
        Me.bt_Undo.IdleBorderThickness = 1
        Me.bt_Undo.IdleCornerRadius = 1
        Me.bt_Undo.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Undo.IdleForecolor = System.Drawing.Color.White
        Me.bt_Undo.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Undo.Location = New System.Drawing.Point(580, 59)
        Me.bt_Undo.Margin = New System.Windows.Forms.Padding(0)
        Me.bt_Undo.Name = "bt_Undo"
        Me.bt_Undo.Size = New System.Drawing.Size(160, 48)
        Me.bt_Undo.TabIndex = 3
        Me.bt_Undo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_2
        '
        Me.lb_2.AutoSize = True
        Me.lb_2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.ForeColor = System.Drawing.Color.Black
        Me.lb_2.Location = New System.Drawing.Point(223, 45)
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Size = New System.Drawing.Size(101, 17)
        Me.lb_2.TabIndex = 82
        Me.lb_2.Text = "Student Name"
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.lb_1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_1.ForeColor = System.Drawing.Color.Black
        Me.lb_1.Location = New System.Drawing.Point(40, 45)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(58, 17)
        Me.lb_1.TabIndex = 80
        Me.lb_1.Text = "Roll No."
        '
        'tb_1
        '
        Me.tb_1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderColorIdle = System.Drawing.Color.Gray
        Me.tb_1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tb_1.BorderThickness = 1
        Me.tb_1.Cursor = System.Windows.Forms.Cursors.IBeam
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
        'tb_2
        '
        Me.tb_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_2.Location = New System.Drawing.Point(223, 74)
        Me.tb_2.Name = "tb_2"
        Me.tb_2.Size = New System.Drawing.Size(336, 20)
        Me.tb_2.TabIndex = 2
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Gray
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderThickness = 1
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Enabled = False
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(221, 65)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(340, 36)
        Me.BunifuMetroTextbox1.TabIndex = 95
        Me.BunifuMetroTextbox1.TabStop = False
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Deleted_Request_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 584)
        Me.Controls.Add(Me.DRV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-1000, -1000)
        Me.Name = "Deleted_Request_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Deleted Request View"
        Me.DRV.ResumeLayout(False)
        Me.DRV.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DRV As Panel
    Friend WithEvents bt_Undo As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lb_2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lb_1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tb_1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tb_2 As TextBox
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
