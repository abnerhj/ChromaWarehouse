namespace ReturnInspection
{
    partial class fMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tSN = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SNNO = new System.Windows.Forms.Label();
            this.QCLot = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Mark = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SN_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tSN);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.SNNO);
            this.panel1.Controls.Add(this.QCLot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 94);
            this.panel1.TabIndex = 0;
            // 
            // tSN
            // 
            this.tSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tSN.Location = new System.Drawing.Point(191, 51);
            this.tSN.Name = "tSN";
            this.tSN.Size = new System.Drawing.Size(136, 25);
            this.tSN.TabIndex = 3;
            this.tSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tSN_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(136, 25);
            this.textBox1.TabIndex = 2;
            // 
            // SNNO
            // 
            this.SNNO.AutoSize = true;
            this.SNNO.Location = new System.Drawing.Point(41, 54);
            this.SNNO.Name = "SNNO";
            this.SNNO.Size = new System.Drawing.Size(23, 15);
            this.SNNO.TabIndex = 1;
            this.SNNO.Text = "SN";
            // 
            // QCLot
            // 
            this.QCLot.AutoSize = true;
            this.QCLot.Location = new System.Drawing.Point(41, 13);
            this.QCLot.Name = "QCLot";
            this.QCLot.Size = new System.Drawing.Size(23, 15);
            this.QCLot.TabIndex = 0;
            this.QCLot.Text = "QC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.Mark);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 160);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(552, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(339, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Allow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(116, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(757, 80);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Mark
            // 
            this.Mark.AutoSize = true;
            this.Mark.Location = new System.Drawing.Point(44, 22);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(55, 15);
            this.Mark.TabIndex = 0;
            this.Mark.Text = "Remark";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(928, 313);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN_NO,
            this.WONO,
            this.Material_No,
            this.qty,
            this.type});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(928, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // SN_NO
            // 
            this.SN_NO.HeaderText = "SNNO";
            this.SN_NO.Name = "SN_NO";
            this.SN_NO.ReadOnly = true;
            // 
            // WONO
            // 
            this.WONO.HeaderText = "WO";
            this.WONO.Name = "WONO";
            this.WONO.ReadOnly = true;
            // 
            // Material_No
            // 
            this.Material_No.HeaderText = "Material";
            this.Material_No.Name = "Material_No";
            this.Material_No.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "QTY";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "TYPE";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 567);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tSN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SNNO;
        private System.Windows.Forms.Label QCLot;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Mark;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn WONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}

