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
            lectureOne.TextDescription = "Information on how to swim faster";

            var practicalLesson = new PracticalLesson();
            practicalLesson.TaskCondition = "Have 5 years experience";
            practicalLesson.TaskSolution = "Swim faster";


            var trainingOne = new Training();
            trainingOne.Add(lectureOne, practicalLesson);

            trainingOne.Print();




            var lectureTwo = new Lecture();
            lectureOne.Topic = "Running";
            lectureOne.TextDescription = "Information on how to run faster";


            var practicalLessonTwo = new PracticalLesson();
            practicalLessonTwo.TaskCondition = "Have 3 years running experience";
            practicalLessonTwo.TaskSolution = "Run faster";

            var trainingTwo = new Training();
            trainingTwo.Add(lectureTwo, practicalLessonTwo);
            trainingTwo.TextDescription = "Funny";

            trainingTwo.Print();

            trainingOne.IsPractical();
            trainingTwo.IsPractical();


        }
    }
}
