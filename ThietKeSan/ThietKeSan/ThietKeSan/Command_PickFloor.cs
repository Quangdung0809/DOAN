#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using static ThietKeSan.SingleData;

#endregion

namespace ThietKeSan
{
    [Transaction(TransactionMode.Manual)]
    public class Command_PickFloor : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,ref string message,ElementSet elements)
        {
            Singleton.Instance = new Singleton();
            Singleton.Instance.RevitData.UIApplication = commandData.Application;
            Document RevitDoc = Singleton.Instance.RevitData.Document;           
            CommonData.DK = string.Empty;
            CommonData.clsSan = null;
            pickFloor:
            Singleton.Instance.FormData.Thongtinsan.ShowDialog();
            if (CommonData.DK == "Pick") 
            {           
                Singleton.Instance.FormData.Thongtinsan.Close();
                PickFloor(RevitDoc);           
                goto pickFloor;
            }
            return Result.Succeeded;
        }
        private void PickFloor(Document RevitDoc)
        {
            Function func = new Function();
            Singleton.Instance.RevitData.Transaction.Start();
            Reference rf = null;
            try
            {
                rf = Singleton.Instance.RevitData.Selection.PickObject(ObjectType.Element, new FloorSelectionFilter(), "Chọn sàn cần tính thép");
                Element element = RevitDoc.GetElement(rf);
                Floor floor = element as Floor;
                if (floor.get_Parameter(BuiltInParameter.FLOOR_PARAM_IS_STRUCTURAL).AsValueString() == "No")
                {
                    MessageBox.Show("Sàn đang chọn là sàn kiến trúc không thể đặt thép", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    CommonData.DK = "Close";
                    Singleton.Instance.RevitData.Transaction.RollBack();
                    return;
                }
                CommonData.Floor = floor;
                CommonData.clsSan = new clsSan();
                CommonData.clsSan = func.GetFloor(floor);
                CreatSectionofFloor1(RevitDoc, floor, "View Section 1 - 1", 0.5);
                CreatSectionofFloor2(RevitDoc, floor, "View Section 2 - 2", 0.5);
                CommonData.DK = "Close";
            }
            catch (System.Exception)
            {
                MessageBox.Show("Chưa chọn sàn!");
                CommonData.DK = "Close";
                Singleton.Instance.RevitData.Transaction.RollBack();
            }
            Singleton.Instance.RevitData.Transaction.Commit();       
        }

        private ViewSection CreatSectionofFloor1(Document doc, Element element, string viewName, double offset)
        {
            BoundingBoxXYZ bbox = element.get_BoundingBox(null);
            if (bbox == null) return null;
            double l1 = (bbox.Max.Y - bbox.Min.Y);

            XYZ origin = bbox.Min;

            XYZ viewdir = XYZ.BasisX;
            XYZ up = XYZ.BasisZ;
            XYZ right = up.CrossProduct(viewdir);

            Transform transform = Transform.Identity;
            transform.Origin = origin + viewdir * l1 * offset;
            transform.BasisX = right;
            transform.BasisY = up;
            transform.BasisZ = viewdir;

            BoundingBoxXYZ sectionBox = new BoundingBoxXYZ();
            sectionBox.Transform = transform;

            double d = l1;
            BoundingBoxXYZ bb = element.get_BoundingBox(null);
            double minZ = bb.Min.Z;
            double maxZ = bb.Max.Z;
            double h = maxZ - minZ;

            sectionBox.Min = new XYZ(-d * 0.2, -1, 0);
            sectionBox.Max = new XYZ(d * 1.2, h + 1, 0.1);

            ViewFamilyType viewFamilyType = new FilteredElementCollector(doc).OfClass(typeof(ViewFamilyType)).Cast<ViewFamilyType>().FirstOrDefault(x => x.ViewFamily == ViewFamily.Section);

            ViewSection sectionView = null;

            FilteredElementCollector collector = new FilteredElementCollector(doc);
            ICollection<Element> sectionElements = collector.OfCategory(BuiltInCategory.OST_Views).WhereElementIsNotElementType().ToElements();
            foreach (Element elem in sectionElements)
            {
                ViewSection viewSection = elem as ViewSection;
                if (viewSection != null && viewSection.Name == (viewName + " " + element.Id.ToString()))
                {
                    sectionView = viewSection;
                    break;
                }
            }
            if (sectionView == null) { sectionView = ViewSection.CreateSection(doc, viewFamilyType.Id, sectionBox); sectionView.get_Parameter(BuiltInParameter.VIEW_NAME).Set(viewName + " " + element.Id.ToString());}

            return sectionView;
        }
        private ViewSection CreatSectionofFloor2(Document doc, Element element, string viewName, double offset)
        {
            BoundingBoxXYZ bbox = element.get_BoundingBox(null);
            if (bbox == null) return null;
            double l2 = (bbox.Max.X - bbox.Min.X);

            XYZ origin = bbox.Min;

            XYZ viewdir = XYZ.BasisY;
            XYZ up = XYZ.BasisZ;
            XYZ right = up.CrossProduct(viewdir);

            Transform transform = Transform.Identity;
            transform.Origin = origin + viewdir * l2 * offset;
            transform.BasisX = right;
            transform.BasisY = up;
            transform.BasisZ = viewdir;

            BoundingBoxXYZ sectionBox = new BoundingBoxXYZ();
            sectionBox.Transform = transform;

            double d = l2;
            BoundingBoxXYZ bb = element.get_BoundingBox(null);
            double minZ = bb.Min.Z;
            double maxZ = bb.Max.Z;
            double h = maxZ - minZ;

            sectionBox.Min = new XYZ(-d * 1.2, -1, 0);
            sectionBox.Max = new XYZ(d * 0.2, h + 1, 0.1);

            ViewFamilyType viewFamilyType = new FilteredElementCollector(doc).OfClass(typeof(ViewFamilyType)).Cast<ViewFamilyType>().FirstOrDefault(x => x.ViewFamily == ViewFamily.Section);

            ViewSection sectionView = null;

            FilteredElementCollector collector = new FilteredElementCollector(doc);
            ICollection<Element> sectionElements = collector.OfCategory(BuiltInCategory.OST_Views).WhereElementIsNotElementType().ToElements();
            foreach (Element elem in sectionElements)
            {
                ViewSection viewSection = elem as ViewSection;
                if (viewSection != null && viewSection.Name == (viewName + " " + element.Id.ToString()))
                {
                    sectionView = viewSection;
                    break;
                }
            }
            if (sectionView == null) { sectionView = ViewSection.CreateSection(doc, viewFamilyType.Id, sectionBox); sectionView.get_Parameter(BuiltInParameter.VIEW_NAME).Set((viewName + " " + element.Id.ToString())); }

            return sectionView;
        }
        public XYZ GetPoint(Floor floor)
        {
            var bdbxyz = floor.get_BoundingBox(null);
            return bdbxyz.Min;
        }
    }
    public class FloorSelectionFilter : ISelectionFilter
    {
        public bool AllowElement(Element elem)
        {
            if (elem.Category == null) return false;
            if (elem.Category.Id.IntegerValue == (int)BuiltInCategory.OST_Floors)
            {
                return true;
            }
            return false;
        }
        public bool AllowReference(Reference reference, XYZ position)
        {
            return false;
        }
    }
}
