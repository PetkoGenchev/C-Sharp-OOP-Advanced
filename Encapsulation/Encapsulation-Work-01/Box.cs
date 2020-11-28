using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Work_01
{
    public class Box
    {
        private const double minValue = 0;

        private const string invalidMessage = "{0} cannot be zero or negative.";

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                ValidateSide(value,nameof(this.Length));

                this.length = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                ValidateSide(value,nameof(this.Width));

                this.width = value;
            }
        }



        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                ValidateSide(value,nameof(this.Height));

                this.height = value;
            }
        }

        private void ValidateSide(double value, string sideName)
        {
            if (value <= minValue)
            {
                throw new ArgumentException(string.Format(invalidMessage, sideName));
            }
        }


        public double SurfaceArea()
        {
            return 2 * (this.Length * this.Width) +
                2 * (this.Length * this.Height) +
                2 * (this.Width * this.Height);
        }

        public double LateralSurfaceArea()
        {
            return (2 * this.Length * this.Height) +
                (2 * this.Width * this.Height);
        }
        public double Volume()
        {
            return this.Width * this.Length * this.Height;
        }
    }
}