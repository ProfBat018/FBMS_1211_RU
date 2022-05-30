#pragma once
#include "Vehicle.h"

class Bus : Vehicle
{
public: // getters & setters
	void set_ride_price(float _ride_price) { this->ride_price = _ride_price; }
	float get_ride_price() const { return this->ride_price; }

public: // constructors
	Bus(char* _make, char* _model, const unsigned short _year, float _ride_price)
		: Vehicle(_make, _model, _year)
	{
		this->ride_price = _ride_price;
	}

public:
	void print() const override;

private:
		float ride_price;
};
