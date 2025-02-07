#include <iostream>
#include <vector>
using namespace std;
void BubleSort(vector<int>& num);
void Print(vector<int>& num);


int main(){
	
	setlocale(LC_ALL, "ru");
	vector<int> user_num{ 12, 2145, 8, 4016, 4, 2, 1, 1000, 3, 10004, 10 ,15, 235, 6 };
	cout << "Отсортированый массив" << endl;
	BubleSort(user_num);
	Print(user_num);
	return 0;

}
void BubleSort(vector<int>& num) {
	for (int i = 0; i < num.size(); i++) {
		for (int j = 0; j < num.size() - 1 - i; j++) {
			if (num[j] > num[j + 1]) {
				int b = num[j];
				num[j] = num[j + 1];
				num[j + 1] = b;
			}
		}
	}
}

void Print(vector<int>& num) {
	
	for (int i = 0; i < 14; ++i){
		cout << num[i] << " ";
	}
}
