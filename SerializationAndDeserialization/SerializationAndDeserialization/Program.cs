using System;

namespace SerializationAndDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /* BinaryDeserealization binaryDeserialization = new BinaryDeserealization();
             binaryDeserialization.Deserialization();*/

            /* JsonSerialization jsonSerialization = new JsonSerialization();
             jsonSerialization.JsonSerialize();*/
            /* JsonDeserialization jsonDeserialization = new JsonDeserialization();
             jsonDeserialization.JsonDeserialize();*/
            XMLSerialization.SerializeXml();


        }
    }
}
