#include <iostream>
#include "cat_funcs.h"
#include <math.h>

int main()
{
	
	int length = 0;
	int choice = 0;

	std::cout << "Enter count of cats: ";
	std::cin >> length;

	Cat* kotiki = new Cat[length]{};

	
	for (int i = 0; i < length; i++)
	{
		kotiki[i] = add_cat();
	}

	for (int i = 0; i < length; i++)
	{
		std::cout << i + 1;
		print_cat(kotiki[i]);
	}

	std::cout << "Select cat you want to edit: ";
	std::cin >> choice;


	kotiki[choice] = edit_cat(kotiki[choice]);

	for (int i = 0; i < length; i++)
	{
		std::cout << i + 1;
		print_cat(kotiki[i]);
	}

	return 0;
}
