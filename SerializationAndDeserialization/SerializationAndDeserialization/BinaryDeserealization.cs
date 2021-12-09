using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationAndDeserialization
{
    class BinarySerialization
    {
        public void Serialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"C:\Users\NEHA TELECOM\source\SerializationAndDeserialization\SerializationAndDeserialization\SerializationAndDeserialization\Example.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
        }
    }
    class BinaryDeserealization
    {
        public void Deserialization()
        {
            FileStream fileStream = new FileStream(@"C:\Users\NEHA TELECOM\source\SerializationAndDeserialization\SerializationAndDeserialization\SerializationAndDeserialization\Example.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializedDemo = (Demo)formatter.Deserialize(fileStream);

            Console.WriteLine($"ApplicationName { deserializedDemo.ApplicationName} --- ApplicationId   { deserializedDemo.ApplicationId}");
            Console.ReadKey();
        }
    }
    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialazation ";
        public int ApplicationId { get; set; } = 100;
    }

}
