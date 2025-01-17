namespace FinancialCrmProject
{
    partial class FrmBankTransaction
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOdemeUpdate = new System.Windows.Forms.Button();
            this.btnOdemeDelete = new System.Windows.Forms.Button();
            this.btnOdemeCreate = new System.Windows.Forms.Button();
            this.btnOdemeList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOdemePeriot = new System.Windows.Forms.TextBox();
            this.txtOdemeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnBankTransaction = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnBanks = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.labelControl1);
            this.panel4.Location = new System.Drawing.Point(-1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1267, 65);
            this.panel4.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(32, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(239, 28);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Banka Hareketleri Formu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(260, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 434);
            this.panel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(998, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOdemeUpdate);
            this.panel2.Controls.Add(this.btnOdemeDelete);
            this.panel2.Controls.Add(this.btnOdemeCreate);
            this.panel2.Controls.Add(this.btnOdemeList);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtOdemePeriot);
            this.panel2.Controls.Add(this.txtOdemeId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(260, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 189);
            this.panel2.TabIndex = 9;
            // 
            // btnOdemeUpdate
            // 
            this.btnOdemeUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOdemeUpdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeUpdate.Location = new System.Drawing.Point(496, 190);
            this.btnOdemeUpdate.Name = "btnOdemeUpdate";
            this.btnOdemeUpdate.Size = new System.Drawing.Size(153, 36);
            this.btnOdemeUpdate.TabIndex = 11;
            this.btnOdemeUpdate.Text = "Kategori Güncelle";
            this.btnOdemeUpdate.UseVisualStyleBackColor = false;
            // 
            // btnOdemeDelete
            // 
            this.btnOdemeDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOdemeDelete.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeDelete.Location = new System.Drawing.Point(337, 190);
            this.btnOdemeDelete.Name = "btnOdemeDelete";
            this.btnOdemeDelete.Size = new System.Drawing.Size(153, 36);
            this.btnOdemeDelete.TabIndex = 10;
            this.btnOdemeDelete.Text = "Kategori Sil";
            this.btnOdemeDelete.UseVisualStyleBackColor = false;
            // 
            // btnOdemeCreate
            // 
            this.btnOdemeCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOdemeCreate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeCreate.Location = new System.Drawing.Point(178, 190);
            this.btnOdemeCreate.Name = "btnOdemeCreate";
            this.btnOdemeCreate.Size = new System.Drawing.Size(153, 36);
            this.btnOdemeCreate.TabIndex = 9;
            this.btnOdemeCreate.Text = "Yeni Kategori";
            this.btnOdemeCreate.UseVisualStyleBackColor = false;
            // 
            // btnOdemeList
            // 
            this.btnOdemeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOdemeList.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeList.Location = new System.Drawing.Point(19, 190);
            this.btnOdemeList.Name = "btnOdemeList";
            this.btnOdemeList.Size = new System.Drawing.Size(153, 36);
            this.btnOdemeList.TabIndex = 8;
            this.btnOdemeList.Text = "Kategori Listesi";
            this.btnOdemeList.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(45, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kategori Adı :";
            // 
            // txtOdemePeriot
            // 
            this.txtOdemePeriot.BackColor = System.Drawing.Color.IndianRed;
            this.txtOdemePeriot.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdemePeriot.Location = new System.Drawing.Point(171, 93);
            this.txtOdemePeriot.Name = "txtOdemePeriot";
            this.txtOdemePeriot.Size = new System.Drawing.Size(214, 28);
            this.txtOdemePeriot.TabIndex = 3;
            // 
            // txtOdemeId
            // 
            this.txtOdemeId.BackColor = System.Drawing.Color.IndianRed;
            this.txtOdemeId.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdemeId.Location = new System.Drawing.Point(171, 44);
            this.txtOdemeId.Name = "txtOdemeId";
            this.txtOdemeId.Size = new System.Drawing.Size(214, 28);
            this.txtOdemeId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Id :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnBankTransaction);
            this.panel1.Controls.Add(this.btnExpense);
            this.panel1.Controls.Add(this.btnBills);
            this.panel1.Controls.Add(this.btnBanks);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Location = new System.Drawing.Point(-1, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 639);
            this.panel1.TabIndex = 8;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(32, 378);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(167, 35);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(32, 512);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(32, 446);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(167, 35);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "Ayarlar";
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnBankTransaction
            // 
            this.btnBankTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnBankTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankTransaction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankTransaction.ForeColor = System.Drawing.Color.White;
            this.btnBankTransaction.Location = new System.Drawing.Point(32, 310);
            this.btnBankTransaction.Name = "btnBankTransaction";
            this.btnBankTransaction.Size = new System.Drawing.Size(167, 35);
            this.btnBankTransaction.TabIndex = 4;
            this.btnBankTransaction.Text = "Banka Hareketleri";
            this.btnBankTransaction.UseVisualStyleBackColor = false;
            // 
            // btnExpense
            // 
            this.btnExpense.BackColor = System.Drawing.Color.Transparent;
            this.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpense.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpense.ForeColor = System.Drawing.Color.White;
            this.btnExpense.Location = new System.Drawing.Point(32, 248);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(167, 35);
            this.btnExpense.TabIndex = 3;
            this.btnExpense.Text = "Giderler";
            this.btnExpense.UseVisualStyleBackColor = false;
            // 
            // btnBills
            // 
            this.btnBills.BackColor = System.Drawing.Color.Transparent;
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Location = new System.Drawing.Point(32, 181);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(167, 35);
            this.btnBills.TabIndex = 2;
            this.btnBills.Text = "Faturalar";
            this.btnBills.UseVisualStyleBackColor = false;
            // 
            // btnBanks
            // 
            this.btnBanks.BackColor = System.Drawing.Color.Transparent;
            this.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanks.ForeColor = System.Drawing.Color.White;
            this.btnBanks.Location = new System.Drawing.Point(32, 115);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(167, 35);
            this.btnBanks.TabIndex = 1;
            this.btnBanks.Text = "Bankalar";
            this.btnBanks.UseVisualStyleBackColor = false;
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(32, 43);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(167, 35);
            this.btnCategories.TabIndex = 0;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.UseVisualStyleBackColor = false;
            // 
            // FrmBankTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 709);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1283, 756);
            this.MinimumSize = new System.Drawing.Size(1283, 756);
            this.Name = "FrmBankTransaction";
            this.Text = "FrmBankTransaction";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOdemeUpdate;
        private System.Windows.Forms.Button btnOdemeDelete;
        private System.Windows.Forms.Button btnOdemeCreate;
        private System.Windows.Forms.Button btnOdemeList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOdemePeriot;
        private System.Windows.Forms.TextBox txtOdemeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnBankTransaction;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Button btnCategories;
    }
}