using UnityEngine;

namespace Code
{
    public struct Vector
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static explicit operator Vector(double x) => new Vector(x,x,x);
        public static implicit operator double(Vector x) => x.X;
        public static Vector operator +(Vector v1, Vector v2)
        {
            Vector res = new Vector();
            {
                res.X = v1.X + v2.X;
                res.Y = v1.Y + v2.Y;
                res.Z = v1.Z + v2.Z;
            }
            return res;
        }
    }
}