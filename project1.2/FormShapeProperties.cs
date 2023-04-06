using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using project1._2.Figures;

namespace project1._2
{
    public partial class FormShapeProperties : Form
    {
        public FormShapeProperties()
        {
            InitializeComponent();
        }

        public Shape Shapes { get; set; }
        
        private TypeShape _typeShape;
        public TypeShape TypeShape       //1-Circle/2-Square/3-Triangle/4-Rectangle
        {
            get { return _typeShape; }
            set 
            { 
                _typeShape = value;
                if (_typeShape == TypeShape.Circle)
                {
                    radioButtonCircle.Checked = true;
                }
                else if (_typeShape == TypeShape.Square)
                {
                    radioButtonSquare.Checked = true;
                }
                else if (_typeShape == TypeShape.Triangle)
                {
                    radioButtonTriangle.Checked = true;
                }
                else 
                {
                    radioButtonRectangle.Checked = true;
                }
            }
        }
        private int _width;
        public int NewWidth
        {
            get { return _width; }
            set 
            { 
                _width = value;
                textBoxX.Text = _width.ToString();
            }
        }
        private int? _height;
        public int? NewHeight
        {
            get { return _height; }
            set 
            {
                _height = value;
                if(textBoxY.Text != null)
                {
                    textBoxY.Text = _height.ToString();
                }
            }
        }

        public Color NewColor { get; set; }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonCircle.Checked) 
            {
                //Shapes = new Circle { Radius = int.Parse(textBoxX.Text),Position = Location,Color= Color.Red };
                NewWidth = int.Parse(textBoxX.Text);
                TypeShape = TypeShape.Circle;
                DialogResult = DialogResult.OK;
            }
            else if (radioButtonSquare.Checked)
            {
                //Shapes = new Square { Width = int.Parse(textBoxX.Text), Position = Location, Color = Color.Red };
                NewWidth = int.Parse(textBoxX.Text);
                TypeShape = TypeShape.Square;
                DialogResult = DialogResult.OK;
            }
            else if (radioButtonTriangle.Checked)
            {
                //Shapes = new Triangle { Width = int.Parse(textBoxX.Text), Position = Location, Color = Color.Red };
                NewWidth = int.Parse(textBoxX.Text);
                TypeShape = TypeShape.Triangle;
                DialogResult = DialogResult.OK;
            }
            else
            {
                //Shapes = new Rectangle { Width = int.Parse(textBoxX.Text), Height = int.Parse(textBoxY.Text), Position = Location, Color = Color.Red };
                NewWidth = int.Parse(textBoxX.Text);
                NewHeight = int.Parse(textBoxY.Text);
                TypeShape = TypeShape.Rectangle;
                
                DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            NewColor = cd.ShowDialog() == DialogResult.OK ? cd.Color : Color.Gray;
            {
                NewColor = cd.Color;
            }
        }
    }
}
