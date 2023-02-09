#include <iostream>

class Person
{
private:
	int count_detishek;
protected:
	char* name;
	char* surname;
	int age;
public:
	Person()
	{
		name = nullptr;
		surname = nullptr;
		age = 0;
		count_detishek = 0;
	}

	void print()
	{
		std::cout <<  name;
	}
};


class Child : public Person
{
public:
	void show()
	{
		print();
	}
};


int main()
{
    std::cout << "Hello World!\n";
}
