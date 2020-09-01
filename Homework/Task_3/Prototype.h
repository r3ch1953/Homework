#pragma once

#include "Weapon.h"
#include "MageWeapon.h"
#include "ArcherWeapon.h"
#include "SwordsmanWeapon.h"

#include <vector>
using namespace std;

class Prototype
{
private:
	static vector<Weapon*> prototypes;

public:
	static Weapon* CreateWeapon(int choice)
	{
		return prototypes[choice - 1]->Clone();
	}

	static vector<Weapon*>* GetPrototypes() { return &prototypes; }
};

