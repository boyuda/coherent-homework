using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    class Training
    {
        public string TextDescription { get; set; } = "";

        public string[] ArrayOfTraining = new string[5];


        //Method to populate array
        public void Add (Lecture lecture, PracticalLesson lesson)
        {
            ArrayOfTraining[0] = lecture.Topic.ToString();
            ArrayOfTraining[1] = lecture.TextDescription.ToString();
            ArrayOfTraining[2] = lesson.TaskCondition.ToString();
            ArrayOfTraining[3] = lesson.TaskSolution.ToString();
            ArrayOfTraining[4] = lesson.TextDescription.ToString();
        }

        //Add method overload
        public void Add(PracticalLesson lesson)
        {
            ArrayOfTraining[0] = "";
            ArrayOfTraining[1] = "";
            ArrayOfTraining[2] = lesson.TaskCondition.ToString();
            ArrayOfTraining[3] = lesson.TaskSolution.ToString();
            ArrayOfTraining[4] = lesson.TextDescription.ToString();
        }


        //Mthod to display info on the console (for testing purposes)
        public void Print()
        {
            Console.WriteLine(@"
            Training Description: {0}
            Lecture Topic: {1}
            Lecture Description: {2}
            Practical Lesson Task Condition: {3}
            Practical Lesson Task Solution: {4}
            Practical Lesson Task Description: {5}
            ", this.TextDescription, ArrayOfTraining[0], ArrayOfTraining[1], ArrayOfTraining[2], ArrayOfTraining[3], ArrayOfTraining[4]);
        }


        //returns true if the training contains only practical lessons
        public bool IsPractical()
        {
            if (string.IsNullOrEmpty(ArrayOfTraining[0]) && (string.IsNullOrEmpty(ArrayOfTraining[1])))
            {
                return true;
            } else
            {
                return false;
            }

        }

        public Training Clone()
        {
            Training deepClone = new Training();
            deepClone.TextDescription = this.TextDescription;
            deepClone.ArrayOfTraining[0] = this.ArrayOfTraining[0];
            deepClone.ArrayOfTraining[1] = this.ArrayOfTraining[1];
            deepClone.ArrayOfTraining[2] = this.ArrayOfTraining[2];
            deepClone.ArrayOfTraining[3] = this.ArrayOfTraining[3];
            deepClone.ArrayOfTraining[4] = this.ArrayOfTraining[4];

            return deepClone;
        }


    }
}
