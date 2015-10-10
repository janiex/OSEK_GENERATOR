#include "common.h"
StatusType ClearEvent
(
	EventMaskType Mask
);
StatusType GetEvent
(
	TaskType TaskID,
	EventMaskRefType Event
);
StatusType OS_SetEvent
(
	TaskType TaskID,
	EventMaskType Mask
);
StatusType OS_WaitEvent
(
	EventMaskType Mask
);
