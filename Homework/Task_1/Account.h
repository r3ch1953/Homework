#pragma once

#include "IAccount.h"
#include <string>
using namespace std;

class Account : public IAccount
{
private:
	string id;
	string password;
	float money;

public:
	Account(string id, string password, float money) : id(id), password(password), money(money) {}

	string GetId() const;
	string GetPassword() const;
	float GetMoney() const;

	void SetId(string id);
	void SetPassword(string password);
	void SetMoney(float money);
	
	void PutMoney(int money) override;
	void WithdrawMoney(int money) override;
	
	string Print() const override;
};

