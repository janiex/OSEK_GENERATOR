#ifndef ALARM_H_
#define ALARM_H_
#include "OS_Types.h"
typedef struct {
	CallbackType CallbackFunction;
	TaskType TaskID;
#if(0 != EVENT_ENABLED)
    EventMaskType Event;
#endif
	CounterType Counter;
} AlarmActionInfoType;

/** \brief Alarm Variable Type */
typedef struct {
	AlarmStateType AlarmState;
	AlarmTimeType AlarmTime;
	AlarmCycleTimeType AlarmCycleTime;
} AlarmVarType;

/** \brief Alarm Constant Type */
typedef struct {
	CounterType Counter;
	AlarmActionType AlarmAction;
	AlarmActionInfoType AlarmActionInfo;
} AlarmConstType;

/** \brief Auto Start Alarm Type */
typedef struct {
	AppModeType Mode;
	AlarmType Alarm;
	AlarmTimeType AlarmTime;
	AlarmCycleTimeType AlarmCycleTime;
} AutoStartAlarmType;
/************************************************************************************
 *                                 EXPORTED FUNCTION                                *
 ************************************************************************************/
extern AlarmVarType AlarmsVar[];
extern const AlarmConstType AlarmsConst[];
extern AlarmIncrementType IncrementAlarm(AlarmType AlarmID, AlarmIncrementType Increment);
extern StatusType SetRelAlarm
(
	AlarmType AlarmID,
	TickType Increment,
	TickType Cycle
);
extern StatusType CancelAlarm
(
	AlarmType AlarmID
);
extern StatusType GetAlarm
(
	AlarmType AlarmID,
	TickRefType Tick
);
extern StatusType SetAbsAlarm
(
	AlarmType AlarmID,
	TickType Start,
	TickType Cycle
);
#endif /*ALARM_H_*/
