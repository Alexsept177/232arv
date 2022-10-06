using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _232arv;

public class program
{
  public static void Main()
  {
    IShape a =null;
    Console.WriteLine("---------------------");
    Console.WriteLine("Skriv en höjd");
    Console.WriteLine("---------------------");
    float height = float.Parse(Console.ReadLine());
    Console.WriteLine("---------------------");
    Console.WriteLine("Skriv en bredd");
    Console.WriteLine("---------------------");
    float width = float.Parse(Console.ReadLine());
    Console.WriteLine("---------------------");
    Console.WriteLine("Skriv en diameter");
    Console.WriteLine("---------------------");
    float diameter = float.Parse(Console.ReadLine());
    int choice = 1;

    while (choice != 0)
    {

      Console.WriteLine("Rectangle skriv 1, triangle skriv 2, circle skriv 3,  Cylinder skriv 4, Sphere skriv 5");
      choice = int.Parse(Console.ReadLine());
      if (choice == 1)
      {
        Console.WriteLine("---------------------");
        a = new Rectangle(width, height);
        Console.WriteLine("---------------------");
      }
      else if (choice == 2)
      {
        Console.WriteLine("---------------------");
        a = new triangle(width, height);
        Console.WriteLine("---------------------");
      }
      else if (choice == 3)
      {
        Console.WriteLine("---------------------");
        a = new Circle(diameter);
        Console.WriteLine("---------------------");
      }
      else if( choice == 4)
      {
        Console.WriteLine("---------------------");
        a = new Cylinder(diameter, height);
        Console.WriteLine("---------------------");
      }
      else if(choice == 5)
      {
        Console.WriteLine("---------------------");
        a = new Sphere(diameter);
        Console.WriteLine("---------------------");
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
















