using System;

namespace tovarNamespace
{
  public struct Tovar
  {
    private string name;
    private double cost;
    private double discount;
    private string text;
    private int quantity;
    public Tovar(string name, double cost, double discount, string text, int quantity)
    {
      this.name = name;
      this.cost = cost;
      this.discount = discount;
      this.text = text;
      this.quantity = quantity;
    }
    public string Name
    {
      set
      {
        if(value.Length != 0)
        {
          name = value;
        }
        else
        {
          Console.WriteLine("Wrong value");
        }
      }
      get
      {
        return name;
      }
    }
    public double Cost
    {
      set
      {
        if(value >= 0)
        {
          cost = value;
        }
        else
        {
          Console.WriteLine("Wrong value");
        }
      }
      get
      {
        return cost;
      }
    }
    public double Discount
    {
      set
      {
        if(value >= 0)
        {
          discount = value;
        }
        else
        {
          Console.WriteLine("Wrong value");
        }
      }
      get
      {
        return discount;
      }
    }
    public string Text
    {
      set
      {
        if(value.Length != 0)
        {
          text = value;
        }
        else
        {
          Console.WriteLine("Wrong value");
        }
      }
      get
      {
        return text;
      }
    }
    public int Quantity
    {
      set
      {
        if(value >= 0)
        {
          quantity = value;
        }
      }
      get
      {
        return quantity;
      }
    }
    public double TotalPrice
    {
      get
      {
        return quantity * cost * (1 - discount/100);
      }
    }
    public void PrintItem()
    {
      Console.WriteLine($"Name: {name}\nQuantity: {quantity}\nCost: {cost}\nDiscount: {discount}\nTotal cost: {TotalPrice}\nWish: {text}");
    }
  }
}