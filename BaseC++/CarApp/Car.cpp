#include <iostream>
#include "Car.h"


COLORS select_color()
{
	int choice = 0;

	std::cout
		<< "Select color: " << '\n'
		<< '\t' << "1. RED" << '\n'
		<< '\t' << "2. GREEN" << '\n'
		<< '\t' << "3. BLUE" << '\n';

	std::cin >> choice;

	switch (choice)
	{
	case 1:
		return COLORS::RED;
		break;
	case 2:
		return COLORS::GREEN;
		break;
	case 3:
		return COLORS::BLUE;
		break;
	default:
		select_color();
		break;
	}
}


Car add_car()
{
	std::cin.ignore();

	Car tmp_car; // объект структуры Car


	tmp_car.tune_stage = STAGE::Stage0;
	tmp_car.mileage = 0;

	tmp_car.make = new char[1024]{};
	tmp_car.model = new char[1024]{};

	std::cout << "Enter car make: ";
	gets_s(tmp_car.make, 1024);

	std::cout << "Enter car model: ";
	gets_s(tmp_car.model, 1024);


	std::cout << "Select color: ";
	tmp_car.color = select_color();

	std::cout << "Enter HP: ";
	std::cin >> tmp_car.HP;

	std::cout << "Enter engine volume: ";
	std::cin >> tmp_car.engine_volume;

	std::cout << "Enter year: ";
	std::cin >> tmp_car.year;

	std::cout
		<< "Enter 1 if Tuned " << '\n'
		<< "Else enter 0: ";

	std::cin >> tmp_car.isTuned;

	return tmp_car;
}


Car tune_car(Car my_car)
{



	return my_car;
}


void print_car(Car my_car)
{
	std::cout
		<< "Info..." << '\n'
		<< '\t' << "Car Make : " << my_car.make << '\n'
		<< '\t' << "Car Model : " << my_car.model << '\n'
		<< '\t' << "Car HP: " << my_car.HP << '\n'
		<< '\t' << "Car Year: " << my_car.year << '\n'
		<< '\t' << "Car Engine volume: " << my_car.engine_volume << '\n'
		<< '\t' << "Car mileage: " << my_car.mileage << '\n'
		<< '\t' << "Color: " << print_color(my_car.color) << '\n'
		<< '\t' << "Stage: " << print_stage(my_car.tune_stage) << '\n';
		
	if (my_car.isTuned)
		std::cout << '\t' << "Tuned: Yes" << std::endl;
	else
		std::cout << '\t' << "Tuned: NO" << std::endl;
}


char* print_color(COLORS color)
{
	char* result;

	switch (color)
	{
	case RED:
		result = new char[] {"RED"};
		break;
	case GREEN:
		result = new char[] {"GREEN"};
		break;
	case BLUE:
		result = new char[] {"BLUE"};
		break;
	default:
		result = new char[] {"NO COLOR..."};
		break;
	}
	return result;
}


char* print_stage(STAGE stage)
{
	char* result;

	switch (stage)
	{
	case Stage0:
		result = new char[] {"Stage 0"};
		break;
	case Stage1:
		result = new char[] {"Stage 1"};
		break;
	case Stage2:
		result = new char[] {"Stage 2"};
		break;
	case Stage3:
		result = new char[] {"Stage 3"};
		break;
	case Stage4:
		result = new char[] {"Stage 4"};
		break;
	default:
		result = new char[] {"Stage 0"};
		break;
	}

	return result;
}


