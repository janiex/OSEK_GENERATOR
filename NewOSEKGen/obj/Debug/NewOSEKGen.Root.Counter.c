#include "OS_Types.h"
#include "Counter.h"
#include "Alarm.h"

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
#if (ALARMS_COUNT != 0)
CounterIncrementType IncrementCounter(CounterType CounterID, CounterIncrementType Increment)
{
	BYTE loopi;
	AlarmType AlarmID;
	AlarmIncrementType MinimalCount = -1;
	AlarmIncrementType TmpCount;

	/* increment counter */
	CountersVar[CounterID].Time+=Increment;

	/* check if the timer has an overvlow */
	while ( CountersVar[CounterID].Time >= CountersConst[CounterID].MaxAllowedValue )
	{
		/* reset counter */
		CountersVar[CounterID].Time -= CountersConst[CounterID].MaxAllowedValue;
	}

	/* for alarms on this counter */
	for(loopi = 0; loopi < CountersConst[CounterID].AlarmsCount; loopi++)
	{
		/* get alarm id */
		AlarmID = CountersConst[CounterID].AlarmRef[loopi];

		/* check if the alarm is eanble */
		if (AlarmsVar[AlarmID].AlarmState == 1)
		{
			/* increment alarm and get the next alarm time */
			TmpCount = IncrementAlarm(AlarmID, Increment);

			/* if the actual count is smaller */
			if (MinimalCount > TmpCount)
			{
				/* set it as minimal count */
				MinimalCount = TmpCount;
			}
		}
	}

	/* return the minimal increment */
	return (CounterIncrementType)MinimalCount;
}
#endif /* #if (ALARMS_COUNT != 0) */
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
StatusType IAdvanceCounter(CounterType CounterID)
{
    // 1. Check if the call is from ISR or system context
    // GetCallingContext()
    // 2. Check if the interrupts are enabled - they have to be disabled
    // 3. Check if the referenced counter is valid
    // 4. -> Then OK - increment the counter by one, becasue this is the system quant
    (void)IncrementCounter(CounterID, 1); // We don't care about the return value,since it could be

    // zero, when increment just by one
	return E_OK;
}

