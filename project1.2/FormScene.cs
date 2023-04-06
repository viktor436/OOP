using project1._2.Figures;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

using Circle = project1._2.Figures.Circle;
using Rectangle = project1._2.Figures.Rectangle;
using Square = project1._2.Figures.Square;
using Triangle = project1._2.Figures.Triangle;



namespace project1._2
{
    public partial class FormScene : Form, IGraphics
    {
        private Graphics _onPaintgraphics;

        private Scene scene = new Scene();
        public FormScene()
        {
            InitializeComponent();
            CalculateGameArea();
        }
        private double _shapesArea;
        public double ShapesArea
        {
            get { return _shapesArea; }
            private set { _shapesArea = value; }
        }
        private void RefreshArea()
        {
            //In this implemetation area is refreshed only when game dialog is opened.
            _shapesArea = 0;
            _shapesArea = scene.CalculateSurface();
        }
        private int _gameArea;
        public int GameArea 
        {
            get { return _gameArea; }
            set { _gameArea = value; }
        }

        private void CalculateGameArea()
        {
            var random = new Random();
            _gameArea = random.Next(0, this.Width*this.Height - ((5*this.Width*this.Height)/100));
        }

        #region DrawFigures
        public void DrawRectangle(Color colorBorder, Color colorFill, int x, int y, int width, int height)
        {
            if (_onPaintgraphics != null)
            {
                using (var b = new SolidBrush(colorFill))
                    _onPaintgraphics.FillRectangle(b, x, y, width, height);
                using (var pen = new Pen(colorBorder, 5))
                    _onPaintgraphics.DrawRectangle(pen, x, y, width, height);
            }

        }
        public void DrawTriangle(Color colorBorder, Color colorFill, Point[] points)
        {
            if (_onPaintgraphics != null)
            {
                using (var b = new SolidBrush(colorFill))
                    _onPaintgraphics.FillPolygon(b, points);
                using (var pen = new Pen(colorBorder, 5))
                    _onPaintgraphics.DrawPolygon(pen, points);
            }
        }
        public void DrawSquare(Color colorBorder, Color colorFill, int x, int y, int width, int width1)
        {
            if (_onPaintgraphics != null)
            {
                using (var b = new SolidBrush(colorFill))
                    _onPaintgraphics.FillRectangle(b, x, y, width, width);
                using (var pen = new Pen(colorBorder, 5))
                    _onPaintgraphics.DrawRectangle(pen, x, y, width, width);
            }
        }
        public void DrawCircle(Color colorBorder, Color colorFill, int x, int y, int radius, int radius1)
        {
            if(_onPaintgraphics != null)
            {
                using (var b = new SolidBrush(colorFill))
                    _onPaintgraphics.FillEllipse(b, x, y, radius, radius);
                using (var pen = new Pen(colorBorder, 5))
                    _onPaintgraphics.DrawEllipse(pen, x, y, radius, radius);
            }
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            _onPaintgraphics = e.Graphics;

            foreach (var shape in scene.Shapes)
            {
                if (shape != null)
                {
                    shape.Paint(this);
                } 
            }
            _onPaintgraphics = null;
        }

