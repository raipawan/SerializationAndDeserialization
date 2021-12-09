using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SerializationAndDeserialization
{
    class JsonSerialization
    {
        public void JsonSerialize()
        {
            BlogSites bsobj = new BlogSites()
            {
                Name = "Sam",
                Description = "Welcome to universe"

            };
            string jsonData = JsonConvert.SerializeObject(bsobj);
            Console.WriteLine(jsonData);
        }
    }
    class JsonDeserialization
    {
        public void JsonDeserialize()
        {
            string json = @"{
              'Name' : 'Sam',
              'Description' : 'Welcome to universe'
                 }";
            BlogSites bsobj = JsonConvert.DeserializeObject<BlogSites>(json);
            Console.WriteLine(bsobj.Name);
        }
    }

    [DataContract]
    class BlogSites
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
