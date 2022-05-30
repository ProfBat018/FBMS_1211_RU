#include <iostream>
#include "Bus.h"

void Bus::print() const
{
	std::cout
		<< "Bus make: " << this->make << '\n'
		<< "Bus model: " << this->model << '\n'
		<< "Bus year: " << this->year << '\n'
		<< "Bus ride cost: " << this->ride_price << '\n';
}

