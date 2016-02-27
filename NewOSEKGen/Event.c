
#include "task.h"
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
StatusType ClearEvent
(
	EventMaskType Mask
)
{
	/* \req OSEK_SYS_3.16 The system service StatusType
	 * ClearEvent ( EventMaskType Mask ) shall be defined */

	/* \req OSEK_SYS_3.16.2 Possible return values in Standard mode is E_OK */
	StatusType ret = E_OK;

#if (ERROR_CHECKING_TYPE == ERROR_CHECKING_EXTENDED)
	if ( !TasksConst[GetRunningTask()].ConstFlags.Extended )
	{
		/* \req OSEK_SYS_3.16.3-1/2 Extra possible return values in Extended
		 * mode are E_OS_ACCESS, E_OS_CALLEVEL */
		ret = E_OS_ACCESS;
	}
	else if ( GetCallingContext() != CONTEXT_TASK )
	{
		/* \req OSEK_SYS_3.16.3-2/2 Extra possible return values in Extended
		 * mode are E_OS_ACCESS, E_OS_CALLEVEL */
		ret = E_OS_CALLEVEL;
	}
	else
#endif
	{
		/* enter to critical code */
		IntSecure_Start();

		/* \req OSEK_SYS_3.16.1 The events of the extended task calling ClearEvent
		 * are cleared according to the event mask Mask */
		TasksVar[GetRunningTask()].Events &=
			(EventMaskType)~( Mask & TasksConst[GetRunningTask()].EventsMask );

		/* finish cirtical code */
		IntSecure_End();

	}

#if ( (ERROR_CHECKING_TYPE == ERROR_CHECKING_EXTENDED) && \
		(HOOK_ERRORHOOK == ENABLE) )
	/* \req OSEK_ERR_1.3-9/xx The ErrorHook hook routine shall be called if a
	 * system service returns a StatusType value not equal to E_OK.*/
	/* \req OSEK_ERR_1.3.1-9/xx The hook routine ErrorHook is not called if a
	 * system service is called from the ErrorHook itself. */
   if ( ( ret != E_OK ) && (ErrorHookRunning != 1))
	{
		SetError_Api(OSServiceId_ClearEvent);
		SetError_Param1(Mask);
		SetError_Ret(ret);
		SetError_Msg("ClearEvent returns != than E_OK");
		SetError_ErrorHook();
	}
#endif

	return ret;
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
StatusType GetEvent
(
	TaskType TaskID,
	EventMaskRefType Event
)
{
	/* \req OSEK_SYS_3.17 The system service StatusType
	 ** GetEvent ( TaskType TaskID, EventMaskRefType Event ) shall be defined*/

	/* \req OSEK_SYS_3.17.3 Possible return values in Standard mode is E_OK */
	StatusType ret = E_OK;

#if (ERROR_CHECKING_TYPE == ERROR_CHECKING_EXTENDED)
	if ( TaskID >= TASKS_COUNT )
	{
		/* \req OSEK_SYS_3.17.4-1/3 Extra possible return values in Extended mode are
		 ** E_OS_ID, E_OS_ACCESS, E_OS_STATE */
		ret = E_OS_ID;
	}
	else if ( !TasksConst[TaskID].ConstFlags.Extended )
	{
		/* \req OSEK_SYS_3.17.4-2/3 Extra possible return values in Extended mode are
		 ** E_OS_ID, E_OS_ACCESS, E_OS_STATE */
		ret = E_OS_ACCESS;
	}
	else if ( TasksVar[TaskID].Flags.State == TASK_ST_SUSPENDED )
	{
		/* \req OSEK_SYS_3.17.4-3/3 Extra possible return values in Extended mode are
		 ** E_OS_ID, E_OS_ACCESS, E_OS_STATE */
		ret = E_OS_STATE;
	}
	else
#endif
	{
		/* \req OSEK_SYS_3.17.1 This service shall return the current state of
		 ** all event bits of the task TaskID, not the events that the task is
		 ** waiting for */
		/* \req OSEK_SYS_3.17.2 The current status of the event mask of task
		 ** TaskID shall be copied to Event */
		*Event = TasksVar[TaskID].Events;
	}

#if ( (ERROR_CHECKING_TYPE == ERROR_CHECKING_EXTENDED) && \
		(HOOK_ERRORHOOK == ENABLE) )
	/* \req OSEK_ERR_1.3-10/xx The ErrorHook hook routine shall be called if a
	 ** system service returns a StatusType value not equal to E_OK.*/
	/* \req OSEK_ERR_1.3.1-10/xx The hook routine ErrorHook is not called if a
	 ** system service is called from the ErrorHook itself. */
   if ( ( ret != E_OK ) && (ErrorHookRunning != 1))
	{
		SetError_Api(OSServiceId_SetEvent);
		SetError_Param1(TaskID);
		SetError_Param2(Event);
		SetError_Ret(ret);
		SetError_Msg("ActivateTask returns != than E_OK");
		SetError_ErrorHook();
	}
