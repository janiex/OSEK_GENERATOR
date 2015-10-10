#ifndef _BASIC_TYPES_
#define _BASIC_TYPES_
#define TRUE    (1==1)
#define FALSE   (!TRUE)
/** \brief Type definition of StatusType
 **
 ** This type is used to represent the status returned by all FreeOSEK APIs
 **/
/* \req OSEK_SYS_1.1 */
typedef unsigned char StatusType;
/** \brief Definition return value E_OK */
/* \req OSEK_SYS_1.1.1 */
#define E_OK					((StatusType)0U)
/** \brief Definition return value E_OS_ACCESS */
/* \req OSEK_SYS_1.1.1 */
#define E_OS_ACCESS			((StatusType)1U)
/** \brief Definition return value E_OS_CALLEVEL */
/* \req OSEK_SYS_1.1.1 */
#define E_OS_CALLEVEL		((StatusType)2U)
/** \brief Definition return value E_OS_ID */
/* \req OSEK_SYS_1.1.1 */
#define E_OS_ID				((StatusType)3U)
/** \brief Definition return value E_OS_LIMIT */
/* \req OSEK_SYS_1.1.1 */
#define E_OS_LIMIT			((StatusType)4U)
/** \brief Definition return value E_OS_NOFUNC */
/* \req OSEK_SYS_1.1.1 */
#define E_OS_NOFUNC			((StatusType)5U)
/** \brief Definition return value E_OS_RESOURCE */
/* \req OSEK_SYS_1.1.1 */
#define E_OS_RESOURCE		((StatusType)6U)
/** \brief Definition return value E_OS_STATE */
/* \req OSEK_SYS_1.1.1 */
#define E_OS_STATE			((StatusType)7U)
/** \brief Definition return value E_OS_VALUE */
/* \req OSEK_SYS_1.1.1 */
#define E_OS_VALUE			((StatusType)8U)
typedef void (* CallbackType)(void);
//#ifdef NULL
//#undef NULL
/** \brief NULL definition */
#ifndef NULL
#define NULL ((void *)0)
#endif
//#endif
    #ifndef TYPES_BOOLEAN
    /** \brief boolean type type definition */
    typedef unsigned char boolean;
    #endif
    
    #ifndef TYPES_UINT8
    #define TYPES_UINT8
    /** \brief default usigned 8 bits integer type definition */
    typedef unsigned char uint8;
    #endif

    #ifndef TYPES_SINT8
    #define TYPES_SINT8
    /** \brief default signed 8 bits integer type definition */
    typedef signed char sint8;
    #endif

    #ifndef TYPES_UINT8F
    #define TYPES_UINT8F
    /** \brief default unsigned 8 bits fast integer type definition */
    typedef unsigned int uint8f;
    #endif

    #ifndef TYPES_SINT8F
    #define TYPES_SINT8F
    /** \brief default signed 8 bits fast integer type definition */
    typedef signed int sint8f;
    #endif

    #ifndef TYPES_UINT16
    #define TYPES_UINT16
    /** \brief default unsigned 16 bits integer type definition */
    typedef unsigned short uint16;
    #endif

    #ifndef TYPES_SINT16
    #define TYPES_SINT16
    /** \brief default signed 16 bits integer type definition */
    typedef signed short sint16;
    #endif

    #ifndef TYPES_UINT16F
    #define TYPES_UINT16F
    /** \brief default unsigned 16 bits fast integer type definition */
    typedef unsigned int uint16f;
    #endif

    #ifndef TYPES_SINT16F
    #define TYPES_SINT16F
    /** \brief default signed 16 bits fast integer type definition */
    typedef signed int sint16f;
    #endif

    #ifndef TYPES_UINT32
    #define TYPES_UINT32
    /** \brief default unsigned 32 bits integer type definition */
    typedef unsigned long uint32;
    #endif

    #ifndef TYPES_SINT32
    #define TYPES_SINT32
    /** \brief default signed 32 bits integer type definition */
    typedef signed long sint32;
    #endif

    #ifndef TYPES_UINT32F
    #define TYPES_UINT32F
    /** \brief default unsigned 32 bits fast integer type definition */
    typedef unsigned long uint32f;
    #endif

    #ifndef TYPES_SINT32F
    #define TYPES_SINT32F
    /** \brief default signed 32 bits fast integer type definition */
    typedef signed long sint32f;
    #endif



    #ifndef TYPES_STD_RETURNTYPE
    #define TYPES_STD_RETURNTYPE
    /** \brief default Standard Return type definition */
    typedef uint8f Std_ReturnType;
    #endif


#endif /* _BASIC_TYPES_ */