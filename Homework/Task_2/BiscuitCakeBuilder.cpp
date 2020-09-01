#include "BiscuitCakeBuilder.h"

BiscuitCakeBuilder::BiscuitCakeBuilder() {
	this->GetCake()->SetName("Biscuit cake");
}

void BiscuitCakeBuilder::SetBasics() {
	this->GetCake()->SetPart("Basics", "biscuit");
}

void BiscuitCakeBuilder::SetCream() {
	this->GetCake()->SetPart("Cream", "plombir");
}

void BiscuitCakeBuilder::SetDesign() {
	this->GetCake()->SetPart("Design", "cocos");
}
