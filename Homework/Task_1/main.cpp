#include "LINUXComponentsFactory.h"
#include "WINDOWSComponentsFactory.h"
#include "MACComponentsFactory.h"
#include "ComponentsFactory.h"

#include <fstream>
#include <string>
using namespace std;

// OS - Operating system
// GUI - Graphical user interface

enum class OS {
	LINUX,
	WINDOWS,
	MAC,
	NONE
};

struct GUI {
	IButton* button;
	IMenu  * menu;
	ICursor* cursor;
	IWindow* window;
};

OS ConvertToEnum(string os) {
	if (os == "LINUX")
		return OS::LINUX;

	else if (os == "WINDOWS")
		return OS::WINDOWS;

	else if (os == "MAC")
		return OS::MAC;

	else
		return OS::NONE;
}

string ReadFromFile(string filename) {
	ifstream file(filename);
	if (!file)
		return "error";
		
	string os;
	getline(file, os);

	return os;
}

ComponentsFactory* DetectFactory(OS os) {
	switch (os) {
	case OS::NONE:
	case OS::MAC:
		return new MACComponentsFactory();

	case OS::WINDOWS:
		return new WINDOWSComponentsFactory();

	case OS::LINUX:
		return new LINUXComponentsFactory();
	}
}

GUI CreateGUI(ComponentsFactory* factory) {
	return GUI{ factory->CreateButton(), factory->CreateMenu(), factory->CreateCursor(), factory->CreateWindow() };
}

int main() {
	
	GUI gui = CreateGUI(DetectFactory(ConvertToEnum(ReadFromFile("os.txt"))));

	gui.button->Press();
	gui.cursor->Rotate();
	gui.menu->Choice();
	gui.window->Show();
		
	return 0;
}
