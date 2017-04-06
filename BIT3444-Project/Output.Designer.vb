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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSolve = New System.Windows.Forms.Button()
        Me.rdoSolver = New System.Windows.Forms.RadioButton()
        Me.rdoLabelCorr = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Location = New System.Drawing.Point(12, 241)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(145, 36)
        Me.btnAddOrder.TabIndex = 1
        Me.btnAddOrder.Text = "Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = True
        '
        'lstWaiting
        '
        Me.lstWaiting.FormattingEnabled = True
        Me.lstWaiting.Location = New System.Drawing.Point(13, 25)
        Me.lstWaiting.Name = "lstWaiting"
        Me.lstWaiting.Size = New System.Drawing.Size(131, 199)
        Me.lstWaiting.TabIndex = 2
        '
        'lblWaiting
        '
        Me.lblWaiting.AutoSize = True
        Me.lblWaiting.Location = New System.Drawing.Point(12, 9)
        Me.lblWaiting.Name = "lblWaiting"
        Me.lblWaiting.Size = New System.Drawing.Size(77, 13)
        Me.lblWaiting.TabIndex = 3
        Me.lblWaiting.Text = "Waiting Orders"
        '
        'lblDelivered
        '
        Me.lblDelivered.AutoSize = True
        Me.lblDelivered.Location = New System.Drawing.Point(230, 9)
        Me.lblDelivered.Name = "lblDelivered"
        Me.lblDelivered.Size = New System.Drawing.Size(86, 13)
        Me.lblDelivered.TabIndex = 5
        Me.lblDelivered.Text = "Delivered Orders"
        '
        'lstDelivered
        '
        Me.lstDelivered.FormattingEnabled = True
        Me.lstDelivered.Location = New System.Drawing.Point(233, 25)
        Me.lstDelivered.Name = "lstDelivered"
        Me.lstDelivered.Size = New System.Drawing.Size(134, 199)
        Me.lstDelivered.TabIndex = 8
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(-3, 321)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(861, 177)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "End My Suffering"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(187, 247)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(129, 30)
        Me.btnSolve.TabIndex = 10
        Me.btnSolve.Text = "Assign Orders"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'rdoSolver
        '
        Me.rdoSolver.AutoSize = True
        Me.rdoSolver.Location = New System.Drawing.Point(154, 298)
        Me.rdoSolver.Name = "rdoSolver"
        Me.rdoSolver.Size = New System.Drawing.Size(114, 17)
        Me.rdoSolver.TabIndex = 11
        Me.rdoSolver.TabStop = True
        Me.rdoSolver.Text = "Linear Optimization"
        Me.rdoSolver.UseVisualStyleBackColor = True
        '
        'rdoLabelCorr
        '
        Me.rdoLabelCorr.AutoSize = True
        Me.rdoLabelCorr.Location = New System.Drawing.Point(299, 298)
        Me.rdoLabelCorr.Name = "rdoLabelCorr"
        Me.rdoLabelCorr.Size = New System.Drawing.Size(102, 17)
        Me.rdoLabelCorr.TabIndex = 12
        Me.rdoLabelCorr.TabStop = True
        Me.rdoLabelCorr.Text = "Label Correcting"
        Me.rdoLabelCorr.UseVisualStyleBackColor = True
        '
        'frmOutput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 495)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.rdoLabelCorr)
        Me.Controls.Add(Me.rdoSolver)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.lstDelivered)
        Me.Controls.Add(Me.lblDelivered)
        Me.Controls.Add(Me.lblWaiting)
        Me.Controls.Add(Me.lstWaiting)
        Me.Controls.Add(Me.btnAddOrder)
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
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSolve As Button
    Friend WithEvents rdoSolver As RadioButton
    Friend WithEvents rdoLabelCorr As RadioButton
End Class
