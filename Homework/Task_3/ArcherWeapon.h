#pragma once
#include "Weapon.h"

class ArcherWeapon : public Weapon
{
public:
	ArcherWeapon(int damage = 8, std::string name = "ArhcerWeapon") : Weapon(damage, name) {}

	Weapon* Clone() override { return new ArcherWeapon(*this); }

	void Print() const override { Weapon::Print(); }
};

