#pragma once

__interface  ICarConsole
{
public:
	virtual void Stop() = 0;
	virtual void Run() = 0;
	virtual void Rotate(int angle) = 0;
};

