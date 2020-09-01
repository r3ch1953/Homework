#pragma once
#include <iostream>
#include "ICursor.h"

class MACCursor : public ICursor {
public:
	void Rotate() override {
		std::cout << "This is MAC cursor\n";
	}
};

