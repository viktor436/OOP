
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace project1._2.Figures
{
    [Serializable]
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract void Paint(IGraphics g);
        public abstract bool Contains(Point p);
        public abstract void Move(Point p);
        public abstract Shape Copy(Point p);
        public abstract TypeShape typeShape { get; }
        public bool Selected { get; set; }

        public Color Color { get; set; }

    }
    public enum TypeShape
    {
        Circle,
        Square,
        Triangle,
        Rectangle
    }
    

    //interface ISurface
    //{
    //    double CalculateArea();
    //}
}
