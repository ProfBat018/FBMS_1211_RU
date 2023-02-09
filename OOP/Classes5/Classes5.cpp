#include <iostream>


class Integer
{
private:
	int i;
public:
	Integer(int i)
	{
		this->i = i;
	}

	int GetInteger() const
	{
		return this->i;
	}

	int Addition(const Integer& i2) const
	{
		return this->i + i2.i;
	}


	int operator +(const Integer& i2) const
	{
		return this->i + i2.i;
	}

	int operator -(const Integer& i2) const
	{
		return this->i - i2.i;
	}


	int operator *(const Integer& i2) const
	{
		return this->i * i2.i;
	}

	int operator /(const Integer& i2) const
	{
		return this->i / i2.i;
	}

	bool operator ==(const Integer& i2) const
	{
		return this->i == i2.i ? true : false;
	}
};


int main()
{
	Integer a1(1);
	Integer a2(2);

	std::cout << a1.Addition(a2) << std::endl;
	std::cout << a1 + a2 << std::endl;
	std::cout << (a1 == a2) << std::endl;


	return 0;
}
