using System;
using System.Reflection;

namespace TrainingManagementSystem
{
    class Training
    {

        private LessonBase[] trainings = new LessonBase[2];

        public string Description { get; set; } = "";

        //Method to populate array
        public void Add (Lecture lecture, PracticalLesson lesson)
        {
            trainings[0] = lecture;
            trainings[1] = lesson;
        }

        //Add method overload
        public void Add(PracticalLesson lesson)
        {
            trainings[1] = lesson;
        }

        //Add method overload
        public void Add(LessonBase description)
        {
            Description = description.ToString();
        }

        //Method to display info on the console (for testing purposes)
        public void Print()
        {
            Console.WriteLine(Description);
            foreach (object n in trainings)
            {
                foreach (PropertyInfo property in n.GetType().GetProperties())
                {

                    Console.WriteLine(property.GetValue(n));
                }
            }
        }

        //returns true if the training contains only practical lessons
        public bool IsPractical()
        {
            if (trainings[0] == null)
            {
                return true;
            } else
            {
                return false;
            }

        }

        // Method for deep clone
        public Training Clone()
        {
            var deepClone = new Training();
            deepClone.Description = this.Description;

            for (int i = 0; i < trainings.Length; i++)
            {
                deepClone.trainings[i] = this.trainings[i];
            }

            return deepClone;
        }

    }
}
