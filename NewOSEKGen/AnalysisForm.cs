using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewOSEKGen
{
    
    public partial class AnalysisForm : Form
    {
        
        public AnalysisForm(Task[] TaskInfo, Alarm[] AlarmInfo)
        {
            InitializeComponent();

            //int TaskCounter = 0;
            int b;
            while(null != TaskInfo[TaskCounter])
            {
                AnalysisData.Rows.Add();
                AnalysisData.Rows[TaskCounter].Cells[0].Value = TaskInfo[TaskCounter].GetTaskName();
                AnalysisData.Rows[TaskCounter].Cells[1].Value = TaskInfo[TaskCounter].GetTaskPrio();
                b = 0;
                while (null != AlarmInfo[b])
                {
                    if (TaskInfo[TaskCounter].GetTaskName() == AlarmInfo[b].GetTASK_NAME())
                    {
                        AnalysisData.Rows[TaskCounter].Cells[2].Value = AlarmInfo[b].GetAutostart_cycletime() + " 000";
                        AnalysisData.Rows[TaskCounter].Cells[0].ReadOnly = true;
                        AnalysisData.Rows[TaskCounter].Cells[1].ReadOnly = true;
                        AnalysisData.Rows[TaskCounter].Cells[3].ReadOnly = true;
                        AnalysisData.Rows[TaskCounter].Cells[7].ReadOnly = true;
                        AnalysisData.Rows[TaskCounter].Cells[8].ReadOnly = true;
                        break;
                    }
                    b++;
                }
                AnalysisData.Rows[TaskCounter].Cells[3].Value = ((TaskInfo[TaskCounter].GetTaskScheduler()=="NON")?"Non-Preemptive":"Pre-Emptive");
       

                TaskCounter++;
            }

            MaximumExec.Checked = true;
        }

        private void Analyze_Click(object sender, EventArgs e)
        {
            int a = 0;
            double C = 0;
            double  T = 0;
            double ItsTime = 0.0F;
            double Higher = 0.0F;
            double Lower = 0.0F;
            int selection;
            if (MaximumExec.Checked)
            {
                selection = 6;
            }
            else if (AverageExec.Checked)
            {
                selection = 5;
            }
            else if (MinimumExec.Checked)
            {
                selection = 4;
            }
            else
            {

                selection = 6;
                

            }
            if ((AnalysisData.Rows[a].Cells[selection].Value != null) && ((AnalysisData.Rows[a].Cells[2].Value != null)))
            {
                for (a = 0; a < TaskCounter; a++)
                {

                    try
                    {
                        C = Convert.ToDouble(AnalysisData.Rows[a].Cells[selection].Value);

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("The  value is not recognized as a valid value.");
                        }
                    catch (InvalidCastException)
                    {
                        MessageBox.Show("Convertion error please check the value!");
                    }
                    try
                    {
                         T = Convert.ToDouble(AnalysisData.Rows[a].Cells[2].Value);

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("The value is not recognized as a valid value.");
                    }
                    catch (InvalidCastException)
                    {
                        MessageBox.Show("Convertion error please check the value!");
                    }

                    AnalysisData.Rows[a].Cells[7].Value = C / T;  
                    // TaskAnal[TaskCounter].
                }
                
            }
            

            for (a = 0; a < (AnalysisData.Rows.Count-1); a++)
            {
                TaskAnal[a] = new Analysis();
                
                int ExecTime = Convert.ToInt32(AnalysisData.Rows[a].Cells[selection].Value);
                TaskAnal[a].SetTasksName(AnalysisData.Rows[a].Cells[0].Value.ToString());
                TaskAnal[a].SetCycle(Convert.ToDouble(AnalysisData.Rows[a].Cells[2].Value));
                TaskAnal[a].SetRealPri(Convert.ToInt32(AnalysisData.Rows[a].Cells[1].Value));
                TaskAnal[a].SetPreemptive("Non-Preemptive" == AnalysisData.Rows[a].Cells[3].Value.ToString() ? false : true);
                TaskAnal[a].SetExecTime(ExecTime);
            }
            MakeExecPriority(TaskAnal, (AnalysisData.Rows.Count - 1));
            for (a = 0; a < (AnalysisData.Rows.Count - 1); a++)
            {
                ItsTime = TaskAnal[a].GetExecTime();
                Higher = GetHiherPriorityTime(TaskAnal, (AnalysisData.Rows.Count - 1), a);
                Lower = GetLowPriority(TaskAnal, (AnalysisData.Rows.Count - 1), a);
                AnalysisData.Rows[a].Cells[8].Value = ItsTime + Lower + Higher;
            }
            ItsTime = 0.0F;
            if (CheckRMS(TaskAnal, (AnalysisData.Rows.Count - 1)))
            {
                for (a = 0; a < (AnalysisData.Rows.Count - 1); a++)
                {
                    ItsTime += Convert.ToDouble(AnalysisData.Rows[a].Cells[7].Value);
                }
                ItsTime = ItsTime * 100.0F;
                ExecutionLoad.Text = String.Format("{0:0.##}",ItsTime.ToString()) + " %";
                if (69.31F > ItsTime)
                {
                    ExecutionLoad.BackColor = Color.Green;
                    ScheduleRT.Text = "YES";
                    ScheduleRT.BackColor = Color.Green;
                }
                else
                {
                    ExecutionLoad.BackColor = Color.Red;
                    ScheduleRT.Text = "NO";
                    ScheduleRT.BackColor = Color.Red;
                }
            }

        }
        private bool CheckRMS(Analysis[] List, int Count)
        {
            int i,j;
            bool Result = true;

            for (i = 0; i < Count; i++)
            {
                for (j = 0; j < Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        if (List[i].GetExecPri() > List[j].GetExecPri())
                        {
                            if (List[i].GetCycle() <= List[j].GetCycle())
                            {
                                
                            }
                            else
                            {
                                Result = false;
                            }
                        }
                    }
                }
            }
            if (!Result)
            {
                RMS_OK.Text = "NO";
                RMS_OK.BackColor = Color.Red;
                ExecutionLoad.Text = "NO RMS";
                ExecutionLoad.BackColor = Color.Red;
                ScheduleRT.Text = "NO RMS";
                ScheduleRT.BackColor = Color.Red;

            }
            else
            {
                RMS_OK.Text = "YES";
                RMS_OK.BackColor = Color.Green;
            }
            return Result;
        }
        private void MakeExecPriority(Analysis[] List, int Count)
        {
            int[] numbers = new int[Count];
            for(int a = 0; a < Count; a++ )
            {
                numbers[a] = List[a].GetRealPrio();
            }
            Array.Sort(numbers);
            for (int a = 0; a < Count; a++)
            {
                List[a].SetExecPri(Array.IndexOf(numbers, List[a].GetRealPrio()));
            }
        }
        private double GetHiherPriorityTime(Analysis[] List, int Count, int index)
        {
            double Result = 0.0F;
            for (int i = 0; i < Count; i++)
            {
                if ((i != index) && (List[index].GetExecPri() < List[i].GetExecPri()))
                {
                    Result += List[i].GetExecTime();
                }
            }
            return Result;
        }
        private double GetLowPriority(Analysis[] List, int Count, int index)
        {
            double Result = 0.0F;
            for (int i = 0; i < Count; i++)
            {
                if (i != index)
                {
                    if (List[i].GetExecPri() < List[index].GetExecPri())
                    {
                        if (!List[i].GetPreemptive())
                        {
                            if (Result < List[i].GetExecTime())
                            {
                                Result = List[i].GetExecTime();
                            }
                        }
                    }
                }
            }
            return Result;
        }
    }
}