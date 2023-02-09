#include "Calc.h"
#include <iostream>

using namespace std;


int* create_arr(const int length)
{
	int* arr = new int[length] {};
	
	for (int i = 0; i < length; i++)
		*(arr + i) = i + 1;

	return arr;
}


void print_arr(int* arr, const int length)
{
	for (int i = 0; i < length; i++)
	{
		cout << *(arr + i) << endl;
	}
}
