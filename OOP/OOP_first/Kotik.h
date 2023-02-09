#pragma once
#include <iostream>




struct Kotik // Структура типа - котик. 
{
private:
	char* name = new char[1024]{};
	char* breed = new char[1024]{};

public:

#pragma region NameProperty
	void SetName()
	{
		std::cout << "Enter cat name: " << std::endl;
		gets_s(name, 1024);
	}

	char* GetName()
	{
		return name;
	}
#pragma endregion

#pragma region BreedProperty
	void SetBreed()
	{
		std::cout << "Enter cat breed: " << std::endl;
		gets_s(breed, 1024);
	}

	char* GetBreed()
	{
		return breed;
	}

#pragma endregion 

	void print()
	{
		std::cout
			<< "Name is:\t" << GetName() << '\n'
			<< "Breed is:\t" << GetBreed() << '\n';
	}

	void add()
	{
		SetName();
		SetBreed();
	}
};