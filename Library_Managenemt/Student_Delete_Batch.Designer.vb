<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Delete_Batch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Delete_Batch))
        Me.SR = New System.Windows.Forms.Panel()
        Me.bt_Cancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bt_Delete = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lb_6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dd_2 = New System.Windows.Forms.ComboBox()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.SR.SuspendLayout()
        Me.SuspendLayout()
        '
        'SR
        '
        Me.SR.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SR.BackgroundImage = CType(resources.GetObject("SR.BackgroundImage"), System.Drawing.Image)
        Me.SR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SR.Controls.Add(Me.bt_Cancel)
        Me.SR.Controls.Add(Me.bt_Delete)
        Me.SR.Controls.Add(Me.lb_6)
        Me.SR.Controls.Add(Me.dd_2)
        Me.SR.Controls.Add(Me.BunifuMetroTextbox1)
        Me.SR.Location = New System.Drawing.Point(25, 76)
        Me.SR.Name = "SR"
        Me.SR.Size = New System.Drawing.Size(782, 250)
        Me.SR.TabIndex = 57
        '
        'bt_Cancel
        '
        Me.bt_Cancel.ActiveBorderThickness = 1
        Me.bt_Cancel.ActiveCornerRadius = 1
        Me.bt_Cancel.ActiveFillColor = System.Drawing.Color.White
        Me.bt_Cancel.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Cancel.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Cancel.AutoScroll = True
        Me.bt_Cancel.BackColor = System.Drawing.Color.White
        Me.bt_Cancel.BackgroundImage = CType(resources.GetObject("bt_Cancel.BackgroundImage"), System.Drawing.Image)
        Me.bt_Cancel.ButtonText = "CANCEL"
        Me.bt_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Cancel.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Cancel.IdleBorderThickness = 1
        Me.bt_Cancel.IdleCornerRadius = 1
        Me.bt_Cancel.IdleFillColor = System.Drawing.Color.White
        Me.bt_Cancel.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Cancel.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bt_Cancel.Location = New System.Drawing.Point(584, 105)
        Me.bt_Cancel.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Cancel.Name = "bt_Cancel"
        Me.bt_Cancel.Size = New System.Drawing.Size(156, 50)
        Me.bt_Cancel.TabIndex = 80
        Me.bt_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.bt_Delete.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Delete.ForeColor = System.Drawing.Color.White
        Me.bt_Delete.IdleBorderThickness = 1
        Me.bt_Delete.IdleCornerRadius = 1
        Me.bt_Delete.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Delete.IdleForecolor = System.Drawing.Color.White
        Me.bt_Delete.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Delete.Location = New System.Drawing.Point(394, 105)
        Me.bt_Delete.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Delete.Name = "bt_Delete"
        Me.bt_Delete.Size = New System.Drawing.Size(182, 50)
        Me.bt_Delete.TabIndex = 79
        Me.bt_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_6
        '
        Me.lb_6.AutoSize = True
        Me.lb_6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_6.ForeColor = System.Drawing.Color.Black
        Me.lb_6.Location = New System.Drawing.Point(41, 91)
        Me.lb_6.Name = "lb_6"
        Me.lb_6.Size = New System.Drawing.Size(52, 17)
        Me.lb_6.TabIndex = 38
        Me.lb_6.Text = "Session"
        '
        'dd_2
        '
        Me.dd_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dd_2.DropDownWidth = 154
        Me.dd_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dd_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd_2.ForeColor = System.Drawing.Color.Black
        Me.dd_2.FormattingEnabled = True
        Me.dd_2.IntegralHeight = False
        Me.dd_2.ItemHeight = 21
        Me.dd_2.Location = New System.Drawing.Point(43, 115)
        Me.dd_2.Name = "dd_2"
        Me.dd_2.Size = New System.Drawing.Size(335, 29)
        Me.dd_2.TabIndex = 5
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Gray
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderThickness = 1
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(41, 111)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(340, 36)
        Me.BunifuMetroTextbox1.TabIndex = 78
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Student_Delete_Bathch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(824, 362)
        Me.Controls.Add(Me.SR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-1000, -1000)
        Me.Name = "Student_Delete_Bathch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Student Delete Bathch"
        Me.SR.ResumeLayout(False)
        Me.SR.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SR As Panel
    Friend WithEvents dd_2 As ComboBox
    Friend WithEvents lb_6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents bt_Delete As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bt_Cancel As Bunifu.Framework.UI.BunifuThinButton2
End Class
