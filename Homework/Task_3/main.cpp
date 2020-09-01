#include "Prototype.h"

vector<Weapon*> Prototype::prototypes = { new MageWeapon(), new ArcherWeapon(), new SwordsmanWeapon() };

int main()
{
	vector<Weapon*> myWeapons;
	
	bool exit = false;
	while (!exit)
	{
		system("cls");
		int choice;
		cout << "<<< MENU >>>\n\n";
	
		int i = 1;
		for(auto item : *Prototype::GetPrototypes())
		{
			cout << i << ".\n";
			item->Print();
			cout << "----\n";
			++i;
		}
		
		cout << "Select weapon(0 - exit): ";
		cin >> choice;

		switch (choice)
		{
		case 0:
			exit = true;
			break;

		default:
			myWeapons.push_back(Prototype::CreateWeapon(choice));
			break;
		}
	}

	system("cls");

	cout << "My Weapons:\n";
	
	int i = 1;
	for (auto item : myWeapons)
	{
		cout << i << ".\n";
		item->Print();
		cout << "----\n";
		++i;
	}
	
	return 0;
}