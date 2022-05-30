#include <iostream>
#include "Calc.h"
using namespace std;


int main()
{
	int* arr = create_arr(10);
	print_arr(arr, 10);

	const char* name = "Elvin";
	cout << name;
}

