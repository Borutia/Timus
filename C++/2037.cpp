#include <iostream>
#include <string>

char str[7] = "ababba";

std::string repeat(int p, int n)
{
    std::string s;
    for(int i = 0; i < n; )
    {
        for(int j = 0; j < p && i < n; i++, j++)
            s.push_back('a');
        for(int j = 0; j < 6 && i < n; i++, j++)
            s.push_back(str[j]);
    }
    return s;
}

std::string print(int n, int k)
{
    if(n == 8 && k == 7)
        return "aababbaa"; 
    if(n != k && k < 8)
        return "NO";
    if(k <= (n - 6)/2 + 6) 
        return "a" + repeat(k-8, n-1);
    return repeat(k-6, n); 
}                         

int main()
{
    int n;
    std::cin >> n;
    for(int k = 1; k <= n; k++)
        std::cout << k << " : " << print(n, k) << "\n";
}