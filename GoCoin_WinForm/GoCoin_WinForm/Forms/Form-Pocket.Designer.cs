namespace GoCoin_WinForm.Forms
{
    partial class Form_Pocket
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
            this.lblWallet = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbPocketName = new System.Windows.Forms.TextBox();
            this.btnAddPocket = new System.Windows.Forms.Button();
            this.btnDeletePocket = new System.Windows.Forms.Button();
            this.btnEditPocket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWallet
            // 
            this.lblWallet.AutoSize = true;
            this.lblWallet.Font = new System.Drawing.Font("Eras Demi ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWallet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblWallet.Location = new System.Drawing.Point(14, 56);
            this.lblWallet.Name = "lblWallet";
            this.lblWallet.Size = new System.Drawing.Size(85, 15);
            this.lblWallet.TabIndex = 0;
            this.lblWallet.Text = "Nama pcoket:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(596, 403);
            this.dataGridView1.TabIndex = 1;
            // 
            // tbPocketName
            // 
            this.tbPocketName.Location = new System.Drawing.Point(14, 74);
            this.tbPocketName.Name = "tbPocketName";
            this.tbPocketName.Size = new System.Drawing.Size(209, 23);
            this.tbPocketName.TabIndex = 2;
            // 
            // btnAddPocket
            // 
            this.btnAddPocket.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddPocket.FlatAppearance.BorderSize = 0;
            this.btnAddPocket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPocket.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddPocket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnAddPocket.Location = new System.Drawing.Point(12, 103);
            this.btnAddPocket.Name = "btnAddPocket";
            this.btnAddPocket.Size = new System.Drawing.Size(119, 28);
            this.btnAddPocket.TabIndex = 3;
            this.btnAddPocket.Text = "Add Pocket";
            this.btnAddPocket.UseVisualStyleBackColor = false;
            // 
            // btnDeletePocket
            // 
            this.btnDeletePocket.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeletePocket.FlatAppearance.BorderSize = 0;
            this.btnDeletePocket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePocket.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeletePocket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnDeletePocket.Location = new System.Drawing.Point(14, 200);
            this.btnDeletePocket.Name = "btnDeletePocket";
            this.btnDeletePocket.Size = new System.Drawing.Size(119, 28);
            this.btnDeletePocket.TabIndex = 4;
            this.btnDeletePocket.Text = "Delete Pocket";
            this.btnDeletePocket.UseVisualStyleBackColor = false;
            // 
            // btnEditPocket
            // 
            this.btnEditPocket.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEditPocket.FlatAppearance.BorderSize = 0;
            this.btnEditPocket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPocket.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditPocket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnEditPocket.Location = new System.Drawing.Point(14, 166);
            this.btnEditPocket.Name = "btnEditPocket";
            this.btnEditPocket.Size = new System.Drawing.Size(119, 28);
            this.btnEditPocket.TabIndex = 5;
            this.btnEditPocket.Text = "Edit Pocket";
            this.btnEditPocket.UseVisualStyleBackColor = false;
            // 
            // Form_Pocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnEditPocket);
            this.Controls.Add(this.btnDeletePocket);
            this.Controls.Add(this.btnAddPocket);
            this.Controls.Add(this.tbPocketName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblWallet);
            this.Name = "Form_Pocket";
            this.Text = "Form_Pocket";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWallet;
        private DataGridView dataGridView1;
        private TextBox tbPocketName;
        private Button btnAddPocket;
        private Button btnDeletePocket;
        private Button btnEditPocket;
    }
}