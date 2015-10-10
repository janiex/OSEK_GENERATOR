#ifndef HW_CONFIG_H_
#define HW_CONFIG_H_
/*-----------------------------------------------------------------------------
      Specify the PLL control register (PLLCR) and divide select (DIVSEL) value.
-----------------------------------------------------------------------------*/
//#define DSP28_DIVSEL   0   // Enable /4 for SYSCLKOUT
//#define DSP28_DIVSEL   1 // Enable /4 for SYSCKOUT
#define DSP28_DIVSEL     2 // Enable /2 for SYSCLKOUT
//#define DSP28_DIVSEL     3 // Enable /1 for SYSCLKOUT

#define DSP28_PLLCR   10
//#define DSP28_PLLCR    9
//#define DSP28_PLLCR    8
//#define DSP28_PLLCR    7
//#define DSP28_PLLCR    6
//#define DSP28_PLLCR    5
//#define DSP28_PLLCR    4
//#define DSP28_PLLCR    3
//#define DSP28_PLLCR    2
//#define DSP28_PLLCR    1
//#define DSP28_PLLCR    0  // PLL is bypassed in this mode
//----------------------------------------------------------------------------
#endif /*HW_CONFIG_H_*/
