namespace Video_System_Ultimate
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.FL_IMG2 = new System.Windows.Forms.PictureBox();
            this.FL_lblUsuario = new System.Windows.Forms.Label();
            this.FL_lblSenha = new System.Windows.Forms.Label();
            this.FL_txtUsuario = new System.Windows.Forms.TextBox();
            this.FL_txtSenha = new System.Windows.Forms.TextBox();
            this.FL_btEntrar = new System.Windows.Forms.Button();
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSet();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERSTableAdapter = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.USERSTableAdapter();
            this.tableAdapterManager = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.FL_IMG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FL_IMG2
            // 
            this.FL_IMG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FL_IMG2.Image = ((System.Drawing.Image)(resources.GetObject("FL_IMG2.Image")));
            this.FL_IMG2.Location = new System.Drawing.Point(0, 0);
            this.FL_IMG2.Name = "FL_IMG2";
            this.FL_IMG2.Size = new System.Drawing.Size(451, 299);
            this.FL_IMG2.TabIndex = 0;
            this.FL_IMG2.TabStop = false;
            // 
            // FL_lblUsuario
            // 
            this.FL_lblUsuario.AutoSize = true;
            this.FL_lblUsuario.BackColor = System.Drawing.Color.White;
            this.FL_lblUsuario.Location = new System.Drawing.Point(15, 235);
            this.FL_lblUsuario.Name = "FL_lblUsuario";
            this.FL_lblUsuario.Size = new System.Drawing.Size(70, 16);
            this.FL_lblUsuario.TabIndex = 1;
            this.FL_lblUsuario.Text = "Usuário :";
            // 
            // FL_lblSenha
            // 
            this.FL_lblSenha.AutoSize = true;
            this.FL_lblSenha.BackColor = System.Drawing.Color.White;
            this.FL_lblSenha.Location = new System.Drawing.Point(15, 260);
            this.FL_lblSenha.Name = "FL_lblSenha";
            this.FL_lblSenha.Size = new System.Drawing.Size(68, 16);
            this.FL_lblSenha.TabIndex = 2;
            this.FL_lblSenha.Text = "Senha ..:";
            // 
            // FL_txtUsuario
            // 
            this.FL_txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FL_txtUsuario.Location = new System.Drawing.Point(85, 232);
            this.FL_txtUsuario.Name = "FL_txtUsuario";
            this.FL_txtUsuario.Size = new System.Drawing.Size(350, 22);
            this.FL_txtUsuario.TabIndex = 1;
            // 
            // FL_txtSenha
            // 
            this.FL_txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FL_txtSenha.Location = new System.Drawing.Point(85, 257);
            this.FL_txtSenha.Name = "FL_txtSenha";
            this.FL_txtSenha.Size = new System.Drawing.Size(230, 22);
            this.FL_txtSenha.TabIndex = 4;
            this.FL_txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FL_txtSenha_KeyPress);
            // 
            // FL_btEntrar
            // 
            this.FL_btEntrar.Location = new System.Drawing.Point(335, 257);
            this.FL_btEntrar.Name = "FL_btEntrar";
            this.FL_btEntrar.Size = new System.Drawing.Size(100, 22);
            this.FL_btEntrar.TabIndex = 5;
            this.FL_btEntrar.Text = "&Entrar";
            this.FL_btEntrar.UseVisualStyleBackColor = true;
            this.FL_btEntrar.Click += new System.EventHandler(this.FL_btEntrar_Click);
            // 
            // bD_VIDEO_SYSTEM_ULTIMATEDataSet
            // 
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.DataSetName = "BD_VIDEO_SYSTEM_ULTIMATEDataSet";
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CIDADETableAdapter = null;
            this.tableAdapterManager.ContasTableAdapter = null;
            this.tableAdapterManager.ESTADOTableAdapter = null;
            this.tableAdapterManager.FILMETableAdapter = null;
            this.tableAdapterManager.GENEROTableAdapter = null;
            this.tableAdapterManager.ITEMLOCACAOTableAdapter = null;
            this.tableAdapterManager.LOCACAOTableAdapter = null;
            this.tableAdapterManager.PRECOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = this.uSERSTableAdapter;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 299);
            this.Controls.Add(this.FL_btEntrar);
            this.Controls.Add(this.FL_txtSenha);
            this.Controls.Add(this.FL_txtUsuario);
            this.Controls.Add(this.FL_lblSenha);
            this.Controls.Add(this.FL_lblUsuario);
            this.Controls.Add(this.FL_IMG2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video System Ultimate";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FL_IMG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FL_IMG2;
        private System.Windows.Forms.Label FL_lblUsuario;
        private System.Windows.Forms.Label FL_lblSenha;
        private System.Windows.Forms.TextBox FL_txtUsuario;
        private System.Windows.Forms.TextBox FL_txtSenha;
        private System.Windows.Forms.Button FL_btEntrar;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSet bD_VIDEO_SYSTEM_ULTIMATEDataSet;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager tableAdapterManager;

    }
}