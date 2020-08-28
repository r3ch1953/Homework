#pragma once
#include "Barrack.h"
#include "MilitaryDoctor.h"

class MedicalBarrack : public Barrack
{
public:
	Unit* CreateUnit() override
	{
		return new MilitaryDoctor;
	}
};

