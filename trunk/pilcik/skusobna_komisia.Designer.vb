<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class skusobna_komisia
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
        Dim PredsedaLabel As System.Windows.Forms.Label
        Dim Clen1Label As System.Windows.Forms.Label
        Dim Clen2Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(skusobna_komisia))

        Me.Skusobna_komisiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        
        Me.Skusobna_komisiaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Skusobna_komisiaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PredsedaTextBox = New System.Windows.Forms.TextBox
        Me.Clen1TextBox = New System.Windows.Forms.TextBox
        Me.Clen2TextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        PredsedaLabel = New System.Windows.Forms.Label
        Clen1Label = New System.Windows.Forms.Label
        Clen2Label = New System.Windows.Forms.Label

        CType(Me.Skusobna_komisiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Skusobna_komisiaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Skusobna_komisiaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PredsedaLabel
        '
        PredsedaLabel.AutoSize = True
        PredsedaLabel.Location = New System.Drawing.Point(115, 129)
        PredsedaLabel.Name = "PredsedaLabel"
        PredsedaLabel.Size = New System.Drawing.Size(54, 13)
        PredsedaLabel.TabIndex = 3
        PredsedaLabel.Text = "predseda:"
        '
        'Clen1Label
        '
        Clen1Label.AutoSize = True
        Clen1Label.Location = New System.Drawing.Point(115, 155)
        Clen1Label.Name = "Clen1Label"
        Clen1Label.Size = New System.Drawing.Size(36, 13)
        Clen1Label.TabIndex = 5
        Clen1Label.Text = "clen1:"
        '
        'Clen2Label
        '
        Clen2Label.AutoSize = True
        Clen2Label.Location = New System.Drawing.Point(115, 181)
        Clen2Label.Name = "Clen2Label"
        Clen2Label.Size = New System.Drawing.Size(36, 13)
        Clen2Label.TabIndex = 7
        Clen2Label.Text = "clen2:"
        '
        'PilcikdbDataSet
        '
      
        '
        'Skusobna_komisiaBindingSource
        '
        Me.Skusobna_komisiaBindingSource.DataMember = "skusobna_komisia"

        '
        'Skusobna_komisiaTableAdapter
        '

        '
        'TableAdapterManager
        '
       

        '
        'Skusobna_komisiaBindingNavigator
        '
        Me.Skusobna_komisiaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Skusobna_komisiaBindingNavigator.BindingSource = Me.Skusobna_komisiaBindingSource
        Me.Skusobna_komisiaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Skusobna_komisiaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Skusobna_komisiaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Skusobna_komisiaBindingNavigatorSaveItem})
        Me.Skusobna_komisiaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Skusobna_komisiaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Skusobna_komisiaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Skusobna_komisiaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Skusobna_komisiaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Skusobna_komisiaBindingNavigator.Name = "Skusobna_komisiaBindingNavigator"
        Me.Skusobna_komisiaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Skusobna_komisiaBindingNavigator.Size = New System.Drawing.Size(624, 25)
        Me.Skusobna_komisiaBindingNavigator.TabIndex = 0
        Me.Skusobna_komisiaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Skusobna_komisiaBindingNavigatorSaveItem
        '
        Me.Skusobna_komisiaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Skusobna_komisiaBindingNavigatorSaveItem.Image = CType(resources.GetObject("Skusobna_komisiaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Skusobna_komisiaBindingNavigatorSaveItem.Name = "Skusobna_komisiaBindingNavigatorSaveItem"
        Me.Skusobna_komisiaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Skusobna_komisiaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PredsedaTextBox
        '
        Me.PredsedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Skusobna_komisiaBindingSource, "predseda", True))
        Me.PredsedaTextBox.Location = New System.Drawing.Point(175, 126)
        Me.PredsedaTextBox.Name = "PredsedaTextBox"
        Me.PredsedaTextBox.Size = New System.Drawing.Size(274, 20)
        Me.PredsedaTextBox.TabIndex = 4
        '
        'Clen1TextBox
        '
        Me.Clen1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Skusobna_komisiaBindingSource, "clen1", True))
        Me.Clen1TextBox.Location = New System.Drawing.Point(175, 152)
        Me.Clen1TextBox.Name = "Clen1TextBox"
        Me.Clen1TextBox.Size = New System.Drawing.Size(274, 20)
        Me.Clen1TextBox.TabIndex = 6
        '
        'Clen2TextBox
        '
        Me.Clen2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Skusobna_komisiaBindingSource, "clen2", True))
        Me.Clen2TextBox.Location = New System.Drawing.Point(175, 178)
        Me.Clen2TextBox.Name = "Clen2TextBox"
        Me.Clen2TextBox.Size = New System.Drawing.Size(274, 20)
        Me.Clen2TextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(351, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Ulož"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'skusobna_komisia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 514)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(PredsedaLabel)
        Me.Controls.Add(Me.PredsedaTextBox)
        Me.Controls.Add(Clen1Label)
        Me.Controls.Add(Me.Clen1TextBox)
        Me.Controls.Add(Clen2Label)
        Me.Controls.Add(Me.Clen2TextBox)
        Me.Controls.Add(Me.Skusobna_komisiaBindingNavigator)
        Me.Name = "skusobna_komisia"
        Me.Text = "skusobna_komisia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        CType(Me.Skusobna_komisiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Skusobna_komisiaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Skusobna_komisiaBindingNavigator.ResumeLayout(False)
        Me.Skusobna_komisiaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Skusobna_komisiaBindingSource As System.Windows.Forms.BindingSource
    
    Friend WithEvents Skusobna_komisiaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Skusobna_komisiaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PredsedaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Clen1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Clen2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
