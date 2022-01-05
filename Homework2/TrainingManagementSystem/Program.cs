using System;

namespace TrainingManagementSystem
{
    class Program
    {
        //Starting point
        static void Main(string[] args)
        {

            //Creating first training with lecture and practical lesson
            var firstLecture = new Lecture();
            firstLecture.Topic = "Running";
            firstLecture.TextDescription = "Running in 2022";

            var firstLesson = new PracticalLesson();
            firstLesson.TaskCondition = "Have 5 years of experience in running";
            firstLesson.TaskSolution = "Have good running sneakers";
            firstLesson.TextDescription = "Prepare kids for running marathon";

            var firstTraining = new Training();
            firstTraining.Add(firstLecture, firstLesson);

            //firstTraining deep cloone
            var secondTraining = firstTraining.Clone();

            //printing results
            secondTraining.Print();
            firstTraining.Print();




        }
    }
}
