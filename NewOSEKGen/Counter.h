#ifndef _COUNTER_
#define _COUNTER_
#include "common.h"
/************************************************************************************
 *                                 COUNTER TYPES                                    *
 ************************************************************************************/
typedef struct {
	uint8	AlarmsCount;
	AlarmType* AlarmRef;
	TickType MaxAllowedValue;
	TickType MinCycle;
	TickType TicksPerBase;
} CounterConstType;

typedef struct {
	TickType Time;
}CounterVarType;
#endif /* _COUNTER_ */
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
