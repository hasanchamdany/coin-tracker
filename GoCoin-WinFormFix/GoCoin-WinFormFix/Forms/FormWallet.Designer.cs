namespace GoCoin_WinFormFix.Forms
{
    partial class FormWallet
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
            this.btnAddWallet = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtWalletName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditWallet = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDeleteWallet = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLoadWallet = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvWallet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWallet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddWallet
            // 
            this.btnAddWallet.Location = new System.Drawing.Point(9, 146);
            this.btnAddWallet.Name = "btnAddWallet";
            this.btnAddWallet.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddWallet.Size = new System.Drawing.Size(262, 39);
            this.btnAddWallet.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnAddWallet.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnAddWallet.StateCommon.Border.ColorAngle = 0F;
            this.btnAddWallet.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddWallet.StateCommon.Border.Rounding = 20;
            this.btnAddWallet.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddWallet.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddWallet.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWallet.TabIndex = 1;
            this.btnAddWallet.Values.Text = "Add Wallet";
            this.btnAddWallet.Click += new System.EventHandler(this.btnAddWallet_Click);
            // 
            // txtWalletName
            // 
            this.txtWalletName.Location = new System.Drawing.Point(15, 9);
            this.txtWalletName.Name = "txtWalletName";
            this.txtWalletName.Size = new System.Drawing.Size(236, 35);
            this.txtWalletName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtWalletName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtWalletName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtWalletName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtWalletName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtWalletName.StateCommon.Border.Rounding = 20;
            this.txtWalletName.StateCommon.Border.Width = 1;
            this.txtWalletName.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtWalletName.StateCommon.Content.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWalletName.TabIndex = 2;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txtWalletName);
            this.kryptonPanel1.Location = new System.Drawing.Point(9, 69);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(262, 55);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.kryptonPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wallet name :";
            // 
            // btnEditWallet
            // 
            this.btnEditWallet.Location = new System.Drawing.Point(9, 206);
            this.btnEditWallet.Name = "btnEditWallet";
            this.btnEditWallet.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnEditWallet.Size = new System.Drawing.Size(121, 36);
            this.btnEditWallet.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnEditWallet.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnEditWallet.StateCommon.Border.ColorAngle = 0F;
            this.btnEditWallet.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEditWallet.StateCommon.Border.Rounding = 20;
            this.btnEditWallet.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEditWallet.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEditWallet.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditWallet.TabIndex = 6;
            this.btnEditWallet.Values.Text = "Edit";
            this.btnEditWallet.Click += new System.EventHandler(this.btnEditWallet_Click);
            // 
            // btnDeleteWallet
            // 
            this.btnDeleteWallet.Location = new System.Drawing.Point(9, 248);
            this.btnDeleteWallet.Name = "btnDeleteWallet";
            this.btnDeleteWallet.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnDeleteWallet.Size = new System.Drawing.Size(121, 36);
            this.btnDeleteWallet.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnDeleteWallet.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnDeleteWallet.StateCommon.Border.ColorAngle = 0F;
            this.btnDeleteWallet.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteWallet.StateCommon.Border.Rounding = 20;
            this.btnDeleteWallet.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDeleteWallet.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDeleteWallet.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWallet.TabIndex = 7;
            this.btnDeleteWallet.Values.Text = "Delete";
            this.btnDeleteWallet.Click += new System.EventHandler(this.btnDeleteWallet_Click);
            // 
            // btnLoadWallet
            // 
            this.btnLoadWallet.Location = new System.Drawing.Point(175, 383);
            this.btnLoadWallet.Name = "btnLoadWallet";
            this.btnLoadWallet.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnLoadWallet.Size = new System.Drawing.Size(121, 36);
            this.btnLoadWallet.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnLoadWallet.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnLoadWallet.StateCommon.Border.ColorAngle = 0F;
            this.btnLoadWallet.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLoadWallet.StateCommon.Border.Rounding = 20;
            this.btnLoadWallet.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLoadWallet.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLoadWallet.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadWallet.TabIndex = 8;
            this.btnLoadWallet.Values.Text = "Load";
            this.btnLoadWallet.Click += new System.EventHandler(this.btnLoadWallet_Click);
            // 
            // dgvWallet
            // 
            this.dgvWallet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWallet.Location = new System.Drawing.Point(384, 59);
            this.dgvWallet.Name = "dgvWallet";
            this.dgvWallet.Size = new System.Drawing.Size(473, 369);
            this.dgvWallet.TabIndex = 9;
            this.dgvWallet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWallet_CellContentClick);
            // 
            // FormWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dgvWallet);
            this.Controls.Add(this.btnLoadWallet);
            this.Controls.Add(this.btnDeleteWallet);
            this.Controls.Add(this.btnEditWallet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.btnAddWallet);
            this.Name = "FormWallet";
            this.Text = "FormWallet";
            this.Load += new System.EventHandler(this.FormWallet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWallet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddWallet;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtWalletName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEditWallet;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteWallet;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLoadWallet;
        private System.Windows.Forms.DataGridView dgvWallet;
    }
}