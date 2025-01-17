namespace FinancialCrmProject
{
    partial class FrmSpendings
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
            this.cmbCategoryList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpendingAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpendingTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSpendingId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpendingUpdate = new System.Windows.Forms.Button();
            this.btnSpendingDelete = new System.Windows.Forms.Button();
            this.btnSpendingCreate = new System.Windows.Forms.Button();
            this.btnSpendingList = new System.Windows.Forms.Button();
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
            this.labelControl1.Size = new System.Drawing.Size(146, 28);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Giderler Formu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(260, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1006, 340);
            this.panel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCategoryList);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSpendingAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSpendingTitle);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSpendingId);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnSpendingUpdate);
            this.panel2.Controls.Add(this.btnSpendingDelete);
            this.panel2.Controls.Add(this.btnSpendingCreate);
            this.panel2.Controls.Add(this.btnSpendingList);
            this.panel2.Location = new System.Drawing.Point(260, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 283);
            this.panel2.TabIndex = 9;
            // 
            // cmbCategoryList
            // 
            this.cmbCategoryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbCategoryList.FormattingEnabled = true;
            this.cmbCategoryList.Location = new System.Drawing.Point(196, 187);
            this.cmbCategoryList.Name = "cmbCategoryList";
            this.cmbCategoryList.Size = new System.Drawing.Size(216, 24);
            this.cmbCategoryList.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(92, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kategori :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dateTimePicker.Location = new System.Drawing.Point(195, 238);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(217, 22);
            this.dateTimePicker.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(113, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Başlık :";
            // 
            // txtSpendingAmount
            // 
            this.txtSpendingAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSpendingAmount.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingAmount.Location = new System.Drawing.Point(195, 137);
            this.txtSpendingAmount.Name = "txtSpendingAmount";
            this.txtSpendingAmount.Size = new System.Drawing.Size(217, 28);
            this.txtSpendingAmount.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(106, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Miktar :";
            // 
            // txtSpendingTitle
            // 
            this.txtSpendingTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSpendingTitle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingTitle.Location = new System.Drawing.Point(195, 89);
            this.txtSpendingTitle.Name = "txtSpendingTitle";
            this.txtSpendingTitle.Size = new System.Drawing.Size(217, 28);
            this.txtSpendingTitle.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(121, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tarih :";
            // 
            // txtSpendingId
            // 
            this.txtSpendingId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSpendingId.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingId.Location = new System.Drawing.Point(195, 40);
            this.txtSpendingId.Name = "txtSpendingId";
            this.txtSpendingId.Size = new System.Drawing.Size(217, 28);
            this.txtSpendingId.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(146, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id :";
            // 
            // btnSpendingUpdate
            // 
            this.btnSpendingUpdate.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSpendingUpdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingUpdate.Location = new System.Drawing.Point(492, 218);
            this.btnSpendingUpdate.Name = "btnSpendingUpdate";
            this.btnSpendingUpdate.Size = new System.Drawing.Size(176, 38);
            this.btnSpendingUpdate.TabIndex = 11;
            this.btnSpendingUpdate.Text = "Gider Güncelle";
            this.btnSpendingUpdate.UseVisualStyleBackColor = false;
            this.btnSpendingUpdate.Click += new System.EventHandler(this.btnSpendingUpdate_Click);
            // 
            // btnSpendingDelete
            // 
            this.btnSpendingDelete.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSpendingDelete.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingDelete.Location = new System.Drawing.Point(492, 157);
            this.btnSpendingDelete.Name = "btnSpendingDelete";
            this.btnSpendingDelete.Size = new System.Drawing.Size(176, 38);
            this.btnSpendingDelete.TabIndex = 10;
            this.btnSpendingDelete.Text = "Gider Sil";
            this.btnSpendingDelete.UseVisualStyleBackColor = false;
            this.btnSpendingDelete.Click += new System.EventHandler(this.btnSpendingDelete_Click);
            // 
            // btnSpendingCreate
            // 
            this.btnSpendingCreate.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSpendingCreate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingCreate.Location = new System.Drawing.Point(492, 98);
            this.btnSpendingCreate.Name = "btnSpendingCreate";
            this.btnSpendingCreate.Size = new System.Drawing.Size(176, 38);
            this.btnSpendingCreate.TabIndex = 9;
            this.btnSpendingCreate.Text = "Gider Ekle";
            this.btnSpendingCreate.UseVisualStyleBackColor = false;
            this.btnSpendingCreate.Click += new System.EventHandler(this.btnSpendingCreate_Click);
            // 
            // btnSpendingList
            // 
            this.btnSpendingList.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSpendingList.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingList.Location = new System.Drawing.Point(492, 40);
            this.btnSpendingList.Name = "btnSpendingList";
            this.btnSpendingList.Size = new System.Drawing.Size(176, 38);
            this.btnSpendingList.TabIndex = 8;
            this.btnSpendingList.Text = "Giderler";
            this.btnSpendingList.UseVisualStyleBackColor = false;
            this.btnSpendingList.Click += new System.EventHandler(this.btnSpendingList_Click);
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
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
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
            this.btnBankTransaction.Click += new System.EventHandler(this.btnBankTransaction_Click);
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
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
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
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
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
            this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
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
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // FrmSpendings
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
            this.Name = "FrmSpendings";
            this.Text = "FrmSpending";
            this.Load += new System.EventHandler(this.FrmSpendings_Load);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnBankTransaction;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpendingAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpendingTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSpendingId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpendingUpdate;
        private System.Windows.Forms.Button btnSpendingDelete;
        private System.Windows.Forms.Button btnSpendingCreate;
        private System.Windows.Forms.Button btnSpendingList;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoryList;
    }
}