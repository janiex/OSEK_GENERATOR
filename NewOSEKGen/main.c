
/* Standard includes. */
#include <msp430.h>
#include "HW_config.h"
#include "Tables.h"
#include "Counter.h"
#include "Alarm.h"
#include "Task.h"
/*******************************************************************************
 **                    loval variables                                        **
 *******************************************************************************/
uint8 SuspendOSInterrupts_Counter;

uint8 DisableAllInterrupts_Counter;

uint8 SuspendAllInterrupts_Counter;
ContextType ActualContext ;
TaskType RunningTask = INVALID_TASK;
/*******************************************************************************
 **                    Function prototypes                                    **
 *******************************************************************************/
void StartOS(AppModeType Mode);
void StartOs_Arch(void);
void StartOs_Arch_Cpu(void);
static uint8 CreatTask(TaskType TaskID);
static pStackPtr InitialiseStack( pStackPtr pStack, pTASK_CODE pxCode, uint32 stacksize);
#if (HOOK_STARTUPHOOK == ENABLE)
void StartupHook(void);

#endif
void TerminateTsk(void);


/*******************************************************************************
 **                    Local Variables                                        **
 *******************************************************************************/

pStackPtr volatile pRunningTask = NULL;



/*******************************************************************************
 **                    TASKS                                                  **
 *******************************************************************************/

/*******************************************************************************
 **                    Local Macro                                            **
 *******************************************************************************/
/*******************************************************************************
**                                                                            **
** FUNC-NAME     :                                                            **
**                                                                            **
** DESCRIPTION   :                                                            **
**                                                                            **
** PRECONDITIONS :                                                            **
**                                                                            **
** PARAMETER     :                                                            **
**                                                                            **
** RETURN        :                                                            **
**                                                                            **
** REMARKS       :                                                            **
**                                                                            **
*******************************************************************************/
int main (void)
{
	/* Setup the hardware for use with the Olimex demo board. */
	SetupHardware();
#if(UART_INTERFACE == ENABLE)	
	SendString("\r\nI've got the power!\r\n");
#endif /* (UART_INTERFACE == ENABLE)	*/
	/* now start the OS */
	StartOS(OS_NORMAL_MODE);
	/* This fragment should never be reached ! */
	return 0;
}


/*******************************************************************************
**                                                                            **
** FUNC-NAME     :                                                            **
**                                                                            **
** DESCRIPTION   :                                                            **
**                                                                            **
** PRECONDITIONS :                                                            **
**                                                                            **
** PARAMETER     :                                                            **
**                                                                            **
** RETURN        :                                                            **
**                                                                            **
** REMARKS       :                                                            **
**                                                                            **
*******************************************************************************/
/*
 * The ISR used for the scheduler tick.
 */

void vTickISR( void )
{
		
		
}

/*******************************************************************************
**                                                                            **
** FUNC-NAME     :                                                            **
**                                                                            **
** DESCRIPTION   :                                                            **
**                                                                            **
** PRECONDITIONS :                                                            **
**                                                                            **
** PARAMETER     :                                                            **
**                                                                            **
** RETURN        :                                                            **
**                                                                            **
** REMARKS       :                                                            **
**                                                                            **
*******************************************************************************/

void vPortYieldProcessor(void)
{

}


/*******************************************************************************
**                                                                            **
** FUNC-NAME     :                                                            **
**                                                                            **
** DESCRIPTION   :                                                            **
**                                                                            **
** PRECONDITIONS :                                                            **
**                                                                            **
** PARAMETER     :                                                            **
**                                                                            **
** RETURN        :                                                            **
**                                                                            **
** REMARKS       :                                                            **
**                                                                            **
*******************************************************************************/

