#ifndef INTERRUPTS_H_
#define INTERRUPTS_H_
#include "os_arch.h"
#include "basictypes.h"
#include "common.h"
extern pStackPtr volatile pRunningTask;
extern volatile uint16 SystemStack[SystemStackSize];
extern StatusType IAdvanceCounter(CounterType CounterID);
void Dispatch(void);
#endif /*INTERRUPTS_H_*/