        private void DeleteSelected()
        {
            scene.DeleteSelectedShape();
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        { 
            if (e.Button == MouseButtons.Left)
            {
                if (radioButtonPaint.Checked)
                {
                    var fp = new FormShapeProperties();
                    if (fp.ShowDialog() == DialogResult.OK)
                    {
                        int xDimension = fp.NewWidth;
                        int? yDimension = fp.NewHeight;
                        Color Color = (Color)fp.NewColor;
                        Shape s;
                        if (fp.TypeShape == TypeShape.Circle)
                            s = new Circle { Position = e.Location, Radius = xDimension, Color = Color };
                        else if (fp.TypeShape == TypeShape.Square)
                            s = new Square { Position = e.Location, Width = xDimension, Color = Color };
                        else if (fp.TypeShape == TypeShape.Triangle)
                            s = new Triangle { Position = e.Location, Width = xDimension, Color = Color };
                        else
                            s = new Rectangle { Position = e.Location, Width = xDimension, Height = (int)yDimension, Color = Color };
                        
                        scene.Shapes.Add(s);
                    }
                }
                else if (radioButtonMove.Checked)
                {
                    foreach (var shape in scene.Shapes)
                    {
                        if (shape.Selected)
                        {
                            shape.Move(new Point(e.X, e.Y));
                        }
                    }
                }
                else
                {
                    Shape s = null;
                    foreach (var shape in scene.Shapes)
                    {
                        if (shape.Selected)
                        {
                            s = shape.Copy(new Point(e.X, e.Y));
                        }
                    }
                    RefreshArea();
                    scene.AddShape(s);
                }
            }

            else if (e.Button == MouseButtons.Right)
            {
                if (radioButtonEdit.Checked)
                {
                    Shape s = null;
                    foreach (var shape in scene.Shapes.Where(sh=>sh.Contains(e.Location)))          //Linq
                    {
                        s = shape;
                    }
                    if (s != null)
                    {
                        switch (s.typeShape)
                        {
                            case TypeShape.Circle:
                                Circle circle = (Circle)s;
                                var fsp = new FormShapeProperties();
                                fsp.TypeShape = TypeShape.Circle;
                                fsp.NewWidth = circle.Radius;
                                fsp.NewColor = circle.Color;

                                if (fsp.ShowDialog() == DialogResult.OK)
                                {
                                    circle.Radius = fsp.NewWidth;
                                    circle.Color = fsp.NewColor;
                                }
                                break;
                            case TypeShape.Triangle:
                                Triangle triangle = (Triangle)s;
                                var fsp1 = new FormShapeProperties();
                                fsp1.TypeShape = TypeShape.Triangle;
                                fsp1.NewWidth = triangle.Width;
                                fsp1.NewColor = triangle.Color;

                                if (fsp1.ShowDialog() == DialogResult.OK)
                                {
                                    triangle.Width = fsp1.NewWidth;
                                    triangle.Color = fsp1.NewColor;
                                }
                                break;
                            case TypeShape.Square:
                                Square square = (Square)s;
                                var fsp2 = new FormShapeProperties();
                                fsp2.TypeShape = TypeShape.Square;
                                fsp2.NewWidth = square.Width;
                                fsp2.NewColor = square.Color;

                                if (fsp2.ShowDialog() == DialogResult.OK)
                                {
                                    square.Width = fsp2.NewWidth;
                                    square.Color = fsp2.NewColor;
                                }
                                break;
                            case TypeShape.Rectangle:
                                Rectangle rectangle = (Rectangle)s;
                                var fsp3 = new FormShapeProperties();
                                fsp3.TypeShape = TypeShape.Rectangle;
                                fsp3.NewWidth = rectangle.Width;
                                fsp3.NewHeight = rectangle.Height;
                                fsp3.NewColor = rectangle.Color;

                                if (fsp3.ShowDialog() == DialogResult.OK)
                                {
                                    rectangle.Width = fsp3.NewWidth;
                                    rectangle.Height = (int)fsp3.NewHeight;
                                    rectangle.Color = fsp3.NewColor;
                                }
                                break;
                        }
                    }
                }
                else 
                {
                    foreach (var shape in scene.Shapes)
                    {
                        shape.Selected = false;
                    }

                    Shape selectedShape = scene.Shapes                      //Linq
                        .FirstOrDefault(shape=>shape.Contains(e.Location));
                    
                    if (selectedShape != null)
                    {
                        selectedShape.Selected = true;
                    }
                } 
            }
            Invalidate();
        }
        
        private void buttonGame_Click(object sender, EventArgs e)
        {
            RefreshArea();
            var fgl = new FormGameLevel();
            if (fgl.ShowDialog() == DialogResult.OK)
            {
                if (fgl.Level == 1)
                {
                    var fg = new FormGame(FormGame.FormGameStyle.Easy);
                    fg.ShapesArea = ShapesArea;
                    fg.ShipArea = GameArea;
                    fg.ShowDialog();
                    if (fg.Fail)
                    {
                        scene.DeleteAllShapes();
                        Invalidate();
                    }
                }
                else
                {
                    var fg = new FormGame(FormGame.FormGameStyle.Hard);
                    fg.ShapesArea = ShapesArea;
                    fg.ShipArea = GameArea;
                    fg.ShowDialog();
                    if (fg.Fail)
                    {
                        scene.DeleteAllShapes();
                        Invalidate();
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteSelected();
            Invalidate();
        }

        private void FormScene_FormClosing(object sender, FormClosingEventArgs e)
        {
            var fs = new SaveFileDialog();
            if (fs.ShowDialog() == DialogResult.OK)
            {
                var formatter = new BinaryFormatter();
                using (var stream = new FileStream($"{fs.FileName}", FileMode.Create))
                {
                    formatter.Serialize(stream, scene.Shapes);
                }
            }
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var ofd =new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var formatter = new BinaryFormatter();
                using (var stream = new FileStream($"{ofd.FileName}", FileMode.Open))
                {
                    scene.Shapes = (List<Shape>)formatter.Deserialize(stream);
                }
            }
            Invalidate();
        }
    }
}
