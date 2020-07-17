using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Square : Rectangle,IResizeable
    {
        public Square()
        {

        }

        public Square(double side) :base(side,side)
        {

        }

        public Square(double side,string color,bool filled) : base(side, side, color, filled)
        {

        }

        public double GetSide() => GetWidth();


        public void SetSide(double side)
        {
             this.SetWidth(side);
             this.SetHeight(side);
        }

        public void Resize(double percent)
        {
            this.SetSide(this.GetSide()+((this.GetSide()*percent)/100));
        }

        public override string ToString()
        {
            return $"square has side: {this.GetSide()} and {base.ToString()}";
        }
    }
}