#endif

	return ret;
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

StatusType OS_SetEvent
(
	TaskType TaskID,
	EventMaskType Mask
)
{
	/* \req OSEK_SYS_3.15 The system service StatusType
	 * SetEvent ( TaskType TaskID, EventMaskType Mask ) shall be defined */

	/* \req OSEK_SYS_3.15.2: Possible return values in Standard mode is E_OK */
	StatusType ret = E_OK;

#if (ERROR_CHECKING_TYPE == ERROR_CHECKING_EXTENDED)
	if ( TaskID >= TASKS_COUNT )
	{
		/* \req OSEK_SYS_3.15.3-1/3 Extra possible return values in Extended mode
		 * are E_OS_ID, E_OS_ACCESS, E_OS_STATE */
		ret = E_OS_ID;
	}
	else if ( !TasksConst[TaskID].ConstFlags.Extended )
	{
		/* \req OSEK_SYS_3.15.3-2/3 Extra possible return values in Extended mode
		 * are E_OS_ID, E_OS_ACCESS, E_OS_STATE */
		ret = E_OS_ACCESS;
	}
	else if ( TasksVar[TaskID].Flags.State == TASK_ST_SUSPENDED )
	{
		/* \req OSEK_SYS_3.15.3-3/3 Extra possible return values in Extended mode
		 * are E_OS_ID, E_OS_ACCESS, E_OS_STATE */
		ret = E_OS_STATE;
	}
	else
#endif
	{
		/* enter to critical code */
		IntSecure_Start();

		/* the event shall be set only if the task is running ready or waiting */
		if ( 	( TasksVar[TaskID].Flags.State == RUNNING ) ||
				( TasksVar[TaskID].Flags.State == READY ) ||
				( TasksVar[TaskID].Flags.State == WAITING) )
		{
			/* set the events */
			/* \req OSEK_SYS_3.15.1-1/3 The events of task TaskID are set according to the
			 * event mask Mask. Calling SetEvent causes the task TaskID to be
			 * transferred to the ready state, if it was waiting for at least one
			 * of the events specified in Mask */
			TasksVar[TaskID].Events |= ( Mask & TasksConst[TaskID].EventsMask );

			/* if the task is waiting and one waiting event occurrs set it to ready */
			if (	( TasksVar[TaskID].Flags.State == WAITING ) &&
					( TasksVar[TaskID].EventsWait & TasksVar[TaskID].Events ) )
			{
				/* \req OSEK_SYS_3.15.1-2/3 The events of task TaskID are set according to the
				 * event mask Mask. Calling SetEvent causes the task TaskID to be
				 * transferred to the ready state, if it was waiting for at least one
				 * of the events specified in Mask */
				AddReady(TaskID);

				/* \req OSEK_SYS_3.15.1-3/3 The events of task TaskID are set according to the
				 * event mask Mask. Calling SetEvent causes the task TaskID to be
				 * transferred to the ready state, if it was waiting for at least one
				 * of the events specified in Mask */
				TasksVar[TaskID].Flags.State = READY;

				IntSecure_End();

#if (NON_PREEMPTIVE == DISABLE)
				/* check if called from a Task Context */
				if ( GetCallingContext() ==  CONTEXT_TASK )
				{
					if ( ( TasksConst[GetRunningTask()].ConstFlags.Preemtive ) &&
						  ( ret == E_OK )	)
					{
						/* \req OSEK_SYS_3.15.4 Rescheduling shall take place only if called from a
						 * preemptable task. */
						(void)Schedule();
					}
				}
#endif /* #if (NON_PREEMPTIVE == DISABLE) */

			}
			else
			{
				IntSecure_End();
			}
		}
		else
		{
			IntSecure_End();
		}
	}
	return ret;
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

StatusType OS_WaitEvent
(
	EventMaskType Mask
)
{
	/* \req OSEK_SYS_3.18: The system service StatusType
	  * WaitEvent ( EventMaskType Mask ) shall be defined */

	volatile uint8	flag = 1;

	/* \req OSEK_SYS_3.18.3 Possible return values in Standard mode is E_OK */
	StatusType ret = E_OK;

#if (ERROR_CHECKING_TYPE == ERROR_CHECKING_EXTENDED)
	if ( !TasksConst[GetRunningTask()].ConstFlags.Extended )
	{
		/* \req OSEK_SYS_3.18.4-1/3 Extra possible return values in Extended mode
		  * are E_OS_ACCESS, E_OS_RESOURCE, E_OS_CALLEVEL */
		ret = E_OS_ACCESS;
	}
	else if ( GetCallingContext() != CONTEXT_TASK )
	{
		/* \req OSEK_SYS_3.18.4-2/3 Extra possible return values in Extended mode
		  * are E_OS_ACCESS, E_OS_RESOURCE, E_OS_CALLEVEL */
		ret = E_OS_CALLEVEL;
	}
	else if ( TasksVar[GetRunningTask()].Resources != 0 )
	{
		/* \req OSEK_SYS_3.18.4-3/3 Extra possible return values in Extended mode
		  * are E_OS_ACCESS, E_OS_RESOURCE, E_OS_CALLEVEL */
		ret = E_OS_RESOURCE;
	}
	else
#endif
	{
		/* enter to critical code */
		IntSecure_Start();

		if ( Mask & TasksVar[GetRunningTask()].Events )
		{
			/* finish cirtical code */
	      IntSecure_End();
		}
		else
		{
			/* \req OSEK_SYS_3.18.1 The state of the calling task is set to waiting,
			  * unless at least one of the events specified in Mask has already been
			  * set */
			TasksVar[GetRunningTask()].Flags.State = WAITING;

			/* set wait mask */
			TasksVar[GetRunningTask()].EventsWait = Mask;

			/* save actual task context */
//			SaveContext(GetRunningTask()); Kristian TODO:

			if (flag)
			{

				/* execute this code only ones */
				flag = 0;

				/* remove of the Ready List */
				RemoveTask(GetRunningTask());

				/* set running task to invalid */
         	SetRunningTask(INVALID_TASK);

				/* finish cirtical code */
		      IntSecure_End();

				/* OSEK_SYS_3.18.2 This call enforces rescheduling, if the wait
				  * condition occurs. If rescheduling takes place, the internal
				  * resource of the task is released while the task is in the
				  * waiting state */
				(void)Schedule();
			}
			else
			{
				/* finish critical code */
				IntSecure_End();
			}
		}
	}

#if ( (ERROR_CHECKING_TYPE == ERROR_CHECKING_EXTENDED) && \
      (HOOK_ERRORHOOK == ENABLE) )
	/* \req OSEK_ERR_1.3-11/xx The ErrorHook hook routine shall be called if a
	  * system service returns a StatusType value not equal to E_OK.*/
	/* \req OSEK_ERR_1.3.1-11/xx The hook routine ErrorHook is not called if a
	  * system service is called from the ErrorHook itself. */
	if ( ( ret != E_OK ) && (ErrorHookRunning != 1))
	{
		SetError_Api(OSServiceId_WaitEvent);
		SetError_Param1(Mask);
		SetError_Ret(ret);
		SetError_Msg("ActivateTask returns != than E_OK");
		SetError_ErrorHook();
	}
#endif

	return ret;
}



/** @} doxygen end group definition */
/** @} doxygen end group definition */
/*==================[end of file]============================================*/

