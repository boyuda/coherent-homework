

namespace TrainingManagementSystem
{
    class Lecture : LessonBase
    {
        public string Topic { get; set; } = "";

        
        public Lecture(string topic)
        {
            Topic = topic;
        }

        public override Lecture Clone()
        {
            var clonedLecture = new Lecture(this.Topic);
            clonedLecture.Description = this.Description;
            return clonedLecture;
        }
    }
}
