using System;


namespace TrainingManagementSystem
{
    class Training
    {

        private string[] lessons = new string[5];
        private LessonBase[] trainings = new LessonBase[5];

        public string Description { get; set; } = "";

        //Method to populate array
        public void Add (Lecture lecture, PracticalLesson lesson)
        {
            lessons[0] = lecture.Topic.ToString();
            lessons[1] = lecture.Description.ToString();
            lessons[2] = lesson.TaskCondition.ToString();
            lessons[3] = lesson.TaskSolution.ToString();
            lessons[4] = lesson.Description.ToString();

            trainings[0] = lecture.Test.ToString();
        }

        //Add method overload
        public void Add(PracticalLesson lesson)
        {
            lessons[0] = "";
            lessons[1] = "";
            lessons[2] = lesson.TaskCondition.ToString();
            lessons[3] = lesson.TaskSolution.ToString();
            lessons[4] = lesson.Description.ToString();
           // this.Description = description.ToString();
        }

        //Method to display info on the console (for testing purposes)
        public void Print()
        {
            Console.WriteLine(@"
            Training Description: {0}
            Lecture Topic: {1}
            Lecture Description: {2}
            Practical Lesson Task Condition: {3}
            Practical Lesson Task Solution: {4}
            Practical Lesson Task Description: {5}
            ", this.Description, lessons[0], lessons[1], lessons[2], lessons[3], lessons[4]);
        }

        //returns true if the training contains only practical lessons
        public bool IsPractical()
        {
            if (string.IsNullOrEmpty(lessons[0]) && (string.IsNullOrEmpty(lessons[1])))
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

            for (int i = 0; i < lessons.Length; i++)
            {
                deepClone.lessons[i] = this.lessons[i];
            }

            return deepClone;
        }

    }
}
