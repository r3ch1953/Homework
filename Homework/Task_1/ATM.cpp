#include "ATM.h"

#include <iostream>

ATM::ATM(Client* client, Account* account)
{
	this->client = client;
	this->account = account;
}

void ATM::Login(Client* client)
{
	if (this->client == client)
	{
		cout << "Login done\n";
		login = true;
	}
	else
		cout << "Something was wrong\n";
}

void ATM::Logout()
{
	cout << "Logout done\n";
	login = false;
}

bool ATM::CheckLogined() const
{
	return login;
}

void ATM::PutMoney(int money)
{
	if (CheckLogined())
		this->account->PutMoney(money);
}

void ATM::WithdrawMoney(int money)
{
	if (CheckLogined())
		this->account->WithdrawMoney(money);
}

string ATM::Print() const
{
	if (CheckLogined())
		return this->account->Print();
	return "Error";
}
