#include <iostream>


void reverse_orig(int* arr, int length)
{
	int* tmp_arr = new int[length];

	for (int i = 0, j = length - 1; i < length; i++, j--)
	{
		*(tmp_arr + i) = *(arr + j);
	}

	for (int i = 0; i < length; i++)
	{
		*(arr + i) = *(tmp_arr + i);
	}
	delete[] tmp_arr;
}


int* reverse_arr(int* arr, int length)
{
	int* tmp_arr = new int[length];

	for (int i = 0, j = length - 1; i < length; i++, j--)
	{
		*(tmp_arr + i) = *(arr + j);
	}
	return tmp_arr;
}

void print_arr(int* arr, int length)
{
	for (int i = 0; i < length; i++)
	{
		std::cout << *(arr + i) << " ";
	}
	std::cout << std::endl;
}

int main()
{
	int length = 5;
	int* arr = new int[length] {1, 2, 3, 4, 5};

	int* new_arr = reverse_arr(arr, length);
	print_arr(new_arr, length);
}
