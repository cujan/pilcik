<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class osoba_detail
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
        Dim Titul_predLabel As System.Windows.Forms.Label
        Dim PriezviskoLabel As System.Windows.Forms.Label
        Dim MenoLabel As System.Windows.Forms.Label
        Dim Datum_narodeniaLabel As System.Windows.Forms.Label
        Dim Rodne_cisloLabel As System.Windows.Forms.Label
        Dim Cislo_opLabel As System.Windows.Forms.Label
        Dim UlicaLabel As System.Windows.Forms.Label
        Dim MestoLabel As System.Windows.Forms.Label
        Dim PscLabel As System.Windows.Forms.Label
        Dim Cislo_pilcickeho_preukazuLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(osoba_detail))
        Me.OsobaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.OsobaBindingSource = New System.Windows.Forms.BindingSource(Me.components)

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
        Me.OsobaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Titul_predTextBox = New System.Windows.Forms.TextBox
        Me.PriezviskoTextBox = New System.Windows.Forms.TextBox
        Me.MenoTextBox = New System.Windows.Forms.TextBox
        Me.Datum_narodeniaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Rodne_cisloTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_opTextBox = New System.Windows.Forms.TextBox
        Me.UlicaTextBox = New System.Windows.Forms.TextBox
        Me.MestoTextBox = New System.Windows.Forms.TextBox
        Me.PscTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_pilcickeho_preukazuTextBox = New System.Windows.Forms.TextBox
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.TelefonTextBox = New System.Windows.Forms.TextBox
      
        Me.ulozButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label

        Me.Clenovia_kurzuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
       
        Me.Clenovia_kurzuDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Titul_predLabel = New System.Windows.Forms.Label
        PriezviskoLabel = New System.Windows.Forms.Label
        MenoLabel = New System.Windows.Forms.Label
        Datum_narodeniaLabel = New System.Windows.Forms.Label
        Rodne_cisloLabel = New System.Windows.Forms.Label
        Cislo_opLabel = New System.Windows.Forms.Label
        UlicaLabel = New System.Windows.Forms.Label
        MestoLabel = New System.Windows.Forms.Label
        PscLabel = New System.Windows.Forms.Label
        Cislo_pilcickeho_preukazuLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        TelefonLabel = New System.Windows.Forms.Label
        CType(Me.OsobaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OsobaBindingNavigator.SuspendLayout()
        CType(Me.OsobaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()


        CType(Me.Clenovia_kurzuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clenovia_kurzuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Titul_predLabel
        '
        Titul_predLabel.AutoSize = True
        Titul_predLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Titul_predLabel.Location = New System.Drawing.Point(12, 33)
        Titul_predLabel.Name = "Titul_predLabel"
        Titul_predLabel.Size = New System.Drawing.Size(65, 13)
        Titul_predLabel.TabIndex = 3
        Titul_predLabel.Text = "Titul pred:"
        '
        'PriezviskoLabel
        '
        PriezviskoLabel.AutoSize = True
        PriezviskoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        PriezviskoLabel.Location = New System.Drawing.Point(149, 33)
        PriezviskoLabel.Name = "PriezviskoLabel"
        PriezviskoLabel.Size = New System.Drawing.Size(69, 13)
        PriezviskoLabel.TabIndex = 5
        PriezviskoLabel.Text = "Priezvisko:"
        '
        'MenoLabel
        '
        MenoLabel.AutoSize = True
        MenoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        MenoLabel.Location = New System.Drawing.Point(430, 33)
        MenoLabel.Name = "MenoLabel"
        MenoLabel.Size = New System.Drawing.Size(42, 13)
        MenoLabel.TabIndex = 7
        MenoLabel.Text = "Meno:"
        '
        'Datum_narodeniaLabel
        '
        Datum_narodeniaLabel.AutoSize = True
        Datum_narodeniaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Datum_narodeniaLabel.Location = New System.Drawing.Point(25, 88)
        Datum_narodeniaLabel.Name = "Datum_narodeniaLabel"
        Datum_narodeniaLabel.Size = New System.Drawing.Size(107, 13)
        Datum_narodeniaLabel.TabIndex = 9
        Datum_narodeniaLabel.Text = "Dátum narodenia:"
        '
        'Rodne_cisloLabel
        '
        Rodne_cisloLabel.AutoSize = True
        Rodne_cisloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Rodne_cisloLabel.Location = New System.Drawing.Point(29, 132)
        Rodne_cisloLabel.Name = "Rodne_cisloLabel"
        Rodne_cisloLabel.Size = New System.Drawing.Size(80, 13)
        Rodne_cisloLabel.TabIndex = 11
        Rodne_cisloLabel.Text = "Rodné číslo:"
        '
        'Cislo_opLabel
        '
        Cislo_opLabel.AutoSize = True
        Cislo_opLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Cislo_opLabel.Location = New System.Drawing.Point(29, 174)
        Cislo_opLabel.Name = "Cislo_opLabel"
        Cislo_opLabel.Size = New System.Drawing.Size(58, 13)
        Cislo_opLabel.TabIndex = 13
        Cislo_opLabel.Text = "Číslo op:"
        '
        'UlicaLabel
        '
        UlicaLabel.AutoSize = True
        UlicaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        UlicaLabel.Location = New System.Drawing.Point(435, 128)
        UlicaLabel.Name = "UlicaLabel"
        UlicaLabel.Size = New System.Drawing.Size(40, 13)
        UlicaLabel.TabIndex = 15
        UlicaLabel.Text = "Ulica:"
        '
        'MestoLabel
        '
        MestoLabel.AutoSize = True
        MestoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        MestoLabel.Location = New System.Drawing.Point(430, 154)
        MestoLabel.Name = "MestoLabel"
        MestoLabel.Size = New System.Drawing.Size(45, 13)
        MestoLabel.TabIndex = 17
        MestoLabel.Text = "Mesto:"
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        PscLabel.Location = New System.Drawing.Point(437, 180)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(35, 13)
        PscLabel.TabIndex = 19
        PscLabel.Text = "PSČ:"
        '
        'Cislo_pilcickeho_preukazuLabel
        '
        Cislo_pilcickeho_preukazuLabel.AutoSize = True
        Cislo_pilcickeho_preukazuLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Cislo_pilcickeho_preukazuLabel.Location = New System.Drawing.Point(29, 221)
        Cislo_pilcickeho_preukazuLabel.Name = "Cislo_pilcickeho_preukazuLabel"
        Cislo_pilcickeho_preukazuLabel.Size = New System.Drawing.Size(160, 13)
        Cislo_pilcickeho_preukazuLabel.TabIndex = 21
        Cislo_pilcickeho_preukazuLabel.Text = "Číslo pilčíckeho preukazu:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        EmailLabel.Location = New System.Drawing.Point(144, 247)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 13)
        EmailLabel.TabIndex = 23
        EmailLabel.Text = "E-mail:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        TelefonLabel.Location = New System.Drawing.Point(135, 270)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(54, 13)
        TelefonLabel.TabIndex = 25
        TelefonLabel.Text = "Telefón:"
        '
        'OsobaBindingNavigator
        '
        Me.OsobaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OsobaBindingNavigator.BindingSource = Me.OsobaBindingSource
        Me.OsobaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OsobaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OsobaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.OsobaBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.OsobaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OsobaBindingNavigatorSaveItem})
        Me.OsobaBindingNavigator.Location = New System.Drawing.Point(0, 688)
        Me.OsobaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OsobaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OsobaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OsobaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OsobaBindingNavigator.Name = "OsobaBindingNavigator"
        Me.OsobaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OsobaBindingNavigator.Size = New System.Drawing.Size(898, 25)
        Me.OsobaBindingNavigator.TabIndex = 0
        Me.OsobaBindingNavigator.Text = "BindingNavigator1"
        Me.OsobaBindingNavigator.Visible = False
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
        'OsobaBindingSource
        '
        Me.OsobaBindingSource.DataMember = "osoba"

        '
        'PilcikdbDataSet
        '
 
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
        'OsobaBindingNavigatorSaveItem
        '
        Me.OsobaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OsobaBindingNavigatorSaveItem.Image = CType(resources.GetObject("OsobaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OsobaBindingNavigatorSaveItem.Name = "OsobaBindingNavigatorSaveItem"
        Me.OsobaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OsobaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Titul_predTextBox
        '
        Me.Titul_predTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource, "titul_pred", True))
        Me.Titul_predTextBox.Location = New System.Drawing.Point(83, 30)
        Me.Titul_predTextBox.Name = "Titul_predTextBox"
        Me.Titul_predTextBox.Size = New System.Drawing.Size(60, 20)
        Me.Titul_predTextBox.TabIndex = 4
        '
        'PriezviskoTextBox
        '
        Me.PriezviskoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource, "priezvisko", True))
        Me.PriezviskoTextBox.Location = New System.Drawing.Point(224, 30)
        Me.PriezviskoTextBox.Name = "PriezviskoTextBox"
        Me.PriezviskoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PriezviskoTextBox.TabIndex = 6
        '
        'MenoTextBox
        '
        Me.MenoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource, "meno", True))
        Me.MenoTextBox.Location = New System.Drawing.Point(481, 30)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(145, 20)
        Me.MenoTextBox.TabIndex = 8
        '
        'Datum_narodeniaDateTimePicker
        '
        Me.Datum_narodeniaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OsobaBindingSource, "datum_narodenia", True))
        Me.Datum_narodeniaDateTimePicker.Location = New System.Drawing.Point(138, 84)
        Me.Datum_narodeniaDateTimePicker.Name = "Datum_narodeniaDateTimePicker"
        Me.Datum_narodeniaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Datum_narodeniaDateTimePicker.TabIndex = 10
        '
        'Rodne_cisloTextBox
        '
        Me.Rodne_cisloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource, "rodne_cislo", True))
        Me.Rodne_cisloTextBox.Location = New System.Drawing.Point(138, 132)
        Me.Rodne_cisloTextBox.Name = "Rodne_cisloTextBox"
        Me.Rodne_cisloTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Rodne_cisloTextBox.TabIndex = 12
        '
        'Cislo_opTextBox
        '
        Me.Cislo_opTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource, "cislo_op", True))
        Me.Cislo_opTextBox.Location = New System.Drawing.Point(138, 171)
        Me.Cislo_opTextBox.Name = "Cislo_opTextBox"
        Me.Cislo_opTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_opTextBox.TabIndex = 14
        '
        'UlicaTextBox
        '
        Me.UlicaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource, "ulica", True))
        Me.UlicaTextBox.Location = New System.Drawing.Point(481, 125)
        Me.UlicaTextBox.Name = "UlicaTextBox"
        Me.UlicaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UlicaTextBox.TabIndex = 16
        '
        'MestoTextBox
        '
        Me.MestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource, "mesto", True))
        Me.MestoTextBox.Location = New System.Drawing.Point(481, 151)
        Me.MestoTextBox.Name = "MestoTextBox"
        Me.MestoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MestoTextBox.TabIndex = 18
        '
        'PscTextBox
        '
        Me.PscTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource, "psc", True))
        Me.PscTextBox.Location = New System.Drawing.Point(481, 177)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PscTextBox.TabIndex = 20
        '
        'Cislo_pilcickeho_preukazuTextBox
        '
        Me.Cislo_pilcickeho_preukazuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource, "cislo_pilcickeho_preukazu", True))
        Me.Cislo_pilcickeho_preukazuTextBox.Location = New System.Drawing.Point(195, 214)
        Me.Cislo_pilcickeho_preukazuTextBox.Name = "Cislo_pilcickeho_preukazuTextBox"
        Me.Cislo_pilcickeho_preukazuTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_pilcickeho_preukazuTextBox.TabIndex = 22
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(195, 240)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 24
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource, "telefon", True))
        Me.TelefonTextBox.Location = New System.Drawing.Point(195, 267)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelefonTextBox.TabIndex = 26
        '
        'OsobaTableAdapter
        '

        '
        'TableAdapterManager
        '
        

        '
        'ulozButton
        '
        Me.ulozButton.Location = New System.Drawing.Point(704, 47)
        Me.ulozButton.Name = "ulozButton"
        Me.ulozButton.Size = New System.Drawing.Size(75, 23)
        Me.ulozButton.TabIndex = 27
        Me.ulozButton.Text = "Ulož"
        Me.ulozButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Absolvované kurzy"
        '
        'AbsolvovaneKurzyDataSet
        '
    
        '
        'Clenovia_kurzuBindingSource
        '
        Me.Clenovia_kurzuBindingSource.DataMember = "clenovia_kurzu"

        '
        'Clenovia_kurzuTableAdapter
        '

        '
        'TableAdapterManager1
        '
     

        '
        'Clenovia_kurzuDataGridView
        '
        Me.Clenovia_kurzuDataGridView.AllowUserToAddRows = False
        Me.Clenovia_kurzuDataGridView.AllowUserToDeleteRows = False
        Me.Clenovia_kurzuDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Clenovia_kurzuDataGridView.AutoGenerateColumns = False
        Me.Clenovia_kurzuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Clenovia_kurzuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Clenovia_kurzuDataGridView.DataSource = Me.Clenovia_kurzuBindingSource
        Me.Clenovia_kurzuDataGridView.Location = New System.Drawing.Point(12, 350)
        Me.Clenovia_kurzuDataGridView.Name = "Clenovia_kurzuDataGridView"
        Me.Clenovia_kurzuDataGridView.ReadOnly = True
        Me.Clenovia_kurzuDataGridView.Size = New System.Drawing.Size(871, 351)
        Me.Clenovia_kurzuDataGridView.TabIndex = 29
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nazov"
        Me.DataGridViewTextBoxColumn5.HeaderText = "nazov"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "zaciatok_kurzu"
        Me.DataGridViewTextBoxColumn6.HeaderText = "zaciatok_kurzu"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "koniec_kurzu"
        Me.DataGridViewTextBoxColumn7.HeaderText = "koniec_kurzu"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "typ"
        Me.DataGridViewTextBoxColumn8.HeaderText = "typ"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'osoba_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 713)
        Me.Controls.Add(Me.Clenovia_kurzuDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ulozButton)
        Me.Controls.Add(Titul_predLabel)
        Me.Controls.Add(Me.Titul_predTextBox)
        Me.Controls.Add(PriezviskoLabel)
        Me.Controls.Add(Me.PriezviskoTextBox)
        Me.Controls.Add(MenoLabel)
        Me.Controls.Add(Me.MenoTextBox)
        Me.Controls.Add(Datum_narodeniaLabel)
        Me.Controls.Add(Me.Datum_narodeniaDateTimePicker)
        Me.Controls.Add(Rodne_cisloLabel)
        Me.Controls.Add(Me.Rodne_cisloTextBox)
        Me.Controls.Add(Cislo_opLabel)
        Me.Controls.Add(Me.Cislo_opTextBox)
        Me.Controls.Add(UlicaLabel)
        Me.Controls.Add(Me.UlicaTextBox)
        Me.Controls.Add(MestoLabel)
        Me.Controls.Add(Me.MestoTextBox)
        Me.Controls.Add(PscLabel)
        Me.Controls.Add(Me.PscTextBox)
        Me.Controls.Add(Cislo_pilcickeho_preukazuLabel)
        Me.Controls.Add(Me.Cislo_pilcickeho_preukazuTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(Me.OsobaBindingNavigator)
        Me.Name = "osoba_detail"
        Me.Text = "osoba_detail"
        CType(Me.OsobaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OsobaBindingNavigator.ResumeLayout(False)
        Me.OsobaBindingNavigator.PerformLayout()
        CType(Me.OsobaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()


        CType(Me.Clenovia_kurzuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clenovia_kurzuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OsobaBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents OsobaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents OsobaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Titul_predTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_narodeniaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Rodne_cisloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_opTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UlicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_pilcickeho_preukazuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ulozButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Friend WithEvents Clenovia_kurzuBindingSource As System.Windows.Forms.BindingSource
  
    Friend WithEvents Clenovia_kurzuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
