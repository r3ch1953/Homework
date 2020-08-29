#include <iostream>
#include "Wallet.h"

int main()
{
	Wallet* walletOne = Wallet::GetObject(100);

	walletOne->WithdrawMoney(10);
	walletOne->Print();

	Wallet* walletTwo = Wallet::GetObject(200);

	walletTwo->Print();

	return 0;
}