using System;
using System.Collections.Generic;
using System.Text;

namespace NewOSEKGen
{
    class Counter
    {
        private string CounterName_tag;
        private string TimerName_tag;
        private string MinCycle_tag;
        private string MaxAllowedValue_tag;
        private string TickPerBase_tag;
        private string TimeInNS_tag;
        private int AssociatedAlarms;
        
        public Counter()
        {
            CounterName_tag = "";
            TimerName_tag = "";
            MinCycle_tag = "";
            MaxAllowedValue_tag = "";
            TickPerBase_tag = "";
            TimeInNS_tag = "";
            AssociatedAlarms = 0;           
            //
            // TODO: Add constructor logic here
            //            
        }
        public void SetCounterName(string p)
        {
            CounterName_tag = p;
        }
        public string GetCounterName()
        {
            return CounterName_tag;
        }

        public void SetTimerName(string p)
        {
            TimerName_tag = p;
        }
        public string GetTimerName()
        {
            return TimerName_tag;
        }
        public void SetMinCycle(string p)
        {
            MinCycle_tag = p;
        }
        public string GetMinCycle()
        {
            return MinCycle_tag;
        }
        public void SetMaxAllowedValue(string p)
        {
            MaxAllowedValue_tag = p;
        }
        public string GetMaxAllowedValue()
        {
            return MaxAllowedValue_tag;
        }
        //TickPerBase_tag
        public void SetTickPerBase(string p)
        {
            TickPerBase_tag = p;
        }
        public string GetTickPerBase()
        {
            return TickPerBase_tag;
        }
        //TimeInNS_tag
        public void SetTimeInNS(string p)
        {
            TimeInNS_tag = p;
        }
        public string GetTimeInNS()
        {
            return TimeInNS_tag;
        }
        public void SetAssociatedAlarms(int NumberOfAlarmsForThisCounter)
        {
            AssociatedAlarms = NumberOfAlarmsForThisCounter;
        }
        public int GetAssociatedAlarms()
        {
            return AssociatedAlarms;
        }

        
        
    }
    
}
