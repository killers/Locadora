namespace Video_System_Ultimate
{
    partial class Frm_CadEstado
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
            System.Windows.Forms.Label iDESTADOLabel;
            System.Windows.Forms.Label nOMEESTADOLabel;
            System.Windows.Forms.Label uFESTADOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadEstado));
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSet();
            this.eSTADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTADOTableAdapter = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.ESTADOTableAdapter();
            this.tableAdapterManager = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager();
            this.eSTADOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eSTADOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDESTADOTextBox = new System.Windows.Forms.TextBox();
            this.nOMEESTADOTextBox = new System.Windows.Forms.TextBox();
            this.uFESTADOTextBox = new System.Windows.Forms.TextBox();
            iDESTADOLabel = new System.Windows.Forms.Label();
            nOMEESTADOLabel = new System.Windows.Forms.Label();
            uFESTADOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingNavigator)).BeginInit();
            this.eSTADOBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDESTADOLabel
            // 
            iDESTADOLabel.AutoSize = true;
            iDESTADOLabel.Location = new System.Drawing.Point(94, 65);
            iDESTADOLabel.Name = "iDESTADOLabel";
            iDESTADOLabel.Size = new System.Drawing.Size(43, 13);
            iDESTADOLabel.TabIndex = 1;
            iDESTADOLabel.Text = "Código:";
            // 
            // nOMEESTADOLabel
            // 
            nOMEESTADOLabel.AutoSize = true;
            nOMEESTADOLabel.Location = new System.Drawing.Point(63, 94);
            nOMEESTADOLabel.Name = "nOMEESTADOLabel";
            nOMEESTADOLabel.Size = new System.Drawing.Size(74, 13);
            nOMEESTADOLabel.TabIndex = 3;
            nOMEESTADOLabel.Text = "Nome Estado:";
            // 
            // uFESTADOLabel
            // 
            uFESTADOLabel.AutoSize = true;
            uFESTADOLabel.Location = new System.Drawing.Point(113, 120);
            uFESTADOLabel.Name = "uFESTADOLabel";
            uFESTADOLabel.Size = new System.Drawing.Size(24, 13);
            uFESTADOLabel.TabIndex = 5;
            uFESTADOLabel.Text = "UF:";
            // 
            // bD_VIDEO_SYSTEM_ULTIMATEDataSet
            // 
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.DataSetName = "BD_VIDEO_SYSTEM_ULTIMATEDataSet";
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eSTADOBindingSource
            // 
            this.eSTADOBindingSource.DataMember = "ESTADO";
            this.eSTADOBindingSource.DataSource = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet;
            // 
            // eSTADOTableAdapter
            // 
            this.eSTADOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CIDADETableAdapter = null;
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
            // eSTADOBindingNavigator
            // 
            this.eSTADOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eSTADOBindingNavigator.BindingSource = this.eSTADOBindingSource;
            this.eSTADOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eSTADOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eSTADOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eSTADOBindingNavigatorSaveItem});
            this.eSTADOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eSTADOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eSTADOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eSTADOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eSTADOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eSTADOBindingNavigator.Name = "eSTADOBindingNavigator";
            this.eSTADOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eSTADOBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.eSTADOBindingNavigator.TabIndex = 0;
            this.eSTADOBindingNavigator.Text = "bindingNavigator1";
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
            // eSTADOBindingNavigatorSaveItem
            // 
            this.eSTADOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eSTADOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eSTADOBindingNavigatorSaveItem.Image")));
            this.eSTADOBindingNavigatorSaveItem.Name = "eSTADOBindingNavigatorSaveItem";
            this.eSTADOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eSTADOBindingNavigatorSaveItem.Text = "Save Data";
            this.eSTADOBindingNavigatorSaveItem.Click += new System.EventHandler(this.eSTADOBindingNavigatorSaveItem_Click);
            // 
            // iDESTADOTextBox
            // 
            this.iDESTADOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eSTADOBindingSource, "IDESTADO", true));
            this.iDESTADOTextBox.Location = new System.Drawing.Point(143, 65);
            this.iDESTADOTextBox.Name = "iDESTADOTextBox";
            this.iDESTADOTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDESTADOTextBox.TabIndex = 2;
            // 
            // nOMEESTADOTextBox
            // 
            this.nOMEESTADOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eSTADOBindingSource, "NOMEESTADO", true));
            this.nOMEESTADOTextBox.Location = new System.Drawing.Point(143, 91);
            this.nOMEESTADOTextBox.Name = "nOMEESTADOTextBox";
            this.nOMEESTADOTextBox.Size = new System.Drawing.Size(100, 20);
            this.nOMEESTADOTextBox.TabIndex = 4;
            // 
            // uFESTADOTextBox
            // 
            this.uFESTADOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eSTADOBindingSource, "UFESTADO", true));
            this.uFESTADOTextBox.Location = new System.Drawing.Point(143, 117);
            this.uFESTADOTextBox.Name = "uFESTADOTextBox";
            this.uFESTADOTextBox.Size = new System.Drawing.Size(100, 20);
            this.uFESTADOTextBox.TabIndex = 6;
            // 
            // Frm_CadEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(iDESTADOLabel);
            this.Controls.Add(this.iDESTADOTextBox);
            this.Controls.Add(nOMEESTADOLabel);
            this.Controls.Add(this.nOMEESTADOTextBox);
            this.Controls.Add(uFESTADOLabel);
            this.Controls.Add(this.uFESTADOTextBox);
            this.Controls.Add(this.eSTADOBindingNavigator);
            this.Name = "Frm_CadEstado";
            this.Text = "Cadastro de Estado";
            this.Load += new System.EventHandler(this.Frm_CadEstado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingNavigator)).EndInit();
            this.eSTADOBindingNavigator.ResumeLayout(false);
            this.eSTADOBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_VIDEO_SYSTEM_ULTIMATEDataSet bD_VIDEO_SYSTEM_ULTIMATEDataSet;
        private System.Windows.Forms.BindingSource eSTADOBindingSource;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.ESTADOTableAdapter eSTADOTableAdapter;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eSTADOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eSTADOBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDESTADOTextBox;
        private System.Windows.Forms.TextBox nOMEESTADOTextBox;
        private System.Windows.Forms.TextBox uFESTADOTextBox;
    }
}