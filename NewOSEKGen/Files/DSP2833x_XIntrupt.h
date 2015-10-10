// TI File $Revision: /main/1 $
// Checkin $Date: August 18, 2006   13:52:39 $
//###########################################################################
//
// FILE:  DSP2833x_XIntrupt.h
//
// TITLE: DSP2833x Device External Interrupt Register Definitions.
//
//###########################################################################
// $TI Release: DSP2833x/DSP2823x C/C++ Header Files V1.31 $
// $Release Date: August 4, 2009 $
//###########################################################################

#ifndef DSP2833x_XINTRUPT_H
#define DSP2833x_XINTRUPT_H


#ifdef __cplusplus
extern "C" {
#endif

//---------------------------------------------------------------------------

struct XINTCR_BITS {
    uint16   ENABLE:1;    // 0      enable/disable
    uint16   rsvd1:1;     // 1      reserved
    uint16   POLARITY:2;  // 3:2    pos/neg, both triggered
    uint16   rsvd2:12;    //15:4    reserved
};

union XINTCR_REG {
   uint16               all;
   struct XINTCR_BITS   bit;
};  

struct XNMICR_BITS {
    uint16   ENABLE:1;    // 0      enable/disable
    uint16   SELECT:1;    // 1      Timer 1 or XNMI connected to int13
    uint16   POLARITY:2;  // 3:2    pos/neg, or both triggered
    uint16   rsvd2:12;    // 15:4   reserved
};

union XNMICR_REG {
   uint16               all;
   struct XNMICR_BITS   bit;
};  




//---------------------------------------------------------------------------
// External Interrupt Register File:
//
struct XINTRUPT_REGS {
   union XINTCR_REG XINT1CR;
   union XINTCR_REG XINT2CR;
   union XINTCR_REG XINT3CR;
   union XINTCR_REG XINT4CR;
   union XINTCR_REG XINT5CR;
   union XINTCR_REG XINT6CR;
   union XINTCR_REG XINT7CR;
   union XNMICR_REG XNMICR;
   uint16           XINT1CTR;
   uint16           XINT2CTR;
   uint16           rsvd[5];
   uint16           XNMICTR;
};

//---------------------------------------------------------------------------
// External Interrupt References & Function Declarations:
//
extern volatile struct XINTRUPT_REGS XIntruptRegs;

#ifdef __cplusplus
}
#endif /* extern "C" */

#endif  // end of DSP2833x_XINTF_H definition

//===========================================================================
// End of file.
//===========================================================================

