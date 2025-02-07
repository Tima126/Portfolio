#include <iostream>
using namespace std;
int readnumber()
{
	cout << "Numbers:";
	int num;
	cin >> num;
	return num;
}

void writeAnswer(int result)
{
	if (result > 10)
	{
		result -= 10;
	}
	else if (result == 10)
	{

	}
	else
	{
		result += 10;
	}
	cout << " " << result;
}