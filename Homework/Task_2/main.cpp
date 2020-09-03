#include "Programmer.h"
#include "Java.h"
#include "Cpp.h"
#include "Freelance.h"
#include "Company.h"

int main()
{
	Programmer* programmer = new Programmer(new Java(), new Freelance());

	programmer->DoWork();

	cout << "-----\n";
	
	programmer->Print();

	programmer->ChangeLanguage(new Cpp());
	programmer->AddNewJod(new Company());

	programmer->DoWork();

	cout << "-----\n";

	programmer->Print();
	
	return 0;
}