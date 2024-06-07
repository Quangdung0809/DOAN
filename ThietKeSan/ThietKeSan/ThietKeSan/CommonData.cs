using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI.Selection;
using static ThietKeSan.SingleData;

namespace ThietKeSan
{
    public class CommonData
    {
        public static Floor Sanchon = null;

        // khai báo vật liệu 
        public static string BT;
        public static double Rb;
        public static double Rbt;
        public static double Eb;
        public static string TH;
        public static double Rs;
        public static double Rsc;
        public static double Es;
        public static clsSan clsSan = null;
        public static List<clsSan> lst_clssan = new List<clsSan>();
        public static List<clsHoattai> lst_clsHoattai = new List<clsHoattai>();
        public static List<clsTinhtai> lst_clsTinhtai = new List<clsTinhtai>();
        public static List<clsHoattai> lst_clsHoattaiTam = new List<clsHoattai>();
        public static List<clsTinhtai> lst_clsTinhtaiTam = new List<clsTinhtai>();
        public static clsHoattai clsHoattai = new clsHoattai();
        public static clsTinhtai clsTinhTai = new clsTinhtai();
        public static List<clsLopVatLieu> lst_clsVatLieu = new List<clsLopVatLieu>();
        public static clsLopVatLieu clsLopVatLieu = new clsLopVatLieu();
        public static List<RebarShape> lst_rebarshape = new List<RebarShape>();
        public static List<RebarBarType> lst_rebarbartype = new List<RebarBarType>();
        public static string DK = string.Empty;
        public static string TenSan;
        public static ElementId IdSan;
        public static ElementId IdSanDatThep;
        public static clsSan clsSanDatThep = null;
        public static XYZ pt1 = new XYZ();
        public static Floor Floor = null;
        public static string checkcreaterebar = string.Empty;

        public static List<string> list_reabar = new List<string>();
    }
}
