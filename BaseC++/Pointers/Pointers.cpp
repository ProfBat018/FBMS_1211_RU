// Pointers part 1 
/*
#include <iostream>


int test(int num)
{
	std::cout << "Test called" << std::endl;
	return num == 10 ? 0 : test(num + 1);
}

void print_arr(int* arr, int length);
void fill_arr(int* arr, int length);
void addition1(int* n1, int* n2);
void addition2(int n1, int n2);
void addition3(int& n1, int& n2);


int main()
{
	// * оператор разыменовывания. Dereference operator

	int a = 5;

	std::cout << a << std::endl;

	// & - показывает адрес переменной в RAM
	std::cout << &a << std::endl;




	int a = 6;

	int* p_a = &a;

	std::cout << &a << " " << p_a << std::endl;
	std::cout << a << " " << *p_a << std::endl;



	long long int arr[5] = { 1, 2, 3, 4, 5 };

	for (int i = 0; i < 5; i++)
	{
		std::cout << *(arr + i) << std::endl;
	}

	for (long long int* p_arr = arr; p_arr < arr; p_arr++)
	{
		std::cout << *p_arr << std::endl;
	}



	int a = 5;

	int* p_a = &a;



	std::cout << &a << " " << *(&a) << std::endl;
	std::cout << &p_a << " " << *(&p_a) << std::endl; // *(&p_a) = p_a


	std::cout << arr << " " << sizeof(arr) << std::endl;
	std::cout << &arr << " " << sizeof(&arr) << std::endl;


	std::cout << *(arr + 1) << " " << arr + 1 << std::endl; // 1
	std::cout << *(&arr + 1) << " " << &arr + 1 << std::endl; // 2



	std::cout << &arr << " " << &arr + 1 << " " << &arr + 1 << std::endl;
	std::cout << *(&arr) << " " << *(&arr + 1) << " " << *(&arr + 1) << std::endl;



	std::cout << &arr[0] << " " << &arr[1] << " " << &arr[4] << std::endl;
	std::cout << &arr << " " << arr + 1 << " " << &arr + 1 << std::endl;



	for (int i = 0; i < 6; i++)
	{
		std::cout << arr + i << " ";
	}
	std::cout << std::endl;

	std::cout << arr + 1 << std::endl;
	std::cout << &arr + 1 << std::endl;
	std::cout << *arr + 1 << std::endl;




	int number = 11;

	int* p_number = &number;

	std::cout << &number << std::endl;
	std::cout << p_number << std::endl;
	std::cout << &p_number << std::endl;

	int arr[3] = {1, 2, 3};

	std::cout << &arr[0] << " " << &arr << std::endl;
	std::cout << *(&arr[0]) << " " << *(&arr) << std::endl;



	int num1 = 0, num2 = 0;

	std::cout << "Enter first number: ";
	std::cin >> num1;

	std::cout << "Enter second number: ";
	std::cin >> num2;

	int* p_num1 = &num1;
	int* p_num2 = &num2;

	std::cout << *p_num1 + *p_num2 << std::endl;


	const int length = 5;
	int arr[length] = { 1, 2, 3, 4, 5 };

	for (int* i = arr; i < arr + length; i++)
	{
		std::cout << i;
	}

	// 03.08.2021 - NEW, DELETE, dynamic array, pointers


	int a = 5;

	int* p_a = &a;

	int* p_a2 = new int(5); // new - создает значение в куче.

	const int length = 5;

	int arr[length] = { 1, 2, 3, 4, 5 }; // хранится в стэке


	int length = 0;
	std::cin >> length; // Enter 5


	int* arr = new int[length]; // new creates my array in heap

	// * dereference operator, не путать с (int*) - pointer



	fill_arr(arr, length);
	print_arr(arr, length);


	int num1 = 5;
	int num2 = 5;

	int* p_num1 = &num1;
	int* p_num2 = &num2;


	//std::cout << addition2(num1, num2);

	std::cout << num1 << " " << num2 << std::endl;
	addition1(p_num1, p_num2);
	std::cout << num1 << " " << num2 << std::endl;

	std::cout << num1 << " " << num2 << std::endl;
	addition2(num1, num2);
	std::cout << num1 << " " << num2 << std::endl;


	std::cout << num1 << " " << num2 << std::endl;
	addition3(num1, num2);
	std::cout << num1 << " " << num2 << std::endl;

	return 0;
}

void addition1(int* n1, int* n2)
{
	*n1 = 0;
	*n2 = 100;
	std::cout << "Addition1 called" << std::endl;
}

void addition2(int n1, int n2)
{
	n1 = 0;
	n2 = 100;
	std::cout << "Addition2 called" << std::endl;
}

void addition3(int &n1, int &n2)
{
	n1 = 123;
	n2 = 123;
	std::cout << "Addition3 called" << std::endl;
}


void fill_arr(int* arr, int length)
{
	for (int* i = arr, counter = 0; i < arr + length; i++, counter++)
	{
		*i = counter + 1;
	}

}


void print_arr(int* arr, int length)
{
	for (int* i = arr; i < arr + length; i++)
	{
		std::cout << *i << " ";
	}
}

*/

#include <iostream>

void print_static_arr(int arr[], int length)
{
	for (int i = 0; i < length; i++)
	{
		std::cout << arr[i] << " ";
	}
	std::cout << std::endl;
}

void fill_static_arr(int arr[], int length)
{
	for (int i = 0; i < length; i++)
	{
		arr[i] = i + 1;
	}
}

void print_dynamic_arr(int* arr, int length)
{
	for (int i = 0; i < length; i++)
	{
		std::cout << *(arr + i) << " ";
	}
}

void fill_dynamic_arr(int* arr, int length)
{
	for (int i = 0; i < length; i++)
	{
		*(arr + i) = i + 1;
	}
}

int main()
{
	// Базовые понятия указателей 
	/*
	int num1 = 5;
	int* p_num1 = &num1;

	std::cout
		<< "Value of num1: " << num1 << '\n'
		<< "Value of &num1:" << &num1 << '\n'
		<< "Value of p_num1: " << p_num1 << '\n'
		<< "Value of *p_num1: " << *p_num1 << '\n'
		<< "Value of &p_num1: " << &p_num1 << '\n';
	*/

	// Понятие указателя на примере массива

	/*
	const int length = 3;

	int arr[length]; // static array

	std::cout
		<< "Value of arr is address of first element: " << arr << '\n'
		<< "Value of arr is address of second element: " << arr + 1 << '\n'
		<< "Start address of array.\nP.S.Expands to the first element address: " << &arr << '\n'
		<< "arr + length: " << arr + length << '\n'
		<< "&arr + 1: " << &arr + 1 << '\n'
		<< "arr[length + 1]: " << arr[length + 1] << '\n';
	*/

	/*
	for (int i = 0; i < length + 1; i++)
	{
		std::cout << arr + i<< " ";
	}
	std::cout << std::endl;

	std::cout << &arr + 1 << " " << *(arr + length) << std::endl;
	*/


	int length = 0;
	std::cout << "Enter length of your array: ";
	std::cin >> length;

	int* arr = new int[length];

	fill_dynamic_arr(arr, length);
	print_dynamic_arr(arr, length);

	int* arr2 = new int[length - 5];

	delete[]arr;

	return 0;
}