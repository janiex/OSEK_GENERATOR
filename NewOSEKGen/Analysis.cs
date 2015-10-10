using System;
using System.Collections.Generic;
using System.Text;

namespace NewOSEKGen
{
    public class Analysis
    {
        private string TaskName;
        private int RealPriority;
        private int SchedulePriority;
        private double CyclePeriod;
        private double ExecutionTime;
        private bool Preemptive; // 0 - non; 1- preemptive
        public Analysis()
        {
            TaskName = "";
            RealPriority = 1;
            SchedulePriority = 1;
            CyclePeriod = 1.0F;
            ExecutionTime = 1.0F;
            Preemptive = false;
        }
        public void SetTasksName(string p)
        {
            TaskName = p;
        }
        public string GetTasksName()
        {
            return TaskName;
        }
        public void SetRealPri(int a)
        {
            RealPriority = a;
        }
        public int GetRealPrio()
        {
            return RealPriority;
        }
        public void SetExecPri(int a)
        {
            SchedulePriority = a;
        }
        public int GetExecPri()
        {
            return SchedulePriority;
        }
        public void SetCycle(double a)
        {
            CyclePeriod = a;
        }
        public double GetCycle()
        {
            return CyclePeriod;
        }
        public void SetExecTime(double a)
        {
            ExecutionTime = a;
        }
        public double GetExecTime()
        {
            return ExecutionTime;
        }
        public void SetPreemptive(bool a)
        {
            Preemptive = a;
        }
        public bool GetPreemptive()
        {
            return Preemptive;
        }
        
    }
    
}
