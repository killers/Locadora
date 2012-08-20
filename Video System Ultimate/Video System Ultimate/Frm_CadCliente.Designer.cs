namespace Video_System_Ultimate
{
    partial class Frm_CadCliente
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
            System.Windows.Forms.Label cPFUSUARIOLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label dATANASCIMENTOLabel;
            System.Windows.Forms.Label lAGRADOUROLabel;
            System.Windows.Forms.Label nUMEROLabel;
            System.Windows.Forms.Label bAIRROLabel;
            System.Windows.Forms.Label iDESTADOLabel;
            System.Windows.Forms.Label iDCIDADELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadCliente));
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSet();
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOTableAdapter = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.USUARIOTableAdapter();
            this.tableAdapterManager = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager();
            this.cIDADETableAdapter = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.CIDADETableAdapter();
            this.eSTADOTableAdapter = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.ESTADOTableAdapter();
            this.uSUARIOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.uSUARIOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.dATANASCIMENTODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lAGRADOUROTextBox = new System.Windows.Forms.TextBox();
            this.nUMEROTextBox = new System.Windows.Forms.TextBox();
            this.bAIRROTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.eSTADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cIDADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FCC_IMG4 = new System.Windows.Forms.PictureBox();
            this.FCC_btCancelar = new System.Windows.Forms.Button();
            this.FCC_btSalvar = new System.Windows.Forms.Button();
            this.FCC_btLimpar = new System.Windows.Forms.Button();
            this.FCC_lblInfo = new System.Windows.Forms.Label();
            this.cPFUSUARIOMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            cPFUSUARIOLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            dATANASCIMENTOLabel = new System.Windows.Forms.Label();
            lAGRADOUROLabel = new System.Windows.Forms.Label();
            nUMEROLabel = new System.Windows.Forms.Label();
            bAIRROLabel = new System.Windows.Forms.Label();
            iDESTADOLabel = new System.Windows.Forms.Label();
            iDCIDADELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingNavigator)).BeginInit();
            this.uSUARIOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCC_IMG4)).BeginInit();
            this.SuspendLayout();
            // 
            // cPFUSUARIOLabel
            // 
            cPFUSUARIOLabel.AutoSize = true;
            cPFUSUARIOLabel.Location = new System.Drawing.Point(20, 60);
            cPFUSUARIOLabel.Name = "cPFUSUARIOLabel";
            cPFUSUARIOLabel.Size = new System.Drawing.Size(106, 13);
            cPFUSUARIOLabel.TabIndex = 1;
            cPFUSUARIOLabel.Text = "CPF* .......................:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(20, 90);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(107, 13);
            nOMELabel.TabIndex = 3;
            nOMELabel.Text = "Nome Completo* .....:";
            // 
            // dATANASCIMENTOLabel
            // 
            dATANASCIMENTOLabel.AutoSize = true;
            dATANASCIMENTOLabel.Location = new System.Drawing.Point(20, 120);
            dATANASCIMENTOLabel.Name = "dATANASCIMENTOLabel";
            dATANASCIMENTOLabel.Size = new System.Drawing.Size(107, 13);
            dATANASCIMENTOLabel.TabIndex = 5;
            dATANASCIMENTOLabel.Text = "Data de Nascimento:";
            // 
            // lAGRADOUROLabel
            // 
            lAGRADOUROLabel.AutoSize = true;
            lAGRADOUROLabel.Location = new System.Drawing.Point(20, 150);
            lAGRADOUROLabel.Name = "lAGRADOUROLabel";
            lAGRADOUROLabel.Size = new System.Drawing.Size(68, 13);
            lAGRADOUROLabel.TabIndex = 7;
            lAGRADOUROLabel.Text = "Logradouro*:";
            // 
            // nUMEROLabel
            // 
            nUMEROLabel.AutoSize = true;
            nUMEROLabel.Location = new System.Drawing.Point(20, 180);
            nUMEROLabel.Name = "nUMEROLabel";
            nUMEROLabel.Size = new System.Drawing.Size(66, 13);
            nUMEROLabel.TabIndex = 9;
            nUMEROLabel.Text = "Número* ....:";
            // 
            // bAIRROLabel
            // 
            bAIRROLabel.AutoSize = true;
            bAIRROLabel.Location = new System.Drawing.Point(177, 180);
            bAIRROLabel.Name = "bAIRROLabel";
            bAIRROLabel.Size = new System.Drawing.Size(41, 13);
            bAIRROLabel.TabIndex = 11;
            bAIRROLabel.Text = "Bairro*:";
            // 
            // iDESTADOLabel
            // 
            iDESTADOLabel.AutoSize = true;
            iDESTADOLabel.Location = new System.Drawing.Point(20, 210);
            iDESTADOLabel.Name = "iDESTADOLabel";
            iDESTADOLabel.Size = new System.Drawing.Size(62, 13);
            iDESTADOLabel.TabIndex = 13;
            iDESTADOLabel.Text = "Estado* ....:";
            // 
            // iDCIDADELabel
            // 
            iDCIDADELabel.AutoSize = true;
            iDCIDADELabel.Location = new System.Drawing.Point(156, 210);
            iDCIDADELabel.Name = "iDCIDADELabel";
            iDCIDADELabel.Size = new System.Drawing.Size(50, 13);
            iDCIDADELabel.TabIndex = 15;
            iDCIDADELabel.Text = "Cidade* :";
            // 
            // bD_VIDEO_SYSTEM_ULTIMATEDataSet
            // 
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.DataSetName = "BD_VIDEO_SYSTEM_ULTIMATEDataSet";
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.USUARIOTableAdapter = this.uSUARIOTableAdapter;
            // 
            // cIDADETableAdapter
            // 
            this.cIDADETableAdapter.ClearBeforeFill = true;
            // 
            // eSTADOTableAdapter
            // 
            this.eSTADOTableAdapter.ClearBeforeFill = true;
            // 
            // uSUARIOBindingNavigator
            // 
            this.uSUARIOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uSUARIOBindingNavigator.BindingSource = this.uSUARIOBindingSource;
            this.uSUARIOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uSUARIOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uSUARIOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uSUARIOBindingNavigatorSaveItem});
            this.uSUARIOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uSUARIOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uSUARIOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uSUARIOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uSUARIOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uSUARIOBindingNavigator.Name = "uSUARIOBindingNavigator";
            this.uSUARIOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uSUARIOBindingNavigator.Size = new System.Drawing.Size(515, 25);
            this.uSUARIOBindingNavigator.TabIndex = 0;
            this.uSUARIOBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // uSUARIOBindingNavigatorSaveItem
            // 
            this.uSUARIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uSUARIOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uSUARIOBindingNavigatorSaveItem.Image")));
            this.uSUARIOBindingNavigatorSaveItem.Name = "uSUARIOBindingNavigatorSaveItem";
            this.uSUARIOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uSUARIOBindingNavigatorSaveItem.Text = "Save Data";
            this.uSUARIOBindingNavigatorSaveItem.Click += new System.EventHandler(this.uSUARIOBindingNavigatorSaveItem_Click);
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOBindingSource, "NOME", true));
            this.nOMETextBox.Location = new System.Drawing.Point(133, 87);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(250, 20);
            this.nOMETextBox.TabIndex = 2;
            // 
            // dATANASCIMENTODateTimePicker
            // 
            this.dATANASCIMENTODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.uSUARIOBindingSource, "DATANASCIMENTO", true));
            this.dATANASCIMENTODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dATANASCIMENTODateTimePicker.Location = new System.Drawing.Point(133, 118);
            this.dATANASCIMENTODateTimePicker.Name = "dATANASCIMENTODateTimePicker";
            this.dATANASCIMENTODateTimePicker.Size = new System.Drawing.Size(80, 20);
            this.dATANASCIMENTODateTimePicker.TabIndex = 3;
            // 
            // lAGRADOUROTextBox
            // 
            this.lAGRADOUROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOBindingSource, "LAGRADOURO", true));
            this.lAGRADOUROTextBox.Location = new System.Drawing.Point(93, 146);
            this.lAGRADOUROTextBox.Name = "lAGRADOUROTextBox";
            this.lAGRADOUROTextBox.Size = new System.Drawing.Size(290, 20);
            this.lAGRADOUROTextBox.TabIndex = 4;
            // 
            // nUMEROTextBox
            // 
            this.nUMEROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOBindingSource, "NUMERO", true));
            this.nUMEROTextBox.Location = new System.Drawing.Point(93, 177);
            this.nUMEROTextBox.Name = "nUMEROTextBox";
            this.nUMEROTextBox.Size = new System.Drawing.Size(78, 20);
            this.nUMEROTextBox.TabIndex = 5;
            // 
            // bAIRROTextBox
            // 
            this.bAIRROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOBindingSource, "BAIRRO", true));
            this.bAIRROTextBox.Location = new System.Drawing.Point(223, 177);
            this.bAIRROTextBox.Name = "bAIRROTextBox";
            this.bAIRROTextBox.Size = new System.Drawing.Size(160, 20);
            this.bAIRROTextBox.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uSUARIOBindingSource, "IDESTADO", true));
            this.comboBox1.DataSource = this.eSTADOBindingSource;
            this.comboBox1.DisplayMember = "UFESTADO";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(50, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "IDESTADO";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // eSTADOBindingSource
            // 
            this.eSTADOBindingSource.DataMember = "ESTADO";
            this.eSTADOBindingSource.DataSource = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uSUARIOBindingSource, "IDCIDADE", true));
            this.comboBox2.DataSource = this.cIDADEBindingSource;
            this.comboBox2.DisplayMember = "NOMECIDADE";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(208, 207);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(175, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "IDCIDADE";
            // 
            // cIDADEBindingSource
            // 
            this.cIDADEBindingSource.DataMember = "CIDADE";
            this.cIDADEBindingSource.DataSource = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet;
            // 
            // FCC_IMG4
            // 
            this.FCC_IMG4.Location = new System.Drawing.Point(410, 0);
            this.FCC_IMG4.Name = "FCC_IMG4";
            this.FCC_IMG4.Size = new System.Drawing.Size(80, 318);
            this.FCC_IMG4.TabIndex = 19;
            this.FCC_IMG4.TabStop = false;
            // 
            // FCC_btCancelar
            // 
            this.FCC_btCancelar.Location = new System.Drawing.Point(303, 271);
            this.FCC_btCancelar.Name = "FCC_btCancelar";
            this.FCC_btCancelar.Size = new System.Drawing.Size(80, 30);
            this.FCC_btCancelar.TabIndex = 11;
            this.FCC_btCancelar.Text = "&Cancelar";
            this.FCC_btCancelar.UseVisualStyleBackColor = true;
            this.FCC_btCancelar.Click += new System.EventHandler(this.FCC_btCancelar_Click);
            // 
            // FCC_btSalvar
            // 
            this.FCC_btSalvar.Location = new System.Drawing.Point(103, 271);
            this.FCC_btSalvar.Name = "FCC_btSalvar";
            this.FCC_btSalvar.Size = new System.Drawing.Size(80, 30);
            this.FCC_btSalvar.TabIndex = 9;
            this.FCC_btSalvar.Text = "&Salvar";
            this.FCC_btSalvar.UseVisualStyleBackColor = true;
            this.FCC_btSalvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // FCC_btLimpar
            // 
            this.FCC_btLimpar.Location = new System.Drawing.Point(203, 271);
            this.FCC_btLimpar.Name = "FCC_btLimpar";
            this.FCC_btLimpar.Size = new System.Drawing.Size(80, 30);
            this.FCC_btLimpar.TabIndex = 10;
            this.FCC_btLimpar.Text = "&Limpar";
            this.FCC_btLimpar.UseVisualStyleBackColor = true;
            this.FCC_btLimpar.Click += new System.EventHandler(this.FCC_btLimpar_Click);
            // 
            // FCC_lblInfo
            // 
            this.FCC_lblInfo.AutoSize = true;
            this.FCC_lblInfo.Location = new System.Drawing.Point(260, 243);
            this.FCC_lblInfo.Name = "FCC_lblInfo";
            this.FCC_lblInfo.Size = new System.Drawing.Size(123, 13);
            this.FCC_lblInfo.TabIndex = 20;
            this.FCC_lblInfo.Text = "( * ) Campos Obrigatórios";
            // 
            // cPFUSUARIOMaskedTextBox
            // 
            this.cPFUSUARIOMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOBindingSource, "CPFUSUARIO", true));
            this.cPFUSUARIOMaskedTextBox.Location = new System.Drawing.Point(133, 61);
            this.cPFUSUARIOMaskedTextBox.Mask = "000.000.000-00";
            this.cPFUSUARIOMaskedTextBox.Name = "cPFUSUARIOMaskedTextBox";
            this.cPFUSUARIOMaskedTextBox.Size = new System.Drawing.Size(115, 20);
            this.cPFUSUARIOMaskedTextBox.TabIndex = 23;
            this.cPFUSUARIOMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Frm_CadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(515, 338);
            this.Controls.Add(this.cPFUSUARIOMaskedTextBox);
            this.Controls.Add(this.FCC_lblInfo);
            this.Controls.Add(this.FCC_btLimpar);
            this.Controls.Add(this.FCC_btSalvar);
            this.Controls.Add(this.FCC_btCancelar);
            this.Controls.Add(this.FCC_IMG4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(cPFUSUARIOLabel);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.nOMETextBox);
            this.Controls.Add(dATANASCIMENTOLabel);
            this.Controls.Add(this.dATANASCIMENTODateTimePicker);
            this.Controls.Add(lAGRADOUROLabel);
            this.Controls.Add(this.lAGRADOUROTextBox);
            this.Controls.Add(nUMEROLabel);
            this.Controls.Add(this.nUMEROTextBox);
            this.Controls.Add(bAIRROLabel);
            this.Controls.Add(this.bAIRROTextBox);
            this.Controls.Add(iDESTADOLabel);
            this.Controls.Add(iDCIDADELabel);
            this.Controls.Add(this.uSUARIOBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_CadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_CadCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingNavigator)).EndInit();
            this.uSUARIOBindingNavigator.ResumeLayout(false);
            this.uSUARIOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCC_IMG4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_VIDEO_SYSTEM_ULTIMATEDataSet bD_VIDEO_SYSTEM_ULTIMATEDataSet;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uSUARIOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uSUARIOBindingNavigatorSaveItem;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.ESTADOTableAdapter eSTADOTableAdapter;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.DateTimePicker dATANASCIMENTODateTimePicker;
        private System.Windows.Forms.TextBox lAGRADOUROTextBox;
        private System.Windows.Forms.TextBox nUMEROTextBox;
        private System.Windows.Forms.TextBox bAIRROTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource eSTADOBindingSource;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.CIDADETableAdapter cIDADETableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource cIDADEBindingSource;
        private System.Windows.Forms.PictureBox FCC_IMG4;
        private System.Windows.Forms.Button FCC_btCancelar;
        private System.Windows.Forms.Button FCC_btSalvar;
        private System.Windows.Forms.Button FCC_btLimpar;
        private System.Windows.Forms.Label FCC_lblInfo;
        private System.Windows.Forms.MaskedTextBox cPFUSUARIOMaskedTextBox;

    }
}