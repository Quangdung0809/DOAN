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
using System.Data;
using System.Security.Cryptography;

namespace ThietKeSan
{
    public class Function
    {
       
        public clsSan GetFloor(Floor floor)
        {
            clsSan cls_San = new clsSan(); 
            BoundingBoxXYZ bbox = floor.get_BoundingBox(null);
            if (bbox == null) return null;
            CommonData.pt1 = bbox.Min;
            double thickness = Math.Round((bbox.Max.Z - bbox.Min.Z) * 304.8) / 1000;
            double l1 = Math.Round((bbox.Max.X - bbox.Min.X) * 304.8) / 1000;
            double l2 = Math.Round((bbox.Max.Y - bbox.Min.Y) * 304.8) / 1000;
            if (l1 < l2)
            {
                cls_San.L1 = l1;
                cls_San.L2 = l2;
            }
            else
            {
                cls_San.L1 = l2;
                cls_San.L2 = l1;
            }
            cls_San.Hs = thickness;
            cls_San.ID = floor.Id;
            cls_San.tensan = floor.FloorType.Name;
            cls_San.sodo = "9";
            return cls_San;
        }

        public static DataTable bangTra9()
        {
            DataTable table = new DataTable();
            table.Columns.Add("tyLe", typeof(double));
            table.Columns.Add("alpha1", typeof(double));
            table.Columns.Add("alpha2", typeof(double));
            table.Columns.Add("beta1", typeof(double));
            table.Columns.Add("beta2", typeof(double));
            table.Rows.Add(1, 0.0179, 0.0179, 0.0417, 0.0417);
            table.Rows.Add(1.05, 0.0187, 0.0171, 0.0437, 0.0394);
            table.Rows.Add(1.1, 0.0194, 0.0161, 0.045, 0.0372);
            table.Rows.Add(1.15, 0.02, 0.015, 0.0461, 0.0349);
            table.Rows.Add(1.2, 0.0204, 0.0142, 0.0468, 0.0325);
            table.Rows.Add(1.25, 0.0207, 0.0133, 0.0473, 0.0303);
            table.Rows.Add(1.3, 0.0208, 0.0123, 0.0475, 0.0281);
            table.Rows.Add(1.35, 0.021, 0.0115, 0.0474, 0.0262);
            table.Rows.Add(1.4, 0.021, 0.0107, 0.0473, 0.024);
            table.Rows.Add(1.45, 0.0209, 0.01, 0.0469, 0.0223);
            table.Rows.Add(1.5, 0.0208, 0.0093, 0.0464, 0.0206);
            table.Rows.Add(1.55, 0.0206, 0.0086, 0.0459, 0.0191);
            table.Rows.Add(1.6, 0.0205, 0.008, 0.0452, 0.0177);
            table.Rows.Add(1.65, 0.0202, 0.0179, 0.0417, 0.0417);
            table.Rows.Add(1.7, 0.02, 0.0069, 0.0438, 0.0152);
            table.Rows.Add(1.75, 0.0197, 0.0064, 0.0431, 0.0141);
            table.Rows.Add(1.8, 0.0195, 0.006, 0.0423, 0.0131);
            table.Rows.Add(1.85, 0.0192, 0.0056, 0.0415, 0.0122);
            table.Rows.Add(1.9, 0.019, 0.0052, 0.0408, 0.0113);
            table.Rows.Add(1.95, 0.0186, 0.0049, 0.04, 0.0107);
            table.Rows.Add(2, 0.0183, 0.0046, 0.0392, 0.0098);
            return table;
        }

        public static double tinhalpha(double M, double h0)
        {
            
            double alpha = Math.Round(M / (CommonData.Rb * (Math.Pow(h0, 2))), 3);

            return alpha;
        }

        public static double tinhζ(double alpha)
        {
            double ζ = Math.Round(0.5 * (1 + Math.Sqrt(1 - 2 * alpha)), 3);

            return ζ;
        }
        public static double tinhAs(double M, double ζ, double h0)
        {
           
            double _As = Math.Round(M / ((CommonData.Rs / 1000) * ζ * h0 * 1000), 3);

            return _As;
        }
        public static double tinhμ(double _As, double h0)
        {
            double μ = Math.Round(_As * 100 / (h0 * 1000), 3);

            return μ;
        }

