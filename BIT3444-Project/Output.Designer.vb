<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutput
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
        Me.rdoSolver = New System.Windows.Forms.RadioButton()
        Me.rdoLabelCorr = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Location = New System.Drawing.Point(13, 361)
        Me.btnAddOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(177, 44)
        Me.btnAddOrder.TabIndex = 1
        Me.btnAddOrder.Text = "Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = True
        '
        'lstWaiting
        '
        Me.lstWaiting.FormattingEnabled = True
        Me.lstWaiting.ItemHeight = 16
        Me.lstWaiting.Location = New System.Drawing.Point(17, 31)
        Me.lstWaiting.Margin = New System.Windows.Forms.Padding(4)
        Me.lstWaiting.Name = "lstWaiting"
        Me.lstWaiting.Size = New System.Drawing.Size(173, 244)
        Me.lstWaiting.TabIndex = 2
        '
        'lblWaiting
        '
        Me.lblWaiting.AutoSize = True
        Me.lblWaiting.Location = New System.Drawing.Point(16, 11)
        Me.lblWaiting.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWaiting.Name = "lblWaiting"
        Me.lblWaiting.Size = New System.Drawing.Size(103, 17)
        Me.lblWaiting.TabIndex = 3
        Me.lblWaiting.Text = "Waiting Orders"
        '
        'lblDelivered
        '
        Me.lblDelivered.AutoSize = True
        Me.lblDelivered.Location = New System.Drawing.Point(232, 11)
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
        Me.lstDelivered.Location = New System.Drawing.Point(235, 32)
        Me.lstDelivered.Margin = New System.Windows.Forms.Padding(4)
        Me.lstDelivered.Name = "lstDelivered"
        Me.lstDelivered.Size = New System.Drawing.Size(177, 244)
        Me.lstDelivered.TabIndex = 8
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(13, 422)
        Me.btnSolve.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(177, 44)
        Me.btnSolve.TabIndex = 10
        Me.btnSolve.Text = "Assign Orders"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'rdoSolver
        '
        Me.rdoSolver.AutoSize = True
        Me.rdoSolver.Location = New System.Drawing.Point(17, 294)
        Me.rdoSolver.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSolver.Name = "rdoSolver"
        Me.rdoSolver.Size = New System.Drawing.Size(151, 21)
        Me.rdoSolver.TabIndex = 11
        Me.rdoSolver.TabStop = True
        Me.rdoSolver.Text = "Linear Optimization"
        Me.rdoSolver.UseVisualStyleBackColor = True
        '
        'rdoLabelCorr
        '
        Me.rdoLabelCorr.AutoSize = True
        Me.rdoLabelCorr.Location = New System.Drawing.Point(17, 323)
        Me.rdoLabelCorr.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoLabelCorr.Name = "rdoLabelCorr"
        Me.rdoLabelCorr.Size = New System.Drawing.Size(133, 21)
        Me.rdoLabelCorr.TabIndex = 12
        Me.rdoLabelCorr.TabStop = True
        Me.rdoLabelCorr.Text = "Label Correcting"
        Me.rdoLabelCorr.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(310, 422)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(102, 44)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmOutput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 480)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.rdoLabelCorr)
        Me.Controls.Add(Me.rdoSolver)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.lstDelivered)
        Me.Controls.Add(Me.lblDelivered)
        Me.Controls.Add(Me.lblWaiting)
        Me.Controls.Add(Me.lstWaiting)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmOutput"
        Me.Text = "Output"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents lstWaiting As ListBox
    Friend WithEvents lblWaiting As Label
    Friend WithEvents lblDelivered As Label
    Friend WithEvents lstDelivered As ListBox
    Friend WithEvents btnSolve As Button
    Friend WithEvents rdoSolver As RadioButton
    Friend WithEvents rdoLabelCorr As RadioButton
    Friend WithEvents btnClose As Button
End Class
