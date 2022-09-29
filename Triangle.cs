using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class triangle : IShape
{
    protected float width;
    protected float height;

/*    public Shape(float width, float height)
    {
        this.width = width;
        this.height = height;
    } */
    public triangle(float width, float height)
    {

    }
    public  float Area()
    {
        float Area = (width * height) / 2;
        return Area;
    }
    public float Omkrets()
    {
        float Circumference = (width + height + (float)Math.Sqrt((double)(width * width) + (double)(height * height)));
        return Circumference;
    }
}