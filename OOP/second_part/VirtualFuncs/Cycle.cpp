#include  "Cycle.h"
#include <iostream>

void Cycle::print() const
{
	std::cout
		<< "Cycle make: " << this->make << '\n'
		<< "Cycle model: " << this->model << '\n'
		<< "Cycle year: " << this->year << '\n'
		<< "Cycle type: " << this->cycle_type << '\n';
}

