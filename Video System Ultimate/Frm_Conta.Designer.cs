namespace Video_System_Ultimate
{
    partial class Frm_Conta
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
            System.Windows.Forms.Label idContaLabel;
            System.Windows.Forms.Label vALORPAGOLabel;
            System.Windows.Forms.Label vALORDEVIDOLabel;
            System.Windows.Forms.Label idLocacaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Conta));
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSet();
            this.contasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasTableAdapter = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.ContasTableAdapter();
            this.tableAdapterManager = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager();
            this.idContaTextBox = new System.Windows.Forms.TextBox();
            this.vALORPAGOTextBox = new System.Windows.Forms.TextBox();
            this.vALORDEVIDOTextBox = new System.Windows.Forms.TextBox();
            this.idLocacaoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FC_IMG6 = new System.Windows.Forms.PictureBox();
            idContaLabel = new System.Windows.Forms.Label();
            vALORPAGOLabel = new System.Windows.Forms.Label();
            vALORDEVIDOLabel = new System.Windows.Forms.Label();
            idLocacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FC_IMG6)).BeginInit();
            this.SuspendLayout();
            // 
            // idContaLabel
            // 
            idContaLabel.AutoSize = true;
            idContaLabel.Location = new System.Drawing.Point(163, 25);
            idContaLabel.Name = "idContaLabel";
            idContaLabel.Size = new System.Drawing.Size(52, 13);
            idContaLabel.TabIndex = 1;
            idContaLabel.Text = "ID Conta:";
            idContaLabel.Visible = false;
            // 
            // vALORPAGOLabel
            // 
            vALORPAGOLabel.AutoSize = true;
            vALORPAGOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vALORPAGOLabel.Location = new System.Drawing.Point(18, 108);
            vALORPAGOLabel.Name = "vALORPAGOLabel";
            vALORPAGOLabel.Size = new System.Drawing.Size(138, 20);
            vALORPAGOLabel.TabIndex = 3;
            vALORPAGOLabel.Text = "VALOR PAGO ....:";
            // 
            // vALORDEVIDOLabel
            // 
            vALORDEVIDOLabel.AutoSize = true;
            vALORDEVIDOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vALORDEVIDOLabel.Location = new System.Drawing.Point(18, 139);
            vALORDEVIDOLabel.Name = "vALORDEVIDOLabel";
            vALORDEVIDOLabel.Size = new System.Drawing.Size(139, 20);
            vALORDEVIDOLabel.TabIndex = 5;
            vALORDEVIDOLabel.Text = "VALOR DEVIDO :";
            // 
            // idLocacaoLabel
            // 
            idLocacaoLabel.AutoSize = true;
            idLocacaoLabel.Location = new System.Drawing.Point(150, 51);
            idLocacaoLabel.Name = "idLocacaoLabel";
            idLocacaoLabel.Size = new System.Drawing.Size(66, 13);
            idLocacaoLabel.TabIndex = 7;
            idLocacaoLabel.Text = "ID Locacao:";
            idLocacaoLabel.Visible = false;
            // 
            // bD_VIDEO_SYSTEM_ULTIMATEDataSet
            // 
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.DataSetName = "BD_VIDEO_SYSTEM_ULTIMATEDataSet";
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contasBindingSource
            // 
            this.contasBindingSource.DataMember = "Contas";
            this.contasBindingSource.DataSource = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet;
            // 
            // contasTableAdapter
            // 
            this.contasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CIDADETableAdapter = null;
            this.tableAdapterManager.ContasTableAdapter = this.contasTableAdapter;
            this.tableAdapterManager.ESTADOTableAdapter = null;
            this.tableAdapterManager.FILMETableAdapter = null;
            this.tableAdapterManager.GENEROTableAdapter = null;
            this.tableAdapterManager.ITEMLOCACAOTableAdapter = null;
            this.tableAdapterManager.LOCACAOTableAdapter = null;
            this.tableAdapterManager.PRECOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // idContaTextBox
            // 
            this.idContaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idContaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "IdConta", true));
            this.idContaTextBox.Location = new System.Drawing.Point(219, 22);
            this.idContaTextBox.Name = "idContaTextBox";
            this.idContaTextBox.ReadOnly = true;
            this.idContaTextBox.Size = new System.Drawing.Size(40, 20);
            this.idContaTextBox.TabIndex = 2;
            this.idContaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idContaTextBox.Visible = false;
            // 
            // vALORPAGOTextBox
            // 
            this.vALORPAGOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "VALORPAGO", true));
            this.vALORPAGOTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vALORPAGOTextBox.Location = new System.Drawing.Point(159, 106);
            this.vALORPAGOTextBox.Name = "vALORPAGOTextBox";
            this.vALORPAGOTextBox.Size = new System.Drawing.Size(100, 25);
            this.vALORPAGOTextBox.TabIndex = 4;
            this.vALORPAGOTextBox.Enter += new System.EventHandler(this.vALORPAGOTextBox_Enter);
            this.vALORPAGOTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vALORPAGOTextBox_KeyPress);
            // 
            // vALORDEVIDOTextBox
            // 
            this.vALORDEVIDOTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.vALORDEVIDOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "VALORDEVIDO", true));
            this.vALORDEVIDOTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vALORDEVIDOTextBox.Location = new System.Drawing.Point(159, 137);
            this.vALORDEVIDOTextBox.Name = "vALORDEVIDOTextBox";
            this.vALORDEVIDOTextBox.ReadOnly = true;
            this.vALORDEVIDOTextBox.Size = new System.Drawing.Size(100, 25);
            this.vALORDEVIDOTextBox.TabIndex = 6;
            // 
            // idLocacaoTextBox
            // 
            this.idLocacaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idLocacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "IdLocacao", true));
            this.idLocacaoTextBox.Location = new System.Drawing.Point(219, 48);
            this.idLocacaoTextBox.Name = "idLocacaoTextBox";
            this.idLocacaoTextBox.ReadOnly = true;
            this.idLocacaoTextBox.Size = new System.Drawing.Size(40, 20);
            this.idLocacaoTextBox.TabIndex = 8;
            this.idLocacaoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idLocacaoTextBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FC_IMG6
            // 
            this.FC_IMG6.Image = ((System.Drawing.Image)(resources.GetObject("FC_IMG6.Image")));
            this.FC_IMG6.Location = new System.Drawing.Point(34, 12);
            this.FC_IMG6.Name = "FC_IMG6";
            this.FC_IMG6.Size = new System.Drawing.Size(84, 79);
            this.FC_IMG6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FC_IMG6.TabIndex = 11;
            this.FC_IMG6.TabStop = false;
            // 
            // Frm_Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(274, 246);
            this.Controls.Add(this.FC_IMG6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(idContaLabel);
            this.Controls.Add(this.idContaTextBox);
            this.Controls.Add(vALORPAGOLabel);
            this.Controls.Add(this.vALORPAGOTextBox);
            this.Controls.Add(vALORDEVIDOLabel);
            this.Controls.Add(this.vALORDEVIDOTextBox);
            this.Controls.Add(idLocacaoLabel);
            this.Controls.Add(this.idLocacaoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Conta";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Conta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FC_IMG6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_VIDEO_SYSTEM_ULTIMATEDataSet bD_VIDEO_SYSTEM_ULTIMATEDataSet;
        private System.Windows.Forms.BindingSource contasBindingSource;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.ContasTableAdapter contasTableAdapter;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idContaTextBox;
        private System.Windows.Forms.TextBox idLocacaoTextBox;
        public System.Windows.Forms.TextBox vALORPAGOTextBox;
        public System.Windows.Forms.TextBox vALORDEVIDOTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox FC_IMG6;
    }
}