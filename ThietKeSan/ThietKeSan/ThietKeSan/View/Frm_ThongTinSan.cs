using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeSan.View
{
    public partial class Frm_ThongTinSan : Form
    {
        public Frm_ThongTinSan()
        {
            InitializeComponent();
        }

        private void btn_chonsan_Click(object sender, EventArgs e)
        {
            CommonData.DK = "Pick";
            Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_tenosan.Text)) { MessageBox.Show("Chưa chọn sàn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if(string.IsNullOrEmpty(cbb_tinhtai.Text)) { MessageBox.Show("Chưa chọn tĩnh tải!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (string.IsNullOrEmpty(cbb_hoattai.Text)) { MessageBox.Show("Chưa chọn hoạt tải !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (CommonData.clsSan != null)
            {
                CommonData.clsSan.gb = Convert.ToDouble(cbb_tinhtai.SelectedValue);
                CommonData.clsSan.pb = Convert.ToDouble(cbb_hoattai.SelectedValue);
                CommonData.clsSan.TT = cbb_tinhtai.Text;
                CommonData.clsSan.HT = cbb_hoattai.Text;
                if (CommonData.lst_clssan.Count > 0)
                {
                    int dem = 0;
                    foreach (var item in CommonData.lst_clssan)
                    {
                        if (item.ID.ToString() == CommonData.clsSan.ID.ToString())
                        {
                            item.a = double.Parse(txt_a.Text);
                            CommonData.lst_clssan.Insert(CommonData.lst_clssan.IndexOf(item), CommonData.clsSan);
                            CommonData.lst_clssan.Remove(item);
                            dem += 1;
                            break;
                        }       
                    }
                    if (dem == 0)
                    {
                        CommonData.lst_clssan.Add(CommonData.clsSan);
                    }
                }
                else
                {
                    CommonData.lst_clssan.Add(CommonData.clsSan);
                }
            }
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonData.DK = "Close";
            Close();
        }

        private void Frm_ThongTinSan_Load(object sender, EventArgs e)
        {
            #region Combobox data
            var dtTT = new DataTable();
            dtTT.Columns.AddRange(new DataColumn[] { new DataColumn("tentinhtai", typeof(string)), new DataColumn("gb", typeof(double)) });
            dtTT.Rows.Clear();
            if (CommonData.lst_clsTinhtai.Count != 0)
            {
                foreach (var item in CommonData.lst_clsTinhtai)
                {
                    dtTT.Rows.Add(item.tentinhtai, item.gb);
                }
                cbb_tinhtai.DisplayMember = "tentinhtai";
                cbb_tinhtai.ValueMember = "gb";
                cbb_tinhtai.DataSource = dtTT;
            }
            var dtHT = new DataTable();
            dtHT.Columns.AddRange(new DataColumn[] { new DataColumn("tenhoattai", typeof(string)), new DataColumn("Pb", typeof(double)) });
            dtHT.Rows.Clear();
            if (CommonData.lst_clsHoattai.Count != 0)
            {
                foreach (var item in CommonData.lst_clsHoattai)
                {
                    dtHT.Rows.Add(item.tenhoattai, item.Pb);
                }
                cbb_hoattai.DisplayMember = "tenhoattai";
                cbb_hoattai.ValueMember = "Pb";
                cbb_hoattai.DataSource = dtHT;
            }
            #endregion
            if (CommonData.clsSan == null) { label14.Text = "";  return; }
            txt_Hs.Text = CommonData.clsSan.Hs.ToString();
            txt_L1.Text = CommonData.clsSan.L1.ToString();
            txt_L2.Text = CommonData.clsSan.L2.ToString();
            txt_tenosan.Text = CommonData.clsSan.tensan;
            label14.Text = CommonData.clsSan.ID.ToString();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            foreach (var item in CommonData.lst_clssan)
            {
                if (item.ID.ToString() == dgv_osan.CurrentRow.Cells[0].Value.ToString())
                {
                    CommonData.lst_clssan.Remove(item);
                    break;
                }
            }
            RefreshData();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            dgv_osan.Rows.Clear();
            for (int i = 0; i < CommonData.lst_clssan.Count; i++)
                dgv_osan.Rows.Add(CommonData.lst_clssan[i].ID, CommonData.lst_clssan[i].tensan, CommonData.lst_clssan[i].sodo,
                    CommonData.lst_clssan[i].L1, CommonData.lst_clssan[i].L2, CommonData.lst_clssan[i].TyLe,
                    CommonData.lst_clssan[i].Hs, CommonData.lst_clssan[i].Ho, CommonData.lst_clssan[i].qb);
        }
    }
}
