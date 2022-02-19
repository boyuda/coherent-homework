using System;

namespace TrainingManagementSystem
{
    class Program
    {
        //Starting point
        static void Main(string[] args)
        {

            //Creating first training with lecture and practical lesson
            var firstLecture = new Lecture("Running");
            var firstLesson = new PracticalLesson("Have 5 years of experience in running", "Have good running sneakers");
            firstLesson.Description = "Prepare kids for running marathon";
            firstLecture.Description = "Interesting";
            

            var firstTraining = new Training();
            firstTraining.Description = "Training consist of running lecture and lesson";
            firstTraining.Add(firstLesson);
            firstTraining.Add(firstLecture);


            //firstTraining deep cloone
            var secondTraining = firstTraining.Clone();
            firstLecture.Description = "test";
            
            //printing results
            firstTraining.Print();
            secondTraining.Print();

            firstTraining.IsPractical();
        
        }
    }
}
