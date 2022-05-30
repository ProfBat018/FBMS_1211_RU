#include "jagged_arr_funcs.h"
#include <iostream>
#include "multy_arr_funcs.h"


int** fill_jagged_arr(int row_length, int* length_arr)
{
	int** tmp_arr = new int* [row_length] {};


	for (size_t i = 0; i < row_length; i++)
	{
		int arr_length = {};
		std::cout << "Enter length of inner array => ";
		std::cin >> arr_length;

		*(length_arr + i) = arr_length;

		tmp_arr[i] = fill_arr(arr_length);
	}
	return tmp_arr;
}




int* fill_arr(int arr_length)
{
	int* arr = new int[arr_length] {};

	for (size_t i = 0; i < arr_length; i++)
	{
		int value = {};

		std::cout << "Enter:" << " " << i + 1 << " " << "value of array => ";
		std::cin >> value;

		*(arr + i) = value;
	}

	return arr;
}

void print_jagged_arr(int** multi_arr, int row_length, int* length_arr)
{
	for (size_t i = 0; i < row_length; i++)
	{
		for (size_t j = 0; j < *(length_arr + i); j++)
		{
			std::cout << *(*(multi_arr + i) + j) << " ";
		}
		std::cout << std::endl;
	}
}


void print_arr(int* arr, int arr_length)
{
	for (size_t i = 0; i < arr_length; i++)
		std::cout << *(arr + i) << " ";
	std::cout << std::endl;
}
