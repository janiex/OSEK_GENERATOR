#if(SELECTED_MICROCONTROLLER == _MSP430_x54x_) 
	#include <msp430x54x.h>
#elif(SELECTED_MICROCONTROLLER == _MSP430_xG46x_)
	#include <msp430xG46x.h>
#else 
	#error "Inplausible selection of MSP430 derivate"
#endif //(SELECTED_MICROCONTROLLER == _MSP430_x54x_) AND (SELECTED_MICROCONTROLLER == _MSP430_xG46x_)

#if(SELECTED_MICROCONTROLLER == _MSP430_x54x_)
void InitHW(void)
{
	WDTCTL = WDTPW + WDTHOLD;                 // Stop WDT
	TA1CCTL0 = CCIE;                          // CCR0 interrupt enabled
	TA1CCR0 = 50000;                          // count with
	TA1CTL = TASSEL_2 + MC_2 + TACLR;         // SMCLK, contmode, clear TAR
	//P1DIR |= 0x01;                            // P1.0 output
	//P10DIR = P10DIR | 0xC0;			          //LED1, LED2 set as output
	//P10OUT = P1OUT | 0x80 & ~(0x40);	      //Set LED1 ON, LED2 OFF
	P3SEL = 0x30;                             // P3.4,5 = USCI_A0 TXD/RXD
	UCA0CTL1 |= UCSWRST;                      // **Put state machine in reset**
	UCA0CTL1 |= UCSSEL_2;                     // SMCLK
	UCA0BR0 = 9;                              // 1MHz 115200 (see User's Guide)
	UCA0BR1 = 0;                              // 1MHz 115200
	UCA0MCTL |= UCBRS_1 + UCBRF_0;            // Modulation UCBRSx=1, UCBRFx=0
	UCA0CTL1 &= ~UCSWRST;                     // **Initialize USCI state machine**
}
#elif(SELECTED_MICROCONTROLLER == _MSP430_xG46x_)

	#define _8MHZ 	1
	#define _32KHZ	2
	#define CLOCK _8MHZ
	#if (CLOCK == _32KHZ)
	void InitHW(void)
	{
		volatile unsigned int i;
		WDTCTL = WDTPW +WDTHOLD;                  // Stop WDT
		FLL_CTL0 |= XCAP14PF;                     // Configure load caps
	  // Wait for xtal to stabilize
		do
		  {
		  IFG1 &= ~OFIFG;                           // Clear OSCFault flag
		  for (i = 0x47FF; i > 0; i--);             // Time for flag to set
		  }
		  while ((IFG1 & OFIFG));

		  P2SEL = BIT4|BIT5;                        // P2.4,5 = USCI_A0 RXD/TXD

		  UCA0CTL1 |= UCSSEL_2;                     // SMCLK
		  UCA0BR0 = 0x09;                           // 1MHz 115200
		  UCA0BR1 = 0x00;                           // 1MHz 115200
		  UCA0MCTL = 0x02;                          // Modulation
		  UCA0CTL1 &= ~UCSWRST;                     // **Initialize USCI state machine**
									  // P5.1 output
		  TACCTL0 = CCIE;                           // TACCR0 interrupt enabled
		  TACCR0 = 5000;
		  TACTL = TASSEL_2 + MC_2;                  // SMCLK, continuous mode

	}
	#elif (CLOCK == _8MHZ)
	void InitHW(void){
		volatile unsigned int i;

	  WDTCTL = WDTPW+WDTHOLD;                   // Stop WDT
	  FLL_CTL0 |= XCAP14PF;                     // Configure load caps
	  FLL_CTL1 &= ~XT2OFF;                      // Clear bit = HFXT2 on

	  // Wait for xtal to stabilize
	  do
	  {
	  IFG1 &= ~OFIFG;                           // Clear OSCFault flag
	  for (i = 0x47FF; i > 0; i--);             // Time for flag to set
	  }
	  while ((IFG1 & OFIFG));                   // OSCFault flag still set?
	  FLL_CTL1 |= SELM_XT2;                     // MCLK = XT2

	  BTCTL = BT_ADLY_16;                     	// 16-miliseconds interrupt
	  IE2 |= BTIE;                              // Enable Basic Timer interrupt

	  //P5DIR |= 0x002;                           // P5.1 = output direction
	  P2SEL = BIT4|BIT5;                        // P2.4,5 = USCI_A0 RXD/TXD

	  UCA0CTL1 |= UCSSEL_2;                     // SMCLK
	  UCA0BR0 = 0x09;                           // 1MHz 115200
	  UCA0BR1 = 0x00;                           // 1MHz 115200
	  UCA0MCTL = 0x02;                          // Modulation
	  UCA0CTL1 &= ~UCSWRST;                     // **Initialize USCI state machine**
	  
	  P5DIR |= 0x02;                           // P5.1 = output direction
	  P2DIR |= 0x06;
	  P5OUT &= ~(0x02);
	  P2OUT &= ~(0x06);
	}

	#else
		#error Wrong Configuration of the Clock
	#endif

#else
	#error Inplausible MSP430 derivate selection!
#endif // (SELECTED_MICROCONTROLLER == _MSP430_x54x_) AND (SELECTED_MICROCONTROLLER == _MSP430_xG46x_)

