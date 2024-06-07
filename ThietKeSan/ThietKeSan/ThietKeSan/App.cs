#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Media;
using System.Windows.Media.Imaging;

#endregion

namespace ThietKeSan
{
    class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            const string ribbonTab = "DATN_NguyenXuanMong";
            const string panelData = "Data";
            const string panelDesign = "Design";
            const string panelExport = "Export";
            try
            {
                a.CreateRibbonTab(ribbonTab);
            }
            catch (Exception ex)
            {
                TaskDialog.Show("Error", ex.ToString());
                return Result.Failed;
            }

            RibbonPanel ribbonPanelData = null;
            RibbonPanel ribbonPanelDesign= null;
            RibbonPanel ribbonPanelExport = null;

            ribbonPanelData = a.CreateRibbonPanel(ribbonTab, panelData);
            ribbonPanelDesign = a.CreateRibbonPanel(ribbonTab, panelDesign);
            ribbonPanelExport = a.CreateRibbonPanel(ribbonTab, panelExport);

            #region Tạo nút thêm tải trọng

            Image image_ThemTaiTrong = Properties.Resources.icons8_add_properties_24;
            ImageSource imageSource_ThemTaiTrong = Bmp_GetImage(image_ThemTaiTrong);

            PushButtonData PButtonData_ThemTaiTrong = new PushButtonData("PButton_ThemTaiTrong", "Thêm tải trọng", Assembly.GetExecutingAssembly().Location, "ThietKeSan.Command_ThemTaiTrong")
            {
                ToolTip = "",
                Image = imageSource_ThemTaiTrong,
                LargeImage = imageSource_ThemTaiTrong
            };

            PushButton PButton_ThemTaiTrong = ribbonPanelData.AddItem(PButtonData_ThemTaiTrong) as PushButton;
            #endregion

            #region Tạo nút vật liệu

            Image image_VatLieu = Properties.Resources.icons8_slab_24;
            ImageSource imageSource_VatLieu = Bmp_GetImage(image_VatLieu);

            PushButtonData PButtonData_VatLieu = new PushButtonData("PButton_VatLieu", "Vật liệu", Assembly.GetExecutingAssembly().Location, "ThietKeSan.Command_VatLieu")
            {
                ToolTip = "",
                Image = imageSource_VatLieu,
                LargeImage = imageSource_VatLieu
            };

            PushButton PButton_VatLieu = ribbonPanelData.AddItem(PButtonData_VatLieu) as PushButton;
            #endregion

            #region Tạo nút chọn sàn

            Image image_PickFloor = Properties.Resources.icons8_web_analytics_24;
            ImageSource imageSource_PickFloor = Bmp_GetImage(image_PickFloor);

            PushButtonData PButtonData_PickFloor = new PushButtonData("PButton_PickFloor", "Thông tin sàn", Assembly.GetExecutingAssembly().Location, "ThietKeSan.Command_PickFloor")
            {
                ToolTip = "",
                Image = imageSource_PickFloor,
                LargeImage = imageSource_PickFloor
            };

            PushButton PButton_PickFloor = ribbonPanelData.AddItem(PButtonData_PickFloor) as PushButton;
            #endregion
    
            #region Tạo nút tính thép

            Image image_TinhThep = Properties.Resources.icons8_reinforced_concrete_24;
            ImageSource imageSource_TinhThep = Bmp_GetImage(image_TinhThep);

            PushButtonData PButtonData_TinhThep = new PushButtonData("PButton_TinhThep", "Tính thép", Assembly.GetExecutingAssembly().Location, "ThietKeSan.Command_TinhThep")
            {
                ToolTip = "",
                Image = imageSource_TinhThep,
                LargeImage = imageSource_TinhThep
            };

            PushButton PButton_TinhThep = ribbonPanelDesign.AddItem(PButtonData_TinhThep) as PushButton;
            #endregion

            #region Tạo nút bố trí

            Image image_BoTriThep = Properties.Resources.icons8_arrange_24;
            ImageSource imageSource_BoTriThep = Bmp_GetImage(image_BoTriThep);

            PushButtonData PButtonData_BoTriThep = new PushButtonData("PButton_BoTriThep", "Bố trí thép", Assembly.GetExecutingAssembly().Location, "ThietKeSan.Command_BoTriThep")
            {
                ToolTip = "",
                Image = imageSource_BoTriThep,
                LargeImage = imageSource_BoTriThep
            };

            PushButton PButton_BoTriThep = ribbonPanelDesign.AddItem(PButtonData_BoTriThep) as PushButton;
            #endregion

            #region Tạo thuyết minh

            Image image_ThuyetMinh = Properties.Resources.icons8_words_24;
            ImageSource imageSource_ThuyetMinh = Bmp_GetImage(image_ThuyetMinh);

            PushButtonData PButtonData_ThuyetMinh = new PushButtonData("PButton_ThuyetMinh", "Thuyết minh", Assembly.GetExecutingAssembly().Location, "ThietKeSan.Command_TM")
            {
                ToolTip = "",
                Image = imageSource_ThuyetMinh,
                LargeImage = imageSource_ThuyetMinh
            };

            PushButton PButton_ThuyetMinh = ribbonPanelExport.AddItem(PButtonData_ThuyetMinh) as PushButton;
            #endregion
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
        private BitmapSource Bmp_GetImage(Image img)
        {
            BitmapImage bmp = new BitmapImage();
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                ms.Position = 0;
                bmp.BeginInit();
                bmp.CacheOption = BitmapCacheOption.OnLoad;
                bmp.UriSource = null;
                bmp.StreamSource = ms;
                bmp.EndInit();
            }
            return bmp;
        }
    }
}
