using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Triangle : Shape
    {
        private double _Side1=1;
        private double _Side2=1;
        private double _Side3=1;

        public Triangle()
        {

        }

        public Triangle(double side1,double side2,double side3)
        {
            this._Side1 = side1;
            this._Side2 = side2;
            this._Side3 = side3;
        }

        public Triangle(double side1, double side2, double side3, string color, bool filled) : base(color, filled) 
        {
            this._Side1 = side1;
            this._Side2 = side2;
            this._Side3 = side3;
        }

        public double Side1
        {
            get => this._Side1;
            set => this._Side1 = value;
        }

        public double Side2
        {
            get => this._Side2;
            set => this._Side2 = value;
        }

        public double Side3
        {
            get => this._Side3;
            set => this._Side3 = value;
        }

        public double GetArea()
        {
            double HalfP = 1 / 2 * (this._Side1+this._Side2+this._Side3);
            double PDivi = (HalfP - this._Side1) * (HalfP - this._Side2) * (HalfP - this._Side3);
            return Math.Sqrt(HalfP * PDivi);
        }

        public double GetPerimeter()=> this._Side1 + this._Side2 + this._Side3;

        public override string ToString()=> $"side1={this.Side1}, side2={this.Side2}, side3={this.Side3} and {base.ToString()}";
        
    }
}
