/*----------------------------------------------------------------------------*/
/* a hook for HW initialization                                               */
#define SetupHardware()		InitHW()
/* a hook for timer providing the system time tick initialization             */
#define SetupTimerInterrupt()
#define LOAD_SYSTEM_CONTEXT()								   \
						asm(" mov.w #SystemStack,R12");\
						asm(" add.w #(254), R12");     \
						asm(" mov.w R12,SP");
#define RESTORE_CONTEXT()                              \
						asm(" mov.w	 &pRunningTask,R12"); \
						asm(" mov.w R12, SP");            \
						asm(" popm.w #12,R15");           \
						asm(" reti");	




