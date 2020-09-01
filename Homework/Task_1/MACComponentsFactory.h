#pragma once
#include "ComponentsFactory.h"

#include "MACCursor.h"
#include "MACButton.h"
#include "MACMenu.h"
#include "MACWindow.h"

class MACComponentsFactory : public ComponentsFactory {
public:
	IButton* CreateButton() override {
		return new MACButton();
	}
	IMenu* CreateMenu() override {
		return new MACMenu();
	}
	ICursor* CreateCursor() override {
		return new MACCursor();
	}
	IWindow* CreateWindow() override {
		return new MACWindow();
	}
};


