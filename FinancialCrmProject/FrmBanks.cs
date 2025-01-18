using FinancialCrmProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrmProject
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {

            btnBanks.Enabled = false;

            // Banka Bakiyeleri

            var ziraatBanks = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();

            var vakifBanks = db.Banks.Where(x => x.BankTitle == "VakıfBank").Select(y => y.BankBalance).FirstOrDefault();

            var isBanks = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBankBalance.Text = (ziraatBanks.ToString() + " ₺");
            lblVakifBankBalance.Text = (vakifBanks.ToString() + " ₺");
            lblIsBankBalance.Text = (isBanks.ToString() + " ₺");

            // Banka Hareketleri

            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + "   " + bankProcess1.Amount + " ₺" + "   " + bankProcess1.ProcessDate;  

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + "   " + bankProcess2.Amount + " ₺" + "   " + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + "   " + bankProcess3.Amount + " ₺" + "   " + bankProcess3.ProcessDate;

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + "   " + bankProcess4.Amount + " ₺" + "   " + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + "   " + bankProcess4.Amount + " ₺" + "   " + bankProcess5.ProcessDate;


        }

        private void btnGiderler_Click(object sender, EventArgs e)
        {
            FrmBilling frmbll = new FrmBilling();
            frmbll.Show();
            this.Hide(); // arka planda açık kalmaya devam ettiği için RAM de yer kaplar ve performance sorunları doğurabilir.!! */ this.Close(); olarak revize edilmesi daha doğru olur. /*
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmdas = new FrmDashboard();
            frmdas.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBankTransaction_Click(object sender, EventArgs e)
        {
            FrmBankTransaction frmBnkTr = new FrmBankTransaction();
            frmBnkTr.Show();
            this.Hide();

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmcat = new FrmCategories();
            frmcat.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frmbl = new FrmBilling();
            frmbl.Show();
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
