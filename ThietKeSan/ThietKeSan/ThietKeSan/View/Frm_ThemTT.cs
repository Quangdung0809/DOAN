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
using Excel = Microsoft.Office.Interop.Excel;

namespace ThietKeSan.View
{
    public partial class Frm_ThemTT : Form
    {
        public Frm_ThemTT()
        {
            InitializeComponent();
        }

        private void Frm_ThemTT_Load(object sender, EventArgs e)
        {

        }

        private void Btn_import_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(openFileDialog1.FileName);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets["Sheet1"];
                Excel.Range xlRange = xlWorksheet.UsedRange;
                // Dem so hang
                CommonData.lst_clsVatLieu.Clear();
                for (int i = 1; i <= xlRange.Rows.Count; i++)
                {
                    var clssv = new clsLopVatLieu();

                    clssv.lopvl = xlWorksheet.Cells[i, 1].value;
                    clssv.beday = xlWorksheet.Cells[i, 2].value;
                    clssv.TrongLuong = xlWorksheet.Cells[i, 3].value;
                    clssv.HSVT = xlWorksheet.Cells[i, 4].value;

                    CommonData.lst_clsVatLieu.Add(clssv);
                }
                xlWorkbook.Close();
                xlApp.Quit();
            }
            AddtoDatagrid();
            txt_tenTinhTai.Text = "S1";
        }
        public void AddtoDatagrid()
        {
            dgv_LopVatLieu.Rows.Clear();
            foreach (var item in CommonData.lst_clsVatLieu)
            {
                int i = 1;
                dgv_LopVatLieu.Rows.Add(i, item.lopvl, item.beday, item.TrongLuong, item.HSVT, item.TTTT);
                i += 1;
            }
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            CommonData.clsTinhTai = new clsTinhtai();
            double gb = 0;
            foreach (var item in CommonData.lst_clsVatLieu)
            {
                gb = gb + item.TTTT;
            }
            
            foreach (var item in CommonData.lst_clsTinhtai)
            {
                if (item.tentinhtai == txt_tenTinhTai.Text)
                {
                    MessageBox.Show("Tĩnh tải đã tồn tại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            foreach (var item in CommonData.lst_clsTinhtaiTam)
            {
                if (item.tentinhtai == txt_tenTinhTai.Text)
                {
                    MessageBox.Show("Tĩnh tải đã tồn tại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            CommonData.clsTinhTai.New(txt_tenTinhTai.Text, gb);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            dgv_LopVatLieu.Rows.RemoveAt(dgv_LopVatLieu.CurrentRow.Index);
            CommonData.lst_clsVatLieu.RemoveAt(dgv_LopVatLieu.CurrentRow.Index);
            for (int i = 0; i < dgv_LopVatLieu.Rows.Count; i++)
            {
                dgv_LopVatLieu.Rows[i].Cells[0].Value = (i+1).ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            SingleData.Singleton.Instance.FormData.ThemVatLieu = new Frm_ThemLopVatLieu();
            var dlg = SingleData.Singleton.Instance.FormData.ThemVatLieu.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                dgv_LopVatLieu.Rows.Add(dgv_LopVatLieu.Rows.Count, CommonData.clsLopVatLieu.lopvl, CommonData.clsLopVatLieu.beday, CommonData.clsLopVatLieu.TrongLuong, CommonData.clsLopVatLieu.HSVT, CommonData.clsLopVatLieu.TTTT);
                CommonData.lst_clsVatLieu.Add(CommonData.clsLopVatLieu);
            }
        }
    }
}
