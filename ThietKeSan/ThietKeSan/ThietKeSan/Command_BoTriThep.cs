#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
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
    public class Command_BoTriThep : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            Singleton.Instance = new Singleton();
            Singleton.Instance.RevitData.UIApplication = commandData.Application;
            Function func = new Function();
            Document doc = Singleton.Instance.RevitData.Document;

            #region Them Dk thep
            CommonData.list_reabar.Add("6");
            CommonData.list_reabar.Add("8");
            CommonData.list_reabar.Add("10");
            CommonData.list_reabar.Add("12");
            CommonData.list_reabar.Add("14");
            CommonData.list_reabar.Add("16");
            CommonData.list_reabar.Add("18");
            CommonData.list_reabar.Add("20");
            CommonData.list_reabar.Add("22");
            CommonData.list_reabar.Add("25");
            CommonData.list_reabar.Add("28");
            CommonData.list_reabar.Add("30");
            CommonData.list_reabar.Add("35");
            #endregion

            using (Transaction tx = new Transaction(doc))
            {
                tx.Start("Dat Thep");
                CommonData.lst_rebarbartype = func.GetAllRebarbarType(doc);
                if (CommonData.checkcreaterebar != "ok")
                {
                    foreach (var item in CommonData.list_reabar)
                    {
                        func.Create_RebarbarType(doc, item, CommonData.lst_rebarbartype);
                    }
                    CommonData.checkcreaterebar = "ok";
                }
                try
                {
                    var dlg = Singleton.Instance.FormData.Botrithep.ShowDialog();
                    if (dlg == System.Windows.Forms.DialogResult.OK)
                    {


                        List<double> lst_kc = func.khoangcach(CommonData.clsSanDatThep.kc1, CommonData.clsSanDatThep.kc2, CommonData.clsSanDatThep.kcI, CommonData.clsSanDatThep.kcII);
                        CommonData.clsSanDatThep.tinh_thep4canh(CommonData.clsSanDatThep.Φ1, CommonData.clsSanDatThep.kc1, CommonData.clsSanDatThep.Φ2, CommonData.clsSanDatThep.kc2, CommonData.clsSanDatThep.ΦI, CommonData.clsSanDatThep.kcI, CommonData.clsSanDatThep.ΦII, CommonData.clsSanDatThep.kcII);

                        CommonData.lst_rebarshape = func.GetAllRebarShape(doc);
                        CommonData.lst_rebarbartype.Clear();
                        CommonData.lst_rebarbartype = func.GetAllRebarbarType(doc);
                        RebarHookType hookType = func.GetRebarHook(doc);

                        RebarBarType rebarBarType1 = CommonData.lst_rebarbartype.Where(k => func.ConvertFttoMM(k.BarNominalDiameter) == CommonData.clsSanDatThep.Φ1).First();
                        RebarBarType rebarBarType2 = CommonData.lst_rebarbartype.Where(k => func.ConvertFttoMM(k.BarNominalDiameter) == CommonData.clsSanDatThep.Φ2).First();
                        RebarBarType rebarBarType3 = CommonData.lst_rebarbartype.Where(k => func.ConvertFttoMM(k.BarNominalDiameter) == CommonData.clsSanDatThep.ΦI).First();
                        RebarBarType rebarBarType4 = CommonData.lst_rebarbartype.Where(k => func.ConvertFttoMM(k.BarNominalDiameter) == CommonData.clsSanDatThep.ΦII).First();

                        RebarShape rebarShape = CommonData.lst_rebarshape.Where(k => k.Name == "M_00").First();

                        Floor floorDatThep = doc.GetElement(CommonData.clsSanDatThep.ID) as Floor;

                        var rebarsInHost = RebarHostData.GetRebarHostData(floorDatThep).GetRebarsInHost();
                        if (rebarsInHost != null && rebarsInHost.Count() > 0)
                        {
                            doc.Delete(rebarsInHost.Select(k=>k.Id).ToList());
                        }
                         var bdbox = floorDatThep.get_BoundingBox(null);

                        func.PlaceRebarTop1(doc, rebarBarType1, rebarShape, null, null, floorDatThep, RebarHookOrientation.Left, RebarHookOrientation.Left, bdbox.Min, CommonData.clsSanDatThep.L2, lst_kc[0], 15 / 304.8);
                        func.PlaceRebarBottom1(doc, rebarBarType3, rebarShape, null, null, floorDatThep, RebarHookOrientation.Left, RebarHookOrientation.Left, bdbox.Min, CommonData.clsSanDatThep.L2, lst_kc[1], 15 / 304.8);
                        func.PlaceRebarTop2(doc, rebarBarType2, rebarShape, null, null, floorDatThep, RebarHookOrientation.Left, RebarHookOrientation.Left, bdbox.Min, CommonData.clsSanDatThep.L1, lst_kc[2], 15 / 304.8);
                        func.PlaceRebarBottom2(doc, rebarBarType4, rebarShape, null, null, floorDatThep, RebarHookOrientation.Left, RebarHookOrientation.Left, bdbox.Min, CommonData.clsSanDatThep.L1, lst_kc[3], 15 / 304.8);
                       
                        MessageBox.Show("Đặt thép xong", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                tx.Commit();
            }
           
           
            return Result.Succeeded;
        }
    }
    
}
