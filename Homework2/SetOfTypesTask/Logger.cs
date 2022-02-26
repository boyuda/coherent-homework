using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace CustomAttribute
{
    class Logger
    {
        public string FileName { get; set; }
        public List<string> Properties { get; set; }


        //Adding ctor
        public Logger(string fileName )
        {
            FileName = fileName;
            Properties = new List<string>();
        }


        public void Track<T>(T testObject)
        {

            //Checking if class has TrackingEntity applied to it.
            var checkEntityAttribute = testObject.GetType().IsDefined(typeof(TrackingEntityAttribute), true);

            if(!checkEntityAttribute)
            {
                throw new ArgumentException("Class has no entity attribute");
            }


            //Checking if object has any properties with given attribute.
            foreach (var prop in testObject.GetType().GetProperties())
            {
                if (prop.IsDefined(typeof(TrackingPropertyAttribute), false))
                {
                    var customAttribute = prop.GetCustomAttribute<TrackingPropertyAttribute>();
                    if(!(string.IsNullOrWhiteSpace(customAttribute.PropertyName))) 
                    
                    {
                        Properties.Add(customAttribute.PropertyName + ":" + prop.GetValue(testObject, null));
                    }
                    else
                    {
                        Properties.Add(prop.Name.ToString() + ":" + prop.GetValue(testObject, null));
                    }

                }
            }


            //Checking if object has any fields with given attribute.
            FieldInfo[] fields = testObject.GetType().GetFields();


            foreach (var field in fields)
            {

                if (field.IsDefined(typeof(TrackingPropertyAttribute), true))
                {
                    var customAttribute = field.GetCustomAttribute<TrackingPropertyAttribute>();

                    if (!(string.IsNullOrWhiteSpace(customAttribute.PropertyName)))
                    {
                        Properties.Add(customAttribute.PropertyName + ":" + field.GetValue(testObject));
                    }
                    else
                    {
                        Properties.Add(field.Name.ToString() + ":" + field.GetValue(testObject));
                    }
                }
                  
            }


            string json = JsonSerializer.Serialize(Properties);
            File.WriteAllText(@$"D:\{FileName}.json", json);
        }



    }
}
