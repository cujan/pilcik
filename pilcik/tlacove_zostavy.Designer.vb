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
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Pilcik_dbDataSet = New pilcik.pilcik_dbDataSet()
        Me.KurzpohladBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kurz_pohladTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.kurz_pohladTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pilaRadioButton = New System.Windows.Forms.RadioButton()
        Me.lktRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.Pilcik_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KurzpohladBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.KurzpohladBindingSource
        Me.ComboBox1.DisplayMember = "spolocny_nazov"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(372, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "id"
        '
        'Pilcik_dbDataSet
        '
        Me.Pilcik_dbDataSet.DataSetName = "pilcik_dbDataSet"
        Me.Pilcik_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KurzpohladBindingSource
        '
        Me.KurzpohladBindingSource.DataMember = "kurz_pohlad"
        Me.KurzpohladBindingSource.DataSource = Me.Pilcik_dbDataSet
        '
        'Kurz_pohladTableAdapter
        '
        Me.Kurz_pohladTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ukáž zostavu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pilaRadioButton
        '
        Me.pilaRadioButton.AutoSize = True
        Me.pilaRadioButton.Location = New System.Drawing.Point(6, 30)
        Me.pilaRadioButton.Name = "pilaRadioButton"
        Me.pilaRadioButton.Size = New System.Drawing.Size(44, 17)
        Me.pilaRadioButton.TabIndex = 2
        Me.pilaRadioButton.TabStop = True
        Me.pilaRadioButton.Text = "Píla"
        Me.pilaRadioButton.UseVisualStyleBackColor = True
        '
        'lktRadioButton
        '
        Me.lktRadioButton.AutoSize = True
        Me.lktRadioButton.Location = New System.Drawing.Point(6, 63)
        Me.lktRadioButton.Name = "lktRadioButton"
        Me.lktRadioButton.Size = New System.Drawing.Size(45, 17)
        Me.lktRadioButton.TabIndex = 3
        Me.lktRadioButton.TabStop = True
        Me.lktRadioButton.Text = "LKT"
        Me.lktRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pilaRadioButton)
        Me.GroupBox1.Controls.Add(Me.lktRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vyberte tlačovú zostavu"
        '
        'tlacove_zostavy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 547)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "tlacove_zostavy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "tlacove_zostavy"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Pilcik_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KurzpohladBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Pilcik_dbDataSet As pilcik.pilcik_dbDataSet
    Friend WithEvents KurzpohladBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Kurz_pohladTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.kurz_pohladTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pilaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents lktRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox




End Class
