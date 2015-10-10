using System;
using System.Collections.Generic;
using System.Text;

namespace NewOSEKGen
{
    public class SortTasks
    {
        private int[,] TaskPriority;
        private int[] numbers;
        public SortTasks(int TasksCount, Task[] List)
        {
            TaskPriority = new int[2, TasksCount];
            numbers = new int[TasksCount];
            for (int i = 0; i < TasksCount; i++)
            {
                numbers[i] = TaskPriority[0, i] = Convert.ToInt32(List[i].GetTaskPrio());


            }
            Array.Sort(numbers);
            for (int i = 0; i < TasksCount; i++)
            {
                TaskPriority[1, i] = Array.IndexOf(numbers, TaskPriority[0, i]);
            }

        }
        public string GetPriority(int TaskID)
        {
            return ((TaskPriority[1,TaskID]+1).ToString());

        }

    }
}
