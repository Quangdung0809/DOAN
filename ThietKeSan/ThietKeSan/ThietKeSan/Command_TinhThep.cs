#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using static ThietKeSan.SingleData;

#endregion

namespace ThietKeSan
{
    [Transaction(TransactionMode.Manual)]
    public class Command_TinhThep : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            TinhThep();
            return Result.Succeeded;
        }

        private void TinhThep()
        {
            if (CommonData.lst_clssan?.Count < 1) return;
            foreach (var item in CommonData.lst_clssan)
            {
                DataTable table = Function.bangTra9();

                var tinh4canh = item;
                var noisuy_tinh = new clsSan();

                for (int j = 0; j < table.Rows.Count - 1; j++)
                {

                    if (Convert.ToDouble(table.Rows[j][0]) == item.TyLe)
                    {
                        noisuy_tinh.a1 = Convert.ToDouble(table.Rows[j][1]);
                        noisuy_tinh.a2 = Convert.ToDouble(table.Rows[j][2]);
                        noisuy_tinh.b1 = Convert.ToDouble(table.Rows[j][3]);
                        noisuy_tinh.b2 = Convert.ToDouble(table.Rows[j][4]);

                        tinh4canh.tinh_noisuy(noisuy_tinh.a1, noisuy_tinh.a2, noisuy_tinh.b1, noisuy_tinh.b2);
                        break;
                    }
                    else if (Convert.ToDouble(table.Rows[j][0]) < item.TyLe && item.TyLe < Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][0]))
                    {
                        noisuy_tinh.a1 = Convert.ToDouble(table.Rows[j][1]) + (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][1]) - Convert.ToDouble(table.Rows[j][1])) * (item.TyLe - Convert.ToDouble(table.Rows[j][0])) / (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][1]) - Convert.ToDouble(table.Rows[j][0]));
                        noisuy_tinh.a2 = Convert.ToDouble(table.Rows[j][2]) + (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][2]) - Convert.ToDouble(table.Rows[j][2])) * (item.TyLe - Convert.ToDouble(table.Rows[j][0])) / (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][1]) - Convert.ToDouble(table.Rows[j][0]));
                        noisuy_tinh.b1 = Convert.ToDouble(table.Rows[j][3]) + (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][3]) - Convert.ToDouble(table.Rows[j][3])) * (item.TyLe - Convert.ToDouble(table.Rows[j][0])) / (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][1]) - Convert.ToDouble(table.Rows[j][0]));
                        noisuy_tinh.b2 = Convert.ToDouble(table.Rows[j][4]) + (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][4]) - Convert.ToDouble(table.Rows[j][4])) * (item.TyLe - Convert.ToDouble(table.Rows[j][0])) / (Convert.ToDouble(table.Rows[Convert.ToInt32(Operators.AddObject(j, 1))][1]) - Convert.ToDouble(table.Rows[j][0]));
                        tinh4canh.tinh_noisuy(noisuy_tinh.a1, noisuy_tinh.a2, noisuy_tinh.b1, noisuy_tinh.b2);
                        break;
                    }
                }
                double a1 = tinh4canh.a1;
                double a2 = tinh4canh.a2;
                double b1 = tinh4canh.b1;
                double b2 = tinh4canh.b2;
                double qb = item.qb;
                double L1 = item.L1;
                double L2 = item.L2;


                tinh4canh.M1 = Math.Round(a1 * qb * L1 * L2, 3);
                tinh4canh.M2 = Math.Round(a2 * qb * L1 * L2, 3);
                tinh4canh.MI = Math.Round(b1 * qb * L1 * L2, 3);
                tinh4canh.MII = Math.Round(b2 * qb * L1 * L2, 3);

                tinh4canh.alpha1 = Function.tinhalpha(tinh4canh.M1, item.Ho);
                tinh4canh.ζ1 = Function.tinhζ(tinh4canh.alpha1);
                tinh4canh.As1 = Function.tinhAs(tinh4canh.M1 * Math.Pow(10d, 6d), tinh4canh.ζ1, item.Ho);
                tinh4canh.μ1 = Function.tinhμ(tinh4canh.As1, item.Ho * 1000);

                tinh4canh.alpha2 = Function.tinhalpha(tinh4canh.M2, item.Ho);
                tinh4canh.ζ2 = Function.tinhζ(tinh4canh.alpha2);
                tinh4canh.As2 = Function.tinhAs(tinh4canh.M2 * Math.Pow(10d, 6d), tinh4canh.ζ2, item.Ho);
                tinh4canh.μ2 = Function.tinhμ(tinh4canh.As2, item.Ho * 1000);

                tinh4canh.alphaI = Function.tinhalpha(tinh4canh.MI, item.Ho);
                tinh4canh.ζI = Function.tinhζ(tinh4canh.alphaI);
                tinh4canh.AsI = Function.tinhAs(tinh4canh.MI * Math.Pow(10d, 6d), tinh4canh.ζI, item.Ho);
                tinh4canh.μI = Function.tinhμ(tinh4canh.AsI, item.Ho * 1000);

                tinh4canh.alphaII = Function.tinhalpha(tinh4canh.MII, item.Ho);
                tinh4canh.ζII = Function.tinhζ(tinh4canh.alphaII);
                tinh4canh.AsII = Function.tinhAs(tinh4canh.MII * Math.Pow(10d, 6d), tinh4canh.ζII, item.Ho);
                tinh4canh.μII = Function.tinhμ(tinh4canh.AsII, item.Ho * 1000);
                item.tinh_San4ccanh(tinh4canh.M1, tinh4canh.alpha1, tinh4canh.ζ1, tinh4canh.As1, tinh4canh.μ1,
                                         tinh4canh.M2, tinh4canh.alpha2, tinh4canh.ζ2, tinh4canh.As2, tinh4canh.μ2,
                                         tinh4canh.MI, tinh4canh.alphaI, tinh4canh.ζI, tinh4canh.AsI, tinh4canh.μI,
                                         tinh4canh.MII, tinh4canh.alphaII, tinh4canh.ζII, tinh4canh.AsII, tinh4canh.μII);
            }
            MessageBox.Show("Tính toán thép thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
   
    
}
