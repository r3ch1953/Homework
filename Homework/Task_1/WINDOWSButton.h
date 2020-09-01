#pragma once
#include  <iostream>
#include "IButton.h"

class WINDOWSButton : public IButton {
public:
	void Press() override {
		std::cout << "This is WINDOWS button\n";
	}
};