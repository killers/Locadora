namespace Video_System_Ultimate
{
    partial class Frm_PesquisaFilme
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
            System.Windows.Forms.Label dESCRICAOLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSet();
            this.fILMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fILMETableAdapter = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.FILMETableAdapter();
            this.tableAdapterManager = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager();
            this.fILMEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENEROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gENEROTableAdapter = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.GENEROTableAdapter();
            this.iDGENEROComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            dESCRICAOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILMEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENEROBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dESCRICAOLabel
            // 
            dESCRICAOLabel.AutoSize = true;
            dESCRICAOLabel.Location = new System.Drawing.Point(480, 26);
            dESCRICAOLabel.Name = "dESCRICAOLabel";
            dESCRICAOLabel.Size = new System.Drawing.Size(42, 13);
            dESCRICAOLabel.TabIndex = 3;
            dESCRICAOLabel.Text = "Gênero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Nome do Filme que deseja Procurar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bD_VIDEO_SYSTEM_ULTIMATEDataSet
            // 
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.DataSetName = "BD_VIDEO_SYSTEM_ULTIMATEDataSet";
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fILMEBindingSource
            // 
            this.fILMEBindingSource.DataMember = "FILME";
            this.fILMEBindingSource.DataSource = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet;
            // 
            // fILMETableAdapter
            // 
            this.fILMETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CIDADETableAdapter = null;
            this.tableAdapterManager.ContasTableAdapter = null;
            this.tableAdapterManager.ESTADOTableAdapter = null;
            this.tableAdapterManager.FILMETableAdapter = this.fILMETableAdapter;
            this.tableAdapterManager.GENEROTableAdapter = null;
            this.tableAdapterManager.ITEMLOCACAOTableAdapter = null;
            this.tableAdapterManager.LOCACAOTableAdapter = null;
            this.tableAdapterManager.PRECOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // fILMEDataGridView
            // 
            this.fILMEDataGridView.AutoGenerateColumns = false;
            this.fILMEDataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.fILMEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fILMEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.fILMEDataGridView.DataSource = this.fILMEBindingSource;
            this.fILMEDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fILMEDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fILMEDataGridView.Location = new System.Drawing.Point(0, 90);
            this.fILMEDataGridView.MultiSelect = false;
            this.fILMEDataGridView.Name = "fILMEDataGridView";
            this.fILMEDataGridView.ReadOnly = true;
            this.fILMEDataGridView.RowHeadersVisible = false;
            this.fILMEDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fILMEDataGridView.Size = new System.Drawing.Size(703, 284);
            this.fILMEDataGridView.TabIndex = 3;
            this.fILMEDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fILMEDataGridView_CellContentClick);
            this.fILMEDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fILMEDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDFILME";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código do Filme";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDGENERO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TITULO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SUBTITULO";
            this.dataGridViewTextBoxColumn4.HeaderText = "Subtitulo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ANOPRODUCAO";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data da produção";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PRODUTORA";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produtora";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DURACAO";
            this.dataGridViewTextBoxColumn7.HeaderText = "Duração";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // gENEROBindingSource
            // 
            this.gENEROBindingSource.DataMember = "GENERO";
            this.gENEROBindingSource.DataSource = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet;
            // 
            // gENEROTableAdapter
            // 
            this.gENEROTableAdapter.ClearBeforeFill = true;
            // 
            // iDGENEROComboBox
            // 
            this.iDGENEROComboBox.DataSource = this.gENEROBindingSource;
            this.iDGENEROComboBox.DisplayMember = "DESCRICAO";
            this.iDGENEROComboBox.FormattingEnabled = true;
            this.iDGENEROComboBox.Location = new System.Drawing.Point(483, 41);
            this.iDGENEROComboBox.Name = "iDGENEROComboBox";
            this.iDGENEROComboBox.Size = new System.Drawing.Size(168, 21);
            this.iDGENEROComboBox.TabIndex = 5;
            this.iDGENEROComboBox.ValueMember = "IDGENERO";
            this.iDGENEROComboBox.SelectedIndexChanged += new System.EventHandler(this.iDGENEROComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "Limpa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_PesquisaFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iDGENEROComboBox);
            this.Controls.Add(dESCRICAOLabel);
            this.Controls.Add(this.fILMEDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_PesquisaFilme";
            this.Text = "Frm_PesquisaFilme";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_PesquisaFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILMEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENEROBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSet bD_VIDEO_SYSTEM_ULTIMATEDataSet;
        private System.Windows.Forms.BindingSource fILMEBindingSource;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.FILMETableAdapter fILMETableAdapter;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView fILMEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource gENEROBindingSource;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.GENEROTableAdapter gENEROTableAdapter;
        private System.Windows.Forms.ComboBox iDGENEROComboBox;
        private System.Windows.Forms.Button button1;
    }
}