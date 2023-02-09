#include <iostream>
#include  "Animal.h"
#include  "Cat.h"

int main()
{
	Cat c1(new char[] {"Musviq"}, true, 6, 9);

	c1.print();

	return 0;
}
