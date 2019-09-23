using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReturnInspection
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            SajetCommon.SetLanguageControl(this);
            RandomNum();
            tSN.Focus();
        }

        private void RandomNum()
        {
            string dateCode = "RE" + DateTime.Now.Year.ToString().Substring(2) + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');
            DataSet data = ClientUtils.ExecuteSQL("select sajet.SEQ_RETURN_QC_LOT.nextval from dual");
            dateCode = dateCode + data.Tables[0].Rows[0][0].ToString().PadLeft(4, '0');
            textBox1.Text = dateCode;
        }

        private void tSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)Keys.Enter) return;
            List<Object[]> param = new List<object[]>();
            param.Add(new object[] { ParameterDirection.Input, OracleType.VarChar, "C_SN", tSN.Text.Trim() });
            param.Add(new object[] { ParameterDirection.Output, OracleType.VarChar, "C_WO", "" });
            param.Add(new object[] { ParameterDirection.Output, OracleType.VarChar, "C_MATERIAL", "" });
            param.Add(new object[] { ParameterDirection.Output, OracleType.VarChar, "C_QTY", "" });
            param.Add(new object[] { ParameterDirection.Output, OracleType.VarChar, "C_TYPE", "" });
            param.Add(new object[] { ParameterDirection.Output, OracleType.VarChar, "TRES", "" });
            DataSet dataSet = ClientUtils.ExecuteProc("sajet.G_QC_RETURN_CHECK", param.ToArray());
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                if (dataSet.Tables[0].Rows[0]["TRES"].ToString() != "OK")
                {
                    SajetCommon.Show_Message(dataSet.Tables[0].Rows[0]["TRES"].ToString(), 0);
                    tSN.Focus();
                    tSN.SelectAll();
                    return;
                }
                else
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["SN_NO"].Value = tSN.Text.Trim();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["WONO"].Value = dataSet.Tables[0].Rows[0]["C_WO"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Material_No"].Value = dataSet.Tables[0].Rows[0]["C_MATERIAL"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["qty"].Value = dataSet.Tables[0].Rows[0]["C_QTY"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["type"].Value = dataSet.Tables[0].Rows[0]["C_TYPE"].ToString();
                    tSN.Focus();
                    tSN.SelectAll();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sSQL = string.Empty;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sSQL = string.Format(@"Insert into SAJET.G_QC_CHECK_RETURN
                                        VALUES('" + textBox1.Text.Trim() + "'," +
                                        "'" + dataGridView1.Rows[i].Cells["SN_NO"].Value.ToString() + "'," +
                                        "'Y'," +
                                        "'" + ClientUtils.UserPara1 + "',SYSDATE," +
                                        "'" + richTextBox1.Text.Trim() + "');");
                sb.AppendLine(sSQL);
            }
            try
            {
                sSQL = string.Format(@"begin {0} end;", sb.ToString());
                ClientUtils.ExecuteSQL(sSQL);
            }
            catch (Exception ex)
            {
                SajetCommon.Show_Message(ex.Message, 0);
                return;
            }
            dataGridView1.Rows.Clear();
            tSN.Focus();
            tSN.SelectAll();
            RandomNum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sSQL = string.Empty;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sSQL = string.Format(@"Insert into SAJET.G_QC_CHECK_RETURN
                                        VALUES('" + textBox1.Text.Trim() + "'," +
                                        "'" + dataGridView1.Rows[i].Cells["SN_NO"].Value.ToString() + "'," +
                                        "'N'," +
                                        "'" + ClientUtils.UserPara1 + "',SYSDATE," +
                                        "'" + richTextBox1.Text.Trim() + "');");
                sb.AppendLine(sSQL);
            }
            try
            {
                sSQL = string.Format(@"begin {0} end;", sb.ToString());
                ClientUtils.ExecuteSQL(sSQL);
            }
            catch (Exception ex)
            {
                SajetCommon.Show_Message(ex.Message, 0);
                return;
            }
            dataGridView1.Rows.Clear();
            tSN.Focus();
            tSN.SelectAll();
            RandomNum();
        }
    }
}
