using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
    public class MyLine : Shape
    {
        int _radius; // radius for a dot in the line
        int startX , startY;
        public MyLine(Color clr) 
        {
            Color = clr;
            _radius = 2;
            startX = 100;
            startY = 100;
        }

        public MyLine() : this(Color.Black) { }

        public override void Draw()
        {
            if(Selected)
            {
                DrawOutline();
            }
            SplashKit.DrawLine(Color.Red, startX, startY, X, Y);
        }

        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color, X, Y, _radius);
            SplashKit.FillCircle(Color, startX, startY, _radius);
        }

        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointOnLine(pt, SplashKit.LineFrom(startX, startY, X, Y));
        }
    }
}
