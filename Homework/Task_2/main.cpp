#include "BiscuitCakeBuilder.h"
#include "KyivCakeBuilder.h"
#include "Roshen.h"

int main()
{
	Roshen* roshen = new Roshen(new KyivCakeBuilder());
	roshen->Create()->Print();
	delete roshen;

	cout << "----\n";
	
	roshen = new Roshen(new BiscuitCakeBuilder());
	roshen->Create()->Print();
	delete roshen;
	
	return 0;
}