#ifndef TASK_H_
#define TASK_H_
#include "OS_Types.h"
/** \brief Task Constant type definition
 **
 ** This structure defines all constants and constant pointers
 ** needed to manage a task
 **
 ** \param EntryPoint pointer to the entry point for this task
 ** \param Priority static priority of this task
 ** \param MaxActivations maximal activations for this task
 **/
typedef struct {
	EntryPointType          EntryPoint;	
	StackPtrType            StackPtr;
	StackSizeType           StackSize;
	TaskPriorityType        StaticPriority;
	TaskActivationsType     MaxActivations;
	TaskFlagsType           ConstFlags;
	TaskEventsType          EventsMask;
	TaskResourcesType       ResourcesMask;
} TaskConstType;
/** \brief Task Variable type definition
 **
 ** This structure defines all variables needed to manage a task
 **
 ** \param ActualPriority actual priority of this task
 ** \param Activations actual activations on this task
 ** \param Flags flags variable of this task
 ** \param Events of this task
 ** \param Resource of this task
 **/
typedef struct {
	pStackPtr			pTopOfStack;
	TaskPriorityType    ActualPriority;
	TaskActivationsType Activations;
	TaskFlagsType       Flags;
	TaskEventsType      Events;
	TaskEventsType      EventsWait;
	TaskResourcesType   Resources;
} TaskVariableType;

/** \brief Auto Start Structure Type
 **
 ** \param Total taks on this application mode
 ** \param Reference to the tasks on this Application Mode
 **/
typedef struct {
	const TaskTotalType TotalTasks;
	TaskRefConstType TasksRef;
} AutoStartType;

extern const TaskConstType TasksConst[];
extern TaskVariableType TasksVar[];
extern void AddReady(TaskType TaskID);

extern ReadyVarType ReadyVar[];
extern const ReadyConstType ReadyConst[];
extern StatusType ActivateTask(TaskType TaskID);
extern void RemoveTask(TaskType TaskID);
extern TaskType GetNextTask(void);
extern StatusType GetTaskID (TaskRefType TaskID);
extern StatusType TerminateTask(void);
#endif /*TASK_H_*/
