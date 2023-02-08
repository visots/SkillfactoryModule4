﻿namespace _7_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            D d = new D();
            E e = new E();
            d.Display(); //D
            
            ((A)e).Display();//C
            ((B)d).Display();//B
            ((A)d).Display();//A
        }
    }

    class A
    {
        public virtual void Display() => Console.WriteLine("A");
    }

    class B : A
    {
        public new void Display() => Console.WriteLine("B");
    }

    class C : A
    {
        public override void Display() => Console.WriteLine("C");
    }

    class D : B
    {
        public new void Display() => Console.WriteLine("D");
    }

    class E : C
    {
        public new void Display() => Console.WriteLine("E");
    }
}