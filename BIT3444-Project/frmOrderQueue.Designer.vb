<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderQueue
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
        Me.lstWaiting = New System.Windows.Forms.ListBox()
        Me.lblWaiting = New System.Windows.Forms.Label()
        Me.lblDelivered = New System.Windows.Forms.Label()
        Me.lstDelivered = New System.Windows.Forms.ListBox()
        Me.btnSolve = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEditOrder = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelCorrectingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinearOptimizationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstWaiting
        '
        Me.lstWaiting.FormattingEnabled = True
        Me.lstWaiting.ItemHeight = 16
        Me.lstWaiting.Location = New System.Drawing.Point(17, 84)
        Me.lstWaiting.Margin = New System.Windows.Forms.Padding(4)
        Me.lstWaiting.Name = "lstWaiting"
        Me.lstWaiting.Size = New System.Drawing.Size(173, 276)
        Me.lstWaiting.TabIndex = 2
        '
        'lblWaiting
        '
        Me.lblWaiting.AutoSize = True
        Me.lblWaiting.Location = New System.Drawing.Point(16, 64)
        Me.lblWaiting.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWaiting.Name = "lblWaiting"
        Me.lblWaiting.Size = New System.Drawing.Size(103, 17)
        Me.lblWaiting.TabIndex = 3
        Me.lblWaiting.Text = "Waiting Orders"
        '
        'lblDelivered
        '
        Me.lblDelivered.AutoSize = True
        Me.lblDelivered.Location = New System.Drawing.Point(232, 64)
        Me.lblDelivered.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDelivered.Name = "lblDelivered"
        Me.lblDelivered.Size = New System.Drawing.Size(116, 17)
        Me.lblDelivered.TabIndex = 5
        Me.lblDelivered.Text = "Delivered Orders"
        '
        'lstDelivered
        '
        Me.lstDelivered.FormattingEnabled = True
        Me.lstDelivered.ItemHeight = 16
        Me.lstDelivered.Location = New System.Drawing.Point(235, 85)
        Me.lstDelivered.Margin = New System.Windows.Forms.Padding(4)
        Me.lstDelivered.Name = "lstDelivered"
        Me.lstDelivered.Size = New System.Drawing.Size(177, 276)
        Me.lstDelivered.TabIndex = 8
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(12, 422)
        Me.btnSolve.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(177, 44)
        Me.btnSolve.TabIndex = 10
        Me.btnSolve.Text = "Assign Orders"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(235, 422)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(177, 44)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnEditOrder
        '
        Me.btnEditOrder.Location = New System.Drawing.Point(13, 370)
        Me.btnEditOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditOrder.Name = "btnEditOrder"
        Me.btnEditOrder.Size = New System.Drawing.Size(177, 44)
        Me.btnEditOrder.TabIndex = 14
        Me.btnEditOrder.Text = "Edit Order"
        Me.btnEditOrder.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(432, 28)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderToolStripMenuItem, Me.SortByToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelCorrectingToolStripMenuItem, Me.LinearOptimizationToolStripMenuItem})
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.OrderToolStripMenuItem.Text = "Optimization Type"
        '
        'LabelCorrectingToolStripMenuItem
        '
        Me.LabelCorrectingToolStripMenuItem.Name = "LabelCorrectingToolStripMenuItem"
        Me.LabelCorrectingToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.LabelCorrectingToolStripMenuItem.Text = "Label Correcting"
        '
        'LinearOptimizationToolStripMenuItem
        '
        Me.LinearOptimizationToolStripMenuItem.Name = "LinearOptimizationToolStripMenuItem"
        Me.LinearOptimizationToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.LinearOptimizationToolStripMenuItem.Text = "Linear Optimization"
        '
        'SortByToolStripMenuItem
        '
        Me.SortByToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AscendingToolStripMenuItem, Me.DescendingToolStripMenuItem})
        Me.SortByToolStripMenuItem.Name = "SortByToolStripMenuItem"
        Me.SortByToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.SortByToolStripMenuItem.Text = "Sort By"
        '
        'AscendingToolStripMenuItem
        '
        Me.AscendingToolStripMenuItem.Name = "AscendingToolStripMenuItem"
        Me.AscendingToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.AscendingToolStripMenuItem.Text = "Ascending"
        '
        'DescendingToolStripMenuItem
        '
        Me.DescendingToolStripMenuItem.Name = "DescendingToolStripMenuItem"
        Me.DescendingToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.DescendingToolStripMenuItem.Text = "Descending"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(86, 471)
        Me.txtTotalCost.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(104, 22)
        Me.txtTotalCost.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 490)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 18
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(9, 475)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(76, 17)
        Me.lblCost.TabIndex = 19
        Me.lblCost.Text = "Total Cost:"
        '
        'frmOrderQueue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 506)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.btnEditOrder)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.lstDelivered)
        Me.Controls.Add(Me.lblDelivered)
        Me.Controls.Add(Me.lblWaiting)
        Me.Controls.Add(Me.lstWaiting)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmOrderQueue"
        Me.Text = "Order Queue"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstWaiting As ListBox
    Friend WithEvents lblWaiting As Label
    Friend WithEvents lblDelivered As Label
    Friend WithEvents lstDelivered As ListBox
    Friend WithEvents btnSolve As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnEditOrder As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortByToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelCorrectingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinearOptimizationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AscendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCost As Label
End Class
