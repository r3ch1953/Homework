#pragma once

#include "ICarConsole.h"
#include "Car.h"

#include <cmath>

class NewCar : public ICarConsole
{
private:
	Car* car;

public:
	NewCar(Car* car = new Car()) : car(car) {}

	void Run() override { this->car->Start(); }
	void Stop() override { this->car->Stop(); }
	
	void Rotate(int angle) override
	{
		if (angle > 0)
			this->car->Right(angle);

		if (angle < 0)
			this->car->Left(abs(angle));
	}
};

