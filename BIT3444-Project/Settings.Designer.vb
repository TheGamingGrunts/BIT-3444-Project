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
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(12, 238)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(166, 57)
        Me.btnApply.TabIndex = 0
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(221, 238)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(166, 57)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'rdoLinearOptimization
        '
        Me.rdoLinearOptimization.AutoSize = True
        Me.rdoLinearOptimization.Location = New System.Drawing.Point(12, 33)
        Me.rdoLinearOptimization.Name = "rdoLinearOptimization"
        Me.rdoLinearOptimization.Size = New System.Drawing.Size(151, 21)
        Me.rdoLinearOptimization.TabIndex = 2
        Me.rdoLinearOptimization.TabStop = True
        Me.rdoLinearOptimization.Text = "Linear Optimization"
        Me.rdoLinearOptimization.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 60)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(133, 21)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Label Correcting"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'rdoAscending
        '
        Me.rdoAscending.AutoSize = True
        Me.rdoAscending.Location = New System.Drawing.Point(221, 33)
        Me.rdoAscending.Name = "rdoAscending"
        Me.rdoAscending.Size = New System.Drawing.Size(95, 21)
        Me.rdoAscending.TabIndex = 4
        Me.rdoAscending.TabStop = True
        Me.rdoAscending.Text = "Ascending"
        Me.rdoAscending.UseVisualStyleBackColor = True
        '
        'rdoDescending
        '
        Me.rdoDescending.AutoSize = True
        Me.rdoDescending.Location = New System.Drawing.Point(221, 60)
        Me.rdoDescending.Name = "rdoDescending"
        Me.rdoDescending.Size = New System.Drawing.Size(104, 21)
        Me.rdoDescending.TabIndex = 5
        Me.rdoDescending.TabStop = True
        Me.rdoDescending.Text = "Descending"
        Me.rdoDescending.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 321)
        Me.Controls.Add(Me.rdoDescending)
        Me.Controls.Add(Me.rdoAscending)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.rdoLinearOptimization)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnApply As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents rdoLinearOptimization As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rdoAscending As RadioButton
    Friend WithEvents rdoDescending As RadioButton
End Class
