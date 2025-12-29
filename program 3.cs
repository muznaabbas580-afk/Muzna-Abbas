using System;
class Parent
{ 
    public virtual  void Greet()
    {
        Console.Write(" hello from parent ");

    }
}
class Child : Parent
{
    public override void Greet()
    {
        Console.Write("hello from Child"); 
        
    }
}
class Program
{
static void Main()
    {
        Parent p = new Parent();
        Child c = new Child();
        Parent  pc = new  Child();
        p.Greet ();  
        c.Greet();
        pc.Greet();
