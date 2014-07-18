<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.rollD6 = New System.Windows.Forms.Button()
        Me.roll3d6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rollD6
        '
        Me.rollD6.Location = New System.Drawing.Point(12, 12)
        Me.rollD6.Name = "rollD6"
        Me.rollD6.Size = New System.Drawing.Size(75, 23)
        Me.rollD6.TabIndex = 0
        Me.rollD6.Text = "Roll D6"
        Me.rollD6.UseVisualStyleBackColor = True
        '
        'roll3d6
        '
        Me.roll3d6.Location = New System.Drawing.Point(12, 41)
        Me.roll3d6.Name = "roll3d6"
        Me.roll3d6.Size = New System.Drawing.Size(75, 23)
        Me.roll3d6.TabIndex = 1
        Me.roll3d6.Text = "Roll 3d6"
        Me.roll3d6.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.roll3d6)
        Me.Controls.Add(Me.rollD6)
        Me.Name = "MainForm"
        Me.Text = "DiceRoller"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rollD6 As System.Windows.Forms.Button
    Friend WithEvents roll3d6 As System.Windows.Forms.Button

End Class
