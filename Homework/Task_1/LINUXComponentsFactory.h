#pragma once
#include "ComponentsFactory.h"

#include "LINUXCursor.h"
#include "LINUXButton.h"
#include "LINUXMenu.h"
#include "LINUXWindow.h"

class LINUXComponentsFactory : public ComponentsFactory {
public:
	IButton* CreateButton() override {
		return new LINUXButton();
	}
	IMenu* CreateMenu() override {
		return new LINUXMenu();
	}
	ICursor* CreateCursor() override {
		return new LINUXCursor();
	}
	IWindow* CreateWindow() override {
		return new LINUXWindow();
	}
};