void StartOS
(
	AppModeType Mode
)
{
	/* \req OSEK_SYS_3.25 The system service void
	 ** StartOS ( AppModeType Mode ) shall be defined */

	/* \req OSEK_SYS_3.25.1 This system service shall starts the operating
	 ** system */
	uint8f loopi;

	IntSecure_Start();

	/* save the aplication mode */
	ApplicationMode = Mode;

	/* StartOs_Arch  - the tasks are initiated with a IRQ like context */
	StartOs_Arch();

	/* set sys context */
	SetActualContext(CONTEXT_SYS);

	/* set actual task to invalid task */
	SetRunningTask(INVALID_TASK);
#if(TASKS_AUTOSTART_COUNT > 0)
	/*************************************************************************
	 * The autostar tasks are just started without other trigger,
	 * than the OS start-up. After that they can be executed by their trigger.
	 * ************************************************************************
	 */
	/* add to ready the corresponding tasks for this
    * Application Mode */
	for (loopi = 0; loopi < AutoStart[Mode].TotalTasks; loopi++)
	{
		/* activate task */
		ActivateTask(AutoStart[Mode].TasksRef[loopi]);
	}
#endif //(TASKS_AUTOSTART_COUNT > 0)
#if (ALARM_AUTOSTART_COUNT > 0)
	/* *************************************************************************
	 * The difference between autostart alarm and general one is
	 * only the starting point. General alarms are started in explicit way.
	 * Autostart alarms are started by the start-up of the system.
	 * *************************************************************************
	 * */
	for (loopi = 0; loopi < ALARM_AUTOSTART_COUNT; loopi++)
	{
		if (AutoStartAlarm[loopi].Mode == Mode)
		{
			(void)SetRelAlarm(AutoStartAlarm[loopi].Alarm, AutoStartAlarm[loopi].AlarmTime, AutoStartAlarm[loopi].AlarmCycleTime);
		}
	}
#endif

#if (HOOK_STARTUPHOOK == ENABLE)
	StartupHook();
#endif

	IntSecure_End();

	SetRunningTask(GetRunningTask());
	/* set actual context task */
	SetActualContext(CONTEXT_TASK);
	
	pRunningTask = TasksVar[GetRunningTask()].pTopOfStack;
	asm(" mov	 &pRunningTask,R12");
	asm(" mov R12, SP");
	asm(" popm.w #12,R15");
	asm(" reti");
	
	while(1);
}

/*******************************************************************************
**                                                                            **
** FUNC-NAME     :                                                            **
**                                                                            **
** DESCRIPTION   :                                                            **
**                                                                            **
** PRECONDITIONS :                                                            **
**                                                                            **
** PARAMETER     :                                                            **
**                                                                            **
** RETURN        :                                                            **
**                                                                            **
** REMARKS       :                                                            **
**                                                                            **
*******************************************************************************/
void StartOs_Arch(void)
{
	uint8f loopi;
	/* Init the stack spaces with patterns and water-marks                    */
	/* initialize the stacks of the system */
	/* init every task */
	for( loopi = 0; loopi < TASKS_COUNT; loopi++)
	{
		/* init stack */
		CreatTask(loopi);
	}
	/* Add the idle task into thre ready queue                                */
	//AddReady(Task_IDLE);
	/* call CPU dependent initialisation                                      */
	StartOs_Arch_Cpu();
	return;
}

/*******************************************************************************
**                                                                            **
** FUNC-NAME     :                                                            **
**                                                                            **
** DESCRIPTION   :                                                            **
**                                                                            **
** PRECONDITIONS :                                                            **
**                                                                            **
** PARAMETER     :                                                            **
**                                                                            **
** RETURN        :                                                            **
**                                                                            **
** REMARKS       :                                                            **
**                                                                            **
*******************************************************************************/
void StartOs_Arch_Cpu(void)
{

	/* Set-up the tick timer interrupt										  */
	SetupTimerInterrupt();
	return;
}








