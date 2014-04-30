using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    public class Vec2
    {
        public float x, y;

        public Vec2()
        {
            x = y = 0;
        }

        public Vec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vec2 operator+(Vec2 a, Vec2 b)
        {
            //For adding 2 vectors
            Vec2 newVector = new Vec2((a.x + b.x), (a.y + b.y));
            return newVector;
        }

        public static Vec2 operator-(Vec2 a, Vec2 b)
        {
            //for subtracting 2 vectors
            Vec2 newVector = new Vec2((a.x - b.x), (a.y - b.y));
            return newVector;
        }

        public static Vec2 operator *(float k, Vec2 v)
        {
            //for multiplying 2 vectors
            Vec2 newVector = new Vec2((v.x * k), (v.y * k));
            return newVector;
        }

        public static Vec2 operator *(Vec2 v, float k)
        {
            //for multiplying 2 vectors
            Vec2 newVector = new Vec2((v.x * k), (v.y * k));
            return newVector;
        }

        public static Boolean operator ==(Vec2 a, Vec2 b)
        {
            //are both vectors equal?
            return (a.x == b.x && a.y == b.y);
        }

        public static Boolean operator !=(Vec2 a, Vec2 b)
        {
            //are 2 vectors not equal?
            return (a.x != b.x || a.y != b.y);
        }

        public static float Dot(Vec2 a, Vec2 b)
        {
            //calculates the Dot product of two vectors
            float dotprod;
            dotprod = (a.x * b.x) + (a.y * b.y);
            return (float)dotprod;
        }

        public float GetMag()
        {
            double magnitude = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
            return (float)magnitude;
        }
               
    }
    
}
