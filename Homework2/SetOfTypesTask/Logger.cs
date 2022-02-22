using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CustomAttribute
{
    class Logger
    {
        public string FileName { get; set; }

        public Logger(string fileName )
        {
            if(string.IsNullOrEmpty(fileName)) 
            {
                fileName = "test";
            }

            FileName = fileName;
        }

        public void Track(object testObject)
        {
            var checkEntityAttribute = testObject.GetType().IsDefined(typeof(TrackingEntityAttribute), true);

            if(!checkEntityAttribute)
            {
                throw new ArgumentException("Class has no entity attribute");
            }

            string json = JsonSerializer.Serialize(testObject);
            File.WriteAllText(@$"D:\{FileName}.json", json);


            //foreach (var prop in testObject.GetType().GetProperties())
            //{
            //    Console.WriteLine("{0}={1}", prop.Name, prop.GetValue(testObject, null));
            //}
        }

        public void Propert(object testObject)
        {
            //
        }

        public void  att()
        {
        }

    }
}
