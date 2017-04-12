<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddOrder
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
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblOrigin = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.txtOrigin = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(27, 27)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(50, 17)
        Me.lblModel.TabIndex = 0
        Me.lblModel.Text = "Model:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(27, 70)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(65, 17)
        Me.lblQuantity.TabIndex = 1
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblOrigin
        '
        Me.lblOrigin.AutoSize = True
        Me.lblOrigin.Location = New System.Drawing.Point(27, 115)
        Me.lblOrigin.Name = "lblOrigin"
        Me.lblOrigin.Size = New System.Drawing.Size(50, 17)
        Me.lblOrigin.TabIndex = 2
        Me.lblOrigin.Text = "Origin:"
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Location = New System.Drawing.Point(27, 163)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(83, 17)
        Me.lblDestination.TabIndex = 3
        Me.lblDestination.Text = "Destination:"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(130, 24)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(272, 22)
        Me.txtModel.TabIndex = 4
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(130, 160)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(272, 22)
        Me.txtDestination.TabIndex = 5
        '
        'txtOrigin
        '
        Me.txtOrigin.Location = New System.Drawing.Point(130, 112)
        Me.txtOrigin.Name = "txtOrigin"
        Me.txtOrigin.Size = New System.Drawing.Size(272, 22)
        Me.txtOrigin.TabIndex = 6
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(130, 67)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(272, 22)
        Me.txtQuantity.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(30, 208)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(154, 70)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(248, 208)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(154, 70)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmAddOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 306)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtOrigin)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.lblDestination)
        Me.Controls.Add(Me.lblOrigin)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblModel)
        Me.Name = "frmAddOrder"
        Me.Text = "Add Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblModel As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblOrigin As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents txtOrigin As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
End Class
