using System;

namespace project
{

  class Killer : Robot
  {

    private int damage;

    public Killer(int age, string name, int health, int[] coordinates, int damage) : base(age, name, health, coordinates)
    {
      this.damage = damage;
    }

    public void print()
    {
      base.printValues();
      Console.Write("Damege:" + damage);
    }

  }
}
