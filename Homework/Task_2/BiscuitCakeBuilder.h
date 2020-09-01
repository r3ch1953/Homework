#pragma once
#include "CakeBuilder.h"

class BiscuitCakeBuilder : public CakeBuilder {
public:
	BiscuitCakeBuilder();

	void SetBasics() override;
	void SetCream () override;
	void SetDesign() override;
};

