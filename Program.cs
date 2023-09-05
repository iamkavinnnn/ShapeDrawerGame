using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Shape Drawer", 800, 600);

            Drawing newDrawing = new Drawing();
            

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {

                    Shape newShape = new Shape();
                    newDrawing.Background = Color.RandomRGB(255);
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    
                }

                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }
    }
}
