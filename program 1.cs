using System;
class Parent
{
    public void Greet ()
    {
        Console.WriteLine("hello your parents");
    }
}
class Child:Parent
{
  public void sayhi()
    {
        Console.WriteLine(" hi from child");
    }
}
class Program
{
    static void Main()
    {
        Child c = new Child();
        c.Greet();
        c.sayhi();         
    }
}
