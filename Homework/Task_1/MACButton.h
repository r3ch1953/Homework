#pragma once
#include  <iostream>
#include "IButton.h"

class MACButton : public IButton {
public:
	void Press() override {
		std::cout << "This is MAC button\n";
	}
};

