using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static void RedondearPanel(Panel panel)
        {

            Rectangle bounds = new Rectangle(0, 0, panel.Width, panel.Height);
            GraphicsPath path = new();
            int radio = 25 * 2;

            path.AddArc(bounds.X, bounds.Y, radio, radio, 180, 90);
            path.AddArc(bounds.Right - radio, bounds.Y, radio, radio, 270, 90);
            path.AddArc(bounds.Right - radio, bounds.Bottom - radio, radio, radio, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radio, radio, radio, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);

        }

        public static void RedondearPanelArriba(Panel panel)
        {
            Rectangle bounds = new Rectangle(0, 0, panel.Width, panel.Height);
            GraphicsPath path = new();
            int radio = 25 * 2;

            path.AddArc(bounds.X, bounds.Y, radio, radio, 180, 90);
            path.AddArc(bounds.Right - radio, bounds.Y, radio, radio, 270, 90);
            path.AddLine(bounds.Right, bounds.Y + radio, bounds.Right, bounds.Bottom);
            path.AddLine(bounds.Right, bounds.Bottom, bounds.X, bounds.Bottom);
            path.AddLine(bounds.X, bounds.Bottom, bounds.X, bounds.Y + radio);


            panel.Region = new Region(path);
        }
    }
}
