#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using static ThietKeSan.SingleData;

#endregion

namespace ThietKeSan
{
    [Transaction(TransactionMode.Manual)]
    public class Command_VatLieu : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            Singleton.Instance = new Singleton();
            Singleton.Instance.RevitData.UIApplication = commandData.Application;
            Singleton.Instance.FormData.FormVatLieu.ShowDialog();
            return Result.Succeeded;
        }
    }
   
    
}
