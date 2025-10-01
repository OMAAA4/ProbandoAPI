using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Forms
{
    internal static class ModificacionInterfaz
    {
        public static void RedondearLabel(Label lbl, int radio)
        {
            var rect = lbl.ClientRectangle;
            var path = new GraphicsPath();
            int d = radio * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            lbl.Region = new Region(path);
        }
    }
}
