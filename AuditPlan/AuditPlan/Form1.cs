using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection con = new SqlConnection("Data Source=MASHOOD;Initial Catalog=AuditPlan;Integrated Security=True");
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
        #region===============================================Keemari Depo===============================================
        public void TotalPurStckKemInst()
        {
            KI_TPSM_P_Stck_TB.Text = ((Convert.ToInt64(KI_MS_P_IN_TB.Text) * 30) + (Convert.ToInt64(KI_HOBC_P_IN_TB.Text) * 30) + (Convert.ToInt64(KI_HSD_P_IN_TB.Text) * 30) + (Convert.ToInt64(KI_KO_P_IN_TB.Text) * 30)).ToString();
        }
        public void TotalPurAmntKemInst()
        {
            KI_TPSM_P_Prc_TB.Text = ((Convert.ToInt64(KI_MS_P_Prc_TB.Text) * 30) + (Convert.ToInt64(KI_HOBC_P_Prc_TB.Text) * 30) + (Convert.ToInt64(KI_HSD_P_Prc_TB.Text) * 30) + (Convert.ToInt64(KI_KO_P_Prc_TB.Text) * 30)).ToString();
        }
        public void TotalTranStckKemInst()
        {
            KI_TTS_T_Stck_TB.Text = ((Convert.ToInt64(KI_MS_T_TS_TB.Text) * 30) + (Convert.ToInt64(KI_HOBC_T_TS_TB.Text) * 30) + (Convert.ToInt64(KI_HSD_T_TS_TB.Text) * 30) + (Convert.ToInt64(KI_KO_T_TS_TB.Text) * 30)).ToString();
        }

        public void TotalSaleAmntKemInst()
        {
            KI_TSA_S_Amnt_TB.Text = ((Convert.ToInt64(KI_MS_S_Prc_TB.Text) * 30) + (Convert.ToInt64(KI_HOBC_S_Prc_TB.Text) * 30) + (Convert.ToInt64(KI_HSD_S_Prc_TB.Text) * 30) + (Convert.ToInt64(KI_KO_S_Prc_TB.Text) * 30)).ToString();
        }

        public void DepoPDStckKemInst()
        {
            KI_SD_Stck_TB.Text = (Convert.ToInt64(KI_TTS_T_Stck_TB.Text) / 90).ToString();
            KI_DD_Stck_TB.Text = (Convert.ToInt64(KI_TTS_T_Stck_TB.Text) / 90).ToString();
            KI_QD_Stck_TB.Text = (Convert.ToInt64(KI_TTS_T_Stck_TB.Text) / 90).ToString();
        }
        public void DepoTotStckKemInst()
        {
            KI_Depo_TStck.Text = KI_TTS_T_Stck_TB.Text;
        }
        public void DepoPDSaleKemInst()
        {
            KI_SD_Sale_TB.Text = (Convert.ToInt64(KI_SD_Stck_TB.Text) * 125).ToString();
            KI_DD_Sale_TB.Text = (Convert.ToInt64(KI_DD_Stck_TB.Text) * 130).ToString();
            KI_QD_Sale_TB.Text = (Convert.ToInt64(KI_QD_Stck_TB.Text) * 122).ToString();
        }
        public void DepoTotSaleKemInst()
        {
            KI_Depo_TAmnt.Text = ((Convert.ToInt64(KI_SD_Sale_TB.Text) + Convert.ToInt64(KI_DD_Sale_TB.Text) + Convert.ToInt64(KI_QD_Sale_TB.Text)) * 30).ToString();
        }

        public void KID_Clr()
        {
            KD_Date.Text = null; KI_MS_P_IN_TB.Clear(); KI_HOBC_P_IN_TB.Clear(); KI_HSD_P_IN_TB.Clear(); KI_KO_P_IN_TB.Clear(); KI_MS_P_Prc_TB.Clear();
            KI_HOBC_P_Prc_TB.Clear(); KI_HSD_P_Prc_TB.Clear(); KI_KO_P_Prc_TB.Clear(); KI_MS_T_IN_TB.Clear(); KI_HOBC_T_IN_TB.Clear();
            KI_HSD_T_IN_TB.Clear(); KI_KO_T_IN_TB.Clear(); KI_MS_T_TS_TB.Clear(); KI_HOBC_T_TS_TB.Clear(); KI_HSD_T_TS_TB.Clear();
            KI_KO_T_TS_TB.Clear(); KI_MS_S_IN_TB.Clear(); KI_HOBC_S_IN_TB.Clear(); KI_HSD_S_IN_TB.Clear(); KI_KO_S_IN_TB.Clear();
            KI_MS_S_Prc_TB.Clear(); KI_HOBC_S_Prc_TB.Clear(); KI_HSD_S_Prc_TB.Clear(); KI_KO_S_Prc_TB.Clear(); KI_TPSM_P_Prc_TB.Clear();
            KI_TPSM_P_Stck_TB.Clear(); KI_TTS_T_Stck_TB.Clear(); KI_TSA_S_Amnt_TB.Clear(); KI_SD_Sale_TB.Clear(); KI_SD_Stck_TB.Clear();
            KI_DD_Sale_TB.Clear(); KI_DD_Stck_TB.Clear(); KI_QD_Sale_TB.Clear(); KI_QD_Stck_TB.Clear(); KI_Depo_TAmnt.Clear();
            KI_Depo_TStck.Clear();
        }

        public void KeemariDepo_Result()
        {
            int j = 0;
            while (Res_GV.Rows.Count > j)
            {
                string dept = Res_GV.Rows[j].Cells[1].Value.ToString();
                if (dept == "Keemari Depo")
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
            int i = 0;
            int Low = risk.Next(1, 40);
            int Medium = risk.Next(41, 70);
            int High = risk.Next(71, 100);
            double val = 0;
            while (KemD_GV.Rows.Count > i)
            {
                val += double.Parse(KemD_GV.Rows[i].Cells[11].Value.ToString());
                i++;
            }
            if (val > 25000000)
            {
                String query = "Insert INTO AuditPlanRes(Departments, Frequency, Risk) VALUES('Keemari Depo', '" + HighFreq + "', '" + High + "')";
                SQL_Queires SQ = new SQL_Queires();
                SQ.InsertData(query);
                SQ.ShowGVData("SELECT * FROM AuditPlanRes", Res_GV);
            }
            else if (val < 25000000 && val > 15000000)
            {
                String query = "Insert INTO AuditPlanRes(Departments, Frequency, Risk) VALUES('Keemari Depo', '" + MedFreq + "', '" + Medium + "')";
                SQL_Queires SQ = new SQL_Queires();
                SQ.InsertData(query);
                SQ.ShowGVData("SELECT * FROM AuditPlanRes", Res_GV);
            }
            else if (val < 15000000)
            {
                String query = "Insert INTO AuditPlanRes(Departments, Frequency, Risk) VALUES('Keemari Depo', '" + LowFreq + "', '" + Low + "')";
                SQL_Queires SQ = new SQL_Queires();
                SQ.InsertData(query);
                SQ.ShowGVData("SELECT * FROM AuditPlanRes", Res_GV);
            }
        }
        private void KI_AInfo_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                SQL_Queires SQ = new SQL_Queires();
                int j = 0;
                while (KemD_GV.Rows.Count > j)
                {
                    string val = KemD_GV.Rows[j].Cells[1].Value.ToString();
                    if (KD_Date.Text == val)
                    {
                        SQ.DeleteData("DELETE FROM KeemariDepo WHERE Date = '" + val + "';");
                    }
                    j++;
                }
                double MS_SaleStck = (Convert.ToInt64(KI_MS_P_IN_TB.Text) * Convert.ToInt64(KI_MS_S_IN_TB.Text)) / 100;
                double HOBC_SaleStck = (Convert.ToInt64(KI_HOBC_P_IN_TB.Text) * Convert.ToInt64(KI_HOBC_S_IN_TB.Text)) / 100;
                double HSD_SaleStck = (Convert.ToInt64(KI_HSD_P_IN_TB.Text) * Convert.ToInt64(KI_HSD_S_IN_TB.Text)) / 100;
                double KO_SaleStck = (Convert.ToInt64(KI_KO_P_IN_TB.Text) * Convert.ToInt64(KI_KO_S_IN_TB.Text)) / 100;
                double MS_CStck = Convert.ToInt64(KI_MS_P_IN_TB.Text) - (Convert.ToInt64(KI_MS_T_TS_TB.Text) + MS_SaleStck);
                double HOBC_CStck = Convert.ToInt64(KI_HOBC_P_IN_TB.Text) - (Convert.ToInt64(KI_HOBC_T_TS_TB.Text) + HOBC_SaleStck);
                double HSD_CStck = Convert.ToInt64(KI_HSD_P_IN_TB.Text) - (Convert.ToInt64(KI_HSD_T_TS_TB.Text) + HSD_SaleStck);
                double KO_CStck = Convert.ToInt64(KI_KO_P_IN_TB.Text) - (Convert.ToInt64(KI_KO_T_TS_TB.Text) + KO_SaleStck);
                String query = "Insert INTO KeemariDepo (Date, MS_Pur_Ltr, HOBC_Pur_Ltr, HSD_Pur_Ltr, KO_Pur_Ltr, Pur_Tstock, MS_Pur_Amnt, HOBC_Pur_Amnt," +
                "HSD_Pur_Amnt, KO_Pur_Amnt, Pur_Tamount, MS_Tran_Per, HOBC_Tran_Per, HSD_Tran_Per, KO_Tran_Per, MS_Tran_Stck, HOBC_Tran_Stck, " +
                "HSD_Tran_Stck, KO_Tran_Stck, Tran_Tstock, MS_Sale_Per, HOBC_Sale_per, HSD_Sale_Per, KO_Sale_Per, MS_Sale_Amnt, HOBC_Sale_Amnt, HSD_Sale_Amnt," +
                "KO_Sale_Amnt, Sale_Tamount, SukhD_Stck, DaulD_Stck, QueD_Stck, Depo_Tstock, SukhD_Sale, DaulD_Sale, QueD_Sale, Depo_TSale, MS_Pur_Prc," +
                "HOBC_Pur_Prc, HSD_Pur_Prc, KO_Pur_Prc, MS_ClosingS, HOBC_ClosingS, HSD_ClosingS, KO_ClosingS, MS_Sale_Prc, HOBC_Sale_Prc," +
                "HSD_Sale_Prc, KO_Sale_Prc) VALUES('" + KD_Date.Text + "', '" + KI_MS_P_IN_TB.Text + "', '" + KI_HOBC_P_IN_TB.Text + "', '" + KI_HSD_P_IN_TB.Text + "', '" + KI_KO_P_IN_TB.Text + "', '" + KI_TPSM_P_Stck_TB.Text + "', " +
                "'" + KI_MS_P_Prc_TB.Text + "', '" + KI_HOBC_P_Prc_TB.Text + "', '" + KI_HSD_P_Prc_TB.Text + "', '" + KI_KO_P_Prc_TB.Text + "', '" + KI_TPSM_P_Prc_TB.Text + "', '" + KI_MS_T_IN_TB.Text + "', " +
                "'" + KI_HOBC_T_IN_TB.Text + "', '" + KI_HSD_T_IN_TB.Text + "', '" + KI_KO_T_IN_TB.Text + "', '" + KI_MS_T_TS_TB.Text + "', '" + KI_HOBC_T_TS_TB.Text + "', '" + KI_HSD_T_TS_TB.Text + "', " +
                "'" + KI_KO_T_TS_TB.Text + "', '" + KI_TTS_T_Stck_TB.Text + "', '" + KI_MS_S_IN_TB.Text + "', '" + KI_HOBC_S_IN_TB.Text + "', '" + KI_HSD_S_IN_TB.Text + "', '" + KI_KO_S_IN_TB.Text + "', " +
                "'" + KI_MS_S_Prc_TB.Text + "', '" + KI_HOBC_S_Prc_TB.Text + "', '" + KI_HSD_S_Prc_TB.Text + "', '" + KI_KO_S_Prc_TB.Text + "', '" + KI_TSA_S_Amnt_TB.Text + "', '" + KI_SD_Stck_TB.Text + "', '" + KI_DD_Stck_TB.Text + "', " +
                "'" + KI_QD_Stck_TB.Text + "', '" + KI_Depo_TStck.Text + "', '" + KI_SD_Sale_TB.Text + "', '" + KI_DD_Sale_TB.Text + "', '" + KI_QD_Sale_TB.Text + "', '" + KI_Depo_TAmnt.Text + "', " +
                "'" + 90 + "', '" + 100 + "', '" + 115 + "', '" + 110 + "', '" + MS_CStck + "', '" + HOBC_CStck + "', '" + HSD_CStck + "', '" + KO_CStck + "', '" + 98 + "', '" + 116 + "', '" + 125 + "', '" + 120 + "')";
                SQ.InsertData(query);
                MessageBox.Show("Success!");
                KID_Clr();
                SQ.ShowGVData("SELECT * FROM KeemariDepo", KemD_GV);
                KeemariDepo_Result();
            }
            catch (FormatException)
            {
            }
        }
        private void KI_Update_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                string comp = KemD_GV.SelectedRows[0].Cells[1].Value.ToString();
                if (KD_Date.Text == comp)
                {
                    double MS_SaleStck = (Convert.ToInt64(KI_MS_P_IN_TB.Text) * Convert.ToInt64(KI_MS_S_IN_TB.Text)) / 100;
                    double HOBC_SaleStck = (Convert.ToInt64(KI_HOBC_P_IN_TB.Text) * Convert.ToInt64(KI_HOBC_S_IN_TB.Text)) / 100;
                    double HSD_SaleStck = (Convert.ToInt64(KI_HSD_P_IN_TB.Text) * Convert.ToInt64(KI_HSD_S_IN_TB.Text)) / 100;
                    double KO_SaleStck = (Convert.ToInt64(KI_KO_P_IN_TB.Text) * Convert.ToInt64(KI_KO_S_IN_TB.Text)) / 100;
                    double MS_CStck = Convert.ToInt64(KI_MS_P_IN_TB.Text) - (Convert.ToInt64(KI_MS_T_TS_TB.Text) + MS_SaleStck);
                    double HOBC_CStck = Convert.ToInt64(KI_HOBC_P_IN_TB.Text) - (Convert.ToInt64(KI_HOBC_T_TS_TB.Text) + HOBC_SaleStck);
                    double HSD_CStck = Convert.ToInt64(KI_HSD_P_IN_TB.Text) - (Convert.ToInt64(KI_HSD_T_TS_TB.Text) + HSD_SaleStck);
                    double KO_CStck = Convert.ToInt64(KI_KO_P_IN_TB.Text) - (Convert.ToInt64(KI_KO_T_TS_TB.Text) + KO_SaleStck);
                    SQL_Queires SQ = new SQL_Queires();
                    con.Open();
                    string id = KemD_GV.SelectedRows[0].Cells[0].Value.ToString();
                    SqlDataAdapter Update = new SqlDataAdapter("UPDATE KeemariDepo SET Date = '" + KD_Date.Text + "', MS_Pur_Ltr= '" + KI_MS_P_IN_TB.Text + "', HOBC_Pur_Ltr= '" + KI_HOBC_P_IN_TB.Text + "', HSD_Pur_Ltr= '" + KI_HSD_P_IN_TB.Text + "'," +
                        "KO_Pur_Ltr= '" + KI_KO_P_IN_TB.Text + "', Pur_Tstock= '" + KI_TPSM_P_Stck_TB.Text + "', MS_Pur_Amnt= '" + KI_MS_P_Prc_TB.Text + "', HOBC_Pur_Amnt= '" + KI_HOBC_P_Prc_TB.Text + "', HSD_Pur_Amnt= '" + KI_HSD_P_Prc_TB.Text + "'," +
                        "KO_Pur_Amnt= '" + KI_KO_P_Prc_TB.Text + "', Pur_Tamount= '" + KI_TPSM_P_Prc_TB.Text + "', MS_Tran_Per= '" + KI_MS_T_IN_TB.Text + "', HOBC_Tran_Per= '" + KI_HOBC_T_IN_TB.Text + "', HSD_Tran_Per= '" + KI_HSD_T_IN_TB.Text + "'," +
                        "KO_Tran_Per= '" + KI_KO_T_IN_TB.Text + "', MS_Tran_Stck= '" + KI_MS_T_TS_TB.Text + "', HOBC_Tran_Stck= '" + KI_HOBC_T_TS_TB.Text + "', HSD_Tran_Stck= '" + KI_HSD_T_TS_TB.Text + "', KO_Tran_Stck= '" + KI_KO_T_TS_TB.Text + "'," +
                        "Tran_Tstock= '" + KI_TTS_T_Stck_TB.Text + "', MS_Sale_Per= '" + KI_MS_S_IN_TB.Text + "', HOBC_Sale_Per= '" + KI_HOBC_S_IN_TB.Text + "', HSD_Sale_Per= '" + KI_HSD_S_IN_TB.Text + "', KO_Sale_Per= '" + KI_KO_S_IN_TB.Text + "'," +
                        "MS_Sale_Amnt= '" + KI_MS_S_Prc_TB.Text + "', HOBC_Sale_Amnt= '" + KI_HOBC_S_Prc_TB.Text + "', HSD_Sale_Amnt= '" + KI_HSD_S_Prc_TB.Text + "', KO_Sale_Amnt= '" + KI_KO_S_Prc_TB.Text + "', Sale_Tamount= '" + KI_TSA_S_Amnt_TB.Text + "'," +
                        "SukhD_Stck= '" + KI_SD_Stck_TB.Text + "', DaulD_Stck= '" + KI_DD_Stck_TB.Text + "', QueD_Stck= '" + KI_QD_Stck_TB.Text + "', Depo_Tstock= '" + KI_Depo_TStck.Text + "', SukhD_Sale= '" + KI_SD_Sale_TB.Text + "'," +
                        "DaulD_Sale= '" + KI_DD_Sale_TB.Text + "', QueD_Sale= '" + KI_QD_Sale_TB.Text + "', Depo_TSale= '" + KI_Depo_TAmnt.Text + "', MS_ClosingS= '" + MS_CStck + "', HOBC_ClosingS= '" + HOBC_CStck + "'," +
                        "HSD_ClosingS= '" + HSD_CStck + "', KO_ClosingS= '" + KO_CStck + "' WHERE ID = '" + id + "'", con);
                    Update.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    SQ.ShowGVData("SELECT * FROM KeemariDepo", KemD_GV);
                    KID_Clr();
                    MessageBox.Show("Updated Successfully");
                }
                else
                {
                    MessageBox.Show("You cannot change date");
                }
            }
            finally
            {
                con.Close();
            }
        }

        private void KemD_GV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = KemD_GV.SelectedRows[0].Cells[0].Value.ToString();
                KD_Date.Text = KemD_GV.SelectedRows[0].Cells[1].Value.ToString();
                KI_MS_P_IN_TB.Text = KemD_GV.SelectedRows[0].Cells[2].Value.ToString();
                KI_HOBC_P_IN_TB.Text = KemD_GV.SelectedRows[0].Cells[3].Value.ToString();
                KI_HSD_P_IN_TB.Text = KemD_GV.SelectedRows[0].Cells[4].Value.ToString();
                KI_KO_P_IN_TB.Text = KemD_GV.SelectedRows[0].Cells[5].Value.ToString();
                KI_TPSM_P_Stck_TB.Text = KemD_GV.SelectedRows[0].Cells[6].Value.ToString();
                KI_MS_P_Prc_TB.Text = KemD_GV.SelectedRows[0].Cells[7].Value.ToString();
                KI_HOBC_P_Prc_TB.Text = KemD_GV.SelectedRows[0].Cells[8].Value.ToString();
                KI_HSD_P_Prc_TB.Text = KemD_GV.SelectedRows[0].Cells[9].Value.ToString();
                KI_KO_P_Prc_TB.Text = KemD_GV.SelectedRows[0].Cells[10].Value.ToString();
                KI_TPSM_P_Prc_TB.Text = KemD_GV.SelectedRows[0].Cells[11].Value.ToString();
                KI_MS_T_IN_TB.Text = KemD_GV.SelectedRows[0].Cells[12].Value.ToString();
                KI_HOBC_T_IN_TB.Text = KemD_GV.SelectedRows[0].Cells[13].Value.ToString();
                KI_HSD_T_IN_TB.Text = KemD_GV.SelectedRows[0].Cells[14].Value.ToString();
                KI_KO_T_IN_TB.Text = KemD_GV.SelectedRows[0].Cells[15].Value.ToString();
                KI_MS_T_TS_TB.Text = KemD_GV.SelectedRows[0].Cells[16].Value.ToString();
                KI_HOBC_T_TS_TB.Text = KemD_GV.SelectedRows[0].Cells[17].Value.ToString();
                KI_HSD_T_TS_TB.Text = KemD_GV.SelectedRows[0].Cells[18].Value.ToString();
                KI_KO_T_TS_TB.Text = KemD_GV.SelectedRows[0].Cells[19].Value.ToString();
                KI_TTS_T_Stck_TB.Text = KemD_GV.SelectedRows[0].Cells[20].Value.ToString();
                KI_MS_S_IN_TB.Text = KemD_GV.SelectedRows[0].Cells[21].Value.ToString();
                KI_HOBC_S_IN_TB.Text = KemD_GV.SelectedRows[0].Cells[22].Value.ToString();
                KI_HSD_S_IN_TB.Text = KemD_GV.SelectedRows[0].Cells[23].Value.ToString();
                KI_KO_S_IN_TB.Text = KemD_GV.SelectedRows[0].Cells[24].Value.ToString();
                KI_MS_S_Prc_TB.Text = KemD_GV.SelectedRows[0].Cells[25].Value.ToString();
                KI_HOBC_S_Prc_TB.Text = KemD_GV.SelectedRows[0].Cells[26].Value.ToString();
                KI_HSD_S_Prc_TB.Text = KemD_GV.SelectedRows[0].Cells[27].Value.ToString();
                KI_KO_S_Prc_TB.Text = KemD_GV.SelectedRows[0].Cells[28].Value.ToString();
                KI_TSA_S_Amnt_TB.Text = KemD_GV.SelectedRows[0].Cells[29].Value.ToString();
                KI_SD_Stck_TB.Text = KemD_GV.SelectedRows[0].Cells[30].Value.ToString();
                KI_DD_Stck_TB.Text = KemD_GV.SelectedRows[0].Cells[31].Value.ToString();
                KI_QD_Stck_TB.Text = KemD_GV.SelectedRows[0].Cells[32].Value.ToString();
                KI_Depo_TStck.Text = KemD_GV.SelectedRows[0].Cells[33].Value.ToString();
                KI_SD_Sale_TB.Text = KemD_GV.SelectedRows[0].Cells[34].Value.ToString();
                KI_DD_Sale_TB.Text = KemD_GV.SelectedRows[0].Cells[35].Value.ToString();
                KI_QD_Sale_TB.Text = KemD_GV.SelectedRows[0].Cells[36].Value.ToString();
                KI_Depo_TAmnt.Text = KemD_GV.SelectedRows[0].Cells[37].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void KI_Del_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SQL_Queires SQ = new SQL_Queires();
                    string id = KemD_GV.SelectedRows[0].Cells[0].Value.ToString();
                    SQ.DeleteData("DELETE FROM KeemariDepo WHERE ID = '" + id + "';");
                    SQ.ShowGVData("Select * FROM KeemariDepo", KemD_GV);
                    KID_Clr();
                }
            }
            catch (Exception)
            {
            }
        }
        public void KD_TextChange()
        {
            try
            {
                KI_MS_P_Prc_TB.Text = (Convert.ToInt64(KI_MS_P_IN_TB.Text) * 90).ToString();
                KI_HOBC_P_Prc_TB.Text = (Convert.ToInt64(KI_HOBC_P_IN_TB.Text) * 100).ToString();
                KI_HSD_P_Prc_TB.Text = (Convert.ToInt64(KI_HSD_P_IN_TB.Text) * 115).ToString();
                KI_KO_P_Prc_TB.Text = (Convert.ToInt64(KI_KO_P_IN_TB.Text) * 110).ToString();
                TotalPurStckKemInst();
                TotalPurAmntKemInst();
                KI_MS_T_TS_TB.Text = ((Convert.ToInt64(KI_MS_P_IN_TB.Text) * Convert.ToInt64(KI_MS_T_IN_TB.Text)) / 100).ToString();
                KI_HOBC_T_TS_TB.Text = ((Convert.ToInt64(KI_HOBC_P_IN_TB.Text) * Convert.ToInt64(KI_HOBC_T_IN_TB.Text)) / 100).ToString();
                KI_HSD_T_TS_TB.Text = ((Convert.ToInt64(KI_HSD_P_IN_TB.Text) * Convert.ToInt64(KI_HSD_T_IN_TB.Text)) / 100).ToString();
                KI_KO_T_TS_TB.Text = ((Convert.ToInt64(KI_KO_P_IN_TB.Text) * Convert.ToInt64(KI_KO_T_IN_TB.Text)) / 100).ToString();
                TotalTranStckKemInst();
                KI_MS_S_Prc_TB.Text = (((Convert.ToInt64(KI_MS_P_IN_TB.Text) * Convert.ToInt64(KI_MS_S_IN_TB.Text)) / 100) * 98).ToString();
                KI_HOBC_S_Prc_TB.Text = (((Convert.ToInt64(KI_HOBC_P_IN_TB.Text) * Convert.ToInt64(KI_HOBC_S_IN_TB.Text)) / 100) * 116).ToString();
                KI_HSD_S_Prc_TB.Text = (((Convert.ToInt64(KI_HSD_P_IN_TB.Text) * Convert.ToInt64(KI_HSD_S_IN_TB.Text)) / 100) * 125).ToString();
                KI_KO_S_Prc_TB.Text = (((Convert.ToInt64(KI_KO_P_IN_TB.Text) * Convert.ToInt64(KI_KO_S_IN_TB.Text)) / 100) * 120).ToString();
                TotalSaleAmntKemInst();
                DepoPDStckKemInst();
                DepoPDSaleKemInst();
                DepoTotStckKemInst();
                DepoTotSaleKemInst();
            }
            catch (Exception)
            {
            }
        }

        private void KI_MS_P_IN_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (KI_MS_P_IN_TB.Text == String.Empty)
                {
                    KI_MS_P_Prc_TB.Clear();
                }
                KI_MS_P_Prc_TB.Text = (Convert.ToInt64(KI_MS_P_IN_TB.Text) * 90).ToString();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_HOBC_P_IN_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (KI_HOBC_P_IN_TB.Text == String.Empty)
                {
                    KI_HOBC_P_Prc_TB.Clear();
                }
                KI_HOBC_P_Prc_TB.Text = (Convert.ToInt64(KI_HOBC_P_IN_TB.Text) * 100).ToString();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_HSD_P_IN_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (KI_HSD_P_IN_TB.Text == String.Empty)
                {
                    KI_HSD_P_Prc_TB.Clear();
                }
                KI_HSD_P_Prc_TB.Text = (Convert.ToInt64(KI_HSD_P_IN_TB.Text) * 115).ToString();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_KO_P_IN_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (KI_KO_P_IN_TB.Text == String.Empty)
                {
                    KI_KO_P_Prc_TB.Clear();
                    KI_TPSM_P_Stck_TB.Clear();
                    KI_TPSM_P_Prc_TB.Clear();
                }
                KI_KO_P_Prc_TB.Text = (Convert.ToInt64(KI_KO_P_IN_TB.Text) * 110).ToString();
                TotalPurStckKemInst();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_MS_T_IN_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (KI_MS_T_IN_TB.Text == String.Empty)
                {
                    KI_MS_T_TS_TB.Clear();
                }
                KI_MS_T_TS_TB.Text = ((Convert.ToInt64(KI_MS_P_IN_TB.Text) * Convert.ToInt64(KI_MS_T_IN_TB.Text)) / 100).ToString();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_HOBC_T_IN_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (KI_HOBC_T_IN_TB.Text == String.Empty)
                {
                    KI_HOBC_T_TS_TB.Clear();
                }
                KI_HOBC_T_TS_TB.Text = ((Convert.ToInt64(KI_HOBC_P_IN_TB.Text) * Convert.ToInt64(KI_HOBC_T_IN_TB.Text)) / 100).ToString();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_HSD_T_IN_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (KI_HSD_T_IN_TB.Text == String.Empty)
                {
                    KI_HSD_T_TS_TB.Clear();
                }
                KI_HSD_T_TS_TB.Text = ((Convert.ToInt64(KI_HSD_P_IN_TB.Text) * Convert.ToInt64(KI_HSD_T_IN_TB.Text)) / 100).ToString();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_KO_T_IN_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (KI_KO_T_IN_TB.Text == String.Empty)
                {
                    KI_KO_T_TS_TB.Clear();
                    KI_TTS_T_Stck_TB.Clear();
                    KI_DD_Sale_TB.Clear();
                    KI_DD_Stck_TB.Clear();
                    KI_SD_Sale_TB.Clear();
                    KI_SD_Stck_TB.Clear();
                    KI_QD_Sale_TB.Clear();
                    KI_QD_Stck_TB.Clear();
                    KI_Depo_TAmnt.Clear();
                    KI_Depo_TStck.Clear();
                }
                KI_KO_T_TS_TB.Text = ((Convert.ToInt64(KI_KO_P_IN_TB.Text) * Convert.ToInt64(KI_KO_T_IN_TB.Text)) / 100).ToString();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_MS_S_IN_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (KI_MS_S_IN_TB.Text == String.Empty)
                {
                    KI_MS_S_Prc_TB.Clear();
                }
                KI_MS_S_Prc_TB.Text = (((Convert.ToInt64(KI_MS_P_IN_TB.Text) * Convert.ToInt64(KI_MS_S_IN_TB.Text)) / 100) * 98).ToString();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_HOBC_S_IN_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (KI_HOBC_S_IN_TB.Text == String.Empty)
                {
                    KI_HOBC_S_Prc_TB.Clear();
                }
                KI_HOBC_S_Prc_TB.Text = (((Convert.ToInt64(KI_HOBC_P_IN_TB.Text) * Convert.ToInt64(KI_HOBC_S_IN_TB.Text)) / 100) * 116).ToString();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_HSD_S_IN_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (KI_HSD_S_IN_TB.Text == String.Empty)
                {
                    KI_HSD_S_Prc_TB.Clear();
                }
                KI_HSD_S_Prc_TB.Text = (((Convert.ToInt64(KI_HSD_P_IN_TB.Text) * Convert.ToInt64(KI_HSD_S_IN_TB.Text)) / 100) * 125).ToString();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_KO_S_IN_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (KI_KO_S_IN_TB.Text == String.Empty)
                {
                    KI_KO_S_Prc_TB.Clear();
                    KI_TSA_S_Amnt_TB.Clear();
                }
                KI_KO_S_Prc_TB.Text = (((Convert.ToInt64(KI_KO_P_IN_TB.Text) * Convert.ToInt64(KI_KO_S_IN_TB.Text)) / 100) * 120).ToString();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_KO_P_Prc_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TotalPurAmntKemInst();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_KO_T_TS_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TotalTranStckKemInst();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_KO_S_Prc_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TotalSaleAmntKemInst();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_TTS_T_Stck_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DepoPDStckKemInst();
                DepoPDSaleKemInst();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_QD_Stck_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DepoTotStckKemInst();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_QD_Sale_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DepoTotSaleKemInst();
                KD_TextChange();
            }
            catch (Exception)
            {
            }
        }

        private void KI_Rest_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                KID_Clr();
            }
            catch (Exception)
            {
            }
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
        
    }
}
