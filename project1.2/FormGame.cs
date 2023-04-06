using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project1._2
{
    public partial class FormGame : Form
    {
        public enum FormGameStyle
        {
            Easy,
            Hard
        }
        //private FormGameStyle _style;
        //public FormGameStyle Style
        //{
        //    get { return _style; }
        //    set { _style = value; }
        //}
        public FormGame(FormGameStyle style)
        {
            InitializeComponent();
            switch (style)
            {
                case FormGameStyle.Easy:
                    isEasy = true;
                    break;
                case FormGameStyle.Hard:
                    isEasy = false;
                    break;
            }
        }
        private bool _fail;
        public bool Fail 
        {
            get { return _fail; }
            set { _fail = value; }
        }
        private double _shapesArea;
        public double ShapesArea 
        {
            get { return _shapesArea; }
            set { _shapesArea = value; }
        }
        private double _shipArea;
        public double ShipArea 
        {
            get { return _shipArea; }
            set { _shipArea = value; }
        }
        private bool isEasy;

        private void FormGame_Load(object sender, EventArgs e)
        {
            if(isEasy)
                toolStripStatusLabelArea.Text = $"Load Weight:{_shapesArea.ToString()}";
            else
                toolStripStatusLabelArea.Text = "Load Weight: ****";

            toolStripStatusLabelShipMaxWeight.Text = $"Max Weight:{_shipArea.ToString()}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((_shapesArea>=_shipArea-(_shipArea*5)/100) && (_shapesArea <= _shipArea + (_shipArea * 5) / 100))
            {
                _fail = false;
                var gs = new GameSuccess();
                gs.ShowDialog();
            }
            else
            {
                _fail = true;
                var gf = new GameFail();
                gf.ShowDialog();
            }

        }

        private void buttonWait_Click(object sender, EventArgs e)
        {

        }
    }
}
