namespace _6_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        class TrafficLight
        {
            string _colour;

            private void ChangeColour (string colour)
            {
                _colour = colour;
            }

            public string GetColour()
            {
                return _colour;
            }
        }
    }
}