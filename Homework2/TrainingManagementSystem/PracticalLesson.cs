

namespace TrainingManagementSystem
{
    class PracticalLesson:LessonBase
    {
        public string TaskCondition { get; set; } = "";
        public string TaskSolution { get; set; } = "";

        public PracticalLesson(string _taskCondition, string taskSolution, string _description)
        {
            TaskCondition = _taskCondition;
            TaskSolution = taskSolution;
        }

    }
}
