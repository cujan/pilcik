<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tlacove_zostavy
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
        Me.components = New System.ComponentModel.Container
        Me.Button1 = New System.Windows.Forms.Button
        Me.protokol_kurzComboBox = New System.Windows.Forms.ComboBox
        Me.KurzBindingSource = New System.Windows.Forms.BindingSource(Me.components)
       
        Me.Label2 = New System.Windows.Forms.Label
        Me.protokol_pila_RadioButton = New System.Windows.Forms.RadioButton
        Me.protokol_lkt_RadioButton = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton

        Me.KurzBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)

        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
       
        CType(Me.KurzBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(276, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ukáž"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'protokol_kurzComboBox
        '
        Me.protokol_kurzComboBox.DataSource = Me.KurzBindingSource1
        Me.protokol_kurzComboBox.DisplayMember = "nazov_spolu"
        Me.protokol_kurzComboBox.FormattingEnabled = True
        Me.protokol_kurzComboBox.Location = New System.Drawing.Point(328, 221)
        Me.protokol_kurzComboBox.Name = "protokol_kurzComboBox"
        Me.protokol_kurzComboBox.Size = New System.Drawing.Size(315, 21)
        Me.protokol_kurzComboBox.TabIndex = 3
        Me.protokol_kurzComboBox.ValueMember = "id"
        Me.protokol_kurzComboBox.Visible = False
        '
        'KurzBindingSource
        '
        Me.KurzBindingSource.DataMember = "kurz"

        '
        'PilcikdbDataSet
        '
        
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(371, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Vyberte kurz !!!"
        Me.Label2.Visible = False
        '
        'protokol_pila_RadioButton
        '
        Me.protokol_pila_RadioButton.AutoSize = True
        Me.protokol_pila_RadioButton.Location = New System.Drawing.Point(23, 186)
        Me.protokol_pila_RadioButton.Name = "protokol_pila_RadioButton"
        Me.protokol_pila_RadioButton.Size = New System.Drawing.Size(256, 17)
        Me.protokol_pila_RadioButton.TabIndex = 3
        Me.protokol_pila_RadioButton.TabStop = True
        Me.protokol_pila_RadioButton.Text = "Protokol - obsluha motorových píl a krovinorezov"
        Me.protokol_pila_RadioButton.UseVisualStyleBackColor = True
        '
        'protokol_lkt_RadioButton
        '
        Me.protokol_lkt_RadioButton.AutoSize = True
        Me.protokol_lkt_RadioButton.Location = New System.Drawing.Point(23, 225)
        Me.protokol_lkt_RadioButton.Name = "protokol_lkt_RadioButton"
        Me.protokol_lkt_RadioButton.Size = New System.Drawing.Size(218, 17)
        Me.protokol_lkt_RadioButton.TabIndex = 6
        Me.protokol_lkt_RadioButton.TabStop = True
        Me.protokol_lkt_RadioButton.Text = "Protokol - obsluha a údržba ŠLKT a UKT"
        Me.protokol_lkt_RadioButton.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(23, 267)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'KurzComboDataSet
        '
      
        '
        'KurzBindingSource1
        '
        Me.KurzBindingSource1.DataMember = "kurz"

        '
        'KurzTableAdapter1
        '

        '
        'tlacove_zostavy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 547)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.protokol_lkt_RadioButton)
        Me.Controls.Add(Me.protokol_pila_RadioButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.protokol_kurzComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "tlacove_zostavy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "tlacove_zostavy"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        
        CType(Me.KurzBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents protokol_kurzComboBox As System.Windows.Forms.ComboBox

    Friend WithEvents KurzBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents protokol_pila_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents protokol_lkt_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton

    Friend WithEvents KurzBindingSource1 As System.Windows.Forms.BindingSource

End Class
