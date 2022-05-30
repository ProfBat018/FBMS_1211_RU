#include "multy_arr_funcs.h"
#include "jagged_arr_funcs.h"
#include <iostream>

int** fill_multy_arr(int row_length, int col_length)
{
	int** tmp_arr = new int* [row_length] {};

	for (size_t i = 0; i < row_length; i++)
	{
		*(tmp_arr + i) = fill_arr(col_length);
	}
	return tmp_arr;
}

void print_multy_arr(int** arr, int row_length, int col_length)
{
	for (size_t i = 0; i < row_length; i++)
	{
		print_arr(*(arr + i), col_length);
	}
}


