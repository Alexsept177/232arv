using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _232arv
{
    public class Cylinder : IShape
    {
        public float diameter;
        public float height;
        public Cylinder(float diameter, float height)
        {
            this.diameter = diameter;
            this.height = height;
        }
        public float Area()
        {
            float r = diameter/2;
            float CylinderA= (float)(Math.PI * 2 * r * height);
            return  CylinderA;
        }
        public float Omkrets()
        {
            float r = diameter/2;
            float  CylinderO = (float)(r * height);
            return  CylinderO;
        }


    }
}