using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Circle : Shape,IResizeable
    {
        private double _Radius = 1;

        public Circle()
        {

        }

        public Circle(double radius)
        {
            this._Radius = radius;
        }

        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            this._Radius = radius;
        }

        public double Radius
        {
            get => this._Radius;
            set => this._Radius = value;
        }


        public virtual double GetArea()=> this._Radius * this._Radius * Math.PI;

        public double GetPerimeter()=> 2 * this._Radius * Math.PI;

        public void Resize(double percent)
        {
            this.Radius =this.Radius + ((this.Radius * percent) / 100);
        }

        public override string ToString()
        {
            return $"radius is: {this.Radius} and {base.ToString()}";
        }
    }
}
