namespace GoCoin_WinFormFix.Forms
{
    partial class FormDashboard
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cbCategory = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbWallet = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dgvOutcome = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dgvIncome = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTransType = new System.Windows.Forms.Label();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.rdbOutcome = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdbIncome = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnEditTrans = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDeleteTrans = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label6 = new System.Windows.Forms.Label();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtAmount = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAddTrans = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbWallet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category:";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cbCategory);
            this.kryptonPanel1.Location = new System.Drawing.Point(12, 107);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(201, 46);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.kryptonPanel1.TabIndex = 9;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownWidth = 177;
            this.cbCategory.Location = new System.Drawing.Point(9, 10);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbCategory.Size = new System.Drawing.Size(183, 27);
            this.cbCategory.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbCategory.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbCategory.StateCommon.ComboBox.Border.Rounding = 10;
            this.cbCategory.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.TabIndex = 1;
            this.cbCategory.Text = "Choose category";
            // 
            // cbWallet
            // 
            this.cbWallet.DropDownWidth = 177;
            this.cbWallet.Location = new System.Drawing.Point(6, 9);
            this.cbWallet.Name = "cbWallet";
            this.cbWallet.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbWallet.Size = new System.Drawing.Size(183, 27);
            this.cbWallet.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbWallet.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbWallet.StateCommon.ComboBox.Border.Rounding = 10;
            this.cbWallet.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWallet.TabIndex = 0;
            this.cbWallet.Text = "Choose category";
            // 
            // dgvOutcome
            // 
            this.dgvOutcome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutcome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutcome.Location = new System.Drawing.Point(248, 251);
            this.dgvOutcome.Name = "dgvOutcome";
            this.dgvOutcome.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dgvOutcome.Size = new System.Drawing.Size(591, 186);
            this.dgvOutcome.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.dgvOutcome.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvOutcome.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.dgvOutcome.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.dgvOutcome.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dgvOutcome.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.dgvOutcome.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvOutcome.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.dgvOutcome.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.dgvOutcome.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.dgvOutcome.TabIndex = 10;
            // 
            // dgvIncome
            // 
            this.dgvIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Location = new System.Drawing.Point(248, 28);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dgvIncome.Size = new System.Drawing.Size(591, 186);
            this.dgvIncome.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.dgvIncome.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvIncome.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.dgvIncome.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.dgvIncome.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dgvIncome.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.dgvIncome.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvIncome.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.dgvIncome.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.dgvIncome.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.dgvIncome.TabIndex = 11;
            this.dgvIncome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIncome_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(245, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Income";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(245, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Outcome";
            // 
            // lblTransType
            // 
            this.lblTransType.AutoSize = true;
            this.lblTransType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransType.ForeColor = System.Drawing.Color.White;
            this.lblTransType.Location = new System.Drawing.Point(15, 43);
            this.lblTransType.Name = "lblTransType";
            this.lblTransType.Size = new System.Drawing.Size(125, 16);
            this.lblTransType.TabIndex = 14;
            this.lblTransType.Text = "Transaction type:";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.rdbOutcome);
            this.kryptonPanel2.Controls.Add(this.rdbIncome);
            this.kryptonPanel2.Location = new System.Drawing.Point(12, 53);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(201, 41);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.kryptonPanel2.TabIndex = 15;
            // 
            // rdbOutcome
            // 
            this.rdbOutcome.Location = new System.Drawing.Point(106, 9);
            this.rdbOutcome.Name = "rdbOutcome";
            this.rdbOutcome.Size = new System.Drawing.Size(83, 20);
            this.rdbOutcome.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.rdbOutcome.StateCommon.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOutcome.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.rdbOutcome.TabIndex = 1;
            this.rdbOutcome.Values.Text = "Outcome";
            this.rdbOutcome.CheckedChanged += new System.EventHandler(this.rdbOutcome_CheckedChanged);
            // 
            // rdbIncome
            // 
            this.rdbIncome.Location = new System.Drawing.Point(12, 9);
            this.rdbIncome.Name = "rdbIncome";
            this.rdbIncome.Size = new System.Drawing.Size(73, 20);
            this.rdbIncome.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.rdbIncome.StateCommon.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIncome.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.rdbIncome.TabIndex = 0;
            this.rdbIncome.Values.Text = "Income";
            this.rdbIncome.CheckedChanged += new System.EventHandler(this.rdbIncome_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Wallet:";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.cbWallet);
            this.kryptonPanel3.Location = new System.Drawing.Point(12, 166);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(201, 48);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.kryptonPanel3.TabIndex = 19;
            // 
            // btnEditTrans
            // 
            this.btnEditTrans.Location = new System.Drawing.Point(12, 336);
            this.btnEditTrans.Name = "btnEditTrans";
            this.btnEditTrans.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnEditTrans.Size = new System.Drawing.Size(98, 36);
            this.btnEditTrans.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnEditTrans.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnEditTrans.StateCommon.Border.ColorAngle = 0F;
            this.btnEditTrans.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEditTrans.StateCommon.Border.Rounding = 20;
            this.btnEditTrans.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEditTrans.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEditTrans.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTrans.TabIndex = 22;
            this.btnEditTrans.Values.Text = "Edit";
            this.btnEditTrans.Click += new System.EventHandler(this.btnEditTrans_Click);
            // 
            // btnDeleteTrans
            // 
            this.btnDeleteTrans.Location = new System.Drawing.Point(114, 336);
            this.btnDeleteTrans.Name = "btnDeleteTrans";
            this.btnDeleteTrans.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnDeleteTrans.Size = new System.Drawing.Size(98, 36);
            this.btnDeleteTrans.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnDeleteTrans.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnDeleteTrans.StateCommon.Border.ColorAngle = 0F;
            this.btnDeleteTrans.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteTrans.StateCommon.Border.Rounding = 20;
            this.btnDeleteTrans.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDeleteTrans.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDeleteTrans.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTrans.TabIndex = 23;
            this.btnDeleteTrans.Values.Text = "Delete";
            this.btnDeleteTrans.Click += new System.EventHandler(this.btnDeleteTrans_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Amount:";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.txtAmount);
            this.kryptonPanel4.Location = new System.Drawing.Point(12, 227);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(201, 48);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.kryptonPanel4.TabIndex = 27;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(6, 9);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(183, 29);
            this.txtAmount.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtAmount.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtAmount.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtAmount.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAmount.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtAmount.StateCommon.Border.Rounding = 10;
            this.txtAmount.StateCommon.Border.Width = 1;
            this.txtAmount.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtAmount.StateCommon.Content.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.TabIndex = 2;
            // 
            // btnAddTrans
            // 
            this.btnAddTrans.Location = new System.Drawing.Point(12, 294);
            this.btnAddTrans.Name = "btnAddTrans";
            this.btnAddTrans.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddTrans.Size = new System.Drawing.Size(200, 36);
            this.btnAddTrans.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnAddTrans.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnAddTrans.StateCommon.Border.ColorAngle = 0F;
            this.btnAddTrans.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddTrans.StateCommon.Border.Rounding = 20;
            this.btnAddTrans.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddTrans.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddTrans.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrans.TabIndex = 28;
            this.btnAddTrans.Values.Text = "Add Transaction";
            this.btnAddTrans.Click += new System.EventHandler(this.btnAddTrans_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnAddTrans);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kryptonPanel4);
            this.Controls.Add(this.btnDeleteTrans);
            this.Controls.Add(this.btnEditTrans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.lblTransType);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvIncome);
            this.Controls.Add(this.dgvOutcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbWallet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvOutcome;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbWallet;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTransType;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdbOutcome;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdbIncome;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEditTrans;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteTrans;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCategory;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAmount;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddTrans;
    }
}