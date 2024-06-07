using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ThietKeSan.SingleData;

namespace ThietKeSan.View
{
    public partial class Frm_TaiTrong : Form
    {
        public Frm_TaiTrong()
        {
            InitializeComponent();
        }

        private void btn_Themtt_Click(object sender, EventArgs e)
        {
            var dlg = Singleton.Instance.FormData.FormTinhTai.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                CommonData.lst_clsTinhtaiTam.Add(CommonData.clsTinhTai);
                RefreshTT();
            }
        }
        private void RefreshHT()
        {
            dgv_Hoattai.Rows.Clear();
            foreach (var item in CommonData.lst_clsHoattaiTam)
            {
                dgv_Hoattai.Rows.Add(item.tenhoattai, item.Pb);
            }
        }
        private void RefreshTT()
        {
            dgv_Tinhtai.Rows.Clear();
            foreach (var item in CommonData.lst_clsTinhtaiTam)
            {
                dgv_Tinhtai.Rows.Add(item.tentinhtai, item.gb);
            }
        }
        private void OnOpenForm()
        {
            dgv_Tinhtai.Rows.Clear();
            CommonData.lst_clsTinhtaiTam.Clear();
            foreach (var item in CommonData.lst_clsTinhtai)
            {
                dgv_Tinhtai.Rows.Add(item.tentinhtai, item.gb);
                CommonData.lst_clsTinhtaiTam.Add(item);
            }
            dgv_Hoattai.Rows.Clear();
            CommonData.lst_clsHoattaiTam.Clear();
            foreach (var item in CommonData.lst_clsHoattai)
            {
                dgv_Hoattai.Rows.Add(item.tenhoattai, item.Pb);
                CommonData.lst_clsHoattaiTam.Add(item);
            }
        }
        private void btn_xoatt_Click(object sender, EventArgs e)
        {
            var cls_tt = CommonData.lst_clsTinhtaiTam.Where(k => k.tentinhtai == dgv_Tinhtai.CurrentRow.Cells["Column1"].Value.ToString()).First();
            if (CommonData.lst_clsTinhtaiTam.Contains(cls_tt))
            {
                CommonData.lst_clsTinhtaiTam.Remove(cls_tt);
                RefreshTT();
            }
        }

        private void btn_themht_Click(object sender, EventArgs e)
        {
            var dlg = Singleton.Instance.FormData.FormHoatTai.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                CommonData.lst_clsHoattaiTam.Add(CommonData.clsHoattai);
                RefreshHT();
            }
        }

        private void Frm_TaiTrong_Load(object sender, EventArgs e)
        {
            OnOpenForm();
        }

        private void btn_xoaht_Click(object sender, EventArgs e)
        {
            var cls_ht = CommonData.lst_clsHoattaiTam.Where(k => k.tenhoattai == dgv_Hoattai.CurrentRow.Cells["Column1"].Value.ToString()).First();
            if (CommonData.lst_clsHoattaiTam.Contains(cls_ht))
            {
                CommonData.lst_clsHoattaiTam.Remove(cls_ht);
                RefreshHT();
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            CommonData.lst_clsTinhtai.Clear();
            CommonData.lst_clsTinhtai.AddRange(CommonData.lst_clsTinhtaiTam);
            CommonData.lst_clsHoattai.Clear();
            CommonData.lst_clsHoattai.AddRange(CommonData.lst_clsHoattaiTam);
            MessageBox.Show("Lưu tải trọng thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
