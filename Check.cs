using System;
using tovarNamespace;
using System.Collections.Generic;

namespace checkNamespace
{
  public struct Check
  {
    public List<Tovar> tovars;
    public Check()
    {
      this.tovars = new List<Tovar>();
    }
    public Tovar this[int index]
    {
      set
      {
        if(index >= 0 && index < tovars.Count)
        {
          tovars[index] = value;
        }
        else
        {
          Console.WriteLine("Wrong index");
        }
      }
      get
      {
        if(index >= 0 && index < tovars.Count)
        {
          return tovars[index];
        }
        else
        {
          Console.WriteLine("Wrong index");
          return tovars[0];
        }
      }
    }
    public void AddTovar(Tovar t)
    {
      tovars.Add(t);
    }
    public void PrintAll()
    {
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      for(int i = 0; i < tovars.Count; i++)
      {
        tovars[i].PrintItem();
      }
      Console.ResetColor();
    }
  }
}