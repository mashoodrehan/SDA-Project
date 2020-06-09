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
        static Random risk = new Random();
        int LowFreq = 1;
        int MedFreq = 2;
        int HighFreq = 3;
        #region==================================================Panels==================================================
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

        private void KI_NI_Btn_Click(object sender, EventArgs e)
        {
            Panel(ChaklalaInstPnl);
        }

        private void KI_Bck_Btn_Click(object sender, EventArgs e)
        {
            Panel(DeptPnl);
        }

        private void Rslt_Hm_Btn_Click(object sender, EventArgs e)
        {
            Panel(HomePnl);
        }

        private void Rslt_Bck_Btn_Click(object sender, EventArgs e)
        {
            Panel(DeptPnl);
        }

        private void FD_Pnl2_Hm_Btn_Click(object sender, EventArgs e)
        {
            Panel(HomePnl);
        }

        private void FD_Pnl2_Bck_Btn_Click(object sender, EventArgs e)
        {
            Panel(FinancePnl);
        }

        private void FD_Pnl1_Hm_Btn_Click(object sender, EventArgs e)
        {
            Panel(HomePnl);
        }

        private void FD_Pnl1_Bck_Btn_Click(object sender, EventArgs e)
        {
            Panel(DeptPnl);
        }

        private void FD_Pnl1_NP_Btn_Click(object sender, EventArgs e)
        {
            Panel(FinancePnl2);
        }

        private void MD_Hm_Btn_Click(object sender, EventArgs e)
        {
            Panel(HomePnl);
        }

        private void MD_Bck_Btn_Click(object sender, EventArgs e)
        {
            Panel(DeptPnl);
        }

        private void HR_Hm_Btn_Click(object sender, EventArgs e)
        {
            Panel(HomePnl);
        }

        private void HR_Bck_Btn_Click(object sender, EventArgs e)
        {
            Panel(DeptPnl);
        }

        private void ParAVI_Hm_Btn_Click(object sender, EventArgs e)
        {
            Panel(HomePnl);
        }

        private void ParAVI_Bck_Btn_Click(object sender, EventArgs e)
        {
            Panel(ChaklalaAVIPnl);
        }

        private void KAVI_Home_Btn_Click(object sender, EventArgs e)
        {
            Panel(HomePnl);
        }

        private void KAVI_Bck_Btn_Click(object sender, EventArgs e)
        {
            Panel(DeptPnl);
        }

        private void KAVI_NAvi_Btn_Click(object sender, EventArgs e)
        {
            Panel(ChaklalaAVIPnl);
        }

        private void ChaklalaAvi_Hm_Btn_Click(object sender, EventArgs e)
        {
            Panel(HomePnl);
        }

        private void CAVI_Bck_Btn_Click(object sender, EventArgs e)
        {
            Panel(KemariAviPnl);
        }

        private void CAVI_NA_Btn_Click(object sender, EventArgs e)
        {
            Panel(ParcoAVIPnl);
        }

        private void C_Home_Btn_Click(object sender, EventArgs e)
        {
            Panel(HomePnl);
        }

        private void C_Bck_Btn_Click(object sender, EventArgs e)
        {
            Panel(KemariInstPnl);
        }

        private void C_NI_Btn_Click(object sender, EventArgs e)
        {
            Panel(ParcoInstPnl);
        }

        private void ParcoHmBtn_Click(object sender, EventArgs e)
        {
            Panel(HomePnl);
        }

        private void P_Bck_Btn_Click(object sender, EventArgs e)
        {
            Panel(ChaklalaInstPnl);
        }
        #endregion
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditPlanDataSet.AuditPlanRes' table. You can move, or remove it, as needed.
            this.auditPlanResTableAdapter.Fill(this.auditPlanDataSet.AuditPlanRes);
            // TODO: This line of code loads data into the 'auditPlanDataSet.FinanceDpt' table. You can move, or remove it, as needed.
            this.financeDptTableAdapter.Fill(this.auditPlanDataSet.FinanceDpt);
            // TODO: This line of code loads data into the 'auditPlanDataSet.MarketDpt' table. You can move, or remove it, as needed.
            this.marketDptTableAdapter.Fill(this.auditPlanDataSet.MarketDpt);
            // TODO: This line of code loads data into the 'auditPlanDataSet.HRDept' table. You can move, or remove it, as needed.
            this.hRDeptTableAdapter.Fill(this.auditPlanDataSet.HRDept);
            // TODO: This line of code loads data into the 'auditPlanDataSet.PARCOAvi' table. You can move, or remove it, as needed.
            this.pARCOAviTableAdapter.Fill(this.auditPlanDataSet.PARCOAvi);
            // TODO: This line of code loads data into the 'auditPlanDataSet.ChaklalaAvi' table. You can move, or remove it, as needed.
            this.chaklalaAviTableAdapter.Fill(this.auditPlanDataSet.ChaklalaAvi);
            // TODO: This line of code loads data into the 'auditPlanDataSet.KeemariAvi' table. You can move, or remove it, as needed.
            this.keemariAviTableAdapter.Fill(this.auditPlanDataSet.KeemariAvi);
            // TODO: This line of code loads data into the 'auditPlanDataSet.PARCODepo' table. You can move, or remove it, as needed.
            this.pARCODepoTableAdapter.Fill(this.auditPlanDataSet.PARCODepo);
            // TODO: This line of code loads data into the 'auditPlanDataSet.ChaklalaDepo' table. You can move, or remove it, as needed.
            this.chaklalaDepoTableAdapter.Fill(this.auditPlanDataSet.ChaklalaDepo);
            // TODO: This line of code loads data into the 'auditPlanDataSet.KeemariDepo' table. You can move, or remove it, as needed.
            this.keemariDepoTableAdapter.Fill(this.auditPlanDataSet.KeemariDepo);

        }
        #region--------------------------HR Department-----------------------------------------------------------
        public void HR_Clr()
        {
            HR_Date.Text = null; HR_Pur_Air_Tic_TB.Clear(); HR_Main_St_Cars_TB.Clear(); HR_HotlB_TB.Clear(); HR_Tran_Arr_TB.Clear();
            HR_PhotoC_TB.Clear();
        }
        public void HR_Result()
        {
            int j = 0;
            while (Res_GV.Rows.Count > j)
            {
                string dept = Res_GV.Rows[j].Cells[1].Value.ToString();
                if (dept == "HR Department")
                {
                    try
                    {
                        SQL_Queires SQ = new SQL_Queires();
                        string id = Res_GV.Rows[j].Cells[0].Value.ToString();
                        SQ.DeleteData("DELETE FROM AuditPlanRes WHERE ID = '" + id + "';");
                        SQ.ShowGVData("Select * FROM AuditPlanRes", Res_GV);
                    }
                    catch (Exception)
                    {
                    }
                }
                j++;
            }
            int Low = risk.Next(1, 40);
            int Medium = risk.Next(41, 70);
            int High = risk.Next(71, 100);
            int i = 0;
            double val = 0;
            while (HR_GV.Rows.Count > i)
            {
                val += double.Parse(HR_GV.Rows[i].Cells[2].Value.ToString()) + double.Parse(HR_GV.Rows[i].Cells[3].Value.ToString()) +
                    double.Parse(HR_GV.Rows[i].Cells[4].Value.ToString()) + double.Parse(HR_GV.Rows[i].Cells[5].Value.ToString()) +
                    double.Parse(HR_GV.Rows[i].Cells[6].Value.ToString());
                i++;
            }
            if (val > 6000000)
            {
                String query = "Insert INTO AuditPlanRes(Departments, Frequency, Risk) VALUES('HR Department', '" + HighFreq + "', '" + High + "')";
                SQL_Queires SQ = new SQL_Queires();
                SQ.InsertData(query);
                SQ.ShowGVData("SELECT * FROM AuditPlanRes", Res_GV);
            }
            else if (val < 6000000 && val > 3000000)
            {
                String query = "Insert INTO AuditPlanRes(Departments, Frequency, Risk) VALUES('HR Department', '" + MedFreq + "', '" + Medium + "')";
                SQL_Queires SQ = new SQL_Queires();
                SQ.InsertData(query);
                SQ.ShowGVData("SELECT * FROM AuditPlanRes", Res_GV);
            }
            else if (val < 3000000)
            {
                String query = "Insert INTO AuditPlanRes(Departments, Frequency, Risk) VALUES('HR Department', '" + LowFreq + "', '" + Low + "')";
                SQL_Queires SQ = new SQL_Queires();
                SQ.InsertData(query);
                SQ.ShowGVData("SELECT * FROM AuditPlanRes", Res_GV);
            }
        }
        #endregion

        private void HR_AddInfo_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                SQL_Queires SQ = new SQL_Queires();
                int j = 0;
                while (HR_GV.Rows.Count > j)
                {
                    string val = HR_GV.Rows[j].Cells[1].Value.ToString();
                    if (HR_Date.Text == val)
                    {
                        SQ.DeleteData("DELETE FROM HRDept WHERE Date = '" + val + "';");
                    }
                    j++;
                }
                String query = "Insert INTO HRDept (Date, Pur_Aff_Tic, Maint_Staff_Cars, Hotel_Book, Trans_Arran_Staff, Photo_Exp) " +
                    "VALUES('" + HR_Date.Text + "', '" + HR_Pur_Air_Tic_TB.Text + "', '" + HR_Main_St_Cars_TB.Text + "', '" + HR_HotlB_TB.Text + "', " +
                    "'" + HR_Tran_Arr_TB.Text + "', '" + HR_PhotoC_TB.Text + "')";
                SQ.InsertData(query);
                MessageBox.Show("Success!");
                HR_Clr();
                SQ.ShowGVData("SELECT * FROM HRDept", HR_GV);
                HR_Result();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void HR_GV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = HR_GV.SelectedRows[0].Cells[0].Value.ToString();
                HR_Date.Text = HR_GV.SelectedRows[0].Cells[1].Value.ToString();
                HR_Pur_Air_Tic_TB.Text = HR_GV.SelectedRows[0].Cells[2].Value.ToString();
                HR_Main_St_Cars_TB.Text = HR_GV.SelectedRows[0].Cells[3].Value.ToString();
                HR_HotlB_TB.Text = HR_GV.SelectedRows[0].Cells[4].Value.ToString();
                HR_Tran_Arr_TB.Text = HR_GV.SelectedRows[0].Cells[5].Value.ToString();
                HR_PhotoC_TB.Text = HR_GV.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void HR_Delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SQL_Queires SQ = new SQL_Queires();
                    string id = HR_GV.SelectedRows[0].Cells[0].Value.ToString();
                    SQ.DeleteData("DELETE FROM HRDept WHERE ID = '" + id + "';");
                    SQ.ShowGVData("Select * FROM HRDept", HR_GV);
                    HR_Clr();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
