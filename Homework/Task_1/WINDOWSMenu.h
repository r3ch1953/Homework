#pragma once
#include <iostream>
#include "IMenu.h"

class WINDOWSMenu : public IMenu {
public:
	void Choice() override {
		std::cout << "This is WINDOWS menu\n";
	}
};
