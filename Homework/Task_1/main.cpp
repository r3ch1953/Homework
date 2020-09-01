#include "LINUXComponentsFactory.h"
#include "WINDOWSComponentsFactory.h"
#include "MACComponentsFactory.h"

#include <vector>
using namespace std;

int main()
{
	// Init factories
	LINUXComponentsFactory   LINUXFactory;
	MACComponentsFactory     MACFactory;
	WINDOWSComponentsFactory WINDOWSFactory;
	
	vector<ComponentsFactory*> factories {&LINUXFactory, &MACFactory, &WINDOWSFactory};

	// Init components
	vector<IButton*> buttons;
	vector<IMenu*>   menus;
	vector<ICursor*> cursors;
	vector<IWindow*> windows;

	// Create Buttons
	for (auto item : factories)
		buttons.push_back(item->CreateButton());

	// Create Menus
	for (auto item : factories)
		menus.push_back(item->CreateMenu());

	// Create Cursors
	for (auto item : factories)
		cursors.push_back(item->CreateCursor());

	// Create Windows
	for (auto item : factories)
		windows.push_back(item->CreateWindow());

	// Show all buttons
	for (auto item : buttons)
		item->Press();
	cout << "-----\n";
	
	// Show all menus
	for (auto item : menus)
		item->Choice();
	cout << "-----\n";
	
	// Show all cursors
	for (auto item : cursors)
		item->Rotate();
	cout << "-----\n";
	
	// Show all windows
	for (auto item : windows)
		item->Show();
	cout << "-----\n";
	
	return 0;
}
