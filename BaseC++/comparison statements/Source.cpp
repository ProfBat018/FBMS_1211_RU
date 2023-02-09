#include <iostream>

using namespace std;

// ctrl + k + d beautify your code.

int main()
{
	/*
	// if - если
	// else if - иначе если
	// else - иначе
	// { - begin
	// } - end
	// можно писать без {} если внутри условия всего одна строка.

	if (true) // будет работать, потому что всегда true при работе программы.
	{
		cout << "Hello World" << endl;
	}

	if (false) // будет работать, потому что всегда true при работе программы.
		cout << "Hello World" << endl;
	*/

	/*
	int num = 2;

	if (num == 2)
	{
		cout << 2; // 2
	}
	else if (num == 3)
	{
		cout << 3; // no
	}
	else if (num == 4)
	{
		cout << 4; // no
	}
	else
	{
		cout << 1; // no
	}


	if (num == 2)
	{
		cout << 2; // 2
	}
	if (num == 3)
	{
		cout << 3; // no
	}
	if (num == 4)
	{
		cout << 4; // no
	}
	else
	{
		cout << 1; // 1
	}

	*/

	/*
	// ? - if
	// : - else
	int test = 3;

	cout << (test % 2 == 0 ? "Yes" : (test == 1 ? "Hello" : (test == 3 ? "3" : "-3"))) << endl;


	int test2 = 3;

	if (test % 2 == 0)
	{
		cout << "Yes";
	}
	else
	{
		if (test == 1)
		{
			cout << "Hello";
		}
		else
		{
			if (test == 3)
			{
				cout << "3";
			}
			else
			{
				cout << "-3";
			}
		}
	}


	if (test % 2 == 0)
	{
		cout << "Yes";
	}
	else if (test == 1)
	{
		cout << "Hello";
	}
	else if (test == 3)
	{
		cout << "3";
	}
	else
	{
		cout << "-3";
	}

	*/

	/*

	int first_number = 0, second_number = 0;
	int result = 0;

	cout << "Enter your first number: ";
	cin >> first_number;

	cout << "Enter your second number: ";
	cin >> second_number;

	result = first_number + second_number;

	if (result > 0 && result % 2 == 0) // && - and, || - or
	{
		cout << "Positive and even" << endl;
	}
	else if (result > 0 && result % 2 != 0)
	{
		cout << "Positive and odd" << endl;
	}
	else if (result == 0)
	{
		cout << "Equal to zero" << endl;
	}
	else
	{
		cout << "Negative" << endl;
	}
	*/

	/*
		int a = 2;

		switch (a)
		{
			case 1: // True or False
				cout << "1";
				break;
			case 2:
				cout << "2";
				break;
			case 3:
				cout << "3";
				break;
			case 4:
				cout << "4";
				break;
		}

	

			int first_number = 0, second_number = 0, result = 0, choice = 0;
			bool success = true;

			cout << "Enter first number: ";
			cin >> first_number;

			cout << "Enter second number: ";
			cin >> second_number;

			cout << "1. Addition" << '\n'
				<< "2. Subtraction" << '\n'
				<< "3. Multiplication" << '\n'
				<< "4. Division" << '\n';
			cin >> choice;


			switch (choice)
			{
			case 1:
				result = first_number + second_number;
				break;
			case 2:
				result = first_number - second_number;
				break;
			case 3:
				result = first_number * second_number;
				break;
			case 4:
				result = first_number / second_number;
				break;
			default:
				cout << "Error" << endl;
				success = false;
				break;
			}

			if (success)
			{
				cout << "Your result is: " << result;
			}


		*/

	/*char a = 'a';

	switch (a)
	{
	case 'a':
		cout << 'a';
		break;
	case 'b':
		cout << 'b';
		break;
	}*/

	/*
		float a = 3.25;

		switch ((int)a) // не работает, так как switch работает только с интегральными типами данных.
		{
		case 3:
			cout << 3.25;
			break;
		case 4:
			cout << 4.25;
			break;
		}
	*/

	/*
		bool a = true;

		switch (a)
		{
		case true:
			cout << "true";
			break;
		case false:
			cout << "false";
			break;
		}
	*/


	// if, else if, else - condition 
	// switch - state(то есть это состяение) switch statements
	// любое константное значение, которое вы присваете - это литерал.
	//int k = 0; // 0 - literal 
	//const int a = 0;
	// компилятор заранее знает, где какие литералы. То есть все значения нашего switch
	//switch (k) // /переключатель, тоже относится к условаиям. При этом как таковой проверкой он не занимается.
	//{
	//case 0:
	//	cout << k;
	//	break;
	//case 1: // k == 1 
	//	cout << "1";
	//	break;
	//case 2:
	//	cout << "2";
	//	break;
	//case 3:
	//	cout << "3";
	//	break;
	//default:
	//	cout << "Error";
	//	break;
	//}


	return 0;
}