#ifndef STD_TYPES_
#define STD_TYPES_

/**********************************************************************************************************************
 * INCLUDES
 *********************************************************************************************************************/

# include "Platform_Types.h"
# include "Compiler.h"
/**********************************************************************************************************************
 * STANDARD CONSTANTS
 *********************************************************************************************************************/
# define STD_HIGH     ((uint8)1u) /* Physical state 5V or 3.3V */
# define STD_LOW      ((uint8)0u) /* Physical state 0V */

# define STD_ACTIVE   1u /* Logical state active */
# define STD_IDLE     0u /* Logical state idle */

# define STD_ON       1u
# define STD_OFF      0u

#ifdef _QAC_
#define STD_RET_TYPE_CAST (uint8)
#else
#define STD_RET_TYPE_CAST
#endif
/* This typedef has been added for OSEK compliance */
# ifndef STATUSTYPEDEFINED
#  define STATUSTYPEDEFINED
#  define E_OK      (STD_RET_TYPE_CAST 0u)
typedef unsigned char StatusType; /* OSEK compliance */
# endif

# define E_NOT_OK     	(STD_RET_TYPE_CAST 1u)
# define E_INVALIDARG 	(STD_RET_TYPE_CAST 2u)
# define E_FALSE      	(STD_RET_TYPE_CAST 3u)
# define E_PENDING    	(STD_RET_TYPE_CAST 4u)
# define E_POINTER    	(STD_RET_TYPE_CAST 5u)
# define NOT_IMPLEMENTED (STD_RET_TYPE_CAST 5u)

typedef uint16 Std_ReturnType;

#endif /*STD_TYPES_*/
