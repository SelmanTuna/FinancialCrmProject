using FinancialCrmProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrmProject
{
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnExpense_Click(object sender, EventArgs e)
        {
            FrmSpendings frmspn = new FrmSpendings();
            frmspn.Show();
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            btnExpense.Enabled = false;

            var categories = db.Categories.ToList();
            cmbCategoryList.DataSource = categories;
            cmbCategoryList.DisplayMember = "CategoryName";
            cmbCategoryList.ValueMember = "CategoryId";

        }

        private void btnSpendingList_Click(object sender, EventArgs e)
        {
            //var values = db.Spendings.ToList();
            //dataGridView1.DataSource = values; 

            var context = new FinancialCrmDbEntities();
            var values = context.Spendings
                    .Select(x => new
                    {
                        x.SpendingId,
                        x.SpendingDate,
                        x.SpendingTitle,
                        x.SpendingAmount,
                        //x.CategoryId
                        CategoryName = x.Categories.CategoryName

                    }).ToList();

            dataGridView1.DataSource = values;            
        }

        private void btnSpendingCreate_Click(object sender, EventArgs e)
        {
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            int categoryId = int.Parse(cmbCategoryList.SelectedValue.ToString());

            DateTime spendingDate = dateTimePicker.Value;
            

            Spendings spend = new Spendings();

            spend.SpendingTitle = title;
            spend.SpendingAmount = amount;
            spend.CategoryId = categoryId;
            spend.SpendingDate = spendingDate;

            db.Spendings.Add(spend);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı.", "Harcama Ekleme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSpendingDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);

            var removeSpend = db.Spendings.Find(id);

            db.Spendings.Remove(removeSpend);
            db.SaveChanges();

            MessageBox.Show("Silme İşlemi Başarılı!", "Harcama Silme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Error);        
        }

        private void btnSpendingUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            string title = txtSpendingTitle.Text;
            decimal amount = int.Parse(txtSpendingAmount.Text);
            int categoryId = int.Parse(cmbCategoryList.SelectedValue.ToString());

            DateTime spendingDate = dateTimePicker.Value;

            var updatedValue = db.Spendings.Find(id);

            updatedValue.SpendingTitle = title;
            updatedValue.SpendingAmount = amount;
            updatedValue.SpendingDate = spendingDate;
            updatedValue.CategoryId = categoryId;

            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı.", "Güncelleme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frmbl = new FrmBilling();
            frmbl.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmcat = new FrmCategories();
            frmcat.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmbnk = new FrmBanks();
            frmbnk.Show();
            this.Hide();
        }

        private void btnBankTransaction_Click(object sender, EventArgs e)
        {
            FrmBankTransaction frmBnTr = new FrmBankTransaction();
            frmBnTr.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmdas = new FrmDashboard();
            frmdas.Show();
            this.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSettings frmset = new FrmSettings();
            frmset.Show();
            this.Hide();
        }
    }
}
