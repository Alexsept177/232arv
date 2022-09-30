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

            Console.WriteLine("Rectangle skriv 1, triangle skriv 2");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                a = new Rectangle(width, height);
            }
            
            else if (choice == 2)
            {
                a = new triangle(width, height);
            }
            if (choice == 3)
            {
                a = new Circle(diameter);
            }
            else{
                continue;
            } 
            Console.WriteLine(a.Area());
            Console.WriteLine(a.Omkrets());
                
            
        }
    }


}
















