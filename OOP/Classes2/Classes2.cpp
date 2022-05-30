#include <iostream>

// this - обращается к объекту класса и работает с его данными. 
// inspector, mutator, modificator, accessor  

// mutator - изменяет данные, добавляет что-то в объект
// inspector - берет данные , не может делать изменения
// modificator - static, const и т.д. и т.п.
// accessor - public, private, protected


struct my_struct
{
	int a;
	char b;
	char c;
	my_struct* d;
};


class person
{
	int id{};
	char* name{};
	char* surname{};
	int age{};

public:
	person() // Default ctor
	{
		static int counter = 0;
		this->id = ++counter;
	}

	person(char* name, char* surname, int age) : person()
	{
		this->name = name;
		this->surname = surname;
		this->age = age;
	}

	person(const person &copy_person)
	{
		this->id = copy_person.id;
		this->name = copy_person.name;
		this->surname = copy_person.surname;
		this->age = copy_person.age;
	}

	~person()
	{
		std::cout << "Desctructor called" << std::endl;
		delete this->name;
		delete this->surname;

	}

	int get_id()
	{
		return id;
	}

	char* get_name() const
	{
		return name;
	}

	void set_name(char* name)
	{
		this->name = name;
	}

	char* get_surname() const
	{
		return surname;
	}

	void set_surname(char* surname)
	{
		this->surname = surname;
	}

	int get_age() const
	{
		return age;
	}

	void set_age(int age)
	{
		this->age = age;
	}

	void print() const
	{
		std::cout
			<< "Id is: " << this->id << std::endl
			<< "Name is: " << this->name << std::endl
			<< "Surname is: " << this->surname << std::endl
			<< "Age is: " << this->age << std::endl;
	}
};


int main()
{
	person p1(new char[] {"Elvin"}, new char[] {"Azimov"}, 19); // p1 - объект класса person. 

	/*

	int a = 0;

	if (a == 0)
	{
		person p2(new char[] {"Ilkin"}, new char[] {"Mammadli"}, 12); // p1 - объект класса person.
	}
	*/

	person p2 = p1;

	p2.print();

	return 0;
}