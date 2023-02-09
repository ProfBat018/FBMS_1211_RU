#include "Mylib.h"
#include "iostream"

// В функциях всегда должен быть указан тип данных.
// Все функции с типами данных, кроме void возвращают тип данных.

void print_hello()
{
	std::cout << "Hello World" << std::endl;
}


int addition(int first_num, int second_num)
{
	int result = first_num + second_num;
	return result;
}


float addition2(float first_num, float second_num)
{
	float result = first_num + second_num;
	return result;
}

void print_arr(int arr[], int length)
{
	for (int i = 0; i < length; i++)
	{
		std::cout << arr[i] << std::endl;
	}
}

void fill_arr(int arr[], int length)
{
	for (int i = 0; i < length; i++)
	{
		std::cout << "Enter " << i + 1 << " element of arr: ";
		std::cin >> arr[i];
	}

}


void fill_rand(int arr[], int length, int start_rand, int end_rand)
{
	for (int i = 0; i < length; i++)
	{
		arr[i] = rand() % (end_rand - start_rand + 1) + start_rand;
	}
}

float addition3(float first_num, float second_num)
{
	float result = first_num + second_num;
	return result;
}

bool is_Even(int number)
{
	return number % 2 == 0 ? true : false;
}

