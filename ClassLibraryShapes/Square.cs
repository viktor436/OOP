
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace project1._2.Figures
{
    [Serializable]
    public class Square : Shape
    {
        public int Width { get; set; }
        protected Point _position;
        public Point Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public override TypeShape typeShape
        {
            get { return TypeShape.Square; }
        }

        public override double CalculateArea()
        {
            return Width * Width;
        }

        public override bool Contains(Point p)
        {
            return (Position.X < p.X && p.X < Position.X + Width && Position.Y < p.Y && p.Y < Position.Y + Width);
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
            g.DrawSquare(fillColor, borderColor, Position.X, Position.Y, Width, Width);
        }
        public override void Move(Point p)
        {
            _position.X = p.X;
            _position.Y = p.Y;
        }

        public override Shape Copy(Point p)
        {
            return new Square { Color = this.Color, Position = p, Width = this.Width};
        }
    }
}
