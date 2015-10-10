using System;

namespace NewOSEKGen
{
	/// <summary>
	/// Summary description for Task.
	/// </summary>
	public class Task
	{
		private string TaskName_tag;
		private string TaskPriority_tag;
		private string TaskActivation_tag;
		private string TaskType_tag;		
		private string TaskStackSize_tag;		
		private string TskCallScheduler_tag;
		private string TaskSchedule_tag;
		private string TaskEvent_tag;
		private string TaskResource_tag;
        private bool AutoStartTask_tag;
		public Task()
		{
			
			TaskName_tag = "";
			TaskPriority_tag = "";
			TaskActivation_tag = "";
			TaskType_tag = "";		
			TaskStackSize_tag = "";	
			TskCallScheduler_tag = "";
			TaskSchedule_tag = "";
			TaskEvent_tag = "";
			TaskResource_tag = "";
            AutoStartTask_tag = false;

			

			//
			// TODO: Add constructor logic here
			//
		}
		public void SetTaskName(string p)
		{
			TaskName_tag = p;
		}
		public string GetTaskName()
		{
			return TaskName_tag;
		}

		public void SetTaskPrio(string p)
		{
			TaskPriority_tag = p;
		}
		public string GetTaskPrio()
		{
			return TaskPriority_tag;
		}

		public void SetTaskActivation(string p)
		{
			TaskActivation_tag = p;
		}
		public string GetTaskTaskActivation()
		{
			return TaskActivation_tag;
		}

		public void SetTaskType(string p)
		{
			TaskType_tag = p;
		}
		public string GetTaskType()
		{
			return TaskType_tag;
		}
		public void SetTaskStackSize(string p)
		{
			TaskStackSize_tag = p;
		}
		public string GetTaskStackSize()
		{
			return TaskStackSize_tag;
		}

		public void SetTaskCallScheduler(string p)
		{
			TskCallScheduler_tag = p;
		}
		public string GetTaskCallScheduler()
		{
			return TskCallScheduler_tag;
		}
		

		public void SetTaskScheduler(string p)
		{
			TaskSchedule_tag = p;
		}
		public string GetTaskScheduler()
		{
			return TaskSchedule_tag;
		}

		public void SetTaskEvent(string p)
		{
			TaskEvent_tag = p;
		}
		public string GetTaskEvent()
		{
			return TaskEvent_tag;
		}
		public void SetTaskResource(string p)
		{
			TaskResource_tag = p;
		}
		public string GetTaskResource()
		{
			return TaskResource_tag;
		}
        public void SetAutoStartTask(bool p)
        {
            AutoStartTask_tag = p;
        }
        public bool GetAutoStartTask()
        {
            return AutoStartTask_tag;
        }
	}		
}
