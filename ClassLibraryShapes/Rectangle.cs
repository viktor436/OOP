
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace project1._2.Figures
{
    [Serializable]
    public class Rectangle : Square
    {
        public int Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }
        public override TypeShape typeShape
        {
            get { return TypeShape.Rectangle; }
        }
        public override void Paint(IGraphics g)
        {
            Color borderColor;
            if (Selected)
            {
                borderColor = Color.Red;
            }
            else
            {
                borderColor = Color;
            }
            var fillColor = Color.FromArgb(100, Color);
            g.DrawRectangle(fillColor, borderColor, Position.X, Position.Y, Width, Height);
        }
        public override bool Contains(Point p)
        {
            return (Position.X < p.X && p.X < (Position.X + Width) && Position.Y < p.Y && p.Y < (Position.Y + Height));
        }
        public override Shape Copy(Point p)
        {
            return new Rectangle { Color = this.Color, Position = p, Width = this.Width,Height = this.Height };
        }
    }
}
