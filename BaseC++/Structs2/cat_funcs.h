#pragma once

enum CAT_COLOR { Smoke, White, Red_Tabby, Silver_Tabby, Red_Point, Silver_Shaded };

struct Cat
{
	char* name;
	char* breed;
	int age;
	CAT_COLOR color;
};


CAT_COLOR select_color(int color);
Cat add_cat();
Cat edit_cat(Cat kotik);
void print_cat(Cat kotik);
void print_color(CAT_COLOR color);
char* change_name();
char* change_breed();
int change_age();


