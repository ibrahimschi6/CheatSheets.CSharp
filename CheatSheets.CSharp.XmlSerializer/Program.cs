using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

namespace CheatSheets.CSharp.XmlSerializer
{
    public class Program
    {
        static void Main(string[] args)
        {

            SampleClass input = new SampleClass { Id = 1, Name = "First", SubClasses = new List<SampleSubClass>() };

            for (int i = 0; i < 10; i++)
            {
                input.SubClasses.Add(new SampleSubClass { Id = 10 + i, Name = "Test" + i });
            }


            //CALL
            var testData = SerializeToString(input);

            Console.WriteLine(testData);

            SerializeToFile(testData, @"c:\temp\ObjectToText.xml");

            Console.ReadKey();
        }

        public static string SerializeToString(object obj)
        {
            XmlSerializerFactory serializerFactory = new XmlSerializerFactory();
            var serializer = serializerFactory.CreateSerializer(obj.GetType());

            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);

                return writer.ToString();
            }
        }
        public static void SerializeToFile(object obj, string fileFullPath){
            var xmlWriter =  System.Xml.XmlWriter.Create(fileFullPath);

            (new System.Xml.Serialization.XmlSerializer(obj.GetType())).Serialize(xmlWriter, obj);
        }
    }
        public class SampleClass
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public List<SampleSubClass> SubClasses { get; set; }
        }
        public class SampleSubClass
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }
    
}