#pragma once
#include "person.h"


class student : public person
{
	char* subject{};
public:

	char* get_subject() const
	{
		return this->subject;
	}

	void set_subject(char* subject)
	{
		this->subject = subject;
	}

	void ask_question();

};
