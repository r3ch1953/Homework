#pragma once
#include <iostream>

#include "Language.h"

class Java : public Language
{
public:
	int WriteCode() override
	{
		std::cout << "Writing code in java!\n";
		return 90;
	}
};

