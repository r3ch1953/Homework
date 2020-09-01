#pragma once
#include "Weapon.h"

class MageWeapon : public Weapon
{
public:
	MageWeapon(int damage = 10, std::string name = "MageWeapon") : Weapon(damage, name) {}
	
	Weapon* Clone() override { return new MageWeapon(*this); }

	void Print() const override { Weapon::Print(); }
};

