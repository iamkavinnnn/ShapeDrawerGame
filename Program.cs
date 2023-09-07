using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }
        public static void Main()
        {
            Window window = new Window("Shape Drawer", 800, 600);

            Drawing newDrawing = new Drawing();
            ShapeKind kindToAdd = ShapeKind.Circle;
            

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }

                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                }

                if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                }

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    

                    if (kindToAdd == ShapeKind.Circle)
                    {

                        Shape newShape = new MyCircle();
                        newShape.X = SplashKit.MouseX();
                        newShape.Y = SplashKit.MouseY();
                        newDrawing.AddShape(newShape);
                    }

                    if (kindToAdd == ShapeKind.Rectangle)
                    {
                        Shape newShape = new MyRectangle();
                        newShape.X = SplashKit.MouseX();
                        newShape.Y = SplashKit.MouseY();
                        newDrawing.AddShape(newShape);
                    }

                    if(kindToAdd == ShapeKind.Line)
                    {
                        Shape newShape = new MyLine();
                        newShape.X = SplashKit.MouseX();
                        newShape.Y = SplashKit.MouseY();
                        newDrawing.AddShape(newShape);

                    }
                    // newDrawing.AddShape(newShape);
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    newDrawing.Background = Color.RandomRGB(255);
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    newDrawing.SelectShapesAt(SplashKit.MousePosition());
                }

                if(SplashKit.KeyTyped(KeyCode.DeleteKey) || SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    
                    newDrawing.Delete();
                }

                
                newDrawing.Draw();
                
                

                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }
    }
}
