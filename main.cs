using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    firstLinq();
  }

  public static void firstLinq(){
    string[] names = {"Bills","Steve","James","Mohan"};

    var myLinqQuery = from name in names
                    where name.Contains('a')
                    select name;

    foreach(var name in myLinqQuery)
      Console.Write(name + " ");
  }
}