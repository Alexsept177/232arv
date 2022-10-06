using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _232arv
{
    public class Sphere : IShape
    {
        protected float diameter;
        public Sphere(float diameter)
        {
            this.diameter = diameter;
        }
        public float Area()
        {
            float r = diameter/2;
            float SphereA= (float)(4* Math.PI * (r * r));
            return  SphereA;
        }
        public float Omkrets()
        {
            float r = diameter/2;
            float  SphereO = (float)(2 * (Math.PI * r));
            return  SphereO;
        }

    }
}