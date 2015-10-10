#ifndef COMMON_H_
#define COMMON_H_
/**********************************************************************************************************************
 * INCLUDES
 *********************************************************************************************************************/
#include "OS_Types.h"


/**********************************************************************************************************************
 * VARIABLES DECLARATION
 *********************************************************************************************************************/
extern ContextType ActualContext;
extern TaskType RunningTask;
extern AppModeType ApplicationMode;
extern pStackPtr volatile pRunningTask;
/**********************************************************************************************************************
 * ACCESS MACROS
 *********************************************************************************************************************/
 /** param[in] newcontext valid values are:
 **               - CONTEXT_INVALID
 **               - CONTEXT_TASK
 **               - CONTEXT_ISR1
 **               - CONTEXT_ISR2
 **/
#define SetActualContext(newcontext)        \
	{										\
		ActualContext = (newcontext);		\
	}
#define GetCallingContext()   (ActualContext)
#define GetRunningTask()   (RunningTask)
#define SetRunningTask(newtask)  (RunningTask = (newtask) )
#define ReleaseInternalResources()							\
	{																	\
		/* set the priority to the normal value */		\
		TasksVar[GetRunningTask()].ActualPriority =		\
		TasksConst[GetRunningTask()].StaticPriority;		\
	}
#define GetCounter_Arch(CounterID) (CountersVar[CounterID].Time)
#define GetCounter(CounterID) GetCounter_Arch(CounterID)	
#define PostTaskHook()
#define PreTaskHook()	
#endif /*COMMON_H_*/
