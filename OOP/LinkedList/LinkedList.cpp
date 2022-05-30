#include <iostream>


/*

class LinkedList
{
public:
	int value;
	LinkedList* next;

	LinkedList();
	void print();
};


LinkedList::LinkedList()
{
	value = NULL;
	next = nullptr;
}


void LinkedList::print()
{
	std::cout << "Value is: " << value << '\n';
}


int main()
{
	LinkedList first;
	LinkedList second;


	first.value = 1;
	first.next = &second;

	second.value = 2;
	second.next = nullptr;


	first.print();
	second.print();


	return 0;
}
 */

/*
class Node
{
public:
	int value;
	Node* next;

	Node();
	void add_to_begin(Node** first_node, int value);
	void print(Node* node);
};


Node::Node()
{
	value = NULL;
	next = nullptr;
}


void Node::add_to_begin(Node** first_node, int value)
{
	Node* tmp_node = new Node();

	tmp_node->value = value;
	tmp_node->next = *first_node;
	*first_node = tmp_node;
}

void Node::print(Node* node) // second
{
	while (node != nullptr)
	{
		std::cout << node->value << ' ';
		node = node->next;
	}
}


int main()
{
	Node* head = new Node();
	Node* second = new Node();
	Node* tail = new Node();

	Node* new_head = new Node();


	head->value = 1;
	head->next = second;

	second->value = 2;
	second->next = tail;

	tail->value = 3;
	tail->next = nullptr;

	head->print(second);

	head->add_to_begin(&new_head, 15);

}
*/



class Node
{
public:
	int value;
	Node* next;

	Node();
	static void add_to_begin(Node** first_node, int value);
	static void print(Node* node);
};


Node::Node()
{
	value = NULL;
	next = nullptr;
}


void Node::add_to_begin(Node** first_node, int value)
{
	Node* tmp_node = new Node();

	tmp_node->value = value;
	tmp_node->next = *first_node;
	*first_node = tmp_node;
}

void Node::print(Node* node) // second
{
	while (node != nullptr)
	{
		std::cout << node->value << ' ';
		node = node->next;
	}
}


int main()
{
	Node* head = new Node();
	Node* second = new Node();
	Node* tail = new Node();

	Node* new_head = new Node();


	head->value = 1;
	head->next = second;

	second->value = 2;
	second->next = tail;

	tail->value = 3;
	tail->next = nullptr;

	Node::print(head);
}


