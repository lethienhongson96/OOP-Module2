using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Cylinder : Circle
    {
        private double _Height;
        public Cylinder(double radius, string color, bool filled,double height) : base(radius,color,filled)
        {
            this._Height = height;
        }

        public override double GetArea()
        {
            return (base.GetArea()*2)+(2*Math.PI*this.Radius*this._Height);
        }

        public override string ToString()
        {
            return $"Cylinder has height: {this._Height} {(base.ToString())}";
        }
       
    }
    
}
