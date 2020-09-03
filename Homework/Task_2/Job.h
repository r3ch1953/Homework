#pragma once
#include "Language.h"

__interface Job
{
public:
	virtual int Work(Language* language) = 0;
};

