#include <iostream>
#include "Bus.h"
#include "Cycle.h"
#include "Vehicle.h"


int main()
{
	Bus b(new char[] {"Man"}, new char[] {"Neoplan"}, 2016, 3.25);
	Cycle c(new char[] {"BSD"}, new char[] {"Alvx"}, 2021, Cycle::Type::BMX);


	b.print();
	c.print();

	return 0;
}
