using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1._2.Figures
{
    public interface IGraphics
    {
        void DrawRectangle(Color colorBorder, Color colorFill, int x, int y, int width, int height);
        void DrawTriangle(Color colorBorder, Color colorFill, Point[] points);
        void DrawSquare(Color colorBorder, Color colorFill, int x, int y, int width, int width1);
        void DrawCircle(Color colorBorder, Color colorFill, int x, int y, int radius, int radius1);
    }
}
