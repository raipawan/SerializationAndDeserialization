using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace SerializationAndDeserialization
{
    class XMLSerialization
    {
        public static void SerializeXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"C:\Users\NEHA TELECOM\source\SerializationAndDeserialization\SerializationAndDeserialization\SerializationAndDeserialization\ExampleForXml.txt", FileMode.Create);
            OrderForm orderForm = new OrderForm();
            DateTime dt2 = new DateTime(2021, 12, 9);
            orderForm.OrderDate = dt2;
            ser.Serialize(fileStream, orderForm);
        }
    }
    class XmlDeserialization
    {
        public static void DeserializeXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"C:\Users\NEHA TELECOM\source\SerializationAndDeserialization\SerializationAndDeserialization\SerializationAndDeserialization\ExampleForXml.txt", FileMode.Open);
            OrderForm data = (OrderForm)ser.Deserialize(fileStream);
            Console.WriteLine(data.OrderDate);
        }
    }
    public class OrderForm
    {
        public DateTime OrderDate;
    }
}
