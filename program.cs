using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _232arv;

public class program
{
  public enum Shape
    {
        Rectangle, 
        Triangle,
        Circle,
        Cylinder,
        Sphere
    }
  public static void Main()
  {
    IShape a =null;    
    int choice = 1;

    while (choice != 0)
    {
      Shape shape;

      Console.WriteLine("Rectangle skriv 1, triangle skriv 2, circle skriv 3,  Cylinder skriv 4, Sphere skriv 5");
      choice = int.Parse(Console.ReadLine());

      Console.WriteLine("---------------------");
      Console.WriteLine("Skriv en diameter");
      Console.WriteLine("---------------------");
      float diameter = float.Parse(Console.ReadLine());

      if(choice == 1) 
      {
        float width = float.Parse(Console.ReadLine());
        shape = Shape.Rectangle;
        Console.WriteLine("Skriv en höjd");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Skriv en bredd");
        a = new Rectangle(width, height);
      }
      else if (choice == 2) 
      {
        shape = Shape.Triangle;
        a = new triangle(width, height);
      }
      else if (choice == 3)
      {
        shape = Shape.Circle;
        a = new Circle(diameter);
      }
      else if( choice == 4)
      {
        shape = Shape.Cylinder;
        a = new Cylinder(diameter, height); 

      }
      else if(choice == 5) 
      {
        shape = Shape.Sphere;
        a = new Sphere(diameter);
      }
      else
      {
        continue;
      } 
      Console.WriteLine(a.Area());
      Console.WriteLine(a.Omkrets());
    }
  }
}
















