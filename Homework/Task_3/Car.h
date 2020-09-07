#pragma once

#include <string>
#include <iostream>
using namespace std;

class Car
{
public:
	void Start()
	{
		cout << "Car strated\n";
	}

	void Stop()
	{
		cout << "Car stoped\n";
	}

	void Left(int angle)
	{
		cout << "Car rotated to left for angele: " << angle << endl;
	}

	void Right(int angle)
	{
		cout << "Car rotated to right for angele: " << angle << endl;
	}
};

