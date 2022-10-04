using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Rectangle : IShape
{
    protected float width;
    protected float height;

/*    public Shape(float width, float height)
    {
        this.width = width;
        this.height = height;
    } */
    public Rectangle(float width, float height)
    {
    }
    public  float Area()
    {
        float RectangleA = width * height;
        return RectangleA;
    }
    public  float Omkrets()
    {
        float RectangleO = ((width * 2) + (height * 2));
        return RectangleO;
    }


}


