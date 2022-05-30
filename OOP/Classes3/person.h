#pragma once


class person
{

public:

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

	void print() const;

	void eat(char* meal) const;

private:
	char* name{};
	char* surname{};
	int  age{};
};
