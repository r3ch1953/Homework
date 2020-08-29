#include "Wallet.h"
#include <iostream>

Wallet* Wallet::object = nullptr;

Wallet::Wallet(float money)
{
    SetMoney(money);
}

Wallet* Wallet::GetObject(float money)
{
    if (object == nullptr)
        object = new Wallet(money);

    return object;
}

float Wallet::GetMoney() const
{
    return this->money;
}

void Wallet::SetMoney(float money)
{
    this->money = money;
}

void Wallet::PutMoney(float money)
{
    this->money += money;
}

void Wallet::WithdrawMoney(float money)
{
    if (money <= this->money)
        this->money -= money;
}

void Wallet::Print() const
{
    std::cout << "Money: " << money << std::endl;
}
