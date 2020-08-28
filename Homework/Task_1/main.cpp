#include <iostream>
#include <vector>

#include "Unit.h"
#include "Marine.h"
#include "CrazyScientist.h"
#include "MilitaryDoctor.h"

#include "Barrack.h"
#include "MilitaryBarrack.h"
#include "ScientistBarrack.h"
#include "MedicalBarrack.h"

int main()
{
	vector<Unit*> units;

	MilitaryBarrack militaryBarrack;
	ScientistBarrack scientistBarrack;
	MedicalBarrack medicalBarrack;

	vector<Barrack*> barracks = { &militaryBarrack, &scientistBarrack, &medicalBarrack };

	bool exit = false;
	unsigned int choice;
	while (!exit)
	{
		cout << "0. Exit \t 1. Marine \t 2. Crazy Scientist \t 3. Military Doctor \n";
		cout << "Eneter your choice: ";
		cin >> choice;

		if (choice == 0 || choice > 3)
			exit = true;
		else
			units.push_back(barracks[choice - 1]->CreateUnit());
	}
	system("cls");

	for (auto item : units)
		item->Play();

	units.clear();
	barracks.clear();

	return 0;
}