#pragma once
#include <iostream>
#include "ICursor.h"

class LINUXCursor : public ICursor {
public:
	void Rotate() override {
		std::cout << "This is LINUX cursor\n";
	}
};

