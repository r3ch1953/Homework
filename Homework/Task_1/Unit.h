#pragma once
#include <string>
using namespace std;

class Unit
{
protected:
	string name;
	int health;
	int damage;

public:
	Unit();

	virtual void Play() = 0;
};

