#include <iostream>
#include "my_lib.h"

// Выводит зубчатый массив, при условии что все его элементы одного размера.

/*
void print_arr(int* arr, int length)
{
	for (int i = 0; i < length; i++)
	{
		std::cout << *(arr + i) << " ";
	}
	std::cout << std::endl;
}
*/

/*
void show_jagged(int** arr, int* length_arr, int length)
{
	for (int i = 0; i < length; i++)
	{
		print_arr(*(arr + i), *(length_arr + i));
	}
}
*/


void print_arr(int* arr, int length)
{
	for (int i = 0; i < length; i++)
	{
		std::cout << *(arr + i) << " ";
	}
	std::cout << std::endl;
}


void print_jagged(int** arr, int count, int* arr_length)
{
	for (int i = 0; i < count; i++)
	{
		print_arr(*(arr + i), *(arr_length + i));
	}
}

int** fill_arr(int row_count, int* arr_length)
{
	int** tmp_arr = new int* [row_count] {};

	for (int i = 0; i < row_count; i++)
	{
		int row_length = 0;
		std::cout << "Enter length of row array: ";
		std::cin >> row_length;

		*(tmp_arr + i) = new int[row_length] {}; // tmp_arr[i] = new int[row_length]{};

		*(arr_length + i) = row_length; // arr_length[i] = row_length;

		for (int j = 0; j < row_length; j++)
		{
			int num = 0;
			std::cout << "Enter your number: ";
			std::cin >> num;

			*(*(tmp_arr + i) + j) = num; // tmp_arr[i][j] = num;
		}
	}
	return tmp_arr;
	delete[] tmp_arr;
}

int main()
{
	setlocale(LC_ALL, "ru");

	int row_count = 0;
	std::cout << "Enter length of your jagged array: ";
	std::cin >> row_count; // Ввожу кол-во массивов внутри jagged-array

	int* arr_length = new int[row_count] {}; // Создаю массив из длин внутренних массивов


	int** arr = fill_arr(row_count, arr_length); // Вызываю fill_array и записываю все в переменную
	print_jagged(arr, row_count, arr_length); // Печатаю


}

/*
	int arr[2][2] = { { 1, 2 }, { 3, 4 } }; // статичный многомерный массив

	std::cout << arr << " " << &arr << '\n';
	std::cout << arr + 1 << " " << &arr + 1 << '\n';
	*/

	/*
	// Статичный Jagged array.
	int* arr[2] = { new int[2]{1, 2}, new int[2]{3, 4} };

	std::cout << arr << " " << &arr << '\n';
	std::cout << arr + 1 << " " << &arr + 1 << '\n';

	std::cout << **arr << " " << *(*arr + 1) << '\n';
	std::cout << **(arr + 1) << " " << *(*(arr + 1) + 1) << '\n';

	// Динамичный jagged array.
	int** arr2 = new int* [2]{ new int[2]{1, 2}, new int[2]{3, 4} };

	std::cout << arr2 << " " << &arr2 << '\n';
	std::cout << arr2 + 1 << " " << &arr2 + 1 << '\n';

	std::cout << *(*arr2) << " " << *(*arr2 + 1) << '\n'; // 1  2
	std::cout << **(arr2 + 1) << " " << *(*(arr2 + 1) + 1) << '\n';// 3 4
	*/

	/*
	int row;
	std::cout << "Enter length of jagged array: ";
	std::cin >> row;
	int** arr = new int* [row]{ };

	for (int i = 0; i < row; i++)
	{
		int col = 0;
		std::cout << "Enter length of sub-array: ";
		std::cin >> col;
		arr[i] = new int[col] {};
	}
	*/

	/*
	int** arr = new int* [2]{};

	for (int i = 0; i < 2; i++)
	{
		arr[i] = new int[2]{};
	}


	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 2; j++)
		{
			std::cout << arr[i][j] << " ";
		}
		std::cout << std::endl;
	}
	*/

	/*
	int** arr = new int* [2]{};

	*arr = new int[2]{ 1, 2 }; // arr - pointer to first element, *arr - dereference of first element
	*(arr + 1) = new int[2]{ 3, 4 }; // arr + 1 - pointer to second element, *(arr + 1) - dereference of first element

	std::cout
		<< "arr is: Pointer to first element: " << arr << '\n'
		<< "&arr: Address of pointer to pointer of first element " << &arr << '\n'
		<< "*arr: Address of pointer to first element: " << *arr << '\n'
		<< "**arr: Dereference of pointer to pointer of first element, which is - " << **arr << '\n'
		<< "*(*arr + 1): Dereference of pointer to pointer of second element, which is - " << *(*arr + 1) << '\n'
		<< "**(arr + 1): Разыменовывание указателя второго элемента, который указывает на 3" << **(arr + 1) << '\n'
		<< "*(arr + 1)" << *(arr + 1) << " - " << **(arr + 1) << '\n'
		<< "*(*(arr + 1) + 1) " << *(arr + 1) + 1 << " - " << *(*(arr + 1) + 1) << '\n';
	*/

	/*
	int** arr = new int* [2]{};

	arr = fill_arr(arr, 2, 2);
	print_arr(arr, 2, 2);

	int* arr2 = new int[3]{ 1, 2, 3 };

	for (int* p_arr = arr2; p_arr < arr2 + 3; p_arr++)
	{
		std::cout << *p_arr << " ";
	}
	*/

	//for (int i = 0; i < 2; i++)
	//{
	//	for (int j = 0; j < 2; j++)
	//	{
	//		std::cout << arr[i][j] << " ";
	//	}
	//	std::cout << std::endl;
	//}
