#pragma once

#include <iostream>
#include "Animal.h"


class Cat : public Animal
{
	int lives;
public:

	Cat(char* name, bool isPredator, int age, int lives) : Animal(name, isPredator)
	{
		this->age = age;
		this->lives = lives;
 	}
	void print() const override
	{
		std::cout << get_name() << '\n' << get_is_predator() << '\n' << age;
	}
};