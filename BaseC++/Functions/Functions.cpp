#include <iostream>
#include <time.h>
#include "Mylib.h"

// Function overloading - перегрузка функций 
// Когда есть два или более функций с одинаковыми названиями, но отличающийся по:

// by count of parameters - по числу параметров
/*
int add_num(int number1, int number2)
{
	return number1 + number2;
}

int add_num(int number1, int number2)
{
	return number1 + number2;
}
*/
// by type of parameters - по типу параметров 

/*
int add_num(int number1, int number2)
{
	return number1 + number2;
}

float add_num(float number1, float number2)
{
	return number1 + number2;
}
*/
// by sequence - по последовательности
/*
int add_num(int number1, float number2)
{
	return number1 + number2;
}

int add_num(float number1, int number2)
{
	return number1 + number2;
}
*/

// Inline Functions
/*
inline int add_num(int number1, float number2)
{
	return number1 + number2;
}
*/

// Правила вызова inline ф-й
/*
* 1. Ф-я должна быть максимально маленькой
* 2. Ф-я не должна состоять из условий, циклов, перенключателей и т.д и т.п.
* 3. ТО ЧТО ВЫ НАПИСАЛИ СЛОВО INLINE НЕ ДЕЛАЕТ ЕГО INLINE, ТАК КАК КОМПИЛЯТОР САМ ЭТО РЕШАЕТ
*/
/*
inline int say_hello()
{
	return 5 + 5;
}

int say_hello2()
{
	return 5 + 5;
}
*/

// Template fucntions - шаблонные функции
// dry - do not repeat yourself


template<typename T1, typename T2> // T - это шаблонный тип данных, созданный нами. Он превратится в то, что получит
T1 add_num(T1 number1, T2 number2)
{
	return number1 + number2;
}


/*
template<typename T>
void test(T number)
{
	std::cout << typeid(number).name() << std::endl;
}
*/

// Рекурсия - функция, которая вызывает саму себя 
// При рекурсии обязательно должга быть точка выхода.
/*
int add(int num)
{
	if (num == 0)
	{
		return 0;
	}
	std::cout << num << std::endl;
	num -= 1;
	add(num);
}

void add2(int num)
{
	for (int i = num; i >= 0; i--)
	{
		std::cout << i << std::endl;
	}
}
*/

const int row = 2;
const int col = 2;


void print_multi_arr(int arr[row][col])
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

int main()
{
	int arr[row][col] = { {1, 2}, {3, 4} };

	print_multi_arr(arr);

	return 0;
}



