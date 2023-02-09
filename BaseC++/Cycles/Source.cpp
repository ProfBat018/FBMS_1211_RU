#include <iostream>
#include "time.h"
#include "windows.h"

using namespace std;

int main()
{
	// Cycle(цикл) - Код, который повторется n раз.
	// Зачем нам это надо ? Автоматизация, упрощение, ускорение.

	// Какие циклы есть - for, while, do while

	// Debug - пошаговый выполнение кода.

	// while
	/*
	int i = 0;

	while (i != 10) // while - цикл с условием
	{
		i++;
		cout << i << endl;
	}
	*/

	/*
	while (true)
	{
		cout << "Hello World" << endl;
	}
	*/


	/*int i = 0;
	int j = 0;

	while (i != 5)
	{
		while (j != 5)
		{
			cout << i << " " << j << endl;
			j++;
		}
		if (i == 4)
		{
			continue;
		}

		i++;
	}*/

	/*
	int first_num = 0, second_num = 0;
	int result = 0, choice = 0;
	bool exit = false;

	while (!exit) // exit != true
	{
		cout << "Enter first number: ";
		cin >> first_num;

		cout << "Enter second number: ";
		cin >> second_num;

		cout << "Enter your operation:" << endl
			<< "1. Addition" << endl
			<< "2. Subtraction" << endl
			<< "3. Break" << endl;
		cin >> choice;


		switch (choice)
		{
		case 1:
			result = first_num + second_num;
			break;
		case 2:
			result = first_num - second_num;
			break;
		case 3:
			exit = true;
			break;
		default:
			cout << "Error, type again..." << endl;
			continue;
		}

		cout << "Result = " << result << endl;
	}
	*/


	// do while


	/*
	int num1 = 0, num2 = 0, result = 0;
	int choice = 0;

	bool exit = true;

	do
	{

		cout << "Enter first number: ";
		cin >> num1;

		cout << "Enter second number: ";
		cin >> num2;


		cout << "1.addition" << endl
			<< "2. subtraction" << endl
			<< "3. exit" << endl;
		cin >> choice;


		switch (choice)
		{
		case 1:
			result = num1 + num2;
			break;
		case 2:
			result = num1 - num2;
			break;
		case 3:
			exit = true;
			break;
		default:
			cout << "Error" << endl;
			result = 404;
			break;
		}
		cout << "Result is: " << result << endl;

	} while (!exit); // (exit == false or exit != true) это одно и то же
	*/


	/*
	while (!exit)
	{
		cout << "Enter first number: ";
		cin >> num1;

		cout << "Enter second number: ";
		cin >> num2;


		cout << "1.addition" << endl
			<< "2. subtraction" << endl
			<< "3. exit" << endl;
		cin >> choice;


		switch (choice)
		{
		case 1:
			result = num1 + num2;
			break;
		case 2:
			result = num1 - num2;
			break;
		case 3:
			exit = false;
			break;
		default:
			cout << "Error" << endl;
			result = 404;
			break;
		}
		cout << "Result is: " << result << endl;

	}
	*/

	/*
		int i =	0;
		do
		{
			int j = 0;

			cout << ++j;
			i++;

		} while (i != 10);
	*/

	// for 
	// while and do while - cycle with condition
	// for - cycle with parameters 

	/*
	for (int i = 0; i < 5; i++) // initialize int i = 0, condition i < 10, iteration i++
	{
		for (int j = 0; j < 5; j++)
		{
			cout << i << " " << j << endl;
		}
	}


	int i = 0;
	int j = 0;
	while (i < 5)
	{
		j = 0;
		while (j < 5)
		{
			cout << i << " " << j << endl;
			j++;
		}
		i++;
	}
*/


// break and continue

	/*
int start = 0;
int end = 10;

while (start < end)
{
	start++;
	if (start == 7)
		continue;
	cout << start;
}
*/

/*
// все четные, нечетные, кратные 10.
int start = 0, end = 0;

cout << "Enter start: ";
cin >> start;

cout << "Enter end: ";
cin >> end;


cout << "Even: ";
int i = start;
while (i < end)
{
	if (i % 2 == 0)
	{
		cout << i << " ";
	}
	i++;
}

cout << "ODD: ";
i = start;
while (i < end)
{
	if (i % 2 != 0)
	{
		cout << i << " ";
	}
	i++;
}
*/

/*
for (int i = 0; i < 10; i++) // analog of range(start, end, step)
{
	cout << i << endl;
	// i++ and i+=1 the same thing
}

for (int i = 0; i < 3; i++)
{
	for (int j = 0; j < 3; j++)
	{
		for (int k = 0; k < 3; k++)
		{
			cout << i << " " << j << " " << k << endl;
		}
	}
}
*/

// kiss - keep it simple stupid 
// dry - don't  repeat yourself

	/*
int num1, num2, num3;
cin >> num1;
cin >> num2;
cin >> num3;

cout << num1 << " " << num2 << " " << num3 << endl;
*/

/*
srand(time(NULL)); // Сброс времени на секунду старта программы.

int a = 0;

a = rand() % 2;

cout << a << endl;

cout << a;
*/

/*
for (int i = 0; i < 10; i++)
{
	cout << time(NULL) << endl;
	Sleep(1000);

}
*/

/*
	srand(time(NULL));

	int a = rand() % 123456789;
	cout << a << " ";
	Sleep(1000);

	srand(a);

	int b = rand() % 100;
	cout << b << " ";
*/

/*
	for (int i = 0; i < 10; i++)
	{
		for (int i = 0; i < 10; i++)
		{
			cout << "*";
		}
		cout << endl;
	}
*/


// ENUM - enumerable (перечисляемый тип двнных)

	/*
	enum Color1 {RED = 1, GREEN, BLUE};


		int num = 0;

		cout << "1.RED: " << endl
			<< "2.GREEN" << endl
			<< "3.BLUE" << endl;
		cin >> num;

		switch (num)
		{
		case RED:
			cout << "RED";
			break;
		case Color1::GREEN:
			cout << "GREEN";
			break;
		case Color1::BLUE:
			cout << "BLUE";
			break;
		}
	*/

	// LIST - тип данных, который хранит в себе проидексированные значения любого типа данных.
	// ARRAY - массив, то есть последовательность из значений одного типа дпнных.

/*
	int arr[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // статический массив, static array

	for (int i = 0; i < 10; i++)
	{
		cout << arr[i] << " ";
	}
*/

/*
const int length = 10;

int arr[length];

for (int i = 0; i < length; i++)
{
	cin >> arr[i];
}

for (int i = 0; i < length; i++)
{
	cout << arr[i] << endl;
}
*/

/*

	int result = {};
	const int length = { 10 };

	int arr[length] = { 1, 2, true, 'a', 3.25 };

	for (int i = 0; i < length; i++)
	{
		cout << arr[i] << endl;
	}
*/

/*
int num{ 1 };
int num2{ 2 };
int result{};

result = num + num2;

cout << result;
*/


//const int length = 10;

/*
int arr[] = {1, 2, 3};
char arr2[] = { 'a', 'b', 'c' };


int all_size = sizeof(arr);
int first_size = sizeof(arr[0]);

int length = all_size / first_size;
*/

	return 0;
}
