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
            firstLecture.Description = "Running in 2022";
            firstLecture.Test = "dwada";


            var firstLesson = new PracticalLesson();
            firstLesson.TaskCondition = "Have 5 years of experience in running";
            firstLesson.TaskSolution = "Have good running sneakers";
            firstLesson.Description = "Prepare kids for running marathon";

            var firstTraining = new Training();
            firstTraining.Description = "Training consist of running lecture and lesson";

            firstTraining.Add(firstLecture, firstLesson);

            //firstTraining deep cloone
            var secondTraining = firstTraining.Clone();


            //printing results
            secondTraining.Print();
            firstTraining.Print();




        }
    }
}
