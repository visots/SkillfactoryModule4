namespace _7_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Processor : ComputerPart
    {
        public override void Work()
        {
        }
    }

    class Motherboard : ComputerPart
    {
        public override void Work()
        {
        }
    }

    class GraphicCard : ComputerPart
    {
        public override void Work()
        {
        }
    }

    abstract class ComputerPart
    {
       public abstract void Work();
    }
}