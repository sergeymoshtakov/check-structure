using System;
using tovarNamespace;
using checkNamespace;

class Program {
  public static void Main (string[] args) {
    Tovar a1 = new Tovar("Utyug", 323.3, 23.4, "You will win million dollars", 20);
    Check ch = new Check();
    ch.AddTovar(a1);
    ch.PrintAll();
  }
}