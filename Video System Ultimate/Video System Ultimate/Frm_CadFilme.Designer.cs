namespace Video_System_Ultimate
{
    partial class Frm_CadFilme
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
            System.Windows.Forms.Label iDFILMELabel;
            System.Windows.Forms.Label iDGENEROLabel;
            System.Windows.Forms.Label tITULOLabel;
            System.Windows.Forms.Label sUBTITULOLabel;
            System.Windows.Forms.Label aNOPRODUCAOLabel;
            System.Windows.Forms.Label pRODUTORALabel;
            System.Windows.Forms.Label dURACAOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadFilme));
            this.bD_VIDEO_SYSTEM_ULTIMATEDataSet = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSet();
            this.fILMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fILMETableAdapter = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.FILMETableAdapter();
            this.tableAdapterManager = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager();
            this.gENEROTableAdapter = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.GENEROTableAdapter();
            this.fILMEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fILMEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDFILMETextBox = new System.Windows.Forms.TextBox();
            this.tITULOTextBox = new System.Windows.Forms.TextBox();
            this.sUBTITULOTextBox = new System.Windows.Forms.TextBox();
            this.aNOPRODUCAODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pRODUTORATextBox = new System.Windows.Forms.TextBox();
            this.dURACAOTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gENEROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTipo = new System.Windows.Forms.Label();
            this.pRECOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRECOTableAdapter = new Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.PRECOTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.FCF_IMG5 = new System.Windows.Forms.PictureBox();
            this.FCF_lblInfo2 = new System.Windows.Forms.Label();
            this.FCF_btSalvar = new System.Windows.Forms.Button();
            this.FCF_btLimpar = new System.Windows.Forms.Button();
            this.FCF_btCancelar = new System.Windows.Forms.Button();
            iDFILMELabel = new System.Windows.Forms.Label();
            iDGENEROLabel = new System.Windows.Forms.Label();
            tITULOLabel = new System.Windows.Forms.Label();
            sUBTITULOLabel = new System.Windows.Forms.Label();
            aNOPRODUCAOLabel = new System.Windows.Forms.Label();
            pRODUTORALabel = new System.Windows.Forms.Label();
            dURACAOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILMEBindingNavigator)).BeginInit();
            this.fILMEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gENEROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRECOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCF_IMG5)).BeginInit();
            this.SuspendLayout();
            // 
            // iDFILMELabel
            // 
            iDFILMELabel.AutoSize = true;
            iDFILMELabel.Location = new System.Drawing.Point(20, 60);
            iDFILMELabel.Name = "iDFILMELabel";
            iDFILMELabel.Size = new System.Drawing.Size(50, 13);
            iDFILMELabel.TabIndex = 1;
            iDFILMELabel.Text = "Código* :";
            // 
            // iDGENEROLabel
            // 
            iDGENEROLabel.AutoSize = true;
            iDGENEROLabel.Location = new System.Drawing.Point(142, 210);
            iDGENEROLabel.Name = "iDGENEROLabel";
            iDGENEROLabel.Size = new System.Drawing.Size(49, 13);
            iDGENEROLabel.TabIndex = 3;
            iDGENEROLabel.Text = "Gênero*:";
            // 
            // tITULOLabel
            // 
            tITULOLabel.AutoSize = true;
            tITULOLabel.Location = new System.Drawing.Point(20, 90);
            tITULOLabel.Name = "tITULOLabel";
            tITULOLabel.Size = new System.Drawing.Size(42, 13);
            tITULOLabel.TabIndex = 5;
            tITULOLabel.Text = "Título*:";
            // 
            // sUBTITULOLabel
            // 
            sUBTITULOLabel.AutoSize = true;
            sUBTITULOLabel.Location = new System.Drawing.Point(20, 120);
            sUBTITULOLabel.Name = "sUBTITULOLabel";
            sUBTITULOLabel.Size = new System.Drawing.Size(51, 13);
            sUBTITULOLabel.TabIndex = 7;
            sUBTITULOLabel.Text = "Subtitulo:";
            // 
            // aNOPRODUCAOLabel
            // 
            aNOPRODUCAOLabel.AutoSize = true;
            aNOPRODUCAOLabel.Location = new System.Drawing.Point(20, 150);
            aNOPRODUCAOLabel.Name = "aNOPRODUCAOLabel";
            aNOPRODUCAOLabel.Size = new System.Drawing.Size(104, 13);
            aNOPRODUCAOLabel.TabIndex = 9;
            aNOPRODUCAOLabel.Text = "Data da Produção* :";
            // 
            // pRODUTORALabel
            // 
            pRODUTORALabel.AutoSize = true;
            pRODUTORALabel.Location = new System.Drawing.Point(20, 180);
            pRODUTORALabel.Name = "pRODUTORALabel";
            pRODUTORALabel.Size = new System.Drawing.Size(60, 13);
            pRODUTORALabel.TabIndex = 11;
            pRODUTORALabel.Text = "Produtora*:";
            // 
            // dURACAOLabel
            // 
            dURACAOLabel.AutoSize = true;
            dURACAOLabel.Location = new System.Drawing.Point(20, 210);
            dURACAOLabel.Name = "dURACAOLabel";
            dURACAOLabel.Size = new System.Drawing.Size(51, 13);
            dURACAOLabel.TabIndex = 13;
            dURACAOLabel.Text = "Duração:";
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
            this.tableAdapterManager.GENEROTableAdapter = this.gENEROTableAdapter;
            this.tableAdapterManager.ITEMLOCACAOTableAdapter = null;
            this.tableAdapterManager.LOCACAOTableAdapter = null;
            this.tableAdapterManager.PRECOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Video_System_Ultimate.BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // gENEROTableAdapter
            // 
            this.gENEROTableAdapter.ClearBeforeFill = true;
            // 
            // fILMEBindingNavigator
            // 
            this.fILMEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fILMEBindingNavigator.BindingSource = this.fILMEBindingSource;
            this.fILMEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fILMEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fILMEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fILMEBindingNavigatorSaveItem});
            this.fILMEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fILMEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fILMEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fILMEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fILMEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fILMEBindingNavigator.Name = "fILMEBindingNavigator";
            this.fILMEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fILMEBindingNavigator.Size = new System.Drawing.Size(490, 25);
            this.fILMEBindingNavigator.TabIndex = 0;
            this.fILMEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Novo Registro";
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
            this.bindingNavigatorDeleteItem.Text = "Excluir Registro";
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
            // fILMEBindingNavigatorSaveItem
            // 
            this.fILMEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fILMEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fILMEBindingNavigatorSaveItem.Image")));
            this.fILMEBindingNavigatorSaveItem.Name = "fILMEBindingNavigatorSaveItem";
            this.fILMEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fILMEBindingNavigatorSaveItem.Text = "Salvar Registro";
            this.fILMEBindingNavigatorSaveItem.Click += new System.EventHandler(this.fILMEBindingNavigatorSaveItem_Click);
            // 
            // iDFILMETextBox
            // 
            this.iDFILMETextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.iDFILMETextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iDFILMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fILMEBindingSource, "IDFILME", true));
            this.iDFILMETextBox.Location = new System.Drawing.Point(86, 57);
            this.iDFILMETextBox.Name = "iDFILMETextBox";
            this.iDFILMETextBox.ReadOnly = true;
            this.iDFILMETextBox.Size = new System.Drawing.Size(40, 20);
            this.iDFILMETextBox.TabIndex = 1;
            this.iDFILMETextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tITULOTextBox
            // 
            this.tITULOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fILMEBindingSource, "TITULO", true));
            this.tITULOTextBox.Location = new System.Drawing.Point(86, 87);
            this.tITULOTextBox.Name = "tITULOTextBox";
            this.tITULOTextBox.Size = new System.Drawing.Size(300, 20);
            this.tITULOTextBox.TabIndex = 2;
            // 
            // sUBTITULOTextBox
            // 
            this.sUBTITULOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fILMEBindingSource, "SUBTITULO", true));
            this.sUBTITULOTextBox.Location = new System.Drawing.Point(86, 117);
            this.sUBTITULOTextBox.Name = "sUBTITULOTextBox";
            this.sUBTITULOTextBox.Size = new System.Drawing.Size(300, 20);
            this.sUBTITULOTextBox.TabIndex = 3;
            // 
            // aNOPRODUCAODateTimePicker
            // 
            this.aNOPRODUCAODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fILMEBindingSource, "ANOPRODUCAO", true));
            this.aNOPRODUCAODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aNOPRODUCAODateTimePicker.Location = new System.Drawing.Point(130, 146);
            this.aNOPRODUCAODateTimePicker.Name = "aNOPRODUCAODateTimePicker";
            this.aNOPRODUCAODateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.aNOPRODUCAODateTimePicker.TabIndex = 4;
            // 
            // pRODUTORATextBox
            // 
            this.pRODUTORATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fILMEBindingSource, "PRODUTORA", true));
            this.pRODUTORATextBox.Location = new System.Drawing.Point(86, 177);
            this.pRODUTORATextBox.Name = "pRODUTORATextBox";
            this.pRODUTORATextBox.Size = new System.Drawing.Size(300, 20);
            this.pRODUTORATextBox.TabIndex = 5;
            // 
            // dURACAOTextBox
            // 
            this.dURACAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fILMEBindingSource, "DURACAO", true));
            this.dURACAOTextBox.Location = new System.Drawing.Point(86, 206);
            this.dURACAOTextBox.Name = "dURACAOTextBox";
            this.dURACAOTextBox.Size = new System.Drawing.Size(50, 20);
            this.dURACAOTextBox.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fILMEBindingSource, "IDGENERO", true));
            this.comboBox1.DataSource = this.gENEROBindingSource;
            this.comboBox1.DisplayMember = "DESCRICAO";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(192, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "IDGENERO";
            // 
            // gENEROBindingSource
            // 
            this.gENEROBindingSource.DataMember = "GENERO";
            this.gENEROBindingSource.DataSource = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(20, 240);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 16;
            this.lblTipo.Text = "Tipo:";
            // 
            // pRECOBindingSource
            // 
            this.pRECOBindingSource.DataMember = "PRECO";
            this.pRECOBindingSource.DataSource = this.bD_VIDEO_SYSTEM_ULTIMATEDataSet;
            // 
            // pRECOTableAdapter
            // 
            this.pRECOTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fILMEBindingSource, "IdPreco", true));
            this.comboBox2.DataSource = this.pRECOBindingSource;
            this.comboBox2.DisplayMember = "Descricao";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(86, 237);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "Idpreco";
            // 
            // FCF_IMG5
            // 
            this.FCF_IMG5.Location = new System.Drawing.Point(411, -1);
            this.FCF_IMG5.Name = "FCF_IMG5";
            this.FCF_IMG5.Size = new System.Drawing.Size(80, 340);
            this.FCF_IMG5.TabIndex = 18;
            this.FCF_IMG5.TabStop = false;
            // 
            // FCF_lblInfo2
            // 
            this.FCF_lblInfo2.AutoSize = true;
            this.FCF_lblInfo2.Location = new System.Drawing.Point(249, 266);
            this.FCF_lblInfo2.Name = "FCF_lblInfo2";
            this.FCF_lblInfo2.Size = new System.Drawing.Size(123, 13);
            this.FCF_lblInfo2.TabIndex = 19;
            this.FCF_lblInfo2.Text = "( * ) Campos Obrigatórios";
            // 
            // FCF_btSalvar
            // 
            this.FCF_btSalvar.Location = new System.Drawing.Point(92, 296);
            this.FCF_btSalvar.Name = "FCF_btSalvar";
            this.FCF_btSalvar.Size = new System.Drawing.Size(80, 30);
            this.FCF_btSalvar.TabIndex = 9;
            this.FCF_btSalvar.Text = "&Salvar";
            this.FCF_btSalvar.UseVisualStyleBackColor = true;
            this.FCF_btSalvar.Click += new System.EventHandler(this.FCF_btSalvar_Click);
            // 
            // FCF_btLimpar
            // 
            this.FCF_btLimpar.Location = new System.Drawing.Point(192, 296);
            this.FCF_btLimpar.Name = "FCF_btLimpar";
            this.FCF_btLimpar.Size = new System.Drawing.Size(80, 30);
            this.FCF_btLimpar.TabIndex = 10;
            this.FCF_btLimpar.Text = "&Limpar";
            this.FCF_btLimpar.UseVisualStyleBackColor = true;
            this.FCF_btLimpar.Click += new System.EventHandler(this.FCF_btLimpar_Click);
            // 
            // FCF_btCancelar
            // 
            this.FCF_btCancelar.Location = new System.Drawing.Point(292, 296);
            this.FCF_btCancelar.Name = "FCF_btCancelar";
            this.FCF_btCancelar.Size = new System.Drawing.Size(80, 30);
            this.FCF_btCancelar.TabIndex = 11;
            this.FCF_btCancelar.Text = "&Cancelar";
            this.FCF_btCancelar.UseVisualStyleBackColor = true;
            this.FCF_btCancelar.Click += new System.EventHandler(this.FCF_btCancelar_Click);
            // 
            // Frm_CadFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(490, 338);
            this.Controls.Add(this.FCF_btCancelar);
            this.Controls.Add(this.FCF_btLimpar);
            this.Controls.Add(this.FCF_btSalvar);
            this.Controls.Add(this.FCF_lblInfo2);
            this.Controls.Add(this.FCF_IMG5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(iDFILMELabel);
            this.Controls.Add(this.iDFILMETextBox);
            this.Controls.Add(iDGENEROLabel);
            this.Controls.Add(tITULOLabel);
            this.Controls.Add(this.tITULOTextBox);
            this.Controls.Add(sUBTITULOLabel);
            this.Controls.Add(this.sUBTITULOTextBox);
            this.Controls.Add(aNOPRODUCAOLabel);
            this.Controls.Add(this.aNOPRODUCAODateTimePicker);
            this.Controls.Add(pRODUTORALabel);
            this.Controls.Add(this.pRODUTORATextBox);
            this.Controls.Add(dURACAOLabel);
            this.Controls.Add(this.dURACAOTextBox);
            this.Controls.Add(this.fILMEBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CadFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Filmes";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_CadFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_VIDEO_SYSTEM_ULTIMATEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fILMEBindingNavigator)).EndInit();
            this.fILMEBindingNavigator.ResumeLayout(false);
            this.fILMEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gENEROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRECOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCF_IMG5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_VIDEO_SYSTEM_ULTIMATEDataSet bD_VIDEO_SYSTEM_ULTIMATEDataSet;
        private System.Windows.Forms.BindingSource fILMEBindingSource;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.FILMETableAdapter fILMETableAdapter;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fILMEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fILMEBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDFILMETextBox;
        private System.Windows.Forms.TextBox tITULOTextBox;
        private System.Windows.Forms.TextBox sUBTITULOTextBox;
        private System.Windows.Forms.DateTimePicker aNOPRODUCAODateTimePicker;
        private System.Windows.Forms.TextBox pRODUTORATextBox;
        private System.Windows.Forms.TextBox dURACAOTextBox;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.GENEROTableAdapter gENEROTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource gENEROBindingSource;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.BindingSource pRECOBindingSource;
        private BD_VIDEO_SYSTEM_ULTIMATEDataSetTableAdapters.PRECOTableAdapter pRECOTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox FCF_IMG5;
        private System.Windows.Forms.Label FCF_lblInfo2;
        private System.Windows.Forms.Button FCF_btSalvar;
        private System.Windows.Forms.Button FCF_btLimpar;
        private System.Windows.Forms.Button FCF_btCancelar;
    }
}