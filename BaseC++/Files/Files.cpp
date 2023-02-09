#include <iostream>
#include <cstdio>



int main()
{
	// r - read
	// w - write
	// a - append 



#pragma region Writing
	/*
	FILE* p_file_write;

	fopen_s(&p_file_write, "data2.txt", "w");

	if (p_file_write != nullptr)
	{
		fputs("Ilkin polucaet 1 ball", p_file_write);
	}

	if (p_file_write != nullptr)
	{
		fclose(p_file_write);
	}
	*/
#pragma endregion

#pragma region Reading
	/*
		FILE* p_file_read;
		fopen_s(&p_file_read, "data2.txt", "r");


		char* loaded_text = new char[1024]{};

		if (p_file_read != nullptr)
		{
			fgets(loaded_text, 1024, p_file_read);
		}

		std::cout << loaded_text;


		if (p_file_read != nullptr)
		{
			fclose(p_file_read);
		}
	*/
#pragma endregion 

#pragma region Append
	/*
	FILE* file;

	fopen_s(&file, "data2.txt", "a");

	if (file != nullptr)
	{
		fputs("Hello\nHello\nHello", file);
	}

	if (file != nullptr)
	{
		fclose(file);
	}

	k*/
#pragma endregion

#pragma region ReadingLines
	/*
	FILE* file;

	fopen_s(&file, "data2.txt", "r");

	char** loaded_text = new char* [2];

	loaded_text[0] = new char[1024]{};
	loaded_text[1] = new char[1024]{};


	if (file != nullptr)
	{
		for (size_t i = 0; i < 2; i++)
		{
			fgets(loaded_text[i], 1024, file);
		}
	}

	std::cout << loaded_text[0];
	std::cout << loaded_text[1];

	if (file != nullptr)
	{
		fclose(file);
	}
	*/
#pragma endregion

}



