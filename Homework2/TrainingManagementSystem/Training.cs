using System;
using System.Linq;
using System.Reflection;

namespace TrainingManagementSystem
{
    class Training
    {

        public string Description { get; set; } = "";

        private int trainingsIndex = 0;
        private const int LessonsMaxCount = 10;
        private LessonBase[] trainings = new LessonBase[LessonsMaxCount];


        //Add method 
        public void Add(LessonBase lesson)
        {
            if (trainingsIndex == LessonsMaxCount)
            {
                throw new IndexOutOfRangeException ("Lessons count exceeded allowed value.");
            }
            trainings[trainingsIndex++] = lesson;
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
        public void IsPractical()
        {
            trainings.Any(item => item is PracticalLesson);
        }

        // Method for deep clone
        public Training Clone()
        {
            var deepClone = new Training();

            for (int i = 0; i < trainings.Length; i++)
            {
                deepClone.trainings[i] = (LessonBase)this.trainings[i].Clone();
            }
            return deepClone;
        }
    }
}
