namespace _7_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class ElectricEngine : Engine
    {

    }

    class GasEngine : Engine
    {

    }

    abstract class Car<TEngine>  where TEngine : Engine          
    {
        public TEngine Engine;

        public abstract void ChangePart<TCarPart>(TCarPart newPart) where TCarPart : CarPart;

    }

    class Battery : CarPart
    {

    }

    class Differential : CarPart
    {

    }

    class Wheel : CarPart
    {

    }

    abstract class Engine
    {

    }

    abstract class CarPart
    {

    }

    class ElecticCar<TEngine> : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }

    class GasCar<TEngine> : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }
}