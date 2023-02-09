#pragma once
#include "Vehicle.h"



class Cycle : Vehicle
{
public:
	enum Type { Mountain = 1, Ride, BMX, Highway };

public: // getters & setters
	Type get_cycle_type() const { return this->cycle_type; }

	void set_cycle_type(Type cycle_type) { this->cycle_type = cycle_type; }

public: // constructors
	Cycle(char* _make, char* _model, const unsigned short _year, Type _cycle_type)
		: Vehicle(_make, _model, _year)
	{
		this->cycle_type = _cycle_type;
	}

public:
	void print() const override;

private:
	Type cycle_type;


};
