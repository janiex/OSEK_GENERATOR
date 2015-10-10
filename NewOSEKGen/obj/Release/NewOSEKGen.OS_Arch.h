#ifndef _OS_ARCH_
#define _OS_ARCH_
#include "BasicTypes.h"
#define INSTRUCTION_SIZE 			((uint32)4)
#define ARM_INITIAL_SPSR            ((uint32) 0x1f)
typedef uint16 *pStackPtr;
#define setcontext(cntx)
#define savecontext(cntx)

extern void InitHW(void);
/** \brief Call to an other Task
 **
 ** This function jmps to the indicated task.
 **/
#define CallTask(a, b)	
#define GetCounter_Arch(CounterID) (CountersVar[CounterID].Time)
#define EnableInterrupts()
#define DisableInterrupts()	


#define SuspendAllInterrupts_Arch()	 	DisableInterrupts()
#define DisableAllInterrupts_Arch() 	SuspendAllInterrupts_Arch()
#define ResumeAllInterrupts_Arch()		EnableInterrupts()
#define EnableAllInterrupts_Arch()		EnableInterrupts()

	#define DisableAllInterrupts()			\
		{												\
			DisableAllInterrupts_Counter++;	\
			DisableAllInterrupts_Arch();		\
		}
#define EnableAllInterrupts()						\
	{														\
		DisableAllInterrupts_Counter--;			\
		if(DisableAllInterrupts_Counter <=		\
			((uint8)0U))			\
		{													\
			DisableAllInterrupts_Counter =		\
				((uint8)0U);		\
			EnableAllInterrupts_Arch();			\
		}													\
	}
	/** \brief Resume All Interrupts
	 **
	 ** This API resume all Interruptions suspended by the last call to
	 ** SuspendAllInterrupts.
	 **/
	/* \req OSEK_SYS_3.9 The system service void ResumeAllInterrupts ( void )
	 *  shall be defined
	 * \req OSEK_SYS_3.9.1 This service restores the recognition status of all
	 *  interrupts saved by the SuspendAllInterrupts service
	 * \req OSEK_SYS_3.9.2 SuspendAllInterrupts/ResumeAllInterrupts can be nested.
	 *  In case of nesting pairs of the calls SuspendAllInterrupts and
	 *  ResumeAllInterrupts the interrupt recognition status saved by the first
	 *  call of SuspendAllInterrupts is restored by the last call of the
	 *  ResumeAllInterrupts service.
	 **/
	#define ResumeAllInterrupts() 					\
		{														\
			SuspendAllInterrupts_Counter--;			\
			if(SuspendAllInterrupts_Counter <=		\
				((uint8)0U))			\
			{													\
				SuspendAllInterrupts_Counter =		\
					((uint8)0U);		\
				ResumeAllInterrupts_Arch();			\
			}													\
		}

	/** \brief Suspend All Interrupts
	 **
	 ** This API suspend all Interruptions and saves the interruptions state for
	 ** the EnableAllInterrupts API.
	 **/
	/* \req OSEK_SYS_3.10 The system service void SuspendAllInterrupts ( void )
	 *  shall be defined
	 * \req OSEK_SYS_3.10.1 This service shall save the recognition status of all
	 *  interrupts
	 * \req OSEK_SYS_3.10.2 and disables all interrupts for which the hardware
	 *  supports disabling
	 */
	#define SuspendAllInterrupts()					\
		{														\
			SuspendAllInterrupts_Counter++;			\
			SuspendAllInterrupts_Arch();				\
		}

	/** \brief Resume OS Interrupts
	 **
	 ** This service restores the recognition status of interrupts saved by the
	 ** SuspendOSInterrupts service.
	 **/
	/* \req OSEK_SYS_3.11 The system service void ResumeOSInterrupts ( void )
	 *  shall be defined
	 * \req OSEK_SYS_3.11.1 This service restores the recognition status of
	 *  interrupts saved by the SuspendOSInterrupts service
	 * \req OSEK_SYS_3.11.2 SuspendOSInterrupts/ResumeOSInterrupts can be nested.
	 *  In case of nesting pairs of the calls SuspendOSInterrupts and
	 *  ResumeOSInterrupts the interrupt recognition status saved by the first call
	 *  of SuspendOSInterrupts is restored by the last call of the
	 *  ResumeOSInterrupts service
	 */
	#define ResumeOSInterrupts()						\
		{														\
			SuspendOSInterrupts_Counter--;			\
			if(SuspendOSInterrupts_Counter <= 		\
				((uint8)0U))			\
			{													\
				SuspendOSInterrupts_Counter =			\
					((uint8)0U);		\
				ResumeOSInterrupts_Arch();				\
			}													\
		}

	/** \brief Suspend OS Interrupts
	 **
	 ** SuspendOSInterrupts/ResumeOSInterrupts can be nested. In case of nesting pairs of
	 ** the calls SuspendOSInterrupts and ResumeOSInterrupts the interrupt recognition
	 ** status saved by the first call of SuspendOSInterrupts is restored by the last
	 ** call of the ResumeOSInterrupts service.
	 **/
	/* \req OSEK_SYS_3.12 The system service void SuspendOSInterrupts ( void )
	 *  shall be defined
	 * \req OSEK_SYS_3.12.1 This service shall save the recognition status of
	 *  interrupts of category 2
	 * \req OSEK_SYS_3.12.2 and disables the recognition of these interrupts
	 */
	#define SuspendOSInterrupts()						\
		{														\
			SuspendOSInterrupts_Counter++;			\
			SuspendOSInterrupts_Arch();				\
		}

#endif /* #define _OS_ARCH_ */
