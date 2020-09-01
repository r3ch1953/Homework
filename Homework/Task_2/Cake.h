#pragma once
#include <map>
#include <iostream>
using namespace std;

class Cake {
private:
	string name;
	map<string, string> parts;

public:
	Cake(string name = "Cake") : name(name) {}

	string GetName() const;
	string GetPart(string key);

	void SetName(string name);
	void SetPart(string key, string value);

	void Print() const;
};

