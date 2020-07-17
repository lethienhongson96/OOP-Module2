using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Point3D : Point2D
    {
        private float _Z = 0;

        public Point3D() { }

        public Point3D(float x,float y):base(x,y)
        {

        }

        public float Z
        {
            get => this._Z;
            set => this._Z = value;
        }

        public void SetXYZ(float x,float y,float z) 
        {
            SetXY(x,y);
            this._Z = z;
        }

        public float[] GetXYZ()
        {
            float[] XYZ = GetXY();
            Array.Resize(ref XYZ, XYZ.Length + 1);
            XYZ[2] = this._Z;
            return XYZ;
        }

        public override string InFor()
        {
            return $"{base.InFor()} and z: {this.Z}" ;
        }
    }
}
