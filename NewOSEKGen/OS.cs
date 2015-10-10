using System;
using System.Collections.Generic;
using System.Text;

namespace NewOSEKGen
{
    class OS
    {
        private string MicroSelection_tag;
        private string CC_tag;
        private string STACK_CHECK_tag;
        private string ERROR_CHECKING_EXTENDED_tag;
        private string STARTUP_HOOK_tag;
        private string SHUTDOWN_HOOK_tag;
        private string PRETASK_HOOK_tag;
        private string POSTTASK_HOOK_tag;
        private string PREISR_HOOK_tag;
        private string POSTISR_HOOK_tag;
        private string INTERRUPT_NESTING_tag;
        public OS()
        {
            MicroSelection_tag = "";
            CC_tag = "";
            STACK_CHECK_tag = "";
            ERROR_CHECKING_EXTENDED_tag = "";
            STARTUP_HOOK_tag = "";
            SHUTDOWN_HOOK_tag = "";
            PRETASK_HOOK_tag = "";
            POSTTASK_HOOK_tag = "";
            PREISR_HOOK_tag = "";
            POSTISR_HOOK_tag = "";
            INTERRUPT_NESTING_tag = "";
        }
        /******************************************/
        public void SetMicroSelection(string p)
        {
            MicroSelection_tag = p.ToUpper();
        }
        public string GetMicroSelection()
        {
            return MicroSelection_tag;
 
        }
        /******************************************/
        /******************************************/
        public void SetCC(string p)
        {
            CC_tag = p;
        }
        public string GetCC()
        {
            return CC_tag;

        }
        /******************************************/
        /******************************************/
        public void SetSTACK_CHECK(string p)
        {
            STACK_CHECK_tag = p.ToUpper(); 
        }
        public string GetSTACK_CHECK()
        {
            return STACK_CHECK_tag;

        }
        /******************************************/
        /******************************************/
        public void SetERROR_CHECKING_EXTENDED(string p)
        {
            ERROR_CHECKING_EXTENDED_tag = p.ToUpper();
        }
        public string GetERROR_CHECKING_EXTENDED()
        {
            return ERROR_CHECKING_EXTENDED_tag;

        }
        /******************************************/
        /******************************************/
        public void SetSTARTUP_HOOK(string p)
        {
            STARTUP_HOOK_tag = p.ToUpper();
        }
        public string GetSTARTUP_HOOK()
        {
            return STARTUP_HOOK_tag;

        }
        /******************************************/
        /******************************************/
        public void SetSHUTDOWN_HOOK(string p)
        {
            SHUTDOWN_HOOK_tag = p.ToUpper();
        }
        public string GetSHUTDOWN_HOOK()
        {
            return SHUTDOWN_HOOK_tag;

        }
        /******************************************/
        /******************************************/
        public void SetPRETASK_HOOK(string p)
        {
            PRETASK_HOOK_tag = p.ToUpper();
        }
        public string GetPRETASK_HOOK()
        {
            return PRETASK_HOOK_tag;

        }
        /******************************************/
        /******************************************/
        public void SetPOSTTASK_HOOK(string p)
        {
            POSTTASK_HOOK_tag = p.ToUpper();
        }
        public string GetPOSTTASK_HOOK()
        {
            return POSTTASK_HOOK_tag;

        }
        /******************************************/
        /******************************************/
        public void SetPREISR_HOOK(string p)
        {
            PREISR_HOOK_tag = p.ToUpper();
        }
        public string GetPREISR_HOOK()
        {
            return PREISR_HOOK_tag;

        }
        /******************************************/
        /******************************************/
        public void SetPOSTISR_HOOK(string p)
        {
            POSTISR_HOOK_tag = p.ToUpper();
        }
        public string GetPOSTISR_HOOK()
        {
            return POSTISR_HOOK_tag;

        }
        /******************************************/
        /******************************************/
        public void SetINTERRUPT_NESTING(string p)
        {
            INTERRUPT_NESTING_tag = p.ToUpper();
        }
        public string GetINTERRUPT_NESTING()
        {
            return INTERRUPT_NESTING_tag;

        }
        /******************************************/
     
    }
}
