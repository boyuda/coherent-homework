using System;

namespace TrainingManagementSystem
{
    class Program
    {
        //Starting point
        static void Main(string[] args)
        {
            var lectureOne = new Lecture();
            lectureOne.Topic = "Swiming";
            lectureOne.Topic = "Information on how to swim faster";

            var practicalLesson = new PracticalLesson();
            practicalLesson.TaskCondition = "Have 5 years experience";
            practicalLesson.TaskSolution = "Swim faster";


            var trainingOne = new Training("Swimer", "Teaching kids on swiming");
            trainingOne.Add(lectureOne);

            trainingOne.IsPractical();
        }
    }
}
