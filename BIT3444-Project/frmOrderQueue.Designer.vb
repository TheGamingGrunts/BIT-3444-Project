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
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.lstWaiting = New System.Windows.Forms.ListBox()
        Me.lblWaiting = New System.Windows.Forms.Label()
        Me.lblDelivered = New System.Windows.Forms.Label()
        Me.lstDelivered = New System.Windows.Forms.ListBox()
        Me.btnSolve = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRemoveOrder = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
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
        'btnAddOrder
        '
        Me.btnAddOrder.Location = New System.Drawing.Point(10, 344)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(133, 36)
        Me.btnAddOrder.TabIndex = 1
        Me.btnAddOrder.Text = "Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = True
        '
        'lstWaiting
        '
        Me.lstWaiting.FormattingEnabled = True
        Me.lstWaiting.Location = New System.Drawing.Point(13, 68)
        Me.lstWaiting.Name = "lstWaiting"
        Me.lstWaiting.Size = New System.Drawing.Size(131, 225)
        Me.lstWaiting.TabIndex = 2
        '
        'lblWaiting
        '
        Me.lblWaiting.AutoSize = True
        Me.lblWaiting.Location = New System.Drawing.Point(12, 52)
        Me.lblWaiting.Name = "lblWaiting"
        Me.lblWaiting.Size = New System.Drawing.Size(77, 13)
        Me.lblWaiting.TabIndex = 3
        Me.lblWaiting.Text = "Waiting Orders"
        '
        'lblDelivered
        '
        Me.lblDelivered.AutoSize = True
        Me.lblDelivered.Location = New System.Drawing.Point(174, 52)
        Me.lblDelivered.Name = "lblDelivered"
        Me.lblDelivered.Size = New System.Drawing.Size(86, 13)
        Me.lblDelivered.TabIndex = 5
        Me.lblDelivered.Text = "Delivered Orders"
        '
        'lstDelivered
        '
        Me.lstDelivered.FormattingEnabled = True
        Me.lstDelivered.Location = New System.Drawing.Point(176, 69)
        Me.lstDelivered.Name = "lstDelivered"
        Me.lstDelivered.Size = New System.Drawing.Size(134, 225)
        Me.lstDelivered.TabIndex = 8
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(10, 386)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(133, 36)
        Me.btnSolve.TabIndex = 10
        Me.btnSolve.Text = "Assign Orders"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(232, 421)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 36)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRemoveOrder
        '
        Me.btnRemoveOrder.Location = New System.Drawing.Point(10, 301)
        Me.btnRemoveOrder.Name = "btnRemoveOrder"
        Me.btnRemoveOrder.Size = New System.Drawing.Size(133, 36)
        Me.btnRemoveOrder.TabIndex = 14
        Me.btnRemoveOrder.Text = "Remove Order"
        Me.btnRemoveOrder.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(176, 301)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(133, 36)
        Me.btnSettings.TabIndex = 15
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(324, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderToolStripMenuItem, Me.SortByToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelCorrectingToolStripMenuItem, Me.LinearOptimizationToolStripMenuItem})
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.OrderToolStripMenuItem.Text = "Optimization Type"
        '
        'LabelCorrectingToolStripMenuItem
        '
        Me.LabelCorrectingToolStripMenuItem.Name = "LabelCorrectingToolStripMenuItem"
        Me.LabelCorrectingToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.LabelCorrectingToolStripMenuItem.Text = "Label Correcting"
        '
        'LinearOptimizationToolStripMenuItem
        '
        Me.LinearOptimizationToolStripMenuItem.Name = "LinearOptimizationToolStripMenuItem"
        Me.LinearOptimizationToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.LinearOptimizationToolStripMenuItem.Text = "Linear Optimization"
        '
        'SortByToolStripMenuItem
        '
        Me.SortByToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AscendingToolStripMenuItem, Me.DescendingToolStripMenuItem})
        Me.SortByToolStripMenuItem.Name = "SortByToolStripMenuItem"
        Me.SortByToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.SortByToolStripMenuItem.Text = "Sort By"
        '
        'AscendingToolStripMenuItem
        '
        Me.AscendingToolStripMenuItem.Name = "AscendingToolStripMenuItem"
        Me.AscendingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AscendingToolStripMenuItem.Text = "Ascending"
        '
        'DescendingToolStripMenuItem
        '
        Me.DescendingToolStripMenuItem.Name = "DescendingToolStripMenuItem"
        Me.DescendingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DescendingToolStripMenuItem.Text = "Descending"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(64, 439)
        Me.txtTotalCost.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(79, 20)
        Me.txtTotalCost.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 454)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 18
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(6, 442)
        Me.lblCost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(58, 13)
        Me.lblCost.TabIndex = 19
        Me.lblCost.Text = "Total Cost:"
        '
        'frmOrderQueue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 475)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnRemoveOrder)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.lstDelivered)
        Me.Controls.Add(Me.lblDelivered)
        Me.Controls.Add(Me.lblWaiting)
        Me.Controls.Add(Me.lstWaiting)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmOrderQueue"
        Me.Text = "Order Queue"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents lstWaiting As ListBox
    Friend WithEvents lblWaiting As Label
    Friend WithEvents lblDelivered As Label
    Friend WithEvents lstDelivered As ListBox
    Friend WithEvents btnSolve As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRemoveOrder As Button
    Friend WithEvents btnSettings As Button
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
