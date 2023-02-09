#include "person.h"

#include <iostream>


void person::eat(char* meal) const
{
	std::cout << "Person eats: " << meal << "\n";
}

void person::print() const
{
	std::cout
	<< this->name << '\n'
	<< this->surname << '\n'
	<< this->age << '\n';
}

