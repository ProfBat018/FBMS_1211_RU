#include <iostream>

// Structures part 1
/*
struct Person
{
	char* name;
	char* surname;
	int age;
};
*/

// Structures part 2 - ÂÛĞÀÂÍÈÂÀÍÈÅ ÑÒĞÓÊÒÓĞ
/*
struct Person
{
	long long int id;		// 8 byte 
	int age;	// 8 byte
	char gender;// 1 byte
	char isAdult;// 1 byte
	char isPowerful;// 1 byte
	char isCurly;// 1 byte
	char isCool; // 1 byte

};
*/


// Structures part 3 - Âûğàâíèâàíèå ïî ïîğÿäêó

/*
struct Person
{
	float a1; 
	double a2;
	float a3; 
};
*/
// vs
/*
struct Person
{
	float a1;
	double a2;
	float a3;
};
*/



enum COLORS {RED, BLACK};

struct Car
{
	char* Make;
	char* Model;
	int Year;
	COLORS Car_Color;
};

Car add_car();
void print_car(Car car);


int main()
{

	// Structures part 1
	/*
	Person elvin;

	elvin.name = new char[] {"Elvin"};
	elvin.surname = new char[] {"Azimov"};
	elvin.age = 19;
	*/

	// Structures part 2 - ÂÛĞÀÂÍÈÂÀÍÈÅ ÑÒĞÓÊÒÓĞ
	/*
	Person person1;

	std::cout << sizeof(person1);
	*/

	// Structures part 3 - Âûğàâíèâàíèå ïî ïîğÿäêó
	/*
	Person p1;

	std::cout << sizeof(p1);
	*/


	


	Car car1 = add_car();
	print_car(car1);


	return 0;
}


Car add_car()
{
	Car tmp_car;

	char* make_input = new char[150]{};
	char* model_input = new char[150]{};
	int year_input;
	int color_input;

	std::cout << "Enter Make: ";
	gets_s(make_input, 150);

	std::cout << "Enter Model: ";
	gets_s(model_input, 150);

	std::cout << "Enter year: ";
	std::cin >> year_input;

	std::cout << "Enter Color: 1.Red\n2.Black\n";
	std::cin >> color_input;

	
	tmp_car.Make = make_input;
	tmp_car.Model = model_input;
	tmp_car.Year = year_input;
	tmp_car.Car_Color = (COLORS)color_input;

	return tmp_car;
}

void print_car(Car car)
{
	std::cout
		<< "Make is: " << car.Make << '\n'
		<< "Model is: " << car.Model << '\n'
		<< "Year is: " << car.Year << '\n'
		<< "Car color is: " << car.Car_Color << '\n';
}