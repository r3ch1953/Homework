#pragma once
#include <iostream>

#include "Employee.h"
#include "Job.h"
#include "Language.h"

#include <string>
#include <list>
using namespace std;

class Programmer : public Employee
{
private:
	string name;
	Language* language;
	list<Job*> jobs;
	int money;
	int oldMoney;
public:
	Programmer( Language* language, Job* job, string name = "Programmer")
	{
		this->language = language;
		this->name = name;
		this->jobs.push_back(job);
	}
	
	void DoWork() override
	{
		oldMoney = money;
		for(auto item : jobs)
		{
			money += item->Work(language);
		}
		cout << "You worked 1 hour!\n And paid 10% tax!\n";
		cout << "Total payment: " << money - oldMoney << endl;
		PayTax();
	}

	void PayTax() override
	{
		money -= (money - oldMoney) / 10;
	}

	void ChangeLanguage(Language* language)
	{
		this->language = language;
	}
	void AddNewJod(Job* job)
	{
		jobs.push_back(job);
	}

	void Print() const
	{
		cout << "Name: " << name << endl;
		cout << "Money: " << money << endl;
		
	}
};

