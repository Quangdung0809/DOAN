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
    public partial class Frm_ThemLopVatLieu : Form
    {
        public Frm_ThemLopVatLieu()
        {
            InitializeComponent();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            CommonData.clsLopVatLieu = new clsLopVatLieu();
            CommonData.clsLopVatLieu.lopvl = txt_ten.Text;
            CommonData.clsLopVatLieu.beday = Convert.ToDouble(txt_beday.Text);
            CommonData.clsLopVatLieu.TrongLuong = Convert.ToDouble(txt_tlr.Text);
            CommonData.clsLopVatLieu.HSVT = Convert.ToDouble(txt_hs.Text);
        }

        private void Frm_ThemLopVatLieu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
