<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.rdoLinearOptimization = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.rdoAscending = New System.Windows.Forms.RadioButton()
        Me.rdoDescending = New System.Windows.Forms.RadioButton()
        Me.grpSolveType = New System.Windows.Forms.GroupBox()
        Me.grpSort = New System.Windows.Forms.GroupBox()
        Me.grpSolveType.SuspendLayout()
        Me.grpSort.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(9, 193)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(124, 46)
        Me.btnApply.TabIndex = 0
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(166, 193)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 46)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'rdoLinearOptimization
        '
        Me.rdoLinearOptimization.AutoSize = True
        Me.rdoLinearOptimization.Location = New System.Drawing.Point(5, 18)
        Me.rdoLinearOptimization.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoLinearOptimization.Name = "rdoLinearOptimization"
        Me.rdoLinearOptimization.Size = New System.Drawing.Size(114, 17)
        Me.rdoLinearOptimization.TabIndex = 2
        Me.rdoLinearOptimization.TabStop = True
        Me.rdoLinearOptimization.Text = "Linear Optimization"
        Me.rdoLinearOptimization.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(5, 39)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(102, 17)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Label Correcting"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'rdoAscending
        '
        Me.rdoAscending.AutoSize = True
        Me.rdoAscending.Location = New System.Drawing.Point(6, 18)
        Me.rdoAscending.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoAscending.Name = "rdoAscending"
        Me.rdoAscending.Size = New System.Drawing.Size(75, 17)
        Me.rdoAscending.TabIndex = 4
        Me.rdoAscending.TabStop = True
        Me.rdoAscending.Text = "Ascending"
        Me.rdoAscending.UseVisualStyleBackColor = True
        '
        'rdoDescending
        '
        Me.rdoDescending.AutoSize = True
        Me.rdoDescending.Location = New System.Drawing.Point(6, 39)
        Me.rdoDescending.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoDescending.Name = "rdoDescending"
        Me.rdoDescending.Size = New System.Drawing.Size(82, 17)
        Me.rdoDescending.TabIndex = 5
        Me.rdoDescending.TabStop = True
        Me.rdoDescending.Text = "Descending"
        Me.rdoDescending.UseVisualStyleBackColor = True
        '
        'grpSolveType
        '
        Me.grpSolveType.Controls.Add(Me.RadioButton2)
        Me.grpSolveType.Controls.Add(Me.rdoLinearOptimization)
        Me.grpSolveType.Location = New System.Drawing.Point(22, 12)
        Me.grpSolveType.Name = "grpSolveType"
        Me.grpSolveType.Size = New System.Drawing.Size(123, 68)
        Me.grpSolveType.TabIndex = 6
        Me.grpSolveType.TabStop = False
        Me.grpSolveType.Text = "Solution Method"
        '
        'grpSort
        '
        Me.grpSort.Controls.Add(Me.rdoDescending)
        Me.grpSort.Controls.Add(Me.rdoAscending)
        Me.grpSort.Location = New System.Drawing.Point(173, 12)
        Me.grpSort.Name = "grpSort"
        Me.grpSort.Size = New System.Drawing.Size(103, 68)
        Me.grpSort.TabIndex = 7
        Me.grpSort.TabStop = False
        Me.grpSort.Text = "Sort By"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 261)
        Me.Controls.Add(Me.grpSort)
        Me.Controls.Add(Me.grpSolveType)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.grpSolveType.ResumeLayout(False)
        Me.grpSolveType.PerformLayout()
        Me.grpSort.ResumeLayout(False)
        Me.grpSort.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnApply As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents rdoLinearOptimization As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rdoAscending As RadioButton
    Friend WithEvents rdoDescending As RadioButton
    Friend WithEvents grpSolveType As GroupBox
    Friend WithEvents grpSort As GroupBox
End Class
