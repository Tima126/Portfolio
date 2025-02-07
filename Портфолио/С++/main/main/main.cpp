#include <iostream>
using namespace std;
#include"io.h"

int main()
{
	int num1 = readnumber();
	int num2 = readnumber();

	int sum = num1 + num2;
	writeAnswer(sum);

	int minus = num1 - num2;
	writeAnswer(minus);

	int umn = num1 * num2;
	writeAnswer(umn);
	if (num2 != 0)
	{
		int del = num1 / num2;
		writeAnswer(del);
	}
	else
	{
		cout << "Error" << endl;
	}
	return 0;
}

