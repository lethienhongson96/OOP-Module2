using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Rectangle : Shape,IResizeable
    {
        private double _Width = 1;
        private double _Height = 3;

        public Rectangle()
        {

        }

        public Rectangle(double width,double height)
        {
            this._Width = width;
            this._Height = height;
        }

        public Rectangle(double width, double height,string color,bool filled) : base(color,filled)
        {
            this._Width = width;
            this._Height = height;
        }

        public double GetWidth() => this._Width;
        public virtual void SetWidth(double width) => this._Width = width;

        public double GetHeight() => this._Height;
        public virtual void SetHeight(double height) => this._Height = height;

        public double GetArea() => this._Width * this._Height;
        public double GetPerimeter() => 2 * (this._Width + this._Height);

        public override string ToString()
        {
            return $"rectangle with Width: {this._Width} height: {this._Height} area={this.GetArea()} and {base.ToString()}";
        }

        public void Resize(double percent)
        {
            this.SetWidth(this.GetWidth()+(this.GetWidth()*percent/100));
            this.SetHeight(this.GetHeight()+(this.GetHeight() * percent / 100));
        }
    }
}
