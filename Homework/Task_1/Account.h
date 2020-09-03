#pragma once
#include <iostream>
#include <vector>
#include <string>
using namespace std;

class Account
{
private:
	int id;
	int money;
	string password;

	static vector<int> AccountsID;

public:
	Account(string password, int money = 0) : password(std::move(password)), money(money)
	{
		if (!AccountsID.empty())
			id = *AccountsID.end() + 1;
		else
			id = 1;

		AccountsID.push_back(id);
	}

	int GetId() const { return id; }
	int GetMoney() const { return money; }
	string GetPassword() const { return password; }
	
	void PutMoney(int money)
	{
		this->money += money;
	}
	void WithdrawMoney(int money)
	{
		if (this->money >= money)
			this->money -= money;
	}

	void Print() const
	{
		cout << "<--- Account --->\n\n";
		cout << "ID: " << id << endl;
		cout << "Money: " << money << endl;
	}
};

