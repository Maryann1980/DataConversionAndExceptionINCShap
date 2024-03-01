using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConversionAndExceptionINCShap
{
    internal class Rectangle
    {
        private double _width;
        private double _length;

        public Rectangle()
        {
            



        }
        public Rectangle(double width, double length)
        {
            SetLength(Length);
            SetWidth(Width);
        }
        public double Length
        {
            get
            {
                return _length;
            }
        }
        public double Width
        {
            get
            {
                return _width;
            }
        }

        public void SetLength(double Value)
        {
            if (Value > 0)
            {
                _length = Value;
            }
            else
            {
                throw new ArgumentException("The length must not be less than or equal to 0");
            }
        }
        public void SetWidth(double Value)
        {
            if (Value > 0)
            {
                _width = Value;
            }
            else
            {
                throw new ArgumentException("The width must not be less than or equal to 0");
            }

        }

        public double Area()
        {
            return Length * Width;
        }
    }
}
