using System;

namespace SerializationAndDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinarySerialization binarySerialization = new BinarySerialization();
            binarySerialization.Serialization();
        }
    }
}
