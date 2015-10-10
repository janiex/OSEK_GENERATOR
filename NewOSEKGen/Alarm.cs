using System;
using System.Collections.Generic;
using System.Text;

namespace NewOSEKGen
{
    public class Alarm
    {
        private string AlarmName_tag;
        private string Counter_tag;
        private string Autostart_enb;
        private string Autostart_Alarmtime;
        private string Autostart_cycletime;
        private string Autostart_appmode;
        private string ACTION_TYPE;

        private string TASK_NAME;
        private string EVENT_NAME;
        private string ALARMCALLBACK;

        //Constructor
    
        public Alarm()
        { 
            AlarmName_tag = "";
            Counter_tag = "";
            Autostart_enb = "";
            Autostart_Alarmtime = "";
            Autostart_cycletime = "";
            Autostart_appmode = "";
            ACTION_TYPE = "";
            TASK_NAME = "";
            EVENT_NAME = "";
            ALARMCALLBACK = "";
        }
        // Alarm Name
        public void SetAlarmName(string p)
        {
            AlarmName_tag = p;  
        }
        public  string GetAlarmName()
        {
            return AlarmName_tag;     
        }
        // Alarm Counter
        public void SetAlarmCounter(string p)
        {
            Counter_tag = p;
        }
        public  string GetAlarmCounter()
        {
            return Counter_tag;
        }
        // Alarm Autostart Enabled
        public void SetAlarmAutostartEn(string p)
        {
            Autostart_enb = p;
        }
        public string GetAlarmAutostartEn()
        {
            return Autostart_enb;
        }
        // Alarm Autostart Alarmtime
        public void SetAutostart_Alarmtime(string p)
        {
            Autostart_Alarmtime = p;
        }
        public string GetAutostart_Alarmtime()
        {
            return Autostart_Alarmtime;
        }
        // Alarm Autostart_cycletime
        public void SetAutostart_cycletime(string p)
        {
            Autostart_cycletime = p;
        }
        public string GetAutostart_cycletime()
        {
            return Autostart_cycletime;
        }

        // Alarm Autostart_cycletime
        public void SetAutostart_appmode(string p)
        {
            Autostart_appmode = p;
        }
        public string GetAutostart_appmode()
        {
            return Autostart_appmode;
        }
        
        // Alarm ACTION_TYPE
        public void SetACTION_TYPE(string p)
        {
            ACTION_TYPE = p;
        }
        public string GetACTION_TYPE()
        {
            return ACTION_TYPE;
        }
        // Alarm TASK_NAME
        public void SetTASK_NAME(string p)
        {
            TASK_NAME = p;
        }
        public string GetTASK_NAME()
        {
            return TASK_NAME;
        }
        // Alarm TASK_NAME
        public void SetEVENT_NAME(string p)
        {
            EVENT_NAME = p;
        }
        public string GetEVENT_NAME()
        {
            return EVENT_NAME;
        }
        // Alarm ALARMCALLBACK
        public void SetALARMCALLBACK(string p)
        {
            ALARMCALLBACK = p;
        }
        public string GetALARMCALLBACK()
        {
            return ALARMCALLBACK;
        }
    }
}
