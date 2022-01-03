using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    class Training
    {
        public string TrainingName { get; set; }
        public string TextDescription { get; set; } = "";

        public static object[][] ArrayOfTrainings = new object[1][];

        private static int PositionInArray { get; set; }

        public Training (string trainingName, string textDescription)
        {
            this.TrainingName = trainingName;
            this.TextDescription = textDescription;
        }

        //Adding objects to the JaggedArray
        public void Add(object lectures, object practicalLesson)
        {
            ArrayOfTrainings[PositionInArray] = new object[] { lectures, practicalLesson };
            PositionInArray++;
        }

        public void Add(object lectures)
        {
            ArrayOfTrainings[PositionInArray] = new object[] { lectures, null };
            PositionInArray++;
        }



        public void Print()
        {
            string lol =  Convert.ToString(ArrayOfTrainings[0][1]);
            Console.WriteLine(lol.ToString());
        }



        public void IsPractical()
        {
            {
                foreach (object[] array in ArrayOfTrainings)
                {
                    foreach (object value in array)
                    {
                        Console.WriteLine("test");
                    }
                }
            }
        }

        public void Clone()
        {
            //do something
        }


    }
}
