#include <iostream>
#include "my_lib.h"

void print_arr(int** arr, int row, int col)
{
	for (int i = 0; i < row; i++)
	{
		for (int j = 0; j < col; j++)
		{
			std::cout << arr[i][j] << " ";
		}
		std::cout << std::endl;
	}
}

int** fill_arr(int** arr, int row, int col)
{
	int counter = 0;

	for (int i = 0; i < row; i++)
	{
		arr[i] = new int[col];
	}

	for (int i = 0; i < row; i++)
	{
		for (int j = 0; j < col; j++)
		{
			counter++;
			arr[i][j] = counter;
		}
	}
	return arr;
}