/*******************************************************************************
**                                                                            **
** FUNC-NAME     :                                                            **
**                                                                            **
** DESCRIPTION   :                                                            **
**                                                                            **
** PRECONDITIONS :                                                            **
**                                                                            **
** PARAMETER     :                                                            **
**                                                                            **
** RETURN        :                                                            **
**                                                                            **
** REMARKS       :                                                            **
**                                                                            **
*******************************************************************************/
uint8 CreatTask(TaskType TaskID)
{
	StatusType result;
	if(TASKS_MAX_NUMBER >  TaskID)
	{
		TasksVar[TaskID].ActualPriority = TasksConst[TaskID].StaticPriority;
		TasksVar[TaskID].Activations    = TasksConst[TaskID].MaxActivations;
		TasksVar[TaskID].Flags          = TasksConst[TaskID].ConstFlags;
		TasksVar[TaskID].Events         = 0; /* TODO */
		TasksVar[TaskID].EventsWait     = 0; /* TODO */
		TasksVar[TaskID].pTopOfStack    = InitialiseStack(
															TasksConst[TaskID].StackPtr,
															TasksConst[TaskID].EntryPoint,
															(TasksConst[TaskID].StackSize)
															);
		result = E_OK;															
	}
	else
	{
		result = E_OS_LIMIT;
	}
	
return result;
}



/*******************************************************************************
**                                                                            **
** FUNC-NAME     :                                                            **
**                                                                            **
** DESCRIPTION   :                                                            **
**                                                                            **
** PRECONDITIONS :                                                            **
**                                                                            **
** PARAMETER     :                                                            **
**                                                                            **
** RETURN        :                                                            **
**                                                                            **
** REMARKS       :                                                            **
**                                                                            **
*******************************************************************************/
/*
 * Initialise the stack of a task to look exactly as if a call to
 * SAVE_CONTEXT had been called.
 *
 * See header file for description.
 */
/* Scheduler utilities. */

pStackPtr InitialiseStack( pStackPtr pStack, pTASK_CODE pxCode, uint32 stacksize)
{
	if(NULL != pStack)
	{
		pStackPtr pSt = (pStack + stacksize-1);
	    *pSt = 0xBEEF; // The water mark
		pSt--;
	   *pSt = (uint16)pxCode;
		pSt--;
		*pSt = 0x0008; //SR
		pSt--;
		*pSt-- = 0x1515; //R15
		*pSt-- = 0x1414; //R14
		*pSt-- = 0x1313; //R13
		*pSt-- = 0x1212; //R12
		*pSt-- = 0x1111; //R11
		*pSt-- = 0x1010; //R10
		*pSt-- = 0x0909; //R9
		*pSt-- = 0x0808; //R8
		*pSt-- = 0x0707; //R7
		*pSt-- = 0x0606; //R6
		*pSt-- = 0x0505; //R5
		*pSt   = 0x0404; //R4
		
		return pSt;
	}
	
	return NULL;
}

/*******************************************************************************
**                                                                            **
** FUNC-NAME     :                                                            **
**                                                                            **
** DESCRIPTION   :                                                            **
**                                                                            **
** PRECONDITIONS :                                                            **
**                                                                            **
** PARAMETER     :                                                            **
**                                                                            **
** RETURN        :                                                            **
**                                                                            **
** REMARKS       :                                                            **
**                                                                            **
*******************************************************************************/
#if (HOOK_STARTUPHOOK == ENABLE)
void StartupHook(void)
{
	/* Start the necessary non autostart alarms                              */
	/* Alarm ID, Initial Offset, Cyclic Period                               */
	//SetRelAlarm(!!! YOU HAVE TO START THE NON AUTOSTART ALARMS HERE !!! );
	
	return;
}
#endif
/*******************************************************************************
**                                                                            **
** FUNC-NAME     :                                                            **
**                                                                            **
** DESCRIPTION   :                                                            **
**                                                                            **
** PRECONDITIONS :                                                            **
**                                                                            **
** PARAMETER     :                                                            **
**                                                                            **
** RETURN        :                                                            **
**                                                                            **
** REMARKS       :                                                            **
**                                                                            **
*******************************************************************************/
void Dispatch(void)
{
	register int i;
	//update the stack pointer for the task
	TasksVar[GetRunningTask()].pTopOfStack = pRunningTask;
	for(i=0; i<COOUNTERS_FOR_TIMER_A; i++)
	{
		(void)IAdvanceCounter(Timer_A_Counters[i]);	
	}
	if(TasksConst[GetRunningTask()].ConstFlags.Preemtive)
	{
		Schedule();
	}
}

void TerminateTsk(void)
{
	LOAD_SYSTEM_CONTEXT();
	CreatTask(GetRunningTask());
	TerminateTask();
	RESTORE_CONTEXT();
}
