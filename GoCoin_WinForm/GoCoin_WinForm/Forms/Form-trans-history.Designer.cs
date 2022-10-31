namespace GoCoin_WinForm.Forms
{
    partial class Form_transaction_history
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
            this.btnEditTrans = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateTrans = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.cbPocket = new System.Windows.Forms.ComboBox();
            this.lblPocketName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbOutcome = new System.Windows.Forms.RadioButton();
            this.rbIncome = new System.Windows.Forms.RadioButton();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteTrans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditTrans
            // 
            this.btnEditTrans.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEditTrans.FlatAppearance.BorderSize = 0;
            this.btnEditTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTrans.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnEditTrans.Location = new System.Drawing.Point(12, 367);
            this.btnEditTrans.Name = "btnEditTrans";
            this.btnEditTrans.Size = new System.Drawing.Size(96, 32);
            this.btnEditTrans.TabIndex = 13;
            this.btnEditTrans.Text = "Edit";
            this.btnEditTrans.UseVisualStyleBackColor = false;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddTransaction.FlatAppearance.BorderSize = 0;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnAddTransaction.Location = new System.Drawing.Point(12, 329);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(200, 32);
            this.btnAddTransaction.TabIndex = 12;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(580, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Outcome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(270, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Income :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(270, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(292, 400);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(580, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(292, 400);
            this.dataGridView2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(12, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Date:";
            // 
            // dtpDateTrans
            // 
            this.dtpDateTrans.Location = new System.Drawing.Point(12, 284);
            this.dtpDateTrans.Name = "dtpDateTrans";
            this.dtpDateTrans.Size = new System.Drawing.Size(200, 23);
            this.dtpDateTrans.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Amount:";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(12, 229);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(200, 23);
            this.tbAmount.TabIndex = 22;
            // 
            // cbPocket
            // 
            this.cbPocket.FormattingEnabled = true;
            this.cbPocket.Items.AddRange(new object[] {
            "Pocket 1 ",
            "Pocket 2",
            "Pocket 3"});
            this.cbPocket.Location = new System.Drawing.Point(12, 123);
            this.cbPocket.Name = "cbPocket";
            this.cbPocket.Size = new System.Drawing.Size(200, 23);
            this.cbPocket.TabIndex = 21;
            // 
            // lblPocketName
            // 
            this.lblPocketName.AutoSize = true;
            this.lblPocketName.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPocketName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblPocketName.Location = new System.Drawing.Point(12, 105);
            this.lblPocketName.Name = "lblPocketName";
            this.lblPocketName.Size = new System.Drawing.Size(51, 16);
            this.lblPocketName.TabIndex = 20;
            this.lblPocketName.Text = "Pocket:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Category:";
            // 
            // rbOutcome
            // 
            this.rbOutcome.AutoSize = true;
            this.rbOutcome.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbOutcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rbOutcome.Location = new System.Drawing.Point(137, 67);
            this.rbOutcome.Name = "rbOutcome";
            this.rbOutcome.Size = new System.Drawing.Size(82, 20);
            this.rbOutcome.TabIndex = 18;
            this.rbOutcome.TabStop = true;
            this.rbOutcome.Text = "Outcome";
            this.rbOutcome.UseVisualStyleBackColor = true;
            // 
            // rbIncome
            // 
            this.rbIncome.AutoSize = true;
            this.rbIncome.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rbIncome.Location = new System.Drawing.Point(12, 67);
            this.rbIncome.Name = "rbIncome";
            this.rbIncome.Size = new System.Drawing.Size(70, 20);
            this.rbIncome.TabIndex = 17;
            this.rbIncome.TabStop = true;
            this.rbIncome.Text = "Income";
            this.rbIncome.UseVisualStyleBackColor = true;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(12, 176);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(200, 23);
            this.tbCategory.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Transaction Type:";
            // 
            // btnDeleteTrans
            // 
            this.btnDeleteTrans.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteTrans.FlatAppearance.BorderSize = 0;
            this.btnDeleteTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTrans.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnDeleteTrans.Location = new System.Drawing.Point(116, 367);
            this.btnDeleteTrans.Name = "btnDeleteTrans";
            this.btnDeleteTrans.Size = new System.Drawing.Size(96, 32);
            this.btnDeleteTrans.TabIndex = 26;
            this.btnDeleteTrans.Text = "Delete";
            this.btnDeleteTrans.UseVisualStyleBackColor = false;
            // 
            // Form_transaction_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnDeleteTrans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDateTrans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.cbPocket);
            this.Controls.Add(this.lblPocketName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbOutcome);
            this.Controls.Add(this.rbIncome);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEditTrans);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form_transaction_history";
            this.Text = "Form_transaction_history";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnEditTrans;
        private Button btnAddTransaction;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView2;
        private Label label4;
        private DateTimePicker dtpDateTrans;
        private Label label3;
        private TextBox tbAmount;
        private ComboBox cbPocket;
        private Label lblPocketName;
        private Label label5;
        private RadioButton rbOutcome;
        private RadioButton rbIncome;
        private TextBox tbCategory;
        private Label label6;
        private Button btnDeleteTrans;
    }
}