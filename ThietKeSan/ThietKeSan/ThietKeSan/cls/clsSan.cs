using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThietKeSan
{
    public class clsSan
    {
        private string _betong;
        private double _Rb;
        private double _Rbt;
        private double _Eb;
        private string _Thep;
        private double _Rs;
        private double _Rsc;
        private double _Es;
        private string _tensan;
        private double _L1;
        private double _L2;
        private double _tyle;
        private double _hs;
        private double _a;
        private double _ho;
        private string _TT;
        private string _HT;
        private double _gb;
        private double _pb;
        private double _qb;
        private string _sodo;
        // ban dam
        private double _Mnhip;
        private double _alphaNhip;
        private double _ζnhip;
        private double _Asnhip;
        private double _μnhip;
        private double _Φnhip;
        private double _kcnhip;
        private double _AschonNhip;

        private double _Mgoi;
        private double _alphaGoi;
        private double _ζgoi;
        private double _Asgoi;
        private double _μgoi;
        private double _Φgoi;
        private double _kcgoi;
        private double _AschonGoi;
        // ban ke 4 canh
        private double _a1;
        private double _a2;
        private double _b1;
        private double _b2;

        private double _M1;
        private double _alpha1;
        private double _ζ1;
        private double _As1;
        private double _μ1;
        public int _Φ1;
        public double _kc1;
        private double _Aschon1;

        private double _M2;
        private double _alpha2;
        private double _ζ2;
        private double _As2;
        private double _μ2;
        private int _Φ2;
        private double _kc2;
        private double _Aschon2;

        private double _MI;
        private double _alphaI;
        private double _ζI;
        private double _AsI;
        private double _μI;
        private int _ΦI;
        private double _kcI;
        private double _AschonI;

        private double _MII;
        private double _alphaII;
        private double _ζII;
        private double _AsII;
        private double _μII;
        private int _ΦII;
        private double _kcII;
        private double _AschonII;
        private ElementId _id;
        private StatusPlaceRebar _status = StatusPlaceRebar.NotPlaced;
        public StatusPlaceRebar Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        public ElementId ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Betong
        {
            get
            {
                return _betong;
            }
            set
            {
                _betong = value;
            }
        }
        public double Rb
        {
            get
            {
                return _Rb;
            }
            set
            {
                _Rb = value;
            }
        }

        public double Rbt
        {
            get
            {
                return _Rbt;
            }
            set
            {
                _Rbt = value;
            }
        }

        public double Eb
        {
            get
            {
                return _Eb;
            }
            set
            {
                _Eb = value;
            }
        }

        public string Thep
        {
            get
            {
                return _Thep;
            }
            set
            {
                _Thep = value;
            }
        }

        public double Rs
        {
            get
            {
                return _Rs;
            }
            set
            {
                _Rs = value;
            }
        }

        public double Rsc
        {
            get
            {
                return _Rsc;
            }
            set
            {
                _Rsc = value;
            }
        }

        public double Es
        {
            get
            {
                return _Es;
            }
            set
            {
                _Es = value;
            }
        }

        public string tensan
        {
            get
            {
                return _tensan;
            }
            set
            {
                _tensan = value;
            }
        }
        public string sodo
        {
            get
            {
                return _sodo;
            }
            set
            {
                _sodo = value;
            }
        }
        public double L1
        {
            get
            {
                return _L1;
            }
            set
            {
                _L1 = value;
            }
        }
        public double L2
        {
            get
            {
                return _L2;
            }
            set
            {
                _L2 = value;
            }
        }

        public double TyLe
        {
            get
            {
                _tyle = Math.Round(_L2 / (double)_L1, 3);
                return _tyle;
            }
        }

        public double Hs
        {
            get
            {
                return _hs;
            }
            set
            {
                _hs = value;
            }
        }
        public double a
        {
            get
            {
                return _a;
            }
            set
            {
                _a = value;
            }
        }
        public double Ho
        {
            get
            {
                _ho = _hs - _a;
                return _ho;
            }
        }
        public string TT
        {
            get
            {
                return _TT;
            }
            set
            {
                _TT = value;
            }
        }
        public string HT
        {
            get
            {
                return _HT;
            }
            set
            {
                _HT = value;
            }
        }
        public double gb
        {
            get
            {
                return _gb;
            }
            set
            {
                _gb = value;
            }
        }
        public double pb
        {
            get
            {
                return _pb;
            }
            set
            {
                _pb = value;
            }
        }
        public double qb
        {
            get
            {
                _qb = _gb + _pb;
                return _qb;
            }
        }
        public double Mnhip
        {
            get
            {
                return _Mnhip;
            }
            set
            {
                _Mnhip = value;
            }
        }
        public double alphaNhip
        {
            get
            {
                return _alphaNhip;
            }
            set
            {
                _alphaNhip = value;
            }
        }
        public double ζnhip
        {
            get
            {
                return _ζnhip;
            }
            set
            {
                _ζnhip = value;
            }
        }
        public double Asnhip
        {
            get
            {
                return _Asnhip;
            }
            set
            {
                _Asnhip = value;
            }
        }
        public double μnhip
        {
            get
            {
                return _μnhip;
            }
            set
            {
                _μnhip = value;
            }
        }
        public double Φnhip
        {
            get
            {
                return _Φnhip;
            }
            set
            {
                _Φnhip = value;
            }
        }
        public double kcNhip
        {
            get
            {
                return _kcnhip;
            }
            set
            {
                _kcnhip = value;
            }
        }
        public double AschonNhip
        {
            get
            {
                return _AschonNhip;
            }
            set
            {
                _AschonNhip = value;
            }
        }

        public double Mgoi
        {
            get
            {
                return _Mgoi;
            }
            set
            {
                _Mgoi = value;
            }
        }
        public double alphaGoi
        {
            get
            {
                return _alphaGoi;
            }
            set
            {
                _alphaGoi = value;
            }
        }
        public double ζgoi
        {
            get
            {
                return _ζgoi;
            }
            set
            {
                _ζgoi = value;
            }
        }
        public double Asgoi
        {
            get
            {
                return _Asgoi;
            }
            set
            {
                _Asgoi = value;
            }
        }
        public double μgoi
        {
            get
            {
                return _μgoi;
            }
            set
            {
                _μgoi = value;
            }
        }
        public double Φgoi
        {
            get
            {
                return _Φgoi;
            }
            set
            {
                _Φgoi = value;
            }
        }
        public double kcGoi
        {
            get
            {
                return _kcgoi;
            }
            set
            {
                _kcgoi = value;
            }
        }
        public double AscchonGoi
        {
            get
            {
                return _AschonGoi;
            }
            set
            {
                _AschonGoi = value;
            }
        }

        public double M1
        {
            get
            {
                return _M1;
            }
            set
            {
                _M1 = value;
            }
        }
        public double alpha1
        {
            get
            {
                return _alpha1;
            }
            set
            {
                _alpha1 = value;
            }
        }
        public double ζ1
        {
            get
            {
                return _ζ1;
            }
            set
            {
                _ζ1 = value;
            }
        }
        public double As1
        {
            get
            {
                return _As1;
            }
            set
            {
                _As1 = value;
            }
        }
        public double μ1
        {
            get
            {
                return _μ1;
            }
            set
            {
                _μ1 = value;
            }
        }
        public int Φ1
        {
            get
            {
                return _Φ1;
            }
            set
            {
                _Φ1 = value;
            }
        }
        public double kc1
        {
            get
            {
                return _kc1;
            }
            set
            {
                _kc1 = value;
            }
        }
        public double Aschon1
        {
            get
            {
                return _Aschon1;
            }
            set
            {
                _Aschon1 = value;
            }
        }

        public double M2
        {
            get
            {
                return _M2;
            }
            set
            {
                _M2 = value;
            }
        }
        public double alpha2
        {
            get
            {
                return _alpha2;
            }
            set
            {
                _alpha2 = value;
            }
        }
        public double ζ2
        {
            get
            {
                return _ζ2;
            }
            set
            {
                _ζ2 = value;
            }
        }
        public double As2
        {
            get
            {
                return _As2;
            }
            set
            {
                _As2 = value;
            }
        }
        public double μ2
        {
            get
            {
                return _μ2;
            }
            set
            {
                _μ2 = value;
            }
        }
        public int Φ2
        {
            get
            {
                return _Φ2;
            }
            set
            {
                _Φ2 = value;
            }
        }
        public double kc2
        {
            get
            {
                return _kc2;
            }
            set
            {
                _kc2 = value;
            }
        }
        public double Aschon2
        {
            get
            {
                return _Aschon2;
            }
            set
            {
                _Aschon2 = value;
            }
        }

        public double MI
        {
            get
            {
                return _MI;
            }
            set
            {
                _MI = value;
            }
        }
        public double alphaI
        {
            get
            {
                return _alphaI;
            }
            set
            {
                _alphaI = value;
            }
        }
        public double ζI
        {
            get
            {
                return _ζI;
            }
            set
            {
                _ζI = value;
            }
        }
        public double AsI
        {
            get
            {
                return _AsI;
            }
            set
            {
                _AsI = value;
            }
        }
        public double μI
        {
            get
            {
                return _μI;
            }
            set
            {
                _μI = value;
            }
        }
        public int ΦI
        {
            get
            {
                return _ΦI;
            }
            set
            {
                _ΦI = value;
            }
        }
        public double kcI
        {
            get
            {
                return _kcI;
            }
            set
            {
                _kcI = value;
            }
        }
        public double AschonI
        {
            get
            {
                return _AschonI;
            }
            set
            {
                _AschonI = value;
            }
        }
        public double MII
        {
            get
            {
                return _MII;
            }
            set
            {
                _MII = value;
            }
        }
        public double alphaII
        {
            get
            {
                return _alphaII;
            }
            set
            {
                _alphaII = value;
            }
        }
        public double ζII
        {
            get
            {
                return _ζII;
            }
            set
            {
                _ζII = value;
            }
        }
        public double AsII
        {
            get
            {
                return _AsII;
            }
            set
            {
                _AsII = value;
            }
        }
        public double μII
        {
            get
            {
                return _μII;
            }
            set
            {
                _μII = value;
            }
        }
        public int ΦII
        {
            get
            {
                return _ΦII;
            }
            set
            {
                _ΦII = value;
            }
        }
        public double kcII
        {
            get
            {
                return _kcII;
            }
            set
            {
                _kcII = value;
            }
        }
        public double AschonII
        {
            get
            {
                return _AschonII;
            }
            set
            {
                _AschonII = value;
            }
        }

        public double a1
        {
            get
            {
                return _a1;
            }
            set
            {
                _a1 = value;
            }
        }
        public double a2
        {
            get
            {
                return _a2;
            }
            set
            {
                _a2 = value;
            }
        }
        public double b1
        {
            get
            {
                return _b1;
            }
            set
            {
                _b1 = value;
            }
        }
        public double b2
        {
            get
            {
                return _b2;
            }
            set
            {
                _b2 = value;
            }
        }

        public void tinh_noisuy(double ns_a1, double ns_a2, double ns_b1, double ns_b2)
        {
            this.a1 = ns_a1;
            this.a2 = ns_a2;
            this.b1 = ns_b1;
            this.b2 = ns_b2;
        }

        public void tinh_San4ccanh(double M1, double alpha1, double ζ1, double As1, double μ1
                                 , double M2, double alpha2, double ζ2, double As2, double μ2
                                 , double MI, double alphaI, double ζI, double AsI, double μI
                                 , double MII, double alphaII, double ζII, double AsII, double μII)
        {
            this.M1 = M1;
            this.alpha1 = alpha1;
            this.ζ1 = ζ1;
            this.As1 = As1;
            this.μ1 = μ1;

            this.M2 = M2;
            this.alpha2 = alpha2;
            this.ζ2 = ζ2;
            this.As2 = As2;
            this.μ2 = μ2;

            this.MI = MI;
            this.alphaI = alphaI;
            this.ζI = ζI;
            this.AsI = AsI;
            this.μI = μI;

            this.MII = MII;
            this.alphaII = alphaII;
            this.ζII = ζII;
            this.AsII = AsII;
            this.μII = μII;
        }

        public void tinh_thep4canh(int Φ1, double kc1, int Φ2, double kc2, int ΦI, double kcI, int ΦII, double kcII)
        {
            this.Φ1 = Φ1;
            this.kc1 = kc1;
           

            this.Φ2 = Φ2;
            this.kc2 = kc2;
            

            this.ΦI = ΦI;
            this.kcI = kcI;
            

            this.ΦII = ΦII;
            this.kcII = kcII;
           
        }

        // Thông tin thép lớp trên và lớp dưới 
        //public RebarTop rebartop { get;set; }
        //public RebarBottom rebarbottom { get;set; }

        public Rebar PlaceRebarTop(Document RevitDoc, RebarBarType rebarBarType, RebarShape rebarShape, RebarHookType hookAtStart, RebarHookType hookAtEnd,
           Floor floor, RebarHookOrientation startHookOrient, RebarHookOrientation endHookOrient, XYZ point, double length, double spacing, double cover)
        {
            RebarStyle rebarstyle = RebarStyle.StirrupTie;

            XYZ normal = null;
            normal = new XYZ(0, 0, 1);

            // create rebar line
            BoundingBoxXYZ boundingBoxXYZ = floor.get_BoundingBox(RevitDoc.ActiveView);
            double sizeX = boundingBoxXYZ.Max.X - boundingBoxXYZ.Min.X;
            double sizeY = boundingBoxXYZ.Max.Y - boundingBoxXYZ.Min.Y;

            Line rebarLine1 = Line.CreateBound(new XYZ(point.X + cover, point.Y + cover, point.Z), new XYZ(point.X + cover, point.Y + sizeY - cover, point.Z));
            Line rebarLine2 = Line.CreateBound(new XYZ(point.X + cover, point.Y + sizeY - cover, point.Z), new XYZ(point.X + sizeX - cover, point.Y + sizeY - cover, point.Z));
            Line rebarLine3 = Line.CreateBound(new XYZ(point.X + sizeX - cover, point.Y + sizeY - cover, point.Z), new XYZ(point.X + sizeX - cover, point.Y + cover, point.Z));
            Line rebarLine4 = Line.CreateBound(new XYZ(point.X + sizeX - cover, point.Y + cover, point.Z), new XYZ(point.X + cover, point.Y + cover, point.Z));

            // Create the line rebar
            IList<Curve> curves = new List<Curve>();
            curves.Add(rebarLine1);
            curves.Add(rebarLine2);
            curves.Add(rebarLine3);
            curves.Add(rebarLine4);

            Rebar rebar = null;
            if (rebarShape != null)
            {
                rebar = Rebar.CreateFromRebarShape(RevitDoc, rebarShape, rebarBarType, floor, point, new XYZ(1, 0, 0), new XYZ(0, 1, 0));
                rebar.GetShapeDrivenAccessor().ScaleToBox(new XYZ(point.X + cover, point.Y + cover, point.Z), new XYZ(sizeX - 2 * cover, 0, 0), new XYZ(0, sizeY - 2 * cover, 0));
            }
            else
            {
                rebar = Rebar.CreateFromCurves(RevitDoc, rebarstyle, rebarBarType, hookAtStart, hookAtEnd, floor, normal, curves, startHookOrient, endHookOrient, false, true);
                rebar.GetShapeDrivenAccessor().ScaleToBox(new XYZ(point.X + cover, point.Y + cover, point.Z), new XYZ(sizeX - 2 * cover, 0, 0), new XYZ(0, sizeY - 2 * cover, 0));
            }

            int number = (int)(Math.Round(length / spacing));
            if (null != rebar)
            {
                rebar.GetShapeDrivenAccessor().SetLayoutAsNumberWithSpacing(number, spacing, true, true, true);
            }
            return rebar;
        }
    }
    public enum StatusPlaceRebar
    {
        Placed,
        NotPlaced,
    }
}
