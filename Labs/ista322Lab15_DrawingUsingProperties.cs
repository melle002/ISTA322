//Circle.cs-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
  class Circle : DrawingShape, IDraw, IColor
  {
      public Circle(int diameter):base(diameter)
      {
      }

      public override void Draw(Canvas canvas)
      {
          if(this.shape!=null)
          {
              canvas.Children.Remove(this.shape);
          }
          else
          {
              this.shape = new Ellipse();
          }

          base.Draw(canvas);
      }
  }
}
//DrawingShape.cs---------------------------------------------------------------------
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Drawing
{
    abstract class DrawingShape
    {
        protected int _size;
        protected int _x = 0, _y = 0;
        protected Shape shape = null;

        public DrawingShape(int size)
        {
            this._size = size;
        }

        public int X
        {
            get { return this._x; }
            set { this._x = value; }
        }

        public int Y
        {
            get { return this._y; }
            set { this._y = value; }
        }


        public Color Color
        {
            set
            {
                if (this.shape != null)
                {
                    SolidColorBrush brush = new SolidColorBrush(value);
                    this.shape.Fill = brush;
                }
            }
        }

        public virtual void Draw(Canvas canvas)
        {
            if(this.shape == null)
            {
                throw new InvalidOperationException("Shape is null");
            }

            this.shape.Height = this._size;
            this.shape.Width = this._size;
            Canvas.SetTop(this.shape, this._y);
            Canvas.SetLeft(this.shape, this._x);
            canvas.Children.Add(this.shape);
        }
    }
}
//IColor.cs------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Drawing
{
    interface IColor
    {
        Color Color { set; }
    }
}
//IDraw.cs----------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    interface IDraw
    {
        int X { get; set; }
        int Y { get; set; }
        void Draw(Canvas canvas);
    }
}
//Square.cs--------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    class Square : DrawingShape, IDraw, IColor
    {
        public Square(int sideLength):base(sideLength)
        {
        }

        public override void Draw(Canvas canvas)
        {
            if(this.shape!=null)
            {
                canvas.Children.Remove(this.shape);
            }
            else
            {
                this.shape = new Rectangle();
            }

            base.Draw(canvas);
        }
    }
}
