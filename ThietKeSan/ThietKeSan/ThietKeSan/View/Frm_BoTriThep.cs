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
    public partial class Frm_BoTriThep : Form
    {
        public Frm_BoTriThep()
        {
            InitializeComponent();
        }

        private void Frm_BoTriThep_Load(object sender, EventArgs e)
        {
            cbb_San.Items.Clear();
            foreach (var item in CommonData.lst_clssan)
            {
                cbb_San.Items.Add(item.tensan + " - " + item.ID.ToString());
            }
            if (CommonData.lst_clssan?.Count > 0)
            {
                cbb_San.SelectedIndex = 0;
                var clssan = CommonData.lst_clssan.Where(k => (k.tensan + " - " + k.ID.ToString()) == cbb_San.Text).First();
                if (clssan.Status == StatusPlaceRebar.Placed)
                {
                    cbbΦ1.SelectedItem = clssan.Φ1;
                    cbbΦ2.SelectedItem = clssan.Φ2;
                    cbbΦI.SelectedItem = clssan.ΦI;
                    cbbΦII.SelectedItem = clssan.ΦII;
                }
                else
                {
                    cbbΦ1.SelectedIndex = 0;
                    cbbΦ2.SelectedIndex = 0;
                    cbbΦI.SelectedIndex = 0;
                    cbbΦII.SelectedIndex = 0;
                }              
            }
        }

        private void cbb_San_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            dgv_tinhthep.Rows.Clear();
            foreach (var item in CommonData.lst_clssan)
            {
                if (cbb_San.Text.Contains(item.ID.ToString()))
                {
                    labelID.Text = item.ID.ToString();
                    dgv_tinhthep.Rows.Add(item.ID, "M1", item.M1, item.alpha1, item.ζ1, item.As1, item.μ1, item.Status == StatusPlaceRebar.Placed ? "Đã bố trí" : "Chưa bố trí");
                    dgv_tinhthep.Rows.Add(item.ID, "M2", item.M2, item.alpha2, item.ζ2, item.As2, item.μ2, item.Status == StatusPlaceRebar.Placed ? "Đã bố trí" : "Chưa bố trí");
                    dgv_tinhthep.Rows.Add(item.ID, "MI", item.MI, item.alphaI, item.ζI, item.AsI, item.μI, item.Status == StatusPlaceRebar.Placed ? "Đã bố trí" : "Chưa bố trí");
                    dgv_tinhthep.Rows.Add(item.ID, "MII", item.MII, item.alphaII, item.ζII, item.AsII, item.μII, item.Status == StatusPlaceRebar.Placed ? "Đã bố trí" : "Chưa bố trí");
                    cbbΦ1.Text = item.Φ1.ToString();
                    cbbΦ2.Text = item.Φ2.ToString();
                    cbbΦI.Text = item.ΦI.ToString();
                    cbbΦII.Text = item.ΦII.ToString();
                    txta1.Text = item.kc1.ToString();
                    txta2.Text = item.kc2.ToString();
                    txtaI.Text = item.kcI.ToString();
                    txtaII.Text = item.kcII.ToString();
                    break;
                }
            }
        }
        private void btn_LuuThep_Click(object sender, EventArgs e)
        {
            foreach (var item in CommonData.lst_clssan)
            {
                if (cbb_San.Text.Contains(item.ID.ToString()))
                {
                    item.tinh_thep4canh(Convert.ToInt32(cbbΦ1.Text), Convert.ToDouble(txta1.Text), Convert.ToInt32(cbbΦ2.Text), Convert.ToDouble(txta2.Text), Convert.ToInt32(cbbΦI.Text), Convert.ToDouble(txtaI.Text), Convert.ToInt32(cbbΦII.Text), Convert.ToDouble(txtaII.Text));
                    item.Status = StatusPlaceRebar.Placed;
                    RefreshData();
                    MessageBox.Show("Lưu thép thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        private void cbbΦ1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double n;
            if (string.IsNullOrEmpty(cbb_San.Text)) { MessageBox.Show("Chưa chọn sàn !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            clsSan clsSan = null;
            foreach (var item in CommonData.lst_clssan)
            {
                if (cbb_San.Text.Contains(item.ID.ToString()))
                {
                    clsSan = item;
                }
            }
            switch (cbbΦ1.Text)
            {
                case "6":
                    txta1.Text = Math.Round(28.27d * 1000d / clsSan.As1, 0).ToString();
                    n = clsSan.As1 / 28.27d;
                    txtAsch1.Text = (n * 28.27d).ToString();
                    break;
                case "8":
                    txta1.Text = Math.Round(50.27d * 1000d / clsSan.As1, 0).ToString();
                    n = clsSan.As1 / 50.27d;
                    txtAsch1.Text = (n * 50.27d).ToString();
                    break;
                case "10":
                    txta1.Text = Math.Round(78.54d * 1000d / clsSan.As1, 0).ToString();
                    n = clsSan.As1 / 78.54d;
                    txtAsch1.Text = (n * 78.54d).ToString();
                    break;
                case "12":
                    txta1.Text = Math.Round(113.1d * 1000d / clsSan.As1, 0).ToString();
                    n = clsSan.As1 / 113.1d;
                    txtAsch1.Text = (n * 113.1d).ToString();
                    break;
                case "14":
                    txta1.Text = Math.Round(113.1d * 1000d / clsSan.As1, 0).ToString();
                    n = clsSan.As1 / 153.9d;
                    txtAsch1.Text = (n * 153.9d).ToString();
                    break;
            }
        }

        private void cbbΦ2_SelectedIndexChanged(object sender, EventArgs e)
        {
            double n;
            if (string.IsNullOrEmpty(cbb_San.Text)) { MessageBox.Show("Chưa chọn sàn !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            clsSan clsSan = null;
            foreach (var item in CommonData.lst_clssan)
            {
                if (cbb_San.Text.Contains(item.ID.ToString()))
                {
                    clsSan = item;
                }
            }
            switch (cbbΦ2.Text)
            {
                case "6":
                    txta2.Text = Math.Round(28.27d * 1000d / clsSan.As2, 0).ToString();
                    n = clsSan.As2 / 28.27d;
                    txtAsch2.Text = (n * 28.27d).ToString();
                    break;
                case "8":
                    txta2.Text = Math.Round(50.27d * 1000d / clsSan.As2, 0).ToString();
                    n = clsSan.As2 / 50.27d;
                    txtAsch2.Text = (n * 50.27d).ToString();
                    break;
                case "10":
                    txta2.Text = Math.Round(78.54d * 1000d / clsSan.As2, 0).ToString();
                    n = clsSan.As2 / 78.54d;
                    txtAsch2.Text = (n * 78.54d).ToString();
                    break;
                case "12":
                    txta2.Text = Math.Round(113.1d * 1000d / clsSan.As2, 0).ToString();
                    n = clsSan.As2 / 113.1d;
                    txtAsch2.Text = (n * 113.1d).ToString();
                    break;
                case "14":
                    txta2.Text = Math.Round(113.1d * 1000d / clsSan.As2, 0).ToString();
                    n = clsSan.As2 / 153.9d;
                    txtAsch2.Text = (n * 153.9d).ToString();
                    break;
            }
        }

        private void cbbΦI_SelectedIndexChanged(object sender, EventArgs e)
        {
            double n;
            if (string.IsNullOrEmpty(cbb_San.Text)) { MessageBox.Show("Chưa chọn sàn !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            clsSan clsSan = null;
            foreach (var item in CommonData.lst_clssan)
            {
                if (cbb_San.Text.Contains(item.ID.ToString()))
                {
                    clsSan = item;
                }
            }
            switch (cbbΦI.Text)
            {
                case "6":
                    txtaI.Text = Math.Round(28.27d * 1000d / clsSan.AsI, 0).ToString();
                    n = clsSan.AsI / 28.27d;
                    txtAschI.Text = (n * 28.27d).ToString();
                    break;
                case "8":
                    txtaI.Text = Math.Round(50.27d * 1000d / clsSan.AsI, 0).ToString();
                    n = clsSan.AsI / 50.27d;
                    txtAschI.Text = (n * 50.27d).ToString();
                    break;
                case "10":
                    txtaI.Text = Math.Round(78.54d * 1000d / clsSan.AsI, 0).ToString();
                    n = clsSan.AsI / 78.54d;
                    txtAschI.Text = (n * 78.54d).ToString();
                    break;
                case "12":
                    txtaI.Text = Math.Round(113.1d * 1000d / clsSan.AsI, 0).ToString();
                    n = clsSan.AsI / 113.1d;
                    txtAschI.Text = (n * 113.1d).ToString();
                    break;
                case "14":
                    txtaI.Text = Math.Round(113.1d * 1000d / clsSan.AsI, 0).ToString();
                    n = clsSan.AsI / 153.9d;
                    txtAschI.Text = (n * 153.9d).ToString();
                    break;
            }
        }

        private void cbbΦII_SelectedIndexChanged(object sender, EventArgs e)
        {
            double n;
            if (string.IsNullOrEmpty(cbb_San.Text)) { MessageBox.Show("Chưa chọn sàn !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            clsSan clsSan = null;
            foreach (var item in CommonData.lst_clssan)
            {
                if (cbb_San.Text.Contains(item.ID.ToString()))
                {
                    clsSan = item;
                }
            }
            switch (cbbΦII.Text)
            {
                case "6":
                    txtaII.Text = Math.Round(28.27d * 1000d / clsSan.AsII, 0).ToString();
                    n = clsSan.AsII / 28.27d;
                    txtAschII.Text = (n * 28.27d).ToString();
                    break;
                case "8":
                    txtaII.Text = Math.Round(50.27d * 1000d / clsSan.AsII, 0).ToString();
                    n = clsSan.AsII / 50.27d;
                    txtAschII.Text = (n * 50.27d).ToString();
                    break;
                case "10":
                    txtaII.Text = Math.Round(78.54d * 1000d / clsSan.AsII, 0).ToString();
                    n = clsSan.AsII / 78.54d;
                    txtAschII.Text = (n * 78.54d).ToString();
                    break;
                case "12":
                    txtaII.Text = Math.Round(113.1d * 1000d / clsSan.AsII, 0).ToString();
                    n = clsSan.AsII / 113.1d;
                    txtAschII.Text = (n * 113.1d).ToString();
                    break;
                case "14":
                    txtaII.Text = Math.Round(113.1d * 1000d / clsSan.AsII, 0).ToString();
                    n = clsSan.AsII / 153.9d;
                    txtAschII.Text = (n * 153.9d).ToString();
                    break;
            }
        }

        private void btn_DatThep_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "" || labelID.Text == "ID") 
            { 
                MessageBox.Show("Chưa chọn sàn đặt thép !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                DialogResult = DialogResult.No; 
                Close(); 
            }
            foreach (var item in CommonData.lst_clssan)
            {
                if (cbb_San.Text.Contains(item.ID.ToString()))
                {
                    if (item.Status == StatusPlaceRebar.NotPlaced)
                    {
                        MessageBox.Show("Chưa chọn thép cho sàn muốn đặt !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.No;
                        Close();
                    }
                    else
                    {
                        CommonData.clsSanDatThep = item;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }

            
        }
    }
}
