namespace refeicoes
{
    partial class reservas
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
            System.Windows.Forms.Label idrefLabel;
            System.Windows.Forms.Label rfidLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label dataregistoLabel;
            System.Windows.Forms.Label datarefeicaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservas));
            this.registossaidasDataSet = new refeicoes.registossaidasDataSet();
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservasTableAdapter = new refeicoes.registossaidasDataSetTableAdapters.reservasTableAdapter();
            this.tableAdapterManager = new refeicoes.registossaidasDataSetTableAdapters.TableAdapterManager();
            this.reservasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.reservasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idrefTextBox = new System.Windows.Forms.TextBox();
            this.rfidTextBox = new System.Windows.Forms.TextBox();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.dataregistoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datarefeicaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            idrefLabel = new System.Windows.Forms.Label();
            rfidLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            dataregistoLabel = new System.Windows.Forms.Label();
            datarefeicaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registossaidasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingNavigator)).BeginInit();
            this.reservasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idrefLabel
            // 
            idrefLabel.AutoSize = true;
            idrefLabel.Location = new System.Drawing.Point(71, 44);
            idrefLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idrefLabel.Name = "idrefLabel";
            idrefLabel.Size = new System.Drawing.Size(21, 13);
            idrefLabel.TabIndex = 1;
            idrefLabel.Text = "ID:";
            // 
            // rfidLabel
            // 
            rfidLabel.AutoSize = true;
            rfidLabel.Location = new System.Drawing.Point(51, 73);
            rfidLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            rfidLabel.Name = "rfidLabel";
            rfidLabel.Size = new System.Drawing.Size(42, 13);
            rfidLabel.TabIndex = 3;
            rfidLabel.Text = "Utente:";
            rfidLabel.Click += new System.EventHandler(this.rfidLabel_Click);
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(208, 40);
            tipoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(53, 13);
            tipoLabel.TabIndex = 5;
            tipoLabel.Text = "Refeição:";
            // 
            // dataregistoLabel
            // 
            dataregistoLabel.AutoSize = true;
            dataregistoLabel.Location = new System.Drawing.Point(183, 71);
            dataregistoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataregistoLabel.Name = "dataregistoLabel";
            dataregistoLabel.Size = new System.Drawing.Size(79, 13);
            dataregistoLabel.TabIndex = 7;
            dataregistoLabel.Text = "Reservado em:";
            // 
            // datarefeicaoLabel
            // 
            datarefeicaoLabel.AutoSize = true;
            datarefeicaoLabel.Location = new System.Drawing.Point(196, 99);
            datarefeicaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            datarefeicaoLabel.Name = "datarefeicaoLabel";
            datarefeicaoLabel.Size = new System.Drawing.Size(58, 13);
            datarefeicaoLabel.TabIndex = 9;
            datarefeicaoLabel.Text = "Para o dia:";
            // 
            // registossaidasDataSet
            // 
            this.registossaidasDataSet.DataSetName = "registossaidasDataSet";
            this.registossaidasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataMember = "reservas";
            this.reservasBindingSource.DataSource = this.registossaidasDataSet;
            // 
            // reservasTableAdapter
            // 
            this.reservasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.reservasTableAdapter = this.reservasTableAdapter;
            this.tableAdapterManager.UpdateOrder = refeicoes.registossaidasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utentesTableAdapter = null;
            // 
            // reservasBindingNavigator
            // 
            this.reservasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reservasBindingNavigator.BindingSource = this.reservasBindingSource;
            this.reservasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reservasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.reservasBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reservasBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.reservasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.reservasBindingNavigatorSaveItem});
            this.reservasBindingNavigator.Location = new System.Drawing.Point(0, 169);
            this.reservasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reservasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reservasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reservasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reservasBindingNavigator.Name = "reservasBindingNavigator";
            this.reservasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reservasBindingNavigator.Size = new System.Drawing.Size(446, 35);
            this.reservasBindingNavigator.TabIndex = 0;
            this.reservasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 32);
            this.bindingNavigatorCountItem.Text = "de {0}";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(29, 23);
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
            // reservasBindingNavigatorSaveItem
            // 
            this.reservasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reservasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("reservasBindingNavigatorSaveItem.Image")));
            this.reservasBindingNavigatorSaveItem.Name = "reservasBindingNavigatorSaveItem";
            this.reservasBindingNavigatorSaveItem.Size = new System.Drawing.Size(32, 32);
            this.reservasBindingNavigatorSaveItem.Text = "Save Data";
            this.reservasBindingNavigatorSaveItem.Click += new System.EventHandler(this.reservasBindingNavigatorSaveItem_Click);
            // 
            // idrefTextBox
            // 
            this.idrefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservasBindingSource, "idref", true));
            this.idrefTextBox.Location = new System.Drawing.Point(105, 44);
            this.idrefTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idrefTextBox.Name = "idrefTextBox";
            this.idrefTextBox.Size = new System.Drawing.Size(56, 20);
            this.idrefTextBox.TabIndex = 2;
            // 
            // rfidTextBox
            // 
            this.rfidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservasBindingSource, "rfid", true));
            this.rfidTextBox.Location = new System.Drawing.Point(105, 73);
            this.rfidTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rfidTextBox.Name = "rfidTextBox";
            this.rfidTextBox.Size = new System.Drawing.Size(56, 20);
            this.rfidTextBox.TabIndex = 4;
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservasBindingSource, "tipo", true));
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Items.AddRange(new object[] {
            "Almoço",
            "Jantar"});
            this.tipoComboBox.Location = new System.Drawing.Point(263, 39);
            this.tipoComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(113, 21);
            this.tipoComboBox.TabIndex = 6;
            // 
            // dataregistoDateTimePicker
            // 
            this.dataregistoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservasBindingSource, "dataregisto", true));
            this.dataregistoDateTimePicker.Location = new System.Drawing.Point(265, 71);
            this.dataregistoDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataregistoDateTimePicker.Name = "dataregistoDateTimePicker";
            this.dataregistoDateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.dataregistoDateTimePicker.TabIndex = 8;
            // 
            // datarefeicaoDateTimePicker
            // 
            this.datarefeicaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservasBindingSource, "datarefeicao", true));
            this.datarefeicaoDateTimePicker.Location = new System.Drawing.Point(263, 97);
            this.datarefeicaoDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datarefeicaoDateTimePicker.Name = "datarefeicaoDateTimePicker";
            this.datarefeicaoDateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.datarefeicaoDateTimePicker.TabIndex = 10;
            // 
            // reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(446, 204);
            this.Controls.Add(datarefeicaoLabel);
            this.Controls.Add(this.datarefeicaoDateTimePicker);
            this.Controls.Add(dataregistoLabel);
            this.Controls.Add(this.dataregistoDateTimePicker);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoComboBox);
            this.Controls.Add(rfidLabel);
            this.Controls.Add(this.rfidTextBox);
            this.Controls.Add(idrefLabel);
            this.Controls.Add(this.idrefTextBox);
            this.Controls.Add(this.reservasBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "reservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.reservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registossaidasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingNavigator)).EndInit();
            this.reservasBindingNavigator.ResumeLayout(false);
            this.reservasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private registossaidasDataSet registossaidasDataSet;
        private System.Windows.Forms.BindingSource reservasBindingSource;
        private registossaidasDataSetTableAdapters.reservasTableAdapter reservasTableAdapter;
        private registossaidasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator reservasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton reservasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idrefTextBox;
        private System.Windows.Forms.TextBox rfidTextBox;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.DateTimePicker dataregistoDateTimePicker;
        private System.Windows.Forms.DateTimePicker datarefeicaoDateTimePicker;
    }
}