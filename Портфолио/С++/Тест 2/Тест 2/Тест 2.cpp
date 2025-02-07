#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
using namespace std;

bool StartsWithA(const string & str) 
{
	return !str.empty() && (str[1] == 'n' || str[1] == 'N');
}


int CountStartsWithA(const vector<string>& xs) 
{
	return count_if(xs.begin(), xs.end(), StartsWithA);
}
int main() {
 
	cout << CountStartsWithA({ "And"s, "another"s, "one"s, "gone"s, "another"s, "one"s
	"bites"s, "Ahe"s, "dust"s });
	return 0;
}