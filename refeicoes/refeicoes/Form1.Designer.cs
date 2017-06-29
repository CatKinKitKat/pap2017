namespace refeicoes
{
    partial class Form1
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
            System.Windows.Forms.Label rfidLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label nifLabel;
            System.Windows.Forms.Label saldoLabel;
            System.Windows.Forms.Label contatoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contatoTextBox = new System.Windows.Forms.TextBox();
            this.utentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registossaidasDataSet = new refeicoes.registossaidasDataSet();
            this.saldoTextBox = new System.Windows.Forms.TextBox();
            this.nifTextBox = new System.Windows.Forms.TextBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.rfidNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.utentesTableAdapter = new refeicoes.registossaidasDataSetTableAdapters.utentesTableAdapter();
            this.tableAdapterManager = new refeicoes.registossaidasDataSetTableAdapters.TableAdapterManager();
            this.utentesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.utentesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fKreservasrfid25869641BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fkutentesreservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservasTableAdapter = new refeicoes.registossaidasDataSetTableAdapters.reservasTableAdapter();
            this.idrefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataregistoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datarefeicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            rfidLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            nifLabel = new System.Windows.Forms.Label();
            saldoLabel = new System.Windows.Forms.Label();
            contatoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registossaidasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfidNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utentesBindingNavigator)).BeginInit();
            this.utentesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKreservasrfid25869641BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkutentesreservasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rfidLabel
            // 
            rfidLabel.AutoSize = true;
            rfidLabel.Location = new System.Drawing.Point(72, 65);
            rfidLabel.Name = "rfidLabel";
            rfidLabel.Size = new System.Drawing.Size(44, 25);
            rfidLabel.TabIndex = 0;
            rfidLabel.Text = "rfid:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(49, 104);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(67, 25);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "nome:";
            // 
            // nifLabel
            // 
            nifLabel.AutoSize = true;
            nifLabel.Location = new System.Drawing.Point(72, 139);
            nifLabel.Name = "nifLabel";
            nifLabel.Size = new System.Drawing.Size(38, 25);
            nifLabel.TabIndex = 6;
            nifLabel.Text = "nif:";
            // 
            // saldoLabel
            // 
            saldoLabel.AutoSize = true;
            saldoLabel.Location = new System.Drawing.Point(51, 179);
            saldoLabel.Name = "saldoLabel";
            saldoLabel.Size = new System.Drawing.Size(65, 25);
            saldoLabel.TabIndex = 8;
            saldoLabel.Text = "saldo:";
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.Location = new System.Drawing.Point(28, 221);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(82, 25);
            contatoLabel.TabIndex = 10;
            contatoLabel.Text = "contato:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(contatoLabel);
            this.groupBox1.Controls.Add(this.contatoTextBox);
            this.groupBox1.Controls.Add(saldoLabel);
            this.groupBox1.Controls.Add(this.saldoTextBox);
            this.groupBox1.Controls.Add(nifLabel);
            this.groupBox1.Controls.Add(this.nifTextBox);
            this.groupBox1.Controls.Add(this.pic);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(rfidLabel);
            this.groupBox1.Controls.Add(this.rfidNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(82, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1393, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 53);
            this.button1.TabIndex = 12;
            this.button1.Text = "Foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utentesBindingSource, "contato", true));
            this.contatoTextBox.Location = new System.Drawing.Point(122, 217);
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.Size = new System.Drawing.Size(292, 29);
            this.contatoTextBox.TabIndex = 11;
            // 
            // utentesBindingSource
            // 
            this.utentesBindingSource.DataMember = "utentes";
            this.utentesBindingSource.DataSource = this.registossaidasDataSet;
            // 
            // registossaidasDataSet
            // 
            this.registossaidasDataSet.DataSetName = "registossaidasDataSet";
            this.registossaidasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saldoTextBox
            // 
            this.saldoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utentesBindingSource, "saldo", true));
            this.saldoTextBox.Location = new System.Drawing.Point(122, 174);
            this.saldoTextBox.Name = "saldoTextBox";
            this.saldoTextBox.Size = new System.Drawing.Size(292, 29);
            this.saldoTextBox.TabIndex = 9;
            // 
            // nifTextBox
            // 
            this.nifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utentesBindingSource, "nif", true));
            this.nifTextBox.Location = new System.Drawing.Point(122, 135);
            this.nifTextBox.Name = "nifTextBox";
            this.nifTextBox.Size = new System.Drawing.Size(292, 29);
            this.nifTextBox.TabIndex = 7;
            // 
            // pic
            // 
            this.pic.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.utentesBindingSource, "foto", true));
            this.pic.Location = new System.Drawing.Point(455, 28);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(209, 218);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 5;
            this.pic.TabStop = false;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utentesBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(122, 100);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(292, 29);
            this.nomeTextBox.TabIndex = 3;
            // 
            // rfidNumericUpDown
            // 
            this.rfidNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.utentesBindingSource, "rfid", true));
            this.rfidNumericUpDown.Location = new System.Drawing.Point(122, 65);
            this.rfidNumericUpDown.Name = "rfidNumericUpDown";
            this.rfidNumericUpDown.Size = new System.Drawing.Size(120, 29);
            this.rfidNumericUpDown.TabIndex = 1;
            // 
            // utentesTableAdapter
            // 
            this.utentesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.reservasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = refeicoes.registossaidasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utentesTableAdapter = this.utentesTableAdapter;
            // 
            // utentesBindingNavigator
            // 
            this.utentesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.utentesBindingNavigator.BindingSource = this.utentesBindingSource;
            this.utentesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.utentesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.utentesBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.utentesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.utentesBindingNavigatorSaveItem});
            this.utentesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.utentesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.utentesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.utentesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.utentesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.utentesBindingNavigator.Name = "utentesBindingNavigator";
            this.utentesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.utentesBindingNavigator.Size = new System.Drawing.Size(1737, 35);
            this.utentesBindingNavigator.TabIndex = 1;
            this.utentesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(61, 32);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 35);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // utentesBindingNavigatorSaveItem
            // 
            this.utentesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.utentesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("utentesBindingNavigatorSaveItem.Image")));
            this.utentesBindingNavigatorSaveItem.Name = "utentesBindingNavigatorSaveItem";
            this.utentesBindingNavigatorSaveItem.Size = new System.Drawing.Size(32, 32);
            this.utentesBindingNavigatorSaveItem.Text = "Save Data";
            this.utentesBindingNavigatorSaveItem.Click += new System.EventHandler(this.utentesBindingNavigatorSaveItem_Click);
            // 
            // fKreservasrfid25869641BindingSource
            // 
            this.fKreservasrfid25869641BindingSource.DataMember = "FK__reservas__rfid__25869641";
            this.fKreservasrfid25869641BindingSource.DataSource = this.utentesBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrefDataGridViewTextBoxColumn,
            this.rfidDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.dataregistoDataGridViewTextBoxColumn,
            this.datarefeicaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fkutentesreservasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(84, 400);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1391, 398);
            this.dataGridView1.TabIndex = 2;
            // 
            // fkutentesreservasBindingSource
            // 
            this.fkutentesreservasBindingSource.DataMember = "fkutentesreservas";
            this.fkutentesreservasBindingSource.DataSource = this.utentesBindingSource;
            // 
            // reservasTableAdapter
            // 
            this.reservasTableAdapter.ClearBeforeFill = true;
            // 
            // idrefDataGridViewTextBoxColumn
            // 
            this.idrefDataGridViewTextBoxColumn.DataPropertyName = "idref";
            this.idrefDataGridViewTextBoxColumn.HeaderText = "idref";
            this.idrefDataGridViewTextBoxColumn.Name = "idrefDataGridViewTextBoxColumn";
            this.idrefDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rfidDataGridViewTextBoxColumn
            // 
            this.rfidDataGridViewTextBoxColumn.DataPropertyName = "rfid";
            this.rfidDataGridViewTextBoxColumn.HeaderText = "rfid";
            this.rfidDataGridViewTextBoxColumn.Name = "rfidDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // dataregistoDataGridViewTextBoxColumn
            // 
            this.dataregistoDataGridViewTextBoxColumn.DataPropertyName = "dataregisto";
            this.dataregistoDataGridViewTextBoxColumn.HeaderText = "dataregisto";
            this.dataregistoDataGridViewTextBoxColumn.Name = "dataregistoDataGridViewTextBoxColumn";
            // 
            // datarefeicaoDataGridViewTextBoxColumn
            // 
            this.datarefeicaoDataGridViewTextBoxColumn.DataPropertyName = "datarefeicao";
            this.datarefeicaoDataGridViewTextBoxColumn.HeaderText = "datarefeicao";
            this.datarefeicaoDataGridViewTextBoxColumn.Name = "datarefeicaoDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1737, 1028);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.utentesBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registossaidasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfidNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utentesBindingNavigator)).EndInit();
            this.utentesBindingNavigator.ResumeLayout(false);
            this.utentesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKreservasrfid25869641BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkutentesreservasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private registossaidasDataSet registossaidasDataSet;
        private System.Windows.Forms.BindingSource utentesBindingSource;
        private registossaidasDataSetTableAdapters.utentesTableAdapter utentesTableAdapter;
        private registossaidasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator utentesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton utentesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contatoTextBox;
        private System.Windows.Forms.TextBox saldoTextBox;
        private System.Windows.Forms.TextBox nifTextBox;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.NumericUpDown rfidNumericUpDown;
        private System.Windows.Forms.BindingSource fKreservasrfid25869641BindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fkutentesreservasBindingSource;
        private registossaidasDataSetTableAdapters.reservasTableAdapter reservasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataregistoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datarefeicaoDataGridViewTextBoxColumn;
    }
}