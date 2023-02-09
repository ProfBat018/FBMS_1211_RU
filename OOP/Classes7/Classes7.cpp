#include <iostream>


class Integer
{
private:
	int i;
public:
	Integer() { i = 0; }

	void set_i(int i) { this->i = i; }
	int get_i() const { return this->i; }

	Integer& operator ++() // prefix
	{
		++(this->i);
		return *this;
	}

	Integer operator ++(int) // postfix
	{
		Integer temp;
		temp.i = (this->i)++;
		return temp;
	}
};


std::ostream& operator <<(std::ostream& out, const Integer& i)
{
	out << i.get_i();
	return out;
}

int main()
{
	Integer i;
	Integer j;

	/*
	std::cout << ++i;
	std::cout << ++i;
	std::cout << ++i;
	std::cout << ++i;
	*/

	std::cout << i++ << '\n';
	std::cout << i++ << '\n';

	std::cout << ++j << '\n';
	std::cout << ++j << '\n';
	return 0;
}
