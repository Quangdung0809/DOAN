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
    public class Command_TM : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Singleton.Instance = new Singleton();
            Singleton.Instance.RevitData.UIApplication = commandData.Application;
            Function func = new Function();
            Document doc = Singleton.Instance.RevitData.Document;

            Singleton.Instance.FormData.FormThuyetMinh.ShowDialog();

            return Result.Succeeded;
        }
    }
    
}
