#pragma once
#include "Barrack.h"
#include "Marine.h"

class MilitaryBarrack : public Barrack
{
public:
	Unit* CreateUnit() override
	{
		return new Marine;
	}
};

