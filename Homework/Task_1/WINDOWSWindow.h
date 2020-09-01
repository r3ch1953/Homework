#pragma once
#include <iostream>
#include "IWindow.h"

class WINDOWSWindow : public IWindow {
public:
	void Show() override {
		std::cout << "This is WINDOWS window\n";
	}
};

