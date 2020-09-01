#include "Cake.h"

string Cake::GetName() const {
	return name;
}

string Cake::GetPart(string key) {
	return parts[key];
}

void Cake::SetName(string name) {
	this->name = name;
}

void Cake::SetPart(string key, string value) {
	parts[key] = value;
}

void Cake::Print() const {
	cout << "<---" << name << "--->\n";
	for (auto item : parts)
		cout << item.first << ": " << item.second << endl;
}
