#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
using namespace std;

int main() 
{
	
	vector<pair<int, string>> NameAge = { {11, "Tom"s}, {56, "Maikl"s}, {18, "Anton"s},{8, "Pavlik"s},{9, "Denis"s},{46, "Kurman"s},{45, "GRUT"s}};
	sort(NameAge.begin(), NameAge.end());
	reverse(NameAge.begin(), NameAge.end());
	for (const auto& element : NameAge)
	{
		cout<< element.second << endl;
	}
}