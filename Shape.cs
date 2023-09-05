using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
    public class Shape
    {
        // Variables
        private Color _color; 
        private float _x, _y;
        private int _width, _height;
        private bool _selected;

        public Shape() 
        {
            _x = 0;
            _y = 0;
            _width = 100;
            _height = 100;
            _color = Color.Green;
        }

        public Color Color // bad naming for this class
        {
            get { return _color; }
            set { _color = value; }
        }   

        public float X { get { return _x; } set { _x = value; } }
        public float Y { get { return _y; } set { _y = value; } }

        public int Width { get { return _width; } set{ _width = value; } }
        public int Height { get { return _height; } set { _height = value; } }

        public void Draw()
        {
            SplashKit.FillRectangle(_color, X, Y, Width, Height);
            if (Selected) 
            { 
                this.DrawOutline();
            }
        }

        public bool IsAt(Point2D pt)
        {
            if(pt.X < _width || pt.Y < _height || pt.X > 0 || pt.Y > 0)
            {
                return true;
            } else { return false; }
        }

        public bool Selected // selects the shape using boolean
        {
            get { return _selected; }
            set { _selected = value; }
        }

        public void DrawOutline()
        {
            if(Selected)
            {
                SplashKit.FillRectangle(Color.Black, X - 2, Y - 2, Width + 4, Height + 4);
            }
        }
    }
}
