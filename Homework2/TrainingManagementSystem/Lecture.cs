

namespace TrainingManagementSystem
{
    class Lecture : LessonBase
    {
        public string Topic { get; set; } = "";

        
        public Lecture(string _topic)
        {
            Topic = _topic;
        }

        public override Lecture Clone()
        {
            var clonedLecture = new Lecture(this.Topic);
            clonedLecture.Description = this.Description;
            return clonedLecture;
        }
    }
}
