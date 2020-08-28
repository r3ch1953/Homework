#include "Marine.h"
#include <iostream>

Marine::Marine()
{
	this->damage = 10;
	this->health = 15;
	this->name = "Marine";
}

void Marine::Play()
{
	cout << name << " ready to fight!\n";
}
