#pragma once
#include  <iostream>
#include "IButton.h"

class LINUXButton : public IButton {
public:
	void Press() override {
		std::cout << "This is LINUX button\n";
	}
};