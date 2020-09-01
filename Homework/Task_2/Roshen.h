#pragma once
#include "CakeBuilder.h"

// Director
class Roshen {
private:
	CakeBuilder* builder;

public:
	Roshen(CakeBuilder* builder) {
		this->builder = builder;
	}

	Cake* Create() {
		builder->SetBasics();
		builder->SetCream();
		builder->SetDesign();
		return  builder->GetCake();
	}
};

