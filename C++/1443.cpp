#include <stdio.h>

int main()
{
    int N; 
    double s, l;
    scanf("%d %lf %lf", &N, &s, &l);
    int S = (s+1e-8)*10000, L = (l+1e-8)*10000;
    printf("%d", S/L*N + (S%L ? N/(L/(S%L)) + bool(N%(L/(S%L))) : 0));
}