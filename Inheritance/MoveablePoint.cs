using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class MoveablePoint : Point2D
    {
        private float _XSpeed = 0;
        private float _YSpeed = 0;

        public MoveablePoint() { }

        public MoveablePoint(float xspeed,float yspeed) {
            this._XSpeed = xspeed;
            this._YSpeed = yspeed;
        }

        public MoveablePoint(float xspeed, float yspeed,float x,float y):base(x,y)
        {
            this._XSpeed = xspeed;
            this._YSpeed = yspeed;
        }

        public float XSpeed
        {
            get => this._XSpeed;
            set => this._XSpeed = value;
        }

        public float YSpeed
        {
            get => this._YSpeed;
            set => this._YSpeed = value;
        }

        public void SetXYSpeed(float xspeed,float yspeed)
        {
            this._XSpeed = xspeed;
            this._YSpeed = yspeed;
        }

        public float[] GetXYSpeed()
        {
            float[] speed = { this._XSpeed, this._YSpeed };
            return speed;
        }

        public override string InFor()
        {
            return $"speed x={this.XSpeed} and speed y={this.YSpeed}, {base.InFor()}";
        }

        public string Move()
        {
            string loca = "";
            loca = $"local at: x={this.X + this.XSpeed}, y={this.Y + this.YSpeed}";
            return loca;
        }
    }
}
