#include "Account.h"

#include <iostream>

string Account::GetId() const
{
	return id;
}

string Account::GetPassword() const
{
	return password;
}

float Account::GetMoney() const
{
	return money;
}

void Account::SetId(string id)
{
	this->id = id;
}

void Account::SetPassword(string password)
{
	this->password = password;
}

void Account::SetMoney(float money)
{
	this->money = money;
}

void Account::PutMoney(int money)
{
	this->money += money;
}

void Account::WithdrawMoney(int money)
{
	if (this->money >= money)
		this->money -= money;
}

string Account::Print() const
{
	string report = "<<< ACCCOUNT : " + id + " >>>\n\n" + "Money: " + to_string(money) + "\n";
	cout << report;
	return report;
}

