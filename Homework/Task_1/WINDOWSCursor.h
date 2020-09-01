#pragma once
#include <iostream>
#include "ICursor.h"

class WINDOWSCursor : public ICursor {
public:
	void Rotate() override {
		std::cout << "This is WINDOWS cursor\n";
	}
};

