#include <cstdio>

int main()
{
	// Simple print example 
	//printf("Hello, Orxan");


	/*
		%d - для печати целых чисел
		%f - для печати вещественных чисел
		%c - для печати символов
		%s - для печати строк
	*/

#pragma region integer_variable_print_example 
	/*
	int ilkin = 12;
	int emil = 1;

	printf("Ilkin polucaet %d ballov, Emil ne polucaet %d ballov", ilkin, emil);
	*/
#pragma endregion

#pragma region char_and_int_print
	/*
		int ilkin = 12;

		printf("Ilkin polucaet %d%c ballov", ilkin, '\n');
	*/
#pragma endregion

#pragma region string_print
	/*
	char* name = new char[] {"Elvin"};
	char* surname = new char[] {"Azimov"};
	int age = 19;


	//printf("Name is: %s%cSurname is: %s%cAge is: %d", name, '\n', surname, '\n', age);


	printf("Name is: %s%c", name, '\n');
	printf("Surname is: %s%c", surname, '\n');
	printf("Age is: %d%c", age, '\n');
	*/


#pragma endregion

#pragma region float_print

	/*
	float  a = 3.256666666666f;

	int input = 2;

	char length = 48 + input;
	char* formater = new char[] {'%', '.', length, 'f', '\0'};

	printf(formater, a);
	*/


#pragma endregion


#pragma region input

	/*
	char ilkin{};

	scanf_s("%c", &ilkin, 1);

	printf("%c", ilkin);
	*/

	char* array = new char[1024]{};

	scanf_s("%s", array, 1024);

	printf("%s", array);


#pragma endregion

	return 0;
}
