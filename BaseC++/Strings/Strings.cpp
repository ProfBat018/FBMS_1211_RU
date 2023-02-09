#include <iostream>
#include <string>
#include <cstdio>



int main()
{

#pragma region Статичные строки
	/*
	char name[] = "Elvin";
	char name2[] = { 'E', 'l', 'v' ,'i', 'n', '\0'};

	std::cout << name << std::endl;
	std::cout << name2;
	*/

#pragma endregion

#pragma region Динамичные строки
	/*
		char* name = new char[] {"Elvin"};

		int* arr = new int[] {1, 2, 3};

		std::cout << name << std::endl;
	*/


#pragma endregion 

#pragma region Очень динамичные строки
	/*
		char** names = new char* []
		{
				new char[] {"Elvin"},
				new char[] {"Ilkin"},
				new char[] {"Orxan"},
				new char[] {"Tamerlan"},
				new char[] {69, 108, 118, 105, 110, 0}
		};


		for (size_t i = 0; i < 5; i++)
		{
			std::cout << names[i] << std::endl;
		}
	*/

	/*
	// Старый метод. Небезопасный
	char str1[] = "Sample string";
	char str2[14];
	strcpy(str2, str1);
	*/

#pragma endregion 

#pragma region String methods
	// Новый метод. Безопасный

	// Copy
	/*
	char str1[] = "Sample string";

	char str2[14];
	char str3[28];

	strcpy_s(str2, 14, str1);
	*/

	// Concatination
	/*
	char str1[6] = "Elvin";
	char str2[12] = "Ilkin";

	strcat_s(str2, 12, str1);

	std::cout << str2;
	*/

	// First entry of symbol
	/*
	char str[] = "Elvin";

	char symbol = 'v';

	char* result = strchr(str, symbol);

	std::cout << result;
	*/


	// First entry of string
	/*
	char str1[] = "Elvin Azimov";

	char str2[] = "vin";

	char* result = strstr(str1, str2);

	std::cout << result;
	*/

#pragma endregion 

#pragma region Input-output of strings
	// Functions from C
/*
	char str[100]{};

	gets_s(str, 100); //  Input - Buffer, Buffer Size

	puts(str); // Output
*/

/*
	char* str = new char[1024] {};

	gets_s(str, 1024);

	puts(str);
*/

/*
	char* str2 = new char[1024]{};

	std::cin.getline(str2, 1024);

	std::cout << str2;

*/

#pragma endregion 

#pragma region C++_chamber_of_secret_strings
/*
std::string text; // Показываю, но нельзя использовать. Увижу поставлю 1 балл.

std::getline(std::cin, text);

std::cout << text << std::endl;

std::cout << text.capacity();
*/

#pragma endregion

	char** text = new char* [2]{};

	for (int i = 0; i < 2; i++)
	{
		text[i] = new char[150]{};

		gets_s(text[i], 150);
	}



	for (int i = 0; i < 2; i++)
	{
		puts(text[i]);
	}
}
