using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    class PracticalLesson
    {
        public string TaskCondition { get; set; }
        public string TaskSolution { get; set; }
        public string TextDescription { get; set; }

        public PracticalLesson (string taskCondition, string taskSolution, string textDescription)
        {
            this.TaskCondition = taskCondition;
            this.TaskSolution = taskSolution;
            this.TextDescription = textDescription;
        }

        public PracticalLesson(string taskCondition, string taskSolution)
        {
            this.TaskCondition = taskCondition;
            this.TaskSolution = taskSolution;
            this.TextDescription = null;
        }

    }
}
