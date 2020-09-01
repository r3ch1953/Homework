#pragma once
#include "Weapon.h"

class SwordsmanWeapon : public Weapon
{
public:
	SwordsmanWeapon(int damage = 15, std::string name = "SwordsmanWeapon") : Weapon(damage, name) {}

	Weapon* Clone() override { return new SwordsmanWeapon(*this); }

	void Print() const override { Weapon::Print(); }
};

