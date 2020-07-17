using AccessModifier;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    abstract class Shape
    {
        private string _Color = "blue";
        private bool _Filled = true;

        public Shape()
        {
            //QuadraticEquation qE = new QuadraticEquation();
        }

        public Shape(string color,bool filled)
        {
            this._Color = color;
            this._Filled = filled;
        }

        public string Color
        {
            get => this._Color;
            set => this._Color = value;
        }

        public bool Filled
        {
            get => this._Filled;
            set => this._Filled = value;
        }
        
        public override string ToString()=> $"A Shape with color of {this.Color} and {(this.Filled?"filled":"not filled")}" ;
    }
}
