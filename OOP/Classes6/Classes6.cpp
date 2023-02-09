#include <iostream>

class Person
{
public:
	Person() {  }

	Person(char* name, char* surname, int age)
	{
		this->name = name;
		this->surname = surname;
		this->age = age;
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


	bool operator == (const Person& right) const
	{
		if (strcmp(this->name, right.name) == 0)
		{
			return true;
		}
		else
		{
			return false;
		}
		return (this->age == right.age);
	}

	bool operator > (const Person& right) const
	{
		return (this->age > right.age);
	}

	bool operator < (const Person& right) const
	{
		return (this->age < right.age);
	}

	void print() const
	{
		std::cout
			<< "Name is: " << name << '\n'
			<< "Surname is: " << surname << '\n'
			<< "Age is: " << age << '\n';
	}

	
private:
	char* name;
	char* surname;
	int age;
};


std::ostream& operator <<(std::ostream& out, const Person& person)
{
	out << person.get_name() << ' ' << person.get_surname() << ' ' << person.get_age() << '\n';

	return out;
}

std::istream& operator >>(std::istream& in, Person& person)
{
	char* name = new char[1024]{};
	char* surname = new char[1024]{};
	int age{};

	std::cout << "Enter your name: ";
	gets_s(name, 1024);

	std::cout << "Enter your surname: ";
	gets_s(surname, 1024);

	std::cout << "Enter your age: ";
	std::cin >> age;

	person.set_name(name);
	person.set_surname(surname);
	person.set_age(age);

	return in;
}


void sortPeople(Person* people, int length)
{
	for (int i = 0; i < length + 1; i++)
	{
		for (int j = 0; j < length - 1; j++)
		{
			if (people[i] > people[i + 1])
			{
				std::swap(people[i], people[i + 1]);
			}
		}
	}
}

int main()
{
	/*Person p1(new char[] {"Elvin"}, new char[] {"Azimov"}, 19);
	Person p2(new char[] {"Emil"}, new char[] {"Moryakov"}, 15);
	Person p3(new char[] {"Kerim"}, new char[] {"Kalashov"}, 16);
	Person p4(new char[] {"Ilkin"}, new char[] {"Mammadli"}, 25);


	Person* arr = new Person[]{ p1, p2, p3, p4 };

	sortPeople(arr, 4);


	for (int i = 0; i < 4; i++)
	{
		arr[i].print();
	}*/

	/*
	 
	Person p2(new char[] {"Emil"}, new char[] {"Moryakov"}, 15);
	Person p3(new char[] {"Emil"}, new char[] {"Moryakov"}, 15);

	std::cout << (p2 == p3);

	std::cout << p2;
	 */


	Person p;

	std::cin >> p;
	std::cout << p;

	return 0;
}