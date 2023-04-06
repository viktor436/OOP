
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace project1._2.Figures
{
    [Serializable]
    public class Triangle : Shape
    {

        public int Width { get; set; }
        protected Point _position;
        public Point Position
        {
            get {return _position; }
            set { _position = value; }
        }

        public override TypeShape typeShape
        {
            get { return TypeShape.Triangle; }
        }

        private Point[] points = new Point[3];

        public override double CalculateArea()
        {
            return ((Math.Sqrt(3) * Width * Width) / 4);
        }
        private void FindPoints()
        {
            Point p1 = new Point(Position.X, Position.Y);
            Point p2 = new Point(Position.X + Width, Position.Y);
            Point p3 = new Point(Position.X + (Width / 2), (int)(Position.Y - (Math.Sqrt(3) * (Width / 2))));  //грешка:заради закръглянето до тип int триъгълника не е равностранен
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
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
            FindPoints();
            var fillColor = Color.FromArgb(100, Color);
            g.DrawTriangle(fillColor, borderColor,points);
        }
        
        public override bool Contains(Point p)
        {
            Point p0 = points[0];
            Point p1 = points[1];
            Point p2 = points[2];
            var s = p0.Y * p2.X - p0.X * p2.Y + (p2.Y - p0.Y) * p.X + (p0.X - p2.X) * p.Y;
            var t = p0.X * p1.Y - p0.Y * p1.X + (p0.Y - p1.Y) * p.X + (p1.X - p0.X) * p.Y;

            if ((s < 0) != (t < 0))
                return false;

            var A = -p1.Y * p2.X + p0.Y * (p2.X - p1.X) + p0.X * (p1.Y - p2.Y) + p1.X * p2.Y;

            return A < 0 ? (s <= 0 && s + t >= A) : (s >= 0 && s + t <= A);
        }

        public override void Move(Point p)
        {
            _position.X = p.X;
            _position.Y = p.Y;
        }

        public override Shape Copy(Point p)
        {
            return new Triangle { Color = this.Color, Position = p, Width = this.Width };
        }
    }
}
