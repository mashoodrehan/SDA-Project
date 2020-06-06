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
    }
}
