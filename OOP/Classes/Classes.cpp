#include <iostream>

class person
{
	int id;
	char* name;
	char* surname;
public:

	person() // default constructor
	{
		static int count = 0;
		std::cout << "Constructor without params" << std::endl;

		id = count++;
		name = new char[] {"Elvin"};
		surname = new char[] {"Azimov"};
	}

	//Person(char* _name)
	//{
	//	std::cout << "Constructor with only name param" << std::endl;
	//	name = _name;
	//	surname = new char[] {"Default surname"};
	//} 

	person(char* _name, char* _surname)
	{
		std::cout << "Constructor with params" << std::endl;
		name = _name;
		surname = _surname;
	}


#pragma region Setters

	void setName(char* _name)
	{
		name = _name;
	}

	void setSurName(char* _surname)
	{
		surname = _surname;
	}

#pragma endregion

#pragma region Getters
	char* getName()
	{
		return name;
	}

	char* getSurName()
	{
		return surname;
	}

	int getId()
	{
		return id;
	}
#pragma endregion
};



//struct Person1
//{
//	char* name;
//	char* surname;
//public:
//
//	void setName(char* _name)
//	{
//		name = _name;
//	}
//
//	char* getName()
//	{
//		return name;
//	}
//
//	void setSurName(char* _surname)
//	{
//		surname = _surname;
//	}
//
//	char* getSurName()
//	{
//		return surname;
//	}
//};
//
//
//struct Student1 : Person1
//{
//
//};

int main()
{
	//Person p1(new char[] {"Elvin"}, new char[] {"Azimov"});
	//Person p2(new char[] {"Elvin"});
	
	/*
	Person* p = new Person;

	std::cout << p->getName() << std::endl; // Elvin

	p->setName(new char[] {"Samir"}); // Samir

	std::cout << p->getName(); // Samir
	*/

	person arr[2];

	std::cout << arr[0].getId() << std::endl;
	std::cout << arr[1].getId() << std::endl;
	
	/*
	Person p1; // инициализация объекта класса p1

	std::cout << "Enter your name: ";

	char* name = new char[1024]{};

	p1.setName(gets_s(name, 1024)); // Вызов сеттера

	std::cout << p1.getName(); // Вызов геттера
	*/

	return 0;
}



