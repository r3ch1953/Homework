#pragma once
#include "CakeBuilder.h"

class KyivCakeBuilder : public CakeBuilder {
public:
	KyivCakeBuilder();

	void SetBasics() override;
	void SetCream () override;
	void SetDesign() override;
};

