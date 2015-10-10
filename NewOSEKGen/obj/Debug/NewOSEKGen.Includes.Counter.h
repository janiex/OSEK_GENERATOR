#ifndef COUNTER_H_
#define COUNTER_H_
#include "OS_Types.h"
#include "OS_cfg.h"
#include "common.h"
/************************************************************************************
 *                                 COUNTER TYPES                                    *
 ************************************************************************************/
typedef struct {
	BYTE	AlarmsCount;
	AlarmType* AlarmRef;
	TickType MaxAllowedValue;
	TickType MinCycle;
	TickType TicksPerBase;
} CounterConstType;

typedef struct {
	TickType Time;
}CounterVarType;

/************************************************************************************
 *                                 EXPORTED DATA                                    *
 ************************************************************************************/
extern CounterVarType CountersVar[];
extern const CounterConstType CountersConst[];
/************************************************************************************
 *                                 EXPORTED FUNCTION                                *
 ************************************************************************************/
extern StatusType IAdvanceCounter(CounterType CounterID);
extern AlarmIncrementType IncrementAlarm(AlarmType AlarmID, AlarmIncrementType Increment);
extern CounterIncrementType IncrementCounter(CounterType CounterID, CounterIncrementType Increment);
extern const AlarmType COUNTER_1_LIST[];
extern CounterVarType CountersVar[];
extern const CounterConstType CountersConst[];
#endif /*COUNTER_H_*/
