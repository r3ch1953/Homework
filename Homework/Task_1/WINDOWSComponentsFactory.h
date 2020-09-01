#pragma once
#include "ComponentsFactory.h"

#include "WINDOWSCursor.h"
#include "WINDOWSButton.h"
#include "WINDOWSMenu.h"
#include "WINDOWSWindow.h"

class WINDOWSComponentsFactory : public ComponentsFactory {
public:
	IButton* CreateButton() override {
		return new WINDOWSButton();
	}
	IMenu* CreateMenu() override {
		return new WINDOWSMenu();
	}
	ICursor* CreateCursor() override {
		return new WINDOWSCursor();
	}
	IWindow* CreateWindow() override {
		return new WINDOWSWindow();
	}
};


