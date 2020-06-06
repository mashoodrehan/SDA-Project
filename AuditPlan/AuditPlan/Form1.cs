using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuditPlan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Panel(System.Windows.Forms.Panel p)
        {
            MarketPnl.Visible = false;
            HRMPnl.Visible = false;
            ParcoAVIPnl.Visible = false;
            ChaklalaAVIPnl.Visible = false;
            KemariAviPnl.Visible = false;
            ParcoInstPnl.Visible = false;
            ChaklalaInstPnl.Visible = false;
            KemariInstPnl.Visible = false;
            DeptPnl.Visible = false;
            HomePnl.Visible = false;
            FinancePnl.Visible = false;
            FinancePnl2.Visible = false;
            ResultDptPnl.Visible = false;
            p.Visible = true;
        }

        private void Home_DptBtn_Click(object sender, EventArgs e)
        {
            Panel(DeptPnl);
        }

        private void HomeResltBtn_Click(object sender, EventArgs e)
        {
            Panel(ResultDptPnl);
        }

        private void Dpt_HomeBtn_Click(object sender, EventArgs e)
        {
            Panel(HomePnl);
        }

        private void Dpt_HRDptBtn_Click(object sender, EventArgs e)
        {
            Panel(HRMPnl);
        }

        private void Dpt_OpDptBtn_Click(object sender, EventArgs e)
        {
            Panel(KemariInstPnl);
        }

        private void Dpt_MktDptBtn_Click(object sender, EventArgs e)
        {
            Panel(MarketPnl);
        }

        private void Dpt_AviDptBtn_Click(object sender, EventArgs e)
        {
            Panel(KemariAviPnl);
        }

        private void Dpt_FinDptBtn_Click(object sender, EventArgs e)
        {
            Panel(FinancePnl);
            //try
            //{
            //    SLW();
            //    LGLW();
            //    PQVLW();
            //    CSPLW();
            //}
            //catch (Exception)
            //{
            //}
        }

        private void KIDepoHmBtn_Click(object sender, EventArgs e)
        {
            Panel(HomePnl);
        }
    }
}
