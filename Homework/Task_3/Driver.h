#pragma once

#include "ICarConsole.h"
#include "NewCar.h"

class Driver
{
private:
	ICarConsole* car;

public:
	Driver(ICarConsole* car = new NewCar()) : car(car) {}

	void Drive()
	{
		car->Rotate(-100);
		car->Rotate(100);
		car->Run();
		car->Stop();
	}
};

