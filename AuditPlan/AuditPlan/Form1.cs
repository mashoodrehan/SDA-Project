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

        private void KAVI_AddInfo_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                SQL_Queires SQ = new SQL_Queires();
                int j = 0;
                while (KemA_GV.Rows.Count > j)
                {
                    string val = KemA_GV.Rows[j].Cells[1].Value.ToString();
                    if (KA_Date.Text == val)
                    {
                        SQ.DeleteData("DELETE FROM KeemariAvi WHERE Date = '" + val + "';");
                    }
                    j++;
                }
                double JP4_SaleStck = (Convert.ToInt64(KAVI_JP4_P_IN_TB.Text) * Convert.ToInt64(KAVI_JP4_S_IN_TB.Text)) / 100;
                double JetA1_SaleStck = (Convert.ToInt64(KAVI_JetA1_P_IN_TB.Text) * Convert.ToInt64(KAVI_JetA1_S_IN_TB.Text)) / 100;
                double JP4_CStck = Convert.ToInt64(KAVI_JP4_P_IN_TB.Text) - (Convert.ToInt64(KAVI_JP4_T_Stck_TB.Text) + JP4_SaleStck);
                double JetA1_CStck = Convert.ToInt64(KAVI_JetA1_P_IN_TB.Text) - (Convert.ToInt64(KAVI_JetA1_T_Stck_TB.Text) + JetA1_SaleStck);
                String query = "Insert INTO KeemariAvi (Date, JP4_Pur_Ltr, JetA1_Pur_Ltr, Pur_Tstock, JP4_Pur_Amnt, JetA1_Pur_Amnt," +
                "Pur_Tamount, JP4_Tran_Per, JetA1_Tran_Per, JP4_Tran_Stck, JetA1_Tran_Stck, Tran_Tstock, JP4_Sale_Per, JetA1_Sale_per, " +
                "JP4_Sale_Amnt, JetA1_Sale_Amnt,Sale_Tamount, KarA_Stck, QueA_Stck, NawA_Stck, SukA_Stck, Avi_Tstock, KarA_Sale, " +
                "QueA_Sale, NawA_Sale, SukA_Sale,  Avi_TSale, JP4_Pur_Prc, JetA1_Pur_Prc, JP4_ClosingS, JetA1_ClosingS, JP4_Sale_Prc, " +
                "JetA1_Sale_Prc) VALUES('" + KA_Date.Text + "', '" + KAVI_JP4_P_IN_TB.Text + "', '" + KAVI_JetA1_P_IN_TB.Text + "', '" + KAVI_TPSM_P_TStck_TB.Text + "', " +
                "'" + KAVI_JP4_P_Prc_TB.Text + "', '" + KAVI_JetA1_P_Prc_TB.Text + "', '" + KAVI_TPSM_P_TAmnt_TB.Text + "', '" + KAVI_JP4_T_IN_TB.Text + "', " +
                "'" + KAVI_JetA1_T_IN_TB.Text + "', '" + KAVI_JP4_T_Stck_TB.Text + "', '" + KAVI_JetA1_T_Stck_TB.Text + "', '" + KAVI_TTS_T_TStck_TB.Text + "', " +
                "'" + KAVI_JP4_S_IN_TB.Text + "', '" + KAVI_JetA1_S_IN_TB.Text + "', '" + KAVI_JP4_S_Amnt_TB.Text + "', '" + KAVI_JetA1_S_Amnt_TB.Text + "', " +
                "'" + KAVI_TSA_S_TAmnt_TB.Text + "', '" + KAVI_KA_Stck_TB.Text + "', '" + KAVI_QA_Stck_TB.Text + "', '" + KAVI_NA_Stck_TB.Text + "', " +
                "'" + KAVI_SA_Stck_TB.Text + "', '" + KAVI_Depo_Tstck_TB.Text + "', '" + KAVI_KA_Sale_TB.Text + "', '" + KAVI_QA_Sale_TB.Text + "', " +
                "'" + KAVI_NA_Sale_TB.Text + "', '" + KAVI_SA_Sale_TB.Text + "', '" + KAVI_Depo_TSale_TB.Text + "', '" + 110 + "', '" + 115 + "', '" + JP4_CStck + "', " +
                "'" + JetA1_CStck + "', '" + 120 + "', '" + 125 + "')";
                SQ.InsertData(query);
                MessageBox.Show("Success!");
                //KAVI_Clr();
                SQ.ShowGVData("SELECT * FROM KeemariAvi", KemA_GV);
                //KeemariAvi_Result();
            }
            catch (Exception)
            {
            }
        }
    }
}
