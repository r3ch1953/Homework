#include "Account.h"
#include "Client.h"
#include "ATM.h"

int main()
{
	Account* acc = new Account("1583", "password", 100);
	Client* client = new Client();
	ATM* atm = new ATM(client, acc);

	atm->Login(client);
	atm->Print();
	atm->Logout();
	
	return 0;
}