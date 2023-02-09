#include <iostream>
#include <time.h>

using namespace std;


int main()
{
	srand(time(NULL));

	/*
	// Arrays lesson 2 - ѕовтор и закрепление одномерных массивов.

	// Array(массив) - последовательность элементов одного типа данных.

	// How to create an array ??

	// Method 1 - «адаем значени€, но не задаем длину !!
	int arr[] = { 1, 2, 3, 4, 5};

	// Method 2 - «адаем длину и значени€ !!
	// если не передать все 5 элементов, остальные будут 0 - это и есть инициализаци€
	// если передать больше чисел, чем есть длина, то будет ошибка компил€ции
	int arr[5] = { 1, 2, 3, 4, 5 };

	// Method 3 - «адаем длину, но не задаем значени€, при этом инициализируем
	// ¬ данном случай в массиве будут только 0. ƒанный метод достаточно часто используетс€

	int arr[5] = {};

	// Method 4 - «адаем длину, не задаем значени€, не инициализируем.
	int arr[5];

	// ѕравила !!! - 1. ƒлина должна быть константной, 2. Ќе забывайте про type casting


	const int length = 5;

	int arr[length] = {5, 'a', true, 3.25}; // 5 97 1 3 0

	for (int i = 0; i < length; i++)
	{
		cout << arr[i] << " ";
	}

	*/

	/*
	const int length = 10;
	int arr[length] = {};


	for (int i = 0; i < length; i++)
	{
		arr[i] = rand() % 10 + 1;
	}


	for (int i = 0; i < length; i++)
	{
		cout << arr[i] << " ";
	}

	*/

	/*
	const int length = 5;
	int index = 0, value = 0;
	char choice = 0;

	int arr[length] = { 11, 22, 33, 44, 55 };

	while (true)
	{


		cout << "Choose value to edit: " << endl;

		for (int i = 0; i < length; i++)
		{
			cout << i + 1 << '.' << arr[i] << endl;
		}
		cin >> index;

		cout << "Enter new value: ";
		cin >> value;

		arr[index - 1] = value;


		cout << "New array: ";
		for (int i = 0; i < length; i++)
		{
			cout << arr[i] << " ";
		}

		cout << "Do  you want to exit ? Y/N" << endl;
		cin >> choice;

		if (choice == 'Y' || choice == 'y')
		{
			break;
		}
	}
	*/

	/*
	const int length = 5;
	int arr[length] = {};

	for (int i = 0; i < length; i++)
	{
		cout << "Enter " << i + 1 << " number: ";
		cin >> arr[i];
		cout << endl;
	}

	for (int i = 0; i < length; i++)
	{
		cout << arr[i] << " ";
	}
	*/


	// Onedimensional - multidimensional

	//int arr[] = { 1, 2, 3, 4, 5 }; // 20 byte

	// многомерный массив - это один или более массив внутри другого массива.

	//int arr[2][2] = { {1, 2},
	//   			  {3, 4} };
	// i - ый, j - ый



	/*
	const int length = 10;
	int arr[10] = {};
	int start = 0, end = 0;

	cout << "Enter start of random: ";
	cin >> start;

	cout << "Enter end of random: ";
	cin >> end;

	for (int i = 0; i < length; i++)
	{
		arr[i] = rand() % (end - start + 1) + start;
	}
*/

// SORTING
// Bubble sort 
	/*
	while (swapped)
	{
		swapped = false;
		for (int j = 0; j < length - 1; j++)
		{
			if (arr[j] > arr[j + 1])
			{
				tmp = arr[j];
				arr[j] = arr[j + 1];
				arr[j + 1] = tmp;
				swapped = true;
			}
		}
	}


	for (int i = 0; i < length; i++)
	{
		for (int j = 0; j < length - 1; j++)
		{
			if (arr[j] > arr[j + 1])
			{
				tmp = arr[j];
				arr[j] = arr[j + 1];
				arr[j + 1] = tmp;
			}
		}
	}
	*/
	// selection sort
		/*

		for (int i = 0; i < length; i++)
		{
			lowest_index = i;

			for (int j = i + 1; j < length; j++)
			{
				if (arr[j] < arr[lowest_index])
					lowest_index = j;
			}
				tmp = arr[i];
				arr[i] = arr[lowest_index];
				arr[lowest_index] = tmp;
		}
		*/


		/*
			clock_t start = clock();

			const int length = 5;
			int arr[length] = {8, 9, 1, 5, 12};
			int lowest_index = 0;
			int tmp = 0;
			int value_to_insert = 0;
			int j = 0;

			for (int i = 0; i < length; i++)
			{
				arr[i] = rand() % 10 + 1;
			}


			for (int i = 0; i < length; i++)
			{
				cout << arr[i] << " ";
			}
			cout << endl;

			// insertion
			for (int i = 1; i < length; i++)
			{
				value_to_insert = arr[i];

				j = i - 1;

				while (j >= 0 && arr[j] > value_to_insert)
				{
					arr[j + 1] = arr[j];
					j--;
				}
				arr[j + 1] = value_to_insert;
			}




			for (int i = 0; i < length; i++)
			{
				cout << arr[i] << " ";
			}
			cout << endl;



			printf("%.2fs", (float)(clock() - start) / CLOCKS_PER_SEC);

		*/

		//int mobile_arr[2] = { 773251018, 553251018 };
		//int home_arr[2] = { 4060304, 4060102 };

		// по мобильным
		// 1. 553251018, 773251018 
		// 2. 4060102, 4060304 

		// по домашним
		// 1. 773251018, 553251018
		// 2. 4060102, 4060304 

	//int arr[] = { 1, 2, 3, 4, 5 };

	/*int multi_arr[3][5] = {	{4, 2, 8, 3, 9},
							{3, 1, 9, 4, 7},
							{5, 2, 9, 0, 1} };*/

							// 5  * 2 + 1
							// column_amount * i + j
							// 5 * 1 + 3 = 8
							// 5 * 1 + 1 = 6

/*
	const int rows = 3;
	const int cols = 5;
	int tmp = 0;

	int multi_arr[3][5] = { {4, 2, 8, 3, 9},
							{3, 1, 9, 4, 7},
							{5, 2, 9, 0, 1} };


	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < cols; j++)
		{
			cout << multi_arr[i][j] << " ";
		}
		cout << endl;
	}
	cout << endl;


	for (int k = 0; k < cols; k++)
	{

		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < cols - 1; j++)
			{
				if (multi_arr[i][j] > multi_arr[i][j + 1])
				{
					tmp = multi_arr[i][j];
					multi_arr[i][j] = multi_arr[i][j + 1];
					multi_arr[i][j + 1] = tmp;
				}
				//for (int k = 0; k < cols; k++)
				//{

				//}
			}
		}
	}


	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < cols; j++)
		{
			cout << multi_arr[i][j] << " ";
		}
		cout << endl;
	}
*/

const int length = 10;
int arr[10] = {};
int lowest_index = 0;
int tmp = 0;

for (int i = 0; i < length; i++)
{
	arr[i] = rand() % 10;
}

for (int i = 0; i < length; i++)
{
	cout << arr[i] << " ";
}
cout << endl;



for (int i = 0; i < length; i++)
{
	lowest_index = i;

	for (int j = i + 1; j < length; j++)
	{
		if (arr[j] < arr[lowest_index])
			lowest_index = j;
	}
	tmp = arr[i];
	arr[i] = arr[lowest_index];
	arr[lowest_index] = tmp;
}


for (int i = 0; i < 10; i++)
{
	cout << arr[i] << " ";
}
cout << endl;

	return 0;
}


