#ifndef _COMMON_
#define _COMMON_
#include "BasicTypes.h"
#include "OS_Cfg.h"
#include "OS_arch.h"
extern uint8 SuspendOSInterrupts_Counter;

extern uint8 DisableAllInterrupts_Counter;

extern uint8 SuspendAllInterrupts_Counter;
extern pStackPtr volatile pRunningTask ;
typedef void (*pTASK_CODE)( void * );
/*

*/
#define END_OF_LIST ((TaskType)~0)
/** \brief Type definition of AppModeType
 **
 ** This type is used to represent an Application Mode
 **/
typedef unsigned char AppModeType;
/** \brief Type definition of AlarmType
 **
 ** This type is used to represent references to Alarms
 **/
typedef unsigned char AlarmType;
/** \brief Type definition of TickType
 **
 ** This type is used to represent references to Ticks
 **/
typedef unsigned int TickType;
/** \brief Type definition of AlarmBaseType
 **
 ** This type is used to represent references to AlarmBase
 **/
typedef struct {
	TickType maxallowedvalue;
	TickType ticksperbase;
	TickType mincycle;
} AlarmBaseType;
/** \brief Type definition of AlarmBaseRefType
 **
 ** This type is used to represent references to AlarmBase
 **/
typedef AlarmBaseType* AlarmBaseRefType;
/** \brief Type definition of TickRefType
 **
 ** This type is used to represent references to TickType
 **/
typedef TickType* TickRefType;
/** \brief Alarm State
 **
 ** This type defines the possibly states of one alarm which are:
 ** 0 disable
 ** 1 enable
 **/
typedef uint8 AlarmStateType;

/** \brief Alarm Time */
typedef uint32 AlarmTimeType;

/** \brief Alarm Cycle Time */
typedef uint32 AlarmCycleTimeType;

/** \brief Counter Type */
typedef uint8 CounterType;

/** \brief Counter Increment Type */
typedef uint32f CounterIncrementType;

/** \brief Alarm Increment Type */
typedef uint32f AlarmIncrementType;

/** \brief Alarm Action Type */
typedef enum {
	ALARMCALLBACK = 0,
	SETEVENT = 1,
	ACTIVATETASK = 2,
	INCREMENT = 3
} AlarmActionType;
/**************************************************************************
 *                                Context                                 *
 **************************************************************************/
/** \brief ContextType
 **
 ** Type used to represent the actual context
 **/
typedef uint8 ContextType;
/* \brief Invalid Context */
#define CONTEXT_INVALID ((ContextType)0U)
/** \brief Task Context */
#define CONTEXT_TASK ((ContextType)1U)
/** \brief ISR Category 1 Context */
#define CONTEXT_ISR1 ((ContextType)2U)
/** \brief ISR Category 2 Context */
#define CONTEXT_ISR2 ((ContextType)3U)
/** \brief SYS Context */
#define CONTEXT_SYS	((ContextType)4U)
/** \brief DBG Context */
#define CONTEXT_DBG	((ContextType)5U)
extern ContextType ActualContext;
#define GetCallingContext()   (ActualContext)
/** \brief Set Context
 **
 ** Set the context
 **
 ** \param[in] newcontext valid values are:
 **               - CONTEXT_INVALID
 **               - CONTEXT_TASK
 **               - CONTEXT_ISR1
 **               - CONTEXT_ISR2
 **/
#define SetActualContext(newcontext)   \
	{												\
		ActualContext = (newcontext);		\
	}
#define GetCallingContext()   (ActualContext)
/**************************************************************************
 *                                Events                                  *
 **************************************************************************/
/** \brief Type definition of Event Mask
 **
 ** This type is used to represent Events
 **/
typedef unsigned int EventMaskType;

/** \brief Type definition of EventMaskRefType
 **
 ** This type is used to represent references to Events
 **/
typedef EventMaskType* EventMaskRefType;
/**************************************************************************
 *                                TASKs                                   *
 **************************************************************************/
#define INVALID_TASK  ((TaskType)~0)

/** \brief SUSPEND Task State */
#define SUSPENDED 0U
/** \brief READY Task State */
#define READY 1U
/** \brief RUNNING Task State */
#define RUNNING 2U
/** \brief WAITING Task State */
#define WAITING 3U
/** \brief INVALID Task State */
#define INVALID_STATE 4U
typedef unsigned char TaskPriorityType;

typedef struct {
   unsigned int Extended : 1;
   unsigned int Preemtive : 1;
   unsigned int State : 2;
} TaskFlagsType;
/** \brief Type definition of TaskType
 **
 ** This type is used to represent the Task IDs
 **/
typedef uint8 TaskType;
typedef uint8 TaskActivationsType;

typedef uint32 TaskEventsType;

typedef uint32 TaskResourcesType;

typedef uint16* StackPtrType;

typedef uint16f StackSizeType;

typedef void (* EntryPointType)(void);



typedef uint8 TaskTotalType;
/** \brief Type definition of TaskStateType
 **
 ** This type is used to represent the State of a Task
 **/
typedef unsigned char TaskStateType;

/** \brief Type definition of TaskStateRefType
 **
 ** This type is used to represent a pointer to a TaskStateType
 **/
typedef TaskStateType* TaskStateRefType;

/** \brief InterruptType Type definition */
typedef void (*InterruptType)(void);
/** \brief Type definition of TaskRefType
 **
 ** This type is used to represent a pointer to a Task ID Type
 **/
typedef TaskType* TaskRefType;
typedef const  TaskType* const TaskRefConstType;
extern TaskType RunningTask;
#define GetRunningTask()   (RunningTask)
#define SetRunningTask(newtask)  (RunningTask = (newtask) )
/**************************************************************************
 *                                ReadyList                               *
 **************************************************************************/
/** \brief Ready List Constatn Type
 **
 ** \param ListLength Lenght of the Ready List
 ** \param TaskRef Reference to the Ready Array for this Priority
 **/
typedef struct {
	TaskTotalType ListLength;
	TaskRefType TaskRef;
} ReadyConstType;

/** \brief Ready List Variable Type
 **
 ** \param ListStart first valid componet on the list
 ** \param ListCount count of valid components on this list
 **/
typedef struct {
	TaskTotalType ListStart;
	TaskTotalType ListCount;
} ReadyVarType;
StatusType Schedule
(
	void
);
StatusType TerminateTask
(
	void
);
void ShutdownOS
(
	StatusType Error
);
/** \brief Set the entry point for a task */
#define SetEntryPoint(task)							\
	{															\
		/* init entry point */							\
		TasksConst[task].TaskContext->reg_r15 = 	\
			(uint32) TasksConst[task].EntryPoint;	\
	}
#define ReleaseInternalResources()							\
	{																	\
		/* set the priority to the normal value */		\
		TasksVar[GetRunningTask()].ActualPriority =		\
		TasksConst[GetRunningTask()].StaticPriority;		\
	}
/**************************************************************************
 *                                Counter                                 *
 **************************************************************************/
#define GetCounter(CounterID) GetCounter_Arch(CounterID)

#endif /* Common */
