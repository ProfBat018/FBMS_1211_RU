#include <iostream>

using namespace std;


float add(float num1, float num2)
{
	return num1 + num2;
}


float subtract(float num1, float num2)
{
	return num1 - num2;
}

void say_hello()
{
	std::cout << "Hello World" << std::endl;
	say_hello();
}


int main()
{

	void (*p_say) () = say_hello;

	char a = 'a';

	char* p_a = &a;
	


	float (*operation[2]) (float, float) = {add, subtract};

	std::cout << operation[0](5.5f, 2.2f);


	return 0;
}
