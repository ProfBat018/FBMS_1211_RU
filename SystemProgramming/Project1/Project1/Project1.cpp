#pragma once
#include <iostream>
#include <sstream>
#include <time.h>
#include <fstream>

using namespace std;


class FileService
{
public:
	static void Write(string path, string data)
	{
		fstream file(path.c_str(), ios::app);
		if (file.is_open())
		{
			file << data;
			file.close();
		}
		else
		{
			throw new exception("File is not opened...");
		}
	}
};


class Time // это класс со статичным методом, который возвращает время в момент вызова в формате строки чтобы удобно было записывать в файл.
{
public:
	static std::string GetDate()
	{
		tm local_time;

		time_t now = time(0);
		localtime_s(&local_time, &now);
		std::ostringstream stream;

		stream << local_time.tm_year + 1900 << '-' << local_time.tm_mon + 1 << '-' << local_time.tm_mday;

		return stream.str();
	}
};


struct Expenditure
{
	string name;
	unsigned int amount;
	string time;

	Expenditure() = default;

	Expenditure(string name, unsigned int amount)
	{
		this->name = name;
		this->amount = amount;
		this->time = Time::GetDate();
	}

	string ToString()
	{
		string res = this->time;
		res += name;
		res += '\t';
		ostringstream amount_stream;
		amount_stream << amount;
		res += amount_stream.str();
		res += '\n';

		return res;
	}
};



class Card
{
public:
	enum cards { credit, debut };


	Card() {}
	Card(enum cards mode, unsigned int balance)
	{
		this->balance = balance;
		this->mode = mode;
	}

	void CashIn(unsigned short sum)
	{

	}

	void Payment(Expenditure* p) {
		try
		{
			FileService::Write("data.txt", p->ToString());
		}
		catch (const std::exception& ex)
		{
			cerr << ex.what();
		}

	}

private:
	unsigned short balance;
	cards mode;

};


int main()
{
	Expenditure ex("Burger", 4);

	Card card(Card::cards::debut, 1000);
	
	card.Payment(&ex);


	return 0;
}