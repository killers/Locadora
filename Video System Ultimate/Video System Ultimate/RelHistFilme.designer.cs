namespace Video_System_Ultimate
{
    partial class RelHistFilme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RelatoriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_VIDEO_SYSTEM_ULTIMATEDataSet = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RelatoriosTableAdapter = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.RelatoriosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RelatoriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_VIDEO_SYSTEM_ULTIMATEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // RelatoriosBindingSource
            // 
            this.RelatoriosBindingSource.DataMember = "Relatorios";
            this.RelatoriosBindingSource.DataSource = this.BD_VIDEO_SYSTEM_ULTIMATEDataSet;
            // 
            // BD_VIDEO_SYSTEM_ULTIMATEDataSet
            // 
            this.BD_VIDEO_SYSTEM_ULTIMATEDataSet.DataSetName = "BD_VIDEO_SYSTEM_ULTIMATEDataSet";
            this.BD_VIDEO_SYSTEM_ULTIMATEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelHistFilme";
            reportDataSource1.Value = this.RelatoriosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Video_System_Ultimate.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(402, 325);
            this.reportViewer1.TabIndex = 0;
            // 
            // RelatoriosTableAdapter
            // 
            this.RelatoriosTableAdapter.ClearBeforeFill = true;
            // 
            // RelHistFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 325);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelHistFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Histórico de Filmes";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelHistFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelatoriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_VIDEO_SYSTEM_ULTIMATEDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RelatoriosBindingSource;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSet BD_VIDEO_SYSTEM_ULTIMATEDataSet;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.RelatoriosTableAdapter RelatoriosTableAdapter;
    }
}