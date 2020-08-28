#include "MilitaryDoctor.h"
#include <iostream>

MilitaryDoctor::MilitaryDoctor()
{
	this->damage = 5;
	this->health = 25;
	this->name = "Doctor";
}

void MilitaryDoctor::Play()
{
	cout << name << " ready to fight!\n";
}
