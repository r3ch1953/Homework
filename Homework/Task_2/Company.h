#pragma once
#include "Job.h"

class Company : public Job
{
public:
	int Work(Language* language) override
	{
		return language->WriteCode();
	}
};

