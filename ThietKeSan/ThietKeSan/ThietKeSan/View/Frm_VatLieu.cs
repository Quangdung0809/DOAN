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
    public partial class Frm_VatLieu : Form
    {
        public Frm_VatLieu()
        {
            InitializeComponent();
        }

        private void Frm_VatLieu_Load(object sender, EventArgs e)
        {
            cbb_betong.Text = "B25";
            cbb_thep.Text = "CB300-V";
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

            CommonData.BT = cbb_betong.Text;
            CommonData.Rb = System.Convert.ToDouble(this.txt_Rb.Text);
            CommonData.Rbt = System.Convert.ToDouble(this.txt_Rbt.Text);
            CommonData.Eb = System.Convert.ToDouble(this.txt_Eb.Text);
            CommonData.TH = cbb_thep.Text;
            CommonData.Rs = System.Convert.ToDouble(this.txt_Rs.Text);
            CommonData.Rsc = System.Convert.ToDouble(this.txt_Rsc.Text);
            CommonData.Es = System.Convert.ToDouble(this.txt_Es.Text);

            MessageBox.Show("Lưu dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cbb_betong_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_betong.SelectedIndex)
            {
                case 0:
                    txt_Rb.Text = 8500.ToString();
                    txt_Rbt.Text = 750.ToString();
                    txt_Eb.Text = 23000000.ToString();
                    break;
                case 1:
                    txt_Rb.Text = 11500.ToString();
                    txt_Rbt.Text = 900.ToString();
                    txt_Eb.Text = 27000000.ToString();
                    break;
                case 2:
                    txt_Rb.Text = 14500.ToString();
                    txt_Rbt.Text = 1050.ToString();
                    txt_Eb.Text = 30000000.ToString();
                    break;
                case 3:
                    txt_Rb.Text = 17000.ToString();
                    txt_Rbt.Text = 1200.ToString();
                    txt_Eb.Text = 32500000.ToString();
                    break;
                case 4:
                    txt_Rb.Text = 19500.ToString();
                    txt_Rbt.Text = 1300.ToString();
                    txt_Eb.Text = 34500000.ToString();
                    break;
                case 5:
                    txt_Rb.Text = 22000.ToString();
                    txt_Rbt.Text = 1400.ToString();
                    txt_Eb.Text = 36000000.ToString();
                    break;
            }
        }

        private void cbb_thep_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_thep.SelectedIndex)
            {
                case 0:
                    txt_Rs.Text = 210000.ToString();
                    txt_Rsc.Text = 210000.ToString();
                    txt_Es.Text = 210000000.ToString();
                    break;
                case 1:
                    txt_Rs.Text = 260000.ToString();
                    txt_Rsc.Text = 260000.ToString();
                    txt_Es.Text = 210000000.ToString();
                    break;
                case 2:
                    txt_Rs.Text = 350000.ToString();
                    txt_Rsc.Text = 350000.ToString();
                    txt_Es.Text = 200000000.ToString();
                    break;
                case 3:
                    txt_Rs.Text = 435000.ToString();
                    txt_Rsc.Text = 4355000.ToString();
                    txt_Es.Text = 200000000.ToString();
                    break;
            }
        }
    }
}
