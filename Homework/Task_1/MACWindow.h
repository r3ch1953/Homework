#pragma once
#include <iostream>
#include "IWindow.h"

class MACWindow : public IWindow {
public:
	void Show() override {
		std::cout << "This is MAC window\n";
	}
};
