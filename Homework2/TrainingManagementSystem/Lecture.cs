

namespace TrainingManagementSystem
{
    class Lecture : LessonBase
    {
        protected string Topic { get; set; } = "";

        
        public Lecture(string _topic)
        {
            Topic = _topic;
        }
    }
}
