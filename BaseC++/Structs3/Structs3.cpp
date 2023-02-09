#include <iostream>


struct Person
{
	char* name;
	char* surname;
	int age;

}*ptr_person;


void edit_person(Person &p);
void change_int(int& num);


int main()
{
	/*
	Person p1;
	Person p2;

	p1.age = 19;
	p1.name = new char[] {"Elvin"};
	p1.surname = new char[] {"Azimov"};

	p2.age = 16;
	p2.name = new char[] {"Ilkin"};
	p2.surname = new char[] {"Mammadli"};


	edit_person(p1);

	std::cout << p1.age << std::endl;
	*/

	int a = 0;
	change_int(a);
	std::cout << a;

	return 0;
}


void edit_person(Person &p)
{
	ptr_person = &p;
	
	ptr_person->age = 0;
	ptr_person->name = new char[] {"Test"};
	ptr_person->surname = new char[] {"Test"};
}



void change_int(int& num)
{
	int* p_num = &num;
	*p_num = 10;
}