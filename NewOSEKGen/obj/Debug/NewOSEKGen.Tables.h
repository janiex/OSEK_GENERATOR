#ifndef _TABLES_
#define _TABLES_
#include "Counter.h"
#include "OS_Cfg.h"
#include "Alarm.h"
#include "Task.h"
extern void Task1(void);
extern void Task2(void);
extern void Task3(void);
extern void Idle(void);
uint16 TaskStack1[StackSizeTask1];
uint16 TaskStack2[StackSizeTask2];
uint16 TaskStack3[StackSizeTask3];
uint16 TaskIdleStack[64];
volatile uint16 SystemStack[SystemStackSize];

#define NOT_IMPLEMENTED 0

AppModeType ApplicationMode;
/******************************************************************************
 *                         COUNTERS DATA                                                 *
 ******************************************************************************/
// CounterName##_LIST
const AlarmType SystemCounter_LIST[COUNTER_1_ALARMS_COUNT] =
{
	/* these alarms have to be incremented with this counter                  */
	ALARM10MS,
	ALARM5MS, 
	ALARM50MS 
};
CounterVarType CountersVar[COUNTER_COUNT];
// TODO: Kristian - define const struct content.
const CounterConstType CountersConst[COUNTER_COUNT] =
{
    {
    ALARMS_COUNT, /* number of alarms */
    (AlarmType*)SystemCounter_LIST,
    100000, /* max allowed value */
	1, /* min cycle */
    1000 /* ticks per base */
    }
};


/*****************************************************************************************
 *                         ALARMS DATA                                                   *
 *****************************************************************************************/
AlarmVarType AlarmsVar[COUNTER_1_ALARMS_COUNT]=
{
	{
		0,
		0,
		0
	},
	{
		0,
		0,
		0
	},{
		0,
		0,
		0
	}
};

const AlarmConstType AlarmsConst[COUNTER_1_ALARMS_COUNT] = {
	{
		SystemCounter, /* Associated Counter */
		ACTIVATETASK, /* Alarm action */
		{
			(CallbackType )NULL, /* no callback */

		    Task_10ms, /* no task id */
#if(0 != EVENT_ENABLED)
			0, /* no event */
#endif
			0 /* counter to increment if such,none */
		},
	},
	{
		SystemCounter, /* Counter */
		ACTIVATETASK, /* Alarm action */
		{
			(CallbackType )NULL, /* no callback */

			Task_5ms, /* TaskID */
#if(0 != EVENT_ENABLED)
			0, /* no event */
#endif

			0 /* counter to increment if such,none */
		},
	},
	{
			SystemCounter, /* Counter */
			ACTIVATETASK, /* Alarm action */
			{
				(CallbackType )NULL, /* no callback */

				Task_50ms, /* TaskID */
	#if(0 != EVENT_ENABLED)
				0, /* no event */
	#endif

				0 /* counter to increment if such,none */
			},
		}
};
/*****************************************************************************************
 *                         TASKS  DATA                                                   *
 *****************************************************************************************/
/** \brief InitTask context */


const TaskConstType TasksConst[TASKS_COUNT] = {
	/* Task Task1 */
	{
 		Task1,	/* task entry point */
		(StackPtrType )&TaskStack1,  /* pointer stack memory */
		StackSizeTask1, /* stack size */
		3, /* task priority */
		1, /* task max activations */
		{
			0, /* extended task */
			0, /* 0 - non preemptive; 1 - preemptive task */
			0
		}, /* task const flags */
		0 , /* events mask */
		0 /* resources mask */
	},
    /* Task Task2 */
	{
 		Task2,	/* task entry point */
		(StackPtrType )&TaskStack2, /* pointer stack memory */
		StackSizeTask2, /* stack size */
		2, /* task priority */
		1, /* task max activations */
		{
			0, /* extended task */
			0, /* non preemtive task */
			0
		}, /* task const flags */
		0 , /* events mask */
		0 /* resources mask */
	},
	/* Task Task3 */
		{
	 		Task3,	/* task entry point */
			(StackPtrType )&TaskStack3, /* pointer stack memory */
			StackSizeTask3, /* stack size */
			1, /* task priority */
			1, /* task max activations */
			{
				0, /* extended task */
				1, /* non preemtive task */
				0
			}, /* task const flags */
			0 , /* events mask */
			0 /* resources mask */
		},
	/* Task Idle */
		{
			Idle,	/* task entry point */
			(StackPtrType)&TaskIdleStack,/* pointer stack memory */
			64, /* stack size */
			0, /* task priority */
			1, /* task max activations */
			{
				0, /* extended task */
				1, /* non preemtive task */
				0
			}, /* task const flags */
			0 , /* events mask */
			0 /* resources mask */
		}
};
/* This is the task control block                                         */
TaskVariableType TasksVar[TASKS_COUNT];
TaskType ReadyList3[1];
/** \brief Ready List for Priority Idle */

TaskType ReadyList2[1];
/** \brief Ready List for Priority 1 */

TaskType ReadyList1[1];

/** \brief Ready List for Priority 0 */
TaskType ReadyList0[1];
/** TODO replace next line with:
 ** ReadyVarType ReadyVar[3]  ATTRIBUTES(); */
ReadyVarType ReadyVar[TASKS_COUNT]=
{
	{
		0,
		0
	},
	{
		0,
		0
	},
	{
		0,
		0
	},
	{
		0,
		0
	},
};
const ReadyConstType ReadyConst[TASKS_COUNT] = {

	{
		1, /* Length of this ready list */
		ReadyList3 /* Pointer to the Ready List */
	},
	{
		1, /* Length of this ready list */
		ReadyList2 /* Pointer to the Ready List */
	},
	{
		1, /* Length of this ready list */
		ReadyList1 /* Pointer to the Ready List */
	},
	{
		1, /* Length of this ready list */
		ReadyList0 /* Pointer to the Ready List */
	}
};
/*****************************************************************************************
 *                         AUTOSTART Objects                                             *
 *****************************************************************************************/

 /* List of Auto Start Tasks in Application Mode AppMode1 */

/* AutoStart Array */
const AutoStartType AutoStart[1]  = {
	/* Application Mode AppMode1 */
	{
		0, /* Total Auto Start Tasks in this Application Mode */
		//(TaskRefType)TasksAppModeAppMode1 /* Pointer to the list of Auto Start Stacks on this Application Mode */
		NOT_IMPLEMENTED
	}
};

const AutoStartAlarmType AutoStartAlarm[1] = {
  {
		0, /* Application Mode */
		255, /* Alarms */
		1, /* Alarm Time */
		1 /* Alarm Time */
	}
};

#endif /* _TABLES_ */
