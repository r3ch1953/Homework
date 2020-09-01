#pragma once
#include <iostream>
#include "IMenu.h"

class MACMenu : public IMenu {
public:
	void Choice() override {
		std::cout << "This is MAC menu\n";
	}
};
