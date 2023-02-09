#include <iostream>


class Person
{
public:

	int get_id() const { return id; }

	void set_id(int id) { this->id = id; }

	char* get_name() const { return name; }

	void set_name(char* name) { this->name = name; }

	char* get_surname() const { return surname; }

	void set_surname(char* surname) { this->surname = surname; }

	int get_age() const { return age; }

	void set_age(int age) { this->age = age; }

	void print() const
	{
		std::cout
			<< this->id << ' ' << this->name << ' ' << this->surname << ' ' << this->age << '\n';
	}

public:
	Person(char* name, char* surname, int age)
	{
		static int counter = 0;

		this->id = ++counter;
		this->name = name;
		this->surname = surname;
		this->age = age;
	}

	Person(const Person& other)
	{
		this->id = other.id + 1;
		this->name = other.name;
		this->surname = other.surname;
		this->age = other.age;
	}
private:
	int id;
	char* name;
	char* surname;
	int age;
};

int main()
{
	Person p1(new char[] {"Elvin"}, new char[] {"Azimov"}, 19);

	Person p2 = p1;


	std::cout << &p1 << ' ' << &p2;

	p1.print(); // 1 Elvin Azimov 19
	p2.print(); // 1 Elvin Azimov 19



	return 0;
}
