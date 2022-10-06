using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _232arv
{
    public class Circle : IShape
    {
        public float diameter;
        
        public Circle(float diameter)
        {
            this.diameter = diameter;
        }
        public float Area()
        {
            float r = diameter/2;
            float CircleA= (float)(Math.PI * (r * r));
            return  CircleA;
        }
            public float Omkrets()
        {
            float r = diameter/2;
            float  CircleO = (float)(r * 2 * Math.PI);
            return  CircleO;
        }
    }
}