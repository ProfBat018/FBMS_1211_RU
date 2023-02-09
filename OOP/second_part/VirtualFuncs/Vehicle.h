#pragma once

class Vehicle
{
public: // getters & setters
	char* get_make() const { return make; }
	char* get_model() const { return model; }
	unsigned short get_year() const { return year; }

	void set_make(char* _make) { this->make = _make; }
	void set_model(char* _model) { this->model = _model; }
	void set_year(const unsigned short _year) { this->year = _year; }

public: // constructors
	Vehicle()
	{
		make = nullptr;
		model = nullptr;
		year = 0;
	}

	Vehicle(char* _make, char* _model, const unsigned short _year)
	{
		this->make = _make;
		this->model = _model;
		this->year = _year;
	}

public:
	virtual void print() const = 0;

protected: // fields
	char* make;
	char* model;
	unsigned short year;
};

