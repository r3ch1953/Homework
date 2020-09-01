#pragma once
#include "ICursor.h"
#include "IButton.h"
#include "IMenu.h"
#include "IWindow.h"

class ComponentsFactory abstract {
public:
	virtual IButton* CreateButton() = 0;
	virtual IMenu  * CreateMenu  () = 0;
	virtual ICursor* CreateCursor() = 0;
	virtual IWindow* CreateWindow() = 0;
};

