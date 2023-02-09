#include "Animal.h"
#include <iostream>


char* Animal::get_name() const
{
	return name;
}


bool Animal::get_is_predator() const
{
	return isPredator;
}


void Animal::set_name(char* name)
{
	this->name = name;
}


void Animal::set_is_predator(bool is_predator)
{
	isPredator = is_predator;
}


void Animal::print() const
{
	std::cout << name << '\n' << isPredator;
}


void Animal::eat(char* meal_name) const
{
	std::cout << name << ' ' << "is eating" << meal_name << '\n';
}
