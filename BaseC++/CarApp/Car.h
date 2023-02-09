#pragma once

enum COLORS { RED, GREEN, BLUE };
enum STAGE { Stage0 = 0,  Stage1, Stage2, Stage3, Stage4 };

struct Car
{
	COLORS color;
	STAGE tune_stage;
	char* make;
	char* model;
	unsigned int mileage;
	unsigned short year;
	unsigned short engine_volume;
	unsigned short HP;
	bool isTuned;

};


COLORS select_color();
Car add_car();
Car change_color(Car my_car);
Car tune_car(Car my_car);
void print_car(Car my_car);
char* print_color(COLORS color);
char* print_stage(STAGE car_stage);