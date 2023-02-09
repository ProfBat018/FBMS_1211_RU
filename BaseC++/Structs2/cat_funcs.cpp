#include "cat_funcs.h"
#include <cstdio>
#include <iostream>


CAT_COLOR select_color()
{
	int color = 0;

	std::cout
		<< "Select color of cat: " << '\n'
		<< '\t' << "1. Smoke " << '\n'
		<< '\t' << "2. White " << '\n'
		<< '\t' << "3. Red_Tabby " << '\n'
		<< '\t' << "4. Silver_Tabby " << '\n'
		<< '\t' << "5. Red_Point " << '\n'
		<< '\t' << "6. Silver_Shaded " << '\n';

	std::cin >> color;

	switch (color)
	{
	case 1:
		return CAT_COLOR::Smoke;
		break;
	case 2:
		return CAT_COLOR::White;
		break;
	case 3:
		return CAT_COLOR::Red_Tabby;
		break;
	case 4:
		return CAT_COLOR::Silver_Tabby;
		break;
	case 5:
		return CAT_COLOR::Red_Point;
		break;
	case 6:
		return CAT_COLOR::Silver_Shaded;
		break;
	default:
		std::cout << "Error, try again..." << '\n';
		select_color();
		break;
	}
}


Cat add_cat()
{
	std::cin.ignore();

	Cat tmp_cat;

	tmp_cat.age = 0;
	tmp_cat.name = new char[1024]{};
	tmp_cat.breed = new char[1024]{};

	std::cout << "Enter cat name: ";
	gets_s(tmp_cat.name, 150);

	std::cout << "Enter cat breed: ";
	gets_s(tmp_cat.breed, 150);

	std::cout << "Enter cat age: ";
	std::cin >> tmp_cat.age;

	tmp_cat.color = select_color();

	return tmp_cat;
}


Cat edit_cat(Cat kotik)
{
	std::cin.ignore();

	int choice = 0;

	std::cout
		<< "Enter change parameter" << '\n'
		<< '\t' << "1. Name" << '\n'
		<< '\t' << "2. Breed" << '\n'
		<< '\t' << "3. Age" << '\n'
		<< '\t' << "4. Color" << '\n';

	std::cin >> choice; 

	switch (choice)
	{
	case 1:
		kotik.name = change_name();
		break;
	case 2:
		kotik.breed = change_breed();
		break;
	case 3:
		kotik.age = change_age();
		break;
	case 4:
		kotik.color = select_color();
		break;
	default:
		std::cout << "Error, try again...";
		edit_cat(kotik);
		break;
	}
	return kotik;

}


char* change_name()
{
	std::cin.ignore();

	char* tmp_name = new char[1024]{};
	std::cout << "Enter cat name: ";
	gets_s(tmp_name, 1024);

	return tmp_name;

}


char* change_breed()
{
	std::cin.ignore();

	char* tmp_breed = new char[1024]{};
	std::cout << "Enter cat breed: ";
	gets_s(tmp_breed, 1024);

	return tmp_breed;

}


int change_age()
{
	int tmp_age = 0;

	std::cout << "Enter cat age: ";
	std::cin >> tmp_age;


	return tmp_age;
}


void print_cat(Cat kotik)
{
	std::cout
		<< "Kotik name: " << kotik.name << '\n'
		<< "Kotik breed: " << kotik.breed << '\n'
		<< "Kotik age: " << kotik.age << '\n';

	std::cout << "Kotik color: ";
	print_color(kotik.color);
	std::cout << std::endl;
}


void print_color(CAT_COLOR color)
{
	switch (color)
	{
	case Smoke:
		std::cout << "Smoke" << '\n';
		break;
	case White:
		std::cout << "White" << '\n';
		break;
	case Red_Tabby:
		std::cout << "Red_Tabby" << '\n';
		break;
	case Silver_Tabby:
		std::cout << "Silver_Tabby" << '\n';
		break;
	case Red_Point:
		std::cout << "Red_Point" << '\n';
		break;
	case Silver_Shaded:
		std::cout << "Silver_Shaded" << '\n';
		break;
	default:
		break;
	}
}

