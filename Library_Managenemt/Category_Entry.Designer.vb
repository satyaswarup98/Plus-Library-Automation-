<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Category_Entry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Category_Entry))
        Me.tb_1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.bt_Save = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bt_Cancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lb_1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SuspendLayout()
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
        Me.tb_1.Location = New System.Drawing.Point(56, 70)
        Me.tb_1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tb_1.Name = "tb_1"
        Me.tb_1.Size = New System.Drawing.Size(340, 36)
        Me.tb_1.TabIndex = 1
        Me.tb_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.bt_Save.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Save.ForeColor = System.Drawing.Color.White
        Me.bt_Save.IdleBorderThickness = 1
        Me.bt_Save.IdleCornerRadius = 1
        Me.bt_Save.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Save.IdleForecolor = System.Drawing.Color.White
        Me.bt_Save.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.bt_Save.Location = New System.Drawing.Point(258, 128)
        Me.bt_Save.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Save.Name = "bt_Save"
        Me.bt_Save.Size = New System.Drawing.Size(138, 50)
        Me.bt_Save.TabIndex = 2
        Me.bt_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.bt_Cancel.Location = New System.Drawing.Point(138, 128)
        Me.bt_Cancel.Margin = New System.Windows.Forms.Padding(8)
        Me.bt_Cancel.Name = "bt_Cancel"
        Me.bt_Cancel.Size = New System.Drawing.Size(114, 50)
        Me.bt_Cancel.TabIndex = 3
        Me.bt_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.lb_1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_1.ForeColor = System.Drawing.Color.Black
        Me.lb_1.Location = New System.Drawing.Point(57, 49)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(152, 17)
        Me.lb_1.TabIndex = 57
        Me.lb_1.Text = "Enter A New Category"
        '
        'Category_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(461, 218)
        Me.Controls.Add(Me.lb_1)
        Me.Controls.Add(Me.bt_Cancel)
        Me.Controls.Add(Me.bt_Save)
        Me.Controls.Add(Me.tb_1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Category_Entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents bt_Save As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bt_Cancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lb_1 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
