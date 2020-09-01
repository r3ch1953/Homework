#pragma once
#include <iostream>
#include "IMenu.h"

class LINUXMenu : public IMenu {
public:
	void Choice() override {
		std::cout << "This is LINUX menu\n";
	}
};

