#include <iostream>
#include <vector>
#include <cmath>

using namespace std;

double min3(double a, double b, double c) {
    return min(a, min(b, c));
}

int main() {
    int n, m, k;
    cin >> n >> m >> k;
    ++n, ++m;
    vector<double> diag(n * m, 999999999.9);
    vector<double> dp(n * m);
    for (int i = 0; i < k; ++i) {
        int r, c;
        cin >> c >> r;
        diag[(r - 1) * n + c - 1] = sqrt(2.0) * 100.0;
    }
    for (int i = 0; i < m; ++i) {
        for (int j = 0; j < n; ++j) {
            if (i == 0)
                dp[i * n + j] = j * 100.0;
            else if (j == 0)
                dp[i * n + j] = i * 100.0;
            else
                dp[i * n + j] = min3(
                    100.0 + dp[i * n + j - 1],
                    100.0 + dp[(i - 1) * n + j],
                    diag[(i - 1) * n + j - 1] + dp[(i - 1) * n + j - 1]
                );
        }
    }
    cout << round(dp.back());
    return 0;
}