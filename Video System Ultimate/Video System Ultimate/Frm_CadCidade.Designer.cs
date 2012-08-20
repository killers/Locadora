namespace Video_System_Ultimate
{
    partial class Frm_CadCidade
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
            System.Windows.Forms.Label iDCIDADELabel;
            System.Windows.Forms.Label nOMECIDADELabel;
            System.Windows.Forms.Label cEPCIDADELabel;
            System.Windows.Forms.Label iDESTADOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadCidade));
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSet();
            this.cIDADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cIDADETableAdapter = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.CIDADETableAdapter();
            this.tableAdapterManager = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager();
            this.eSTADOTableAdapter = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.ESTADOTableAdapter();
            this.cIDADEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cIDADEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDCIDADETextBox = new System.Windows.Forms.TextBox();
            this.nOMECIDADETextBox = new System.Windows.Forms.TextBox();
            this.iDESTADOComboBox = new System.Windows.Forms.ComboBox();
            this.eSTADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cEPCIDADEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            iDCIDADELabel = new System.Windows.Forms.Label();
            nOMECIDADELabel = new System.Windows.Forms.Label();
            cEPCIDADELabel = new System.Windows.Forms.Label();
            iDESTADOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingNavigator)).BeginInit();
            this.cIDADEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDCIDADELabel
            // 
            iDCIDADELabel.AutoSize = true;
            iDCIDADELabel.Location = new System.Drawing.Point(70, 67);
            iDCIDADELabel.Name = "iDCIDADELabel";
            iDCIDADELabel.Size = new System.Drawing.Size(43, 13);
            iDCIDADELabel.TabIndex = 1;
            iDCIDADELabel.Text = "Código:";
            // 
            // nOMECIDADELabel
            // 
            nOMECIDADELabel.AutoSize = true;
            nOMECIDADELabel.Location = new System.Drawing.Point(24, 108);
            nOMECIDADELabel.Name = "nOMECIDADELabel";
            nOMECIDADELabel.Size = new System.Drawing.Size(89, 13);
            nOMECIDADELabel.TabIndex = 3;
            nOMECIDADELabel.Text = "Nome da Cidade:";
            // 
            // cEPCIDADELabel
            // 
            cEPCIDADELabel.AutoSize = true;
            cEPCIDADELabel.Location = new System.Drawing.Point(82, 151);
            cEPCIDADELabel.Name = "cEPCIDADELabel";
            cEPCIDADELabel.Size = new System.Drawing.Size(31, 13);
            cEPCIDADELabel.TabIndex = 5;
            cEPCIDADELabel.Text = "CEP:";
            // 
            // iDESTADOLabel
            // 
            iDESTADOLabel.AutoSize = true;
            iDESTADOLabel.Location = new System.Drawing.Point(89, 185);
            iDESTADOLabel.Name = "iDESTADOLabel";
            iDESTADOLabel.Size = new System.Drawing.Size(24, 13);
            iDESTADOLabel.TabIndex = 7;
            iDESTADOLabel.Text = "UF:";
            // 
            // bD_VIDEO_SYSTEM_ULTIMATEDataSet
            // 
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.DataSetName = "BD_VIDEO_SYSTEM_ULTIMATEDataSet";
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cIDADEBindingSource
            // 
            this.cIDADEBindingSource.DataMember = "CIDADE";
            this.cIDADEBindingSource.DataSource = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet;
            // 
            // cIDADETableAdapter
            // 
            this.cIDADETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CIDADETableAdapter = this.cIDADETableAdapter;
            this.tableAdapterManager.ContasTableAdapter = null;
            this.tableAdapterManager.ESTADOTableAdapter = this.eSTADOTableAdapter;
            this.tableAdapterManager.FILMETableAdapter = null;
            this.tableAdapterManager.GENEROTableAdapter = null;
            this.tableAdapterManager.ITEMLOCACAOTableAdapter = null;
            this.tableAdapterManager.LOCACAOTableAdapter = null;
            this.tableAdapterManager.PRECOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // eSTADOTableAdapter
            // 
            this.eSTADOTableAdapter.ClearBeforeFill = true;
            // 
            // cIDADEBindingNavigator
            // 
            this.cIDADEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cIDADEBindingNavigator.BindingSource = this.cIDADEBindingSource;
            this.cIDADEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cIDADEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cIDADEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cIDADEBindingNavigatorSaveItem});
            this.cIDADEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cIDADEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cIDADEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cIDADEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cIDADEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cIDADEBindingNavigator.Name = "cIDADEBindingNavigator";
            this.cIDADEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cIDADEBindingNavigator.Size = new System.Drawing.Size(398, 25);
            this.cIDADEBindingNavigator.TabIndex = 0;
            this.cIDADEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cIDADEBindingNavigatorSaveItem
            // 
            this.cIDADEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cIDADEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cIDADEBindingNavigatorSaveItem.Image")));
            this.cIDADEBindingNavigatorSaveItem.Name = "cIDADEBindingNavigatorSaveItem";
            this.cIDADEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cIDADEBindingNavigatorSaveItem.Text = "Save Data";
            this.cIDADEBindingNavigatorSaveItem.Click += new System.EventHandler(this.cIDADEBindingNavigatorSaveItem_Click_1);
            // 
            // iDCIDADETextBox
            // 
            this.iDCIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cIDADEBindingSource, "IDCIDADE", true));
            this.iDCIDADETextBox.Location = new System.Drawing.Point(119, 64);
            this.iDCIDADETextBox.Name = "iDCIDADETextBox";
            this.iDCIDADETextBox.Size = new System.Drawing.Size(52, 20);
            this.iDCIDADETextBox.TabIndex = 2;
            // 
            // nOMECIDADETextBox
            // 
            this.nOMECIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cIDADEBindingSource, "NOMECIDADE", true));
            this.nOMECIDADETextBox.Location = new System.Drawing.Point(119, 105);
            this.nOMECIDADETextBox.Name = "nOMECIDADETextBox";
            this.nOMECIDADETextBox.Size = new System.Drawing.Size(171, 20);
            this.nOMECIDADETextBox.TabIndex = 4;
            // 
            // iDESTADOComboBox
            // 
            this.iDESTADOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cIDADEBindingSource, "IDESTADO", true));
            this.iDESTADOComboBox.DataSource = this.eSTADOBindingSource;
            this.iDESTADOComboBox.DisplayMember = "UFESTADO";
            this.iDESTADOComboBox.FormattingEnabled = true;
            this.iDESTADOComboBox.Location = new System.Drawing.Point(119, 182);
            this.iDESTADOComboBox.Name = "iDESTADOComboBox";
            this.iDESTADOComboBox.Size = new System.Drawing.Size(59, 21);
            this.iDESTADOComboBox.TabIndex = 6;
            this.iDESTADOComboBox.ValueMember = "IDESTADO";
            // 
            // eSTADOBindingSource
            // 
            this.eSTADOBindingSource.DataMember = "ESTADO";
            this.eSTADOBindingSource.DataSource = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet;
            // 
            // cEPCIDADEMaskedTextBox
            // 
            this.cEPCIDADEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cIDADEBindingSource, "CEPCIDADE", true));
            this.cEPCIDADEMaskedTextBox.Location = new System.Drawing.Point(119, 148);
            this.cEPCIDADEMaskedTextBox.Mask = "00.000-000";
            this.cEPCIDADEMaskedTextBox.Name = "cEPCIDADEMaskedTextBox";
            this.cEPCIDADEMaskedTextBox.Size = new System.Drawing.Size(102, 20);
            this.cEPCIDADEMaskedTextBox.TabIndex = 5;
            // 
            // Frm_CadCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 270);
            this.Controls.Add(this.cEPCIDADEMaskedTextBox);
            this.Controls.Add(iDCIDADELabel);
            this.Controls.Add(this.iDCIDADETextBox);
            this.Controls.Add(nOMECIDADELabel);
            this.Controls.Add(this.nOMECIDADETextBox);
            this.Controls.Add(cEPCIDADELabel);
            this.Controls.Add(iDESTADOLabel);
            this.Controls.Add(this.iDESTADOComboBox);
            this.Controls.Add(this.cIDADEBindingNavigator);
            this.Name = "Frm_CadCidade";
            this.Text = "Formulario de Cadastro de Cidades";
            this.Load += new System.EventHandler(this.Frm_CadCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingNavigator)).EndInit();
            this.cIDADEBindingNavigator.ResumeLayout(false);
            this.cIDADEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_VIDEO_SYSTEM_ULTIMATEDataSet bD_VIDEO_SYSTEM_ULTIMATEDataSet;
        private System.Windows.Forms.BindingSource cIDADEBindingSource;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.CIDADETableAdapter cIDADETableAdapter;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cIDADEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cIDADEBindingNavigatorSaveItem;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.ESTADOTableAdapter eSTADOTableAdapter;
        private System.Windows.Forms.TextBox iDCIDADETextBox;
        private System.Windows.Forms.TextBox nOMECIDADETextBox;
        private System.Windows.Forms.ComboBox iDESTADOComboBox;
        private System.Windows.Forms.BindingSource eSTADOBindingSource;
        private System.Windows.Forms.MaskedTextBox cEPCIDADEMaskedTextBox;

    }
}