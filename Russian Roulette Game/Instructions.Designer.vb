<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructions
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
        Me.btnPlayGame = New System.Windows.Forms.Button()
        Me.tbInstructions = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnPlayGame
        '
        Me.btnPlayGame.Location = New System.Drawing.Point(217, 267)
        Me.btnPlayGame.Name = "btnPlayGame"
        Me.btnPlayGame.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayGame.TabIndex = 11
        Me.btnPlayGame.Text = "Play Game"
        Me.btnPlayGame.UseVisualStyleBackColor = True
        '
        'tbInstructions
        '
        Me.tbInstructions.Location = New System.Drawing.Point(1, 0)
        Me.tbInstructions.Multiline = True
        Me.tbInstructions.Name = "tbInstructions"
        Me.tbInstructions.Size = New System.Drawing.Size(545, 261)
        Me.tbInstructions.TabIndex = 12
        '
        'Instructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 302)
        Me.Controls.Add(Me.tbInstructions)
        Me.Controls.Add(Me.btnPlayGame)
        Me.Name = "Instructions"
        Me.Text = "Instructions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlayGame As Button
    Friend WithEvents tbInstructions As TextBox
End Class
