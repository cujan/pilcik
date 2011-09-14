<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kurz_detail
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
        Dim NazovLabel As System.Windows.Forms.Label
        Dim Zaciatok_kurzuLabel As System.Windows.Forms.Label
        Dim Koniec_kurzuLabel As System.Windows.Forms.Label
        Dim TypLabel As System.Windows.Forms.Label
        Dim Miesto_konaniaLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim Cislo_protokoluLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kurz_detail))
        Me.pridaj_clenaButton = New System.Windows.Forms.Button
        Me.KurzBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.KurzBindingSource = New System.Windows.Forms.BindingSource(Me.components)

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
        Me.KurzBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.Zaciatok_kurzuDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Koniec_kurzuDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.TypTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_konaniaTextBox = New System.Windows.Forms.TextBox
        Me.Clenovia_kurzuDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.datum_narodenia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Clenovia_kurzuBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.IdLabel1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        
        Me.Button2 = New System.Windows.Forms.Button
        Me.Cislo_protokoluTextBox = New System.Windows.Forms.TextBox
        
        Me.typ_nazovComboBox = New System.Windows.Forms.ComboBox
        Me.CtypkurzuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button
        NazovLabel = New System.Windows.Forms.Label
        Zaciatok_kurzuLabel = New System.Windows.Forms.Label
        Koniec_kurzuLabel = New System.Windows.Forms.Label
        TypLabel = New System.Windows.Forms.Label
        Miesto_konaniaLabel = New System.Windows.Forms.Label
        IdLabel = New System.Windows.Forms.Label
        Cislo_protokoluLabel = New System.Windows.Forms.Label
        CType(Me.KurzBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KurzBindingNavigator.SuspendLayout()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        CType(Me.Clenovia_kurzuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clenovia_kurzuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        CType(Me.CtypkurzuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        NazovLabel.Location = New System.Drawing.Point(46, 36)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(82, 13)
        NazovLabel.TabIndex = 16
        NazovLabel.Text = "Názov kurzu:"
        '
        'Zaciatok_kurzuLabel
        '
        Zaciatok_kurzuLabel.AutoSize = True
        Zaciatok_kurzuLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Zaciatok_kurzuLabel.Location = New System.Drawing.Point(46, 71)
        Zaciatok_kurzuLabel.Name = "Zaciatok_kurzuLabel"
        Zaciatok_kurzuLabel.Size = New System.Drawing.Size(96, 13)
        Zaciatok_kurzuLabel.TabIndex = 18
        Zaciatok_kurzuLabel.Text = "Začiatok kurzu:"
        '
        'Koniec_kurzuLabel
        '
        Koniec_kurzuLabel.AutoSize = True
        Koniec_kurzuLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Koniec_kurzuLabel.Location = New System.Drawing.Point(46, 97)
        Koniec_kurzuLabel.Name = "Koniec_kurzuLabel"
        Koniec_kurzuLabel.Size = New System.Drawing.Size(85, 13)
        Koniec_kurzuLabel.TabIndex = 20
        Koniec_kurzuLabel.Text = "Koniec kurzu:"
        '
        'TypLabel
        '
        TypLabel.AutoSize = True
        TypLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        TypLabel.Location = New System.Drawing.Point(46, 123)
        TypLabel.Name = "TypLabel"
        TypLabel.Size = New System.Drawing.Size(67, 13)
        TypLabel.TabIndex = 22
        TypLabel.Text = "Typ kurzu:"
        '
        'Miesto_konaniaLabel
        '
        Miesto_konaniaLabel.AutoSize = True
        Miesto_konaniaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Miesto_konaniaLabel.Location = New System.Drawing.Point(46, 152)
        Miesto_konaniaLabel.Name = "Miesto_konaniaLabel"
        Miesto_konaniaLabel.Size = New System.Drawing.Size(97, 13)
        Miesto_konaniaLabel.TabIndex = 24
        Miesto_konaniaLabel.Text = "Miesto konania:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(574, 22)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 28
        IdLabel.Text = "id:"
        '
        'Cislo_protokoluLabel
        '
        Cislo_protokoluLabel.AutoSize = True
        Cislo_protokoluLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Cislo_protokoluLabel.Location = New System.Drawing.Point(46, 182)
        Cislo_protokoluLabel.Name = "Cislo_protokoluLabel"
        Cislo_protokoluLabel.Size = New System.Drawing.Size(97, 13)
        Cislo_protokoluLabel.TabIndex = 31
        Cislo_protokoluLabel.Text = "Číslo protokolu:"
        '
        'pridaj_clenaButton
        '
        Me.pridaj_clenaButton.Location = New System.Drawing.Point(49, 216)
        Me.pridaj_clenaButton.Name = "pridaj_clenaButton"
        Me.pridaj_clenaButton.Size = New System.Drawing.Size(75, 23)
        Me.pridaj_clenaButton.TabIndex = 15
        Me.pridaj_clenaButton.Text = "Pridaj člena"
        Me.pridaj_clenaButton.UseVisualStyleBackColor = True
        '
        'KurzBindingNavigator
        '
        Me.KurzBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.KurzBindingNavigator.BindingSource = Me.KurzBindingSource
        Me.KurzBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.KurzBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.KurzBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KurzBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.KurzBindingNavigatorSaveItem})
        Me.KurzBindingNavigator.Location = New System.Drawing.Point(0, 677)
        Me.KurzBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.KurzBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.KurzBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.KurzBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.KurzBindingNavigator.Name = "KurzBindingNavigator"
        Me.KurzBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.KurzBindingNavigator.Size = New System.Drawing.Size(1117, 25)
        Me.KurzBindingNavigator.TabIndex = 16
        Me.KurzBindingNavigator.Text = "BindingNavigator1"
        Me.KurzBindingNavigator.Visible = False
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
        'KurzBindingSource
        '
        Me.KurzBindingSource.DataMember = "kurz"

        '
        'PilcikdbDataSet
        '
        
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'KurzBindingNavigatorSaveItem
        '
        Me.KurzBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KurzBindingNavigatorSaveItem.Enabled = False
        Me.KurzBindingNavigatorSaveItem.Image = CType(resources.GetObject("KurzBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.KurzBindingNavigatorSaveItem.Name = "KurzBindingNavigatorSaveItem"
        Me.KurzBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.KurzBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NazovTextBox
        '
        Me.NazovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "nazov", True))
        Me.NazovTextBox.Location = New System.Drawing.Point(170, 29)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.ReadOnly = True
        Me.NazovTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NazovTextBox.TabIndex = 17
        '
        'Zaciatok_kurzuDateTimePicker
        '
        Me.Zaciatok_kurzuDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KurzBindingSource, "zaciatok_kurzu", True))
        Me.Zaciatok_kurzuDateTimePicker.Enabled = False
        Me.Zaciatok_kurzuDateTimePicker.Location = New System.Drawing.Point(170, 67)
        Me.Zaciatok_kurzuDateTimePicker.Name = "Zaciatok_kurzuDateTimePicker"
        Me.Zaciatok_kurzuDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Zaciatok_kurzuDateTimePicker.TabIndex = 19
        '
        'Koniec_kurzuDateTimePicker
        '
        Me.Koniec_kurzuDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KurzBindingSource, "koniec_kurzu", True))
        Me.Koniec_kurzuDateTimePicker.Enabled = False
        Me.Koniec_kurzuDateTimePicker.Location = New System.Drawing.Point(170, 97)
        Me.Koniec_kurzuDateTimePicker.Name = "Koniec_kurzuDateTimePicker"
        Me.Koniec_kurzuDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Koniec_kurzuDateTimePicker.TabIndex = 21
        '
        'TypTextBox
        '
        Me.TypTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "typ", True))
        Me.TypTextBox.Location = New System.Drawing.Point(170, 123)
        Me.TypTextBox.Name = "TypTextBox"
        Me.TypTextBox.ReadOnly = True
        Me.TypTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TypTextBox.TabIndex = 23
        '
        'Miesto_konaniaTextBox
        '
        Me.Miesto_konaniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "miesto_konania", True))
        Me.Miesto_konaniaTextBox.Location = New System.Drawing.Point(170, 149)
        Me.Miesto_konaniaTextBox.Name = "Miesto_konaniaTextBox"
        Me.Miesto_konaniaTextBox.ReadOnly = True
        Me.Miesto_konaniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_konaniaTextBox.TabIndex = 25
        '
        'Clenovia_kurzuDataGridView
        '
        Me.Clenovia_kurzuDataGridView.AllowUserToAddRows = False
        Me.Clenovia_kurzuDataGridView.AllowUserToDeleteRows = False
        Me.Clenovia_kurzuDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Clenovia_kurzuDataGridView.AutoGenerateColumns = False
        Me.Clenovia_kurzuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Clenovia_kurzuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Clenovia_kurzuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.datum_narodenia})
        Me.Clenovia_kurzuDataGridView.DataSource = Me.Clenovia_kurzuBindingSource
        Me.Clenovia_kurzuDataGridView.Location = New System.Drawing.Point(12, 256)
        Me.Clenovia_kurzuDataGridView.Name = "Clenovia_kurzuDataGridView"
        Me.Clenovia_kurzuDataGridView.ReadOnly = True
        Me.Clenovia_kurzuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Clenovia_kurzuDataGridView.Size = New System.Drawing.Size(1101, 397)
        Me.Clenovia_kurzuDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "priezvisko"
        Me.DataGridViewTextBoxColumn4.HeaderText = "priezvisko"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 79
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "meno"
        Me.DataGridViewTextBoxColumn6.HeaderText = "meno"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 58
        '
        'datum_narodenia
        '
        Me.datum_narodenia.DataPropertyName = "datum_narodenia"
        Me.datum_narodenia.HeaderText = "datum_narodenia"
        Me.datum_narodenia.Name = "datum_narodenia"
        Me.datum_narodenia.ReadOnly = True
        Me.datum_narodenia.Width = 114
        '
        'Clenovia_kurzuBindingSource
        '
        Me.Clenovia_kurzuBindingSource.DataMember = "clenovia_kurzu"

        '
        'Clenovia_kurzuDataSet
        '
        
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(475, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Detaily kurzu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(495, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(495, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Label3"
        '
        'IdLabel1
        '
        Me.IdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "id", True))
        Me.IdLabel1.Location = New System.Drawing.Point(542, 22)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdLabel1.TabIndex = 29
        Me.IdLabel1.Text = "Label4"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(180, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Zmaž  člena z kurzu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Clenovia_kurzuTableAdapter
        '

        '
        'TableAdapterManager1
        '
       

        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(390, 146)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Zmeň detaily kurzu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Cislo_protokoluTextBox
        '
        Me.Cislo_protokoluTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "cislo_protokolu", True))
        Me.Cislo_protokoluTextBox.Location = New System.Drawing.Point(170, 175)
        Me.Cislo_protokoluTextBox.Name = "Cislo_protokoluTextBox"
        Me.Cislo_protokoluTextBox.ReadOnly = True
        Me.Cislo_protokoluTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cislo_protokoluTextBox.TabIndex = 32
        '
        'KurzTableAdapter
        '

        '
        'TableAdapterManager
        '
        
        '
        'C_typ_kurzuTableAdapter
        '

        '
        'typ_nazovComboBox
        '
        Me.typ_nazovComboBox.DataSource = Me.CtypkurzuBindingSource
        Me.typ_nazovComboBox.DisplayMember = "nazov"
        Me.typ_nazovComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typ_nazovComboBox.Enabled = False
        Me.typ_nazovComboBox.FormattingEnabled = True
        Me.typ_nazovComboBox.Location = New System.Drawing.Point(170, 122)
        Me.typ_nazovComboBox.Name = "typ_nazovComboBox"
        Me.typ_nazovComboBox.Size = New System.Drawing.Size(200, 21)
        Me.typ_nazovComboBox.TabIndex = 33
        Me.typ_nazovComboBox.ValueMember = "id"
        '
        'CtypkurzuBindingSource
        '
        Me.CtypkurzuBindingSource.DataMember = "c_typ_kurzu"

        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(471, 147)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Ulož zmeny"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'kurz_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 702)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.typ_nazovComboBox)
        Me.Controls.Add(Cislo_protokoluLabel)
        Me.Controls.Add(Me.Cislo_protokoluTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Clenovia_kurzuDataGridView)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(Zaciatok_kurzuLabel)
        Me.Controls.Add(Me.Zaciatok_kurzuDateTimePicker)
        Me.Controls.Add(Koniec_kurzuLabel)
        Me.Controls.Add(Me.Koniec_kurzuDateTimePicker)
        Me.Controls.Add(TypLabel)
        Me.Controls.Add(Me.TypTextBox)
        Me.Controls.Add(Miesto_konaniaLabel)
        Me.Controls.Add(Me.Miesto_konaniaTextBox)
        Me.Controls.Add(Me.KurzBindingNavigator)
        Me.Controls.Add(Me.pridaj_clenaButton)
        Me.Name = "kurz_detail"
        Me.Text = "kurz_detail"
        CType(Me.KurzBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KurzBindingNavigator.ResumeLayout(False)
        Me.KurzBindingNavigator.PerformLayout()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        CType(Me.Clenovia_kurzuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clenovia_kurzuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        CType(Me.CtypkurzuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pridaj_clenaButton As System.Windows.Forms.Button

    Friend WithEvents KurzBindingSource As System.Windows.Forms.BindingSource
   
    Friend WithEvents KurzBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents KurzBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zaciatok_kurzuDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Koniec_kurzuDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TypTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_konaniaTextBox As System.Windows.Forms.TextBox

    Friend WithEvents Clenovia_kurzuBindingSource As System.Windows.Forms.BindingSource
    
    Friend WithEvents Clenovia_kurzuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datum_narodenia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IdLabel1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Cislo_protokoluTextBox As System.Windows.Forms.TextBox

    Friend WithEvents typ_nazovComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CtypkurzuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
