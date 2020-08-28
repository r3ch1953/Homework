#include "CrazyScientist.h"
#include <iostream>

CrazyScientist::CrazyScientist()
{
	this->damage = 15;
	this->health = 5;
	this->name = "cRaZy ScIeNtIsT";
}

void CrazyScientist::Play()
{
	cout << name << " ready to fight!\n";
}
