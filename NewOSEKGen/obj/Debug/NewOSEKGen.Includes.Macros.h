#ifndef MACROS_H_
#define MACROS_H_
#define TRIM_STACK(a) a=(pStackPtr)(a - (pStackPtr)0x24)
#define StartIdle()\
	asm("          MOV AL, @_pRunningTask");\
	asm("          MOV SP,AL");\
	asm("          IRET");
	
	
#define RESTORE_CONTEXT()\
    asm("          MOV32      R7H, *--SP, UNCF");\
    asm("          MOV32      R6H, *--SP, UNCF");\
    asm("          MOV32      R5H, *--SP, UNCF");\
    asm("          MOV32      R4H, *--SP, UNCF");\
    asm("          MOV32      R3H, *--SP, UNCF");\
    asm("          MOV32      R2H, *--SP, UNCF");\
    asm("          MOV32      R1H, *--SP, UNCF");\
    asm("          MOV32      R0H, *--SP, UNCF");\
    asm("          MOV32      STF, *--SP");\
    asm("          MOVL       XAR7,*--SP");\
    asm("          MOVL       XAR6,*--SP");\
    asm("          MOVL       XAR5,*--SP");\
    asm("          MOVL       XAR4,*--SP");\
    asm("          MOVL       XAR3,*--SP");\
    asm("          MOVL       XAR2,*--SP");\
    asm("          MOVL       XT,*--SP");\ 
    asm("          POP        AR1H:AR0H");\
    asm("          POP        RB");\
    asm("          NASP");\
    asm("          IRET");
    
    
    #define LOAD_SYSTEM_CONTEXT()\
    asm("          MOV AL, #_SystemStack");\
    asm("          MOV SP,AL");
#endif /*MACROS_H_*/
