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
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.KurzBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.skusobna_komisiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OsobaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer

        Me.SkusobnakomisiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)


        Me.ClenoviakurzuBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.clenovia_kurzuBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.VseobecneudajeDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vseobecne_udajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        CType(Me.skusobna_komisiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsobaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkusobnakomisiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        CType(Me.ClenoviakurzuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clenovia_kurzuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        CType(Me.VseobecneudajeDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vseobecne_udajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KurzBindingSource
        '
        Me.KurzBindingSource.DataMember = "kurz"

        '
        'ProtokolDataSet
        '
       
        '
        'skusobna_komisiaBindingSource
        '
        Me.skusobna_komisiaBindingSource.DataMember = "skusobna_komisia"

        '
        'OsobaBindingSource
        '
        Me.OsobaBindingSource.DataMember = "osoba"

        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "protokolDataSet_kurz"
        ReportDataSource1.Value = Me.KurzBindingSource
        ReportDataSource2.Name = "protokolDataSet_skusobna_komisia"
        ReportDataSource2.Value = Me.skusobna_komisiaBindingSource
        ReportDataSource3.Name = "protokolDataSet_osoba"
        ReportDataSource3.Value = Me.OsobaBindingSource
        ReportDataSource4.Name = "pocet_clenov_kurzuDataSet_clenovia_kurzu"
        ReportDataSource4.Value = Me.clenovia_kurzuBindingSource
        ReportDataSource5.Name = "vseobecne_udajeDataSet_vseobecne_udaje"
        ReportDataSource5.Value = Me.vseobecne_udajeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "pilcik.protokol_Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(726, 756)
        Me.ReportViewer1.TabIndex = 0
        '
        'KurzTableAdapter
        '

        '
        'SkusobnakomisiaBindingSource
        '
        Me.SkusobnakomisiaBindingSource.DataMember = "skusobna_komisia"
        
        'Skusobna_komisiaTableAdapter
        '

        '
        'OsobaTableAdapter
        '

        '
        'Pocet_clenov_kurzuDataSet
        '
        
        '
        'ClenoviakurzuBindingSource
        '
        Me.ClenoviakurzuBindingSource.DataMember = "clenovia_kurzu"

        '
        'Clenovia_kurzuTableAdapter
        '

        '
        'clenovia_kurzuBindingSource
        '
        Me.clenovia_kurzuBindingSource.DataMember = "clenovia_kurzu"

        '
        'Vseobecne_udajeDataSet
        '
        
        '
        'VseobecneudajeDataSetBindingSource
        '

        Me.VseobecneudajeDataSetBindingSource.Position = 0
        '
        'vseobecne_udajeBindingSource
        '
        Me.vseobecne_udajeBindingSource.DataMember = "vseobecne_udaje"

        '
        'vseobecne_udajeTableAdapter
        '

        '
        'tz_protokol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 756)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "tz_protokol"
        Me.Text = "tz_protokol"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        CType(Me.skusobna_komisiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsobaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkusobnakomisiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        CType(Me.ClenoviakurzuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clenovia_kurzuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        CType(Me.VseobecneudajeDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vseobecne_udajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents KurzBindingSource As System.Windows.Forms.BindingSource
    
    Friend WithEvents SkusobnakomisiaBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents OsobaBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents skusobna_komisiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents clenovia_kurzuBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents ClenoviakurzuBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents vseobecne_udajeBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents VseobecneudajeDataSetBindingSource As System.Windows.Forms.BindingSource


End Class
