using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class Circle
    {
        private double _radius = 1;
        private string _color = "red";

        public Circle(){
        }

        public Circle(double r) => this._radius= r;
        
        public double Radius
        {
            set => _radius = value;
            get => _radius;
        } 
        
        public string Color
        {
            set => _color = value;
            get => _color;
        }

        public double Getarea()=> this._radius * this._radius * Math.PI;
            
    }
}
