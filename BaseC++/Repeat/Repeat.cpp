#include <iostream>
#include "jagged_arr_funcs.h"
#include "multy_arr_funcs.h"
#include <time.h>

/*
void fill_arr(int* arr, int length);
void print_arr(int* arr, int length);
*/



int main()
{
#pragma region JaggedArrays
	// Все функции этого региона в отдельном файле 

	/*
	int arr[2][2] // статичный многгомерный массив
	{
		{1, 2},
		{3, 4}
	};


	int** arr2 = new int* [2]{}; // динамичный, многомерный массив. Так как, каждый его элемент одной длины

	arr2[0] = new int[4]{};
	arr2[1] = new int[4]{};


	int** arr3 = new int* [2]{}; // Зубчатый массив, так как длина каждого внутреннего массива разная.

	arr3[0] = new int[2]{};
	arr3[1] = new int[5]{};
	*/

	/*
	int row_length = {};

	int* length_arr = new int[row_length] {};

	std::cout << "Enter row length: ";
	std::cin >> row_length;

	int** arr = fill_jagged_arr(row_length, length_arr);

	print_jagged_arr(arr, row_length, length_arr);
	*/



#pragma endregion


#pragma region MultiArrays

	/*
	int row_length{}, col_length{};

	std::cout << "Enter length of row: ";
	std::cin >> row_length;

	std::cout << "Enter length of column: ";
	std::cin >> col_length;

	int** arr = fill_multy_arr(row_length, col_length);

	print_multy_arr(arr, row_length, col_length);
	*/


#pragma endregion





	return 0;

}

//  Разкоментируйте все нижнее для работы

/*
		int length = 0;

		std::cout << "Enter length of array: ";
		std::cin >> length;

		int* arr = new int[length] {};

		print_arr(arr, length);
		fill_arr(arr, length);
		print_arr(arr, length);
		*/

		/*
		std::cout << R"###(
		Elvin
		Azimov
		Rasul
						)###";


			std::cout << std::endl;

			std::cout
				<< "Elvin" << '\n'
				<< "Azimov" << '\n'
				<< "Rasul" << '\n';
			*/

			/*
					void  fill_arr(int* arr, int length)
					{
						for (int* p_arr = arr, i = 0; p_arr < arr + length; p_arr++, i++)
						{
							*p_arr = i + 1;
						}
					}

					void print_arr(int* arr, int length)
					{
						for (int i = 0; i < length; i++)
						{
							std::cout << *(arr + i) << " ";
						}
						std::cout << std::endl;
					}
					*/