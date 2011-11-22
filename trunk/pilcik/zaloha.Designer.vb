<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zaloha
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem formulářů
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem formulářů
    'Může být upraveno pomocí Návrháře formulářů.  
    'Neupravovat pomocí editoru kódu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.zalohaButton = New System.Windows.Forms.Button()
        Me.obnovListBox = New System.Windows.Forms.ListBox()
        Me.zalohujRadioButton = New System.Windows.Forms.RadioButton()
        Me.obnovRadioButton = New System.Windows.Forms.RadioButton()
        Me.zaloha_label = New System.Windows.Forms.Label()
        Me.obnovButton = New System.Windows.Forms.Button()
        Me.zmazButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(510, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Záloha databázy"
        '
        'zalohaButton
        '
        Me.zalohaButton.Location = New System.Drawing.Point(325, 51)
        Me.zalohaButton.Name = "zalohaButton"
        Me.zalohaButton.Size = New System.Drawing.Size(75, 23)
        Me.zalohaButton.TabIndex = 1
        Me.zalohaButton.Text = "Zálohuj"
        Me.zalohaButton.UseVisualStyleBackColor = True
        '
        'obnovListBox
        '
        Me.obnovListBox.FormattingEnabled = True
        Me.obnovListBox.Location = New System.Drawing.Point(325, 158)
        Me.obnovListBox.Name = "obnovListBox"
        Me.obnovListBox.Size = New System.Drawing.Size(394, 160)
        Me.obnovListBox.TabIndex = 2
        '
        'zalohujRadioButton
        '
        Me.zalohujRadioButton.AutoSize = True
        Me.zalohujRadioButton.Location = New System.Drawing.Point(22, 57)
        Me.zalohujRadioButton.Name = "zalohujRadioButton"
        Me.zalohujRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.zalohujRadioButton.TabIndex = 3
        Me.zalohujRadioButton.TabStop = True
        Me.zalohujRadioButton.Text = "Zálohuj"
        Me.zalohujRadioButton.UseVisualStyleBackColor = True
        '
        'obnovRadioButton
        '
        Me.obnovRadioButton.AutoSize = True
        Me.obnovRadioButton.Location = New System.Drawing.Point(22, 215)
        Me.obnovRadioButton.Name = "obnovRadioButton"
        Me.obnovRadioButton.Size = New System.Drawing.Size(104, 17)
        Me.obnovRadioButton.TabIndex = 4
        Me.obnovRadioButton.TabStop = True
        Me.obnovRadioButton.Text = "Obnov zo zálohy"
        Me.obnovRadioButton.UseVisualStyleBackColor = True
        '
        'zaloha_label
        '
        Me.zaloha_label.AutoSize = True
        Me.zaloha_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.zaloha_label.Location = New System.Drawing.Point(34, 86)
        Me.zaloha_label.Name = "zaloha_label"
        Me.zaloha_label.Size = New System.Drawing.Size(333, 13)
        Me.zaloha_label.TabIndex = 5
        Me.zaloha_label.Text = "Zálohu databázy vytvoríte stlačením na tlačítko 'Zálohuj'"
        '
        'obnovButton
        '
        Me.obnovButton.Location = New System.Drawing.Point(349, 337)
        Me.obnovButton.Name = "obnovButton"
        Me.obnovButton.Size = New System.Drawing.Size(75, 23)
        Me.obnovButton.TabIndex = 6
        Me.obnovButton.Text = "Obnov"
        Me.obnovButton.UseVisualStyleBackColor = True
        '
        'zmazButton
        '
        Me.zmazButton.Location = New System.Drawing.Point(588, 337)
        Me.zmazButton.Name = "zmazButton"
        Me.zmazButton.Size = New System.Drawing.Size(75, 23)
        Me.zmazButton.TabIndex = 7
        Me.zmazButton.Text = "Zmaž zálohu"
        Me.zmazButton.UseVisualStyleBackColor = True
        '
        'zaloha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 372)
        Me.Controls.Add(Me.zmazButton)
        Me.Controls.Add(Me.obnovButton)
        Me.Controls.Add(Me.zaloha_label)
        Me.Controls.Add(Me.obnovRadioButton)
        Me.Controls.Add(Me.zalohujRadioButton)
        Me.Controls.Add(Me.obnovListBox)
        Me.Controls.Add(Me.zalohaButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "zaloha"
        Me.Text = "zaloha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents zalohaButton As System.Windows.Forms.Button
    Friend WithEvents obnovListBox As System.Windows.Forms.ListBox
    Friend WithEvents zalohujRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents obnovRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents zaloha_label As System.Windows.Forms.Label
    Friend WithEvents obnovButton As System.Windows.Forms.Button
    Friend WithEvents zmazButton As System.Windows.Forms.Button
End Class
