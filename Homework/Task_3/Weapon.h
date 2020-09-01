#pragma once
#include <iostream>
#include <string>

class Weapon abstract
{
protected:
	std::string name;
	int damage;

public:
	Weapon(int damage = 0, std::string name = "weapon") : name(name), damage(damage) {}

	virtual Weapon* Clone() = 0;

	int GetDamage() const { return damage; }
	void SetDamage(int damage) { this->damage = damage; }

	std::string GetName() const { return name; }
	void SetName(std::string name) { this->name = name; }

	virtual void Print() const
	{
		std::cout << "<---" << name << "--->\n";
		std::cout << "Damage: " << damage << std::endl;
	}
};

