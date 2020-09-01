#pragma once
#include "Cake.h"

class CakeBuilder abstract {
private:
	Cake* cake;

public:
	CakeBuilder() {
		cake = new Cake();
	}

	virtual void SetBasics() = 0;
	virtual void SetCream() = 0;
	virtual void SetDesign() = 0;

	Cake* GetCake() const {
		return cake;
	}

	~CakeBuilder() {
		delete cake;
	}
};

