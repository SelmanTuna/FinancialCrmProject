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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities(); 
        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            //var catValues = db.Categories.ToList();
            //dataGridView1.DataSource = catValues;           

            var context = new FinancialCrmDbEntities();
            var category = context.Categories
                .Select(x => new
                {
                    x.CategoryId,
                    x.CategoryName

                }).ToList();

            dataGridView1.DataSource = category;
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            btnCategories.Enabled = false;

            //var catValues = db.Categories.ToList();
            //dataGridView1.DataSource = catValues;
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            string catName = txtCategoryName.Text;

            Categories cat = new Categories();
            cat.CategoryName = catName;
            //cat.Spendings = decimal.Parse(catName.ToString());  

            db.Categories.Add(cat);
            db.SaveChanges();
            MessageBox.Show("Ekleme başarılı.", "Kategori Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frmbl = new FrmBilling();
            frmbl.Show();
            this.Hide();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            FrmSpendings frmspn = new FrmSpendings();
            frmspn.Show();
            this.Hide();
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);

            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Silme İşlme Başarılı.", "Silme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            string catName = txtCategoryName.Text;

            var updatedValue = db.Categories.Find(id);

            updatedValue.CategoryId = id;
            updatedValue.CategoryName = catName;

            db.SaveChanges();

            MessageBox.Show("Güncelleme İşlemi Başarılı.", "Güncelleme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSettings frmset = new FrmSettings();
            frmset.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmdas = new FrmDashboard();
            frmdas.Show();
            this.Hide();
        }

        private void btnBankTransaction_Click(object sender, EventArgs e)
        {
            FrmBankTransaction frmBnkTr = new FrmBankTransaction();
            frmBnkTr.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmbnk = new FrmBanks();
            frmbnk.Show();
            this.Hide();
        }
    }
}
