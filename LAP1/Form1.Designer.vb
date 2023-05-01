<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.typeInputLabel = New System.Windows.Forms.Label()
        Me.typeInputTextBox = New System.Windows.Forms.TextBox()
        Me.copyOfInputLabel = New System.Windows.Forms.Label()
        Me.copyInputTextBox = New System.Windows.Forms.TextBox()
        Me.copyPasteButton = New System.Windows.Forms.Button()
        Me.yellowButton = New System.Windows.Forms.Button()
        Me.blueButton = New System.Windows.Forms.Button()
        Me.redButton = New System.Windows.Forms.Button()
        Me.hideCopyButton = New System.Windows.Forms.Button()
        Me.showCopyButton = New System.Windows.Forms.Button()
        Me.resetFormButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'typeInputLabel
        '
        Me.typeInputLabel.Location = New System.Drawing.Point(69, 46)
        Me.typeInputLabel.Name = "typeInputLabel"
        Me.typeInputLabel.Size = New System.Drawing.Size(224, 39)
        Me.typeInputLabel.TabIndex = 0
        Me.typeInputLabel.Text = "Type Input Here:"
        '
        'typeInputTextBox
        '
        Me.typeInputTextBox.Location = New System.Drawing.Point(330, 46)
        Me.typeInputTextBox.Name = "typeInputTextBox"
        Me.typeInputTextBox.Size = New System.Drawing.Size(269, 39)
        Me.typeInputTextBox.TabIndex = 1
        '
        'copyOfInputLabel
        '
        Me.copyOfInputLabel.Location = New System.Drawing.Point(69, 116)
        Me.copyOfInputLabel.Name = "copyOfInputLabel"
        Me.copyOfInputLabel.Size = New System.Drawing.Size(224, 39)
        Me.copyOfInputLabel.TabIndex = 2
        Me.copyOfInputLabel.Text = "Copy of Input:"
        '
        'copyInputTextBox
        '
        Me.copyInputTextBox.Location = New System.Drawing.Point(330, 116)
        Me.copyInputTextBox.Name = "copyInputTextBox"
        Me.copyInputTextBox.Size = New System.Drawing.Size(269, 39)
        Me.copyInputTextBox.TabIndex = 3
        '
        'copyPasteButton
        '
        Me.copyPasteButton.Location = New System.Drawing.Point(669, 75)
        Me.copyPasteButton.Name = "copyPasteButton"
        Me.copyPasteButton.Size = New System.Drawing.Size(230, 58)
        Me.copyPasteButton.TabIndex = 4
        Me.copyPasteButton.Text = "Copy and Paste"
        Me.copyPasteButton.UseVisualStyleBackColor = True
        '
        'yellowButton
        '
        Me.yellowButton.Location = New System.Drawing.Point(75, 211)
        Me.yellowButton.Name = "yellowButton"
        Me.yellowButton.Size = New System.Drawing.Size(218, 58)
        Me.yellowButton.TabIndex = 5
        Me.yellowButton.Text = "Yellow"
        Me.yellowButton.UseVisualStyleBackColor = True
        '
        'blueButton
        '
        Me.blueButton.Location = New System.Drawing.Point(346, 211)
        Me.blueButton.Name = "blueButton"
        Me.blueButton.Size = New System.Drawing.Size(230, 58)
        Me.blueButton.TabIndex = 6
        Me.blueButton.Text = "Blue"
        Me.blueButton.UseVisualStyleBackColor = True
        '
        'redButton
        '
        Me.redButton.Location = New System.Drawing.Point(635, 211)
        Me.redButton.Name = "redButton"
        Me.redButton.Size = New System.Drawing.Size(230, 58)
        Me.redButton.TabIndex = 7
        Me.redButton.Text = "Red"
        Me.redButton.UseVisualStyleBackColor = True
        '
        'hideCopyButton
        '
        Me.hideCopyButton.Location = New System.Drawing.Point(75, 327)
        Me.hideCopyButton.Name = "hideCopyButton"
        Me.hideCopyButton.Size = New System.Drawing.Size(218, 58)
        Me.hideCopyButton.TabIndex = 8
        Me.hideCopyButton.Text = "Hide Copy"
        Me.hideCopyButton.UseVisualStyleBackColor = True
        '
        'showCopyButton
        '
        Me.showCopyButton.Location = New System.Drawing.Point(346, 327)
        Me.showCopyButton.Name = "showCopyButton"
        Me.showCopyButton.Size = New System.Drawing.Size(230, 58)
        Me.showCopyButton.TabIndex = 9
        Me.showCopyButton.Text = "Show Copy"
        Me.showCopyButton.UseVisualStyleBackColor = True
        '
        'resetFormButton
        '
        Me.resetFormButton.Location = New System.Drawing.Point(635, 327)
        Me.resetFormButton.Name = "resetFormButton"
        Me.resetFormButton.Size = New System.Drawing.Size(230, 58)
        Me.resetFormButton.TabIndex = 10
        Me.resetFormButton.Text = "Reset Form"
        Me.resetFormButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(635, 460)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(230, 58)
        Me.exitButton.TabIndex = 11
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1422, 720)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.resetFormButton)
        Me.Controls.Add(Me.showCopyButton)
        Me.Controls.Add(Me.hideCopyButton)
        Me.Controls.Add(Me.redButton)
        Me.Controls.Add(Me.blueButton)
        Me.Controls.Add(Me.yellowButton)
        Me.Controls.Add(Me.copyPasteButton)
        Me.Controls.Add(Me.copyInputTextBox)
        Me.Controls.Add(Me.copyOfInputLabel)
        Me.Controls.Add(Me.typeInputTextBox)
        Me.Controls.Add(Me.typeInputLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAP 1 Copier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents typeInputLabel As Label
    Friend WithEvents typeInputTextBox As TextBox
    Friend WithEvents copyOfInputLabel As Label
    Friend WithEvents copyInputTextBox As TextBox
    Friend WithEvents copyPasteButton As Button
    Friend WithEvents yellowButton As Button
    Friend WithEvents blueButton As Button
    Friend WithEvents redButton As Button
    Friend WithEvents hideCopyButton As Button
    Friend WithEvents showCopyButton As Button
    Friend WithEvents resetFormButton As Button
    Friend WithEvents exitButton As Button
End Class
