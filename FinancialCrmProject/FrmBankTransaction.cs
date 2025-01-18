using FinancialCrmProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrmProject
{
    public partial class FrmBankTransaction : Form
    {
        public FrmBankTransaction()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int count=0;
        private void FrmBankTransaction_Load(object sender, EventArgs e)
        {
            btnBankTransaction.Enabled = false;

            var incomingAmount = db.BankProcesses.Where(x => x.ProcessType == "Gelen Havale").Sum(y=>y.Amount);
            lblIncomingAmount.Text = incomingAmount.ToString() + " ₺";

            var outgoingAmount = db.BankProcesses.Where(x => x.ProcessType == "Giden Havale").Sum(y => y.Amount);
            lblOutgoingAmount.Text = outgoingAmount.ToString() + " ₺";

            var context = new FinancialCrmDbEntities();
            var bnkProcesses = context.BankProcesses
                .Select(x => new
                {
                    x.BankProcessId,
                    x.Description,
                    x.ProcessDate,
                    x.ProcessType,
                    x.Amount,
                    BankTitle = x.Banks.BankTitle
                }).ToList();
            
            dataGridView1.DataSource = bnkProcesses;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerBnkTransaction_Tick(object sender, EventArgs e)
        {
            count++;

            if (count % 3 == 0)
            {
                var ziraatBnk = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
                lblBankBalance.Text = "Ziraat Bankası";
                lblTotalBankBalance.Text = ziraatBnk.ToString() + " ₺";
            }

            if (count % 3 == 1)
            {
                var vakifBnk = db.Banks.Where(x => x.BankTitle == "VakıfBank").Select(y => y.BankBalance).FirstOrDefault();
                lblBankBalance.Text = "VakıfBank";
                lblTotalBankBalance.Text = vakifBnk.ToString() + " ₺";
            }

            if (count % 3 == 2)
            {
                var isBnk = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();
                lblBankBalance.Text = "İş Bankası";
                lblTotalBankBalance.Text = isBnk.ToString() + " ₺";
            }
        }
    }
}
