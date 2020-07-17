using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    public class QuadraticEquation
    {
        private double _A, _B, _C;

        public QuadraticEquation(double a,double b,double c)
        {
            this._A = a;
            this._B = b;
            this._C = c;
        }

        public double A
        { 
            get => this._A;
            set => this._A = value;
        }

        public double B
        {
            get => this._B;
            set => this._B = value;
        }
        public double C
        {
            get => this._C;
            set => this._C = value;
        }

        public double GetDiscriminant() => (this._B * this._B) - (4 * this._A * this._C);

        public double GetRoot1()=> (-this._B + Math.Sqrt(this.GetDiscriminant())) / (2 * this._A);

        public double GetRoot2() => (-this._B - Math.Sqrt(this.GetDiscriminant())) / (2 * this._A);

        public string GetResult()
        {
            if (this.GetDiscriminant() < 0)
            {
                return "The equation has no roots";
            }

            else if (this.GetDiscriminant()==0)
            {
                return $"The equation have one root is: {this.GetRoot1()}";
            }

            return $"The equation has two roots: {this.GetRoot1()} and {this.GetRoot2()}";
        }

        public static void Main()
        {
            QuadraticEquation pt1 = new QuadraticEquation(1,-8,16);
            Console.WriteLine(pt1.GetResult());
        }
    }
}
