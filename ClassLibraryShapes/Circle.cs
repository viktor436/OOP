
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace project1._2.Figures
{
    [Serializable]
    public class Circle : Shape
    {
        protected int _radius;
        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        protected Point _position;
        public Point Position
        {
            get { return _position; }
            set { _position = value; }
        }
        
        public override TypeShape typeShape 
        {
            get { return TypeShape.Circle; }
        }

        public override double CalculateArea()
        {
            return Radius * Radius * 3.1416;
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
            g.DrawCircle(fillColor, borderColor, Position.X, Position.Y, Radius, Radius);
        }

        public override bool Contains(Point p)
        {
            var center = new Point(Position.X + Radius, Position.Y + Radius);
            return ((p.X - center.X) * (p.X - center.X) + (p.Y - center.Y) * (p.Y - center.Y) < Radius * Radius);
        }
        public override void Move(Point p)
        {
            _position.X = p.X;
            _position.Y = p.Y;
        }
        public override Shape Copy(Point p)
        {
            return new Circle { Color = Color, Position = p, Radius = Radius };
        }


    }
}
