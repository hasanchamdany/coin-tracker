namespace GoCoin_WinForm.Forms
{
    partial class Form_transaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.rbIncome = new System.Windows.Forms.RadioButton();
            this.rbOutcome = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPocketName = new System.Windows.Forms.Label();
            this.cbPocket = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.dtpDateTrans = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(56, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Type:";
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(56, 187);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(200, 23);
            this.tbCategory.TabIndex = 2;
            // 
            // rbIncome
            // 
            this.rbIncome.AutoSize = true;
            this.rbIncome.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rbIncome.Location = new System.Drawing.Point(56, 78);
            this.rbIncome.Name = "rbIncome";
            this.rbIncome.Size = new System.Drawing.Size(70, 20);
            this.rbIncome.TabIndex = 3;
            this.rbIncome.TabStop = true;
            this.rbIncome.Text = "Income";
            this.rbIncome.UseVisualStyleBackColor = true;
            // 
            // rbOutcome
            // 
            this.rbOutcome.AutoSize = true;
            this.rbOutcome.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbOutcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rbOutcome.Location = new System.Drawing.Point(181, 78);
            this.rbOutcome.Name = "rbOutcome";
            this.rbOutcome.Size = new System.Drawing.Size(82, 20);
            this.rbOutcome.TabIndex = 4;
            this.rbOutcome.TabStop = true;
            this.rbOutcome.Text = "Outcome";
            this.rbOutcome.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(56, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category:";
            // 
            // lblPocketName
            // 
            this.lblPocketName.AutoSize = true;
            this.lblPocketName.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPocketName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblPocketName.Location = new System.Drawing.Point(56, 116);
            this.lblPocketName.Name = "lblPocketName";
            this.lblPocketName.Size = new System.Drawing.Size(51, 16);
            this.lblPocketName.TabIndex = 7;
            this.lblPocketName.Text = "Pocket:";
            // 
            // cbPocket
            // 
            this.cbPocket.FormattingEnabled = true;
            this.cbPocket.Items.AddRange(new object[] {
            "Pocket 1 ",
            "Pocket 2",
            "Pocket 3"});
            this.cbPocket.Location = new System.Drawing.Point(56, 134);
            this.cbPocket.Name = "cbPocket";
            this.cbPocket.Size = new System.Drawing.Size(200, 23);
            this.cbPocket.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(56, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amount:";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(56, 240);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(200, 23);
            this.tbAmount.TabIndex = 9;
            // 
            // dtpDateTrans
            // 
            this.dtpDateTrans.Location = new System.Drawing.Point(56, 295);
            this.dtpDateTrans.Name = "dtpDateTrans";
            this.dtpDateTrans.Size = new System.Drawing.Size(200, 23);
            this.dtpDateTrans.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(56, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date:";
            // 
            // Form_transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDateTrans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.cbPocket);
            this.Controls.Add(this.lblPocketName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbOutcome);
            this.Controls.Add(this.rbIncome);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.label1);
            this.Name = "Form_transaction";
            this.Text = "Form_transaction";
            this.Load += new System.EventHandler(this.Form_transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnAddTrans;
        private TextBox tbCategory;
        private RadioButton rbIncome;
        private RadioButton rbOutcome;
        private Label label2;
        private Label lblPocketName;
        private ComboBox cbPocket;
        private Label label3;
        private TextBox tbAmount;
        private DateTimePicker dtpDateTrans;
        private Label label4;
    }
}