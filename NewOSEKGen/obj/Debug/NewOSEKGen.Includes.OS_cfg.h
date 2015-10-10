#ifndef _OS_CFG_
#define _OS_CFG_
#define DISABLE                         0
#define ENABLE                          1
/** \brief ERROR_CHECKING_STANDARD */
#define ERROR_CHECKING_STANDARD         1

/** \brief ERROR_CHECKING_EXTENDED */
#define ERROR_CHECKING_EXTENDED         2

#define COUNTER_COUNT                   {0}
#define ALARMS_COUNT                    {1}
#define {2}								{3}
#define SystemCounter                   {2}
#define COUNTER_1_ALARMS_COUNT          {4}

#define ALARM_AUTOSTART_COUNT			{5}
#define TASKS_COUNT                     {6}
#define READYLISTS_COUNT                TASKS_COUNT

#define TASKS_MAX_NUMBER				TASKS_COUNT

#define NO_EVENTS                       DISABLE
/* The hooks and function at user disposal */
#define ShutdownOs_Arch()
#define ShutdownHook()
#define EnableOSInterrupts()		_BIS_SR(GIE)
#define IntSecure_Start()
#define IntSecure_End()
#define HOOK_ERRORHOOK                  DISABLE
#define ERROR_CHECKING_TYPE             DISABLE
#define HOOK_STARTUPHOOK				ENABLE
#define SystemStackSize					(256)
#define UART_INTERFACE					ENABLE
#define APPLICATION_MODE				(1)

#define AUTOSTART_TASKS					0
#define AUTOSTART_ALARMS				0
