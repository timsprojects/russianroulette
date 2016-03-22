<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Me.btnHighScores = New System.Windows.Forms.Button()
        Me.btnInstrucitions = New System.Windows.Forms.Button()
        Me.btnPlayGame = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHighScores
        '
        Me.btnHighScores.Location = New System.Drawing.Point(404, 140)
        Me.btnHighScores.Name = "btnHighScores"
        Me.btnHighScores.Size = New System.Drawing.Size(75, 23)
        Me.btnHighScores.TabIndex = 12
        Me.btnHighScores.Text = "High Scores"
        Me.btnHighScores.UseVisualStyleBackColor = True
        '
        'btnInstrucitions
        '
        Me.btnInstrucitions.Location = New System.Drawing.Point(58, 140)
        Me.btnInstrucitions.Name = "btnInstrucitions"
        Me.btnInstrucitions.Size = New System.Drawing.Size(97, 23)
        Me.btnInstrucitions.TabIndex = 11
        Me.btnInstrucitions.Text = "Instructions"
        Me.btnInstrucitions.UseVisualStyleBackColor = True
        '
        'btnPlayGame
        '
        Me.btnPlayGame.Location = New System.Drawing.Point(231, 140)
        Me.btnPlayGame.Name = "btnPlayGame"
        Me.btnPlayGame.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayGame.TabIndex = 10
        Me.btnPlayGame.Text = "Play Game"
        Me.btnPlayGame.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(107, 43)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(337, 42)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Russian Roulette"
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Russian_Roulette_Game.My.Resources.Resources.backgroundimage
        Me.ClientSize = New System.Drawing.Size(545, 302)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHighScores)
        Me.Controls.Add(Me.btnInstrucitions)
        Me.Controls.Add(Me.btnPlayGame)
        Me.Name = "Welcome"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHighScores As Button
    Friend WithEvents btnInstrucitions As Button
    Friend WithEvents btnPlayGame As Button
    Friend WithEvents lblTitle As Label
End Class