        private List<Rebar> CreateRebar(Document doc, Wall wall, RebarShape barShape, RebarBarType barType)
        {
            List<Rebar> newRebars = new List<Rebar>();

            Rebar bar = Rebar.CreateFromRebarShape(doc, barShape, barType, wall, new XYZ(2, 0, 2), new XYZ(1, 0, 0), new XYZ(0, 0, 1));
            // call regenerate so that the TotalLength will be calculated before the transaction is committed
            doc.Regenerate();
            newRebars.Add(bar);

            // add a second bar adjacent to the first one
            double barLength = bar.TotalLength;
            bar = Rebar.CreateFromRebarShape(doc, barShape, barType, wall, new XYZ(2 + barLength, 0, 2), new XYZ(1, 0, 0), new XYZ(0, 0, 1));
            newRebars.Add(bar);

            return newRebars;
        }

       public void Create_RebarbarType(Document RevitDocument, string dk, List<RebarBarType> rebarBarTypes)
        {
            foreach (var item in rebarBarTypes)
            {
                if (item.Name == dk)
                {
                    item.BarNominalDiameter = ConvertMMtoFt(Double.Parse(dk));
                    item.StandardBendDiameter = ConvertMMtoFt(Double.Parse(dk)) * 5;
                    item.StandardHookBendDiameter = ConvertMMtoFt(Double.Parse(dk)) * 5;
                    item.StirrupTieBendDiameter = ConvertMMtoFt(Double.Parse(dk)) * 5;
                    return;
                }
            }
            RebarBarType rebarBarType = RebarBarType.Create(RevitDocument);
            rebarBarType.Name = dk;
            rebarBarType.BarNominalDiameter = ConvertMMtoFt(Double.Parse(dk));
            rebarBarType.StandardBendDiameter = ConvertMMtoFt(Double.Parse(dk)) * 5;
            rebarBarType.StandardHookBendDiameter = ConvertMMtoFt(Double.Parse(dk)) * 5;
            rebarBarType.StirrupTieBendDiameter = ConvertMMtoFt(Double.Parse(dk)) * 5;
        }

        public RebarHookType GetRebarHook(Document RevitDoc)
        {
            List<RebarHookType> rebarhooktypes = new FilteredElementCollector(RevitDoc).OfClass(typeof(RebarHookType)).Cast<RebarHookType>().ToList();
            RebarHookType rebarHookType1 = null;
            foreach (var item in rebarhooktypes)
            {
                if (item.Name == "Stirrup/Tie - 135 deg.")
                {
                    rebarHookType1 = item;
                    return item;
                }
            }
            RebarHookType rebarHookType = RebarHookType.Create(RevitDoc, Math.PI/2, ConvertMMtoFt(100));
            return rebarHookType;
        }
        public double ConvertMMtoFt(double input)
        {
            return input / 304.8;
        }
        public double ConvertFttoMM(double input)
        {
            return input * 304.8;
        }

