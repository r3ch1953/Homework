#pragma once

#include "Client.h"
#include "IAccount.h"
#include "Account.h"

class ATM : public IAccount
{
private:
	Client* client;
	Account* account;
	bool login;

public:
	ATM(Client* client, Account* account = new Account("id", "password", 0));

	void Login(Client* client);
	void Logout();
	bool CheckLogined() const;

	void PutMoney(int money) override;
	void WithdrawMoney(int money) override;

	string Print() const override; 
};

