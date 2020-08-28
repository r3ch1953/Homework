#pragma once
#include "Barrack.h"
#include "CrazyScientist.h"

class ScientistBarrack : public Barrack
{
public:
	Unit* CreateUnit() override
	{
		return new CrazyScientist;
	}
};

