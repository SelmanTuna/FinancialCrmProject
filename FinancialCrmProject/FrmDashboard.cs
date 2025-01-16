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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        int count = 0;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            btnDashboard.Enabled = false;

            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";

            var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + "₺";

            //chart1;
            var bankData = db.Banks.Select(x =>new 
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach(var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            //chart2;
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            foreach(var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count % 5 == 1)
            {
                var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = elektrikFaturasi.ToString() + "₺";
            }
            if(count % 5 == 2)
            {
                var suFaturasi = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = suFaturasi.ToString() + "₺";
            }
            if(count % 5 == 3)
            {
                var dogalgazFaturasi = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = dogalgazFaturasi.ToString() + "₺";
            }
            if(count % 5 == 4)
            {
                var internetFaturasi = db.Bills.Where(x => x.BillTitle == "Internet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Internet Faturası";
                lblBillAmount.Text = internetFaturasi.ToString() + "₺";
            }
            if (count % 5 == 0)
            {
                var aidatFaturasi = db.Bills.Where(x => x.BillTitle == "Aidat Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Aidat Faturası";
                lblBillAmount.Text = aidatFaturasi.ToString() + "₺";
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmcat = new FrmCategories();
            frmcat.Show();
            //this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmbnk = new FrmBanks();
            frmbnk.Show();
            //this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frmbl = new FrmBilling();
            frmbl.Show();
            //this.Hide();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            FrmSpending frmspn = new FrmSpending();
            frmspn.Show();
            //this.Hide();
        }

        private void btnBankTransaction_Click(object sender, EventArgs e)
        {
            FrmBankTransaction frmtra = new FrmBankTransaction();
            frmtra.Show();
            //this.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSettings frmset = new FrmSettings();
            frmset.Show();
            //this.Hide();
        }
    }
}