        public Rebar PlaceRebarTop1(Document RevitDoc, RebarBarType rebarBarType, RebarShape rebarShape, RebarHookType hookAtStart, RebarHookType hookAtEnd,
            Floor floor, RebarHookOrientation startHookOrient, RebarHookOrientation endHookOrient, XYZ point, double length, double spacing, double cover)
        {
            RebarStyle rebarstyle = RebarStyle.Standard;

            XYZ normal = new XYZ(1, 0, 0);
            // tạo đường dẫn thép 
            BoundingBoxXYZ boundingBoxXYZ = floor.get_BoundingBox(null);
            double sizeX = boundingBoxXYZ.Max.X - boundingBoxXYZ.Min.X;
            double sizeY = boundingBoxXYZ.Max.Y - boundingBoxXYZ.Min.Y;
            double sizeZ = boundingBoxXYZ.Max.Z - boundingBoxXYZ.Min.Z;

            // khoảng neo cốt thép 
            double v_x1 = ConvertMMtoFt(CommonData.clsSanDatThep.L2 * 1000 * 0.25);
            double v_x2 = ConvertMMtoFt(CommonData.clsSanDatThep.L2 * 1000 * 0.25);

            // Thép lớp trên bên trái 
            Line rebarlinetop1t = Line.CreateBound(new XYZ(point.X + cover, point.Y + cover, point.Z + cover), new XYZ(point.X + cover, point.Y + cover, point.Z + sizeZ - cover));
            Line rebarlinetop2t = Line.CreateBound(new XYZ(point.X + cover, point.Y + cover, point.Z + sizeZ - cover), new XYZ(point.X + cover, point.Y + v_x1, point.Z + sizeZ - cover));
            Line rebarlinetop3t = Line.CreateBound(new XYZ(point.X + cover, point.Y + v_x1, point.Z + sizeZ - cover), new XYZ(point.X + cover, point.Y + v_x1, point.Z + cover));

            // Thép lớp trên bên phải
            Line rebarlinetop1p = Line.CreateBound(new XYZ(point.X + cover, point.Y + sizeY - 2 * cover, point.Z + cover), new XYZ(point.X + cover, point.Y + sizeY - 2 * cover, point.Z + sizeZ - cover));
            Line rebarlinetop2p = Line.CreateBound(new XYZ(point.X + cover, point.Y + sizeY - 2 * cover, point.Z + sizeZ - cover), new XYZ(point.X + cover, point.Y + sizeY - 2 * cover - v_x2, point.Z + sizeZ - cover));
            Line rebarlinetop3p = Line.CreateBound(new XYZ(point.X + cover, point.Y + sizeY - 2 * cover - v_x2, point.Z + sizeZ - cover), new XYZ(point.X + cover, point.Y + sizeY - 2 * cover - v_x2, point.Z + cover));
            
            IList<Curve> curves_t = new List<Curve>();
            curves_t.Add(rebarlinetop1t);
            curves_t.Add(rebarlinetop2t);
            curves_t.Add(rebarlinetop3t);

            IList<Curve> curves_p = new List<Curve>();
            curves_p.Add(rebarlinetop1p);
            curves_p.Add(rebarlinetop2p);
            curves_p.Add(rebarlinetop3p);

            // tạo thép lớp trên 

            Rebar rebartop_t = Rebar.CreateFromCurves(RevitDoc, rebarstyle, rebarBarType, hookAtStart, hookAtEnd, floor, normal, curves_t, startHookOrient, endHookOrient, false, true);
            Rebar rebartop_p = Rebar.CreateFromCurves(RevitDoc, rebarstyle, rebarBarType, hookAtStart, hookAtEnd, floor, normal, curves_p, startHookOrient, endHookOrient, false, true);
            
            // Xét khoảng rải của thép 
            double length_convert = ConvertMMtoFt(length * 1000);
            double spacing_convert = ConvertMMtoFt(spacing); 
            int number = (int)(Math.Round(length_convert / spacing_convert));
            if (null != rebartop_t)
            {
                rebartop_t.GetShapeDrivenAccessor().SetLayoutAsNumberWithSpacing(number, spacing_convert, true, true, true);
                rebartop_p.GetShapeDrivenAccessor().SetLayoutAsNumberWithSpacing(number, spacing_convert, true, true, true);
            }
            return rebartop_t;
        }

