#pragma once

class Animal
{
private:
	char* name;
	bool isPredator;
protected:
	int age;
public:

	Animal()
	{
		name = new char[] {"Cat"};
		isPredator = true;
	}

	Animal(char* name, bool isPredator)
	{
		this->name = name;
		this->isPredator = isPredator;
	}

	char* get_name() const;
	bool get_is_predator() const;
	void set_name(char* name);
	void set_is_predator(bool is_predator);

	virtual void print() const;
	void eat(char* meal_name) const;
};
