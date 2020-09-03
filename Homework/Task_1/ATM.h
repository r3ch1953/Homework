#pragma once
#include "Account.h"

#include <iostream>
using namespace std;

class ATM
{
private:
	Account* acc;
	bool login;
public:
	ATM(Account* acc = new Account("1")) : acc(acc) {}
	~ATM() { delete acc; }

	void SetNewAccount(Account* acc) { this->acc = acc; }
	
	bool GetLoginStatus() const { return login; }
	void Login()
	{
		if(GetLoginStatus())
		{
			cout << "Already logined!\n";
			return;
		}
		
		string password;
		cout << "Enter password:\n";
		cin >> password;

		if (password == acc->GetPassword())
		{
			login = true;
			cout << "Login successful!\n";
		}
		else
			cout << "Login Failed! Wrong password\n";
	}
	void Logout() { login = false; }
	
	void PutMoney(int money)
	{
		if(!GetLoginStatus())
			return;
		
		acc->PutMoney(money);
	}
	void WithdrawMoney(int money)
	{
		if(!GetLoginStatus())
			return;
		
		acc->WithdrawMoney(money);
	}

	void Print() const { acc->Print(); }
};

