#include <iostream>


class number
{

public:
	static int counter;

	static void Increment()
	{
		counter++;
	}

	static int get_counter()
	{
		return counter;
	}
};


int number::counter = 0;


/*
class number
{
	int num{};

public:
	int get_num()
	{
		return  this->num;
	}

	void increment()
	{
		static int counter = 0;
		num = ++counter;
	}

};
*/

int main()
{

	return 0;
}
