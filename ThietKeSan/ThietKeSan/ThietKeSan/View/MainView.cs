using Microsoft.VisualBasic.CompilerServices;
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
    public partial class MainView : Form
    {
        Autodesk.Revit.DB.Document Revitdoc;
        Function func = new Function();
        public MainView(Autodesk.Revit.DB.Document revitdocument)
        {
            Revitdoc = revitdocument;
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            if (CommonData.DK == "")
            {
                btn_chonsan.Enabled = false;   
            }
            else
            {
                btn_chonsan.Enabled = true;
            }
            if (CommonData.lst_clssan.Count == 0)
            {

            }
            else
            {
                txt_Hs.Text = CommonData.lst_clssan[0].a.ToString();
                txt_L1.Text = CommonData.lst_clssan[0].L1.ToString();
                txt_L2.Text = CommonData.lst_clssan[0].L2.ToString();
            }
            txt_tenosan.Text = CommonData.TenSan;

            // Đưa danh sách hoạt tải lên form 
            RefreshCBB();
        }
        private void RefreshCBB()
        {
            var dtHT = new DataTable();
            dtHT.Columns.AddRange(new DataColumn[] { new DataColumn("tenhoattai", typeof(string)), new DataColumn("pb", typeof(double)) });
            dtHT.Rows.Clear();
            if (CommonData.lst_clsHoattai.Count != 0)
            {
                foreach (var item in CommonData.lst_clsHoattai)
                {
                    dtHT.Rows.Add(item.tenhoattai, item.Pb);
                }
                cbb_hoattai.DisplayMember = "tenhoattai";
                cbb_hoattai.ValueMember = "pb";
                cbb_hoattai.DataSource = dtHT;
            }

            // Đưa danh sách tĩnh tải lên form
            var dtTT = new DataTable();
            dtTT.Columns.AddRange(new DataColumn[] { new DataColumn("tentinhtai", typeof(string)), new DataColumn("gb", typeof(double)) });
            dtTT.Rows.Clear();

            foreach (var item in CommonData.lst_clsTinhtai)
            {
                dtTT.Rows.Add(item.tentinhtai, item.gb);
            }
            cbb_tinhtai.DisplayMember = "tentinhtai";
            cbb_tinhtai.ValueMember = "gb";
            cbb_tinhtai.DataSource = dtTT;
        }
        private void btn_chonsan_Click(object sender, EventArgs e)
        {
            CommonData.DK = "";
            DialogResult = DialogResult.OK;        
        }

        private void btn_vatlieu_Click(object sender, EventArgs e)
        {
            Singleton.Instance.FormData.FormVatLieu.ShowDialog();
        }

        private void btn_taitrong_Click(object sender, EventArgs e)
        {
            Singleton.Instance.FormData.FormTaiTrong.ShowDialog();
            RefreshCBB();
        }

        private void btnTinhNoiLuc_Click(object sender, EventArgs e)
        {
            if (CommonData.lst_clssan?.Count < 1) return;
            var tinh4canh = CommonData.lst_clssan[0];
            DataTable table = Function.bangTra9();
            var noisuy_tinh = new clsSan();

            for (int j = 0, loopTo1 = table.Rows.Count - 1; j <= loopTo1; j++)
            {

                if (Convert.ToDouble(table.Rows[j][0]) == CommonData.lst_clssan[0].TyLe)
                {
                    noisuy_tinh.a1 = Convert.ToDouble(table.Rows[j][1]);
                    noisuy_tinh.a2 = Convert.ToDouble(table.Rows[j][2]);
                    noisuy_tinh.b1 = Convert.ToDouble(table.Rows[j][3]);
                    noisuy_tinh.b2 = Convert.ToDouble(table.Rows[j][4]);

                    tinh4canh.tinh_noisuy(noisuy_tinh.a1, noisuy_tinh.a2, noisuy_tinh.b1, noisuy_tinh.b2);
                    break;
                }
                else if (Convert.ToDouble(table.Rows[j][0]) < CommonData.lst_clssan[0].TyLe && CommonData.lst_clssan[0].TyLe < Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][0]))
                {
                    noisuy_tinh.a1 = Convert.ToDouble(table.Rows[j][1]) + (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][1]) - Convert.ToDouble(table.Rows[j][1])) * (CommonData.lst_clssan[0].TyLe - Convert.ToDouble(table.Rows[j][0])) / (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][1]) - Convert.ToDouble(table.Rows[j][0]));
                    noisuy_tinh.a2 = Convert.ToDouble(table.Rows[j][2]) + (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][2]) - Convert.ToDouble(table.Rows[j][2])) * (CommonData.lst_clssan[0].TyLe - Convert.ToDouble(table.Rows[j][0])) / (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][1]) - Convert.ToDouble(table.Rows[j][0]));
                    noisuy_tinh.b1 = Convert.ToDouble(table.Rows[j][3]) + (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][3]) - Convert.ToDouble(table.Rows[j][3])) * (CommonData.lst_clssan[0].TyLe - Convert.ToDouble(table.Rows[j][0])) / (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][1]) - Convert.ToDouble(table.Rows[j][0]));
                    noisuy_tinh.b2 = Convert.ToDouble(table.Rows[j][4]) + (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][4]) - Convert.ToDouble(table.Rows[j][4])) * (CommonData.lst_clssan[0].TyLe - Convert.ToDouble(table.Rows[j][0])) / (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][1]) - Convert.ToDouble(table.Rows[j][0]));
                    tinh4canh.tinh_noisuy(noisuy_tinh.a1, noisuy_tinh.a2, noisuy_tinh.b1, noisuy_tinh.b2);
                    break;

                }
            }
            double a1 = tinh4canh.a1;
            double a2 = tinh4canh.a2;
            double b1 = tinh4canh.b1;
            double b2 = tinh4canh.b2;
            double qb = CommonData.lst_clssan[0].qb;
            double L1 = CommonData.lst_clssan[0].L1;
            double L2 = CommonData.lst_clssan[0].L2;


            tinh4canh.M1 = Math.Round(a1 * qb * L1 * L2, 3);
            tinh4canh.M2 = Math.Round(a2 * qb * L1 * L2, 3);
            tinh4canh.MI = Math.Round(b1 * qb * L1 * L2, 3);
            tinh4canh.MII = Math.Round(b2 * qb * L1 * L2, 3);

            tinh4canh.alpha1 = Function.tinhalpha(tinh4canh.M1, CommonData.lst_clssan[0].Ho);
            tinh4canh.ζ1 = Function.tinhζ(tinh4canh.alpha1);
            tinh4canh.As1 = Function.tinhAs(tinh4canh.M1 * Math.Pow(10d, 6d), tinh4canh.ζ1, CommonData.lst_clssan[0].Ho);
            tinh4canh.μ1 = Function.tinhμ(tinh4canh.As1, CommonData.lst_clssan[0].Ho * 1000);

            tinh4canh.alpha2 = Function.tinhalpha(tinh4canh.M2, CommonData.lst_clssan[0].Ho);
            tinh4canh.ζ2 = Function.tinhζ(tinh4canh.alpha2);
            tinh4canh.As2 = Function.tinhAs(tinh4canh.M2 * Math.Pow(10d, 6d), tinh4canh.ζ2, CommonData.lst_clssan[0].Ho);
            tinh4canh.μ2 = Function.tinhμ(tinh4canh.As2, CommonData.lst_clssan[0].Ho * 1000);

            tinh4canh.alphaI = Function.tinhalpha(tinh4canh.MI, CommonData.lst_clssan[0].Ho);
            tinh4canh.ζI = Function.tinhζ(tinh4canh.alphaI);
            tinh4canh.AsI = Function.tinhAs(tinh4canh.MI * Math.Pow(10d, 6d), tinh4canh.ζI, CommonData.lst_clssan[0].Ho);
            tinh4canh.μI = Function.tinhμ(tinh4canh.AsI, CommonData.lst_clssan[0].Ho * 1000);

            tinh4canh.alphaII = Function.tinhalpha(tinh4canh.MII, CommonData.lst_clssan[0].Ho);
            tinh4canh.ζII = Function.tinhζ(tinh4canh.alphaII);
            tinh4canh.AsII = Function.tinhAs(tinh4canh.MII * Math.Pow(10d, 6d), tinh4canh.ζII, CommonData.lst_clssan[0].Ho);
            tinh4canh.μII = Function.tinhμ(tinh4canh.AsII, CommonData.lst_clssan[0].Ho * 1000);
            //modul.clsDssan.tinh_San4ccanh(i, tinh4canh);
            CommonData.lst_clssan[0].tinh_San4ccanh(tinh4canh.M1, tinh4canh.alpha1, tinh4canh.ζ1, tinh4canh.As1, tinh4canh.μ1,
                                     tinh4canh.M2, tinh4canh.alpha2, tinh4canh.ζ2, tinh4canh.As2, tinh4canh.μ2,
                                     tinh4canh.MI, tinh4canh.alphaI, tinh4canh.ζI, tinh4canh.AsI, tinh4canh.μI,
                                     tinh4canh.MII, tinh4canh.alphaII, tinh4canh.ζII, tinh4canh.AsII, tinh4canh.μII);

            MessageBox.Show(" Tính nội lực thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            this.dgv_osan.Rows.Clear();
            for (int i = 0, loopTo = CommonData.lst_clssan.Count - 1; i <= loopTo; i++)
                this.dgv_osan.Rows.Add(CommonData.lst_clssan[i].tensan, CommonData.lst_clssan[i].sodo, CommonData.lst_clssan[i].L1, CommonData.lst_clssan[i].L2, CommonData.lst_clssan[i].TyLe, CommonData.lst_clssan[i].Hs, CommonData.lst_clssan[i].Ho, CommonData.lst_clssan[i].qb);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (CommonData.lst_clssan?.Count < 1) return;

            // Đưa danh sách hoạt tải lên form 
            var dtHT = new DataTable();
            dtHT.Columns.AddRange(new DataColumn[] { new DataColumn("tenhoattai", typeof(string)), new DataColumn("pb", typeof(double)) });
            dtHT.Rows.Clear();
            if (CommonData.lst_clsHoattai.Count != 0)
            {
                foreach (var item in CommonData.lst_clsHoattai)
                {
                    dtHT.Rows.Add(item.tenhoattai, item.Pb);
                }
                cbb_hoattai.DisplayMember = "tenhoattai";
                cbb_hoattai.ValueMember = "pb";
                cbb_hoattai.DataSource = dtHT;
            }

            // Đưa danh sách tĩnh tải lên form
            var dtTT = new DataTable();
            dtTT.Columns.AddRange(new DataColumn[] { new DataColumn("tentinhtai", typeof(string)), new DataColumn("gb", typeof(double)) });
            dtTT.Rows.Clear();

            foreach (var item in CommonData.lst_clsTinhtai)
            {
                dtTT.Rows.Add(item.tentinhtai, item.gb);
            }
            cbb_tinhtai.DisplayMember = "tentinhtai";
            cbb_tinhtai.ValueMember = "gb";
            cbb_tinhtai.DataSource = dtTT;
            // lưu thông tin sàn vào dữ liệu chung 
            CommonData.lst_clssan[0].Hs = Convert.ToDouble(txt_Hs.Text);
            CommonData.lst_clssan[0].a = Convert.ToDouble(txt_a.Text);
            CommonData.lst_clssan[0].gb = Convert.ToDouble(cbb_tinhtai.SelectedValue);
            CommonData.lst_clssan[0].pb = Convert.ToDouble(cbb_hoattai.SelectedValue);
            CommonData.lst_clssan[0].tensan = txt_tenosan.Text;
            CommonData.lst_clssan[0].sodo = "9";

            // Đẩy giá trị nội lực lên form
            if (CommonData.lst_clssan[0].M1 == 0)
            {

            }
            else
            {
                this.dgv_tinhthep.Rows.Add("M1", CommonData.lst_clssan[0].M1, CommonData.lst_clssan[0].alpha1, CommonData.lst_clssan[0].ζ1, CommonData.lst_clssan[0].As1, CommonData.lst_clssan[0].μ1);
                this.dgv_tinhthep.Rows.Add("M2", CommonData.lst_clssan[0].M2, CommonData.lst_clssan[0].alpha2, CommonData.lst_clssan[0].ζ2, CommonData.lst_clssan[0].As2, CommonData.lst_clssan[0].μ2);
                this.dgv_tinhthep.Rows.Add("MI", CommonData.lst_clssan[0].MI, CommonData.lst_clssan[0].alphaI, CommonData.lst_clssan[0].ζI, CommonData.lst_clssan[0].AsI, CommonData.lst_clssan[0].μI);
                this.dgv_tinhthep.Rows.Add("MII", CommonData.lst_clssan[0].MII, CommonData.lst_clssan[0].alphaII, CommonData.lst_clssan[0].ζII, CommonData.lst_clssan[0].AsII, CommonData.lst_clssan[0].μII);
            }
        }
        double n;

        private void cbbΦ1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CommonData.lst_clssan?.Count < 1) { MessageBox.Show("Chưa chọn sàn !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; } 
            switch (cbbΦ1.Text)
            {
                case "6":
                    txta1.Text = Math.Round(28.27d * 1000d / CommonData.lst_clssan[0].As1, 0).ToString();
                    n = CommonData.lst_clssan[0].As1 / 28.27d;
                    txtAsch1.Text = (n * 28.27d).ToString();
                    break;
                case "8":
                    txta1.Text = Math.Round(50.27d * 1000d / CommonData.lst_clssan[0].As1, 0).ToString();
                    n = CommonData.lst_clssan[0].As1 / 50.27d;
                    txtAsch1.Text = (n * 50.27d).ToString();
                    break;
                case "10":
                    txta1.Text = Math.Round(78.54d * 1000d / CommonData.lst_clssan[0].As1, 0).ToString();
                    n = CommonData.lst_clssan[0].As1 / 78.54d;
                    txtAsch1.Text = (n * 78.54d).ToString();
                    break;
                case "12":
                    txta1.Text = Math.Round(113.1d * 1000d / CommonData.lst_clssan[0].As1, 0).ToString();
                    n = CommonData.lst_clssan[0].As1 / 113.1d;
                    txtAsch1.Text = (n * 113.1d).ToString();
                    break;
                case "14":
                    txta1.Text = Math.Round(113.1d * 1000d / CommonData.lst_clssan[0].As1, 0).ToString();
                    n = CommonData.lst_clssan[0].As1 / 153.9d;
                    txtAsch1.Text = (n * 153.9d).ToString();
                    break;
            }
        }

        private void cbbΦ2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CommonData.lst_clssan?.Count < 1) { MessageBox.Show("Chưa chọn sàn !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            switch (cbbΦ2.Text)
            {
                case "6":
                    txta2.Text = Math.Round(28.27d * 1000d / CommonData.lst_clssan[0].As2, 0).ToString();
                    n = CommonData.lst_clssan[0].As2 / 28.27d;
                    txtAsch2.Text = (n * 28.27d).ToString();
                    break;
                case "8":
                    txta2.Text = Math.Round(50.27d * 1000d / CommonData.lst_clssan[0].As2, 0).ToString();
                    n = CommonData.lst_clssan[0].As2 / 50.27d;
                    txtAsch2.Text = (n * 50.27d).ToString();
                    break;
                case "10":
                    txta2.Text = Math.Round(78.54d * 1000d / CommonData.lst_clssan[0].As2, 0).ToString();
                    n = CommonData.lst_clssan[0].As2 / 78.54d;
                    txtAsch2.Text = (n * 78.54d).ToString();
                    break;
                case "12":
                    txta2.Text = Math.Round(113.1d * 1000d / CommonData.lst_clssan[0].As2, 0).ToString();
                    n = CommonData.lst_clssan[0].As2 / 113.1d;
                    txtAsch2.Text = (n * 113.1d).ToString();
                    break;
                case "14":
                    txta2.Text = Math.Round(113.1d * 1000d / CommonData.lst_clssan[0].As2, 0).ToString();
                    n = CommonData.lst_clssan[0].As2 / 153.9d;
                    txtAsch2.Text = (n * 153.9d).ToString();
                    break;
            }
        }

        private void cbbΦI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CommonData.lst_clssan?.Count < 1) { MessageBox.Show("Chưa chọn sàn !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            switch (cbbΦI.Text)
            {
                case "6":
                    txtaI.Text = Math.Round(28.27d * 1000d / CommonData.lst_clssan[0].AsI, 0).ToString();
                    n = CommonData.lst_clssan[0].AsI / 28.27d;
                    txtAschI.Text = (n * 28.27d).ToString();
                    break;
                case "8":
                    txtaI.Text = Math.Round(50.27d * 1000d / CommonData.lst_clssan[0].AsI, 0).ToString();
                    n = CommonData.lst_clssan[0].AsI / 50.27d;
                    txtAschI.Text = (n * 50.27d).ToString();
                    break;
                case "10":
                    txtaI.Text = Math.Round(78.54d * 1000d / CommonData.lst_clssan[0].AsI, 0).ToString();
                    n = CommonData.lst_clssan[0].AsI / 78.54d;
                    txtAschI.Text = (n * 78.54d).ToString();
                    break;
                case "12":
                    txtaI.Text = Math.Round(113.1d * 1000d / CommonData.lst_clssan[0].AsI, 0).ToString();
                    n = CommonData.lst_clssan[0].AsI / 113.1d;
                    txtAschI.Text = (n * 113.1d).ToString();
                    break;
                case "14":
                    txtaI.Text = Math.Round(113.1d * 1000d / CommonData.lst_clssan[0].AsI, 0).ToString();
                    n = CommonData.lst_clssan[0].AsI / 153.9d;
                    txtAschI.Text = (n * 153.9d).ToString();
                    break;
            }
        }

        private void cbbΦII_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CommonData.lst_clssan?.Count < 1) { MessageBox.Show("Chưa chọn sàn !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            switch (cbbΦII.Text)
            {
                case "6":
                    txtaII.Text = Math.Round(28.27d * 1000d / CommonData.lst_clssan[0].AsII, 0).ToString();
                    n = CommonData.lst_clssan[0].AsII / 28.27d;
                    txtAschII.Text = (n * 28.27d).ToString();
                    break;
                case "8":
                    txtaII.Text = Math.Round(50.27d * 1000d / CommonData.lst_clssan[0].AsII, 0).ToString();
                    n = CommonData.lst_clssan[0].AsII / 50.27d;
                    txtAschII.Text = (n * 50.27d).ToString();
                    break;
                case "10":
                    txtaII.Text = Math.Round(78.54d * 1000d / CommonData.lst_clssan[0].AsII, 0).ToString();
                    n = CommonData.lst_clssan[0].AsII / 78.54d;
                    txtAschII.Text = (n * 78.54d).ToString();
                    break;
                case "12":
                    txtaII.Text = Math.Round(113.1d * 1000d / CommonData.lst_clssan[0].AsII, 0).ToString();
                    n = CommonData.lst_clssan[0].AsII / 113.1d;
                    txtAschII.Text = (n * 113.1d).ToString();
                    break;
                case "14":
                    txtaII.Text = Math.Round(113.1d * 1000d / CommonData.lst_clssan[0].AsII, 0).ToString();
                    n = CommonData.lst_clssan[0].AsII / 153.9d;
                    txtAschII.Text = (n * 153.9d).ToString();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
