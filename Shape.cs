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
        private bool _selected;

        public Shape(Color color) 
        {
            _x = 0;
            _y = 0;
            _color = color;
        }

        public Shape() : this(Color.Yellow)
        {

        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }   

        public float X { get { return _x; } set { _x = value; } }
        public float Y { get { return _y; } set { _y = value; } }

        public virtual void Draw()
        {
            
        }

        public virtual  bool IsAt(Point2D pt)
        {
            return false; 
        }

        public bool Selected 
        {
            get { return _selected; }
            set { _selected = value; }
        }

        public virtual void DrawOutline()
        { 
            // SplashKit.DrawRectangle(Color.Black, X - 2, Y - 2, Width + 4, Height + 4);
        }
    }
}
