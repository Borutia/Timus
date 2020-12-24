#include <iostream>
#include <stdio.h>
#include <cmath>
using namespace std;

int main() {
	int n;
	cin >> n;
	double ans = log10(2)*(n - 1);
	if (n % 2 == 0) {
		ans += log10(2);
	}
	cout << floor(ans) << endl;

	return 0;
}