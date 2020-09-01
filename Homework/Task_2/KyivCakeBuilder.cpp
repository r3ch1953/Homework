#include "KyivCakeBuilder.h"

KyivCakeBuilder::KyivCakeBuilder() {
	this->GetCake()->SetName("Kyiv Cake");
}

void KyivCakeBuilder::SetBasics() {
	this->GetCake()->SetPart("Basics", "air dough with nuts");
}

void KyivCakeBuilder::SetCream() {
	this->GetCake()->SetPart("Cream", "butter and condensed Cream");
}

void KyivCakeBuilder::SetDesign() {
	this->GetCake()->SetPart("Design", "default");
}
