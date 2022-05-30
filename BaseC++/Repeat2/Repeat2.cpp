#pragma region Struct_Array
/*
#include <iostream>

enum CPU { CoreI3, CoreI5, CoreI7, Ryzen3, Ryzen5, Ryzen7 };
enum GPU { AMD, NVIDIA };

struct Computer
{
	char* make;
	char* model;
};

Computer add_pc()
{
	Computer tmp_pc;

	tmp_pc.make = new char[1024]{};
	tmp_pc.model = new char[1024]{};


	printf("Enter pc make: ");
	scanf_s("%s", tmp_pc.make, 1024);

	printf("Enter pc model: ");
	scanf_s("%s", tmp_pc.model, 1024);

	return tmp_pc;
}

void print_pc(Computer pc)
{
	printf("%s%c", pc.make, '\n');
	printf("%s%c", pc.model, '\n');
}

int main()
{
	Computer computers[2]{};

	for (int i = 0; i < 2; i++)
	{
		std::cin.ignore();
		computers[i] = add_pc();
	}


	for (int i = 0; i < 2; i++)
	{
		print_pc(computers[i]);
	}


	return 0;
}
*/

#pragma endregion

#pragma region Files
/*
#include <iostream>


int main()
{
	FILE* my_file;
	char* read = new char[1024]{};

	fopen_s(&my_file, "data.txt", "a+");

	if (my_file != nullptr)
	{
		while (fgets(read, 1024, my_file))
		{
			std::cout << read;
		}
	}

	if (my_file != nullptr)
	{
		fclose(my_file);
	}

	std::cout << read;


	return 0;
}
*/

#pragma endregion

#pragma region Struct sorting
/*
#include <iostream>


struct Computer
{
	int price;
	char* make;
	char* model;
};


void print_pc(Computer pc)
{
	printf("%s%c", pc.make, '\n');
	printf("%s%c", pc.model, '\n');
}

int main()
{
	Computer computers[2]{};

	computers[0].make = new char[] {"Lenovo"};
	computers[0].model = new char[] {"Ideapad 3"};
	computers[0].price = 1650;


	computers[1].make = new char[] {"Asus"};
	computers[1].model = new char[] {"ROG G15"};
	computers[1].price = 2400;


	std::cout << "Before" << std::endl;

	for (int i = 0; i < 2; i++)
	{
		std::cout << computers[i].make << '\n';
	}

	Computer tmp;

	for (int i = 0; i < 2; i++)
	{
		if (computers[i].price < computers[i + 1].price)
		{
			tmp = computers[i];
			computers[i] = computers[i + 1];
			computers[i + 1] = tmp;
		}
	}


	std::cout << "After" << std::endl;

	for (int i = 0; i < 2; i++)
	{
		std::cout << computers[i].make << '\n';
	}


	return 0;
}
*/
#pragma endregion

#pragma region refernce_in_funcs
/*
#include <iostream>


void change_num(int &number)
{
	number = 5;
}


void change_num(int* number)
{
	*number = 10;
}


int main()
{
	int number = 0;

	std::cout << "Before: " << number << std::endl;
	change_num(number);
	std::cout << "After: " << number << std::endl;

	number = 0;

	std::cout << "Before: " << number << std::endl;
	change_num(&number);
	std::cout << "After: " << number << std::endl;

	return 0;
}
*/


#pragma endregion

#pragma region Vopros_Orxana
/*
#include <iostream>
#include <cstdio>



void print_letter(char*& letter)
{
	std::cout << *letter << ' ';
}


int main()
{
	char** text = new char* [2]{};

	for (int i = 0; i < 2; i++)
	{
		*(text + i) = new char[30]{};
	}

	for (int i = 0; i < 2; i++)
	{
		std::cin.ignore();
		std::cout << " Enter " << i + 1 << " sentence: ";
		gets_s(*(text + i), 15);
	}

	for (int i = 0; i < 2; i++)
	{
		puts(*(text + i));
	}


	std::cout
		<< "text: " << text << std::endl
		<< "text[0]: " << text[0] << std::endl
		<< "*text[0]: " << *text[0] << std::endl
		<< "&text[0]: " << &text[0] << std::endl
		<< "*&text: " << *&text << std::endl;

	for (int i = 0; i < 2; i++)
	{
		print_letter(*(*&text + i));
	}



	return 0;
}




*/


#pragma endregion 

#pragma region Struct



/*
#include <iostream>

struct Test
{
	int a; // 8 byte(4 byte)
	long long int b; // 8 byte(0 byte)
	int c; // 8 byte(4 byte)
	int d; //  4 byte(0 byte)
	int f; // 8 byte (4 byte)
	char e; // 1 byte( 3 byte)
	short k; // 2 byte(1 byte)
	char j; // 1 byte(0 byte)
};


struct Test
{
	short b; // 8 byte( 6 byte)
	char a1[30]; // 15 byte (1)
	short d[2]; // 8 byte(4)
	char f[2]; // 0
	short k; // 0
	long long int c[5]; // 40 byte
};



struct Test
{
	char a;
	char a1;
	char a3;
	short c;
	int b;
};

int main()
{
	std::cout << sizeof(Test) << std::endl;
}

*/
#pragma endregion

#pragma region Const_pointer

	/*
#include <iostream>

int main()
{
	// Константный указатель
	int a = 50;


	int* c = &a;
	const int* b = &a;

	*c = 15;

	std::cout << *b << std::endl;
	std::cout << *c << std::endl;
	std::cout << a << std::endl;
	*/


	// Указатель на константу 

	/*
	const int a = 50;

	const int* b = &a;


	const int** c = &b;


	return 0;
}

*/
#pragma endregion