
#include <iostream>
#include "Constant.h"
using namespace std;


double calcul(double seconds)
{
	using namespace Constants;
	return gravity * seconds * seconds;
}



int main()
{	setlocale(LC_ALL, "Russian");
	double tower;
	cout << "Введи высоту башни";
	cin >> tower;

	if (tower <= 0) 
	{
		cout << "Ошибка высота не может быть меньше или ровна нулю";
			return 1;
	}

	for (double seconds = 0.0; seconds <= 1000; seconds++)
	{
		double hig = tower - calcul(seconds);
		
		if (hig <= 0)
		{
			hig = 0;
		}

		cout<<"После:"<<" " << seconds << " " << "секунд падения мячик находится на высоте :" <<" "<< hig <<" "<< "метров" << endl;

		if (hig == 0)
		{
			cout << "За"<< " " << seconds << " " << "секунды мячик окозался на земле " << endl;
			break;
		}
		


	}
	return 0;
	cout << "Падение завершино";


	
}

