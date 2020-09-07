#pragma once
#include <string>

class IAccount
{
public:
	virtual void PutMoney(int money) = 0;
	virtual void WithdrawMoney(int money) = 0;
	virtual std::string Print() const = 0;
};

