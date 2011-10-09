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
        Me.components = New System.ComponentModel.Container()
        Dim NazovLabel As System.Windows.Forms.Label
        Dim Zaciatok_kurzuLabel As System.Windows.Forms.Label
        Dim Koniec_kurzuLabel As System.Windows.Forms.Label
        Dim TypLabel As System.Windows.Forms.Label
        Dim Miesto_konaniaLabel As System.Windows.Forms.Label
        Dim Cislo_protokoluLabel As System.Windows.Forms.Label
        Dim NazovLabel1 As System.Windows.Forms.Label
        Dim TypLabel1 As System.Windows.Forms.Label
        Dim Miesto_konaniaLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kurz_detail))
        Me.pridaj_clenaButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.zmenButton = New System.Windows.Forms.Button()
        Me.ulozButton = New System.Windows.Forms.Button()
        Me.Kurz_idBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Kurz_idBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pilcik_dbDataSet = New pilcik.pilcik_dbDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Kurz_idBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NazovTextBox = New System.Windows.Forms.TextBox()
        Me.Zaciatok_kurzuDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Koniec_kurzuDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TypTextBox = New System.Windows.Forms.TextBox()
        Me.Miesto_konaniaTextBox = New System.Windows.Forms.TextBox()
        Me.Cislo_protokoluTextBox = New System.Windows.Forms.TextBox()
        Me.nazovComboBox = New System.Windows.Forms.ComboBox()
        Me.NazovkurzuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.typComboBox = New System.Windows.Forms.ComboBox()
        Me.CtypkurzuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.miestoKonaniaComboBox = New System.Windows.Forms.ComboBox()
        Me.MiestokonaniaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OsobaClenoviaKurzuDataGridView = New System.Windows.Forms.DataGridView()
        Me.OsobaClenoviaKurzuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Kurz_idTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.kurz_idTableAdapter()
        Me.TableAdapterManager = New pilcik.pilcik_dbDataSetTableAdapters.TableAdapterManager()
        Me.Nazov_kurzuTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.nazov_kurzuTableAdapter()
        Me.C_typ_kurzuTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.c_typ_kurzuTableAdapter()
        Me.Miesto_konaniaTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.miesto_konaniaTableAdapter()
        Me.OsobaClenoviaKurzuTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.osobaClenoviaKurzuTableAdapter()
        Me.ZmazClenaButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NazovLabel = New System.Windows.Forms.Label()
        Zaciatok_kurzuLabel = New System.Windows.Forms.Label()
        Koniec_kurzuLabel = New System.Windows.Forms.Label()
        TypLabel = New System.Windows.Forms.Label()
        Miesto_konaniaLabel = New System.Windows.Forms.Label()
        Cislo_protokoluLabel = New System.Windows.Forms.Label()
        NazovLabel1 = New System.Windows.Forms.Label()
        TypLabel1 = New System.Windows.Forms.Label()
        Miesto_konaniaLabel1 = New System.Windows.Forms.Label()
        CType(Me.Kurz_idBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Kurz_idBindingNavigator.SuspendLayout()
        CType(Me.Kurz_idBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pilcik_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NazovkurzuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtypkurzuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiestokonaniaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsobaClenoviaKurzuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsobaClenoviaKurzuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'NazovLabel1
        '
        NazovLabel1.AutoSize = True
        NazovLabel1.Location = New System.Drawing.Point(393, 367)
        NazovLabel1.Name = "NazovLabel1"
        NazovLabel1.Size = New System.Drawing.Size(39, 13)
        NazovLabel1.TabIndex = 37
        NazovLabel1.Text = "nazov:"
        '
        'TypLabel1
        '
        TypLabel1.AutoSize = True
        TypLabel1.Location = New System.Drawing.Point(393, 445)
        TypLabel1.Name = "TypLabel1"
        TypLabel1.Size = New System.Drawing.Size(24, 13)
        TypLabel1.TabIndex = 43
        TypLabel1.Text = "typ:"
        '
        'Miesto_konaniaLabel1
        '
        Miesto_konaniaLabel1.AutoSize = True
        Miesto_konaniaLabel1.Location = New System.Drawing.Point(393, 471)
        Miesto_konaniaLabel1.Name = "Miesto_konaniaLabel1"
        Miesto_konaniaLabel1.Size = New System.Drawing.Size(81, 13)
        Miesto_konaniaLabel1.TabIndex = 45
        Miesto_konaniaLabel1.Text = "miesto konania:"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(686, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Detaily kurzu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(402, 514)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Label2"
        '
        'zmenButton
        '
        Me.zmenButton.Location = New System.Drawing.Point(480, 182)
        Me.zmenButton.Name = "zmenButton"
        Me.zmenButton.Size = New System.Drawing.Size(75, 23)
        Me.zmenButton.TabIndex = 31
        Me.zmenButton.Text = "Zmeň detaily kurzu"
        Me.zmenButton.UseVisualStyleBackColor = True
        '
        'ulozButton
        '
        Me.ulozButton.Location = New System.Drawing.Point(582, 182)
        Me.ulozButton.Name = "ulozButton"
        Me.ulozButton.Size = New System.Drawing.Size(75, 23)
        Me.ulozButton.TabIndex = 34
        Me.ulozButton.Text = "Ulož zmeny"
        Me.ulozButton.UseVisualStyleBackColor = True
        Me.ulozButton.Visible = False
        '
        'Kurz_idBindingNavigator
        '
        Me.Kurz_idBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Kurz_idBindingNavigator.BindingSource = Me.Kurz_idBindingSource
        Me.Kurz_idBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Kurz_idBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Kurz_idBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Kurz_idBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Kurz_idBindingNavigatorSaveItem})
        Me.Kurz_idBindingNavigator.Location = New System.Drawing.Point(0, 677)
        Me.Kurz_idBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Kurz_idBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Kurz_idBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Kurz_idBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Kurz_idBindingNavigator.Name = "Kurz_idBindingNavigator"
        Me.Kurz_idBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Kurz_idBindingNavigator.Size = New System.Drawing.Size(1157, 25)
        Me.Kurz_idBindingNavigator.TabIndex = 35
        Me.Kurz_idBindingNavigator.Text = "BindingNavigator1"
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
        'Kurz_idBindingSource
        '
        Me.Kurz_idBindingSource.DataMember = "kurz_id"
        Me.Kurz_idBindingSource.DataSource = Me.Pilcik_dbDataSet
        '
        'Pilcik_dbDataSet
        '
        Me.Pilcik_dbDataSet.DataSetName = "pilcik_dbDataSet"
        Me.Pilcik_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Kurz_idBindingNavigatorSaveItem
        '
        Me.Kurz_idBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Kurz_idBindingNavigatorSaveItem.Image = CType(resources.GetObject("Kurz_idBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Kurz_idBindingNavigatorSaveItem.Name = "Kurz_idBindingNavigatorSaveItem"
        Me.Kurz_idBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Kurz_idBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NazovTextBox
        '
        Me.NazovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Kurz_idBindingSource, "nazov", True))
        Me.NazovTextBox.Location = New System.Drawing.Point(480, 364)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NazovTextBox.TabIndex = 38
        '
        'Zaciatok_kurzuDateTimePicker
        '
        Me.Zaciatok_kurzuDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Kurz_idBindingSource, "zaciatok_kurzu", True))
        Me.Zaciatok_kurzuDateTimePicker.Enabled = False
        Me.Zaciatok_kurzuDateTimePicker.Location = New System.Drawing.Point(153, 67)
        Me.Zaciatok_kurzuDateTimePicker.Name = "Zaciatok_kurzuDateTimePicker"
        Me.Zaciatok_kurzuDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Zaciatok_kurzuDateTimePicker.TabIndex = 40
        '
        'Koniec_kurzuDateTimePicker
        '
        Me.Koniec_kurzuDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Kurz_idBindingSource, "koniec_kurzu", True))
        Me.Koniec_kurzuDateTimePicker.Enabled = False
        Me.Koniec_kurzuDateTimePicker.Location = New System.Drawing.Point(153, 97)
        Me.Koniec_kurzuDateTimePicker.Name = "Koniec_kurzuDateTimePicker"
        Me.Koniec_kurzuDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Koniec_kurzuDateTimePicker.TabIndex = 42
        '
        'TypTextBox
        '
        Me.TypTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Kurz_idBindingSource, "typ", True))
        Me.TypTextBox.Location = New System.Drawing.Point(480, 442)
        Me.TypTextBox.Name = "TypTextBox"
        Me.TypTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TypTextBox.TabIndex = 44
        '
        'Miesto_konaniaTextBox
        '
        Me.Miesto_konaniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Kurz_idBindingSource, "miesto_konania", True))
        Me.Miesto_konaniaTextBox.Location = New System.Drawing.Point(480, 468)
        Me.Miesto_konaniaTextBox.Name = "Miesto_konaniaTextBox"
        Me.Miesto_konaniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_konaniaTextBox.TabIndex = 46
        '
        'Cislo_protokoluTextBox
        '
        Me.Cislo_protokoluTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Kurz_idBindingSource, "cislo_protokolu", True))
        Me.Cislo_protokoluTextBox.Enabled = False
        Me.Cislo_protokoluTextBox.Location = New System.Drawing.Point(153, 175)
        Me.Cislo_protokoluTextBox.Name = "Cislo_protokoluTextBox"
        Me.Cislo_protokoluTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_protokoluTextBox.TabIndex = 48
        '
        'nazovComboBox
        '
        Me.nazovComboBox.DataSource = Me.NazovkurzuBindingSource
        Me.nazovComboBox.DisplayMember = "nazov"
        Me.nazovComboBox.Enabled = False
        Me.nazovComboBox.FormattingEnabled = True
        Me.nazovComboBox.Location = New System.Drawing.Point(153, 34)
        Me.nazovComboBox.Name = "nazovComboBox"
        Me.nazovComboBox.Size = New System.Drawing.Size(296, 21)
        Me.nazovComboBox.TabIndex = 49
        Me.nazovComboBox.ValueMember = "ID"
        '
        'NazovkurzuBindingSource
        '
        Me.NazovkurzuBindingSource.DataMember = "nazov_kurzu"
        Me.NazovkurzuBindingSource.DataSource = Me.Pilcik_dbDataSet
        '
        'typComboBox
        '
        Me.typComboBox.DataSource = Me.CtypkurzuBindingSource
        Me.typComboBox.DisplayMember = "nazov"
        Me.typComboBox.Enabled = False
        Me.typComboBox.FormattingEnabled = True
        Me.typComboBox.Location = New System.Drawing.Point(153, 123)
        Me.typComboBox.Name = "typComboBox"
        Me.typComboBox.Size = New System.Drawing.Size(200, 21)
        Me.typComboBox.TabIndex = 50
        Me.typComboBox.ValueMember = "ID"
        '
        'CtypkurzuBindingSource
        '
        Me.CtypkurzuBindingSource.DataMember = "c_typ_kurzu"
        Me.CtypkurzuBindingSource.DataSource = Me.Pilcik_dbDataSet
        '
        'miestoKonaniaComboBox
        '
        Me.miestoKonaniaComboBox.DataSource = Me.MiestokonaniaBindingSource
        Me.miestoKonaniaComboBox.DisplayMember = "miesto_konania"
        Me.miestoKonaniaComboBox.Enabled = False
        Me.miestoKonaniaComboBox.FormattingEnabled = True
        Me.miestoKonaniaComboBox.Location = New System.Drawing.Point(153, 150)
        Me.miestoKonaniaComboBox.Name = "miestoKonaniaComboBox"
        Me.miestoKonaniaComboBox.Size = New System.Drawing.Size(200, 21)
        Me.miestoKonaniaComboBox.TabIndex = 51
        Me.miestoKonaniaComboBox.ValueMember = "ID"
        '
        'MiestokonaniaBindingSource
        '
        Me.MiestokonaniaBindingSource.DataMember = "miesto_konania"
        Me.MiestokonaniaBindingSource.DataSource = Me.Pilcik_dbDataSet
        '
        'OsobaClenoviaKurzuDataGridView
        '
        Me.OsobaClenoviaKurzuDataGridView.AllowUserToAddRows = False
        Me.OsobaClenoviaKurzuDataGridView.AllowUserToDeleteRows = False
        Me.OsobaClenoviaKurzuDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OsobaClenoviaKurzuDataGridView.AutoGenerateColumns = False
        Me.OsobaClenoviaKurzuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OsobaClenoviaKurzuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OsobaClenoviaKurzuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
        Me.OsobaClenoviaKurzuDataGridView.DataSource = Me.OsobaClenoviaKurzuBindingSource
        Me.OsobaClenoviaKurzuDataGridView.Location = New System.Drawing.Point(12, 270)
        Me.OsobaClenoviaKurzuDataGridView.Name = "OsobaClenoviaKurzuDataGridView"
        Me.OsobaClenoviaKurzuDataGridView.ReadOnly = True
        Me.OsobaClenoviaKurzuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OsobaClenoviaKurzuDataGridView.Size = New System.Drawing.Size(1133, 404)
        Me.OsobaClenoviaKurzuDataGridView.TabIndex = 51
        '
        'OsobaClenoviaKurzuBindingSource
        '
        Me.OsobaClenoviaKurzuBindingSource.DataMember = "osobaClenoviaKurzu"
        Me.OsobaClenoviaKurzuBindingSource.DataSource = Me.Pilcik_dbDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(402, 533)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Label3"
        '
        'Kurz_idTableAdapter
        '
        Me.Kurz_idTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.c_typ_kurzuTableAdapter = Nothing
        Me.TableAdapterManager.clenovia_kurzuTableAdapter = Nothing
        Me.TableAdapterManager.kurz_idTableAdapter = Me.Kurz_idTableAdapter
        Me.TableAdapterManager.miesto_konaniaTableAdapter = Nothing
        Me.TableAdapterManager.nazov_kurzuTableAdapter = Nothing
        Me.TableAdapterManager.osobaClenoviaKurzuTableAdapter = Nothing
        Me.TableAdapterManager.osobaTableAdapter = Nothing
        Me.TableAdapterManager.skusobna_komisiaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pilcik.pilcik_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vseobecne_udajeTableAdapter = Nothing
        '
        'Nazov_kurzuTableAdapter
        '
        Me.Nazov_kurzuTableAdapter.ClearBeforeFill = True
        '
        'C_typ_kurzuTableAdapter
        '
        Me.C_typ_kurzuTableAdapter.ClearBeforeFill = True
        '
        'Miesto_konaniaTableAdapter
        '
        Me.Miesto_konaniaTableAdapter.ClearBeforeFill = True
        '
        'OsobaClenoviaKurzuTableAdapter
        '
        Me.OsobaClenoviaKurzuTableAdapter.ClearBeforeFill = True
        '
        'ZmazClenaButton
        '
        Me.ZmazClenaButton.Location = New System.Drawing.Point(153, 216)
        Me.ZmazClenaButton.Name = "ZmazClenaButton"
        Me.ZmazClenaButton.Size = New System.Drawing.Size(152, 23)
        Me.ZmazClenaButton.TabIndex = 53
        Me.ZmazClenaButton.Text = "Zmaž člena kurzu"
        Me.ZmazClenaButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Label4"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "priezvisko"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Priezvisko"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "meno"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Meno"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "datum_narodenia"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dátum narodenia"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cislo_pilcickeho_preukazu"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Číslo pilčíckeho preukazu"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'kurz_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 702)
        Me.Controls.Add(Me.ZmazClenaButton)
        Me.Controls.Add(Me.OsobaClenoviaKurzuDataGridView)
        Me.Controls.Add(Me.miestoKonaniaComboBox)
        Me.Controls.Add(Me.typComboBox)
        Me.Controls.Add(Me.nazovComboBox)
        Me.Controls.Add(NazovLabel1)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(Me.Zaciatok_kurzuDateTimePicker)
        Me.Controls.Add(Me.Koniec_kurzuDateTimePicker)
        Me.Controls.Add(TypLabel1)
        Me.Controls.Add(Me.TypTextBox)
        Me.Controls.Add(Miesto_konaniaLabel1)
        Me.Controls.Add(Me.Miesto_konaniaTextBox)
        Me.Controls.Add(Me.Cislo_protokoluTextBox)
        Me.Controls.Add(Me.Kurz_idBindingNavigator)
        Me.Controls.Add(Me.ulozButton)
        Me.Controls.Add(Cislo_protokoluLabel)
        Me.Controls.Add(Me.zmenButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Zaciatok_kurzuLabel)
        Me.Controls.Add(Koniec_kurzuLabel)
        Me.Controls.Add(TypLabel)
        Me.Controls.Add(Miesto_konaniaLabel)
        Me.Controls.Add(Me.pridaj_clenaButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "kurz_detail"
        Me.Text = "kurz_detail"
        CType(Me.Kurz_idBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Kurz_idBindingNavigator.ResumeLayout(False)
        Me.Kurz_idBindingNavigator.PerformLayout()
        CType(Me.Kurz_idBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pilcik_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NazovkurzuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtypkurzuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiestokonaniaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsobaClenoviaKurzuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsobaClenoviaKurzuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pridaj_clenaButton As System.Windows.Forms.Button




    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents zmenButton As System.Windows.Forms.Button

    Friend WithEvents ulozButton As System.Windows.Forms.Button
    Friend WithEvents Pilcik_dbDataSet As pilcik.pilcik_dbDataSet
    Friend WithEvents Kurz_idBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Kurz_idTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.kurz_idTableAdapter
    Friend WithEvents TableAdapterManager As pilcik.pilcik_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Kurz_idBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Kurz_idBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zaciatok_kurzuDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Koniec_kurzuDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TypTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_konaniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_protokoluTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nazovComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NazovkurzuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Nazov_kurzuTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.nazov_kurzuTableAdapter
    Friend WithEvents typComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CtypkurzuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents C_typ_kurzuTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.c_typ_kurzuTableAdapter
    Friend WithEvents miestoKonaniaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MiestokonaniaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Miesto_konaniaTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.miesto_konaniaTableAdapter
    Friend WithEvents OsobaClenoviaKurzuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OsobaClenoviaKurzuTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.osobaClenoviaKurzuTableAdapter
    Friend WithEvents OsobaClenoviaKurzuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ZmazClenaButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
