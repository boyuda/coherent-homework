

namespace TrainingManagementSystem
{
    class PracticalLesson:LessonBase
    {
        public string TaskCondition { get; set; } = "";
        public string TaskSolution { get; set; } = "";

        public PracticalLesson(string _taskCondition, string taskSolution)
        {
            TaskCondition = _taskCondition;
            TaskSolution = taskSolution;
        }

        public override PracticalLesson Clone()
        {
            var clonedLesson = new PracticalLesson(this.TaskCondition, this.TaskSolution);
            clonedLesson.Description = this.Description;
            return clonedLesson;
        }
    }
}
