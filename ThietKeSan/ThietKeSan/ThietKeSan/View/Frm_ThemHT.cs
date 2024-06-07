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
    public partial class Frm_ThemHT : Form
    {
        public Frm_ThemHT()
        {
            InitializeComponent();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            CommonData.clsHoattai = new clsHoattai();
            CommonData.clsHoattai.tenhoattai = txt_tenHoatTai.Text;
            CommonData.clsHoattai.HTTC = Convert.ToDouble(txt_HTTC.Text);
            CommonData.clsHoattai.HSTC = Convert.ToDouble(txt_HSTC.Text);
            foreach (var item in CommonData.lst_clsHoattai)
            {
                if (item.tenhoattai == txt_tenHoatTai.Text)
                {
                    MessageBox.Show("Hoạt tải đã tồn tại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            foreach (var item in CommonData.lst_clsHoattaiTam)
            {
                if (item.tenhoattai == txt_tenHoatTai.Text)
                {
                    MessageBox.Show("Hoạt tải đã tồn tại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void Frm_ThemHT_Load(object sender, EventArgs e)
        {
            txt_tenHoatTai.Focus();       
            cbb_loaiphong.SelectedIndex = 0;
            txt_tenHoatTai.Text = cbb_loaiphong.Text;
        }

        private void cbb_loaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_loaiphong.SelectedIndex)
            {
                case 0:
                    txt_HTTC.Text = "2";
                    txt_HSTC.Text = "1.2";
                    break;
                case 1:
                    txt_HTTC.Text = "1,5";
                    txt_HSTC.Text = "1.3";
                    break;
                case 2:
                    txt_HTTC.Text = "1,5";
                    txt_HSTC.Text = "1.3";
                    break;
                case 3:
                    txt_HTTC.Text = "2";
                    txt_HSTC.Text = "1.2";
                    break;
                case 4:
                    txt_HTTC.Text = "1,5";
                    txt_HSTC.Text = "1.3";
                    break;
                case 5:
                    txt_HTTC.Text = "3";
                    txt_HSTC.Text = "1.2";
                    break;
                case 6:
                    txt_HTTC.Text = "2";
                    txt_HSTC.Text = "1.2";
                    break;
                case 7:
                    txt_HTTC.Text = "7,5";
                    txt_HSTC.Text = "1.2";
                    break;
                case 8:
                    txt_HTTC.Text = "4";
                    txt_HSTC.Text = "1.2";
                    break;
                case 9:
                    txt_HTTC.Text = "2";
                    txt_HSTC.Text = "1.2";
                    break;
                case 10:
                    txt_HTTC.Text = "3";
                    txt_HSTC.Text = "1.2";
                    break;
                case 11:
                    txt_HTTC.Text = "4";
                    txt_HSTC.Text = "1.2";
                    break;
                case 12:
                    txt_HTTC.Text = "5";
                    txt_HSTC.Text = "1.2";
                    break;
                case 13:
                    txt_HTTC.Text = "7.5";
                    txt_HSTC.Text = "1.2";
                    break;
                case 14:
                    txt_HTTC.Text = "2";
                    txt_HSTC.Text = "1.2";
                    break;
                case 15:
                    txt_HTTC.Text = "4";
                    txt_HSTC.Text = "1.2";
                    break;
                case 16:
                    txt_HTTC.Text = "3";
                    txt_HSTC.Text = "1.2";
                    break;
                case 17:
                    txt_HTTC.Text = "4";
                    txt_HSTC.Text = "1.2";
                    break;
                case 18:
                    txt_HTTC.Text = "5";
                    txt_HSTC.Text = "1.2";
                    break;
            }
            txt_tenHoatTai.Text = cbb_loaiphong.Text;
        }
    }
}
