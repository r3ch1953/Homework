#pragma once

class Wallet
{
private:
	float money;
	static Wallet* object;
	Wallet(float money);

public:
	static Wallet* GetObject(float money);

	float GetMoney() const;
	void SetMoney(float money);

	void PutMoney(float money);
	void WithdrawMoney(float money);

	void Print() const;
};

