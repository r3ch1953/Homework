#pragma once
#include "Language.h"
#include <iostream>

class Cpp : public Language
{
public:
	int WriteCode() override
	{
		std::cout << "Writing code in c++!\n";
		return 100;
	}
};

