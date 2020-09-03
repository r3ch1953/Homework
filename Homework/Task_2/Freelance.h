#pragma once
#include "Job.h"

class Freelance : public Job
{
public:
	int Work(Language* language) override
	{
		return language->WriteCode();
	}
};

