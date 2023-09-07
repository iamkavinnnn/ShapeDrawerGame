using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;  //read-only fields cannot be changed or assigned new values to the field
        private Color _background;  //Color is a class from splashkit. not from the program

        public Drawing(Color background) 
        { 
            _shapes = new List<Shape>(); 
            _background = background;
        }

        public Drawing() : this(Color.White) { }

        public int ShapeCount
        {
            get { return _shapes.Count; }
        }

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);

            foreach(Shape shape in _shapes)
            {
                shape.Draw();
            }
        }

        public void SelectShapesAt(Point2D pt)
        {
            foreach(Shape shape in _shapes)
            {
                if(shape.IsAt(pt))
                {
                    shape.Selected = true;
                } else
                {
                    shape.Selected = false;
                }
            }
        }

        public List<Shape> SelectedShapes()  //// i dont understand why this is told as a property in the pdf file. there is not get and set
        {
            List<Shape> result = new List<Shape>();  // creates a new list to store the shapes that are selected
            foreach(Shape shape in _shapes)
            {
                if(shape.Selected)  // returns true if a shape is selected 
                {
                    result.Add(shape);
                    shape.DrawOutline();
                }
            }
            return result;
        }

        public void Delete()
        {
            foreach (Shape shape in _shapes.ToList()) // i got this from stackoverflow(i dont know if thats illegal) https://stackoverflow.com/questions/1582285/how-to-remove-elements-from-a-generic-list-while-iterating-over-it
            {
                if(shape.Selected)
                {
                    _shapes.Remove(shape);
                }
            }
        }
        
        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }


    }
}