        public Rebar PlaceRebarTop2(Document RevitDoc, RebarBarType rebarBarType, RebarShape rebarShape, RebarHookType hookAtStart, RebarHookType hookAtEnd,
           Floor floor, RebarHookOrientation startHookOrient, RebarHookOrientation endHookOrient, XYZ point, double length, double spacing, double cover)
        {
            RebarStyle rebarstyle = RebarStyle.Standard;

            XYZ normal = new XYZ(0, 1, 0);

            // tạo đường dẫn thép 
            BoundingBoxXYZ boundingBoxXYZ = floor.get_BoundingBox(null);
            double sizeX = boundingBoxXYZ.Max.X - boundingBoxXYZ.Min.X;
            double sizeY = boundingBoxXYZ.Max.Y - boundingBoxXYZ.Min.Y;
            double sizeZ = boundingBoxXYZ.Max.Z - boundingBoxXYZ.Min.Z;

            // khoảng neo cốt thép 
            double v_x1 = ConvertMMtoFt(CommonData.clsSanDatThep.L1 * 1000 * 0.25);
            double v_x2 = ConvertMMtoFt(CommonData.clsSanDatThep.L1 * 1000 * 0.25);

            // Thép lớp trên bên dưới  
            Line rebarlinetop1d = Line.CreateBound(new XYZ(point.X + cover, point.Y + cover, point.Z + cover), new XYZ(point.X + cover, point.Y + cover, point.Z + sizeZ - cover));
            Line rebarlinetop2d = Line.CreateBound(new XYZ(point.X + cover, point.Y + cover, point.Z + sizeZ - cover), new XYZ(point.X + v_x1, point.Y + cover, point.Z + sizeZ - cover));
            Line rebarlinetop3d = Line.CreateBound(new XYZ(point.X + v_x1, point.Y +  cover, point.Z + sizeZ - cover), new XYZ(point.X + v_x1, point.Y + cover, point.Z + cover));


            // Thép lớp trên bên dưới 
            Line rebarlinetop1t = Line.CreateBound(new XYZ(point.X + sizeX - v_x2, point.Y + cover, point.Z + cover), new XYZ(point.X + sizeX - v_x2, point.Y + cover , point.Z + sizeZ - cover));
            Line rebarlinetop2t = Line.CreateBound(new XYZ(point.X + sizeX - v_x2, point.Y + cover, point.Z + sizeZ - cover), new XYZ(point.X + sizeX - cover, point.Y + cover, point.Z + sizeZ - cover));
            Line rebarlinetop3t = Line.CreateBound(new XYZ(point.X + sizeX - cover, point.Y + cover , point.Z + sizeZ - cover), new XYZ(point.X + sizeX - cover, point.Y + cover, point.Z + cover));
            IList<Curve> curves_d = new List<Curve>();
            curves_d.Add(rebarlinetop1d);
            curves_d.Add(rebarlinetop2d);
            curves_d.Add(rebarlinetop3d);

            IList<Curve> curves_t = new List<Curve>();
            curves_t.Add(rebarlinetop1t);
            curves_t.Add(rebarlinetop2t);
            curves_t.Add(rebarlinetop3t);
            // tạo thép lớp trên 
            Rebar rebartop_d = Rebar.CreateFromCurves(RevitDoc, rebarstyle, rebarBarType, hookAtStart, hookAtEnd, floor, normal, curves_d, startHookOrient, endHookOrient, false, true);
            Rebar rebartop_t = Rebar.CreateFromCurves(RevitDoc, rebarstyle, rebarBarType, hookAtStart, hookAtEnd, floor, normal, curves_t, startHookOrient, endHookOrient, false, true);
            
            // Xét khoảng rải của thép 
            double length_convert = ConvertMMtoFt(length * 1000);
            double spacing_convert = ConvertMMtoFt(spacing);
            int number = (int)(Math.Round(length_convert / spacing_convert));
            if (null != rebartop_d)
            {
                rebartop_d.GetShapeDrivenAccessor().SetLayoutAsNumberWithSpacing(number, spacing_convert, true, true, true);
                rebartop_t.GetShapeDrivenAccessor().SetLayoutAsNumberWithSpacing(number, spacing_convert, true, true, true);
            }
            return rebartop_d;
        }
        public List<RebarShape> GetAllRebarShape(Document doc)
        {
            List<RebarShape> rebarshape = new FilteredElementCollector(doc).OfClass(typeof(RebarShape)).Cast<RebarShape>().ToList();
            return rebarshape;
        }
        public List<RebarBarType> GetAllRebarbarType(Document doc)
        {
            List<RebarBarType> bartype = new FilteredElementCollector(doc).OfClass(typeof(RebarBarType)).Cast<RebarBarType>().ToList();
            return bartype;
        }

        public List<double> khoangcach(double kc1, double kc2, double kcI,double kcII)
        {
            List<double> kc_thep = new List<double>();
            kc_thep.Add(kc1);
            kc_thep.Add(kc2);
            kc_thep.Add(kcI);
            kc_thep.Add(kcII);
            List<double> kc_thep_new = new List<double>();

            foreach (var item in kc_thep)
            {
                string text = item.ToString();
                
                double kc = 200;
                if (item < 200 && item > 100)
                {
                    string hangtram = text.ElementAt(0).ToString();
                    string hangchuc = text.ElementAt(1).ToString();
                    kc = Convert.ToDouble(hangtram) * 100 + Convert.ToDouble(hangchuc) * 10;
                }
                else if (item < 100)
                {
                    string hangchuc = text.ElementAt(0).ToString();
                    kc = Convert.ToDouble(hangchuc) * 10;
                }
                else kc = Convert.ToDouble(200);
                kc_thep_new.Add(kc);
            }
            return kc_thep_new;
        }

