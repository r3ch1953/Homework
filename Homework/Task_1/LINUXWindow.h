#pragma once
#include <iostream>
#include "IWindow.h"

class LINUXWindow : public IWindow {
public:
	void Show() override {
		std::cout << "This is LINUX window\n";
	}
};
