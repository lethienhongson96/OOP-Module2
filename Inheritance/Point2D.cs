using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Point2D
    {
        private float _X = 0;
        private float _Y = 0;
        
        public Point2D()
        {

        }

        public Point2D(float x,float y)
        {
            this._X = x;
            this._Y = y;
        }

        public float X
        {
            get => this._X;
            set => this._X = value;
        }

        public float Y
        {
            get => this._Y;
            set => this._Y = value;
        }

        public float[] GetXY()
        {
             float[] XY = {this.X,this.Y};
             return XY;
        }

        public void SetXY(float x,float y)
        {
            this._X = x;
            this._Y= y;
        }

        public virtual string InFor()
        {
            return $"x: {this.X}, y: {this.Y}";
        }
    }
}
