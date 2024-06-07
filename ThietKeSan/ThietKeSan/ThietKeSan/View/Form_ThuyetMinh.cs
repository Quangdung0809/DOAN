using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeSan.View
{
    public partial class Form_ThuyetMinh : Form
    {
        public Form_ThuyetMinh()
        {
            InitializeComponent();
        }

        private void Form_ThuyetMinh_Load(object sender, EventArgs e)
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
            }
        }

        private void btn_TaoTm_Click(object sender, EventArgs e)
        {
            if (cbb_San.Items.Count == 0) { MessageBox.Show("Chưa chọn sàn để tạo thuyết minh", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            string revitAssemblyPath = Assembly.GetExecutingAssembly().Location;
            string revitDirectoryPath = Path.GetDirectoryName(revitAssemblyPath);
            string s = System.IO.File.ReadAllText(revitAssemblyPath.Replace("ThietKeSan.dll", "Report.rtf"));
            foreach (var item in CommonData.lst_clssan)
            {
                string name = item.tensan + " - " + item.ID.ToString();
                if (name == cbb_San.Text)
                {
                    s = s.Replace(@"%TenSan%", item.tensan);
                    s = s.Replace(@"%L1%", item.L1.ToString());
                    s = s.Replace(@"%L2%", item.L2.ToString());
                    s = s.Replace(@"%hs%", item.Hs.ToString());
                    s = s.Replace(@"%TenTT%", item.TT);
                    s = s.Replace(@"%TenHT%", item.HT);

                    s = s.Replace(@"%BT%", CommonData.BT);
                    s = s.Replace(@"%Rb%", CommonData.Rb.ToString());
                    s = s.Replace(@"%Rbt%", CommonData.Rbt.ToString());
                    s = s.Replace(@"%Eb%", CommonData.Eb.ToString());
                    s = s.Replace(@"%TH%", CommonData.TH);
                    s = s.Replace(@"%Rs%", CommonData.Rs.ToString());
                    s = s.Replace(@"%Rsc%", CommonData.Rsc.ToString());
                    s = s.Replace(@"%Es%", CommonData.Es.ToString());

                    s = s.Replace(@"%Gs%", Math.Round(item.gb, 3).ToString());
                    s = s.Replace(@"%Ps%", Math.Round(item.pb, 3).ToString());
                    s = s.Replace(@"%Qs%", Math.Round(item.qb, 3).ToString());
                    s = s.Replace(@"%TS%", Math.Round(item.TyLe, 3).ToString());
                    s = s.Replace(@"%hs%", item.Hs.ToString());
                    
                    s = s.Replace(@"%alpha1%", Math.Round(item.a1, 3).ToString());
                    s = s.Replace(@"%alpha2%", Math.Round(item.a2, 3).ToString());
                    s = s.Replace(@"%beta1%", Math.Round(item.b1, 3).ToString());
                    s = s.Replace(@"%beta2%", Math.Round(item.b2, 3).ToString());
                    s = s.Replace(@"%M1%", Math.Round(item.M1, 3).ToString());
                    s = s.Replace(@"%M2%", Math.Round(item.M2, 3).ToString());
                    s = s.Replace(@"%MI%", Math.Round(item.MI, 3).ToString());
                    s = s.Replace(@"%MII%", Math.Round(item.MII, 3).ToString());
                    s = s.Replace(@"%a%", item.a.ToString());
                    s = s.Replace(@"%h0%", item.Ho.ToString());
                    s = s.Replace(@"%am1%", Math.Round(item.alpha1, 3).ToString());
                    s = s.Replace(@"%am2%", Math.Round(item.alpha2, 3).ToString());
                    s = s.Replace(@"%amI%", Math.Round(item.alphaI, 3).ToString());
                    s = s.Replace(@"%amII%", Math.Round(item.alphaII, 3).ToString());
                    s = s.Replace(@"%coxi1%", Math.Round(item.ζ1, 3).ToString());
                    s = s.Replace(@"%coxi2%", Math.Round(item.ζ2, 3).ToString());
                    s = s.Replace(@"%coxiI%", Math.Round(item.ζI, 3).ToString());
                    s = s.Replace(@"%coxiII%", Math.Round(item.ζII, 3).ToString());
                    s = s.Replace(@"%As1%", Math.Round(item.As1, 3).ToString());
                    s = s.Replace(@"%As2%", Math.Round(item.As2, 3).ToString());
                    s = s.Replace(@"%AsI%", Math.Round(item.AsI, 3).ToString());
                    s = s.Replace(@"%AsII%", Math.Round(item.AsII, 3).ToString());
                    s = s.Replace(@"%m1%", Math.Round(item.μ1, 3).ToString());
                    s = s.Replace(@"%m2%", Math.Round(item.μ2, 3).ToString());
                    s = s.Replace(@"%mI%", Math.Round(item.μI, 3).ToString());
                    s = s.Replace(@"%mII%", Math.Round(item.ζII, 3).ToString());
                    rtb_TM.Rtf = s;
                }
            }
            
        }

        private void btn_XuatTm_Click(object sender, EventArgs e)
        {
            if (cbb_San.Items.Count == 0) { MessageBox.Show("Chưa chọn sàn để tạo thuyết minh", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }   
            SaveFileDialog saveTxt = new SaveFileDialog();
            saveTxt.Filter = "Word Files (*doc)|*.doc";
            saveTxt.Title = "Lưu file thuyết minh";
            saveTxt.RestoreDirectory = true;
            if (saveTxt.ShowDialog() == DialogResult.OK)
            {
                rtb_TM.SaveFile(saveTxt.FileName, RichTextBoxStreamType.RichText);
                MessageBox.Show("Xuất thuyết minh thành công !!");
            }
        }

        private void cbb_San_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in CommonData.lst_clssan)
            {
                if (cbb_San.Text.Contains(item.ID.ToString()))
                {
                    labelID.Text = item.ID.ToString();
                    break;
                }
            }
        }
    }
}