        public Rebar PlaceRebarBottom1(Document RevitDoc, RebarBarType rebarBarType, RebarShape rebarShape, RebarHookType hookAtStart, RebarHookType hookAtEnd,
           Floor floor, RebarHookOrientation startHookOrient, RebarHookOrientation endHookOrient, XYZ point, double length, double spacing, double cover)
        {
            RebarStyle rebarstyle = RebarStyle.Standard;

            XYZ normal = new XYZ(1, 0, 0);
            // tạo đường dẫn thép 
            BoundingBoxXYZ boundingBoxXYZ = floor.get_BoundingBox(null);
            double sizeX = boundingBoxXYZ.Max.X - boundingBoxXYZ.Min.X;
            double sizeY = boundingBoxXYZ.Max.Y - boundingBoxXYZ.Min.Y;
            double sizeZ = boundingBoxXYZ.Max.Z - boundingBoxXYZ.Min.Z;

            // khoảng neo cốt thép 
            double v_x1 = ConvertMMtoFt(CommonData.clsSanDatThep.L2 * 1000 * 0.25);
            double v_x2 = ConvertMMtoFt(CommonData.clsSanDatThep.L2 * 1000 * 0.25);

            // Thép lớp trên bên trái 
            Line rebarlinetop1t = Line.CreateBound(new XYZ(point.X + cover, point.Y + cover, point.Z + sizeZ - cover), new XYZ(point.X + cover, point.Y + cover, point.Z + cover));
            Line rebarlinetop2t = Line.CreateBound(new XYZ(point.X + cover, point.Y + cover, point.Z + cover), new XYZ(point.X + cover, point.Y + sizeY-cover, point.Z + cover));
            Line rebarlinetop3t = Line.CreateBound(new XYZ(point.X + cover, point.Y + sizeY - cover, point.Z + cover), new XYZ(point.X + cover, point.Y + sizeY - cover, point.Z + sizeZ - cover));


            // Thép lớp trên bên phải       
            IList<Curve> curves_t = new List<Curve>();
            curves_t.Add(rebarlinetop1t);
            curves_t.Add(rebarlinetop2t);
            curves_t.Add(rebarlinetop3t);


            // tạo thép lớp trên 
            Rebar rebartop_t = Rebar.CreateFromCurves(RevitDoc, rebarstyle, rebarBarType, hookAtStart, hookAtEnd, floor, normal, curves_t, startHookOrient, endHookOrient, false, true);

            // Xét khoảng rải của thép 
            double length_convert = ConvertMMtoFt(length * 1000);
            double spacing_convert = ConvertMMtoFt(spacing);
            int number = (int)(Math.Round(length_convert / spacing_convert));
            if (null != rebartop_t)
            {
                rebartop_t.GetShapeDrivenAccessor().SetLayoutAsNumberWithSpacing(number, spacing_convert, true, true, true);              
            }
            return rebartop_t;
        }

        public Rebar PlaceRebarBottom2(Document RevitDoc, RebarBarType rebarBarType, RebarShape rebarShape, RebarHookType hookAtStart, RebarHookType hookAtEnd,
        Floor floor, RebarHookOrientation startHookOrient, RebarHookOrientation endHookOrient, XYZ point, double length, double spacing, double cover)
        {
            RebarStyle rebarstyle = RebarStyle.Standard;

            XYZ normal = new XYZ(0, 1, 0);

            // tạo đường dẫn thép 
            BoundingBoxXYZ boundingBoxXYZ = floor.get_BoundingBox(RevitDoc.ActiveView);
            double sizeX = boundingBoxXYZ.Max.X - boundingBoxXYZ.Min.X;
            double sizeY = boundingBoxXYZ.Max.Y - boundingBoxXYZ.Min.Y;
            double sizeZ = boundingBoxXYZ.Max.Z - boundingBoxXYZ.Min.Z;

            // khoảng neo cốt thép 
            double v_x1 = ConvertMMtoFt(CommonData.clsSanDatThep.L1 * 1000 * 0.25);
            double v_x2 = ConvertMMtoFt(CommonData.clsSanDatThep.L1 * 1000 * 0.25);
            // Thép lớp trên bên dưới  
            Line rebarlinetop1d = Line.CreateBound(new XYZ(point.X + cover, point.Y + cover, point.Z + sizeZ - cover), new XYZ(point.X + cover, point.Y + cover, point.Z + cover));
            Line rebarlinetop2d = Line.CreateBound(new XYZ(point.X + cover, point.Y + cover, point.Z + cover), new XYZ(point.X  +sizeX-cover, point.Y + cover, point.Z + cover));
            Line rebarlinetop3d = Line.CreateBound(new XYZ(point.X + sizeX - cover, point.Y + cover, point.Z + cover), new XYZ(point.X + sizeX - cover, point.Y + cover, point.Z + sizeZ - cover));


            // Thép lớp trên bên dưới        
            IList<Curve> curves_d = new List<Curve>();
            curves_d.Add(rebarlinetop1d);
            curves_d.Add(rebarlinetop2d);
            curves_d.Add(rebarlinetop3d);


            // tạo thép lớp trên 
            Rebar rebartop_d = Rebar.CreateFromCurves(RevitDoc, rebarstyle, rebarBarType, hookAtStart, hookAtEnd, floor, normal, curves_d, startHookOrient, endHookOrient, false, true);

            // Xét khoảng rải của thép 
            double length_convert = ConvertMMtoFt(length * 1000);
            double spacing_convert = ConvertMMtoFt(spacing);
            int number = (int)(Math.Round(length_convert / spacing_convert));
            if (null != rebartop_d)
            {
                rebartop_d.GetShapeDrivenAccessor().SetLayoutAsNumberWithSpacing(number, spacing_convert, true, true, true);
               
            }
            return rebartop_d;
        }
    }
}
