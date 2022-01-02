using System;

namespace TrainingManagementSystem
{
    class Program
    {
        //Starting point
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var lectureOne = new Lecture();
            lectureOne.Topic = "How's running good for you";
            lectureOne.TextDescription = "500 years history";



            var lectureTwo = new Lecture();
            lectureTwo.Topic = "testone";

            var practicalLessonOne = new PracticalLesson("Test Condition", "Test Solution", "Test Description");

            var practicalLessonTwo = new PracticalLesson("Test Condition", "Test Solution");

            string test = Convert.ToString(practicalLessonOne.ToString());
            Console.WriteLine(test);

            var trainingOne = new Training("TestOne", "TestTwo");
            trainingOne.Add(lectureTwo, practicalLessonTwo);
           // trainingOne.Print();
            

        }
    }
}
