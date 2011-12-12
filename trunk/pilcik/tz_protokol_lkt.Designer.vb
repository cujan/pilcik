<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tz_protokol_lkt
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
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pilcik_dbDataSet = New pilcik.pilcik_dbDataSet()
        Me.vseobecne_udajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vseobecne_udajeTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.vseobecne_udajeTableAdapter()
        Me.protokolKurzBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.protokolKurzTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.protokolKurzTableAdapter()
        Me.skusobna_komisiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.skusobna_komisiaTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.skusobna_komisiaTableAdapter()
        Me.osobaClenoviaKurzuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.osobaClenoviaKurzuTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.osobaClenoviaKurzuTableAdapter()
        Me.pocetClenovKurzuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pocetClenovKurzuTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.pocetClenovKurzuTableAdapter()
        CType(Me.pilcik_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vseobecne_udajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.protokolKurzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skusobna_komisiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.osobaClenoviaKurzuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pocetClenovKurzuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource6.Name = "vseobecneUdaje"
        ReportDataSource6.Value = Me.vseobecne_udajeBindingSource
        ReportDataSource7.Name = "kurz"
        ReportDataSource7.Value = Me.protokolKurzBindingSource
        ReportDataSource8.Name = "skusobnaKomisia"
        ReportDataSource8.Value = Me.skusobna_komisiaBindingSource
        ReportDataSource9.Name = "osobaClenoviaKurzu"
        ReportDataSource9.Value = Me.osobaClenoviaKurzuBindingSource
        ReportDataSource10.Name = "pocetClenovKurzu"
        ReportDataSource10.Value = Me.pocetClenovKurzuBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "pilcik.protokol_lkt_Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(954, 719)
        Me.ReportViewer1.TabIndex = 0
        '
        'pilcik_dbDataSet
        '
        Me.pilcik_dbDataSet.DataSetName = "pilcik_dbDataSet"
        Me.pilcik_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vseobecne_udajeBindingSource
        '
        Me.vseobecne_udajeBindingSource.DataMember = "vseobecne_udaje"
        Me.vseobecne_udajeBindingSource.DataSource = Me.pilcik_dbDataSet
        '
        'vseobecne_udajeTableAdapter
        '
        Me.vseobecne_udajeTableAdapter.ClearBeforeFill = True
        '
        'protokolKurzBindingSource
        '
        Me.protokolKurzBindingSource.DataMember = "protokolKurz"
        Me.protokolKurzBindingSource.DataSource = Me.pilcik_dbDataSet
        '
        'protokolKurzTableAdapter
        '
        Me.protokolKurzTableAdapter.ClearBeforeFill = True
        '
        'skusobna_komisiaBindingSource
        '
        Me.skusobna_komisiaBindingSource.DataMember = "skusobna_komisia"
        Me.skusobna_komisiaBindingSource.DataSource = Me.pilcik_dbDataSet
        '
        'skusobna_komisiaTableAdapter
        '
        Me.skusobna_komisiaTableAdapter.ClearBeforeFill = True
        '
        'osobaClenoviaKurzuBindingSource
        '
        Me.osobaClenoviaKurzuBindingSource.DataMember = "osobaClenoviaKurzu"
        Me.osobaClenoviaKurzuBindingSource.DataSource = Me.pilcik_dbDataSet
        '
        'osobaClenoviaKurzuTableAdapter
        '
        Me.osobaClenoviaKurzuTableAdapter.ClearBeforeFill = True
        '
        'pocetClenovKurzuBindingSource
        '
        Me.pocetClenovKurzuBindingSource.DataMember = "pocetClenovKurzu"
        Me.pocetClenovKurzuBindingSource.DataSource = Me.pilcik_dbDataSet
        '
        'pocetClenovKurzuTableAdapter
        '
        Me.pocetClenovKurzuTableAdapter.ClearBeforeFill = True
        '
        'tz_protokol_lkt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 719)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "tz_protokol_lkt"
        Me.Text = "tz_protokol_lkt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pilcik_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vseobecne_udajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.protokolKurzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skusobna_komisiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.osobaClenoviaKurzuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pocetClenovKurzuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vseobecne_udajeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents pilcik_dbDataSet As pilcik.pilcik_dbDataSet
    Friend WithEvents protokolKurzBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents skusobna_komisiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents osobaClenoviaKurzuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents pocetClenovKurzuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents vseobecne_udajeTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.vseobecne_udajeTableAdapter
    Friend WithEvents protokolKurzTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.protokolKurzTableAdapter
    Friend WithEvents skusobna_komisiaTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.skusobna_komisiaTableAdapter
    Friend WithEvents osobaClenoviaKurzuTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.osobaClenoviaKurzuTableAdapter
    Friend WithEvents pocetClenovKurzuTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.pocetClenovKurzuTableAdapter



End Class
