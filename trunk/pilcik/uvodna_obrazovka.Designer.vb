<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uvodna_obrazovka
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.verziaLabel = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.skonecena_platnostButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(374, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vitajte"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pocet evidovaných osôb"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Počet evidovaných kurzov"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Label5"
        '
        'verziaLabel
        '
        Me.verziaLabel.AutoSize = True
        Me.verziaLabel.Location = New System.Drawing.Point(12, 662)
        Me.verziaLabel.Name = "verziaLabel"
        Me.verziaLabel.Size = New System.Drawing.Size(39, 13)
        Me.verziaLabel.TabIndex = 5
        Me.verziaLabel.Text = "Label6"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(423, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(240, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Pocet clenov, ktorým vypršala platnosť preukazu:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(456, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'skonecena_platnostButton
        '
        Me.skonecena_platnostButton.Location = New System.Drawing.Point(456, 247)
        Me.skonecena_platnostButton.Name = "skonecena_platnostButton"
        Me.skonecena_platnostButton.Size = New System.Drawing.Size(243, 23)
        Me.skonecena_platnostButton.TabIndex = 8
        Me.skonecena_platnostButton.Text = "Osoby, ktorým skoncila platnosť preukazu"
        Me.skonecena_platnostButton.UseVisualStyleBackColor = True
        '
        'uvodna_obrazovka
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 701)
        Me.ControlBox = False
        Me.Controls.Add(Me.skonecena_platnostButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.verziaLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uvodna_obrazovka"
        Me.Text = "uvodna_obrazovka"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents verziaLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents skonecena_platnostButton As System.Windows.Forms.Button
End Class
