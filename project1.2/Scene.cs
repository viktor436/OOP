using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using project1._2.Figures;

namespace project1._2
{
    public class Scene
    {
        private List<Shape> _shapes= new List<Shape>();
        public List<Shape> Shapes 
        { 
            get { return _shapes; }
            set { _shapes = value; }
        }
        public void AddShape(Shape s)
        {
            foreach (var shape in _shapes)
            {
                shape.Selected = false;
            }
            _shapes.Add(s);
        }

        public void DeleteSelectedShape()
        {
            for (int i = _shapes.Count - 1; i >= 0; i--)
            {
                if (_shapes[i].Selected)
                {
                    _shapes.RemoveAt(i);
                }
            }
        }

        public double CalculateSurface()
        {
            var surface = _shapes.Select(s => s.CalculateArea()).Sum();         //Linq
            return surface;
        }
        public void DeleteAllShapes()
        {
            for (int i = _shapes.Count - 1; i >= 0; i--)
            {
                _shapes.RemoveAt(i);
            }
        }
        public Shape[] FindSelected()
        {
            var shapes = _shapes                    //Linq
                .Where(s => s.Selected)
                .ToArray();

            return shapes;
        }
    }
}
