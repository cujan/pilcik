<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tz_protokol_pila
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.VseobecneudajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pilcik_dbDataSet = New pilcik.pilcik_dbDataSet()
        Me.ProtokolKurzBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkusobnakomisiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KurzBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OsobaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Vseobecne_udajeTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.vseobecne_udajeTableAdapter()
        Me.KurzTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.kurzTableAdapter()
        Me.ProtokolKurzTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.protokolKurzTableAdapter()
        Me.Skusobna_komisiaTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.skusobna_komisiaTableAdapter()
        Me.OsobaClenoviaKurzuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OsobaClenoviaKurzuTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.osobaClenoviaKurzuTableAdapter()
        Me.vseobecne_udajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.skusobna_komisiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.VseobecneudajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pilcik_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProtokolKurzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkusobnakomisiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsobaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsobaClenoviaKurzuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vseobecne_udajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skusobna_komisiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VseobecneudajeBindingSource
        '
        Me.VseobecneudajeBindingSource.DataMember = "vseobecne_udaje"
        Me.VseobecneudajeBindingSource.DataSource = Me.Pilcik_dbDataSet
        '
        'Pilcik_dbDataSet
        '
        Me.Pilcik_dbDataSet.DataSetName = "pilcik_dbDataSet"
        Me.Pilcik_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProtokolKurzBindingSource
        '
        Me.ProtokolKurzBindingSource.DataMember = "protokolKurz"
        Me.ProtokolKurzBindingSource.DataSource = Me.Pilcik_dbDataSet
        '
        'SkusobnakomisiaBindingSource
        '
        Me.SkusobnakomisiaBindingSource.DataMember = "skusobna_komisia"
        Me.SkusobnakomisiaBindingSource.DataSource = Me.Pilcik_dbDataSet
        '
        'KurzBindingSource
        '
        Me.KurzBindingSource.DataMember = "kurz"
        Me.KurzBindingSource.DataSource = Me.Pilcik_dbDataSet
        '
        'OsobaBindingSource
        '
        Me.OsobaBindingSource.DataMember = "osoba"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "vseobecneUdaje"
        ReportDataSource1.Value = Me.vseobecne_udajeBindingSource
        ReportDataSource2.Name = "kurz"
        ReportDataSource2.Value = Me.ProtokolKurzBindingSource
        ReportDataSource3.Name = "skusobnaKomisia"
        ReportDataSource3.Value = Me.skusobna_komisiaBindingSource
        ReportDataSource4.Name = "osobaClenoviaKurzu"
        ReportDataSource4.Value = Me.OsobaClenoviaKurzuBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "pilcik.protokol_Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(726, 756)
        Me.ReportViewer1.TabIndex = 0
        '
        'Vseobecne_udajeTableAdapter
        '
        Me.Vseobecne_udajeTableAdapter.ClearBeforeFill = True
        '
        'KurzTableAdapter
        '
        Me.KurzTableAdapter.ClearBeforeFill = True
        '
        'ProtokolKurzTableAdapter
        '
        Me.ProtokolKurzTableAdapter.ClearBeforeFill = True
        '
        'Skusobna_komisiaTableAdapter
        '
        Me.Skusobna_komisiaTableAdapter.ClearBeforeFill = True
        '
        'OsobaClenoviaKurzuBindingSource
        '
        Me.OsobaClenoviaKurzuBindingSource.DataMember = "osobaClenoviaKurzu"
        Me.OsobaClenoviaKurzuBindingSource.DataSource = Me.Pilcik_dbDataSet
        '
        'OsobaClenoviaKurzuTableAdapter
        '
        Me.OsobaClenoviaKurzuTableAdapter.ClearBeforeFill = True
        '
        'vseobecne_udajeBindingSource
        '
        Me.vseobecne_udajeBindingSource.DataMember = "vseobecne_udaje"
        Me.vseobecne_udajeBindingSource.DataSource = Me.Pilcik_dbDataSet
        '
        'skusobna_komisiaBindingSource
        '
        Me.skusobna_komisiaBindingSource.DataMember = "skusobna_komisia"
        Me.skusobna_komisiaBindingSource.DataSource = Me.Pilcik_dbDataSet
        '
        'tz_protokol_pila
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 756)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "tz_protokol_pila"
        Me.Text = "tz_protokol"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.VseobecneudajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pilcik_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProtokolKurzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkusobnakomisiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsobaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsobaClenoviaKurzuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vseobecne_udajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skusobna_komisiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer


    Friend WithEvents OsobaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pilcik_dbDataSet As pilcik.pilcik_dbDataSet
    Friend WithEvents VseobecneudajeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vseobecne_udajeTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.vseobecne_udajeTableAdapter
    Friend WithEvents KurzBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KurzTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.kurzTableAdapter
    Friend WithEvents ProtokolKurzBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProtokolKurzTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.protokolKurzTableAdapter
    Friend WithEvents SkusobnakomisiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Skusobna_komisiaTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.skusobna_komisiaTableAdapter
    Friend WithEvents OsobaClenoviaKurzuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OsobaClenoviaKurzuTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.osobaClenoviaKurzuTableAdapter
    Friend WithEvents vseobecne_udajeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents skusobna_komisiaBindingSource As System.Windows.Forms.BindingSource






End Class
