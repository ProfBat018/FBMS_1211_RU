#include <iostream>
#include "Kotik.h"


int main()
{
	// Example 1
	/*
	Kotik cat1; // cat1 - объект типа Kotik
	
	cat1.add();
	cat1.print_cat();
	*/
	

	// Example 2

	const int length = 2;
	Kotik* cats = new Kotik[length];
	

	for (size_t i = 0; i < length; i++)
	{
		cats[i].add();
	}

	for (size_t i = 0; i < length; i++)
	{
		cats[i].print();
	}


	std::cout << cats[0].GetBreed();

	return 0;
}
