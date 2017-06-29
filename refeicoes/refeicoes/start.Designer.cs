namespace refeicoes
{
    partial class start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.comPort_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connect_BTN = new System.Windows.Forms.Button();
            this.Timer_LBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.clear_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // comPort_ComboBox
            // 
            this.comPort_ComboBox.FormattingEnabled = true;
            this.comPort_ComboBox.Location = new System.Drawing.Point(22, 33);
            this.comPort_ComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comPort_ComboBox.Name = "comPort_ComboBox";
            this.comPort_ComboBox.Size = new System.Drawing.Size(114, 21);
            this.comPort_ComboBox.TabIndex = 0;
            this.comPort_ComboBox.SelectedIndexChanged += new System.EventHandler(this.comPort_ComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // connect_BTN
            // 
            this.connect_BTN.Location = new System.Drawing.Point(145, 33);
            this.connect_BTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connect_BTN.Name = "connect_BTN";
            this.connect_BTN.Size = new System.Drawing.Size(95, 21);
            this.connect_BTN.TabIndex = 2;
            this.connect_BTN.Text = "Conectar";
            this.connect_BTN.UseVisualStyleBackColor = true;
            this.connect_BTN.Click += new System.EventHandler(this.connect_BTN_Click);
            // 
            // Timer_LBL
            // 
            this.Timer_LBL.AutoSize = true;
            this.Timer_LBL.Location = new System.Drawing.Point(161, 299);
            this.Timer_LBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Timer_LBL.Name = "Timer_LBL";
            this.Timer_LBL.Size = new System.Drawing.Size(56, 13);
            this.Timer_LBL.TabIndex = 3;
            this.Timer_LBL.Text = "Timer:OFF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "INPUT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 94);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(138, 218);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // clear_BTN
            // 
            this.clear_BTN.Location = new System.Drawing.Point(164, 94);
            this.clear_BTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clear_BTN.Name = "clear_BTN";
            this.clear_BTN.Size = new System.Drawing.Size(70, 28);
            this.clear_BTN.TabIndex = 6;
            this.clear_BTN.Text = "Limpar";
            this.clear_BTN.UseVisualStyleBackColor = true;
            this.clear_BTN.Click += new System.EventHandler(this.clear_BTN_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(261, 329);
            this.Controls.Add(this.clear_BTN);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Timer_LBL);
            this.Controls.Add(this.connect_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comPort_ComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "start";
            this.Text = "Conectar";
            this.Load += new System.EventHandler(this.start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.ComboBox comPort_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connect_BTN;
        private System.Windows.Forms.Label Timer_LBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button clear_BTN;
    }
}