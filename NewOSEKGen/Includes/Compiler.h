#ifndef COMPLIER_H_
#define COMPLIER_H_
/**********************************************************************************************************************
 * INCLUDES
 *********************************************************************************************************************/

/* # include "Compiler_Cfg.h" */


/**********************************************************************************************************************
 *  GLOBAL CONSTANT MACROS
 *********************************************************************************************************************/
 /* NULL_PTR define with a void pointer to zero definition*/
# ifndef NULL_PTR
   #define NULL_PTR  ((void *)0)
# endif

/* NULL_PTR define with a void pointer to zero definition*/
# ifndef NULL
   #define NULL  ((void *)0)
# endif

#define ISR_NATIVE(x)     interrupt void  x(void)

#endif /*COMPLIER_H_*/
