#include "types.h"
#include "constants.h"
#include "intrinsics.h"
#include "natives.h"
#include "common.h"

bool loaded = false;

void main()
{
	if (!loaded)
	{
		if (DOES_SCRIPT_EXIST("CyberLoader"))
		{
			REQUEST_SCRIPT("CyberLoader");
			while (!HAS_SCRIPT_LOADED("CyberLoader")) WAIT(0);
			START_NEW_SCRIPT("CyberLoader", 2024);
			SET_SCRIPT_AS_NO_LONGER_NEEDED("CyberLoader");
			loaded = true;
		}
	}
}