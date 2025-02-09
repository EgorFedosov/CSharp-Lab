using System;
using System.Collections.Generic;

namespace project
{

  class Program
  {

    static void Main()
    {

      // Robot bot = new Robot(13, "Botik", 89, new int[] { 3, 4, 5 });
      // bot.printValues();

      // Killer killer = new Killer(76, "Killer", 652, new int[] { 4, 6, 2 }, 42);
      // killer.print();

      List<Killer> robots = new List<Killer>();
      robots.Add(new Killer(14, "zack", 48, new int[] { 3, 7, 1 }, 34));
      robots.Add(new Killer(4, "sneach", 283, new int[] { 2, 5, 1 }, 41));
      robots.Add(new Killer(1, "end", 41, new int[] { 3, 3, 5 }, 72));
      robots.Add(new Killer(12, "jack", 8, new int[] { 33, 5, 3 }, 7));
      robots.Add(new Killer(10, "golub", 4, new int[] { 1, 23, 1 }, 7));

      Console.Write("Enter name for search: ");
      string SearchName = Convert.ToString(Console.ReadLine());

      int maxH = 0;
      string name, maxname = "value";

      foreach (Killer obj in robots)
      {
        if (obj.Search(SearchName))
        {
          obj.print();
        }

        if (obj.health1 > maxH)
        {
          maxname = obj.Name;
        }

        maxH = obj.SortHealth(maxH);


      }
      Console.WriteLine(" Max hp: " + maxH + " His name is: " + maxname);


    }
  }
}